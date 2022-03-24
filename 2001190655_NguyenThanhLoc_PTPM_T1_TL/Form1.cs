using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001190655_NguyenThanhLoc_PTPM_T1_TL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //test();
            //textbox();
            caro();
        }

        public void test()
        {
            string[] foods = { "Grain", "Bread", "Beans", "Eggs", "Chicken", "Milk", "Fruit", "Vegetables", "Pasta", "Rice", "Fish", "Beef" };
            int topPosition = 10;
            foreach (string food in foods)
            {
                CheckBox checkbox = new CheckBox();
                checkbox.Left = 10;
                checkbox.Top = topPosition;
                topPosition += 30;
                checkbox.Text = food;
                pnlCheckBoxList.Controls.Add(checkbox);
            }
        }
        public void textbox()
        {
            string[] texts = { "textBox1", "textBox2", "textBox3", "textBox4" };
            int topPosition = 10;
            foreach (string text in texts)
            {
                TextBox textBox = new TextBox();
                textBox.Size = new Size(300, 20);
                textBox.Left = 10;
                textBox.Top = topPosition;
                topPosition += 30;
                textBox.Text = text;
                pnlCheckBoxList.Controls.Add(textBox);
            }
        }

        public void caro()
        {

           
            int topPosition = 20;
            int leftPosition = 20;
            progressBar1.Maximum = 10;
            for (int i = 0; i <= 10; i++)
            {
                Thread.Sleep(500);
                progressBar1.Value = i;
              
                for (int j = 0; j <= 10; j++)
                {
                    Button nut = new Button();
                    nut.BackColor = Color.LightGray;
                    nut.Size = new Size(30, 30);
                    nut.Top = topPosition;
                    nut.Left = leftPosition;

                    leftPosition += 30;

                    pnlCheckBoxList.Controls.Add(nut);
                    
                }

                topPosition += 30;
                leftPosition = 20;
            }

           

        }

    }
}
