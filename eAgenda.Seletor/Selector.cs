using eAgenda.Social;
using eAgenda.Tarefas;
using eAgenda.Tarefas.Forms;
using System;
using System.Windows.Forms;

namespace eAgenda.Seletor
{
    public partial class Selector : Form
    {
        public Selector()
        {
            InitializeComponent();
        }

        private void BtnTarefas_Click(object sender, EventArgs e)
        {
            TaskDashboard tasksDashboard = new();

            tasksDashboard.ShowDialog();
        }

        private void BtnTarefas_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void BtnTarefas_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        private void BtnSocial_Click(object sender, EventArgs e)
        {
            SocialDashboard socialDashboard = new();

            socialDashboard.ShowDialog();
        }

        private void BtnSocial_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        private void BtnSocial_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }
    }
}
