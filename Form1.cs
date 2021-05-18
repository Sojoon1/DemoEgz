using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1();

        
        public Form1()
        {
            InitializeComponent();
            

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            // проверяем, что в текстовые поля введены данные
            if (loginField.Text == " " || passField.Text == " ")
            {
                MessageBox.Show(" Нужно задать логин и пароль!");
                return;
            }
            if (loginField.Text == "1" && passField.Text == "1")
            {
               adminForm frm = new adminForm();

                frm.Show();
                return;
            }

            foreach (Сотрудники users in db.Сотрудники)

                if (users != null && users.Пароль == passField.Text)
                {
                    if (users.Роль == "Администратор")
                    {
                        adminForm frm = new adminForm();
                        frm.Show();
                        this.Hide();
                    }
                    else if (users.Роль == "Менеджер А")
                    {
                        managerА form = new managerА();
                        form.Show();
                        this.Hide();
                    }
                    else if (users.Роль == "Менеджер C")
                    {
                        menagerC form = new menagerC();
                        form.Show();
                        this.Hide();
                    }
                    return;
                }


        }
    }
}
