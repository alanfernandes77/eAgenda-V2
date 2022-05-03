using eAgenda.Componentes;

namespace eAgenda.Tarefas.UserControls
{
    partial class PendingTasksControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PendingTasksControl));
            this.DgvPendingTasks = new System.Windows.Forms.DataGridView();
            this.ClnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCompletedPorcentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEditTask = new eAgenda.Componentes.CustomButton();
            this.BtnDeleteTask = new eAgenda.Componentes.CustomButton();
            this.BtnViewTask = new eAgenda.Componentes.CustomButton();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPendingTasks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvPendingTasks
            // 
            this.DgvPendingTasks.AllowUserToAddRows = false;
            this.DgvPendingTasks.AllowUserToDeleteRows = false;
            this.DgvPendingTasks.AllowUserToResizeColumns = false;
            this.DgvPendingTasks.AllowUserToResizeRows = false;
            this.DgvPendingTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPendingTasks.BackgroundColor = System.Drawing.Color.White;
            this.DgvPendingTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPendingTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvPendingTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPendingTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPendingTasks.ColumnHeadersHeight = 45;
            this.DgvPendingTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvPendingTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNumber,
            this.ClnTitle,
            this.ClnPriority,
            this.ClnCreationDate,
            this.ClnCompletedPorcentage,
            this.ClnStatus});
            this.DgvPendingTasks.EnableHeadersVisualStyles = false;
            this.DgvPendingTasks.GridColor = System.Drawing.Color.White;
            this.DgvPendingTasks.Location = new System.Drawing.Point(3, 3);
            this.DgvPendingTasks.MultiSelect = false;
            this.DgvPendingTasks.Name = "DgvPendingTasks";
            this.DgvPendingTasks.ReadOnly = true;
            this.DgvPendingTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvPendingTasks.RowHeadersVisible = false;
            this.DgvPendingTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.DgvPendingTasks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPendingTasks.RowTemplate.Height = 35;
            this.DgvPendingTasks.RowTemplate.ReadOnly = true;
            this.DgvPendingTasks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPendingTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvPendingTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPendingTasks.Size = new System.Drawing.Size(1219, 569);
            this.DgvPendingTasks.TabIndex = 3;
            // 
            // ClnNumber
            // 
            this.ClnNumber.DataPropertyName = "Number";
            this.ClnNumber.HeaderText = "Número";
            this.ClnNumber.Name = "ClnNumber";
            this.ClnNumber.ReadOnly = true;
            this.ClnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnTitle
            // 
            this.ClnTitle.DataPropertyName = "Title";
            this.ClnTitle.HeaderText = "Título";
            this.ClnTitle.Name = "ClnTitle";
            this.ClnTitle.ReadOnly = true;
            this.ClnTitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnPriority
            // 
            this.ClnPriority.DataPropertyName = "TaskPriority";
            this.ClnPriority.HeaderText = "Prioridade";
            this.ClnPriority.Name = "ClnPriority";
            this.ClnPriority.ReadOnly = true;
            this.ClnPriority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnPriority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnCreationDate
            // 
            this.ClnCreationDate.DataPropertyName = "CreationDate";
            this.ClnCreationDate.HeaderText = "Data de Criação";
            this.ClnCreationDate.Name = "ClnCreationDate";
            this.ClnCreationDate.ReadOnly = true;
            this.ClnCreationDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnCreationDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnCompletedPorcentage
            // 
            this.ClnCompletedPorcentage.DataPropertyName = "CompletedPercentage";
            this.ClnCompletedPorcentage.HeaderText = "% Concluída";
            this.ClnCompletedPorcentage.Name = "ClnCompletedPorcentage";
            this.ClnCompletedPorcentage.ReadOnly = true;
            this.ClnCompletedPorcentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnCompletedPorcentage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClnStatus
            // 
            this.ClnStatus.DataPropertyName = "Status";
            this.ClnStatus.HeaderText = "Status";
            this.ClnStatus.Name = "ClnStatus";
            this.ClnStatus.ReadOnly = true;
            this.ClnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.DgvPendingTasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 575);
            this.panel1.TabIndex = 4;
            // 
            // BtnEditTask
            // 
            this.BtnEditTask.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditTask.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.BtnEditTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditTask.BorderRadius = 5;
            this.BtnEditTask.BorderSize = 0;
            this.BtnEditTask.FlatAppearance.BorderSize = 0;
            this.BtnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditTask.ForeColor = System.Drawing.Color.White;
            this.BtnEditTask.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditTask.Image")));
            this.BtnEditTask.Location = new System.Drawing.Point(1063, 14);
            this.BtnEditTask.Name = "BtnEditTask";
            this.BtnEditTask.Size = new System.Drawing.Size(69, 61);
            this.BtnEditTask.TabIndex = 6;
            this.BtnEditTask.TextColor = System.Drawing.Color.White;
            this.BtnEditTask.UseVisualStyleBackColor = false;
            this.BtnEditTask.Click += new System.EventHandler(this.BtnEditTask_Click);
            this.BtnEditTask.MouseLeave += new System.EventHandler(this.BtnEditTask_MouseLeave);
            this.BtnEditTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnEditTask_MouseMove);
            // 
            // BtnDeleteTask
            // 
            this.BtnDeleteTask.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteTask.BackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDeleteTask.BorderRadius = 5;
            this.BtnDeleteTask.BorderSize = 0;
            this.BtnDeleteTask.FlatAppearance.BorderSize = 0;
            this.BtnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteTask.Image")));
            this.BtnDeleteTask.Location = new System.Drawing.Point(1138, 14);
            this.BtnDeleteTask.Name = "BtnDeleteTask";
            this.BtnDeleteTask.Size = new System.Drawing.Size(69, 61);
            this.BtnDeleteTask.TabIndex = 7;
            this.BtnDeleteTask.TextColor = System.Drawing.Color.White;
            this.BtnDeleteTask.UseVisualStyleBackColor = false;
            this.BtnDeleteTask.Click += new System.EventHandler(this.BtnDeleteTask_Click);
            this.BtnDeleteTask.MouseLeave += new System.EventHandler(this.BtnDeleteTask_MouseLeave);
            this.BtnDeleteTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnDeleteTask_MouseMove);
            // 
            // BtnViewTask
            // 
            this.BtnViewTask.BackColor = System.Drawing.Color.Gold;
            this.BtnViewTask.BackgroundColor = System.Drawing.Color.Gold;
            this.BtnViewTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnViewTask.BorderRadius = 5;
            this.BtnViewTask.BorderSize = 0;
            this.BtnViewTask.FlatAppearance.BorderSize = 0;
            this.BtnViewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewTask.ForeColor = System.Drawing.Color.White;
            this.BtnViewTask.Image = ((System.Drawing.Image)(resources.GetObject("BtnViewTask.Image")));
            this.BtnViewTask.Location = new System.Drawing.Point(988, 14);
            this.BtnViewTask.Name = "BtnViewTask";
            this.BtnViewTask.Size = new System.Drawing.Size(69, 62);
            this.BtnViewTask.TabIndex = 8;
            this.BtnViewTask.TextColor = System.Drawing.Color.White;
            this.BtnViewTask.UseVisualStyleBackColor = false;
            this.BtnViewTask.Click += new System.EventHandler(this.BtnViewTask_Click);
            this.BtnViewTask.MouseLeave += new System.EventHandler(this.BtnViewTask_MouseLeave);
            this.BtnViewTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnViewTask_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnDeleteTask);
            this.panel2.Controls.Add(this.BtnViewTask);
            this.panel2.Controls.Add(this.BtnEditTask);
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
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciando Tarefas Pendentes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 100);
            this.panel3.TabIndex = 5;
            // 
            // PendingTasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PendingTasksControl";
            this.Size = new System.Drawing.Size(1225, 730);
            this.Load += new System.EventHandler(this.PendingTasksControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPendingTasks)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private CustomButton BtnEditTask;
        private CustomButton BtnDeleteTask;
        private CustomButton BtnViewTask;
        public System.Windows.Forms.DataGridView DgvPendingTasks;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCompletedPorcentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStatus;
    }
}
