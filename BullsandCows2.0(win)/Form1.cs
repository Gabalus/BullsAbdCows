using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication3;

namespace BullsandCows2._0_win_
{
    public partial class Form1 : Form
    {
        Playgame playgame;
        bool flag = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            if (flag)
            {
                string answer = textBox1.Text;
                label1.Text = playgame.nextStep(answer);
            }
           else
            {
                string answer = textBox1.Text;
            }



        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            while (true)
            {



                Random rand = new Random();

                int r = rand.Next(100);
                string number = r.ToString();
                this.Text = number;

                playgame = new Playgame(new Game(number));

                int lenghtnumber = number.Length;
                if (playgame != null)
                {
                    label1.Text = $"Введите ответ длинной-{lenghtnumber}";
                    break;
                }






            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            flag = false;
            while (playgame == null)
            {
                label1.Text = "Загадайте число";


                string number = textBox1.Text;
                this.Text = number;
                playgame = new Playgame(new Game(number));
            }
            label1.Text = "Число загадано, Введите ответ";



            
            
            
           
                
                
            

        }

       
    }
}
