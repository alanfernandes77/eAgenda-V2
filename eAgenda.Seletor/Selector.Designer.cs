using eAgenda.Componentes;

namespace eAgenda.Seletor
{
    partial class Selector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selector));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EAgendaLogo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTarefas = new eAgenda.Componentes.CustomButton();
            this.BtnSocial = new eAgenda.Componentes.CustomButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EAgendaLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecionar Módulo";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label3.Location = new System.Drawing.Point(287, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Olá! Seja bem vindo ao";
            // 
            // EAgendaLogo
            // 
            this.EAgendaLogo.Image = ((System.Drawing.Image)(resources.GetObject("EAgendaLogo.Image")));
            this.EAgendaLogo.Location = new System.Drawing.Point(299, 158);
            this.EAgendaLogo.Name = "EAgendaLogo";
            this.EAgendaLogo.Size = new System.Drawing.Size(159, 115);
            this.EAgendaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EAgendaLogo.TabIndex = 6;
            this.EAgendaLogo.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label4.Location = new System.Drawing.Point(134, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(492, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Para continuar, selecione abaixo o módulo que deseja acessar:";
            // 
            // BtnTarefas
            // 
            this.BtnTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnTarefas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnTarefas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnTarefas.BorderRadius = 5;
            this.BtnTarefas.BorderSize = 1;
            this.BtnTarefas.FlatAppearance.BorderSize = 0;
            this.BtnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarefas.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnTarefas.ForeColor = System.Drawing.Color.White;
            this.BtnTarefas.Location = new System.Drawing.Point(39, 413);
            this.BtnTarefas.Name = "BtnTarefas";
            this.BtnTarefas.Size = new System.Drawing.Size(302, 94);
            this.BtnTarefas.TabIndex = 17;
            this.BtnTarefas.Text = "Tarefas";
            this.BtnTarefas.TextColor = System.Drawing.Color.White;
            this.BtnTarefas.UseVisualStyleBackColor = false;
            this.BtnTarefas.Click += new System.EventHandler(this.BtnTarefas_Click);
            this.BtnTarefas.MouseLeave += new System.EventHandler(this.BtnTarefas_MouseLeave);
            this.BtnTarefas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnTarefas_MouseMove);
            // 
            // BtnSocial
            // 
            this.BtnSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnSocial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.BtnSocial.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.BtnSocial.BorderRadius = 5;
            this.BtnSocial.BorderSize = 1;
            this.BtnSocial.FlatAppearance.BorderSize = 0;
            this.BtnSocial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSocial.Font = new System.Drawing.Font("Poppins Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnSocial.ForeColor = System.Drawing.Color.White;
            this.BtnSocial.Location = new System.Drawing.Point(416, 413);
            this.BtnSocial.Name = "BtnSocial";
            this.BtnSocial.Size = new System.Drawing.Size(302, 94);
            this.BtnSocial.TabIndex = 18;
            this.BtnSocial.Text = "Social";
            this.BtnSocial.TextColor = System.Drawing.Color.White;
            this.BtnSocial.UseVisualStyleBackColor = false;
            this.BtnSocial.Click += new System.EventHandler(this.BtnSocial_Click);
            this.BtnSocial.MouseLeave += new System.EventHandler(this.BtnSocial_MouseLeave);
            this.BtnSocial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnSocial_MouseMove);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label5.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label5.Location = new System.Drawing.Point(137, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "Módulo 01";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.label6.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(510, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 21;
            this.label6.Text = "Módulo 02";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 76);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 594);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 37);
            this.panel2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            this.label2.Location = new System.Drawing.Point(195, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed by Alan, to Academia do Programador @ 2022";
            // 
            // Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(757, 631);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnSocial);
            this.Controls.Add(this.BtnTarefas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EAgendaLogo);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Selector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.EAgendaLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox EAgendaLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private CustomButton BtnTarefas;
        private CustomButton BtnSocial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}