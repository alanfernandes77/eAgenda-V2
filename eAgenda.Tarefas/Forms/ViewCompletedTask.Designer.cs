﻿using eAgenda.Componentes;

namespace eAgenda.Tarefas.Forms
{
    partial class ViewCompletedTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCompletedTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new eAgenda.Componentes.CustomButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblTaskConclusionDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblTaskItensRegistered = new System.Windows.Forms.Label();
            this.LblTaskNumber = new System.Windows.Forms.Label();
            this.LblTaskCompletedPercentage = new System.Windows.Forms.Label();
            this.LblTaskTitle = new System.Windows.Forms.Label();
            this.LblCreationDate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClbTaskItens = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(527, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizando Tarefa";
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBack.BorderRadius = 5;
            this.BtnBack.BorderSize = 0;
            this.BtnBack.FlatAppearance.BorderSize = 0;
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(37, 594);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(453, 44);
            this.BtnBack.TabIndex = 17;
            this.BtnBack.Text = "Voltar";
            this.BtnBack.TextColor = System.Drawing.Color.White;
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.BtnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            this.BtnBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnBack_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(37, 186);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 148);
            this.panel4.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.LblTaskConclusionDate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.LblTaskItensRegistered);
            this.panel3.Controls.Add(this.LblTaskNumber);
            this.panel3.Controls.Add(this.LblTaskCompletedPercentage);
            this.panel3.Controls.Add(this.LblTaskTitle);
            this.panel3.Controls.Add(this.LblCreationDate);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 142);
            this.panel3.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(3, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(229, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Título:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Criação:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(229, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Percentual Concluído:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Itens Cadastrados:";
            // 
            // LblTaskConclusionDate
            // 
            this.LblTaskConclusionDate.AutoSize = true;
            this.LblTaskConclusionDate.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskConclusionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskConclusionDate.Location = new System.Drawing.Point(362, 99);
            this.LblTaskConclusionDate.Name = "LblTaskConclusionDate";
            this.LblTaskConclusionDate.Size = new System.Drawing.Size(0, 22);
            this.LblTaskConclusionDate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label7.Location = new System.Drawing.Point(229, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Data de Conclusão:";
            // 
            // LblTaskItensRegistered
            // 
            this.LblTaskItensRegistered.AutoSize = true;
            this.LblTaskItensRegistered.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskItensRegistered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskItensRegistered.Location = new System.Drawing.Point(134, 99);
            this.LblTaskItensRegistered.Name = "LblTaskItensRegistered";
            this.LblTaskItensRegistered.Size = new System.Drawing.Size(0, 22);
            this.LblTaskItensRegistered.TabIndex = 13;
            // 
            // LblTaskNumber
            // 
            this.LblTaskNumber.AutoSize = true;
            this.LblTaskNumber.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskNumber.Location = new System.Drawing.Point(64, 24);
            this.LblTaskNumber.Name = "LblTaskNumber";
            this.LblTaskNumber.Size = new System.Drawing.Size(0, 22);
            this.LblTaskNumber.TabIndex = 9;
            // 
            // LblTaskCompletedPercentage
            // 
            this.LblTaskCompletedPercentage.AutoSize = true;
            this.LblTaskCompletedPercentage.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskCompletedPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskCompletedPercentage.Location = new System.Drawing.Point(376, 60);
            this.LblTaskCompletedPercentage.Name = "LblTaskCompletedPercentage";
            this.LblTaskCompletedPercentage.Size = new System.Drawing.Size(0, 22);
            this.LblTaskCompletedPercentage.TabIndex = 12;
            // 
            // LblTaskTitle
            // 
            this.LblTaskTitle.AutoSize = true;
            this.LblTaskTitle.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskTitle.Location = new System.Drawing.Point(272, 24);
            this.LblTaskTitle.Name = "LblTaskTitle";
            this.LblTaskTitle.Size = new System.Drawing.Size(0, 22);
            this.LblTaskTitle.TabIndex = 10;
            // 
            // LblCreationDate
            // 
            this.LblCreationDate.AutoSize = true;
            this.LblCreationDate.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCreationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblCreationDate.Location = new System.Drawing.Point(119, 60);
            this.LblCreationDate.Name = "LblCreationDate";
            this.LblCreationDate.Size = new System.Drawing.Size(0, 22);
            this.LblCreationDate.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.ClbTaskItens);
            this.panel2.Location = new System.Drawing.Point(37, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 183);
            this.panel2.TabIndex = 24;
            // 
            // ClbTaskItens
            // 
            this.ClbTaskItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ClbTaskItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClbTaskItens.CheckOnClick = true;
            this.ClbTaskItens.Enabled = false;
            this.ClbTaskItens.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClbTaskItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClbTaskItens.FormattingEnabled = true;
            this.ClbTaskItens.Location = new System.Drawing.Point(3, 3);
            this.ClbTaskItens.Name = "ClbTaskItens";
            this.ClbTaskItens.Size = new System.Drawing.Size(444, 176);
            this.ClbTaskItens.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label8.Location = new System.Drawing.Point(37, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Itens:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(219, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // ViewCompletedTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(527, 663);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewCompletedTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizando Tarefa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private CustomButton BtnBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblTaskConclusionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblTaskItensRegistered;
        private System.Windows.Forms.Label LblTaskNumber;
        private System.Windows.Forms.Label LblTaskCompletedPercentage;
        private System.Windows.Forms.Label LblTaskTitle;
        private System.Windows.Forms.Label LblCreationDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox ClbTaskItens;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
