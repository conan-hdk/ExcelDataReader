﻿using System.Collections;

namespace ExcelDataReader
{
    public class PropertyCollection : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly Dictionary<string, string> dict = new();

        public string this[string key] => dict[key];

        public void Add(string key, string value)
        {
            dict.Add(key, value);
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }
    }
}
