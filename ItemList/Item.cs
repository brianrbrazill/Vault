using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemList
{
    public class Item
    {
       
        /// <summary>
        /// The smaller the value, the lower the quanitites that the total will have effecting the value.
        /// </summary>
        const double DEPRECIATION = .1; 

        /// <summary>
        /// Constructor
        /// </summary>
        public Item(){}

        /// <summary>
        /// Accessor for the name of the item
        /// </summary>
        public string Name { get; set;}

        /// <summary>
        /// Accessor for the total amount in the vault
        /// </summary>
        public int Total { get; set; }

        /// <summary>
        /// Accessor for the value based on the amount in the vault
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Accessor for the initial value that will be used for price calculations
        /// </summary>
        public double InitValue { get; set; }


        /// <summary>
        /// Used to update Items Value using a simple algorithm
        /// </summary>
        public virtual void updateValue()
        {
            if (Total > 0)
            {
                Value = InitValue - (Total)*DEPRECIATION;
            }
            else
                Value = InitValue;


            if (Value < 0)
            {
                Value = .01;
            }
           
        }
    }
    
    /*
     * I used polymorph so that I can seperate the projected items by type in a simple manner 
     */

    /// <summary>
    /// Polymorphed Item - Ammo
    /// </summary>
    class Ammo : Item
    {
        public override void updateValue()
        {
            base.updateValue();
        }
    }

    /// <summary>
    /// Polymorphed Item - Construction
    /// </summary>
    class Construction : Item
    {
        public override void updateValue()
        {
            base.updateValue();
        }
    }

    /// <summary>
    /// Polymorphed Item - Armor
    /// </summary>
    class Armor : Item
    {
        public override void updateValue()
        {
            base.updateValue();
        }
    }
}
