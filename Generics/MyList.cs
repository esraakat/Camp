using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //why is it outside of method? Because we defined an array what gets all elements of MyList class.
        T[] items;

        //ctor - constructor is a method what runs when we use new operator.
        public MyList()
        {
            //we create 0 element an array. 
            items = new T[0];
        }
        public void Add(T item)
        {
            //tempArray - it keeps refernce numbers why they do not get lost.
            T[] tempArray = items;
            items = new T[items.Length + 1]; //element numbers for array

            //elements of tempArray------>items
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Count  //propfull
        {
            get { return items.Length; } //number of array
        }

    }
}
//generic class is a special type
//T - class type
//MyList uses an array in the background
//When we use new operator, it get a new reference number and deletes the old one.