using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemList
{
    class Vault
    {
        /// <summary>
        /// Default Ammo item list.  Order is important, most expensive first.
        /// </summary>
        private string[] _defaultAmmoItems = new string[] { "Rocket Propelled Grenade", "C4 Charge","Ballista Bolt" , "Transponder Node" , "Advanced Sniper Bullet" , "Advanced Rifle Bullet" , "Advanced Bullet" , "Arrow Metal" , "Simple Shotgun Ammo" , "Dart Tranq" , "Simple Rifle Ammo", "Simple Bullet" , "Arrow Tranq" , "Arrow Stone"  };
        /// <summary>
        /// Default Construction item list.  Order is important, most expensive first.
        /// </summary>
        private string[] _defaultConstructionItems = new string[] { "constructionTestSet0", "constructionTestSet1", "constructionTestSet2" };
        /// <summary>
        /// Default Armor item list.  Order is important, most expensive first.
        /// </summary>
        private string[] _defaultArmorItems = new string[] { "armorTestSet0", "armorTestSet1", "armorTestSet2" };

        /// <summary>
        /// This list will hold the entire item list in its vault
        /// </summary>
        private List<Item> _list;

        /// <summary>
        /// Added for the possibility of multiple vaults
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Vault()
        {
            _list = new List<Item>();
            ItemCreation();
        }

        /// <summary>
        /// This will fill the vault with all of the default items and values
        /// </summary>
        private void ItemCreation()
        {
            double defaultValue = 0.00;
            for(int i = _defaultAmmoItems.Length; i > 0; i--)
            {
                Ammo a = new Ammo();
                a.Name = _defaultAmmoItems[i-1];
                a.Value = ++defaultValue;
                a.Total = 0;
                a.InitValue = a.Value;
                _list.Add(a);
            }

            defaultValue = 0.00;
            for (int i = _defaultConstructionItems.Length; i > 0; i--)
            {
                Construction c = new Construction();
                c.Name = _defaultConstructionItems[i - 1];
                c.Value = ++defaultValue;
                c.Total = 0;
                c.InitValue = c.Value;
                _list.Add(c);
            }

            defaultValue = 0.00;
            for (int i = _defaultConstructionItems.Length; i > 0; i--)
            {
                Armor aR = new Armor();
                aR.Name = _defaultArmorItems[i - 1];
                aR.Value = ++defaultValue;
                aR.Total = 0;
                aR.InitValue = aR.Value;
                _list.Add(aR);
            }
        }
        
        /// <summary>
        /// Added for the possiblility of dynamic additions to vaults(unused atm)
        /// </summary>
        /// <param name="i">Item object(ammo, construction, armor(atm))</param>
        public void insertItemInList(Item i)
        {
            _list.Add(i);
        }

        /// <summary>
        /// Needed when you want to make any changes to the item list
        /// </summary>
        /// <param name="newList">New list to replace the old list</param>
        public void setItemList(List<Item> newList)
        {
            _list = newList;
        }

        /// <summary>
        /// Needed if you want the entire list of items
        /// </summary>
        /// <returns>string</returns>
        public List<string> returnItemListName()
        {
            List<string> newlist = new List<string>();
            List<Item> temp = _list;

            try
            {
                foreach(Item i in temp)
                {
                    newlist.Add(i.Name);
                }
                return newlist;
            }

            catch(Exception e)
            {
                Console.WriteLine("{0} No Items in bank", e);
                Console.ReadKey();
            }

            return null;

        }

        /// <summary>
        /// Returns the entire Vault contents
        /// </summary>
        /// <returns>List of Items</returns>
        public List<Item> returnItemList()
        {
            List<Item> list = _list;
            return list;
        }
    }
}
