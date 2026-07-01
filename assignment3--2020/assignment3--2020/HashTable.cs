using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3Template
{
    class HashTable<T>
    {
        private T[] hasharray;

        public HashTable(int size)
        { hasharray = new T[size]; }

        public void Add(T value)
        {

            // this is where insertion goes
            // should use the method hashkey to generate the key/index 
            // remember to account for quadratic probing

            int key = hashkey(value) % hasharray.Length;
            int i = key;
            int j = 1;

            while (!object.Equals(hasharray[i], default(T)))
            {
                i = (key + j * j) % hasharray.Length;
                j++;

                if (j == hasharray.Length)
                {
                    Console.WriteLine("Hash table is full.");
                    return;
                }
            }

            hasharray[i] = value;
        }

        private int find(T value)
        {
            //returns the index the item is found at, or -1 if it isn't found
            //

            int key = hashkey(value) % hasharray.Length;
            int i = key;
            int j = 1;

            while (!object.Equals(hasharray[i], default(T)))
            {
                if (hasharray[i].Equals(value))
                {
                    return i;
                }

                i = (key + j * j) % hasharray.Length;
                j++;

                if (j == hasharray.Length)
                {
                    return -1;
                }
            }

            return -1;
        }

        public bool Find(T value)
        {
            if (this.find(value) >= 0) return true;
            else return false;

        }
        public static int hashkey(T value)
        {

            // if you want you can use a better hashing function here but that seems like it requires effort.
            return value.ToString().Length;
        }
    }
}