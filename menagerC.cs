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
    public partial class menagerC : Form
    {
        Model1 db = new Model1();
        
        public menagerC()
        {
            InitializeComponent();
        }

        private void список_ТЦBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.список_ТЦBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.egzdemoDataSet);

        }

        private void menagerC_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "egzdemoDataSet.Список_ТЦ". При необходимости она может быть перемещена или удалена.
            this.список_ТЦTableAdapter.Fill(this.egzdemoDataSet.Список_ТЦ);

        }

        private void список_ТЦDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 add = new Form6();
            add.db = db;
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                список_ТЦBindingSource.DataSource = db.Список_ТЦ.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form6 frm = new Form6();
            Список_ТЦ add = (Список_ТЦ)список_ТЦBindingSource.Current;

            frm.db = db;
            frm.add = add;
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                список_ТЦBindingSource.DataSource = null;
                список_ТЦBindingSource.DataSource = db.Список_ТЦ.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Список_ТЦ lich = (Список_ТЦ)список_ТЦBindingSource.Current;
            DialogResult dr = MessageBox.Show(
                "Вы действительно хотите удалить данные? " + lich.ID_ТЦ.ToString(),
                "Удаление данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                db.Список_ТЦ.Remove(lich);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                список_ТЦBindingSource.DataSource = db.Список_ТЦ.ToList();
            }
        }
    }
}
