using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechTalk.SpecFlow.Assist;

namespace ContosoUniversity.Utils
{
    public class ColorValueRetriever : IValueRetriever
    {
        public bool CanRetrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return propertyType == typeof(Color);
        }

        public object Retrieve(KeyValuePair<string, string> keyValuePair, Type targetType, Type propertyType)
        {
            return GetValue(keyValuePair.Value);
        }

        public virtual Color GetValue(string value)
        {
            var Color = new Color() {ColorType = value};
            return Color;
        }
    }

    public class ColorValueComparer : IValueComparer
    {
        public bool CanCompare(object actualValue)
        {
            return true;
        }

        public bool Compare(string expectedValue, object actualValue)
        {
            if (actualValue is int)
            {
                return Int16.Parse(expectedValue) == (int)actualValue;
            }
            return expectedValue.Equals(actualValue);
        }
    }
}