using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox2.Visible = false;
        }

        // task 1
        private void button1_Click(object sender, EventArgs e)
        {
            // clearing listbox'
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Visible = true;

            // array
            int[] test = { 2, 2, 5, 4, 3 };

            label1.Text = "Each item in array";
            label2.Text = "Each item in array multiplied by 2";

            // running through array
            for (int i = 0; i < test.Length; i++)
            {
                listBox1.Items.Add(test[i]); // adds each item in array to listbox
                listBox2.Items.Add(test[i] * 2); // adds each item in array to lixtbox AFTER multiplying by 2
            }
        }

        // task 2
        private void button2_Click(object sender, EventArgs e)
        {
            // clearing
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label1.Text = "";
            label2.Text = "";

            // variables
            int[] test = new int[10]; // initialize array
            int m = 0;

            // fills and prints array
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = m;
                m += 2;
            }
            for (int i = 0; i < test.Length; i++)
            {
                listBox1.Items.Add(test[i]);
            }
        }

        // task 3
        private void button3_Click(object sender, EventArgs e)
        {
            // clearing'
            //listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label1.Text = "";
            label2.Text = "";

            // variables
            int[] numbers = { 6, 7, 5, 4, 3 }; // array
            int input = 0;
            bool check = true;

            try
            {
                input = Convert.ToInt32(textBoxTask3.Text); // converts text to int
            }
            catch
            {
                labelInfoTask3.Text = "Only numbers!"; // obsolete
            }

            for (int i = 0; i < numbers.Length; i++) // going for the array
            {
                if (input == numbers[i]) // if the input is in the array - set bool to true and break the loop
                {
                    check = true;
                    break;
                }
                else if (!(input == numbers[i])) // otherwise we keep bool false
                {
                    check = false;
                }
            }
            if (check) // if check is true
                listBox1.Items.Add($"{input}  is in the array."); // adding the true input to list - positive
            else
                listBox1.Items.Add($"{input}  is not in the array."); // adding the non true input to list - negative
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // clearing
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox2.Visible = false;
            label1.Text = "";
            label2.Text = "";
            textBoxTask3.Text = "";
        }
    }
}
