namespace eAgenda.Social.UserControls.ContactControls
{
    partial class EditContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditContactForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.TxbEmail = new System.Windows.Forms.TextBox();
            this.TxbCompany = new System.Windows.Forms.TextBox();
            this.TxbJobPosition = new System.Windows.Forms.TextBox();
            this.MTxbPhone = new System.Windows.Forms.MaskedTextBox();
            this.BtnConclude = new eAgenda.Componentes.CustomButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ChbYes = new System.Windows.Forms.CheckBox();
            this.ChbNo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editando Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(272, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(32, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(32, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Empresa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(272, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Cargo";
            // 
            // TxbName
            // 
            this.TxbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbName.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbName.Location = new System.Drawing.Point(32, 136);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(188, 31);
            this.TxbName.TabIndex = 7;
            // 
            // TxbEmail
            // 
            this.TxbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbEmail.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbEmail.Location = new System.Drawing.Point(32, 229);
            this.TxbEmail.Name = "TxbEmail";
            this.TxbEmail.Size = new System.Drawing.Size(433, 31);
            this.TxbEmail.TabIndex = 8;
            // 
            // TxbCompany
            // 
            this.TxbCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbCompany.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbCompany.Location = new System.Drawing.Point(32, 420);
            this.TxbCompany.Name = "TxbCompany";
            this.TxbCompany.Size = new System.Drawing.Size(188, 31);
            this.TxbCompany.TabIndex = 9;
            // 
            // TxbJobPosition
            // 
            this.TxbJobPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbJobPosition.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbJobPosition.Location = new System.Drawing.Point(272, 420);
            this.TxbJobPosition.Name = "TxbJobPosition";
            this.TxbJobPosition.Size = new System.Drawing.Size(193, 31);
            this.TxbJobPosition.TabIndex = 10;
            // 
            // MTxbPhone
            // 
            this.MTxbPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.MTxbPhone.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MTxbPhone.Location = new System.Drawing.Point(272, 136);
            this.MTxbPhone.Mask = "(99) 00000-0000";
            this.MTxbPhone.Name = "MTxbPhone";
            this.MTxbPhone.Size = new System.Drawing.Size(193, 31);
            this.MTxbPhone.TabIndex = 11;
            // 
            // BtnConclude
            // 
            this.BtnConclude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnConclude.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnConclude.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConclude.BorderRadius = 5;
            this.BtnConclude.BorderSize = 0;
            this.BtnConclude.FlatAppearance.BorderSize = 0;
            this.BtnConclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConclude.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConclude.ForeColor = System.Drawing.Color.White;
            this.BtnConclude.Location = new System.Drawing.Point(32, 489);
            this.BtnConclude.Name = "BtnConclude";
            this.BtnConclude.Size = new System.Drawing.Size(433, 40);
            this.BtnConclude.TabIndex = 12;
            this.BtnConclude.Text = "Concluir";
            this.BtnConclude.TextColor = System.Drawing.Color.White;
            this.BtnConclude.UseVisualStyleBackColor = false;
            this.BtnConclude.Click += new System.EventHandler(this.BtnConclude_Click);
            this.BtnConclude.MouseLeave += new System.EventHandler(this.BtnConclude_MouseLeave);
            this.BtnConclude.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnConclude_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(32, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Possui relação com alguma empresa? *";
            // 
            // ChbYes
            // 
            this.ChbYes.AutoSize = true;
            this.ChbYes.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChbYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ChbYes.Location = new System.Drawing.Point(37, 322);
            this.ChbYes.Name = "ChbYes";
            this.ChbYes.Size = new System.Drawing.Size(51, 26);
            this.ChbYes.TabIndex = 14;
            this.ChbYes.Text = "Sim";
            this.ChbYes.UseVisualStyleBackColor = true;
            this.ChbYes.CheckedChanged += new System.EventHandler(this.ChbYes_CheckedChanged);
            // 
            // ChbNo
            // 
            this.ChbNo.AutoSize = true;
            this.ChbNo.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChbNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ChbNo.Location = new System.Drawing.Point(37, 347);
            this.ChbNo.Name = "ChbNo";
            this.ChbNo.Size = new System.Drawing.Size(54, 26);
            this.ChbNo.TabIndex = 15;
            this.ChbNo.Text = "Não";
            this.ChbNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChbNo.UseVisualStyleBackColor = true;
            this.ChbNo.CheckedChanged += new System.EventHandler(this.ChbNo_CheckedChanged);
            // 
            // EditContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(495, 556);
            this.Controls.Add(this.ChbNo);
            this.Controls.Add(this.ChbYes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnConclude);
            this.Controls.Add(this.MTxbPhone);
            this.Controls.Add(this.TxbJobPosition);
            this.Controls.Add(this.TxbCompany);
            this.Controls.Add(this.TxbEmail);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditContactForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editando Contato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.TextBox TxbEmail;
        private System.Windows.Forms.TextBox TxbCompany;
        private System.Windows.Forms.TextBox TxbJobPosition;
        private System.Windows.Forms.MaskedTextBox MTxbPhone;
        private Componentes.CustomButton BtnConclude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ChbYes;
        private System.Windows.Forms.CheckBox ChbNo;
    }
}
