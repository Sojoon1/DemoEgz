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
    public partial class Form6 : Form
    {
        public Model1 db { get; set; }
        internal Список_ТЦ add;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Одно из важных полей не заполнено!");
                return;
            }
            Список_ТЦ lich = new Список_ТЦ();

            lich.ID_ТЦ = Convert.ToInt32(textBox1.Text); ;
            lich.название_ТЦ = textBox2.Text;
            lich.статус = textBox3.Text;
            lich.количество_павильонов = Convert.ToInt16(textBox4.Text);
            lich.город = textBox5.Text;
            lich.стоимость_постройки = Convert.ToDecimal(textBox6.Text);
            lich.этажность = Convert.ToInt16(textBox7.Text);
            lich.коэффицент_добавчной_стоимости = Convert.ToDouble(textBox8.Text);



            db.Список_ТЦ.Add(lich);

            db.SaveChanges();

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
