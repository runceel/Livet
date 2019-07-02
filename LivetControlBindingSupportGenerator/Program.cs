using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Reflection;
using System.IO;

namespace LivetControlBindingSupportGenerator
{
    class Program
    {

        private static Func<Type, bool> typeFilter =
            t => t.IsSubclassOf(typeof(FrameworkElement)) && !t.IsAbstract && !t.IsGenericType && t.IsPublic;

        static void Main(string[] args)
        {
            var assemblies =
                new[]
                {
                    "PresentationCore",
                    "PresentationFramework",
                    "WindowsBase",
                    "ReachFramework",
                }.Select( name =>
                    {
                        var assemblyName = typeof(FrameworkElement).Assembly.GetName().Clone() as AssemblyName;
                        assemblyName.Name = name;
                        assemblyName.SetPublicKey(typeof(FrameworkElement).Assembly.GetName().GetPublicKey() );
                        assemblyName.ProcessorArchitecture = ProcessorArchitecture.None;
                        return assemblyName;
                    }
                ).Concat(
                    new[]
                    {
                        "System.Xaml",
                        "System.Windows.Presentation"
                    }.Select( name =>
                        {
                            var assemblyName = typeof(object).Assembly.GetName().Clone() as AssemblyName;
                            assemblyName.Name = name;
                            assemblyName.ProcessorArchitecture = ProcessorArchitecture.None;
                            return assemblyName;
                        }
                    )
                ).Select(Assembly.Load)
                .Select( a => { Console.WriteLine( a ); return a; } )
                .ToArray();

            var targetTypes = assemblies.SelectMany(assembly => assembly.GetTypes().Where(typeFilter));

            var typeInformations = targetTypes.ToList().Select(t => new TypeInformation(t)).ToList();

            if (!Directory.Exists("Output"))
            {
                Directory.CreateDirectory("Output");
            }

            List<string> generatedTypeList = new List<string>();

            typeInformations.ForEach(t =>
                {
                    if (t.GetterHavingTargetProperties.Any())
                    {
                        var result = new SetStateToSourceAction() 
                        { TypeName = t.TypeName, GetterHavingTargetProperties = t.GetterHavingTargetProperties }
                        .TransformText();

                        generatedTypeList.Add(t.TypeName + "SetStateToSourceAction");

                        File.WriteAllText("Output\\" + t.TypeName + "SetStateToSourceAction.generated.cs", result);

                        Console.WriteLine(t.TypeName + "SetStateToSourceAction Generated !");
                    }

                    if (t.SetterHavingTargetProperties.Any())
                    {
                        var result = new SetStateToControlBehavior() 
                        { TypeName = t.TypeName, SetterHavingTargetProperties = t.SetterHavingTargetProperties }
                        .TransformText();

                        generatedTypeList.Add(t.TypeName + "SetStateToControlBehavior");

                        File.WriteAllText("Output\\" + t.TypeName + "SetStateToControlBehavior.generated.cs", result, Encoding.UTF8);

                        Console.WriteLine(t.TypeName + "SetStateToControlBehavior Generated !");
                    }
                });

            var metaDataResult = new MetaData() { GeneratedTypeNames = generatedTypeList }.TransformText();

            File.WriteAllText("MetaData.generated.cs", metaDataResult,Encoding.UTF8);

            Console.WriteLine("MetaData Generated !");

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
