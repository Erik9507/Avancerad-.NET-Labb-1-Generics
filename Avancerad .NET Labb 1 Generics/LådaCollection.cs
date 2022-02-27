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
            return innerCol.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //  inner collection to store objects.
        private List<Låda> innerCol;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }

        // Adds an index to the collection.
        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }


        public bool Contains(Låda item)
        {
            bool found = false;

            foreach (Låda bx in innerCol)
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

            foreach (Låda bx in innerCol)
            {
                if (comp.Equals(bx, item))
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
                Console.WriteLine("Box with the same dimentions already exists");
            }
            else
            {
                innerCol.Add(item);
                Console.WriteLine("Added item to the list");
            }          
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Låda item)
        {
            bool result = false;

            // Iterate the inner collection to
            // find the box to be removed.
            for (int i = 0; i < innerCol.Count; i++)
            {
                Låda låda = (Låda)innerCol[i];
                if (new LådaSameDimensions().Equals(låda, item))
                {
                    innerCol.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }


    }
}
