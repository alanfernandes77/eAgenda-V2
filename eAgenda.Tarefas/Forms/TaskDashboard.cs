using eAgenda.Infra.Repositories;
using eAgenda.Infra.Json;
using eAgenda.Tarefas.UserControls;
using System.Windows.Forms;
using eAgenda.Dominio;
using System.Drawing;

namespace eAgenda.Tarefas.Forms
{
    public partial class TaskDashboard : Form
    {
        private readonly JsonSerialization<Task> jsonSerializator;
        private readonly TaskRepository taskRepository;

        private readonly HomeControl homeControl;
        private readonly PendingTasksControl pendingTasksControl;
        private readonly CompletedTasksControl completedTasksControl;

        public TaskDashboard()
        {

            jsonSerializator = new(@"C:\temp\tarefas");
            taskRepository = new(jsonSerializator);

            homeControl = new(taskRepository);
            completedTasksControl = new(jsonSerializator, taskRepository);
            pendingTasksControl = new(jsonSerializator, taskRepository);

            InitializeComponent();
        }

        private void TasksDashboard_Load(object sender, System.EventArgs e)
        {
            LoadUserControl(homeControl);

            panel1.Visible = false;
        }

        private void BtnInicio_Click(object sender, System.EventArgs e)
        {
            MovePanel(BtnInicio);
            homeControl.HomeControl_Load(sender, e);
            TasksDashboard_Load(sender, e);
        }

        private void BtnTarefas_Click(object sender, System.EventArgs e)
        {
            MovePanel(BtnTarefas);
            ShowSubMenu(panel1);
        }

        private void BtnInicio_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnInicio_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnTarefas_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnTarefas_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnConfigs_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnConfigs_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void BtnSubPending_Click(object sender, System.EventArgs e)
        {
            BtnSubCompleted.BackColor = Color.FromArgb(56, 72, 87);
            BtnSubPending.BackColor = Color.FromArgb(26, 188, 156);
            pendingTasksControl.PendingTasksControl_Load(sender, e);
            LoadUserControl(pendingTasksControl);
        }

        private void BtnSubPending_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnSubPending_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
            BtnSubPending.BackColor = Color.FromArgb(56, 72, 87);
        }

        private void BtnSubCompleted_Click(object sender, System.EventArgs e)
        {
            BtnSubPending.BackColor = Color.FromArgb(56, 72, 87);
            BtnSubCompleted.BackColor = Color.FromArgb(26, 188, 156);
            completedTasksControl.CompletedTasksControl_Load(sender, e);
            LoadUserControl(completedTasksControl);
        }

        private void BtnSubCompleted_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;

        }

        private void BtnSubCompleted_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor = Cursors.Default;
            BtnSubCompleted.BackColor = Color.FromArgb(56, 72, 87);
        }

        private void MovePanel(Control c)
        {
            PnlSelector.Height = c.Height;
            PnlSelector.Top = c.Top;
        }

        private void LoadUserControl(UserControl userControl)
        {
            if (PnlConteudo.Controls.Count > 0)
                PnlConteudo.Controls.RemoveAt(0);

            userControl.Dock = DockStyle.Fill;

            PnlConteudo.Controls.Add(userControl);
            PnlConteudo.Tag = userControl;

            userControl.Show();

            switch (userControl.Name)
            {
                case "HomeControl":
                    LblTitulo.Text = "Início";
                    break;

                case "PendingTasksControl":
                    LblTitulo.Text = "Tarefas -> Pendentes";
                    break;

                case "CompletedTasksControl":
                    LblTitulo.Text = "Tarefas -> Concluídas";
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

        private void BtnNewTask_Click(object sender, System.EventArgs e)
        {
            AddTask addtask = new(taskRepository, pendingTasksControl);
            addtask.ShowDialog();
        }

        private void BtnNewTask_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }
        private void BtnNewTask_MouseLeave(object sender, System.EventArgs e)
        {
            Cursor= Cursors.Default;
        }
    }
}