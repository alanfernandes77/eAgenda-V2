using eAgenda.Dominio;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.Tarefas.Forms
{
    public partial class EditTask : Form
    {
        private readonly TaskRepository _taskRepository;
        private readonly PendingTasksControl _tasksControl;
        private readonly Task selectedTask;

        public EditTask(TaskRepository taskRepository, PendingTasksControl tasksControl)
        {
            _taskRepository = taskRepository;
            _tasksControl = tasksControl;
            InitializeComponent();

            selectedTask = _taskRepository.GetPendingTasks()[_tasksControl.DgvPendingTasks.CurrentCell.RowIndex];

            LblTaskNumber.Text = selectedTask.Number.ToString();
            LblTaskTitle.Text = selectedTask.Title;
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                selectedTask.Title = TxbTaskTitle.Text;

                LblTaskTitle.Text = selectedTask.Title;

                _tasksControl.UpdatePendingGrid();

                MessageBox.Show("Tarefa editada com sucesso!", "Editando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void BtnEditTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnEditTask_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TxbTaskTitle.Text))
            {
                MessageBox.Show("O campo 'Título' é obrigatório.'", "Editando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbTaskTitle.Focus();
                return false;
            }

            List<string> titles = _taskRepository.GetPendingTasks().Select(x => x.Title).ToList();

            if (titles.Any(x => x.Contains(TxbTaskTitle.Text, StringComparison.CurrentCultureIgnoreCase)))
            {
                MessageBox.Show("Uma tarefa com esse título já existe.", "Editando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbTaskTitle.Focus();
                return false;
            }

            return true;
        }
    }
}
