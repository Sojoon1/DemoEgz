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
    public partial class adminAdd : Form
    {
        public Model1 db { get; set; }
        internal Арендаторы addd;
        public adminAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Одно из важных полей не заполнено!");
                return;
            }
            Сотрудники lich = new Сотрудники();

            lich.ID_сотрудника = Convert.ToInt32(textBox1.Text); ;
            lich.ФИО = textBox2.Text;
            lich.Логин = textBox3.Text;
            lich.Пароль = textBox4.Text;
            lich.Роль = textBox5.Text;
            lich.Номер_телефона = textBox6.Text;
            lich.Пол = textBox7.Text;



            db.Сотрудники.Add(lich);

            db.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
