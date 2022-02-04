using System;
using System.Windows;

namespace FeatherIcons
{
    public class FeatherIcon : IComparable
    {
        public FeatherIcon(string KeyName, DataTemplate IconData)
        {
            this.KeyName = KeyName;
            this.IconData = IconData;
        }

        public string KeyName { get; private set; }

        public DataTemplate IconData { get; private set; }

        public int CompareTo(object obj)
        {
            return string.Compare(KeyName, ((FeatherIcon)obj).KeyName);
        }
    }
}