namespace eAgenda.Social.Forms.AppointmentForms
{
    partial class RegisterAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAppointmentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxbSubject = new System.Windows.Forms.TextBox();
            this.TxbLocal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ChbNo = new System.Windows.Forms.CheckBox();
            this.ChbYes = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClbAvailableContacts = new System.Windows.Forms.CheckedListBox();
            this.BtnAddContact = new eAgenda.Componentes.CustomButton();
            this.MtxbDate = new System.Windows.Forms.MaskedTextBox();
            this.MtxbEndTime = new System.Windows.Forms.MaskedTextBox();
            this.MtxbStartTime = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registrando Compromisso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Assunto *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(272, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Local *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(32, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(206, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Início *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(371, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fim *";
            // 
            // TxbSubject
            // 
            this.TxbSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbSubject.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbSubject.Location = new System.Drawing.Point(32, 136);
            this.TxbSubject.Name = "TxbSubject";
            this.TxbSubject.Size = new System.Drawing.Size(193, 27);
            this.TxbSubject.TabIndex = 8;
            // 
            // TxbLocal
            // 
            this.TxbLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbLocal.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbLocal.Location = new System.Drawing.Point(272, 136);
            this.TxbLocal.Name = "TxbLocal";
            this.TxbLocal.Size = new System.Drawing.Size(193, 27);
            this.TxbLocal.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(321, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "até";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(68, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(364, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Este compromisso possui algum contato relacionado?";
            // 
            // ChbNo
            // 
            this.ChbNo.AutoSize = true;
            this.ChbNo.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChbNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ChbNo.Location = new System.Drawing.Point(220, 349);
            this.ChbNo.Name = "ChbNo";
            this.ChbNo.Size = new System.Drawing.Size(54, 26);
            this.ChbNo.TabIndex = 17;
            this.ChbNo.Text = "Não";
            this.ChbNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChbNo.UseVisualStyleBackColor = true;
            this.ChbNo.CheckedChanged += new System.EventHandler(this.ChbNo_CheckedChanged);
            // 
            // ChbYes
            // 
            this.ChbYes.AutoSize = true;
            this.ChbYes.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChbYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ChbYes.Location = new System.Drawing.Point(220, 324);
            this.ChbYes.Name = "ChbYes";
            this.ChbYes.Size = new System.Drawing.Size(51, 26);
            this.ChbYes.TabIndex = 16;
            this.ChbYes.Text = "Sim";
            this.ChbYes.UseVisualStyleBackColor = true;
            this.ChbYes.CheckedChanged += new System.EventHandler(this.ChbYes_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label9.Location = new System.Drawing.Point(32, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Se sim, selecione os contatos abaixo:";
            // 
            // ClbAvailableContacts
            // 
            this.ClbAvailableContacts.CheckOnClick = true;
            this.ClbAvailableContacts.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClbAvailableContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClbAvailableContacts.FormattingEnabled = true;
            this.ClbAvailableContacts.Location = new System.Drawing.Point(32, 425);
            this.ClbAvailableContacts.Name = "ClbAvailableContacts";
            this.ClbAvailableContacts.Size = new System.Drawing.Size(433, 164);
            this.ClbAvailableContacts.TabIndex = 19;
            // 
            // BtnAddContact
            // 
            this.BtnAddContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAddContact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAddContact.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddContact.BorderRadius = 5;
            this.BtnAddContact.BorderSize = 0;
            this.BtnAddContact.FlatAppearance.BorderSize = 0;
            this.BtnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddContact.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddContact.ForeColor = System.Drawing.Color.White;
            this.BtnAddContact.Location = new System.Drawing.Point(32, 622);
            this.BtnAddContact.Name = "BtnAddContact";
            this.BtnAddContact.Size = new System.Drawing.Size(433, 40);
            this.BtnAddContact.TabIndex = 20;
            this.BtnAddContact.Text = "Adicionar";
            this.BtnAddContact.TextColor = System.Drawing.Color.White;
            this.BtnAddContact.UseVisualStyleBackColor = false;
            this.BtnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            // 
            // MtxbDate
            // 
            this.MtxbDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MtxbDate.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxbDate.Location = new System.Drawing.Point(32, 229);
            this.MtxbDate.Mask = "00/00/0000";
            this.MtxbDate.Name = "MtxbDate";
            this.MtxbDate.Size = new System.Drawing.Size(153, 27);
            this.MtxbDate.TabIndex = 21;
            this.MtxbDate.ValidatingType = typeof(System.DateTime);
            // 
            // MtxbEndTime
            // 
            this.MtxbEndTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MtxbEndTime.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxbEndTime.Location = new System.Drawing.Point(371, 229);
            this.MtxbEndTime.Mask = "00:00";
            this.MtxbEndTime.Name = "MtxbEndTime";
            this.MtxbEndTime.Size = new System.Drawing.Size(94, 27);
            this.MtxbEndTime.TabIndex = 22;
            // 
            // MtxbStartTime
            // 
            this.MtxbStartTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MtxbStartTime.Font = new System.Drawing.Font("Poppins Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MtxbStartTime.Location = new System.Drawing.Point(206, 229);
            this.MtxbStartTime.Mask = "00:00";
            this.MtxbStartTime.Name = "MtxbStartTime";
            this.MtxbStartTime.Size = new System.Drawing.Size(94, 27);
            this.MtxbStartTime.TabIndex = 23;
            // 
            // RegisterAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(494, 692);
            this.Controls.Add(this.MtxbStartTime);
            this.Controls.Add(this.MtxbEndTime);
            this.Controls.Add(this.MtxbDate);
            this.Controls.Add(this.BtnAddContact);
            this.Controls.Add(this.ClbAvailableContacts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChbNo);
            this.Controls.Add(this.ChbYes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxbLocal);
            this.Controls.Add(this.TxbSubject);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterAppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrando Compromisso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.TextBox TxbSubject;
        private System.Windows.Forms.TextBox TxbLocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ChbNo;
        private System.Windows.Forms.CheckBox ChbYes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox ClbAvailableContacts;
        private Componentes.CustomButton BtnAddContact;
        private System.Windows.Forms.MaskedTextBox MtxbDate;
        private System.Windows.Forms.MaskedTextBox MtxbEndTime;
        private System.Windows.Forms.MaskedTextBox MtxbStartTime;
    }
}