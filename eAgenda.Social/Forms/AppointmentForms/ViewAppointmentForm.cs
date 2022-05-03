using eAgenda.Dominio.Entities;
using eAgenda.Infra.Repositories;
using eAgenda.Social.UserControls;
using System.Windows.Forms;

namespace eAgenda.Social.Forms.AppointmentForms
{
    public partial class ViewAppointmentForm : Form
    {
        private readonly AppointmentRepository _appointmentRepository;
        private readonly FutureAppointmentsControl _futureAppointmentsControl;
        private readonly Appointment _selectedAppointment;

        public ViewAppointmentForm(AppointmentRepository appointmentRepository, FutureAppointmentsControl futureAppointmentsControl)
        {
            _appointmentRepository = appointmentRepository;
            _futureAppointmentsControl = futureAppointmentsControl;

            _selectedAppointment = _appointmentRepository.GetFutureAppointments()[_futureAppointmentsControl.DgvFutureAppointments.CurrentCell.RowIndex];

            InitializeComponent();

            LoadElements();
        }

        private void LoadElements()
        {
            ChbAppointmentHasContacts.Enabled = false;
            checkBox1.Enabled = false;

            LblId.Text = _selectedAppointment.Id.ToString();
            LblSubject.Text = _selectedAppointment.Subject;
            LblLocal.Text = _selectedAppointment.Local;
            LblDate.Text = _selectedAppointment.Date.ToString("dd/MM/yyyy");
            LblStartTime.Text = _selectedAppointment.StartTime.ToString("HH:mm");
            LblEndTime.Text = _selectedAppointment.EndTime.ToString("HH:mm");

            if (_selectedAppointment.withContacts)
            {
                ChbAppointmentHasContacts.Checked = true;
                ChbAppointmentHasContacts.Enabled = false;
                _selectedAppointment.Contacts.ForEach(x => LbxRelatedContacts.Items.Add(x));
            }
            else
            {
                checkBox1.Checked = true;
            }
        }

        private void BtnBack_Click(object sender, System.EventArgs e)
        {
            _futureAppointmentsControl.DgvFutureAppointments.ClearSelection();
            Close();
        }

        private void BtnBack_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnBack_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}