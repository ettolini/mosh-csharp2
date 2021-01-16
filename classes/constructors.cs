using System;
using System.Collections.Generic;

namespace Constructors
{
    public class Order
    {
        // Created this empty class just to showcase how to create a list of objects.
    }

    class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;  // List of Order Objects.

        public Customer()               // If we use a list in or object, we must not forget that lists are a reference type. Meaning, we need
        {                               // to initialize them before handling them, otherwise our code will throw an exception at us.
            Orders = new List<Order>(); // That's why we're forced to initialize our list in our default Constructor, and every other Constructor
        }                               // as well. But instead of typing the same code in every constructor, we referenced this Constructor...

        
        public Customer(int id) // The this keyword is referencing the constructor with that signature, which is executed before this one.
            : this() 
        {
            this.Id = id;
        }

        public Customer(int id, string name)    // This is not considered a "best practice", tho. Since it can get complicated to track.
            : this(id)
            {                                   // It is instead recommended that you only define specific constructors for those atributtes
                this.Name = name;               // that you absolutely need to initialize beforehand for the correct execution of your objects.
            }
    }
}
