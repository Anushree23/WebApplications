using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalAssignClassLib;

namespace CalAssignWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CalAssign obj;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            obj = new CalAssign();
            obj.num1 = Convert.ToInt32(textNum1.Text);
            obj.num2 = Convert.ToInt32(textNum2.Text);
           Sub.Text = obj.Sub().ToString();
         
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            obj = new CalAssign();
            obj.num1 = Convert.ToInt32(textNum1.Text);
            obj.num2 = Convert.ToInt32(textNum2.Text);
            Mul.Text = obj.Mul().ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            obj = new CalAssign();
            obj.num1 = Convert.ToInt32(textNum1.Text);
            obj.num2 = Convert.ToInt32(textNum2.Text);
            Div.Text = obj.Div().ToString();

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            obj = new CalAssign();
            obj.num1 = Convert.ToInt32(textNum1.Text);
            obj.num2 = Convert.ToInt32(textNum2.Text);
            Add.Text = obj.Add().ToString();
        }
    }
}
