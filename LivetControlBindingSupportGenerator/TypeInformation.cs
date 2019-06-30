using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows;

namespace LivetControlBindingSupportGenerator
{
    public class TypeInformation
    {
        public TypeInformation(Type t)
        {
            TypeName = t.Name;

            DependencyPropertyNames = t.GetFields(
                BindingFlags.Static |
                BindingFlags.Public | 
                BindingFlags.FlattenHierarchy)
                .Where(p => p.FieldType == typeof(DependencyProperty))
                .Select(p => p.Name.Replace("Property", string.Empty));

            var targetProperties = t.GetProperties(
                BindingFlags.Instance |
                BindingFlags.Public)
                .Where( 
                    p => 
                    ((!DependencyPropertyNames.Contains(p.Name)) || (DependencyPropertyNames.Contains(p.Name) && (p.GetSetMethod(false) == null))) &&
                    (p.Name != "Content") && 
                    (!p.PropertyType.Namespace.StartsWith("System.Windows")) &&
                    (!p.PropertyType.IsGenericType) &&
                    (!p.GetCustomAttributes(typeof(ObsoleteAttribute),true).Any()))
                .ToList();

            GetterHavingTargetProperties = new Dictionary<string, Type>();
            SetterHavingTargetProperties = new Dictionary<string, Type>();

            foreach(var p in targetProperties.Where(p => p.GetGetMethod(false) != null))
            {
                GetterHavingTargetProperties.Add(p.Name, p.PropertyType);
            }

            foreach (var p in targetProperties.Where(p => p.GetSetMethod(false) != null))
            {
                SetterHavingTargetProperties.Add(p.Name, p.PropertyType);
            }
        }

        public string TypeName
        {
            get;
            private set;
        }

        public Dictionary<string,Type> GetterHavingTargetProperties
        {
            get;
            private set;
        }

        public Dictionary<string, Type> SetterHavingTargetProperties
        {
            get;
            private set;
        }

        public IEnumerable<string> DependencyPropertyNames
        {
            get;
            private set;
        }
    }
}
