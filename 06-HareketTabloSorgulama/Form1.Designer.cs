namespace _06_HareketTabloSorgulama
{
    partial class Form1
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
            this.hareketTabloSorgulamaDataSet = new _06_HareketTabloSorgulama.HareketTabloSorgulamaDataSet();
            this.proje6BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proje6TableAdapter = new _06_HareketTabloSorgulama.HareketTabloSorgulamaDataSetTableAdapters.Proje6TableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hareketTabloSorgulamaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hareketTabloSorgulamaDataSet
            // 
            this.hareketTabloSorgulamaDataSet.DataSetName = "HareketTabloSorgulamaDataSet";
            this.hareketTabloSorgulamaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proje6BindingSource
            // 
            this.proje6BindingSource.DataMember = "Proje6";
            this.proje6BindingSource.DataSource = this.hareketTabloSorgulamaDataSet;
            // 
            // proje6TableAdapter
            // 
            this.proje6TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 756);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 756);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hareketTabloSorgulamaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje6BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HareketTabloSorgulamaDataSet hareketTabloSorgulamaDataSet;
        private System.Windows.Forms.BindingSource proje6BindingSource;
        private HareketTabloSorgulamaDataSetTableAdapters.Proje6TableAdapter proje6TableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

