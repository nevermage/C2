using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2lab_C_sharp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void addFactoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Text = "Кількість відділів: " + zavod.zavodi[comboBox1.SelectedIndex].numOfWorkshops;
            label3.Text = "Кількість робітників: " + zavod.zavodi[comboBox1.SelectedIndex].numOfemployees;
            label4.Text = "Кількість майстрів: " + zavod.zavodi[comboBox1.SelectedIndex].numOfMasters;
            label5.Text = "Заробітна плата робітника: " + zavod.zavodi[comboBox1.SelectedIndex].salaryEmpl;
            label6.Text = "Заробітна плата майстра: " + zavod.zavodi[comboBox1.SelectedIndex].salaryMaster;
            label7.Text = "Прибуток за місяць з робітника: " + zavod.zavodi[comboBox1.SelectedIndex].incomeEmpl;
            label8.Text = "Прибуток за місяць з майстра: " + zavod.zavodi[comboBox1.SelectedIndex].incomeMaster;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>-1)
            {
                zavod.zavodi[comboBox1.SelectedIndex].HireEmpl();
                label3.Text = "Кількість робітників: " + zavod.zavodi[comboBox1.SelectedIndex].numOfemployees;
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                zavod.zavodi[comboBox1.SelectedIndex].FireEmpl();
                label3.Text = "Кількість робітників: " + zavod.zavodi[comboBox1.SelectedIndex].numOfemployees;
            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                zavod.zavodi[comboBox1.SelectedIndex].HireMaster();
                label4.Text = "Кількість майстрів: " + zavod.zavodi[comboBox1.SelectedIndex].numOfMasters;
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                zavod.zavodi[comboBox1.SelectedIndex].FireMaster();
                label4.Text = "Кількість майстрів: " + zavod.zavodi[comboBox1.SelectedIndex].numOfMasters;
            }
                
        }

        private void обToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void порівнятиЗаводиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            zavod.zavodi.Sort();
            form4.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>-1)
            {
                double a = double.Parse(textBox1.Text);
                label2.Text = "Дохiд: " + a.Money(zavod.zavodi[comboBox1.SelectedIndex].incomeEmpl, zavod.zavodi[comboBox1.SelectedIndex].numOfemployees).ToString();
            }    
            
        }
    }
}
