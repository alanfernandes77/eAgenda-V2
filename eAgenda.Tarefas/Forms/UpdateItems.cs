using eAgenda.Dominio;
using eAgenda.Dominio.Enums;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.UserControls;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.Tarefas.Forms
{
    public partial class UpdateItems : Form
    {
        private readonly TaskRepository _taskRepository;
        private readonly PendingTasksControl _pendingTasksControl;
        private readonly Task _task;

        public UpdateItems(TaskRepository taskRepository, PendingTasksControl pendingTasksControl,  Task task)
        {
            InitializeComponent();

            _taskRepository = taskRepository;
            _pendingTasksControl = pendingTasksControl;
            _task = task;

            LblTaskNumber.Text = task.Number.ToString();
            LblTaskTitle.Text = task.Title;

            int i = 0;

            task.Items.ForEach(item =>
            {
                ClbTaskItens.Items.Add(item);

                if (item.Status == ItemStatus.Completado)
                    ClbTaskItens.SetItemChecked(i, true);

                i++;
            });
        }

        public List<Item> CompletedItems
        {
            get
            {
                return ClbTaskItens.CheckedItems
                      .Cast<Item>()
                      .ToList();
            }

        }

        public List<Item> PendingItems
        {
            get
            {
                return ClbTaskItens.Items
                    .Cast<Item>()
                    .Except(CompletedItems)
                    .ToList();
            }
        }

        private void BtnConclude_Click(object sender, System.EventArgs e)
        {
            if (ClbTaskItens.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um item para atualizar.", "Atualizando Itens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                _taskRepository.UpdateItens(_task, CompletedItems, PendingItems);

                MessageBox.Show("Itens atualizados com sucesso!", "Atualizando Itens", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _pendingTasksControl.UpdatePendingGrid();

                Close();
            }
        }
    }
}
