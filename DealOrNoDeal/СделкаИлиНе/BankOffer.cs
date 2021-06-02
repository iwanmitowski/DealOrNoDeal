using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделкаИлиНе
{
    public partial class BankOffer : Form
    {

        int deals = 0; 
        List<double> currentPrizes = new List<double>();
        public bool isAccepted = false;
       
        double offer;
        public BankOffer()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            deals++;
            this.DialogResult = DialogResult.OK;
            this.Hide();
            
        }

        private void btnNoDeal_Click(object sender, EventArgs e)
        {
            deals++;
            
            this.Close();
        }

        private void BankOffer_Load(object sender, EventArgs e)
        {
            ReadCurrentPrizes();
            if (deals == 3 || RollRandomOffer() == 0)
            {
                lblDeal.Text = "Смяна на кутиите";

            }
            else
            {
                currentDeal();
                lblDeal.Text = $"{offer:f2} лева.";
            }
            
        }
        //0 = смяна, else = оферта
        private int RollRandomOffer()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 4);// 0,4
            if (isAccepted)
            {
                number = 0;
            }
            return number; 


        }
        private void currentDeal()
        {
            double min = currentPrizes.First();
            double max;
            if (deals < 2)
            {
                max = currentPrizes.Last() / 20.0;
            }
            else
            {
                max = currentPrizes.Last() / 2.0;
            }


            Random rnd = new Random();
            offer = Math.Floor(rnd.NextDouble() * (max - min) + min);
        }
        private void ReadCurrentPrizes()
        {
            string dest = Path.Combine("Prizes.txt");
            List<double> lines = File.ReadAllLines(dest).Select(double.Parse).ToList();
            currentPrizes.Clear();
            currentPrizes.AddRange(lines);

        }
        public string Offer
        {
            get
            {
                return lblDeal.Text;
            }
        }
    }
}
