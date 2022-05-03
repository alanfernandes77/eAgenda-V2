using eAgenda.Componentes;

namespace eAgenda.Tarefas.Forms
{
    partial class AddItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItems));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTaskTitle = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddItem = new eAgenda.Componentes.CustomButton();
            this.TxbItemDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblTaskNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LbxTaskItensToAdd = new System.Windows.Forms.ListBox();
            this.BtnConclude = new eAgenda.Componentes.CustomButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionando Itens";
            // 
            // LblTaskTitle
            // 
            this.LblTaskTitle.AutoSize = true;
            this.LblTaskTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskTitle.Location = new System.Drawing.Point(168, 124);
            this.LblTaskTitle.Name = "LblTaskTitle";
            this.LblTaskTitle.Size = new System.Drawing.Size(0, 23);
            this.LblTaskTitle.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(127, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Título:";
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAddItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAddItem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddItem.BorderRadius = 5;
            this.BtnAddItem.BorderSize = 0;
            this.BtnAddItem.FlatAppearance.BorderSize = 0;
            this.BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddItem.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddItem.ForeColor = System.Drawing.Color.White;
            this.BtnAddItem.Location = new System.Drawing.Point(202, 295);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(116, 44);
            this.BtnAddItem.TabIndex = 30;
            this.BtnAddItem.Text = "Adicionar";
            this.BtnAddItem.TextColor = System.Drawing.Color.White;
            this.BtnAddItem.UseVisualStyleBackColor = false;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            this.BtnAddItem.MouseLeave += new System.EventHandler(this.BtnAddItem_MouseLeave);
            this.BtnAddItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAddItem_MouseMove);
            // 
            // TxbItemDescription
            // 
            this.TxbItemDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbItemDescription.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbItemDescription.Location = new System.Drawing.Point(52, 230);
            this.TxbItemDescription.MaxLength = 40;
            this.TxbItemDescription.Name = "TxbItemDescription";
            this.TxbItemDescription.Size = new System.Drawing.Size(428, 29);
            this.TxbItemDescription.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(52, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Insira a descrição da item:";
            // 
            // LblTaskNumber
            // 
            this.LblTaskNumber.AutoSize = true;
            this.LblTaskNumber.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskNumber.Location = new System.Drawing.Point(187, 98);
            this.LblTaskNumber.Name = "LblTaskNumber";
            this.LblTaskNumber.Size = new System.Drawing.Size(0, 23);
            this.LblTaskNumber.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(127, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Número:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(34, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Itens adicionados:";
            // 
            // LbxTaskItensToAdd
            // 
            this.LbxTaskItensToAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.LbxTaskItensToAdd.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbxTaskItensToAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LbxTaskItensToAdd.FormattingEnabled = true;
            this.LbxTaskItensToAdd.ItemHeight = 23;
            this.LbxTaskItensToAdd.Location = new System.Drawing.Point(34, 389);
            this.LbxTaskItensToAdd.Name = "LbxTaskItensToAdd";
            this.LbxTaskItensToAdd.Size = new System.Drawing.Size(460, 165);
            this.LbxTaskItensToAdd.TabIndex = 35;
            // 
            // BtnConclude
            // 
            this.BtnConclude.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnConclude.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnConclude.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnConclude.BorderRadius = 5;
            this.BtnConclude.BorderSize = 0;
            this.BtnConclude.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConclude.FlatAppearance.BorderSize = 0;
            this.BtnConclude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConclude.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnConclude.ForeColor = System.Drawing.Color.White;
            this.BtnConclude.Location = new System.Drawing.Point(202, 590);
            this.BtnConclude.Name = "BtnConclude";
            this.BtnConclude.Size = new System.Drawing.Size(116, 44);
            this.BtnConclude.TabIndex = 36;
            this.BtnConclude.Text = "Concluir";
            this.BtnConclude.TextColor = System.Drawing.Color.White;
            this.BtnConclude.UseVisualStyleBackColor = false;
            this.BtnConclude.Click += new System.EventHandler(this.BtnConclude_Click);
            this.BtnConclude.MouseLeave += new System.EventHandler(this.BtnConclude_MouseLeave);
            this.BtnConclude.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnConclude_MouseMove);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(526, 668);
            this.Controls.Add(this.BtnConclude);
            this.Controls.Add(this.LbxTaskItensToAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblTaskTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddItem);
            this.Controls.Add(this.TxbItemDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTaskNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionando Itens";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTaskTitle;
        private System.Windows.Forms.Label label4;
        private CustomButton BtnAddItem;
        private System.Windows.Forms.TextBox TxbItemDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTaskNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LbxTaskItensToAdd;
        private CustomButton BtnConclude;
    }
}
