using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmCaracterul_Ascii : Form
    {
        public frmCaracterul_Ascii()
        {
            InitializeComponent();
        }
    private void tbLitera_KeyUp(object sender, KeyEventArgs e)
   {
          if (e.KeyValue > 64 & e.KeyValue < 91) 
                {
                    lbUltimaLitera.Text = e.KeyData.ToString();
                    lstValori.Items.Add(e.KeyData);//Adaugam litera tastata in lista pentru reutilizare
                    int nr;
                    nr = e.KeyValue;  //Atribuim variabilei nr valoarea literei tastate
                    tbAscii.Text = nr.ToString();  //Transferam casutei tbAscii valoarea in text a variabilei nr
                    transformaBinar(tbAscii.Text);  //Apelam functia pentru transformarea valorii literei tastate in binar
                }
         tbLitera.Text = "";  //Reinitializam afisarea casutei tbLitera                                  
   }
        private void lstValori_Click(object sender, EventArgs e)
        {
            /*Declaram variabilele element_selectat si ascii_element_selectat,
             citim valoarea din lista si o scriem in textbox tbAscii */
            char element_selectat = (lstValori.SelectedItem.ToString())[0];
            lbUltimaLitera.Text = lstValori.Text;
            int ascii_element_selectat = (int)element_selectat;
            tbAscii.Text = ascii_element_selectat.ToString();
            transformaBinar(tbAscii.Text);
        }

        private void transformaBinar(string nrAscii)
        {
            int int_nrAscii;//valoarea intreaga a caracterului ASCII
            int i;
            //initializez lbBinar
            lbBinar.Text = "";
            char[] bin = new char[8];
            int_nrAscii = Convert.ToInt16(nrAscii);

            for (i = 0; i < 8; i++)  //Calculam valoarea binara a parametrului nrAscii
            {
                if (int_nrAscii % 2 == 0)
                    bin[7 - i] = '0';
                else
                    bin[7 - i] = '1';
                int_nrAscii = int_nrAscii / 2;
            }

            for (i = 0; i < 8; i++)  //Includem in vectorul bin[] valorile binare calculate 
            {
                if (bin[i] == '0')
                {
                    lbBinar.Text = lbBinar.Text + "0";  //Concatenam in lbBinar valorile 0
                }
                if (bin[i] == '1')
                {
                    lbBinar.Text = lbBinar.Text + "1";//Concatenam in lbBinar valorile 1 
                                    }
            }
        } 
        private void button1_Click(object sender, EventArgs e)
        {//Stergem lista si reinitializam lbBinar si tbAscii
            lstValori.Items.Clear();
            lbBinar.Text="";
            tbAscii.Text="";
        }
        private void lstValori_SelectedIndexChanged(object sender, EventArgs e){}
        
    }
}
