using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prodesk21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.MaxLength <5)
            {
                


            }
            else
            {
                


            }
        }

        private void Form1_TextChanged(object sender, EventArgs e)

        {
            /*
            if(textBox2.Text.Length <5)
            {
               // MessageBox.Show("Name must conection at last 5 char...!");
               // throw new Exception("Name must conection at last 5 char");

                
            }
            else if(textBox1.Text.Contains("@gmail.com"))
            {
                 

            }
            else if(textBox2.Text == "" && textBox1.Text=="")
            {
                //MessageBox.Show("Enetr data now ...!");
                //throw new Exception("Enetr data now ...!");  
            }
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("@gmail.com"))
            {
                

            }
            else
            {
                //MessageBox.Show("Enetr name + @gmail.com ...!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(textBox2.Text.Length < 5)
            {
                // MessageBox.Show("Name must conection at last 5 char...!");
                throw new Exception("Name must conection at last 5 char...!");

            }
            else if (!textBox1.Text.Contains('@'))
            {
                throw new Exception("enter name + @gmail.com"); 
            }
            else if (textBox2.Text == "" && textBox1.Text == "")
            {
                //MessageBox.Show("Enetr data now ...!");
                throw new Exception("Enetr data now ...!");  
            }
            else
            {
                
                MessageBox.Show("Done ...!");

            }
            
           



        }
    }
}
