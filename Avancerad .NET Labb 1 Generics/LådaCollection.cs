using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Avancerad_.NET_Labb_1_Generics
{
    public class LådaCollection : ICollection<Låda>
    {


        public IEnumerator<Låda> GetEnumerator()
        {
            return collection.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private List<Låda> collection;
        public int Count => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();
        public LådaCollection()
        {
            collection = new List<Låda>();
        }
   

        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda bx in collection)
            {
                if (bx.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public bool Contains(Låda item, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda l in collection)
            {
                if (comp.Equals(l, item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Add(Låda item)
        {
            if (Contains(item))
            {
                Console.WriteLine("Lådan finns redan i listan");
            }
            else
            {
                collection.Add(item);
                Console.WriteLine("Låda tillagd i listan");
            }          
        }

        public void Clear()
        {
            collection.Clear();
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Låda item)
        {
            bool result = false;
            for (int i = 0; i < collection.Count; i++)
            {
                Låda låda = (Låda)collection[i];
                if (new LådaSameDimensions().Equals(låda, item))
                {
                    Console.WriteLine("Objekt med dimensionerna " + item.bredd + "*" + item.längd + "*" + item.höjd + " tas bort");
                    collection.RemoveAt(i);
                    
                    result = true;
                    break;
                }
            }
            return result;
        }


    }
}
