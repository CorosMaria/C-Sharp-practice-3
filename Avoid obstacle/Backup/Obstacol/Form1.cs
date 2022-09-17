using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Obstacol
{
    public partial class Form1 : Form
    {
            float LatimeBanda = 100;
            float MargineStanga = 10;
            float MargineSus = 100;
            int PozitieObstacolStart= 0;
            int PozitieObstacolInainte = 0;
            int PozitieObstacolDupa = 1;
            int depasireY = 0;
            int revenireY = 0;
            bool Depasire = true;
            bool Revenire= true;
            System.Drawing.Graphics Desen;
            System.Drawing.Pen Creion_alb;
            System.Drawing.SolidBrush Pensula_gri;
            System.Drawing.SolidBrush Pensula_Rosie;
            System.Drawing.SolidBrush Pensula_galbena;
            Point[] Obstacol = new Point[] 
            {   new Point { X = 430, Y = 200 },new Point { X = 440, Y = 210 }, 
                new Point { X = 440, Y = 240 },new Point { X = 430, Y = 240 },
                new Point { X = 420, Y = 240 },new Point { X = 400, Y = 220 },
                new Point { X = 410, Y = 210 },new Point { X = 420, Y = 210 }
            };
            Point[] Masina = new Point[] 
            {   new Point { X = 0, Y = 210 },new Point { X = 90, Y = 210 },
                new Point { X = 110, Y = 215 },new Point { X = 110, Y = 245 },
                new Point { X = 90, Y = 250 }, new Point { X = 0, Y = 250 },
            };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Desen = this.CreateGraphics();
        }

        public void DeseneazaScena()
        {
            Desen.Clear(this.BackColor);
            Pensula_gri = new System.Drawing.SolidBrush(System.Drawing.Color.Gray);
            Creion_alb = new System.Drawing.Pen(System.Drawing.Color.White);
            Creion_alb.Width = 6;
            Pensula_Rosie = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
            Pensula_galbena = new System.Drawing.SolidBrush(System.Drawing.Color.Yellow);
            // Desenam partea carsabila
            Desen.FillRectangle(Pensula_gri, MargineStanga, MargineSus, this.Width - 3 * MargineStanga, MargineSus + LatimeBanda);
            // Trasam marginile drumului
            Desen.DrawLine(Creion_alb, MargineStanga, MargineSus + 10, this.Width - 3 * MargineStanga, MargineSus + 10);
            Desen.DrawLine(Creion_alb, MargineStanga, MargineSus + 2 * LatimeBanda - 10, this.Width - 3 * MargineStanga, MargineSus + 2 * LatimeBanda - 10);
            // Trasam linia discontinua 
            float[] Discontinuitate = { 15, 15, 15, 15 };
            Creion_alb.DashPattern = Discontinuitate;
            Desen.DrawLine(Creion_alb, MargineStanga, MargineSus + LatimeBanda, this.Width, MargineSus + LatimeBanda);
        }
        public void DeseneazaObstacol()
        {
                for (int i = 0; i < 8; i++)
                {
                    Obstacol[i].X = Obstacol[i].X + PozitieObstacolInainte;
                    Obstacol[i].Y = Obstacol[i].Y ;
                }
                PozitieObstacolDupa = PozitieObstacolInainte;
                PozitieObstacolInainte = 0;
                Desen.FillPolygon(Pensula_galbena, Obstacol);
        }

        public void DeseneazaMasina()
        {
            for (int i = 0; i <= 5; i++)
            {
                Masina[i].X = Masina[i].X + 5;
                Masina[i].Y = Masina[i].Y + depasireY + revenireY;
            }
            Desen.FillPolygon(Pensula_Rosie, Masina);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DeseneazaScena();
            DeseneazaObstacol();
            //Intrare in depasire
            if (Obstacol[1].X > Masina[3].X)
            {
                if (Obstacol[1].X - Masina[3].X < 90)
                {
                if ((depasireY > -10) && (Depasire == true))
                {
                    depasireY = depasireY - 1;
                }
                else
                {
                    depasireY = 0;
                    Depasire = false;
                }
                }
            }
            //revenire pe banda
            if (Obstacol[1].X < Masina[3].X)
            {
                if (Masina[3].X - Obstacol[1].X > 90) 
                {
                if ((revenireY < 10) && (Revenire == true))
                {
                    revenireY = revenireY + 1;
                }
                else {
                    revenireY = 0;
                    Revenire = false;
                }
                }
            }
            if ((Depasire == false))
            {
                depasireY = 0;
            }
            if ((Revenire == false))
            {
                revenireY = 0;
            }
            DeseneazaMasina();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            PozitieObstacolInainte =(e.X - Obstacol[1].X);
            PozitieObstacolStart =  (e.X - Obstacol[1].X);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LatimeBanda = 100;
            MargineStanga = 10;
            MargineSus = 100;
            PozitieObstacolStart = 0;
            PozitieObstacolInainte = 0;
            PozitieObstacolDupa = 1;
            depasireY = 0;
            revenireY = 0;
            Depasire = true;
            Revenire = true;
            Masina[0].X = 0;    Masina[0].Y = 210 ; 
            Masina[1].X = 90;   Masina[1].Y = 210 ;
            Masina[2].X = 110;  Masina[2].Y = 215 ;
            Masina[3].X = 110;  Masina[3].Y = 245 ;
            Masina[4].X = 90;   Masina[4].Y = 250 ;
            Masina[5].X = 0;    Masina[5].Y = 250 ;
            timer1.Enabled = true;
        }
        }
    }

