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
    }
}
