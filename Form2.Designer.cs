
namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.egzdemoDataSet = new WindowsFormsApp1.EgzdemoDataSet();
            this.список_павильоновBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.список_павильоновTableAdapter = new WindowsFormsApp1.EgzdemoDataSetTableAdapters.Список_павильоновTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.EgzdemoDataSetTableAdapters.TableAdapterManager();
            this.iDПавильонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тЦDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.павильонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьЗаКвмDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.коофДобавчнойСтоимостиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzdemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_павильоновBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПавильонаDataGridViewTextBoxColumn,
            this.тЦDataGridViewTextBoxColumn,
            this.павильонаDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.стоимостьЗаКвмDataGridViewTextBoxColumn,
            this.коофДобавчнойСтоимостиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.список_павильоновBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(138, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // egzdemoDataSet
            // 
            this.egzdemoDataSet.DataSetName = "EgzdemoDataSet";
            this.egzdemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_павильоновBindingSource
            // 
            this.список_павильоновBindingSource.DataMember = "Список павильонов";
            this.список_павильоновBindingSource.DataSource = this.egzdemoDataSet;
            // 
            // список_павильоновTableAdapter
            // 
            this.список_павильоновTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.EgzdemoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АрендаTableAdapter = null;
            this.tableAdapterManager.АрендаторыTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Список_павильоновTableAdapter = this.список_павильоновTableAdapter;
            this.tableAdapterManager.Список_ТЦTableAdapter = null;
            // 
            // iDПавильонаDataGridViewTextBoxColumn
            // 
            this.iDПавильонаDataGridViewTextBoxColumn.DataPropertyName = "ID павильона";
            this.iDПавильонаDataGridViewTextBoxColumn.HeaderText = "ID павильона";
            this.iDПавильонаDataGridViewTextBoxColumn.Name = "iDПавильонаDataGridViewTextBoxColumn";
            this.iDПавильонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // тЦDataGridViewTextBoxColumn
            // 
            this.тЦDataGridViewTextBoxColumn.DataPropertyName = "ТЦ";
            this.тЦDataGridViewTextBoxColumn.HeaderText = "ТЦ";
            this.тЦDataGridViewTextBoxColumn.Name = "тЦDataGridViewTextBoxColumn";
            // 
            // павильонаDataGridViewTextBoxColumn
            // 
            this.павильонаDataGridViewTextBoxColumn.DataPropertyName = "№ павильона";
            this.павильонаDataGridViewTextBoxColumn.HeaderText = "№ павильона";
            this.павильонаDataGridViewTextBoxColumn.Name = "павильонаDataGridViewTextBoxColumn";
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "этаж";
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            // 
            // стоимостьЗаКвмDataGridViewTextBoxColumn
            // 
            this.стоимостьЗаКвмDataGridViewTextBoxColumn.DataPropertyName = "стоимость за кв_м";
            this.стоимостьЗаКвмDataGridViewTextBoxColumn.HeaderText = "стоимость за кв_м";
            this.стоимостьЗаКвмDataGridViewTextBoxColumn.Name = "стоимостьЗаКвмDataGridViewTextBoxColumn";
            // 
            // коофДобавчнойСтоимостиDataGridViewTextBoxColumn
            // 
            this.коофДобавчнойСтоимостиDataGridViewTextBoxColumn.DataPropertyName = "кооф_ добавчной стоимости";
            this.коофДобавчнойСтоимостиDataGridViewTextBoxColumn.HeaderText = "кооф_ добавчной стоимости";
            this.коофДобавчнойСтоимостиDataGridViewTextBoxColumn.Name = "коофДобавчнойСтоимостиDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egzdemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.список_павильоновBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private EgzdemoDataSet egzdemoDataSet;
        private System.Windows.Forms.BindingSource список_павильоновBindingSource;
        private EgzdemoDataSetTableAdapters.Список_павильоновTableAdapter список_павильоновTableAdapter;
        private EgzdemoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПавильонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тЦDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn павильонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьЗаКвмDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn коофДобавчнойСтоимостиDataGridViewTextBoxColumn;
    }
}