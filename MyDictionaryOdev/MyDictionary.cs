using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryOdev
{
    class MyDictionary<TKey,TValue>
    {
        private TKey[] keys;
        private TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;
            TValue[] tempValues = values;

            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            keys[keys.Length - 1] = key;

            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            values[values.Length - 1] = value;

        }

        public TValue[] value
        {
            get { return values; }
        }

        public TKey[] key
        {
            get { return keys; }
        }
    }
}
