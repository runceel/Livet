using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;

namespace LivetControlBindingSupportGenerator
{
    internal class Program
    {
        private static bool TypeFilter(Type t)
        {
            return t != null
                   && (t.IsSubclassOf(typeof(FrameworkElement)) || t == typeof(FrameworkElement))
                   && !t.IsAbstract
                   && !t.IsGenericType
                   && t.IsPublic;
        }

        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            var assemblies =
                new[]
                    {
                        "PresentationCore",
                        "PresentationFramework",
                        "WindowsBase",
                        "ReachFramework"
                    }.Select(name =>
                        {
                            var assemblyName = typeof(FrameworkElement).Assembly.GetName().Clone() as AssemblyName
                                               ?? throw new InvalidOperationException();
                            assemblyName.Name = name;
                            assemblyName.SetPublicKey(typeof(FrameworkElement).Assembly.GetName().GetPublicKey());
                            assemblyName.ProcessorArchitecture = ProcessorArchitecture.None;
                            return assemblyName;
                        }
                    ).Concat(
                        new[]
                        {
                            "System.Xaml",
                            "System.Windows.Presentation"
                        }.Select(name =>
                            {
                                var assemblyName = typeof(object).Assembly.GetName().Clone() as AssemblyName
                                                   ?? throw new InvalidOperationException();
                                assemblyName.Name = name;
                                assemblyName.ProcessorArchitecture = ProcessorArchitecture.None;
                                return assemblyName;
                            }
                        )
                    ).Select(Assembly.Load)
                    .Select(a =>
                    {
                        Console.WriteLine(a);
                        return a;
                    })
                    .ToArray();

            var targetTypes = assemblies.SelectMany(assembly => assembly?.GetTypes().Where(TypeFilter));

            var typeInformations = targetTypes.ToList().Select(t => new TypeInformation(t)).ToList();

            if (!Directory.Exists("Output")) Directory.CreateDirectory("Output");

            var generatedTypeList = new List<string>();

            typeInformations.ForEach(t =>
            {
                if (t == null) throw new ArgumentNullException(nameof(t));

                if (t.GetterHavingTargetProperties.Any())
                {
                    var result = new SetStateToSourceAction
                            {TypeName = t.TypeName, GetterHavingTargetProperties = t.GetterHavingTargetProperties}
                        .TransformText();

                    generatedTypeList.Add(t.TypeName + "SetStateToSourceAction");

                    File.WriteAllText("Output\\" + t.TypeName + "SetStateToSourceAction.generated.cs", result);

                    Console.WriteLine(t.TypeName + "SetStateToSourceAction Generated !");
                }

                // ReSharper disable once InvertIf
                if (t.SetterHavingTargetProperties.Any())
                {
                    var result = new SetStateToControlBehavior
                            {TypeName = t.TypeName, SetterHavingTargetProperties = t.SetterHavingTargetProperties}
                        .TransformText();

                    generatedTypeList.Add(t.TypeName + "SetStateToControlBehavior");

                    File.WriteAllText("Output\\" + t.TypeName + "SetStateToControlBehavior.generated.cs", result,
                        Encoding.UTF8);

                    Console.WriteLine(t.TypeName + "SetStateToControlBehavior Generated !");
                }
            });

            var metaDataResult = new MetaData {GeneratedTypeNames = generatedTypeList}.TransformText();

            File.WriteAllText("MetaData.generated.cs", metaDataResult, Encoding.UTF8);

            Console.WriteLine("MetaData Generated !");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}