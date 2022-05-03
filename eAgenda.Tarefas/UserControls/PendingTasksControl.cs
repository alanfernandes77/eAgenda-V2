using eAgenda.Dominio;
using eAgenda.Infra.Json;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.Forms;
using System.Windows.Forms;

namespace eAgenda.Tarefas.UserControls
{
    public partial class PendingTasksControl : UserControl
    {
        private readonly JsonSerialization<Task> _jsonSerialization;
        private readonly TaskRepository _taskRepository;

        public PendingTasksControl(JsonSerialization<Task> jsonSerialization, TaskRepository taskRepository)
        {
            _jsonSerialization = jsonSerialization;
            _taskRepository = taskRepository;

            InitializeComponent();

            UpdatePendingGrid();
        }

        public void UpdatePendingGrid()
        {
            if (_taskRepository.GetAll() != null)
            {
                _jsonSerialization.Save(_taskRepository.GetAll());
                DgvPendingTasks.Rows.Clear();

                _taskRepository.GetPendingTasks().ForEach(x => DgvPendingTasks.Rows.Add(
                    x.Number,
                    x.Title,
                    x.TaskPriority,
                    x.CreationDate.ToString("dd/MM/yyyy"),
                    x.GetCompletedProcentage() + "%",
                    x.GetStatus()));
            }
            DgvPendingTasks.ClearSelection();
        }

        public void PendingTasksControl_Load(object sender, System.EventArgs e)
        {
            UpdatePendingGrid();
        }

        private void BtnViewTask_Click(object sender, System.EventArgs e)
        {
            if (DgvPendingTasks.CurrentCell != null && DgvPendingTasks.CurrentCell.Selected == true)
            {
                ViewPendingTask viewPendingTask = new(_taskRepository, this);

                viewPendingTask.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista para visualizar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnViewTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnViewTask_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnEditTask_Click(object sender, System.EventArgs e)
        {
            if (DgvPendingTasks.CurrentCell != null && DgvPendingTasks.CurrentCell.Selected == true)
            {
                EditTask editTask = new(_taskRepository, this);

                editTask.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnEditTask_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDeleteTask_Click(object sender, System.EventArgs e)
        {
            if (DgvPendingTasks.CurrentCell != null && DgvPendingTasks.CurrentCell.Selected == true)
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir este registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    _taskRepository.GetAll().RemoveAt(DgvPendingTasks.CurrentCell.RowIndex);
                    UpdatePendingGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro da lista para deletar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDeleteTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDeleteTask_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
