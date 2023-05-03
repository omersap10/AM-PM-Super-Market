using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AMPM.PROJECT
{
    public partial class FormSnacks : Form 
    {
        
        public FormSnacks()
        {
            InitializeComponent();
        }


        private void closeSnacks_Click(object sender, EventArgs e)//close snacks button
        {
            this.Close();
        }

        private void FormSnacks_Load(object sender, EventArgs e)//loading a snacks array
        {
            labelAmountBamba.Text = allData.snacksArray[0].getAmount().ToString();
            labelChipsAmount.Text = allData.snacksArray[1].getAmount().ToString();
            labelAmountDoritos.Text = allData.snacksArray[2].getAmount().ToString();
            labelKinderAmount.Text = allData.snacksArray[3].getAmount().ToString();
            labelAmountKlik.Text = allData.snacksArray[4].getAmount().ToString();

            //tool tip setup:

            toolTipBamba.SetToolTip(pictureBox1, "Name: " + allData.snacksArray[0].getName() + "\nPrice: " + allData.snacksArray[0].getPrice()
                + "\nExp: " + allData.snacksArray[0].getExp().getDay() + "/" + allData.snacksArray[0].getExp().getMonth() +
                "/" + allData.snacksArray[0].getExp().getYear() + "\nCalories: " + allData.snacksArray[0].getCalories() +
                "\nSugar: " + allData.snacksArray[0].getSugar() + "\nSodium: " +
                allData.snacksArray[0].getSodium() + "\nCarbohydrate: " + allData.snacksArray[0].getCarbohydrate());

            toolTipChips.SetToolTip(pictureBox2, "Name: " + allData.snacksArray[1].getName() + "\nPrice: " + allData.snacksArray[1].getPrice()
                + "\nExp: " + allData.snacksArray[1].getExp().getDay() + "/" + allData.snacksArray[1].getExp().getMonth() +
                "/" + allData.snacksArray[1].getExp().getYear() + "\nCalories: " + allData.snacksArray[1].getCalories() +
                "\nSugar: " + allData.snacksArray[1].getSugar() + "\nSodium: " +
                allData.snacksArray[1].getSodium() + "\nCarbohydrate: " + allData.snacksArray[1].getCarbohydrate());

            toolTipDoritos.SetToolTip(pictureBox3, "Name: " + allData.snacksArray[2].getName() + "\nPrice: " + allData.snacksArray[2].getPrice()
                + "\nExp: " + allData.snacksArray[2].getExp().getDay() + "/" + allData.snacksArray[2].getExp().getMonth() +
                "/" + allData.snacksArray[2].getExp().getYear() + "\nCalories: " + allData.snacksArray[2].getCalories() +
                "\nSugar: " + allData.snacksArray[2].getSugar() + "\nSodium: " +
                allData.snacksArray[2].getSodium() + "\nCarbohydrate: " + allData.snacksArray[2].getCarbohydrate());

            toolTipKinder.SetToolTip(pictureBox4, "Name: " + allData.snacksArray[3].getName() + "\nPrice: " + allData.snacksArray[3].getPrice()
                + "\nExp: " + allData.snacksArray[3].getExp().getDay() + "/" + allData.snacksArray[3].getExp().getMonth() +
                "/" + allData.snacksArray[3].getExp().getYear() + "\nCalories: " + allData.snacksArray[3].getCalories() +
                "\nSugar: " + allData.snacksArray[3].getSugar() + "\nSodium: " +
                allData.snacksArray[3].getSodium() + "\nCarbohydrate: " + allData.snacksArray[3].getCarbohydrate());

            toolTipKlik.SetToolTip(pictureBox5, "Name: " + allData.snacksArray[4].getName() + "\nPrice: " + allData.snacksArray[4].getPrice()
                + "\nExp: " + allData.snacksArray[4].getExp().getDay() + "/" + allData.snacksArray[4].getExp().getMonth() +
                "/" + allData.snacksArray[4].getExp().getYear() + "\nCalories: " + allData.snacksArray[4].getCalories() +
                "\nSugar: " + allData.snacksArray[4].getSugar() + "\nSodium: " +
                allData.snacksArray[4].getSodium() + "\nCarbohydrate: " + allData.snacksArray[4].getCarbohydrate());
        }
        private void labelAmountBamba_Click(object sender, EventArgs e) //non-functional
        {

        }

        private void plusBamba_Click(object sender, EventArgs e)//add bamba
        {
            allData.snacksArray[0].setAmount(allData.snacksArray[0].getAmount() + 1);
            labelAmountBamba.Text = allData.snacksArray[0].getAmount().ToString();
        }

        private void minusBamba_Click(object sender, EventArgs e)//remove bamba
        {
            if (allData.snacksArray[0].getAmount() > 0)
            {
                allData.snacksArray[0].setAmount(allData.snacksArray[0].getAmount() - 1);
                labelAmountBamba.Text = allData.snacksArray[0].getAmount().ToString();
            }
        }

        private void plusChips_Click(object sender, EventArgs e)//add chips
        {
            allData.snacksArray[1].setAmount(allData.snacksArray[1].getAmount() + 1);
            labelChipsAmount.Text = allData.snacksArray[1].getAmount().ToString();
        }

        private void minusChips_Click(object sender, EventArgs e)//remove chips
        {
            if (allData.snacksArray[1].getAmount() > 0)
            {
                allData.snacksArray[1].setAmount(allData.snacksArray[1].getAmount() - 1);
                labelChipsAmount.Text = allData.snacksArray[1].getAmount().ToString();
            }
        }

        private void plusDoritos_Click(object sender, EventArgs e)//add doritos
        {
            allData.snacksArray[2].setAmount(allData.snacksArray[2].getAmount() + 1);
            labelAmountDoritos.Text = allData.snacksArray[2].getAmount().ToString();
        }

        private void minusDoritos_Click(object sender, EventArgs e)//remove doritos
        {
            if (allData.snacksArray[2].getAmount() > 0)
            {
                allData.snacksArray[2].setAmount(allData.snacksArray[2].getAmount() - 1);
                labelAmountDoritos.Text = allData.snacksArray[2].getAmount().ToString();
            }
        }

        private void plusKinder_Click(object sender, EventArgs e)//add kinder
        {
            allData.snacksArray[3].setAmount(allData.snacksArray[3].getAmount() + 1);
            labelKinderAmount.Text = allData.snacksArray[3].getAmount().ToString();
        }

        private void minusKinder_Click(object sender, EventArgs e)//remove kinder
        {
            if (allData.snacksArray[3].getAmount() > 0)
            {
                allData.snacksArray[3].setAmount(allData.snacksArray[3].getAmount() - 1);
                labelKinderAmount.Text = allData.snacksArray[3].getAmount().ToString();
            }
        }

        private void plusKlik_Click(object sender, EventArgs e)//add klik
        {
            allData.snacksArray[4].setAmount(allData.snacksArray[4].getAmount() + 1);
            labelAmountKlik.Text = allData.snacksArray[4].getAmount().ToString();
        }

        private void minusKlik_Click(object sender, EventArgs e)//remove klik
        {
            if (allData.snacksArray[4].getAmount() > 0)
            {
                allData.snacksArray[4].setAmount(allData.snacksArray[4].getAmount() - 1);
                labelAmountKlik.Text = allData.snacksArray[4].getAmount().ToString();
            }
        }
    }
}
