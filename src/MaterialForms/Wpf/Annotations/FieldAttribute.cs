using System;
using MaterialDesignThemes.Wpf;

namespace MaterialForms.Wpf.Annotations
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class FieldAttribute : Attribute
    {
        public string Name { get; set; }

        public string Tooltip { get; set; }

        public object Icon { get; set; }
    }
}
