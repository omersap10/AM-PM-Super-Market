using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace AMPM.PROJECT
{
    public partial class ShoppingCart : Form
    {
        static int summerySize;
        static int music;
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        int Xcounta = 0;
      
        public ShoppingCart()
        {
            InitializeComponent();
            player.SoundLocation = "music.wav";
            player.PlayLooping();
        }


        private void tabPage1_Click(object sender, EventArgs e) //non-functional
        {

        }

        private void Cart_Click(object sender, EventArgs e) //non-functional
        {

        }

        private void tabPage2_Click(object sender, EventArgs e) //non-functional
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e) //non-functional
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e) //non-functional
        {

        }

        private void label2_Click(object sender, EventArgs e) //non-functional
        {

        }

        private void ShoppingCart_Load(object sender, EventArgs e)//loading the products
        {
             timer1.Start();
             srollingLabel.Location = new Point(panel1.Width - Xcounta, srollingLabel.Location.Y);
             Xcounta++;


            Date d0 = new Date(30, 12, 2022);
            Date d1 = new Date(30, 09, 2022);
            Date d2 = new Date(25, 12, 2022);
            Date d3 = new Date(20, 10, 2022);
            Date d4 = new Date(01, 12, 2022);
            Date d5 = new Date(25, 09, 2022);
            Date d6 = new Date(04, 11, 2022);
            Date d7 = new Date(12, 02, 2023);
            Date d8 = new Date(03, 03, 2023);
            Date d9 = new Date(15, 10, 2022);
            Date d10 = new Date(01, 11, 2022);
            Date d11 = new Date(03, 10, 2022);
            Date d12 = new Date(22, 12, 2022);
            Date d13 = new Date(16, 11, 2022);
            Date d14 = new Date(24, 11, 2022);
            Date d15 = new Date(30, 12, 2023);
            Date d16 = new Date(04, 12, 2023);
            Date d17 = new Date(27, 12, 2022);
            Date d18 = new Date(26, 10, 2022);
            Date d19 = new Date(09, 09, 2022);
            Date d20 = new Date(11, 10, 2022);
            Date d21 = new Date(07, 09, 2022);
            Date d22 = new Date(13, 10, 2022);
            Date d23 = new Date(14, 11, 2022);
            Date d24 = new Date(15, 05, 2023);

            allData.meatArray[0] = new Meat("Chicken", 40, d0, 500, 200, true, 20);
            allData.meatArray[1] = new Meat("Salmon", 40, d1, 500, 200, true, 20);
            allData.meatArray[2] = new Meat("Steack", 40, d2, 500, 200, true, 20);
            allData.meatArray[3] = new Meat("Kabab", 40, d3, 500, 200, true, 20);
            allData.meatArray[4] = new Meat("Ham", 40, d4, 500, 200, true, 20);
            allData.meatArray[5] = new Meat("Shrimps", 40, d5, 500, 200, true, 20);

            allData.dairyArray[0] = new Dairy("Cheese", 6.90, d6, 50, 11.12, 4.30, 83);
            allData.dairyArray[1] = new Dairy("Milk", 7, d7, 40, 4.5, 3, 195);
            allData.dairyArray[2] = new Dairy("Cream", 8, d8, 50, 150, 38, 34);
            allData.dairyArray[3] = new Dairy("Yogurt", 15, d9, 120, 80, 10, 130);
            allData.dairyArray[4] = new Dairy("Butter", 8, d10, 180, 30, 80, 20);

            allData.snacksArray[0] = new Snacks("Bamba", 7, d11, 50, 10, 35, 20);
            allData.snacksArray[1] = new Snacks("Chips", 11, d12, 70, 20, 30, 12);
            allData.snacksArray[2] = new Snacks("Doritos", 5, d13, 60, 10, 40, 22);
            allData.snacksArray[3] = new Snacks("Kinder", 15, d14, 90, 80, 10, 30);
            allData.snacksArray[4] = new Snacks("Klik", 12, d15, 80, 12, 7, 15);

            allData.alcoholArray[0] = new Alcohol("Arak", 100, d16, 150, 60, false, 24.7);
            allData.alcoholArray[1] = new Alcohol("Whisky", 300, d17, 100, 70, false, 20);
            allData.alcoholArray[2] = new Alcohol("Wine", 120, d18, 170, 45, true, 12);
            allData.alcoholArray[3] = new Alcohol("Rum", 75, d19, 120, 89, true, 11);

            allData.nonAlcoholArray[0] = new Non_Alcohol("Coca-Cola", 17, d20, 40, 60, false, true);
            allData.nonAlcoholArray[1] = new Non_Alcohol("Tea", 10, d21, 23, 17, false, false);
            allData.nonAlcoholArray[2] = new Non_Alcohol("Coffe", 13, d22, 50, 32, true, false);
            allData.nonAlcoholArray[3] = new Non_Alcohol("Soda", 11, d23, 10, 5, false, true);
            allData.nonAlcoholArray[4] = new Non_Alcohol("Water", 9, d24, 0, 0, false, false);

        }

        private void button1_Click(object sender, EventArgs e) // press start button
        {
            bool flagNumberCorrect = true;

            if(allData.customer1.getName() == null)
            {
                MessageBox.Show("Please enter your full name!","invalid name" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (allData.customer1.getAddress() == null)
            {
                MessageBox.Show("Please enter your address!", "invalid address", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string phone = allData.customer1.getPhone_number().Substring(allData.customer1.getPhone_number().IndexOf(':')+2); //substring correct phone nubmer.

            foreach (char c in phone)
            {
                if (c < '0' || c > '9')
                    flagNumberCorrect = false;

            }

            if (allData.customer1.getPhone_number() == null || phone.Length != 10 || flagNumberCorrect == false)
            {
                MessageBox.Show("Please enter your phone number!", "invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CustomerDetails.SelectTab(1); //go to cart tab
            }
            
        }



        private void label5_Click(object sender, EventArgs e) //non-functional
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string address = sender.ToString();
            allData.customer1.setAddress(address);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = sender.ToString();
            allData.customer1.setName(name);
        }

        private void phoneNubmer_TextChanged(object sender, EventArgs e)
        {
            string phone = sender.ToString();
            allData.customer1.setPhone_number(phone);
        }

        private void Meat_Click(object sender, EventArgs e)//meat button
        {
            FormMeat f1 = new FormMeat();
            f1.ShowDialog();
        }

        private void Drinks_Click(object sender, EventArgs e)//drinks button
        {
            FormDrinks f1 = new FormDrinks();
            f1.ShowDialog();
        }

        private void Dairy_Click(object sender, EventArgs e)//dairy button
        {
            FormDairy f1 = new FormDairy();
            f1.ShowDialog();
        }

        private void Snacks_Click(object sender, EventArgs e)//snacks button
        {
            FormSnacks f1 = new FormSnacks();
            f1.ShowDialog();
        }

        private void tabShoppingCart_SelectedIndexChanged(object sender, EventArgs e) // check move between tabs.
        {
            switch(CustomerDetails.SelectedIndex)
            {
                case 1:
                    if (allData.customer1.getName() == null || allData.customer1.getPhone_number() == null || allData.customer1.getAddress() == null)
                    {
                        MessageBox.Show("Please enter all customer details", "Missing details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CustomerDetails.SelectedIndex = 0;
                    }
                    break;
                default:
                    break;
            }
        }

        private void DoneShopping_Click(object sender, EventArgs e)
        {
            productList summeryList = new productList();
            int i = 0;
            int j;
            int amount;
            double totalPrice = 0;

            for (j = 0; j < 6; j++) //meat Array
            {
                if((amount = allData.meatArray[j].getAmount()) > 0)
                {
                    summeryList[i] = allData.meatArray[j];
                    allData.numberOfProductsOrderd += amount;
                    i++;
                    summerySize++;
                }
            }
            for (j = 0; j < 5; j++) //dairy Array
            {
                if ((amount = allData.dairyArray[j].getAmount()) > 0)
                {
                    summeryList[i] = allData.dairyArray[j];
                    allData.numberOfProductsOrderd += amount;
                    i++;
                    summerySize++;
                }
            }
            for (j = 0; j < 5; j++) //snacks Array
            {
                if ((amount = allData.snacksArray[j].getAmount()) > 0)
                {
                    summeryList[i] = allData.snacksArray[j];
                    allData.numberOfProductsOrderd += amount;
                    i++;
                    summerySize++;
                }
            }
            for (j = 0; j < 4; j++) //alcohol Array
            {
                if ((amount = allData.alcoholArray[j].getAmount()) > 0)
                {
                    summeryList[i] = allData.alcoholArray[j];
                    allData.numberOfProductsOrderd += amount;
                    i++;
                    summerySize++;
                }
            }
            for (j = 0; j < 5; j++) //nonAlcohol Array
            {
                if ((amount = allData.nonAlcoholArray[j].getAmount()) > 0)
                {
                    summeryList[i] = allData.nonAlcoholArray[j];
                    allData.numberOfProductsOrderd += amount;
                    i++;
                    summerySize++;
                }
            }

            summeryListOfProducts.Items.Clear();

            for (i = 0; i < summerySize; i++)//calc total price
            {
                summeryListOfProducts.Items.Add(summeryList[i].getName() + " " + summeryList[i].getAmount().ToString());
                totalPrice += summeryList[i].Sales();
            }

            labelNumberOfProd.Text = "Number of products: " + allData.numberOfProductsOrderd;

            labelTotalPrice.Text = "Total price = " + totalPrice;

            if(allData.numberOfProductsOrderd == 0)//if the orderis empty
            {
                MessageBox.Show("Please choose products!", "Missing products", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CustomerDetails.SelectTab(2);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) //start-stop music tab1
        {
            if((music % 2) == 0)
            {
                player.Stop();
                music++;
            }
            else
            {
                player.PlayLooping();
                music++;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) //start-stop music tab2
        {
            if ((music % 2) == 0)
            {
                player.Stop();
                music++;
            }
            else
            {
                player.PlayLooping();
                music++;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e) //start-stop music tab3
        {
            if ((music % 2) == 0)
            {
                player.Stop();
                music++;
            }
            else
            {
                player.PlayLooping();
                music++;
            }
        }

        private void BackToDetails_Click(object sender, EventArgs e) //back to costumer details
        {
            CustomerDetails.SelectTab(0);
        }

        private void saveToFile_Click(object sender, EventArgs e)//save order to file
        {
            TextWriter saveText = new StreamWriter(Application.StartupPath + "\\saveFile\\" + "saveShoppingCart.txt");
            saveText.WriteLine(name.Text);
            saveText.WriteLine(address.Text);
            saveText.WriteLine(phoneNubmer.Text);
            
            foreach(var item in summeryListOfProducts.Items) //enter items into file
            {
                saveText.WriteLine(item);
            }

            saveText.Close();
            MessageBox.Show("Thank you for buying!");
            this.Close();
        }

        private void uploadPrevious_Click(object sender, EventArgs e)//previous order
        {
            int amount;
            string amountString;
            string pro;
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\ASUS\source\repos\AMPM.PROJECT\AMPM.PROJECT\bin\Debug\netcoreapp3.1\saveFile\saveShoppingCart.txt");


            allData.customer1.setName(lines[0]);
            allData.customer1.setAddress(lines[1]);
            allData.customer1.setPhone_number(lines[2]);

            name.Text = allData.customer1.getName();
            address.Text = allData.customer1.getAddress();
            phoneNubmer.Text = allData.customer1.getPhone_number();

            for (int k = 3; k < lines.Length; k++)
            {
                pro = lines[k].Substring(0, lines[k].IndexOf(' '));
                amountString = lines[k].Substring(lines[k].IndexOf(' '));
                amount = Int32.Parse(amountString);

                //meatArray search
                if (string.Compare(pro, "Chicken") == 0)
                {
                    allData.meatArray[0].setAmount(allData.meatArray[0].getAmount() + amount);
                }
                if (string.Compare(pro, "Salmon") == 0)
                {
                    allData.meatArray[1].setAmount(allData.meatArray[1].getAmount() + amount);
                }
                if (string.Compare(pro, "Steack") == 0)
                {
                    allData.meatArray[2].setAmount(allData.meatArray[2].getAmount() + amount);
                }
                if (string.Compare(pro, "Kabab") == 0)
                {
                    allData.meatArray[3].setAmount(allData.meatArray[3].getAmount() + amount);
                }
                if (string.Compare(pro, "Ham") == 0)
                {
                    allData.meatArray[4].setAmount(allData.meatArray[4].getAmount() + amount);
                }
                if (string.Compare(pro, "Shrimps") == 0)
                {
                    allData.meatArray[5].setAmount(allData.meatArray[5].getAmount() + amount);
                }
                //dairyArray search
                if (string.Compare(pro, "Cottage") == 0)
                {
                    allData.dairyArray[0].setAmount(allData.meatArray[0].getAmount() + amount);
                }
                if (string.Compare(pro, "Milk") == 0)
                {
                    allData.dairyArray[1].setAmount(allData.meatArray[1].getAmount() + amount);
                }
                if (string.Compare(pro, "Cream") == 0)
                {
                    allData.dairyArray[2].setAmount(allData.meatArray[2].getAmount() + amount);
                }
                if (string.Compare(pro, "Yogurt") == 0)
                {
                    allData.dairyArray[3].setAmount(allData.meatArray[3].getAmount() + amount);
                }
                if (string.Compare(pro, "Butter") == 0)
                {
                    allData.dairyArray[4].setAmount(allData.meatArray[4].getAmount() + amount);
                }
                //snacksArray search
                if (string.Compare(pro, "Bamba") == 0)
                {
                    allData.snacksArray[0].setAmount(allData.meatArray[0].getAmount() + amount);
                }
                if (string.Compare(pro, "Chips") == 0)
                {
                    allData.snacksArray[1].setAmount(allData.meatArray[1].getAmount() + amount);
                }
                if (string.Compare(pro, "Doritos") == 0)
                {
                    allData.snacksArray[2].setAmount(allData.meatArray[2].getAmount() + amount);
                }
                if (string.Compare(pro, "Kinder") == 0)
                {
                    allData.snacksArray[3].setAmount(allData.meatArray[3].getAmount() + amount);
                }
                if (string.Compare(pro, "Klik") == 0)
                {
                    allData.snacksArray[4].setAmount(allData.meatArray[4].getAmount() + amount);
                }
                //alcoholArray search
                if (string.Compare(pro, "Arak") == 0)
                {
                    allData.alcoholArray[0].setAmount(allData.meatArray[0].getAmount() + amount);
                }
                if (string.Compare(pro, "Whisky") == 0)
                {
                    allData.alcoholArray[1].setAmount(allData.meatArray[1].getAmount() + amount);
                }
                if (string.Compare(pro, "Wine") == 0)
                {
                    allData.alcoholArray[2].setAmount(allData.meatArray[2].getAmount() + amount);
                }
                if (string.Compare(pro, "Rum") == 0)
                {
                    allData.alcoholArray[3].setAmount(allData.meatArray[3].getAmount() + amount);
                }
                //nonAlcoholArray search
                if (string.Compare(pro, "Coca-Cola") == 0)
                {
                    allData.nonAlcoholArray[0].setAmount(allData.meatArray[0].getAmount() + amount);
                }
                if (string.Compare(pro, "Tea") == 0)
                {
                    allData.nonAlcoholArray[1].setAmount(allData.meatArray[1].getAmount() + amount);
                }
                if (string.Compare(pro, "Coffe") == 0)
                {
                    allData.nonAlcoholArray[2].setAmount(allData.meatArray[2].getAmount() + amount);
                }
                if (string.Compare(pro, "Soda") == 0)
                {
                    allData.nonAlcoholArray[3].setAmount(allData.meatArray[3].getAmount() + amount);
                }
                if (string.Compare(pro, "Water") == 0)
                {
                    allData.nonAlcoholArray[4].setAmount(allData.meatArray[4].getAmount() + amount);
                }

            }
            MessageBox.Show("Your previous order has been successfully entered. Please press Start new order");
            
        }

        private void timer1_Tick(object sender, EventArgs e) //scrolling sales
        {

            if (srollingLabel.Location.X == 0)
            {
                srollingLabel.Location = new Point(panel1.Width - Xcounta, srollingLabel.Location.Y);
                Xcounta++;
            }
            else
            {
                srollingLabel.Location = new Point(panel1.Width - Xcounta, srollingLabel.Location.Y);
                Xcounta++;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)//clear cart
        {
            for (int j = 0; j < 6; j++) //meat Array
            {
                allData.meatArray[j].setAmount(0);
               
            }
            for (int j = 0; j < 5; j++) //dairy Array
            {
                allData.dairyArray[j].setAmount(0);
               
            }
            for (int j = 0; j < 5; j++) //snacks Array
            {
                allData.snacksArray[j].setAmount(0);
              
            }
            for (int j = 0; j < 4; j++) //alcohol Array
            {
                allData.alcoholArray[j].setAmount(0);
               
            }
            for (int j = 0; j < 5; j++) //nonAlcohol Array
            {
                allData.nonAlcoholArray[j].setAmount(0);
              
            }
            allData.numberOfProductsOrderd = 0;

            labelNumberOfProd.Text = "Number of products: " + allData.numberOfProductsOrderd;

            labelTotalPrice.Text = "Total price = 0";

        }
    }


    public static class allData
    {
        public static int numberOfProductsOrderd;
        public static Customer customer1 = new Customer();
        public static Meat[] meatArray = new Meat[6];
        public static Dairy[] dairyArray = new Dairy[5];
        public static Snacks[] snacksArray = new Snacks[5];
        public static Alcohol[] alcoholArray = new Alcohol[4];
        public static Non_Alcohol[] nonAlcoholArray = new Non_Alcohol[5];
      
    }
}
