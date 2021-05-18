using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addForm : Form
    {
        public Model1 db { get; set; }
        internal Арендаторы add;
        public addForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" )
            {
                MessageBox.Show("Одно из важных полей не заполнено!");
                return;
            }
            Арендаторы lich = new Арендаторы();

            lich.ID_арендатора = Convert.ToInt32(textBox1.Text); ;
            lich.Название = textBox2.Text;
            lich.Номер_телефона = textBox3.Text;
            lich.Адрес = textBox4.Text;
            


            db.Арендаторы.Add(lich);

            db.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }

