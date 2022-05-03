using eAgenda.Dominio.Entities;
using eAgenda.Infra.Repositories;
using System;
using System.Windows.Forms;

namespace eAgenda.Social.UserControls.ContactControls
{
    public partial class ViewBasicContactForm : Form
    {
        private readonly ContactRepository _contactRepository;
        private readonly ContactsControl _contactsTableControl;
        private readonly Contact _selectedContact;

        public ViewBasicContactForm(ContactRepository contactRepository, ContactsControl contactsTableControl)
        {
            _contactRepository = contactRepository;
            _contactsTableControl = contactsTableControl;

            _selectedContact = _contactRepository.GetAll()[_contactsTableControl.DgvContactsTable.CurrentCell.RowIndex];

            InitializeComponent();

            LoadElements();
        }

        private void LoadElements()
        {
            LblContactID.Text = _selectedContact.Id.ToString();
            LblContactName.Text = _selectedContact.Name;
            LblContactPhone.Text = _selectedContact.Phone;
            LblContactEmail.Text = _selectedContact.Email;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _contactsTableControl.DgvContactsTable.ClearSelection();
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