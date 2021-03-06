﻿using System;
using System.Collections.Generic;
using MaterialForms.Wpf.Resources;

namespace MaterialForms.Wpf.Fields.Defaults
{
    public class SelectionField : DataFormField
    {
        public SelectionField(string key, Type propertyType) : base(key, propertyType)
        {
        }

        public IValueProvider ItemsSource { get; set; }

        public IValueProvider ItemStringFormat { get; set; }

        public IValueProvider DisplayPath { get; set; }

        public IValueProvider ValuePath { get; set; }

        public IValueProvider SelectionType { get; set; }

        protected internal override IBindingProvider CreateBindingProvider(IResourceContext context, IDictionary<string, IValueProvider> formResources)
        {
            throw new NotImplementedException();
        }
    }
}
