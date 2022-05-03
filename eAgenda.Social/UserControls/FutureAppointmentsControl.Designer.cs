namespace eAgenda.Social.UserControls
{
    partial class FutureAppointmentsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FutureAppointmentsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDeleteAppointment = new eAgenda.Componentes.CustomButton();
            this.BtnViewAppointment = new eAgenda.Componentes.CustomButton();
            this.BtnEditAppointment = new eAgenda.Componentes.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvFutureAppointments = new System.Windows.Forms.DataGridView();
            this.ClnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFutureAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 100);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnDeleteAppointment);
            this.panel2.Controls.Add(this.BtnViewAppointment);
            this.panel2.Controls.Add(this.BtnEditAppointment);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 94);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciando Compromissos Futuros";
            // 
            // BtnDeleteAppointment
            // 
            this.BtnDeleteAppointment.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteAppointment.BackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteAppointment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDeleteAppointment.BorderRadius = 5;
            this.BtnDeleteAppointment.BorderSize = 0;
            this.BtnDeleteAppointment.FlatAppearance.BorderSize = 0;
            this.BtnDeleteAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteAppointment.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteAppointment.Image")));
            this.BtnDeleteAppointment.Location = new System.Drawing.Point(1138, 16);
            this.BtnDeleteAppointment.Name = "BtnDeleteAppointment";
            this.BtnDeleteAppointment.Size = new System.Drawing.Size(69, 62);
            this.BtnDeleteAppointment.TabIndex = 7;
            this.BtnDeleteAppointment.TextColor = System.Drawing.Color.White;
            this.BtnDeleteAppointment.UseVisualStyleBackColor = false;
            this.BtnDeleteAppointment.Click += new System.EventHandler(this.BtnDeleteAppointment_Click);
            this.BtnDeleteAppointment.MouseLeave += new System.EventHandler(this.BtnDeleteAppointment_MouseLeave);
            this.BtnDeleteAppointment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnDeleteAppointment_MouseMove);
            // 
            // BtnViewAppointment
            // 
            this.BtnViewAppointment.BackColor = System.Drawing.Color.Gold;
            this.BtnViewAppointment.BackgroundColor = System.Drawing.Color.Gold;
            this.BtnViewAppointment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnViewAppointment.BorderRadius = 5;
            this.BtnViewAppointment.BorderSize = 0;
            this.BtnViewAppointment.FlatAppearance.BorderSize = 0;
            this.BtnViewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnViewAppointment.Image = ((System.Drawing.Image)(resources.GetObject("BtnViewAppointment.Image")));
            this.BtnViewAppointment.Location = new System.Drawing.Point(988, 16);
            this.BtnViewAppointment.Name = "BtnViewAppointment";
            this.BtnViewAppointment.Size = new System.Drawing.Size(69, 62);
            this.BtnViewAppointment.TabIndex = 8;
            this.BtnViewAppointment.TextColor = System.Drawing.Color.White;
            this.BtnViewAppointment.UseVisualStyleBackColor = false;
            this.BtnViewAppointment.Click += new System.EventHandler(this.BtnViewAppointment_Click);
            this.BtnViewAppointment.MouseLeave += new System.EventHandler(this.BtnViewAppointment_MouseLeave);
            this.BtnViewAppointment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnViewAppointment_MouseMove);
            // 
            // BtnEditAppointment
            // 
            this.BtnEditAppointment.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditAppointment.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditAppointment.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditAppointment.BorderRadius = 5;
            this.BtnEditAppointment.BorderSize = 0;
            this.BtnEditAppointment.FlatAppearance.BorderSize = 0;
            this.BtnEditAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditAppointment.ForeColor = System.Drawing.Color.White;
            this.BtnEditAppointment.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditAppointment.Image")));
            this.BtnEditAppointment.Location = new System.Drawing.Point(1063, 16);
            this.BtnEditAppointment.Name = "BtnEditAppointment";
            this.BtnEditAppointment.Size = new System.Drawing.Size(69, 62);
            this.BtnEditAppointment.TabIndex = 6;
            this.BtnEditAppointment.TextColor = System.Drawing.Color.White;
            this.BtnEditAppointment.UseVisualStyleBackColor = false;
            this.BtnEditAppointment.Click += new System.EventHandler(this.BtnEditAppointment_Click);
            this.BtnEditAppointment.MouseLeave += new System.EventHandler(this.BtnEditAppointment_MouseLeave);
            this.BtnEditAppointment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEditAppointment_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.DgvFutureAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 575);
            this.panel1.TabIndex = 6;
            // 
            // DgvAppointmentsTable
            // 
            this.DgvFutureAppointments.AllowUserToAddRows = false;
            this.DgvFutureAppointments.AllowUserToDeleteRows = false;
            this.DgvFutureAppointments.AllowUserToResizeColumns = false;
            this.DgvFutureAppointments.AllowUserToResizeRows = false;
            this.DgvFutureAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFutureAppointments.BackgroundColor = System.Drawing.Color.White;
            this.DgvFutureAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvFutureAppointments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvFutureAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvFutureAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvFutureAppointments.ColumnHeadersHeight = 45;
            this.DgvFutureAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvFutureAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnSubject,
            this.ClnLocal,
            this.ClnData,
            this.ClnStartTime,
            this.ClnEndTime});
            this.DgvFutureAppointments.EnableHeadersVisualStyles = false;
            this.DgvFutureAppointments.GridColor = System.Drawing.Color.White;
            this.DgvFutureAppointments.Location = new System.Drawing.Point(3, 3);
            this.DgvFutureAppointments.MultiSelect = false;
            this.DgvFutureAppointments.Name = "DgvAppointmentsTable";
            this.DgvFutureAppointments.ReadOnly = true;
            this.DgvFutureAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvFutureAppointments.RowHeadersVisible = false;
            this.DgvFutureAppointments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.DgvFutureAppointments.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvFutureAppointments.RowTemplate.Height = 35;
            this.DgvFutureAppointments.RowTemplate.ReadOnly = true;
            this.DgvFutureAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvFutureAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvFutureAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFutureAppointments.Size = new System.Drawing.Size(1219, 569);
            this.DgvFutureAppointments.TabIndex = 3;
            // 
            // ClnSubject
            // 
            this.ClnSubject.DataPropertyName = "Subject";
            this.ClnSubject.HeaderText = "Assunto";
            this.ClnSubject.Name = "ClnSubject";
            this.ClnSubject.ReadOnly = true;
            this.ClnSubject.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnSubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnLocal
            // 
            this.ClnLocal.DataPropertyName = "Local";
            this.ClnLocal.HeaderText = "Local";
            this.ClnLocal.Name = "ClnLocal";
            this.ClnLocal.ReadOnly = true;
            // 
            // ClnData
            // 
            this.ClnData.DataPropertyName = "Data";
            this.ClnData.HeaderText = "Data";
            this.ClnData.Name = "ClnData";
            this.ClnData.ReadOnly = true;
            this.ClnData.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnData.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnStartTime
            // 
            this.ClnStartTime.DataPropertyName = "StartTime";
            this.ClnStartTime.HeaderText = "Início";
            this.ClnStartTime.Name = "ClnStartTime";
            this.ClnStartTime.ReadOnly = true;
            this.ClnStartTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnStartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnEndTime
            // 
            this.ClnEndTime.DataPropertyName = "EndTime";
            this.ClnEndTime.HeaderText = "Fim";
            this.ClnEndTime.Name = "ClnEndTime";
            this.ClnEndTime.ReadOnly = true;
            // 
            // FutureAppointmentsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FutureAppointmentsControl";
            this.Size = new System.Drawing.Size(1225, 730);
            this.Load += new System.EventHandler(this.FutureAppointmentsControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFutureAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Componentes.CustomButton BtnDeleteAppointment;
        private Componentes.CustomButton BtnViewAppointment;
        private Componentes.CustomButton BtnEditAppointment;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DgvFutureAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEndTime;
        public System.Windows.Forms.Label label1;
    }
}
