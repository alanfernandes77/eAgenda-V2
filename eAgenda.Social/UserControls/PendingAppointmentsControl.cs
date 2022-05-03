using eAgenda.Dominio.Entities;
using eAgenda.Infra.Json;
using eAgenda.Infra.Repositories;
using System;
using System.Windows.Forms;

namespace eAgenda.Social.UserControls
{
    public partial class PendingAppointmentsControl : UserControl
    {
        private readonly JsonSerialization<Appointment> _jsonAppointmentSerialization;
        private readonly AppointmentRepository _appointmentRepository;

        public PendingAppointmentsControl(JsonSerialization<Appointment> jsonAppointmentSerialization, AppointmentRepository appointmentRepository)
        {
            _jsonAppointmentSerialization = jsonAppointmentSerialization;
            _appointmentRepository = appointmentRepository;

            InitializeComponent();

            UpdatePendingAppointmentsGrid();
        }

        public void UpdatePendingAppointmentsGrid()
        {
            if (_appointmentRepository.GetAll() != null)
            {
                _jsonAppointmentSerialization.Save(_appointmentRepository.GetAll());
                DgvPendingAppointments.Rows.Clear();

                _appointmentRepository.GetPastAppointments().ForEach(x => DgvPendingAppointments.Rows.Add(
                    x.Subject,
                    x.Local,
                    x.Date.ToString("dd/MM/yyyy"),
                    x.StartTime.ToString("HH:mm"),
                    x.EndTime.ToString("HH:mmm")));
            }
            DgvPendingAppointments.ClearSelection();
        }

        private void PendingAppointmentsControl_Load(object sender, EventArgs e)
        {
            UpdatePendingAppointmentsGrid();
        }

        private void BtnViewAppointment_Click(object sender, EventArgs e)
        {
            if (DgvPendingAppointments.CurrentCell != null && DgvPendingAppointments.CurrentCell.Selected == true)
            {
         
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

        private void BtnViewAppointment_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (DgvPendingAppointments.CurrentCell != null && DgvPendingAppointments.CurrentCell.Selected == true)
            {
                DialogResult result = MessageBox.Show("Deseja realmente excluir este registro?", "Deletando Compromisso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    _appointmentRepository.GetAll().RemoveAt(DgvPendingAppointments.CurrentCell.RowIndex);
                }
            }
            else
            {
                MessageBox.Show("Selecione um compromisso para poder deletar.", "Deletando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            UpdatePendingAppointmentsGrid();
        }

        private void BtnDeleteAppointment_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnDeleteAppointment_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
