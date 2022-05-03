using eAgenda.Dominio;
using eAgenda.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.Tarefas.Forms
{
    public partial class AddItems : Form
    {
        private readonly TaskRepository _taskRepository;
        private readonly Task _task;

        public AddItems(TaskRepository taskRepository, Task task)
        {
            InitializeComponent();

            _taskRepository = taskRepository;

            _task = task;

            LblTaskNumber.Text = task.Number.ToString();
            LblTaskTitle.Text = task.Title;
            _task.Items.ForEach(x => LbxTaskItensToAdd.Items.Add(x));
        }

        public List<Item> AddedItems
        {
            get
            {
                return LbxTaskItensToAdd.Items.Cast<Item>().ToList();
            }
        }

        private void BtnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                LbxTaskItensToAdd.Items.Add(new Item(TxbItemDescription.Text));
                TxbItemDescription.Clear();
                TxbItemDescription.Focus();
            }
        }

        private void BtnAddItem_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnAddItem_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        private void BtnConclude_Click(object sender, EventArgs e)
        {
            if (AddedItems.Count == 0)
            {
                MessageBox.Show("É necessário ter adicionado ao menos 1 item para concluir essa ação.", "Adicionando Itens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _taskRepository.AddItens(_task, AddedItems);
                MessageBox.Show("Itens adicionados com sucesso!", "Adicionando Itens", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void BtnConclude_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnConclude_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TxbItemDescription.Text))
            {
                MessageBox.Show("Insira a descrição do item para poder adiciona-lo.", "Adicionando Itens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            List<string> titles = AddedItems.Select(x => x.Description).ToList();

            if (titles.Any(x => x.Contains(TxbItemDescription.Text, StringComparison.CurrentCultureIgnoreCase)))
            {
                MessageBox.Show("Uma item com esse título já existe.", "Adicionando Itens", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxbItemDescription.Focus();
                return false;
            }

            return true;
        }

    }
}
