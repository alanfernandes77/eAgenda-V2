using eAgenda.Infra.Repositories;
using System;
using System.Windows.Forms;

namespace eAgenda.Social.UserControls
{
    public partial class HomeControl : UserControl
    {
        private readonly AppointmentRepository _appointmentRepository;
        private readonly ContactRepository _contactRepository;

        public HomeControl(AppointmentRepository appointmentRepository, ContactRepository contactRepository)
        {
            _appointmentRepository = appointmentRepository;
            _contactRepository = contactRepository;

            InitializeComponent();
        }

        public void HomeControl_Load(object sender, EventArgs e)
        {
            LblRegisteredAppointments.Text = _appointmentRepository.GetAll().Count.ToString();
            LblRegisteredContacts.Text = _contactRepository.GetAll().Count.ToString();
        }
    }
}
