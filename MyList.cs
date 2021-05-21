using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyList<Tkey, Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyList()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] tempkey = keys;
            Tvalue[] tempvalue = values;
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length+1];
            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
                values[i] = tempvalue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length { get { return keys.Length; } }
        public Tkey[] _key { get { return keys; } }
        public Tvalue[] _value { get { return values; } }
    }
}