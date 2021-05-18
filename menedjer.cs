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
    public partial class managerА : Form
    {
        Model1 db = new Model1();
        public managerА()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void арендаторыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.арендаторыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.egzdemoDataSet);

        }

        private void menedjer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "egzdemoDataSet.Арендаторы". При необходимости она может быть перемещена или удалена.
            this.арендаторыTableAdapter.Fill(this.egzdemoDataSet.Арендаторы);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addForm add = new addForm();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                арендаторыBindingSource.DataSource = db.Арендаторы.ToList();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Арендаторы lich = (Арендаторы)арендаторыBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.ID_арендатора.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Арендаторы.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                арендаторыBindingSource.DataSource = db.Арендаторы.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addForm frm = new addForm();
            Арендаторы add = (Арендаторы)арендаторыBindingSource.Current;

            frm.db = db;
            frm.add = add;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                арендаторыBindingSource.DataSource = null;
                арендаторыBindingSource.DataSource = db.Арендаторы.ToList();
            }
        }
    }
}
