﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "egzdemoDataSet.Список_павильонов". При необходимости она может быть перемещена или удалена.
            this.список_павильоновTableAdapter.Fill(this.egzdemoDataSet.Список_павильонов);

        }
    }
}
