using eAgenda.Dominio.Entities;
using eAgenda.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Social.UserControls.ContactControls
{

    public partial class EditContactForm : Form
    {
        private readonly ContactRepository _contactRepository;
        private readonly ContactsControl _contactsTableControl;
        private readonly Contact _selectedContact;

        public EditContactForm(ContactRepository contactRepository, ContactsControl contactsTableControl)
        {
            _contactRepository = contactRepository;
            _contactsTableControl = contactsTableControl;

            InitializeComponent();

            _selectedContact = _contactRepository.GetAll()[_contactsTableControl.DgvContactsTable.CurrentCell.RowIndex];

            TxbName.Text = _selectedContact.Name;
            MTxbPhone.Text = _selectedContact.Phone;
            TxbEmail.Text = _selectedContact.Email;

            if (_selectedContact.IsBasicContact)
            {
                ChbNo.Checked = true;
            }
            else
            {
                ChbYes.Checked = true;
                TxbCompany.Text = _selectedContact.Company;
                TxbJobPosition.Text = _selectedContact.Job;
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TxbName.Text))
            {
                MessageBox.Show("Campo 'Nome' é obrigatório.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MTxbPhone.Text.Length < MTxbPhone.MaskedTextProvider.Length)
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

            if (ChbYes.Checked == false && ChbNo.Checked == false)
            {
                MessageBox.Show("É necessário informar se o contato possui ou não uma empresa relacionada.", "Adicionando Contato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnConclude_Click(object sender, EventArgs e)

        {
            if (ValidateForm())
            {

                _selectedContact.Name = TxbName.Text;
                _selectedContact.Phone = MTxbPhone.Text;
                _selectedContact.Email = TxbEmail.Text;

                if (ChbYes.Checked == true && _selectedContact.IsBasicContact == true)
                {
                    _selectedContact.IsBasicContact = false;
                    _selectedContact.Company = TxbCompany.Text;
                    _selectedContact.Job = TxbJobPosition.Text;
                } else
                {
                    if (ChbNo.Checked == true && _selectedContact.IsBasicContact == false)
                    {
                        _selectedContact.IsBasicContact = true;
                        _selectedContact.Company = null;
                        _selectedContact.Job = null;

                    }
                }

                _contactsTableControl.UpdateContactsGrid();

                MessageBox.Show("Contato editado com sucesso!", "Editando Contato", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void ChbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbNo.Checked == true)
                ChbYes.Checked = false;

            if (ChbYes.Checked == true)
            {
                TxbCompany.Enabled = true;
                TxbJobPosition.Enabled = true;
            }

            if (ChbYes.Checked == false && ChbNo.Checked == false)
            {
                TxbCompany.Enabled = false;
                TxbJobPosition.Enabled = false;
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

            if (ChbNo.Checked == false && ChbYes.Checked == false)
            {
                TxbCompany.Enabled = false;
                TxbJobPosition.Enabled = false;
            }
        }
    }
}