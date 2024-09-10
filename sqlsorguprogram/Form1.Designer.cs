namespace sqlsorguprogram
{
    partial class sorgu
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
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.sorguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlsorguDataSet = new sqlsorguprogram.sqlsorguDataSet();
            this.btncalis = new System.Windows.Forms.Button();
            this.btnguncel = new System.Windows.Forms.Button();
            this.sorguTableAdapter = new sqlsorguprogram.sqlsorguDataSetTableAdapters.sorguTableAdapter();
            this.sqlsorguDataSet1 = new sqlsorguprogram.sqlsorguDataSet1();
            this.sorguBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sorguTableAdapter1 = new sqlsorguprogram.sqlsorguDataSet1TableAdapters.sorguTableAdapter();
            this.sqlsorguDataSet2 = new sqlsorguprogram.sqlsorguDataSet2();
            this.sorguBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sorguTableAdapter2 = new sqlsorguprogram.sqlsorguDataSet2TableAdapters.sorguTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.sorguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlsorguDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlsorguDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlsorguDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richBox
            // 
            this.richBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richBox.Location = new System.Drawing.Point(13, 19);
            this.richBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richBox.Name = "richBox";
            this.richBox.Size = new System.Drawing.Size(751, 207);
            this.richBox.TabIndex = 0;
            this.richBox.Text = "";
            // 
            // sorguBindingSource
            // 
            this.sorguBindingSource.DataMember = "sorgu";
            this.sorguBindingSource.DataSource = this.sqlsorguDataSet;
            // 
            // sqlsorguDataSet
            // 
            this.sqlsorguDataSet.DataSetName = "sqlsorguDataSet";
            this.sqlsorguDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btncalis
            // 
            this.btncalis.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncalis.Location = new System.Drawing.Point(781, 54);
            this.btncalis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncalis.Name = "btncalis";
            this.btncalis.Size = new System.Drawing.Size(232, 59);
            this.btncalis.TabIndex = 2;
            this.btncalis.Text = "Çalıştır";
            this.btncalis.UseVisualStyleBackColor = true;
            this.btncalis.Click += new System.EventHandler(this.btncalis_Click);
            // 
            // btnguncel
            // 
            this.btnguncel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnguncel.Location = new System.Drawing.Point(781, 143);
            this.btnguncel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnguncel.Name = "btnguncel";
            this.btnguncel.Size = new System.Drawing.Size(232, 59);
            this.btnguncel.TabIndex = 3;
            this.btnguncel.Text = "Ekle - Sil - Güncelle";
            this.btnguncel.UseVisualStyleBackColor = true;
            this.btnguncel.Click += new System.EventHandler(this.btngüncel_Click);
            // 
            // sorguTableAdapter
            // 
            this.sorguTableAdapter.ClearBeforeFill = true;
            // 
            // sqlsorguDataSet1
            // 
            this.sqlsorguDataSet1.DataSetName = "sqlsorguDataSet1";
            this.sqlsorguDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorguBindingSource1
            // 
            this.sorguBindingSource1.DataMember = "sorgu";
            this.sorguBindingSource1.DataSource = this.sqlsorguDataSet1;
            // 
            // sorguTableAdapter1
            // 
            this.sorguTableAdapter1.ClearBeforeFill = true;
            // 
            // sqlsorguDataSet2
            // 
            this.sqlsorguDataSet2.DataSetName = "sqlsorguDataSet2";
            this.sqlsorguDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorguBindingSource2
            // 
            this.sorguBindingSource2.DataMember = "sorgu";
            this.sorguBindingSource2.DataSource = this.sqlsorguDataSet2;
            // 
            // sorguTableAdapter2
            // 
            this.sorguTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 326);
            this.dataGridView1.TabIndex = 4;
            // 
            // sorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1056, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnguncel);
            this.Controls.Add(this.btncalis);
            this.Controls.Add(this.richBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sorgu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sorguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlsorguDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlsorguDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlsorguDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.Button btncalis;
        private System.Windows.Forms.Button btnguncel;
        private sqlsorguDataSet sqlsorguDataSet;
        private System.Windows.Forms.BindingSource sorguBindingSource;
        private sqlsorguDataSetTableAdapters.sorguTableAdapter sorguTableAdapter;
        private sqlsorguDataSet1 sqlsorguDataSet1;
        private System.Windows.Forms.BindingSource sorguBindingSource1;
        private sqlsorguDataSet1TableAdapters.sorguTableAdapter sorguTableAdapter1;
        private sqlsorguDataSet2 sqlsorguDataSet2;
        private System.Windows.Forms.BindingSource sorguBindingSource2;
        private sqlsorguDataSet2TableAdapters.sorguTableAdapter sorguTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

