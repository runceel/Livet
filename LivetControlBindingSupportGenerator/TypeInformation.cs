using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;
using Livet.Annotations;

namespace LivetControlBindingSupportGenerator
{
    public class TypeInformation
    {
        public TypeInformation(Type t)
        {
            if (t == null) throw new ArgumentNullException(nameof(t));

            TypeName = t.Name;

            DependencyPropertyNames = t.GetFields(
                    BindingFlags.Static |
                    BindingFlags.Public |
                    BindingFlags.FlattenHierarchy)
                .Where(p => p.FieldType == typeof(DependencyProperty))
                .Select(p => p.Name.Replace("Property", string.Empty));

            var targetProperties = t
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .Where(
                    p =>
                        (!DependencyPropertyNames.Contains(p.Name) || DependencyPropertyNames.Contains(p.Name)
                         && p.GetSetMethod(false) == null)
                        && p.Name != "Content"
                        && p.PropertyType.Namespace != null
                        && !p.PropertyType.Namespace.StartsWith("System.Windows")
                        && !p.PropertyType.IsGenericType
                        && !p.GetCustomAttributes(typeof(ObsoleteAttribute), true).Any())
                .ToList();

            GetterHavingTargetProperties =
                targetProperties
                    .Where(p => p?.GetGetMethod(false) != null)
                    .ToDictionary(p => p.Name, p => p.PropertyType);

            SetterHavingTargetProperties =
                targetProperties
                    .Where(p => p?.GetSetMethod(false) != null)
                    .ToDictionary(p => p.Name, p => p.PropertyType);
        }

        [NotNull] public string TypeName { get; }
        [NotNull] public Dictionary<string, Type> GetterHavingTargetProperties { get; }
        [NotNull] public Dictionary<string, Type> SetterHavingTargetProperties { get; }
        [NotNull] public IEnumerable<string> DependencyPropertyNames { get; }
    }
}