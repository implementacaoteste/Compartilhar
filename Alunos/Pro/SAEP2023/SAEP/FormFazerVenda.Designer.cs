namespace SAEP
{
    partial class FormFazerVenda
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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label concessionariaLabel;
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeComboBox = new System.Windows.Forms.ComboBox();
            this.concessionariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.concessionariaComboBox = new System.Windows.Forms.ComboBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            concessionariaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionariasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 102);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(42, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Cliente:";
            // 
            // concessionariaLabel
            // 
            concessionariaLabel.AutoSize = true;
            concessionariaLabel.Location = new System.Drawing.Point(12, 149);
            concessionariaLabel.Name = "concessionariaLabel";
            concessionariaLabel.Size = new System.Drawing.Size(82, 13);
            concessionariaLabel.TabIndex = 2;
            concessionariaLabel.Text = "Concessionaria:";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(Models.Clientes);
            // 
            // nomeComboBox
            // 
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientesBindingSource, "Id", true));
            this.nomeComboBox.DataSource = this.clientesBindingSource;
            this.nomeComboBox.DisplayMember = "Nome";
            this.nomeComboBox.FormattingEnabled = true;
            this.nomeComboBox.Location = new System.Drawing.Point(100, 99);
            this.nomeComboBox.Name = "nomeComboBox";
            this.nomeComboBox.Size = new System.Drawing.Size(392, 21);
            this.nomeComboBox.TabIndex = 2;
            this.nomeComboBox.ValueMember = "Id";
            // 
            // concessionariasBindingSource
            // 
            this.concessionariasBindingSource.DataSource = typeof(Models.Concessionarias);
            // 
            // concessionariaComboBox
            // 
            this.concessionariaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.concessionariasBindingSource, "Concessionaria", true));
            this.concessionariaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.concessionariasBindingSource, "Id", true));
            this.concessionariaComboBox.DataSource = this.concessionariasBindingSource;
            this.concessionariaComboBox.DisplayMember = "Concessionaria";
            this.concessionariaComboBox.FormattingEnabled = true;
            this.concessionariaComboBox.Location = new System.Drawing.Point(100, 146);
            this.concessionariaComboBox.Name = "concessionariaComboBox";
            this.concessionariaComboBox.Size = new System.Drawing.Size(392, 21);
            this.concessionariaComboBox.TabIndex = 3;
            this.concessionariaComboBox.ValueMember = "Id";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Location = new System.Drawing.Point(229, 207);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 4;
            this.buttonConfirmar.Text = "Confirmar";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // FormFazerVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(concessionariaLabel);
            this.Controls.Add(this.concessionariaComboBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeComboBox);
            this.Name = "FormFazerVenda";
            this.Text = "FormFazerVenda";
            this.Load += new System.EventHandler(this.FormFazerVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.concessionariasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.ComboBox nomeComboBox;
        private System.Windows.Forms.BindingSource concessionariasBindingSource;
        private System.Windows.Forms.ComboBox concessionariaComboBox;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label1;
    }
}