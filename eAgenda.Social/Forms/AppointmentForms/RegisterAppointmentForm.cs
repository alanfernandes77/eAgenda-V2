using eAgenda.Dominio.Entities;
using eAgenda.Infra.Repositories;
using eAgenda.Social.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.Social.Forms.AppointmentForms
{
    public partial class RegisterAppointmentForm : Form
    {
        private readonly ContactRepository _contactRepository;
        private readonly AppointmentRepository _appointmentRepository;

        private readonly FutureAppointmentsControl _appointmentsTableControl;

        public RegisterAppointmentForm(ContactRepository contactRepository, AppointmentRepository appointmentRepository, FutureAppointmentsControl appointmentsTableControl)
        {
            _contactRepository = contactRepository;
            _appointmentRepository = appointmentRepository;
            _appointmentsTableControl = appointmentsTableControl;

            InitializeComponent();

            _contactRepository.GetAvailableContacts().ForEach(x => ClbAvailableContacts.Items.Add(x));

            ClbAvailableContacts.Enabled = false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(TxbSubject.Text))
            {
                MessageBox.Show("Campo 'Assunto' é obrigatório.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(TxbLocal.Text))
            {
                MessageBox.Show("Campo 'Local' é obrigatório.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MtxbDate.Text.Length < MtxbDate.MaskedTextProvider.Length)
            {
                MessageBox.Show("Campo 'Data' é obrigatório.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DateTime date = Convert.ToDateTime(MtxbDate.Text);


            if (MtxbStartTime.Text.Length < MtxbStartTime.MaskedTextProvider.Length)
            {
                MessageBox.Show("Campo 'Início' é obrigatório.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (MtxbEndTime.Text.Length < MtxbEndTime.MaskedTextProvider.Length)
            {
                MessageBox.Show("Campo 'Fim' é obrigatório.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            DateTime startTime = Convert.ToDateTime(MtxbStartTime.Text);
            DateTime endTime = Convert.ToDateTime(MtxbEndTime.Text);


            if (startTime > endTime)
            {
                MessageBox.Show("O horário de início deve ser menor que o horário de término.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (ChbYes.Checked == true)
            {
                if (_contactRepository.GetAvailableContacts().Count == 0)
                {
                    MessageBox.Show("Não há contatos disponíveis para referenciar ao compromisso.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    if (ClbAvailableContacts.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Selecione ao menos um contato da lista para concluir o registro.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }

            foreach (Appointment appointment in _appointmentRepository.GetAll())
            {
                if (date == appointment.Date)  
                {
                    if (startTime >= appointment.StartTime && startTime <= appointment.EndTime || endTime <= appointment.EndTime && endTime >= appointment.StartTime) 
                    MessageBox.Show("Horário e data não disponíveis.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void ChbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbNo.Checked == true)
                ChbYes.Checked = false;

            if (ChbYes.Checked == false)
                ClbAvailableContacts.Enabled = false;

            if (ChbYes.Checked == true)
            {
                ClbAvailableContacts.Enabled = true;

                if (ClbAvailableContacts.Items.Count == 0)
                {
                    MessageBox.Show("Não há contatos disponíveis para referenciar ao compromisso.", "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ChbYes.Checked = false;
                }
            }
        }

        private void ChbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbYes.Checked == true)
                ChbNo.Checked = false;

            if (ChbNo.Checked == true)
                ClbAvailableContacts.Enabled = false;
            
            if (ChbNo.Checked == false && ChbYes.Checked == false)
            {
                ClbAvailableContacts.Enabled = false;
            }
        }

        private void BtnAddContact_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (ChbYes.Checked == true)
                    _appointmentRepository.RegisterAppointment(new(TxbSubject.Text, TxbLocal.Text, Convert.ToDateTime(MtxbDate.Text), Convert.ToDateTime(MtxbStartTime.Text), Convert.ToDateTime(MtxbEndTime.Text), ClbAvailableContacts.SelectedItems.Cast<Contact>().ToList()));
                else
                    _appointmentRepository.RegisterAppointment(new(TxbSubject.Text, TxbLocal.Text, Convert.ToDateTime(MtxbDate.Text), Convert.ToDateTime(MtxbStartTime.Text), Convert.ToDateTime(MtxbEndTime.Text)));

                _appointmentsTableControl.UpdateFutureAppointmentsGrid();

                MessageBox.Show("Compromisso registrado com sucesso!", "Registrando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }
    }
}