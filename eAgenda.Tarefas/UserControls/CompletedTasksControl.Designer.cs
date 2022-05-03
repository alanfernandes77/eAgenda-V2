namespace eAgenda.Tarefas.UserControls
{
    partial class CompletedTasksControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletedTasksControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDeleteCompletedTask = new eAgenda.Componentes.CustomButton();
            this.BtnViewCompletedTask = new eAgenda.Componentes.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvCompletedTasks = new System.Windows.Forms.DataGridView();
            this.ClnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnCompletedPorcentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnConclusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompletedTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1225, 100);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.BtnDeleteCompletedTask);
            this.panel2.Controls.Add(this.BtnViewCompletedTask);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 94);
            this.panel2.TabIndex = 9;
            // 
            // BtnDeleteCompletedTask
            // 
            this.BtnDeleteCompletedTask.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteCompletedTask.BackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnDeleteCompletedTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDeleteCompletedTask.BorderRadius = 5;
            this.BtnDeleteCompletedTask.BorderSize = 0;
            this.BtnDeleteCompletedTask.FlatAppearance.BorderSize = 0;
            this.BtnDeleteCompletedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCompletedTask.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCompletedTask.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeleteCompletedTask.Image")));
            this.BtnDeleteCompletedTask.Location = new System.Drawing.Point(1138, 15);
            this.BtnDeleteCompletedTask.Name = "BtnDeleteCompletedTask";
            this.BtnDeleteCompletedTask.Size = new System.Drawing.Size(69, 60);
            this.BtnDeleteCompletedTask.TabIndex = 11;
            this.BtnDeleteCompletedTask.TextColor = System.Drawing.Color.White;
            this.BtnDeleteCompletedTask.UseVisualStyleBackColor = false;
            this.BtnDeleteCompletedTask.Click += new System.EventHandler(this.BtnDeleteCompletedTask_Click);
            this.BtnDeleteCompletedTask.MouseLeave += new System.EventHandler(this.BtnDeleteCompletedTask_MouseLeave);
            this.BtnDeleteCompletedTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnDeleteCompletedTask_MouseMove);
            // 
            // BtnViewCompletedTask
            // 
            this.BtnViewCompletedTask.BackColor = System.Drawing.Color.Gold;
            this.BtnViewCompletedTask.BackgroundColor = System.Drawing.Color.Gold;
            this.BtnViewCompletedTask.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnViewCompletedTask.BorderRadius = 5;
            this.BtnViewCompletedTask.BorderSize = 0;
            this.BtnViewCompletedTask.FlatAppearance.BorderSize = 0;
            this.BtnViewCompletedTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewCompletedTask.ForeColor = System.Drawing.Color.White;
            this.BtnViewCompletedTask.Image = ((System.Drawing.Image)(resources.GetObject("BtnViewCompletedTask.Image")));
            this.BtnViewCompletedTask.Location = new System.Drawing.Point(1063, 15);
            this.BtnViewCompletedTask.Name = "BtnViewCompletedTask";
            this.BtnViewCompletedTask.Size = new System.Drawing.Size(69, 62);
            this.BtnViewCompletedTask.TabIndex = 10;
            this.BtnViewCompletedTask.TextColor = System.Drawing.Color.White;
            this.BtnViewCompletedTask.UseVisualStyleBackColor = false;
            this.BtnViewCompletedTask.Click += new System.EventHandler(this.BtnViewCompletedTask_Click);
            this.BtnViewCompletedTask.MouseLeave += new System.EventHandler(this.BtnViewCompletedTask_MouseLeave);
            this.BtnViewCompletedTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnViewCompletedTask_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gerenciando Tarefas Concluídas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.DgvCompletedTasks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 575);
            this.panel1.TabIndex = 6;
            // 
            // DgvCompletedTasks
            // 
            this.DgvCompletedTasks.AllowUserToAddRows = false;
            this.DgvCompletedTasks.AllowUserToDeleteRows = false;
            this.DgvCompletedTasks.AllowUserToResizeColumns = false;
            this.DgvCompletedTasks.AllowUserToResizeRows = false;
            this.DgvCompletedTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCompletedTasks.BackgroundColor = System.Drawing.Color.White;
            this.DgvCompletedTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvCompletedTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvCompletedTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCompletedTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCompletedTasks.ColumnHeadersHeight = 45;
            this.DgvCompletedTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCompletedTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnNumber,
            this.ClnTitle,
            this.ClnPriority,
            this.ClnCreationDate,
            this.ClnCompletedPorcentage,
            this.ClnStatus,
            this.ClnConclusionDate});
            this.DgvCompletedTasks.EnableHeadersVisualStyles = false;
            this.DgvCompletedTasks.GridColor = System.Drawing.Color.White;
            this.DgvCompletedTasks.Location = new System.Drawing.Point(3, 3);
            this.DgvCompletedTasks.MultiSelect = false;
            this.DgvCompletedTasks.Name = "DgvCompletedTasks";
            this.DgvCompletedTasks.ReadOnly = true;
            this.DgvCompletedTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCompletedTasks.RowHeadersVisible = false;
            this.DgvCompletedTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(139)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(218)))), ((int)(((byte)(219)))));
            this.DgvCompletedTasks.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCompletedTasks.RowTemplate.Height = 35;
            this.DgvCompletedTasks.RowTemplate.ReadOnly = true;
            this.DgvCompletedTasks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCompletedTasks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvCompletedTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCompletedTasks.Size = new System.Drawing.Size(1219, 569);
            this.DgvCompletedTasks.TabIndex = 3;
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
            // ClnConclusionDate
            // 
            this.ClnConclusionDate.DataPropertyName = "ConclusionDate";
            this.ClnConclusionDate.HeaderText = "Data de Conclusão";
            this.ClnConclusionDate.Name = "ClnConclusionDate";
            this.ClnConclusionDate.ReadOnly = true;
            this.ClnConclusionDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClnConclusionDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CompletedTasksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "CompletedTasksControl";
            this.Size = new System.Drawing.Size(1225, 730);
            this.Load += new System.EventHandler(this.CompletedTasksControl_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompletedTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView DgvCompletedTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnCompletedPorcentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnConclusionDate;
        private Componentes.CustomButton BtnViewCompletedTask;
        private Componentes.CustomButton BtnDeleteCompletedTask;
    }
}
