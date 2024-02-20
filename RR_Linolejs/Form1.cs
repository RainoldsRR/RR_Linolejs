using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RR_Linolejs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void izmaksas_Click(object sender, EventArgs e)
        {

        }

        private void ievadcena_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ievadrulplatums_TextChanged(object sender, EventArgs e)
        {

        }

        private void izvadizmaksas_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void aprekinat_Click(object sender, EventArgs e)
        {
            double cena1 = Convert.ToDouble(ievadcena.Text);
            int linoleja_platums1 = Convert.ToInt32(ievadrulplatums.Text);
            int telpas_garums1 = Convert.ToInt32(ievadtelpgarums.Text);
            int telpas_platums1 = Convert.ToInt32(ievadtelpplatums.Text);

            gridas_izmaksa(cena1, linoleja_platums1, telpas_platums1, telpas_garums1);
            //double cena, int linoleja_platums, int telpas_platums, int telpas_garums
        }
        public void gridas_izmaksa(double cena, int linoleja_platums, int telpas_platums, int telpas_garums)
        { 
         int telpas_izmers = telpas_platums * telpas_garums;
            double gizvadizmaksas = cena * (telpas_izmers / linoleja_platums);

            izvadizmaksas.Text = gizvadizmaksas.ToString();
        }
    }
}
