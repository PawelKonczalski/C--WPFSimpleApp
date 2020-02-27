using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace dataGrid
{
    class GenderTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MaleTemplate { get; set; }
        public DataTemplate FamaleTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            PersonData person = item as PersonData;

            if (person.Sex == PersonData.Gender.Male)
                return MaleTemplate;

            return FamaleTemplate;
        }
    }
}
