using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemList
{
    public partial class uxItemListForm : Form
    {
        private Vault _vault = new Vault();

        public uxItemListForm()
        {
            InitializeComponent();
            
            List<string> names = _vault.returnItemListName();
            List<Item> itemObject = _vault.returnItemList();
            foreach(Item i in itemObject)
            {
                i.updateValue();
            }
            foreach (string n in names)
            {
                uxListItems.Items.Add(n);
                
            }
        }

        private void uxItemValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxItemCountInBank_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxListItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void uxAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = uxListItems.SelectedItem.ToString();
                List<Item> temp = _vault.returnItemList();

                int val = Convert.ToInt32(uxQuantity.Text);

                if (val >= 0)
                {
                    foreach (Item i in temp)
                    {
                        if (i.Name.Equals(name))
                        {
                            i.Total = i.Total + val;
                            i.updateValue();
                            _vault.setItemList(temp);
                            uxItemValue.Text = i.Value.ToString();
                            uxItemCountInVault.Text = i.Total.ToString();
                        }
                    }
                }
                else
                    MessageBox.Show("Insert a value above 0");
            }
            catch(Exception)
            {
                MessageBox.Show("Insert a proper value");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = uxListItems.SelectedItem.ToString();
                List<Item> temp = _vault.returnItemList();

                int val = Convert.ToInt32(uxQuantity.Text);

                if (val >= 0)
                {
                    foreach (Item i in temp)
                    {
                        if (i.Name.Equals(name))
                        {
                            int test = i.Total - val;
                            if (test >= 0)
                            {
                                i.Total = i.Total - val;
                                i.updateValue();
                                _vault.setItemList(temp);
                                uxItemValue.Text = i.Value.ToString();
                                uxItemCountInVault.Text = i.Total.ToString();
                            }
                            else
                            {
                                MessageBox.Show("Vault is "+(test*-1).ToString()+" shy");
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Insert a value above 0");
            }
            catch (Exception)
            {
                MessageBox.Show("Insert a proper value");
            }
        }

        private void uxCheck_Click(object sender, EventArgs e)
        {
            string name = uxListItems.SelectedItem.ToString();
            List<Item> temp = _vault.returnItemList();
            
                foreach (Item i in temp)
                {
                    if (i.Name.Equals(name))
                    {
                        uxItemValue.Text = i.Value.ToString();
                        uxItemCountInVault.Text = i.Total.ToString();
                    }
                }
        }

        private void uxShowAll_Click(object sender, EventArgs e)
        {
            uxListItems.Items.Clear();

            List<string> names = _vault.returnItemListName();
            foreach (string n in names)
            {
                uxListItems.Items.Add(n);

            }
        }

        private void uxShowAmmo_Click(object sender, EventArgs e)
        {
            uxListItems.Items.Clear();

            List<string> names = new List<string>();
            foreach(Item a in _vault.returnItemList())
            {
                if(a is Ammo)
                {
                    names.Add(a.Name);
                }
            }

            foreach (string n in names)
            {
                uxListItems.Items.Add(n);

            }
        }

        private void uxShowConstruction_Click(object sender, EventArgs e)
        {
            uxListItems.Items.Clear();

            List<string> names = new List<string>();
            foreach (Item c in _vault.returnItemList())
            {
                if (c is Construction)
                {
                    names.Add(c.Name);
                }
            }

            foreach (string n in names)
            {
                uxListItems.Items.Add(n);

            }
        }

        private void uxShowArmor_Click(object sender, EventArgs e)
        {
            uxListItems.Items.Clear();

            List<string> names = new List<string>();
            foreach (Item aR in _vault.returnItemList())
            {
                if (aR is Armor)
                {
                    names.Add(aR.Name);
                }
            }

            foreach (string n in names)
            {
                uxListItems.Items.Add(n);

            }
        }
    }
}
