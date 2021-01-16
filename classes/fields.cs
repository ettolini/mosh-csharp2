using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<int> orders = new List<int>();
        // You can initialize an object as soon as you declare it.
        // Since you declared the orders element with the readonly modifier, you will only be able to initialize the list either here
        // or through a constructor. This way, you avoid yourself the risk of restarting the list and losing data.

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

    }
}