
namespace CST2
{
    partial class ReceptUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxRecept = new System.Windows.Forms.ListBox();
            this.fogasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxNyersanyag = new System.Windows.Forms.ListBox();
            this.nyersanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyiseg4foDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.árDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hozzávalóBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReceptKeresés = new System.Windows.Forms.TextBox();
            this.textBoxNyersanyagKeresés = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalóBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxRecept
            // 
            this.listBoxRecept.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxRecept.DataSource = this.fogasokBindingSource;
            this.listBoxRecept.DisplayMember = "FogasNev";
            this.listBoxRecept.FormattingEnabled = true;
            this.listBoxRecept.ItemHeight = 20;
            this.listBoxRecept.Location = new System.Drawing.Point(14, 76);
            this.listBoxRecept.Name = "listBoxRecept";
            this.listBoxRecept.Size = new System.Drawing.Size(261, 504);
            this.listBoxRecept.TabIndex = 0;
            this.listBoxRecept.SelectedIndexChanged += new System.EventHandler(this.listBoxRecept_SelectedIndexChanged);
            // 
            // fogasokBindingSource
            // 
            this.fogasokBindingSource.DataSource = typeof(CST2.Fogasok);
            // 
            // listBoxNyersanyag
            // 
            this.listBoxNyersanyag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNyersanyag.DataSource = this.nyersanyagokBindingSource;
            this.listBoxNyersanyag.DisplayMember = "NyersanyagNev";
            this.listBoxNyersanyag.FormattingEnabled = true;
            this.listBoxNyersanyag.ItemHeight = 20;
            this.listBoxNyersanyag.Location = new System.Drawing.Point(878, 76);
            this.listBoxNyersanyag.Name = "listBoxNyersanyag";
            this.listBoxNyersanyag.Size = new System.Drawing.Size(254, 504);
            this.listBoxNyersanyag.TabIndex = 1;
            this.listBoxNyersanyag.SelectedIndexChanged += new System.EventHandler(this.listBoxNyersanyag_SelectedIndexChanged);
            // 
            // nyersanyagokBindingSource
            // 
            this.nyersanyagokBindingSource.DataSource = typeof(CST2.Nyersanyagok);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receptIDDataGridViewTextBoxColumn,
            this.fogasIDDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyiseg4foDataGridViewTextBoxColumn,
            this.egysegNevDataGridViewTextBoxColumn,
            this.árDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hozzávalóBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(281, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(481, 503);
            this.dataGridView1.TabIndex = 2;
            // 
            // receptIDDataGridViewTextBoxColumn
            // 
            this.receptIDDataGridViewTextBoxColumn.DataPropertyName = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.HeaderText = "ReceptID";
            this.receptIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.receptIDDataGridViewTextBoxColumn.Name = "receptIDDataGridViewTextBoxColumn";
            this.receptIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptIDDataGridViewTextBoxColumn.Visible = false;
            this.receptIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fogasIDDataGridViewTextBoxColumn
            // 
            this.fogasIDDataGridViewTextBoxColumn.DataPropertyName = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.HeaderText = "FogasID";
            this.fogasIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fogasIDDataGridViewTextBoxColumn.Name = "fogasIDDataGridViewTextBoxColumn";
            this.fogasIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.fogasIDDataGridViewTextBoxColumn.Visible = false;
            this.fogasIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            this.nyersanyagNevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mennyiseg4foDataGridViewTextBoxColumn
            // 
            this.mennyiseg4foDataGridViewTextBoxColumn.DataPropertyName = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.HeaderText = "Mennyiseg_4fo";
            this.mennyiseg4foDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mennyiseg4foDataGridViewTextBoxColumn.Name = "mennyiseg4foDataGridViewTextBoxColumn";
            this.mennyiseg4foDataGridViewTextBoxColumn.ReadOnly = true;
            this.mennyiseg4foDataGridViewTextBoxColumn.Width = 150;
            // 
            // egysegNevDataGridViewTextBoxColumn
            // 
            this.egysegNevDataGridViewTextBoxColumn.DataPropertyName = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.HeaderText = "EgysegNev";
            this.egysegNevDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.egysegNevDataGridViewTextBoxColumn.Name = "egysegNevDataGridViewTextBoxColumn";
            this.egysegNevDataGridViewTextBoxColumn.ReadOnly = true;
            this.egysegNevDataGridViewTextBoxColumn.Width = 150;
            // 
            // árDataGridViewTextBoxColumn
            // 
            this.árDataGridViewTextBoxColumn.DataPropertyName = "Ár";
            this.árDataGridViewTextBoxColumn.HeaderText = "Ár";
            this.árDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.árDataGridViewTextBoxColumn.Name = "árDataGridViewTextBoxColumn";
            this.árDataGridViewTextBoxColumn.ReadOnly = true;
            this.árDataGridViewTextBoxColumn.Width = 150;
            // 
            // hozzávalóBindingSource
            // 
            this.hozzávalóBindingSource.DataSource = typeof(CST2.Hozzávaló);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(788, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(788, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(768, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(768, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            // 
            // textBoxReceptKeresés
            // 
            this.textBoxReceptKeresés.Location = new System.Drawing.Point(14, 44);
            this.textBoxReceptKeresés.Name = "textBoxReceptKeresés";
            this.textBoxReceptKeresés.Size = new System.Drawing.Size(261, 26);
            this.textBoxReceptKeresés.TabIndex = 7;
            this.textBoxReceptKeresés.TextChanged += new System.EventHandler(this.textBoxReceptKeresés_TextChanged);
            // 
            // textBoxNyersanyagKeresés
            // 
            this.textBoxNyersanyagKeresés.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNyersanyagKeresés.Location = new System.Drawing.Point(878, 44);
            this.textBoxNyersanyagKeresés.Name = "textBoxNyersanyagKeresés";
            this.textBoxNyersanyagKeresés.Size = new System.Drawing.Size(254, 26);
            this.textBoxNyersanyagKeresés.TabIndex = 8;
            this.textBoxNyersanyagKeresés.TextChanged += new System.EventHandler(this.textBoxNyersanyagKeresés_TextChanged);
            // 
            // ReceptUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.textBoxNyersanyagKeresés);
            this.Controls.Add(this.textBoxReceptKeresés);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBoxNyersanyag);
            this.Controls.Add(this.listBoxRecept);
            this.Name = "ReceptUC";
            this.Size = new System.Drawing.Size(1137, 653);
            this.Load += new System.EventHandler(this.ReceptUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hozzávalóBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRecept;
        private System.Windows.Forms.ListBox listBoxNyersanyag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReceptKeresés;
        private System.Windows.Forms.TextBox textBoxNyersanyagKeresés;
        private System.Windows.Forms.BindingSource fogasokBindingSource;
        private System.Windows.Forms.BindingSource nyersanyagokBindingSource;
        private System.Windows.Forms.BindingSource hozzávalóBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fogasIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mennyiseg4foDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn egysegNevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn árDataGridViewTextBoxColumn;
    }
}
