using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public bool buttonpressed = false;
        public int pTier { get; set; }
        public int mTier { get; set;}
        public int demand { get; set;}
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tavernTier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            minionOdds.Visible = true;
            
            label4.Visible = true;

            buttonpressed = true;
            var odds = new Method();
            minionOdds.Text = odds.oddsForMinion(pTier, mTier, demand).ToString();
        }

        private void minionTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            minionDemand.Visible = true;
            label3.Visible = true;
            switch (minionTier.Text)
            {
                case "Tavern Tier 1":
                    mTier = 1;
                    break;
                case "Tavern Tier 2":
                    mTier =2;
                    break;
                case "Tavern Tier 3":
                    mTier = 3;
                    break;
                case "Tavern Tier 4":
                    mTier = 4;
                    break;
                case "Tavern Tier 5":
                    mTier = 5;
                    break;
                case "Tavern Tier 6":
                    mTier = 6;
                    break;
            }
            if (buttonpressed == true)
            {
                var odds = new Method();
                minionOdds.Text = odds.oddsForMinion(pTier, mTier, demand).ToString();
            }
        }

        private void playerTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (playerTier.Text)
            {
                case "Tavern Tier 1":
                    pTier = 1;
                    break;
                case "Tavern Tier 2":
                    pTier = 2;
                    break;
                case "Tavern Tier 3":
                    pTier = 3;
                    break;
                case "Tavern Tier 4":
                    pTier = 4;
                    break;
                case "Tavern Tier 5":
                    pTier = 5;
                    break;
                case "Tavern Tier 6":
                    pTier = 6;
                    break;
            }
            minionTier.Visible = true;
            label2.Visible = true;
            if(buttonpressed == true)
            {
                var odds = new Method();
                minionOdds.Text = odds.oddsForMinion(pTier, mTier, demand).ToString();
            }
        }

        private void minionDemand_SelectedIndexChanged(object sender, EventArgs e)
        {
            button.Visible = true;
            switch (minionDemand.Text)
            {
                case "No Demand":
                    demand = 0;
                    break;
                case "Low Demand":
                    demand = 1;
                    break;
                case "Medium Demand":
                    demand = 2;
                    break;
                case "High Demand":
                    demand = 3;
                    break;
                case "Very High Demand":
                    demand = 4;
                    break;
            }
            if (buttonpressed == true)
            {
                var odds = new Method();
                minionOdds.Text = odds.oddsForMinion(pTier, mTier, demand).ToString();
            }
        }
    }
}
