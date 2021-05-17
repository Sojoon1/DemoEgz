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
    public partial class menedjer : Form
    {
        public menedjer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
