using eAgenda.Componentes;

namespace eAgenda.Social
{
    partial class SocialDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SocialDashboard));
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNewAppointment = new eAgenda.Componentes.CustomButton();
            this.BtnSubCompleted = new eAgenda.Componentes.CustomButton();
            this.BtnSubPending = new eAgenda.Componentes.CustomButton();
            this.BtnAppointments = new eAgenda.Componentes.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlSelector = new System.Windows.Forms.Panel();
            this.BtnContacts = new eAgenda.Componentes.CustomButton();
            this.BtnHome = new eAgenda.Componentes.CustomButton();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.PnlOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOptions
            // 
            this.PnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.PnlOptions.Controls.Add(this.panel1);
            this.PnlOptions.Controls.Add(this.BtnAppointments);
            this.PnlOptions.Controls.Add(this.pictureBox2);
            this.PnlOptions.Controls.Add(this.PnlSelector);
            this.PnlOptions.Controls.Add(this.BtnContacts);
            this.PnlOptions.Controls.Add(this.BtnHome);
            this.PnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlOptions.Location = new System.Drawing.Point(0, 0);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(232, 801);
            this.PnlOptions.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnNewAppointment);
            this.panel1.Controls.Add(this.BtnSubCompleted);
            this.panel1.Controls.Add(this.BtnSubPending);
            this.panel1.Location = new System.Drawing.Point(23, 430);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 181);
            this.panel1.TabIndex = 8;
            // 
            // BtnNewAppointment
            // 
            this.BtnNewAppointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnNewAppointment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnNewAppointment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNewAppointment.BorderRadius = 5;
            this.BtnNewAppointment.BorderSize = 0;
            this.BtnNewAppointment.FlatAppearance.BorderSize = 0;
            this.BtnNewAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnNewAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewAppointment.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNewAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnNewAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewAppointment.Location = new System.Drawing.Point(3, 4);
            this.BtnNewAppointment.Name = "BtnNewAppointment";
            this.BtnNewAppointment.Size = new System.Drawing.Size(194, 54);
            this.BtnNewAppointment.TabIndex = 6;
            this.BtnNewAppointment.Text = "Novo Compromisso";
            this.BtnNewAppointment.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnNewAppointment.UseVisualStyleBackColor = false;
            this.BtnNewAppointment.Click += new System.EventHandler(this.BtnNewAppointment_Click);
            this.BtnNewAppointment.MouseLeave += new System.EventHandler(this.BtnNewAppointment_MouseLeave);
            this.BtnNewAppointment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnNewAppointment_MouseMove);
            // 
            // BtnSubCompleted
            // 
            this.BtnSubCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnSubCompleted.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnSubCompleted.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSubCompleted.BorderRadius = 5;
            this.BtnSubCompleted.BorderSize = 0;
            this.BtnSubCompleted.FlatAppearance.BorderSize = 0;
            this.BtnSubCompleted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnSubCompleted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnSubCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubCompleted.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSubCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnSubCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubCompleted.Location = new System.Drawing.Point(3, 124);
            this.BtnSubCompleted.Name = "BtnSubCompleted";
            this.BtnSubCompleted.Padding = new System.Windows.Forms.Padding(20, 0, 40, 0);
            this.BtnSubCompleted.Size = new System.Drawing.Size(194, 54);
            this.BtnSubCompleted.TabIndex = 5;
            this.BtnSubCompleted.Text = "Futuros";
            this.BtnSubCompleted.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnSubCompleted.UseVisualStyleBackColor = false;
            this.BtnSubCompleted.Click += new System.EventHandler(this.BtnSubCompleted_Click);
            this.BtnSubCompleted.MouseLeave += new System.EventHandler(this.BtnSubCompleted_MouseLeave);
            this.BtnSubCompleted.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSubCompleted_MouseMove);
            // 
            // BtnSubPending
            // 
            this.BtnSubPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnSubPending.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnSubPending.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSubPending.BorderRadius = 5;
            this.BtnSubPending.BorderSize = 0;
            this.BtnSubPending.FlatAppearance.BorderSize = 0;
            this.BtnSubPending.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnSubPending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnSubPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubPending.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSubPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnSubPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubPending.Location = new System.Drawing.Point(3, 64);
            this.BtnSubPending.Name = "BtnSubPending";
            this.BtnSubPending.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.BtnSubPending.Size = new System.Drawing.Size(194, 54);
            this.BtnSubPending.TabIndex = 4;
            this.BtnSubPending.Text = "Pendentes";
            this.BtnSubPending.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnSubPending.UseVisualStyleBackColor = false;
            this.BtnSubPending.Click += new System.EventHandler(this.BtnSubPending_Click);
            this.BtnSubPending.MouseLeave += new System.EventHandler(this.BtnSubPending_MouseLeave);
            this.BtnSubPending.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSubPending_MouseMove);
            // 
            // BtnAppointments
            // 
            this.BtnAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnAppointments.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAppointments.BorderRadius = 5;
            this.BtnAppointments.BorderSize = 0;
            this.BtnAppointments.FlatAppearance.BorderSize = 0;
            this.BtnAppointments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnAppointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAppointments.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAppointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnAppointments.Image = ((System.Drawing.Image)(resources.GetObject("BtnAppointments.Image")));
            this.BtnAppointments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAppointments.Location = new System.Drawing.Point(11, 370);
            this.BtnAppointments.Name = "BtnAppointments";
            this.BtnAppointments.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.BtnAppointments.Size = new System.Drawing.Size(212, 54);
            this.BtnAppointments.TabIndex = 7;
            this.BtnAppointments.Text = "Compromissos";
            this.BtnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAppointments.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnAppointments.UseVisualStyleBackColor = false;
            this.BtnAppointments.Click += new System.EventHandler(this.BtnAppointments_Click);
            this.BtnAppointments.MouseLeave += new System.EventHandler(this.BtnAppointments_MouseLeave);
            this.BtnAppointments.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAppointments_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(47, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // PnlSelector
            // 
            this.PnlSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.PnlSelector.Location = new System.Drawing.Point(0, 251);
            this.PnlSelector.Name = "PnlSelector";
            this.PnlSelector.Size = new System.Drawing.Size(5, 53);
            this.PnlSelector.TabIndex = 5;
            // 
            // BtnContacts
            // 
            this.BtnContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnContacts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnContacts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnContacts.BorderRadius = 5;
            this.BtnContacts.BorderSize = 0;
            this.BtnContacts.FlatAppearance.BorderSize = 0;
            this.BtnContacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnContacts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContacts.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnContacts.Image = ((System.Drawing.Image)(resources.GetObject("BtnContacts.Image")));
            this.BtnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContacts.Location = new System.Drawing.Point(11, 310);
            this.BtnContacts.Name = "BtnContacts";
            this.BtnContacts.Padding = new System.Windows.Forms.Padding(20, 0, 60, 0);
            this.BtnContacts.Size = new System.Drawing.Size(212, 54);
            this.BtnContacts.TabIndex = 3;
            this.BtnContacts.Text = "Contatos";
            this.BtnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnContacts.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnContacts.UseVisualStyleBackColor = false;
            this.BtnContacts.Click += new System.EventHandler(this.BtnContacts_Click);
            this.BtnContacts.MouseLeave += new System.EventHandler(this.BtnContacts_MouseLeave);
            this.BtnContacts.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnContacts_MouseMove);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnHome.BorderRadius = 5;
            this.BtnHome.BorderSize = 0;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHome.Location = new System.Drawing.Point(11, 250);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Padding = new System.Windows.Forms.Padding(20, 0, 90, 0);
            this.BtnHome.Size = new System.Drawing.Size(212, 54);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Início";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            this.BtnHome.MouseLeave += new System.EventHandler(this.BtnHome_MouseLeave);
            this.BtnHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnHome_MouseMove);
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.PnlHeader.Controls.Add(this.LblTitle);
            this.PnlHeader.Controls.Add(this.pictureBox1);
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(232, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(1225, 62);
            this.PnlHeader.TabIndex = 1;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Poppins Medium", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitle.ForeColor = System.Drawing.Color.White;
            this.LblTitle.Location = new System.Drawing.Point(76, 13);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(0, 40);
            this.LblTitle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlContent
            // 
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(232, 62);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(1225, 739);
            this.PnlContent.TabIndex = 2;
            // 
            // SocialDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1457, 801);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.PnlOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SocialDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda [Social] Dashboard";
            this.Load += new System.EventHandler(this.SocialDashboard_Load);
            this.PnlOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PnlHeader.ResumeLayout(false);
            this.PnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlOptions;
        private System.Windows.Forms.Panel PnlHeader;
        private CustomButton BtnContacts;
        private CustomButton BtnHome;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlContent;
        internal System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlSelector;
        private CustomButton BtnAppointments;
        private System.Windows.Forms.Panel panel1;
        private CustomButton BtnSubCompleted;
        private CustomButton BtnSubPending;
        private CustomButton BtnNewAppointment;
    }
}