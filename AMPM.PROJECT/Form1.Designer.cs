
namespace AMPM.PROJECT
{
    partial class ShoppingCart
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CustomerDetails = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.uploadPrevious = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phoneNubmer = new System.Windows.Forms.TextBox();
            this.lblPhoneNubmer = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Cart = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.srollingLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BackToDetails = new System.Windows.Forms.Button();
            this.DoneShopping = new System.Windows.Forms.Button();
            this.Drinks = new System.Windows.Forms.Button();
            this.Snacks = new System.Windows.Forms.Button();
            this.Dairy = new System.Windows.Forms.Button();
            this.Meat = new System.Windows.Forms.Button();
            this.Summery = new System.Windows.Forms.TabPage();
            this.labelNumberOfProd = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.saveToFile = new System.Windows.Forms.Button();
            this.summeryListOfProducts = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CustomerDetails.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Cart.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Summery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Controls.Add(this.tabPage1);
            this.CustomerDetails.Controls.Add(this.Cart);
            this.CustomerDetails.Controls.Add(this.Summery);
            this.CustomerDetails.Font = new System.Drawing.Font("Aharoni", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerDetails.Location = new System.Drawing.Point(0, 0);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.SelectedIndex = 0;
            this.CustomerDetails.Size = new System.Drawing.Size(732, 470);
            this.CustomerDetails.TabIndex = 0;
            this.CustomerDetails.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage1.BackgroundImage = global::AMPM.PROJECT.Properties.Resources.רקע_פרויקט;
            this.tabPage1.Controls.Add(this.uploadPrevious);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.phoneNubmer);
            this.tabPage1.Controls.Add(this.lblPhoneNubmer);
            this.tabPage1.Controls.Add(this.start);
            this.tabPage1.Controls.Add(this.address);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.lblName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Details";
            // 
            // uploadPrevious
            // 
            this.uploadPrevious.BackColor = System.Drawing.Color.ForestGreen;
            this.uploadPrevious.Font = new System.Drawing.Font("AR CENA", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uploadPrevious.ForeColor = System.Drawing.SystemColors.Control;
            this.uploadPrevious.Location = new System.Drawing.Point(553, 213);
            this.uploadPrevious.Name = "uploadPrevious";
            this.uploadPrevious.Size = new System.Drawing.Size(165, 88);
            this.uploadPrevious.TabIndex = 12;
            this.uploadPrevious.Text = "Keep Previous Shopping";
            this.uploadPrevious.UseVisualStyleBackColor = false;
            this.uploadPrevious.Click += new System.EventHandler(this.uploadPrevious_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AMPM.PROJECT.Properties.Resources.sound_effect;
            this.pictureBox1.Location = new System.Drawing.Point(44, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 62);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // phoneNubmer
            // 
            this.phoneNubmer.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNubmer.Location = new System.Drawing.Point(27, 390);
            this.phoneNubmer.Name = "phoneNubmer";
            this.phoneNubmer.Size = new System.Drawing.Size(252, 26);
            this.phoneNubmer.TabIndex = 8;
            this.phoneNubmer.TextChanged += new System.EventHandler(this.phoneNubmer_TextChanged);
            // 
            // lblPhoneNubmer
            // 
            this.lblPhoneNubmer.AutoSize = true;
            this.lblPhoneNubmer.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNubmer.Font = new System.Drawing.Font("AR CENA", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNubmer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPhoneNubmer.Location = new System.Drawing.Point(27, 354);
            this.lblPhoneNubmer.Name = "lblPhoneNubmer";
            this.lblPhoneNubmer.Size = new System.Drawing.Size(152, 33);
            this.lblPhoneNubmer.TabIndex = 7;
            this.lblPhoneNubmer.Text = "Phone number";
            this.lblPhoneNubmer.Click += new System.EventHandler(this.label5_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.ForestGreen;
            this.start.Font = new System.Drawing.Font("AR CENA", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.start.ForeColor = System.Drawing.SystemColors.Control;
            this.start.Location = new System.Drawing.Point(552, 321);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(166, 110);
            this.start.TabIndex = 6;
            this.start.Text = "Start new order !";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(27, 304);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(252, 26);
            this.address.TabIndex = 5;
            this.address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(27, 216);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(252, 26);
            this.name.TabIndex = 4;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("AR CENA", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.Color.Transparent;
            this.lblAddress.Location = new System.Drawing.Point(27, 268);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(108, 33);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Adderess";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("AR CENA", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(27, 180);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cart
            // 
            this.Cart.BackgroundImage = global::AMPM.PROJECT.Properties.Resources.Canva_Design__2_;
            this.Cart.Controls.Add(this.btnClear);
            this.Cart.Controls.Add(this.panel1);
            this.Cart.Controls.Add(this.pictureBox2);
            this.Cart.Controls.Add(this.BackToDetails);
            this.Cart.Controls.Add(this.DoneShopping);
            this.Cart.Controls.Add(this.Drinks);
            this.Cart.Controls.Add(this.Snacks);
            this.Cart.Controls.Add(this.Dairy);
            this.Cart.Controls.Add(this.Meat);
            this.Cart.Location = new System.Drawing.Point(4, 25);
            this.Cart.Name = "Cart";
            this.Cart.Padding = new System.Windows.Forms.Padding(3);
            this.Cart.Size = new System.Drawing.Size(724, 441);
            this.Cart.TabIndex = 1;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.ForestGreen;
            this.btnClear.Font = new System.Drawing.Font("AR CENA", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(314, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(107, 55);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.srollingLabel);
            this.panel1.Location = new System.Drawing.Point(3, 285);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 53);
            this.panel1.TabIndex = 11;
            // 
            // srollingLabel
            // 
            this.srollingLabel.AutoSize = true;
            this.srollingLabel.Font = new System.Drawing.Font("AR CENA", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.srollingLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.srollingLabel.Location = new System.Drawing.Point(597, 17);
            this.srollingLabel.Name = "srollingLabel";
            this.srollingLabel.Size = new System.Drawing.Size(1875, 28);
            this.srollingLabel.TabIndex = 12;
            this.srollingLabel.Text = "Buy 5 dairy products get 20NIS off,    Buy 4 snacks products get 40NIS off,    Bu" +
    "y 3 non alcohol products get 10NIS off,    Buy 2 alcohol products get 30NIS off," +
    "    Buy 3 meat product get 80NIS off";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::AMPM.PROJECT.Properties.Resources.sound_effect;
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 62);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BackToDetails
            // 
            this.BackToDetails.BackColor = System.Drawing.Color.ForestGreen;
            this.BackToDetails.Font = new System.Drawing.Font("AR CENA", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackToDetails.ForeColor = System.Drawing.SystemColors.Control;
            this.BackToDetails.Location = new System.Drawing.Point(20, 365);
            this.BackToDetails.Name = "BackToDetails";
            this.BackToDetails.Size = new System.Drawing.Size(107, 55);
            this.BackToDetails.TabIndex = 6;
            this.BackToDetails.Text = "Back";
            this.BackToDetails.UseVisualStyleBackColor = false;
            this.BackToDetails.Click += new System.EventHandler(this.BackToDetails_Click);
            // 
            // DoneShopping
            // 
            this.DoneShopping.BackColor = System.Drawing.Color.ForestGreen;
            this.DoneShopping.Font = new System.Drawing.Font("AR CENA", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoneShopping.ForeColor = System.Drawing.SystemColors.Control;
            this.DoneShopping.Location = new System.Drawing.Point(600, 365);
            this.DoneShopping.Name = "DoneShopping";
            this.DoneShopping.Size = new System.Drawing.Size(107, 55);
            this.DoneShopping.TabIndex = 5;
            this.DoneShopping.Text = "Done";
            this.DoneShopping.UseVisualStyleBackColor = false;
            this.DoneShopping.Click += new System.EventHandler(this.DoneShopping_Click);
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.Color.ForestGreen;
            this.Drinks.Font = new System.Drawing.Font("AR CENA", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Drinks.ForeColor = System.Drawing.SystemColors.Control;
            this.Drinks.Location = new System.Drawing.Point(396, 98);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(122, 63);
            this.Drinks.TabIndex = 4;
            this.Drinks.Text = "Drinks";
            this.Drinks.UseVisualStyleBackColor = false;
            this.Drinks.Click += new System.EventHandler(this.Drinks_Click);
            // 
            // Snacks
            // 
            this.Snacks.BackColor = System.Drawing.Color.ForestGreen;
            this.Snacks.Font = new System.Drawing.Font("AR CENA", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Snacks.ForeColor = System.Drawing.SystemColors.Control;
            this.Snacks.Location = new System.Drawing.Point(396, 215);
            this.Snacks.Name = "Snacks";
            this.Snacks.Size = new System.Drawing.Size(122, 63);
            this.Snacks.TabIndex = 3;
            this.Snacks.Text = "Snacks";
            this.Snacks.UseVisualStyleBackColor = false;
            this.Snacks.Click += new System.EventHandler(this.Snacks_Click);
            // 
            // Dairy
            // 
            this.Dairy.BackColor = System.Drawing.Color.ForestGreen;
            this.Dairy.Font = new System.Drawing.Font("AR CENA", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dairy.ForeColor = System.Drawing.SystemColors.Control;
            this.Dairy.Location = new System.Drawing.Point(208, 215);
            this.Dairy.Name = "Dairy";
            this.Dairy.Size = new System.Drawing.Size(122, 63);
            this.Dairy.TabIndex = 2;
            this.Dairy.Text = "Dairy";
            this.Dairy.UseVisualStyleBackColor = false;
            this.Dairy.Click += new System.EventHandler(this.Dairy_Click);
            // 
            // Meat
            // 
            this.Meat.BackColor = System.Drawing.Color.ForestGreen;
            this.Meat.Font = new System.Drawing.Font("AR CENA", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Meat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Meat.Location = new System.Drawing.Point(208, 98);
            this.Meat.Name = "Meat";
            this.Meat.Size = new System.Drawing.Size(122, 63);
            this.Meat.TabIndex = 1;
            this.Meat.Text = "Meat";
            this.Meat.UseVisualStyleBackColor = false;
            this.Meat.Click += new System.EventHandler(this.Meat_Click);
            // 
            // Summery
            // 
            this.Summery.BackgroundImage = global::AMPM.PROJECT.Properties.Resources.Canva_Design__1_;
            this.Summery.Controls.Add(this.labelNumberOfProd);
            this.Summery.Controls.Add(this.labelTotalPrice);
            this.Summery.Controls.Add(this.saveToFile);
            this.Summery.Controls.Add(this.summeryListOfProducts);
            this.Summery.Controls.Add(this.pictureBox3);
            this.Summery.Location = new System.Drawing.Point(4, 25);
            this.Summery.Name = "Summery";
            this.Summery.Padding = new System.Windows.Forms.Padding(3);
            this.Summery.Size = new System.Drawing.Size(724, 441);
            this.Summery.TabIndex = 2;
            this.Summery.Text = "Summery";
            this.Summery.UseVisualStyleBackColor = true;
            this.Summery.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // labelNumberOfProd
            // 
            this.labelNumberOfProd.AutoSize = true;
            this.labelNumberOfProd.BackColor = System.Drawing.Color.ForestGreen;
            this.labelNumberOfProd.Font = new System.Drawing.Font("AR CENA", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOfProd.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNumberOfProd.Location = new System.Drawing.Point(156, 384);
            this.labelNumberOfProd.Name = "labelNumberOfProd";
            this.labelNumberOfProd.Size = new System.Drawing.Size(194, 30);
            this.labelNumberOfProd.TabIndex = 16;
            this.labelNumberOfProd.Text = "Number Of Products:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BackColor = System.Drawing.Color.ForestGreen;
            this.labelTotalPrice.Font = new System.Drawing.Font("AR CENA", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalPrice.Location = new System.Drawing.Point(429, 384);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(119, 30);
            this.labelTotalPrice.TabIndex = 15;
            this.labelTotalPrice.Text = "Total Price: ";
            // 
            // saveToFile
            // 
            this.saveToFile.BackColor = System.Drawing.Color.ForestGreen;
            this.saveToFile.Font = new System.Drawing.Font("AR CENA", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveToFile.ForeColor = System.Drawing.SystemColors.Control;
            this.saveToFile.Location = new System.Drawing.Point(611, 376);
            this.saveToFile.Name = "saveToFile";
            this.saveToFile.Size = new System.Drawing.Size(107, 55);
            this.saveToFile.TabIndex = 14;
            this.saveToFile.Text = "Save";
            this.saveToFile.UseVisualStyleBackColor = false;
            this.saveToFile.Click += new System.EventHandler(this.saveToFile_Click);
            // 
            // summeryListOfProducts
            // 
            this.summeryListOfProducts.BackColor = System.Drawing.Color.ForestGreen;
            this.summeryListOfProducts.Font = new System.Drawing.Font("AR CENA", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.summeryListOfProducts.ForeColor = System.Drawing.SystemColors.Control;
            this.summeryListOfProducts.FormattingEnabled = true;
            this.summeryListOfProducts.ItemHeight = 32;
            this.summeryListOfProducts.Location = new System.Drawing.Point(156, 63);
            this.summeryListOfProducts.Name = "summeryListOfProducts";
            this.summeryListOfProducts.Size = new System.Drawing.Size(411, 292);
            this.summeryListOfProducts.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::AMPM.PROJECT.Properties.Resources.sound_effect;
            this.pictureBox3.Location = new System.Drawing.Point(18, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 62);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 488);
            this.Controls.Add(this.CustomerDetails);
            this.Name = "ShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.ShoppingCart_Load);
            this.CustomerDetails.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Cart.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Summery.ResumeLayout(false);
            this.Summery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl CustomerDetails;
        private System.Windows.Forms.TabPage Summery;
        private System.Windows.Forms.TabPage Cart;
        private System.Windows.Forms.Button Drinks;
        private System.Windows.Forms.Button Snacks;
        private System.Windows.Forms.Button Dairy;
        private System.Windows.Forms.Button Meat;
        private System.Windows.Forms.Button BackToDetails;
        private System.Windows.Forms.Button DoneShopping;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox summeryListOfProducts;
        private System.Windows.Forms.Button saveToFile;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button uploadPrevious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox phoneNubmer;
        private System.Windows.Forms.Label lblPhoneNubmer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelNumberOfProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label srollingLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClear;
    }
}

