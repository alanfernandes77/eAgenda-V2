using eAgenda.Componentes;

namespace eAgenda.Social.UserControls
{
    partial class ContactsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsControl));
            this.DgvContactsTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnAddContact = new eAgenda.Componentes.CustomButton();
            this.BtnEditContact = new eAgenda.Componentes.CustomButton();
            this.BtnDeleteContact = new eAgenda.Componentes.CustomButton();
            this.BtnViewContact = new eAgenda.Componentes.CustomButton();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactsTable)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvContactsTable
            // 
            this.DgvContactsTable.AllowUserToAddRows = false;
            this.DgvContactsTable.AllowUserToDeleteRows = false;
            this.DgvContactsTable.AllowUserToResizeColumns = false;
            this.DgvContactsTable.AllowUserToResizeRows = false;
            this.DgvContactsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvContactsTable.BackgroundColor = System.Drawing.Color.White;
            this.DgvContactsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvContactsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvContactsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvContactsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvContactsTable.ColumnHeadersHeight = 45;
            this.DgvContactsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvContactsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnName,
            this.ClnPhone,
            this.ClnEmail});
            this.DgvContactsTable.EnableHeadersVisualStyles = false;
            this.DgvContactsTable.GridColor = System.Drawing.Color.White;
            this.DgvContactsTable.Location = new System.Drawing.Point(3, 3);
            this.DgvContactsTable.MultiSelect = false;
            this.DgvContactsTable.Name = "DgvContactsTable";
            this.DgvContactsTable.ReadOnly = true;
            this.DgvContactsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvContactsTable.RowHeadersVisible = false;
            this.DgvContactsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.DgvContactsTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvContactsTable.RowTemplate.Height = 35;
            this.DgvContactsTable.RowTemplate.ReadOnly = true;
            this.DgvContactsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvContactsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvContactsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvContactsTable.Size = new System.Drawing.Size(1219, 569);
            this.DgvContactsTable.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.DgvContactsTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 575);
            this.panel1.TabIndex = 4;
            // 
            // BtnAddContact
            // 
            this.BtnAddContact.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAddContact.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAddContact.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddContact.BorderRadius = 5;
            this.BtnAddContact.BorderSize = 0;
            this.BtnAddContact.FlatAppearance.BorderSize = 0;
            this.BtnAddContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddContact.ForeColor = System.Drawing.Color.White;
            this.BtnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddContact.Image")));
            this.BtnAddContact.Location = new System.Drawing.Point(913, 16);
            this.BtnAddContact.Name = "BtnAddContact";
            this.BtnAddContact.Size = new System.Drawing.Size(69, 62);
            this.BtnAddContact.TabIndex = 5;
            this.BtnAddContact.TextColor = System.Drawing.Color.White;
            this.BtnAddContact.UseVisualStyleBackColor = false;
            this.BtnAddContact.Click += new System.EventHandler(this.BtnAddContact_Click);
            this.BtnAddContact.MouseLeave += new System.EventHandler(this.BtnAddContact_MouseLeave);
            this.BtnAddContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAddContact_MouseMove);
            // 
            // BtnEditContact
            // 
            this.BtnEditContact.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditContact.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditContact.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditContact.BorderRadius = 5;
            this.BtnEditContact.BorderSize = 0;
            this.BtnEditContact.FlatAppearance.BorderSize = 0;
            this.BtnEditContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditContact.ForeColor = System.Drawing.Color.White;
            this.BtnEditContact.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditContact.Image")));
            this.BtnEditContact.Location = new System.Drawing.Point(1063, 16);
            this.BtnEditContact.Name = "BtnEditContact";
            this.BtnEditContact.Size = new System.Drawing.Size(69, 62);
            this.BtnEditContact.TabIndex = 6;
            this.BtnEditContact.TextColor = System.Drawing.Color.White;
            this.BtnEditContact.UseVisualStyleBackColor = false;
            this.BtnEditContact.Click += new System.EventHandler(this.BtnEditContact_Click);
            this.BtnEditContact.MouseLeave += new System.EventHandler(this.BtnEditContact_MouseLeave);
            this.BtnEditContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEditContact_MouseMove);
            // 
            // BtnDeleteContact
            // 
            this.BtnDeleteContact.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteContact.BackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteContact.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDeleteContact.BorderRadius = 5;
            this.BtnDeleteContact.BorderSize = 0;
            this.BtnDeleteContact.FlatAppearance.BorderSize = 0;
            this.BtnDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteContact.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteContact.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteContact.Image")));
            this.BtnDeleteContact.Location = new System.Drawing.Point(1138, 16);
            this.BtnDeleteContact.Name = "BtnDeleteContact";
            this.BtnDeleteContact.Size = new System.Drawing.Size(69, 62);
            this.BtnDeleteContact.TabIndex = 7;
            this.BtnDeleteContact.TextColor = System.Drawing.Color.White;
            this.BtnDeleteContact.UseVisualStyleBackColor = false;
            this.BtnDeleteContact.Click += new System.EventHandler(this.BtnDeleteContact_Click);
            this.BtnDeleteContact.MouseLeave += new System.EventHandler(this.BtnDeleteContact_MouseLeave);
            this.BtnDeleteContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnDeleteContact_MouseMove);
            // 
            // BtnViewContact
            // 
            this.BtnViewContact.BackColor = System.Drawing.Color.Gold;
            this.BtnViewContact.BackgroundColor = System.Drawing.Color.Gold;
            this.BtnViewContact.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnViewContact.BorderRadius = 5;
            this.BtnViewContact.BorderSize = 0;
            this.BtnViewContact.FlatAppearance.BorderSize = 0;
            this.BtnViewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewContact.ForeColor = System.Drawing.Color.White;
            this.BtnViewContact.Image = ((System.Drawing.Image)(resources.GetObject("BtnViewContact.Image")));
            this.BtnViewContact.Location = new System.Drawing.Point(988, 16);
            this.BtnViewContact.Name = "BtnViewContact";
            this.BtnViewContact.Size = new System.Drawing.Size(69, 62);
            this.BtnViewContact.TabIndex = 8;
            this.BtnViewContact.TextColor = System.Drawing.Color.White;
            this.BtnViewContact.UseVisualStyleBackColor = false;
            this.BtnViewContact.Click += new System.EventHandler(this.BtnViewContact_Click);
            this.BtnViewContact.MouseLeave += new System.EventHandler(this.BtnViewContact_MouseLeave);
            this.BtnViewContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnViewContact_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnDeleteContact);
            this.panel2.Controls.Add(this.BtnViewContact);
            this.panel2.Controls.Add(this.BtnEditContact);
            this.panel2.Controls.Add(this.BtnAddContact);
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
            this.label1.Size = new System.Drawing.Size(363, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciando Contatos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 100);
            this.panel3.TabIndex = 5;
            // 
            // ClnName
            // 
            this.ClnName.DataPropertyName = "Name";
            this.ClnName.HeaderText = "Nome";
            this.ClnName.Name = "ClnName";
            this.ClnName.ReadOnly = true;
            this.ClnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnPhone
            // 
            this.ClnPhone.DataPropertyName = "Phone";
            this.ClnPhone.HeaderText = "Telefone";
            this.ClnPhone.Name = "ClnPhone";
            this.ClnPhone.ReadOnly = true;
            this.ClnPhone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnEmail
            // 
            this.ClnEmail.DataPropertyName = "Email";
            this.ClnEmail.HeaderText = "E-mail";
            this.ClnEmail.Name = "ClnEmail";
            this.ClnEmail.ReadOnly = true;
            this.ClnEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ContactsTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ContactsTableControl";
            this.Size = new System.Drawing.Size(1225, 730);
            this.Load += new System.EventHandler(this.ContactsTableControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvContactsTable)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomButton BtnAddContact;
        private CustomButton BtnEditContact;
        private CustomButton BtnDeleteContact;
        private CustomButton BtnViewContact;
        public System.Windows.Forms.DataGridView DgvContactsTable;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnEmail;
    }
}
