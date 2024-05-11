using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        double alfa;
        Random rand = new Random();        
        int[] rang = {1 ,2, 3, 5};
        int[] score = { 0,0,0,0};
        int match = 0;
        int[] indexTeam = new int[2];


        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            match++;

            for (int i = 0; i < rang.Length; i++) 
            {
                score[i] = Poisson(rang[i]);
            }
            
            if (match < 2) 
            {                    
                
                
                if (score[0] > score[1])
                {
                    label11.Text = label1.Text;
                    label11.Visible = true;
                    
                    indexTeam[0] = 0;
                    label1.BackColor = Color.LawnGreen;

                }
                else 
                {
                    label11.Text = label2.Text;
                    label11.Visible = true;
                    //match++;
                    indexTeam[0] = 1;
                    label2.BackColor = Color.LawnGreen;
                }

                if (score[2] > score[3])
                {
                    label12.Text = label3.Text;
                    label12.Visible = true;
                    //match++;
                    indexTeam[1] = 2;
                    label3.BackColor = Color.LawnGreen;
                }
                else
                {
                    label12.Text = label4.Text;
                    label12.Visible = true;
                    //match++;
                    indexTeam[1] = 3;
                    label4.BackColor = Color.LawnGreen;
                }
                
                label1.Text = label1.Text + "  " +  score[0].ToString();
                label2.Text = label2.Text + "  " + score[1].ToString();
                label3.Text = label3.Text + "  " + score[2].ToString();
                label4.Text = label4.Text + "  " + score[3].ToString();
            }

            if(match == 2)
            {
                if (score[indexTeam[0]] > score[indexTeam[1]])
                {
                    label111.Text = label11.Text;
                    label111.Visible = true;
                    //match++;
                    label11.BackColor = Color.LawnGreen;
                }
                else
                {
                    label111.Text = label12.Text;
                    label111.Visible = true;
                    //match++;
                    label12.BackColor = Color.LawnGreen;
                }

                label11.Text = label11.Text + "  " + score[indexTeam[0]].ToString();
                label12.Text = label12.Text + "  " + score[indexTeam[1]].ToString();

            }
        }
        
        
        
        public int Poisson(int rang)
        {
            double S = 0;
            int m = 0;
                while (S >= (-1* rang))
                {

                    alfa = rand.NextDouble();
                    S += Math.Log(alfa);

                    m += 1;
                }
            return m;
        }


    }


    
}
