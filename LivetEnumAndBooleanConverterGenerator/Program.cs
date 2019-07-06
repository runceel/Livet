using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Reflection;
using System.IO;

namespace LivetEnumAndBooleanConverterGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var assemblies =
                new[]
                {
                    "PresentationCore",
                    "PresentationFramework",
                    "WindowsBase"
                }.Select(name =>
                {
                    var assemblyName = typeof(FrameworkElement).Assembly.GetName().Clone() as AssemblyName;
                    assemblyName.Name = name;
                    assemblyName.SetPublicKey(typeof(FrameworkElement).Assembly.GetName().GetPublicKey());
                    assemblyName.ProcessorArchitecture = ProcessorArchitecture.None;
                    return assemblyName;
                }
                ).Select(Assembly.Load)
                .Select(a => { Console.WriteLine(a); return a; })
                .ToArray();

            var enumsT4 = assemblies.SelectMany(a => a.GetTypes())
                .Where(t => t.IsEnum && t.IsPublic)
                .Select(t => new EnumToBooleanConverter() { TypeName = t.Name,EnumMemberNames = t.GetEnumNames()});

            if (!Directory.Exists("Output"))
            {
                Directory.CreateDirectory("Output");
            }

            foreach (var enumT4 in enumsT4)
            {
                var result = enumT4.TransformText();
                File.WriteAllText("Output\\" + enumT4.TypeName + "AndBooleanConverter.generated.cs", result, Encoding.UTF8);

                Console.WriteLine(enumT4.TypeName + "AndBooleanConverter Generated !");
            }
        }
    }
}
