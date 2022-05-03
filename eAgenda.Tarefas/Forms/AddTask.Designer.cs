using eAgenda.Componentes;

namespace eAgenda.Tarefas.Forms
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTaskNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbTaskTitle = new System.Windows.Forms.TextBox();
            this.BtnAddTask = new eAgenda.Componentes.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxPrioridadeBaixa = new System.Windows.Forms.CheckBox();
            this.CbxPrioridadeNormal = new System.Windows.Forms.CheckBox();
            this.CbxPrioridadeAlta = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChbContinueAdding = new eAgenda.Componentes.CustomCheckBox();
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
            this.panel1.Size = new System.Drawing.Size(528, 68);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(137, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionando Tarefa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LblTaskNumber
            // 
            this.LblTaskNumber.AutoSize = true;
            this.LblTaskNumber.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTaskNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.LblTaskNumber.Location = new System.Drawing.Point(204, 94);
            this.LblTaskNumber.Name = "LblTaskNumber";
            this.LblTaskNumber.Size = new System.Drawing.Size(0, 23);
            this.LblTaskNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(52, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Insira o título da tarefa:";
            // 
            // TxbTaskTitle
            // 
            this.TxbTaskTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.TxbTaskTitle.Font = new System.Drawing.Font("Poppins", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxbTaskTitle.Location = new System.Drawing.Point(55, 226);
            this.TxbTaskTitle.MaxLength = 40;
            this.TxbTaskTitle.Name = "TxbTaskTitle";
            this.TxbTaskTitle.Size = new System.Drawing.Size(431, 29);
            this.TxbTaskTitle.TabIndex = 14;
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAddTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnAddTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddTask.BorderRadius = 5;
            this.BtnAddTask.BorderSize = 0;
            this.BtnAddTask.FlatAppearance.BorderSize = 0;
            this.BtnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTask.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAddTask.ForeColor = System.Drawing.Color.White;
            this.BtnAddTask.Location = new System.Drawing.Point(205, 537);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(119, 44);
            this.BtnAddTask.TabIndex = 15;
            this.BtnAddTask.Text = "Adicionar";
            this.BtnAddTask.TextColor = System.Drawing.Color.White;
            this.BtnAddTask.UseVisualStyleBackColor = false;
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            this.BtnAddTask.MouseLeave += new System.EventHandler(this.BtnAddTask_MouseLeave);
            this.BtnAddTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnAddTask_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(51, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Defina  a prioridade da tarefa:";
            // 
            // CbxPrioridadeBaixa
            // 
            this.CbxPrioridadeBaixa.AutoSize = true;
            this.CbxPrioridadeBaixa.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxPrioridadeBaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.CbxPrioridadeBaixa.Location = new System.Drawing.Point(55, 335);
            this.CbxPrioridadeBaixa.Name = "CbxPrioridadeBaixa";
            this.CbxPrioridadeBaixa.Size = new System.Drawing.Size(64, 27);
            this.CbxPrioridadeBaixa.TabIndex = 17;
            this.CbxPrioridadeBaixa.Text = "Baixa";
            this.CbxPrioridadeBaixa.UseVisualStyleBackColor = true;
            this.CbxPrioridadeBaixa.CheckedChanged += new System.EventHandler(this.CbxPrioridadeBaixa_CheckedChanged);
            // 
            // CbxPrioridadeNormal
            // 
            this.CbxPrioridadeNormal.AutoSize = true;
            this.CbxPrioridadeNormal.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxPrioridadeNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.CbxPrioridadeNormal.Location = new System.Drawing.Point(55, 360);
            this.CbxPrioridadeNormal.Name = "CbxPrioridadeNormal";
            this.CbxPrioridadeNormal.Size = new System.Drawing.Size(77, 27);
            this.CbxPrioridadeNormal.TabIndex = 18;
            this.CbxPrioridadeNormal.Text = "Normal";
            this.CbxPrioridadeNormal.UseVisualStyleBackColor = true;
            this.CbxPrioridadeNormal.CheckedChanged += new System.EventHandler(this.CbxPrioridadeNormal_CheckedChanged);
            // 
            // CbxPrioridadeAlta
            // 
            this.CbxPrioridadeAlta.AutoSize = true;
            this.CbxPrioridadeAlta.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CbxPrioridadeAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.CbxPrioridadeAlta.Location = new System.Drawing.Point(55, 385);
            this.CbxPrioridadeAlta.Name = "CbxPrioridadeAlta";
            this.CbxPrioridadeAlta.Size = new System.Drawing.Size(55, 27);
            this.CbxPrioridadeAlta.TabIndex = 19;
            this.CbxPrioridadeAlta.Text = "Alta";
            this.CbxPrioridadeAlta.UseVisualStyleBackColor = true;
            this.CbxPrioridadeAlta.CheckedChanged += new System.EventHandler(this.CbxPrioridadeAlta_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(51, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Continuar Adicionando";
            // 
            // ChbContinueAdding
            // 
            this.ChbContinueAdding.AutoSize = true;
            this.ChbContinueAdding.Location = new System.Drawing.Point(55, 475);
            this.ChbContinueAdding.MinimumSize = new System.Drawing.Size(45, 22);
            this.ChbContinueAdding.Name = "ChbContinueAdding";
            this.ChbContinueAdding.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.ChbContinueAdding.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.ChbContinueAdding.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ChbContinueAdding.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.ChbContinueAdding.Size = new System.Drawing.Size(45, 22);
            this.ChbContinueAdding.TabIndex = 21;
            this.ChbContinueAdding.UseVisualStyleBackColor = true;
            this.ChbContinueAdding.MouseLeave += new System.EventHandler(this.ChbContinueAdding_MouseLeave);
            this.ChbContinueAdding.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChbContinueAdding_MouseMove);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(528, 612);
            this.Controls.Add(this.ChbContinueAdding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbxPrioridadeAlta);
            this.Controls.Add(this.CbxPrioridadeNormal);
            this.Controls.Add(this.CbxPrioridadeBaixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddTask);
            this.Controls.Add(this.TxbTaskTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblTaskNumber);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionando Tarefa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTaskNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbTaskTitle;
        private CustomButton BtnAddTask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbxPrioridadeBaixa;
        private System.Windows.Forms.CheckBox CbxPrioridadeNormal;
        private System.Windows.Forms.CheckBox CbxPrioridadeAlta;
        private System.Windows.Forms.Label label2;
        private CustomCheckBox ChbContinueAdding;
    }
}
