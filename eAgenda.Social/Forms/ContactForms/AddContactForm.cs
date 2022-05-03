using eAgenda.Dominio.Entities;
using eAgenda.Infra.Repositories;
using eAgenda.Social.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace eAgenda.Social.Forms.ContactForms
{
    public partial class AddContactForm : Form
    {

        private readonly ContactRepository _contactRepository;
        private readonly ContactsControl _contactsTableControl;

        public AddContactForm(ContactRepository contactRepository, ContactsControl contactsTableControl)
        {
            _contactRepository = contactRepository;
            _contactsTableControl = contactsTableControl;

            InitializeComponent();

            TxbCompany.Enabled = false;
            TxbJobPosition.Enabled = false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TxbName.Text))
            {
                MessageBox.Show("Campo 'Nome' é obrigatório.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MTxb.Text.Length < MTxb.MaskedTextProvider.Length)
            {
                MessageBox.Show("Campo 'Telefone' é obrigatório.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(TxbEmail.Text))
            {
                MessageBox.Show("Campo 'E-mail' é obrigatório.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MailAddress.TryCreate(TxbEmail.Text, out _) == false)
            {
                MessageBox.Show("Insira um e-mail válido.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ChbYes.Checked == true)
            {
                if (string.IsNullOrEmpty(TxbCompany.Text))
                {
                    MessageBox.Show("Campo 'Empresa' é obrigatório.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrEmpty(TxbJobPosition.Text))
                {
                    MessageBox.Show("Campo 'Cargos' é obrigatório.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            List<string> names = _contactRepository.GetAll().Select(x => x.Name).ToList();
            List<string> emails = _contactRepository.GetAll().Select(x => x.Email).ToList();
            List<string> phones = _contactRepository.GetAll().Select(x => x.Phone).ToList();

            foreach (string name in names)
            {
                if (TxbName.Text.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Um contato com o nome inserido já existe.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            foreach (string phone in phones)
            {
                if (MTxb.Text.Equals(phone))
                {
                    MessageBox.Show("Um contato com o telefone inserido já existe.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            foreach (string email in emails)
            {
                if (TxbEmail.Text.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Um contato com o e-mail inserido já existe.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (ChbYes.Checked == false && ChbNo.Checked == false)
            {
                MessageBox.Show("É necessário informar se o contato possui ou não uma empresa relacionada.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (ChbNo.Checked == true)
                    _contactRepository.AddContact(new Contact(TxbName.Text, TxbEmail.Text, MTxb.Text));
                else
                    _contactRepository.AddContact(new Contact(TxbName.Text, TxbEmail.Text, MTxb.Text, TxbCompany.Text, TxbJobPosition.Text));

                _contactsTableControl.UpdateContactsGrid();

                MessageBox.Show("Contato adicionado com sucesso!", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void BtnAddContact_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnAddContact_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void ChbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbNo.Checked == true)
                ChbYes.Checked = false;

            if (ChbYes.Checked == true)
            {
                TxbCompany.Enabled = true;
                TxbJobPosition.Enabled = true;
            }
        }

        private void ChbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbYes.Checked == true)
                ChbNo.Checked = false;

            if (ChbNo.Checked == true)
            {
                TxbCompany.Enabled = false;
                TxbJobPosition.Enabled = false;
            }
        }
    }
}