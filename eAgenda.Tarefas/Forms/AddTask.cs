using eAgenda.Dominio;
using eAgenda.Dominio.Enums;
using eAgenda.Infra.Repositories;
using eAgenda.Tarefas.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.Tarefas.Forms
{
    public partial class AddTask : Form
    {
        private readonly TaskRepository _taskRepository;
        private readonly PendingTasksControl _pendingTasksControl;

        public AddTask(TaskRepository taskRepository, PendingTasksControl pendingTasksControl)
        {
            _taskRepository = taskRepository;
            _pendingTasksControl = pendingTasksControl;
            InitializeComponent();
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (CbxPrioridadeBaixa.Checked == false && CbxPrioridadeNormal.Checked == false && CbxPrioridadeAlta.Checked == false)
                {
                    _taskRepository.AddTask(new Task(TxbTaskTitle.Text, TaskPriority.Baixa));
                }

                if (CbxPrioridadeBaixa.Checked == true)
                {
                    _taskRepository.AddTask(new Task(TxbTaskTitle.Text, TaskPriority.Baixa));
                }

                if (CbxPrioridadeNormal.Checked == true)
                {
                    _taskRepository.AddTask(new Task(TxbTaskTitle.Text, TaskPriority.Normal));
                }

                if (CbxPrioridadeAlta.Checked == true)
                {
                    _taskRepository.AddTask(new Task(TxbTaskTitle.Text, TaskPriority.Alta));
                }

                _pendingTasksControl.UpdatePendingGrid();

                MessageBox.Show("Tarefa adicionada com sucesso!", "Adicionando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (ChbContinueAdding.Checked == true)
                {
                    TxbTaskTitle.Clear();
                    CbxPrioridadeBaixa.Checked = false;
                    CbxPrioridadeNormal.Checked = false;
                    CbxPrioridadeAlta.Checked = false;
                    TxbTaskTitle.Focus();
                }
                else
                {
                    Close();
                }
            }
        }

        private void BtnAddTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnAddTask_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void CbxPrioridadeBaixa_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPrioridadeNormal.Checked == true || CbxPrioridadeAlta.Checked == true)
                CbxPrioridadeBaixa.Checked = false;
        }

        private void CbxPrioridadeNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPrioridadeBaixa.Checked == true || CbxPrioridadeAlta.Checked == true)
                CbxPrioridadeNormal.Checked = false;
        }

        private void CbxPrioridadeAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (CbxPrioridadeBaixa.Checked == true || CbxPrioridadeNormal.Checked == true)
                CbxPrioridadeAlta.Checked = false;
        }

        private void ChbContinueAdding_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void ChbContinueAdding_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TxbTaskTitle.Text))
            {
                MessageBox.Show("O campo 'Título' é obrigatório.'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbTaskTitle.Focus();
                return false;
            }

            List<string> titles = _taskRepository.GetPendingTasks().Select(x => x.Title).ToList();

            if (titles.Any(x => x.Contains(TxbTaskTitle.Text, StringComparison.CurrentCultureIgnoreCase)))
            {
                MessageBox.Show("Uma tarefa com esse título já existe.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbTaskTitle.Focus();
                return false;
            }

            return true;
        }
    }
}