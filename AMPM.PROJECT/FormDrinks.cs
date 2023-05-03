using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMPM.PROJECT
{
    public partial class FormDrinks : Form
    {
        public FormDrinks()
        {
            InitializeComponent();
        }

        private void closeDrinks_Click(object sender, EventArgs e)//close drinks button
        {
            this.Close();
        }

        private void FormDrinks_Load(object sender, EventArgs e)//loading a drinks array
        {
            labelAmountCola.Text = allData.nonAlcoholArray[0].getAmount().ToString();
            labelAmountSoda.Text = allData.nonAlcoholArray[3].getAmount().ToString();
            labelAmountWater.Text = allData.nonAlcoholArray[4].getAmount().ToString();
            labelAmountTea.Text = allData.nonAlcoholArray[1].getAmount().ToString();
            labelAmountCoffee.Text = allData.nonAlcoholArray[2].getAmount().ToString();
            labelAmountArak.Text = allData.alcoholArray[0].getAmount().ToString();
            labelAmountWhiskey.Text = allData.alcoholArray[1].getAmount().ToString();
            labelAmountWine.Text = allData.alcoholArray[2].getAmount().ToString();
            labelAmountRum.Text = allData.alcoholArray[3].getAmount().ToString();

            //tool tip setup:

            toolTipCola.SetToolTip(pictureBox4, "Name: " + allData.nonAlcoholArray[0].getName() + "\nPrice: " + allData.nonAlcoholArray[0].getPrice() + "\nExp: " + allData.nonAlcoholArray[0].getExp().getDay() + "/" + allData.nonAlcoholArray[0].getExp().getMonth() + "/" + allData.nonAlcoholArray[0].getExp().getYear()
               + "\nCalories: " + allData.nonAlcoholArray[0].getCalories() + "\nSugar: " + allData.nonAlcoholArray[0].getSugar() +
               "\nCaffeine: " + allData.nonAlcoholArray[0].getCaffeine() + "\nCarbonated: " + allData.nonAlcoholArray[0].getCarbonated());

            toolTipTea.SetToolTip(pictureBox5, "Name: " + allData.nonAlcoholArray[1].getName() + "\nPrice: " + allData.nonAlcoholArray[1].getPrice() + "\nExp: " + allData.nonAlcoholArray[1].getExp().getDay() + "/" + allData.nonAlcoholArray[1].getExp().getMonth() + "/" + allData.nonAlcoholArray[1].getExp().getYear()
                + "\nCalories: " + allData.nonAlcoholArray[1].getCalories() + "\nSugar: " + allData.nonAlcoholArray[0].getSugar() +
               "\nCaffeine: " + allData.nonAlcoholArray[1].getCaffeine() + "\nCarbonated: " + allData.nonAlcoholArray[1].getCarbonated());


            toolTipCoffe.SetToolTip(pictureBox6, "Name: " + allData.nonAlcoholArray[2].getName() + "\nPrice: " + allData.nonAlcoholArray[2].getPrice() + "\nExp: " + allData.nonAlcoholArray[2].getExp().getDay() + "/" + allData.nonAlcoholArray[2].getExp().getMonth() + "/" + allData.nonAlcoholArray[2].getExp().getYear()
                + "\nCalories: " + allData.nonAlcoholArray[2].getCalories() + "\nSugar: " + allData.nonAlcoholArray[2].getSugar() +
               "\nCaffeine: " + allData.nonAlcoholArray[2].getCaffeine() + "\nCarbonated: " + allData.nonAlcoholArray[2].getCarbonated());


            toolTipSoda.SetToolTip(pictureBox7, "Name: " + allData.nonAlcoholArray[3].getName() + "\nPrice: " + allData.nonAlcoholArray[3].getPrice() + "\nExp: " + allData.nonAlcoholArray[3].getExp().getDay() + "/" + allData.nonAlcoholArray[3].getExp().getMonth() + "/" + allData.nonAlcoholArray[3].getExp().getYear()
                    + "\nCalories: " + allData.nonAlcoholArray[3].getCalories() + "\nSugar: " + allData.nonAlcoholArray[3].getSugar() +
               "\nCaffeine: " + allData.nonAlcoholArray[3].getCaffeine() + "\nCarbonated: " + allData.nonAlcoholArray[3].getCarbonated());


            toolTipWater.SetToolTip(pictureBox8, "Name: " + allData.nonAlcoholArray[4].getName() + "\nPrice: " + allData.nonAlcoholArray[4].getPrice() + "\nExp: " + allData.nonAlcoholArray[4].getExp().getDay() + "/" + allData.nonAlcoholArray[4].getExp().getMonth() + "/" + allData.nonAlcoholArray[4].getExp().getYear()
                + "\nCalories: " + allData.nonAlcoholArray[4].getCalories() + "\nSugar: " + allData.nonAlcoholArray[4].getSugar() +
               "\nCaffeine: " + allData.nonAlcoholArray[4].getCaffeine() + "\nCarbonated: " + allData.nonAlcoholArray[4].getCarbonated());

            toolTipArak.SetToolTip(pictureBox9, "Name: " + allData.alcoholArray[0].getName() + "\nPrice: " + allData.alcoholArray[0].getPrice() + "\nExp: " + allData.alcoholArray[0].getExp().getDay() + "/" + allData.alcoholArray[0].getExp().getMonth() + "/" + allData.alcoholArray[0].getExp().getYear()
        + "\nCalories: " + allData.alcoholArray[0].getCalories() + "\nSugar: " + allData.alcoholArray[0].getSugar() +
        "\nCaffeine: " + allData.alcoholArray[0].getCaffeine() + "\nAlcohol: " + allData.alcoholArray[0].getAlcohol());

            toolTipWhisky.SetToolTip(pictureBox10, "Name: " + allData.alcoholArray[1].getName() + "\nPrice: " + allData.alcoholArray[1].getPrice() + "\nExp: " + allData.alcoholArray[1].getExp().getDay() + "/" + allData.alcoholArray[1].getExp().getMonth() + "/" + allData.alcoholArray[1].getExp().getYear()
                + "\nCalories: " + allData.alcoholArray[1].getCalories() + "\nSugar: " + allData.alcoholArray[1].getSugar() +
               "\nCaffeine: " + allData.alcoholArray[1].getCaffeine() + "\nAlcohol: " + allData.alcoholArray[1].getAlcohol());


            toolTipWine.SetToolTip(pictureBox11, "Name: " + allData.alcoholArray[2].getName() + "\nPrice: " + allData.alcoholArray[2].getPrice() + "\nExp: " + allData.alcoholArray[2].getExp().getDay() + "/" + allData.alcoholArray[2].getExp().getMonth() + "/" + allData.alcoholArray[2].getExp().getYear()
                + "\nCalories: " + allData.alcoholArray[2].getCalories() + "\nSugar: " + allData.alcoholArray[2].getSugar() +
               "\nCaffeine: " + allData.alcoholArray[2].getCaffeine() + "\nAlcohol: " + allData.alcoholArray[2].getAlcohol());


            toolTipRum.SetToolTip(pictureBox12, "Name: " + allData.alcoholArray[3].getName() + "\nPrice: " + allData.alcoholArray[3].getPrice() + "\nExp: " + allData.alcoholArray[3].getExp().getDay() + "/" + allData.alcoholArray[3].getExp().getMonth() + "/" + allData.alcoholArray[3].getExp().getYear()
                    + "\nCalories: " + allData.alcoholArray[3].getCalories() + "\nSugar: " + allData.alcoholArray[3].getSugar() +
               "\nCaffeine: " + allData.alcoholArray[3].getCaffeine() + "\nAlcohol: " + allData.alcoholArray[3].getAlcohol());

        }

        private void plusCola_Click(object sender, EventArgs e)//add cola
        {
            allData.nonAlcoholArray[0].setAmount(allData.nonAlcoholArray[0].getAmount() + 1);
            labelAmountCola.Text = allData.nonAlcoholArray[0].getAmount().ToString();
        }

        private void minusCola_Click(object sender, EventArgs e)//remove cola
        {
            if (allData.nonAlcoholArray[0].getAmount() > 0)
            {
                allData.nonAlcoholArray[0].setAmount(allData.nonAlcoholArray[0].getAmount() - 1);
                labelAmountCola.Text = allData.nonAlcoholArray[0].getAmount().ToString();
            }
        }

        private void plusSoda_Click(object sender, EventArgs e)//add soda
        {
            allData.nonAlcoholArray[3].setAmount(allData.nonAlcoholArray[3].getAmount() + 1);
            labelAmountSoda.Text = allData.nonAlcoholArray[3].getAmount().ToString();
        }

        private void minusSoda_Click(object sender, EventArgs e)//remove soda
        {
            if (allData.nonAlcoholArray[3].getAmount() > 0)
            {
                allData.nonAlcoholArray[3].setAmount(allData.nonAlcoholArray[3].getAmount() - 1);
                labelAmountSoda.Text = allData.nonAlcoholArray[3].getAmount().ToString();
            }
        }

        private void plusWater_Click(object sender, EventArgs e)//add water
        {
            allData.nonAlcoholArray[4].setAmount(allData.nonAlcoholArray[4].getAmount() + 1);
            labelAmountWater.Text = allData.nonAlcoholArray[4].getAmount().ToString();
        }

        private void minusWater_Click(object sender, EventArgs e)//remove water
        {
            if (allData.nonAlcoholArray[4].getAmount() > 0)
            {
                allData.nonAlcoholArray[4].setAmount(allData.nonAlcoholArray[4].getAmount() - 1);
                labelAmountWater.Text = allData.nonAlcoholArray[4].getAmount().ToString();
            }
        }

        private void plusTea_Click(object sender, EventArgs e)//add tea
        {
            allData.nonAlcoholArray[1].setAmount(allData.nonAlcoholArray[1].getAmount() + 1);
            labelAmountTea.Text = allData.nonAlcoholArray[1].getAmount().ToString();
        }

        private void minusTea_Click(object sender, EventArgs e)//remove tea
        {
            if (allData.nonAlcoholArray[1].getAmount() > 0)
            {
                allData.nonAlcoholArray[1].setAmount(allData.nonAlcoholArray[1].getAmount() - 1);
                labelAmountTea.Text = allData.nonAlcoholArray[1].getAmount().ToString();
            }
        }

        private void plusCoffee_Click(object sender, EventArgs e)//add coffe
        {
            allData.nonAlcoholArray[2].setAmount(allData.nonAlcoholArray[2].getAmount() + 1);
            labelAmountCoffee.Text = allData.nonAlcoholArray[2].getAmount().ToString();
        }

        private void minusCoffee_Click(object sender, EventArgs e)//remove coffe
        {
            if (allData.nonAlcoholArray[2].getAmount() > 0)
            {
                allData.nonAlcoholArray[2].setAmount(allData.nonAlcoholArray[2].getAmount() - 1);
                labelAmountCoffee.Text = allData.nonAlcoholArray[2].getAmount().ToString();
            }
        }

        private void plusArak_Click(object sender, EventArgs e)//add arak
        {
            allData.alcoholArray[0].setAmount(allData.alcoholArray[0].getAmount() + 1);
            labelAmountArak.Text = allData.alcoholArray[0].getAmount().ToString();
        }

        private void minusArak_Click(object sender, EventArgs e)//remove arak
        {
            if (allData.alcoholArray[0].getAmount() > 0)
            {
                allData.alcoholArray[0].setAmount(allData.alcoholArray[0].getAmount() - 1);
                labelAmountArak.Text = allData.alcoholArray[0].getAmount().ToString();
            }
        }

        private void plusWhiskey_Click(object sender, EventArgs e)//add whiskey
        {
            allData.alcoholArray[1].setAmount(allData.alcoholArray[1].getAmount() + 1);
            labelAmountWhiskey.Text = allData.alcoholArray[1].getAmount().ToString();
        }

        private void minusWhiskey_Click(object sender, EventArgs e)//remove whiskey
        {
            if (allData.alcoholArray[1].getAmount() > 0)
            {
                allData.alcoholArray[1].setAmount(allData.alcoholArray[1].getAmount() - 1);
                labelAmountWhiskey.Text = allData.alcoholArray[1].getAmount().ToString();
            }
        }

        private void plusWine_Click(object sender, EventArgs e)//add wine
        {
            allData.alcoholArray[2].setAmount(allData.alcoholArray[2].getAmount() + 1);
            labelAmountWine.Text = allData.alcoholArray[2].getAmount().ToString();
        }

        private void minusWine_Click(object sender, EventArgs e)//remove wine
        {
            if (allData.alcoholArray[2].getAmount() > 0)
            {
                allData.alcoholArray[2].setAmount(allData.alcoholArray[2].getAmount() - 1);
                labelAmountWine.Text = allData.alcoholArray[2].getAmount().ToString();
            }
        }

        private void plusRum_Click(object sender, EventArgs e)//add rum
        {
            allData.alcoholArray[3].setAmount(allData.alcoholArray[3].getAmount() + 1);
            labelAmountRum.Text = allData.alcoholArray[3].getAmount().ToString();
        }

        private void minusRum_Click(object sender, EventArgs e)//remove rum
        {
            if (allData.alcoholArray[3].getAmount() > 0)
            {
                allData.alcoholArray[3].setAmount(allData.alcoholArray[3].getAmount() - 1);
                labelAmountRum.Text = allData.alcoholArray[3].getAmount().ToString();
            }
        }

        private void labelAmountCola_Click(object sender, EventArgs e) //non-functional
        {

        }
    }
}
