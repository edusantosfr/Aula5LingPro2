using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace aula5at2
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int i, j, temp;
        int [] value = new int[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0;  i < 8; i++)
                {
                    value[i] = randNum.Next(0,10);
                    listBox1.Items.Add(value[i]);
                }

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (value[i] < value[j])
                        {
                            temp = value[i];
                            value[i] = value[j];
                            value[j] = temp;
                        }
                    }
                }

                for (int i = 0; i < 8; i++)
                {
                    listBox2.Items.Add(value[i]);
                }
            }
            catch (Exception erro)
            {
                erro.Message.ToString();
            }            
        }
    }
}
