using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMPM.PROJECT
{
    public partial class FormDairy : Form
    {
        public FormDairy()
        {
            InitializeComponent();
        }

        private void closeDairy_Click(object sender, EventArgs e)//close diary button
        {
            this.Close();
        }

        private void FormDairy_Load(object sender, EventArgs e)//loading a dairy array
        {
            labelCheeseAmount.Text = allData.dairyArray[0].getAmount().ToString();
            labelAmountMilk.Text = allData.dairyArray[1].getAmount().ToString();
            labelCreamAmount.Text = allData.dairyArray[2].getAmount().ToString();
            labelAmountYougort.Text = allData.dairyArray[3].getAmount().ToString();
            labelAmountButter.Text = allData.dairyArray[4].getAmount().ToString();

            //tool tip setup:

            toolTipCheese.SetToolTip(pictureBox1, "Name: " + allData.dairyArray[0].getName() +"\nPrice: " + allData.dairyArray[0].getPrice() + "\nExp: "+ allData.dairyArray[0].getExp().getDay()+"/" + allData.dairyArray[0].getExp().getMonth() + "/" + allData.dairyArray[0].getExp().getYear()
                + "\nCalories: " + allData.dairyArray[0].getCalories() + "\nProtein: " + allData.dairyArray[0].getProtein() + "\nFats: " + allData.dairyArray[0].getFats() +
                "\nCalcium: " + allData.dairyArray[0].getCalcium());

            toolTipMilk.SetToolTip(pictureBox2, "Name: " + allData.dairyArray[1].getName() + "\nPrice: " + allData.dairyArray[1].getPrice() + "\nExp: " + allData.dairyArray[1].getExp().getDay() + "/" + allData.dairyArray[1].getExp().getMonth() + "/" + allData.dairyArray[1].getExp().getYear()
                + "\nCalories: " + allData.dairyArray[1].getCalories() + "\nProtein: " + allData.dairyArray[1].getProtein() + "\nFats: " + allData.dairyArray[1].getFats() +
                "\nCalcium: " + allData.dairyArray[1].getCalcium());

            toolTipCream.SetToolTip(pictureBox3, "Name: " + allData.dairyArray[2].getName() + "\nPrice: " + allData.dairyArray[2].getPrice() + "\nExp: " + allData.dairyArray[2].getExp().getDay() + "/" + allData.dairyArray[2].getExp().getMonth() + "/" + allData.dairyArray[2].getExp().getYear()
                + "\nCalories: " + allData.dairyArray[2].getCalories() + "\nProtein: " + allData.dairyArray[2].getProtein() + "\nFats: " + allData.dairyArray[2].getFats() +
                "\nCalcium: " + allData.dairyArray[2].getCalcium());

            toolTipYougort.SetToolTip(pictureBox4, "Name: " + allData.dairyArray[3].getName() + "\nPrice: " + allData.dairyArray[3].getPrice() + "\nExp: " + allData.dairyArray[3].getExp().getDay() + "/" + allData.dairyArray[3].getExp().getMonth() + "/" + allData.dairyArray[3].getExp().getYear()
                    + "\nCalories: " + allData.dairyArray[3].getCalories() + "\nProtein: " + allData.dairyArray[3].getProtein() + "\nFats: " + allData.dairyArray[3].getFats() +
                    "\nCalcium: " + allData.dairyArray[3].getCalcium());

            toolTipButter.SetToolTip(pictureBox5, "Name: " + allData.dairyArray[4].getName() + "\nPrice: " + allData.dairyArray[4].getPrice() + "\nExp: " + allData.dairyArray[4].getExp().getDay() + "/" + allData.dairyArray[4].getExp().getMonth() + "/" + allData.dairyArray[4].getExp().getYear()
                + "\nCalories: " + allData.dairyArray[4].getCalories() + "\nProtein: " + allData.dairyArray[4].getProtein() + "\nFats: " + allData.dairyArray[4].getFats() +
                "\nCalcium: " + allData.dairyArray[4].getCalcium());

        }

        private void plusCheese_Click(object sender, EventArgs e)//add cheese
        {
            allData.dairyArray[0].setAmount(allData.dairyArray[0].getAmount() + 1);
            labelCheeseAmount.Text = allData.dairyArray[0].getAmount().ToString();
        }

        private void minusCheese_Click(object sender, EventArgs e)//remove cheese
        {
            if (allData.dairyArray[0].getAmount() > 0)
            {
                allData.dairyArray[0].setAmount(allData.dairyArray[0].getAmount() - 1);
                labelCheeseAmount.Text = allData.dairyArray[0].getAmount().ToString();
            }
        }

        private void plusMilk_Click(object sender, EventArgs e)//add milk
        {
            allData.dairyArray[1].setAmount(allData.dairyArray[1].getAmount() + 1);
            labelAmountMilk.Text = allData.dairyArray[1].getAmount().ToString();
        }

        private void minusMilk_Click(object sender, EventArgs e)//remove milk
        {
            if (allData.dairyArray[1].getAmount() > 0)
            {
                allData.dairyArray[1].setAmount(allData.dairyArray[1].getAmount() - 1);
                labelAmountMilk.Text = allData.dairyArray[1].getAmount().ToString();
            }
        }

        private void plusCream_Click(object sender, EventArgs e)//add cream
        {
            allData.dairyArray[2].setAmount(allData.dairyArray[2].getAmount() + 1);
            labelCreamAmount.Text = allData.dairyArray[2].getAmount().ToString();
        }

        private void minusCream_Click(object sender, EventArgs e)//remove cream
        {
            if (allData.dairyArray[2].getAmount() > 0)
            {
                allData.dairyArray[2].setAmount(allData.dairyArray[2].getAmount() - 1);
                labelCreamAmount.Text = allData.dairyArray[2].getAmount().ToString();
            }
        }

        private void plusYougort_Click(object sender, EventArgs e)//add yougort
        {
            allData.dairyArray[3].setAmount(allData.dairyArray[3].getAmount() + 1);
            labelAmountYougort.Text = allData.dairyArray[3].getAmount().ToString();
        }

        private void minusYougurt_Click(object sender, EventArgs e)//remove yougort
        {
            if (allData.dairyArray[3].getAmount() > 0)
            {
                allData.dairyArray[3].setAmount(allData.dairyArray[3].getAmount() - 1);
                labelAmountYougort.Text = allData.dairyArray[3].getAmount().ToString();
            }
        }

        private void plusButter_Click(object sender, EventArgs e)//add butter
        {
            allData.dairyArray[4].setAmount(allData.dairyArray[4].getAmount() + 1);
            labelAmountButter.Text = allData.dairyArray[4].getAmount().ToString();
        }

        private void minusButter_Click(object sender, EventArgs e)//remove butter
        {
            if (allData.dairyArray[4].getAmount() > 0)
            {
                allData.dairyArray[4].setAmount(allData.dairyArray[4].getAmount() - 1);
                labelAmountButter.Text = allData.dairyArray[4].getAmount().ToString();
            }
        }

        private void labelCheeseAmount_Click(object sender, EventArgs e) //non-functional
        {

        }
    }
}
