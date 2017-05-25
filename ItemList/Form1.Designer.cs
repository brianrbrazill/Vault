namespace ItemList
{
    partial class uxItemListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxItemValue = new System.Windows.Forms.TextBox();
            this.uxItemCountInVault = new System.Windows.Forms.TextBox();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxRemove = new System.Windows.Forms.Button();
            this.uxQuantity = new System.Windows.Forms.TextBox();
            this.uxListItems = new System.Windows.Forms.ListBox();
            this.uxCheck = new System.Windows.Forms.Button();
            this.uxShowAmmo = new System.Windows.Forms.Button();
            this.uxShowArmor = new System.Windows.Forms.Button();
            this.uxShowConstruction = new System.Windows.Forms.Button();
            this.uxShowAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxItemValue
            // 
            this.uxItemValue.Location = new System.Drawing.Point(119, 12);
            this.uxItemValue.Name = "uxItemValue";
            this.uxItemValue.Size = new System.Drawing.Size(100, 20);
            this.uxItemValue.TabIndex = 1;
            this.uxItemValue.TextChanged += new System.EventHandler(this.uxItemValue_TextChanged);
            // 
            // uxItemCountInVault
            // 
            this.uxItemCountInVault.Location = new System.Drawing.Point(119, 38);
            this.uxItemCountInVault.Name = "uxItemCountInVault";
            this.uxItemCountInVault.Size = new System.Drawing.Size(100, 20);
            this.uxItemCountInVault.TabIndex = 2;
            this.uxItemCountInVault.TextChanged += new System.EventHandler(this.uxItemCountInBank_TextChanged);
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(12, 200);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(75, 23);
            this.uxAdd.TabIndex = 3;
            this.uxAdd.Text = "Player Sell";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxRemove
            // 
            this.uxRemove.Location = new System.Drawing.Point(93, 200);
            this.uxRemove.Name = "uxRemove";
            this.uxRemove.Size = new System.Drawing.Size(75, 23);
            this.uxRemove.TabIndex = 5;
            this.uxRemove.Text = "Player Buy";
            this.uxRemove.UseVisualStyleBackColor = true;
            this.uxRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxQuantity
            // 
            this.uxQuantity.Location = new System.Drawing.Point(12, 229);
            this.uxQuantity.Name = "uxQuantity";
            this.uxQuantity.Size = new System.Drawing.Size(100, 20);
            this.uxQuantity.TabIndex = 6;
            // 
            // uxListItems
            // 
            this.uxListItems.FormattingEnabled = true;
            this.uxListItems.Location = new System.Drawing.Point(13, 12);
            this.uxListItems.Name = "uxListItems";
            this.uxListItems.Size = new System.Drawing.Size(99, 147);
            this.uxListItems.TabIndex = 4;
            this.uxListItems.SelectedIndexChanged += new System.EventHandler(this.uxListItems_SelectedIndexChanged);
            // 
            // uxCheck
            // 
            this.uxCheck.Location = new System.Drawing.Point(13, 165);
            this.uxCheck.Name = "uxCheck";
            this.uxCheck.Size = new System.Drawing.Size(75, 23);
            this.uxCheck.TabIndex = 7;
            this.uxCheck.Text = "Check";
            this.uxCheck.UseVisualStyleBackColor = true;
            this.uxCheck.Click += new System.EventHandler(this.uxCheck_Click);
            // 
            // uxShowAmmo
            // 
            this.uxShowAmmo.Location = new System.Drawing.Point(118, 94);
            this.uxShowAmmo.Name = "uxShowAmmo";
            this.uxShowAmmo.Size = new System.Drawing.Size(75, 23);
            this.uxShowAmmo.TabIndex = 8;
            this.uxShowAmmo.Text = "Ammo";
            this.uxShowAmmo.UseVisualStyleBackColor = true;
            this.uxShowAmmo.Click += new System.EventHandler(this.uxShowAmmo_Click);
            // 
            // uxShowArmor
            // 
            this.uxShowArmor.Location = new System.Drawing.Point(119, 150);
            this.uxShowArmor.Name = "uxShowArmor";
            this.uxShowArmor.Size = new System.Drawing.Size(75, 23);
            this.uxShowArmor.TabIndex = 9;
            this.uxShowArmor.Text = "Armor";
            this.uxShowArmor.UseVisualStyleBackColor = true;
            this.uxShowArmor.Click += new System.EventHandler(this.uxShowArmor_Click);
            // 
            // uxShowConstruction
            // 
            this.uxShowConstruction.Location = new System.Drawing.Point(119, 121);
            this.uxShowConstruction.Name = "uxShowConstruction";
            this.uxShowConstruction.Size = new System.Drawing.Size(75, 23);
            this.uxShowConstruction.TabIndex = 10;
            this.uxShowConstruction.Text = "Construction";
            this.uxShowConstruction.UseVisualStyleBackColor = true;
            this.uxShowConstruction.Click += new System.EventHandler(this.uxShowConstruction_Click);
            // 
            // uxShowAll
            // 
            this.uxShowAll.Location = new System.Drawing.Point(119, 65);
            this.uxShowAll.Name = "uxShowAll";
            this.uxShowAll.Size = new System.Drawing.Size(75, 23);
            this.uxShowAll.TabIndex = 11;
            this.uxShowAll.Text = "All";
            this.uxShowAll.UseVisualStyleBackColor = true;
            this.uxShowAll.Click += new System.EventHandler(this.uxShowAll_Click);
            // 
            // uxItemListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.uxShowAll);
            this.Controls.Add(this.uxShowConstruction);
            this.Controls.Add(this.uxShowArmor);
            this.Controls.Add(this.uxShowAmmo);
            this.Controls.Add(this.uxCheck);
            this.Controls.Add(this.uxQuantity);
            this.Controls.Add(this.uxRemove);
            this.Controls.Add(this.uxListItems);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxItemCountInVault);
            this.Controls.Add(this.uxItemValue);
            this.Name = "uxItemListForm";
            this.Text = "Item List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox uxItemValue;
        private System.Windows.Forms.TextBox uxItemCountInVault;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxRemove;
        private System.Windows.Forms.TextBox uxQuantity;
        private System.Windows.Forms.ListBox uxListItems;
        private System.Windows.Forms.Button uxCheck;
        private System.Windows.Forms.Button uxShowAmmo;
        private System.Windows.Forms.Button uxShowArmor;
        private System.Windows.Forms.Button uxShowConstruction;
        private System.Windows.Forms.Button uxShowAll;
    }
}

