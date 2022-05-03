using eAgenda.Componentes;

namespace eAgenda.Tarefas.Forms
{
    partial class EditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTaskTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTaskNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbTaskTitle = new System.Windows.Forms.TextBox();
            this.BtnEditTask = new eAgenda.Componentes.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 68);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(158, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editando Tarefa";
            // 
            // LblTaskTitle
            // 
            this.LblTaskTitle.AutoSize = true;
            this.LblTaskTitle.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskTitle.Location = new System.Drawing.Point(168, 122);
            this.LblTaskTitle.Name = "LblTaskTitle";
            this.LblTaskTitle.Size = new System.Drawing.Size(0, 23);
            this.LblTaskTitle.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(127, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Número:";
            // 
            // LblTaskNumber
            // 
            this.LblTaskNumber.AutoSize = true;
            this.LblTaskNumber.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskNumber.Location = new System.Drawing.Point(187, 96);
            this.LblTaskNumber.Name = "LblTaskNumber";
            this.LblTaskNumber.Size = new System.Drawing.Size(0, 23);
            this.LblTaskNumber.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(51, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Insira um novo título:";
            // 
            // TxbTaskTitle
            // 
            this.TxbTaskTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbTaskTitle.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbTaskTitle.Location = new System.Drawing.Point(51, 228);
            this.TxbTaskTitle.MaxLength = 40;
            this.TxbTaskTitle.Name = "TxbTaskTitle";
            this.TxbTaskTitle.Size = new System.Drawing.Size(428, 29);
            this.TxbTaskTitle.TabIndex = 21;
            // 
            // BtnEditTask
            // 
            this.BtnEditTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnEditTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnEditTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditTask.BorderRadius = 5;
            this.BtnEditTask.BorderSize = 0;
            this.BtnEditTask.FlatAppearance.BorderSize = 0;
            this.BtnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditTask.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnEditTask.ForeColor = System.Drawing.Color.White;
            this.BtnEditTask.Location = new System.Drawing.Point(201, 293);
            this.BtnEditTask.Name = "BtnEditTask";
            this.BtnEditTask.Size = new System.Drawing.Size(116, 44);
            this.BtnEditTask.TabIndex = 22;
            this.BtnEditTask.Text = "Editar";
            this.BtnEditTask.TextColor = System.Drawing.Color.White;
            this.BtnEditTask.UseVisualStyleBackColor = false;
            this.BtnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            this.BtnEditTask.MouseLeave += new System.EventHandler(this.BtnEditTask_MouseLeave);
            this.BtnEditTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEditTask_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(127, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Título:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(530, 370);
            this.Controls.Add(this.LblTaskTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEditTask);
            this.Controls.Add(this.TxbTaskTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTaskNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editando Tarefa";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTaskNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbTaskTitle;
        private CustomButton BtnEditTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
