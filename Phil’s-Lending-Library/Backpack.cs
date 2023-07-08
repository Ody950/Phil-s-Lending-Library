using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phil_s_Lending_Library
{
    public class Backpack<Thing> : IBag<Thing>
    {

        private List<Thing> BookList2 = new List<Thing>();

        public void Pack(Thing item)
        {
            BookList2.Add(item);
        }


        public Thing Unpack(int index)
        {
            Thing item = BookList2[index];
            BookList2.RemoveAt(index);
            return item;
        }


        public IEnumerator<Thing> GetEnumerator()
        {
            foreach (Thing item in BookList2)
            {
                yield return item;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }

}
