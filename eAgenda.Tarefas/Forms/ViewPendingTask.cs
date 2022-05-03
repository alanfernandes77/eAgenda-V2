using eAgenda.Dominio;
using eAgenda.Dominio.Enums;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.UserControls;
using System.Windows.Forms;
using System;

namespace eAgenda.Tarefas.Forms
{
    public partial class ViewPendingTask : Form
    {
        private readonly TaskRepository _taskRepository;
        private readonly PendingTasksControl _pendingTasksControl;
        private readonly Task selectedTask;

        public ViewPendingTask(TaskRepository taskRepository, PendingTasksControl pendingTasksControl)
        {
            _taskRepository = taskRepository;
            _pendingTasksControl = pendingTasksControl;
            InitializeComponent();

            selectedTask = _taskRepository.GetPendingTasks()[_pendingTasksControl.DgvPendingTasks.CurrentCell.RowIndex];

            LoadElements();
        }

        private void LoadElements()
        {
            LblTaskNumber.Text = selectedTask.Number.ToString();
            LblTaskTitle.Text = selectedTask.Title;
            LblCreationDate.Text = selectedTask.CreationDate.ToString("dd/MM/yyyy");
            LblTaskCompletedPercentage.Text = selectedTask.GetCompletedProcentage() + " %";
            LblTaskItensRegistered.Text = selectedTask.Items.Count.ToString();
            LblTaskConclusionDate.Text = selectedTask.ConclusionDate.HasValue ? selectedTask.ConclusionDate.Value.ToString("dd/MM/yyyy") : "";

            int completed = 0;
            int pending = 0;

            selectedTask.Items.ForEach(item =>
            {
                ClbTaskItens.Items.Add(item);

                if (item.Status == ItemStatus.Completado)
                    ClbTaskItens.SetItemChecked(completed, true);

                if (item.Status == ItemStatus.Pendente)
                    ClbTaskItens.SetItemChecked(pending, false);

                completed++;
                pending++;
            });

        }

        private void BtnTaskAddItems_Click(object sender, EventArgs e)
        {
            AddItems addItems = new(_taskRepository, selectedTask);

            if (selectedTask.GetCompletedProcentage() == 100.0)
            {
                MessageBox.Show("Esta tarefa já foi concluída, sendo assim, assim não é possível adicionar mais itens a ela.", "Visualizando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = addItems.ShowDialog();

            if (result == DialogResult.OK)
            {
                LblTaskItensRegistered.Text = selectedTask.Items.Count.ToString();
                ClbTaskItens.Items.Clear();
                LoadElements();
            }
        }

        private void BtnTaskAddItems_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnTaskAddItems_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnUpdateItens_Click(object sender, EventArgs e)
        {
            if (selectedTask.Items.Count == 0)
            {
                MessageBox.Show("É necessário que a tarefa tenha algum item adicionado para que se posssa atualiza-lo.", "Visualizando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateItems updateItems = new(_taskRepository, _pendingTasksControl, selectedTask);

            updateItems.ShowDialog();

            ClbTaskItens.Items.Clear();
            LoadElements();

            Close();

        }

        private void BtnUpdateItens_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnUpdateItens_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void ViewPendingTask_Load(object sender, EventArgs e)
        {

        }
    }
}