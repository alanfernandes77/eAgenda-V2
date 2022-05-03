using eAgenda.Componentes;

namespace eAgenda.Tarefas.Forms
{
    partial class TaskDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDashboard));
            this.PnlOpcoes = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSubCompleted = new eAgenda.Componentes.CustomButton();
            this.BtnSubPending = new eAgenda.Componentes.CustomButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PnlSelector = new System.Windows.Forms.Panel();
            this.BtnTarefas = new eAgenda.Componentes.CustomButton();
            this.BtnInicio = new eAgenda.Componentes.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlConteudo = new System.Windows.Forms.Panel();
            this.BtnNewTask = new eAgenda.Componentes.CustomButton();
            this.PnlOpcoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlOpcoes
            // 
            this.PnlOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.PnlOpcoes.Controls.Add(this.panel1);
            this.PnlOpcoes.Controls.Add(this.pictureBox2);
            this.PnlOpcoes.Controls.Add(this.PnlSelector);
            this.PnlOpcoes.Controls.Add(this.BtnTarefas);
            this.PnlOpcoes.Controls.Add(this.BtnInicio);
            this.PnlOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlOpcoes.Location = new System.Drawing.Point(0, 0);
            this.PnlOpcoes.Name = "PnlOpcoes";
            this.PnlOpcoes.Size = new System.Drawing.Size(232, 801);
            this.PnlOpcoes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BtnNewTask);
            this.panel1.Controls.Add(this.BtnSubCompleted);
            this.panel1.Controls.Add(this.BtnSubPending);
            this.panel1.Location = new System.Drawing.Point(23, 386);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 181);
            this.panel1.TabIndex = 7;
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
            this.BtnSubCompleted.Location = new System.Drawing.Point(3, 63);
            this.BtnSubCompleted.Name = "BtnSubCompleted";
            this.BtnSubCompleted.Padding = new System.Windows.Forms.Padding(20, 0, 41, 0);
            this.BtnSubCompleted.Size = new System.Drawing.Size(194, 54);
            this.BtnSubCompleted.TabIndex = 5;
            this.BtnSubCompleted.Text = "Concluídas";
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
            this.BtnSubPending.Location = new System.Drawing.Point(3, 123);
            this.BtnSubPending.Name = "BtnSubPending";
            this.BtnSubPending.Padding = new System.Windows.Forms.Padding(20, 0, 44, 0);
            this.BtnSubPending.Size = new System.Drawing.Size(194, 54);
            this.BtnSubPending.TabIndex = 4;
            this.BtnSubPending.Text = "Pendentes";
            this.BtnSubPending.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnSubPending.UseVisualStyleBackColor = false;
            this.BtnSubPending.Click += new System.EventHandler(this.BtnSubPending_Click);
            this.BtnSubPending.MouseLeave += new System.EventHandler(this.BtnSubPending_MouseLeave);
            this.BtnSubPending.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSubPending_MouseMove);
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
            // BtnTarefas
            // 
            this.BtnTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnTarefas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnTarefas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnTarefas.BorderRadius = 5;
            this.BtnTarefas.BorderSize = 0;
            this.BtnTarefas.FlatAppearance.BorderSize = 0;
            this.BtnTarefas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnTarefas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarefas.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTarefas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnTarefas.Image = ((System.Drawing.Image)(resources.GetObject("BtnTarefas.Image")));
            this.BtnTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarefas.Location = new System.Drawing.Point(11, 326);
            this.BtnTarefas.Name = "BtnTarefas";
            this.BtnTarefas.Padding = new System.Windows.Forms.Padding(20, 0, 73, 0);
            this.BtnTarefas.Size = new System.Drawing.Size(212, 54);
            this.BtnTarefas.TabIndex = 3;
            this.BtnTarefas.Text = "Tarefas";
            this.BtnTarefas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTarefas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnTarefas.UseVisualStyleBackColor = false;
            this.BtnTarefas.Click += new System.EventHandler(this.BtnTarefas_Click);
            this.BtnTarefas.MouseLeave += new System.EventHandler(this.BtnTarefas_MouseLeave);
            this.BtnTarefas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnTarefas_MouseMove);
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnInicio.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnInicio.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnInicio.BorderRadius = 5;
            this.BtnInicio.BorderSize = 0;
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(11, 250);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Padding = new System.Windows.Forms.Padding(20, 0, 90, 0);
            this.BtnInicio.Size = new System.Drawing.Size(212, 54);
            this.BtnInicio.TabIndex = 2;
            this.BtnInicio.Text = "Início";
            this.BtnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnInicio.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnInicio.UseVisualStyleBackColor = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            this.BtnInicio.MouseLeave += new System.EventHandler(this.BtnInicio_MouseLeave);
            this.BtnInicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnInicio_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.LblTitulo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(232, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 62);
            this.panel2.TabIndex = 1;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Poppins Medium", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(76, 13);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(0, 40);
            this.LblTitulo.TabIndex = 1;
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
            // PnlConteudo
            // 
            this.PnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlConteudo.Location = new System.Drawing.Point(232, 62);
            this.PnlConteudo.Name = "PnlConteudo";
            this.PnlConteudo.Size = new System.Drawing.Size(1225, 739);
            this.PnlConteudo.TabIndex = 2;
            // 
            // BtnNewTask
            // 
            this.BtnNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnNewTask.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(72)))), ((int)(((byte)(87)))));
            this.BtnNewTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnNewTask.BorderRadius = 5;
            this.BtnNewTask.BorderSize = 0;
            this.BtnNewTask.FlatAppearance.BorderSize = 0;
            this.BtnNewTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(158)))), ((int)(((byte)(132)))));
            this.BtnNewTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewTask.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnNewTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnNewTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNewTask.Location = new System.Drawing.Point(3, 3);
            this.BtnNewTask.Name = "BtnNewTask";
            this.BtnNewTask.Padding = new System.Windows.Forms.Padding(20, 0, 41, 0);
            this.BtnNewTask.Size = new System.Drawing.Size(194, 54);
            this.BtnNewTask.TabIndex = 6;
            this.BtnNewTask.Text = "Nova Tarefa";
            this.BtnNewTask.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.BtnNewTask.UseVisualStyleBackColor = false;
            this.BtnNewTask.Click += new System.EventHandler(this.BtnNewTask_Click);
            this.BtnNewTask.MouseLeave += new System.EventHandler(this.BtnNewTask_MouseLeave);
            this.BtnNewTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnNewTask_MouseMove);
            // 
            // TaskDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1457, 801);
            this.Controls.Add(this.PnlConteudo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda [Tarefas] Dashboard";
            this.Load += new System.EventHandler(this.TasksDashboard_Load);
            this.PnlOpcoes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlOpcoes;
        private System.Windows.Forms.Panel panel2;
        private CustomButton BtnTarefas;
        private CustomButton BtnInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlConteudo;
        internal System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Panel PnlSelector;
        private System.Windows.Forms.Panel panel1;
        private CustomButton BtnSubCompleted;
        private CustomButton BtnSubPending;
        private CustomButton BtnNewTask;
    }
}