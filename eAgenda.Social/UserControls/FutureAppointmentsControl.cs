using eAgenda.Dominio.Entities;
using eAgenda.Infra.Json;
using eAgenda.Infra.Repositories;
using eAgenda.Social.Forms.AppointmentForms;
using System.Windows.Forms;

namespace eAgenda.Social.UserControls
{
    public partial class FutureAppointmentsControl : UserControl
    {
        private readonly JsonSerialization<Appointment> _jsonAppointmentSerialization;
        private readonly AppointmentRepository _appointmentRepository;

        public FutureAppointmentsControl(JsonSerialization<Appointment> jsonAppointmentSerialization, AppointmentRepository appointmentRepository)
        {
            _jsonAppointmentSerialization = jsonAppointmentSerialization;
            _appointmentRepository = appointmentRepository;

            InitializeComponent();

            UpdateFutureAppointmentsGrid();
        }

        public void UpdateFutureAppointmentsGrid()
        {
            if (_appointmentRepository.GetFutureAppointments() != null)
            {
                _jsonAppointmentSerialization.Save(_appointmentRepository.GetFutureAppointments());
                DgvFutureAppointments.Rows.Clear();

                _appointmentRepository.GetFutureAppointments().ForEach(x => DgvFutureAppointments.Rows.Add(
                    x.Subject,
                    x.Local,
                    x.Date.ToString("dd/MM/yyyy"),
                    x.StartTime.ToString("HH:mm"),
                    x.EndTime.ToString("HH:mmm")));
            }
            DgvFutureAppointments.ClearSelection();
        }

        private void FutureAppointmentsControl_Load(object sender, System.EventArgs e)
        {
            UpdateFutureAppointmentsGrid();
        }

        private void BtnViewAppointment_Click(object sender, System.EventArgs e)
        {
            if (DgvFutureAppointments.CurrentCell != null && DgvFutureAppointments.CurrentCell.Selected == true)
            {
                ViewAppointmentForm viewFutureAppointmentsForm = new(_appointmentRepository, this);
                viewFutureAppointmentsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um compromisso para poder visualizar.", "Visualizando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnViewAppointment_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnViewAppointment_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnEditAppointment_Click(object sender, System.EventArgs e)
        {
            if (DgvFutureAppointments.CurrentCell != null && DgvFutureAppointments.CurrentCell.Selected == true)
            {
                EditAppointmentForm editAppointmentForm = new();
                editAppointmentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um compromisso para poder editar.", "Editando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnEditAppointment_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnEditAppointment_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDeleteAppointment_Click(object sender, System.EventArgs e)
        {
            if (DgvFutureAppointments.CurrentCell != null && DgvFutureAppointments.CurrentCell.Selected == true)
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Deletando Compromisso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    _appointmentRepository.GetAll().RemoveAt(DgvFutureAppointments.CurrentCell.RowIndex);
                }
            }
            else
            {
                MessageBox.Show("Selecione um compromisso para poder deletar.", "Deletando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdateFutureAppointmentsGrid();
        }

        private void BtnDeleteAppointment_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDeleteAppointment_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}