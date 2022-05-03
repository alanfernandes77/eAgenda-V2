using eAgenda.Dominio;
using eAgenda.Infra.Json;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.Forms;
using System;
using System.Windows.Forms;

namespace eAgenda.Tarefas.UserControls
{
    public partial class CompletedTasksControl : UserControl
    {
        private readonly TaskRepository _taskRepository;
        private readonly JsonSerialization<Task> _jsonSerialization;

        public CompletedTasksControl(JsonSerialization<Task> jsonSerialization, TaskRepository taskRepository)
        {
            _jsonSerialization = jsonSerialization;
            _taskRepository = taskRepository;

            InitializeComponent();

            UpdateCompletedGrid();
        }

        public void UpdateCompletedGrid()
        {
            if (_taskRepository.GetCompletedTasks() != null)
            {
                _jsonSerialization.Save(_taskRepository.GetCompletedTasks());
                DgvCompletedTasks.Rows.Clear();

                _taskRepository.GetCompletedTasks().ForEach(x => DgvCompletedTasks.Rows.Add(
                    x.Number,
                    x.Title,
                    x.TaskPriority,
                    x.CreationDate.ToString("dd/MM/yyyy"),
                    x.GetCompletedProcentage() + "%",
                    x.GetStatus(),
                    x.ConclusionDate.HasValue ? x.ConclusionDate.Value.ToString("dd/MM/yyyy") : ""));
            }
            DgvCompletedTasks.ClearSelection();
        }

        public void CompletedTasksControl_Load(object sender, EventArgs e)
        { 
            UpdateCompletedGrid();
        }

        private void BtnViewCompletedTask_Click(object sender, EventArgs e)
        {
            ViewCompletedTask viewCompletedTask = new(_taskRepository, this);

            viewCompletedTask.ShowDialog();
        }

        private void BtnViewCompletedTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnViewCompletedTask_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDeleteCompletedTask_Click(object sender, EventArgs e)
        {
            if (DgvCompletedTasks.CurrentCell != null && DgvCompletedTasks.CurrentCell.Selected == true)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    _taskRepository.GetAll().RemoveAt(DgvCompletedTasks.CurrentCell.RowIndex);
                    UpdateCompletedGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteCompletedTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDeleteCompletedTask_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
