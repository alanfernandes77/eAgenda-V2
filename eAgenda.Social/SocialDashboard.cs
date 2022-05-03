using eAgenda.Dominio.Entities;
using eAgenda.Infra.Json;
using eAgenda.Infra.Repositories;
using eAgenda.Social.Forms.AppointmentForms;
using eAgenda.Social.UserControls;
using System;
using System.Windows.Forms;

namespace eAgenda.Social
{
    public partial class SocialDashboard : Form
    {
        private readonly JsonSerialization<Contact> _jsonContactsSerialization;
        private readonly JsonSerialization<Appointment> _jsonAppointmentsSerialization;

        private readonly ContactRepository _contactRepository;
        private readonly AppointmentRepository _appointmentRepository;

        private readonly HomeControl _homeControl;
        private readonly ContactsControl _contactsTableControl;
        private readonly FutureAppointmentsControl _futureAppointmentsControl;
        private readonly PendingAppointmentsControl _pendingAppointmentsControl;

        public SocialDashboard()
        {
            _jsonContactsSerialization = new(@"C:\temp\contatos");
            _jsonAppointmentsSerialization = new(@"C:\temp\compromissos");

            _contactRepository = new(_jsonContactsSerialization);
            _appointmentRepository = new(_jsonAppointmentsSerialization);

            _homeControl = new HomeControl(_appointmentRepository, _contactRepository);
            _contactsTableControl = new(_jsonContactsSerialization, _contactRepository);
            _futureAppointmentsControl = new(_jsonAppointmentsSerialization, _appointmentRepository);
            _pendingAppointmentsControl = new(_jsonAppointmentsSerialization, _appointmentRepository);

            InitializeComponent();
        }

        private void MovePanel(Control c)
        {
            PnlSelector.Height = c.Height;
            PnlSelector.Top = c.Top;
        }

        private void LoadUserControl(UserControl userControl)
        {
            if (PnlContent.Controls.Count > 0)
                PnlContent.Controls.RemoveAt(0);

            userControl.Dock = DockStyle.Fill;

            PnlContent.Controls.Add(userControl);
            PnlContent.Tag = userControl;

            userControl.Show();

            switch (userControl.Name)
            {
                case "HomeControl":
                    LblTitle.Text = "Início";
                    break;

                case "ContactsTableControl":
                    LblTitle.Text = "Contatos";
                    break;

                case "AppointmentsTableControl":
                    LblTitle.Text = "Compromissos";
                    break;

            }
        }

        private void HideSubMenu()
        {
            if (panel1.Visible == true)
                panel1.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void SocialDashboard_Load(object sender, EventArgs e)
        {
            LoadUserControl(_homeControl);

            panel1.Visible = false;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            MovePanel(BtnHome);
            _homeControl.HomeControl_Load(sender, e);
            SocialDashboard_Load(sender, e);
        }

        private void BtnHome_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnHome_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnContacts_Click(object sender, EventArgs e)
        {
            MovePanel(BtnContacts);
            LoadUserControl(_contactsTableControl);
        }

        private void BtnContacts_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnContacts_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            MovePanel(BtnAppointments);
            ShowSubMenu(panel1);
        }

        private void BtnAppointments_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnAppointments_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnNewAppointment_Click(object sender, EventArgs e)
        {
            RegisterAppointmentForm registerAppointmentForm = new(_contactRepository, _appointmentRepository, _futureAppointmentsControl);
            registerAppointmentForm.ShowDialog();
        }

        private void BtnNewAppointment_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnNewAppointment_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnSubPending_Click(object sender, EventArgs e)
        {
            LoadUserControl(_pendingAppointmentsControl);
        }

        private void BtnSubPending_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnSubPending_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnSubCompleted_Click(object sender, EventArgs e)
        {
            LoadUserControl(_futureAppointmentsControl);
        }

        private void BtnSubCompleted_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;

        }

        private void BtnSubCompleted_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}