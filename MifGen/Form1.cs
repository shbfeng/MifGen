using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MifGen
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

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           SinWave usinwave = null;
            if (radio_button_sin.Enabled == true)
            usinwave.Sin_gen();
           else if(radio_button_tri.Enabled == true)
                usinwave.Sin_gen();
            else if (radio_button_square.Enabled == true)
                usinwave.Sin_gen();


        }
    }
            }

        
    

