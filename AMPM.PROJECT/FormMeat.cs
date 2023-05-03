using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AMPM.PROJECT
{
    public partial class FormMeat : Form
    {
        public FormMeat()
        {
            InitializeComponent();
        }


        private void closeMeat_Click(object sender, EventArgs e)//close meat button
        {
            this.Close();
        }

        private void FormMeat_Load(object sender, EventArgs e)//loading a meat array
        {
            labelChickenAmount.Text = allData.meatArray[0].getAmount().ToString();
            labelAmountSalmon.Text = allData.meatArray[1].getAmount().ToString();
            labelAmountSteak.Text = allData.meatArray[2].getAmount().ToString();
            labelAmountKabab.Text = allData.meatArray[3].getAmount().ToString();
            labelAmountHam.Text = allData.meatArray[4].getAmount().ToString();
            labelAmountShrimps.Text = allData.meatArray[5].getAmount().ToString();

            //tool tip setup:

            toolTipChicken.SetToolTip(pictureBox1, "Name: " + allData.meatArray[0].getName() + "\nPrice: " + allData.meatArray[0].getPrice() + "\nExp: " +
                allData.meatArray[0].getExp().getDay()+ "/" + allData.meatArray[0].getExp().getMonth() + "/" + allData.meatArray[0].getExp().getYear()
                + "\nCalories: " + allData.meatArray[0].getCalories()+"\nWeight: "+allData.meatArray[0].getWeight()+"\nKosher: "+
                allData.meatArray[0].getKosher()+"\nFats: "+allData.meatArray[0].getFats());

            toolTipSalmon.SetToolTip(pictureBox2, "Name: " + allData.meatArray[1].getName() + "\nPrice: " + allData.meatArray[1].getPrice() + "\nExp: " +
                allData.meatArray[1].getExp().getDay() + "/" + allData.meatArray[1].getExp().getMonth() + "/" + allData.meatArray[1].getExp().getYear()
                + "\nCalories: " + allData.meatArray[1].getCalories() + "\nWeight: " + allData.meatArray[1].getWeight() + "\nKosher: " +
                allData.meatArray[1].getKosher() + "\nFats: " + allData.meatArray[1].getFats());

            toolTipSteack.SetToolTip(pictureBox3, "Name: " + allData.meatArray[2].getName() + "\nPrice: " + allData.meatArray[2].getPrice() + "\nExp: " +
                allData.meatArray[2].getExp().getDay() + "/" + allData.meatArray[2].getExp().getMonth() + "/" + allData.meatArray[2].getExp().getYear()
                + "\nCalories: " + allData.meatArray[2].getCalories() + "\nWeight: " + allData.meatArray[2].getWeight() + "\nKosher: " +
                allData.meatArray[2].getKosher() + "\nFats: " + allData.meatArray[2].getFats());

            toolTipKabab.SetToolTip(pictureBox4, "Name: " + allData.meatArray[3].getName() + "\nPrice: " + allData.meatArray[3].getPrice() + "\nExp: " +
                allData.meatArray[3].getExp().getDay() + "/" + allData.meatArray[3].getExp().getMonth() + "/" + allData.meatArray[3].getExp().getYear()
                + "\nCalories: " + allData.meatArray[3].getCalories() + "\nWeight: " + allData.meatArray[3].getWeight() + "\nKosher: " +
                allData.meatArray[3].getKosher() + "\nFats: " + allData.meatArray[3].getFats());

            toolTipHam.SetToolTip(pictureBox5, "Name: " + allData.meatArray[4].getName() + "\nPrice: " + allData.meatArray[4].getPrice() + "\nExp: " +
                allData.meatArray[4].getExp().getDay() + "/" + allData.meatArray[4].getExp().getMonth() + "/" + allData.meatArray[4].getExp().getYear()
                + "\nCalories: " + allData.meatArray[4].getCalories() + "\nWeight: " + allData.meatArray[4].getWeight() + "\nKosher: " +
                allData.meatArray[4].getKosher() + "\nFats: " + allData.meatArray[4].getFats());

            toolTipShrimps.SetToolTip(pictureBox6, "Name: " + allData.meatArray[5].getName() + "\nPrice: " + allData.meatArray[5].getPrice() + "\nExp: " +
                allData.meatArray[5].getExp().getDay() + "/" + allData.meatArray[5].getExp().getMonth() + "/" + allData.meatArray[5].getExp().getYear()
                + "\nCalories: " + allData.meatArray[5].getCalories() + "\nWeight: " + allData.meatArray[5].getWeight() + "\nKosher: " +
                allData.meatArray[5].getKosher() + "\nFats: " + allData.meatArray[5].getFats());

        }

        private void plusChicken_Click(object sender, EventArgs e)//add chicken
        {
            allData.meatArray[0].setAmount(allData.meatArray[0].getAmount()+1);
            labelChickenAmount.Text = allData.meatArray[0].getAmount().ToString();

        }

        private void minusChicken_Click(object sender, EventArgs e)//remove chicken
        {
            if(allData.meatArray[0].getAmount() > 0)
            {
                allData.meatArray[0].setAmount(allData.meatArray[0].getAmount() - 1);
                labelChickenAmount.Text = allData.meatArray[0].getAmount().ToString();
            }
        }

        private void labelChickenAmount_Click(object sender, EventArgs e) //non-functinol
        {

        }

        private void minusSalmon_Click(object sender, EventArgs e)//remove salmon
        {
            if (allData.meatArray[1].getAmount() > 0)
            {
                allData.meatArray[1].setAmount(allData.meatArray[1].getAmount() - 1);
                labelAmountSalmon.Text = allData.meatArray[1].getAmount().ToString();
            }
        }

        private void plusSalmon_Click(object sender, EventArgs e)//add salmon
        {
            allData.meatArray[1].setAmount(allData.meatArray[1].getAmount() + 1);
            labelAmountSalmon.Text = allData.meatArray[1].getAmount().ToString();
        }

        private void minusSteak_Click(object sender, EventArgs e)//remove steak
        {
            if (allData.meatArray[2].getAmount() > 0)
            {
                allData.meatArray[2].setAmount(allData.meatArray[2].getAmount() - 1);
                labelAmountSteak.Text = allData.meatArray[2].getAmount().ToString();
            }
        }

        private void plusSteak_Click(object sender, EventArgs e)//add steak
        {
            allData.meatArray[2].setAmount(allData.meatArray[2].getAmount() + 1);
            labelAmountSteak.Text = allData.meatArray[2].getAmount().ToString();
        }

        private void minusKabab_Click(object sender, EventArgs e)//remove kabab
        {
            if (allData.meatArray[3].getAmount() > 0)
            {
                allData.meatArray[3].setAmount(allData.meatArray[3].getAmount() - 1);
                labelAmountKabab.Text = allData.meatArray[3].getAmount().ToString();
            }
        }

        private void plusKabab_Click(object sender, EventArgs e)//add kabab
        {
            allData.meatArray[3].setAmount(allData.meatArray[3].getAmount() + 1);
            labelAmountKabab.Text = allData.meatArray[3].getAmount().ToString();
        }

        private void minusHam_Click(object sender, EventArgs e)//remove ham
        {
            if (allData.meatArray[4].getAmount() > 0)
            {
                allData.meatArray[4].setAmount(allData.meatArray[4].getAmount() - 1);
                labelAmountHam.Text = allData.meatArray[4].getAmount().ToString();
            }
        }

        private void plusHam_Click(object sender, EventArgs e)//add ham
        {
            allData.meatArray[4].setAmount(allData.meatArray[4].getAmount() + 1);
            labelAmountHam.Text = allData.meatArray[4].getAmount().ToString();
        }

        private void minusShrimps_Click(object sender, EventArgs e)//remove shrimps
        {
            if (allData.meatArray[5].getAmount() > 0)
            {
                allData.meatArray[5].setAmount(allData.meatArray[5].getAmount() - 1);
                labelAmountShrimps.Text = allData.meatArray[5].getAmount().ToString();
            }
        }

        private void plusShrimps_Click(object sender, EventArgs e)//add shrimps
        {
            allData.meatArray[5].setAmount(allData.meatArray[5].getAmount() + 1);
            labelAmountShrimps.Text = allData.meatArray[5].getAmount().ToString();
        }
    }
}
