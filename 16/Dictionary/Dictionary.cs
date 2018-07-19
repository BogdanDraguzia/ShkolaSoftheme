using System;
using System.Collections.Generic;

namespace Dictionary
{
    public class Dictionary<TKey, TValue> 
    {
        private List<KeyValuePair<TKey, TValue>> list = new List<KeyValuePair<TKey, TValue>>();

        public void Add(TKey key, TValue value)
        {
            
                foreach (var pair in list)
                    if (pair.Key.Equals(key))
                    {
                        Console.WriteLine("Keys can't repeat!");
                        return;
                    }

            list.Add(new KeyValuePair<TKey, TValue>(){Key =  key, Value = value});
            Console.WriteLine("New pair Added");


        }

        public void Remove(TKey key)
        {
            bool contained = false;
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Key.Equals(key))
                {
                    index = i;
                    contained = true;
                }
            }

            if (contained)
            {
                Console.WriteLine(key+" removed");
                list.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Nothing removed");
            }
        }
    }
    
}