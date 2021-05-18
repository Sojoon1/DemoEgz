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
    public partial class adminForm : Form
    {
        Model1 db = new Model1();
        public adminForm()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.egzdemoDataSet);

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "egzdemoDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.egzdemoDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminAdd add = new adminAdd();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminAdd frm = new adminAdd();
            Сотрудники add = (Сотрудники)сотрудникиBindingSource.Current;

            frm.db = db;
            frm.addd = add;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                сотрудникиBindingSource.DataSource = null;
                сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Сотрудники lich = (Сотрудники)сотрудникиBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.ID_сотрудника.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Сотрудники.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
            }
        }
    }
}
