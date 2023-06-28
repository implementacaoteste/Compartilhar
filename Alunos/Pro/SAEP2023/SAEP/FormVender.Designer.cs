namespace SAEP
{
    partial class FormVender
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.automoveisDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVender = new System.Windows.Forms.DataGridViewButtonColumn();
            this.automoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.automoveisDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.automoveisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // automoveisDataGridView
            // 
            this.automoveisDataGridView.AllowUserToAddRows = false;
            this.automoveisDataGridView.AllowUserToDeleteRows = false;
            this.automoveisDataGridView.AllowUserToOrderColumns = true;
            this.automoveisDataGridView.AutoGenerateColumns = false;
            this.automoveisDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.automoveisDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.buttonVender});
            this.automoveisDataGridView.DataSource = this.automoveisBindingSource;
            this.automoveisDataGridView.Location = new System.Drawing.Point(12, 76);
            this.automoveisDataGridView.Name = "automoveisDataGridView";
            this.automoveisDataGridView.ReadOnly = true;
            this.automoveisDataGridView.Size = new System.Drawing.Size(494, 286);
            this.automoveisDataGridView.TabIndex = 1;
            this.automoveisDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.automoveisDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Preco";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // buttonVender
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.buttonVender.DefaultCellStyle = dataGridViewCellStyle2;
            this.buttonVender.HeaderText = "";
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.ReadOnly = true;
            this.buttonVender.Text = "Vender";
            this.buttonVender.UseColumnTextForButtonValue = true;
            // 
            // automoveisBindingSource
            // 
            this.automoveisBindingSource.DataSource = typeof(Models.Automoveis);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // FormVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.automoveisDataGridView);
            this.Name = "FormVender";
            this.Text = "FormVender";
            ((System.ComponentModel.ISupportInitialize)(this.automoveisDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.automoveisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource automoveisBindingSource;
        private System.Windows.Forms.DataGridView automoveisDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn buttonVender;
        private System.Windows.Forms.Label label1;
    }
}