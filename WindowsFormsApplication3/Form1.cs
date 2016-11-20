using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        byte summary = 0;
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[256];
        int[] array2 = new int[256];

        private void button1_Click(object sender, EventArgs e)
        {
            summary = 0;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            int[] arr = new int[10];
            int i;
            for (i = 0; i <= 9; i++)
            {
                Random r = new Random(Guid.NewGuid().ToByteArray().Max());
                int a = r.Next(10, 99);
                listBox1.Items.Add(a);
                array[i] = a;
                this.summary++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            int i;
            for (i = 0; i <= 9; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            array[this.summary] = Convert.ToInt32(textBox1.Text);
            listBox2.Items.Add(array[this.summary]);
            summary++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            array2 = (int[])array.Clone();
            int i, j, p, t;

            for (i = 0; i < summary -1; i++)
            {
                p = i;
                for (j = i + 1; j < summary - 0; j++)
                {
                    if (array2[j] < array2[p])
                    {
                        p = j;
                    }
                }
                t = array2[i]; array2[i] = array2[p]; array2[p] = t;
            }
            
            for (i = 0; i <= summary - 1; i++)
                listBox3.Items.Add(array2[i]);
        }

    }
}
