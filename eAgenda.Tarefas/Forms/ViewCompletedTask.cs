using eAgenda.Dominio;
using eAgenda.Dominio.Enums;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.UserControls;
using System.Windows.Forms;
using System;

namespace eAgenda.Tarefas.Forms
{
    public partial class ViewCompletedTask : Form
    {
        private readonly TaskRepository _taskRepository;
        private readonly CompletedTasksControl _completedTasksControl;
        private readonly Task selectedTask;

        public ViewCompletedTask(TaskRepository taskRepository, CompletedTasksControl completedTaskControl)
        {
            _taskRepository = taskRepository;
            _completedTasksControl = completedTaskControl;
            InitializeComponent();

            selectedTask = _taskRepository.GetCompletedTasks()[_completedTasksControl.DgvCompletedTasks.CurrentCell.RowIndex];

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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBack_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

    }
}