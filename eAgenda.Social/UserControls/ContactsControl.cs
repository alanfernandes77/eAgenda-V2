using eAgenda.Dominio.Entities;
using eAgenda.Infra.Json;
using eAgenda.Infra.Repositories;
using eAgenda.Social.Forms.ContactForms;
using eAgenda.Social.UserControls.ContactControls;
using System;
using System.Windows.Forms;

namespace eAgenda.Social.UserControls
{
    public partial class ContactsControl : UserControl
    {
        private readonly JsonSerialization<Contact> _jsonContactsSerialization;
        private readonly ContactRepository _contactRepository;

        public ContactsControl(JsonSerialization<Contact> jsonContactsSerialization, ContactRepository contactRepository)
        {
            _jsonContactsSerialization = jsonContactsSerialization;
            _contactRepository = contactRepository;

            InitializeComponent();

            UpdateContactsGrid();
        }

        public void UpdateContactsGrid()
        {
            if (_contactRepository.GetAll() != null)
            {
                _jsonContactsSerialization.Save(_contactRepository.GetAll());
                DgvContactsTable.Rows.Clear();

                _contactRepository.GetAll().ForEach(x => DgvContactsTable.Rows.Add(
                    x.Name,
                    x.Phone,
                    x.Email));
            }
            DgvContactsTable.ClearSelection();
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new(_contactRepository, this);

            addContactForm.ShowDialog();
        }

        private void BtnAddContact_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnAddContact_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnViewContact_Click(object sender, EventArgs e)
        {
           if (DgvContactsTable.CurrentCell != null && DgvContactsTable.CurrentCell.Selected == true)
            {
                Contact contact = _contactRepository.GetAll()[DgvContactsTable.CurrentCell.RowIndex];

                if (contact.IsBasicContact)
                {
                    ViewBasicContactForm viewBasicContactForm = new(_contactRepository, this);
                    viewBasicContactForm.ShowDialog();
                } 
                else
                {
                    ViewCompleteContactForm viewCompleteContactForm = new(_contactRepository, this);
                    viewCompleteContactForm.ShowDialog();
                }
            }
           else
            {
                MessageBox.Show("Selecione um contato para poder visualizar.", "Visualizando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnViewContact_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnViewContact_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnEditContact_Click(object sender, EventArgs e)
        {
            if (DgvContactsTable.CurrentCell != null && DgvContactsTable.CurrentCell.Selected == true)
            {
                EditContactForm editContactForm = new(_contactRepository, this);
                editContactForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um contato para poder editar.", "Editando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditContact_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnEditContact_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDeleteContact_Click(object sender, EventArgs e)
        {
            if (DgvContactsTable.CurrentCell != null && DgvContactsTable.CurrentCell.Selected == true)
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Deletando Contato", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                
                if (result == DialogResult.Yes)
                {
                    _contactRepository.GetAll().RemoveAt(DgvContactsTable.CurrentCell.RowIndex);
                }
            }
            else
            {
                MessageBox.Show("Selecione um contato para poder deletar.", "Deletando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateContactsGrid();
        }

        private void BtnDeleteContact_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDeleteContact_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void ContactsTableControl_Load(object sender, EventArgs e)
        {
            UpdateContactsGrid();
        }
    }
}
