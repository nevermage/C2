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
    public partial class Form3 : Form
    {
        Form1 form;
        public Form3(Form1 f)
        {
            InitializeComponent();
            form = f;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < form.comboBox1.Items.Count; i++)
                comboBox1.Items.Add(form.comboBox1.Items[i]);
            for (int i = 0; i < form.comboBox1.Items.Count; i++)
                comboBox2.Items.Add(form.comboBox1.Items[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                if (comboBox1.SelectedItem != comboBox2.SelectedItem)
                {
                    zavod.zavodi.Add(zavod.zavodi[comboBox1.SelectedIndex] + zavod.zavodi[comboBox2.SelectedIndex]);
                    form.comboBox1.Items.Add(zavod.zavodi[zavod.zavodi.Count - 1].nameZavod);
                    /*form.comboBox1.Items.Remove(comboBox1.SelectedItem);
                    form.comboBox1.Items.Remove(comboBox2.SelectedItem);
                    zavod.zavodi.Remove(zavod.zavodi[comboBox1.SelectedIndex]);
                    zavod.zavodi.Remove(zavod.zavodi[comboBox2.SelectedIndex]);*/


                    this.Close();
                }
                else
                    MessageBox.Show("Оберіть два різних заводи");
                
            }    
            
        }
    }
}
