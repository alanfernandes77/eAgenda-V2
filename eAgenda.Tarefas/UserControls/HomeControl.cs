using eAgenda.Infra.Repositories;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.Tarefas.UserControls
{
    public partial class HomeControl : UserControl
    {
        private readonly TaskRepository _taskRepository;
        public HomeControl(TaskRepository taskRepository)
        {
            _taskRepository = taskRepository;

            InitializeComponent();
        }

        public void HomeControl_Load(object sender, System.EventArgs e)
        {
            LblRegisteredTaskAmount.Text = _taskRepository.GetAll().Count.ToString();
            LblCompletedTasksAmount.Text = _taskRepository.GetCompletedTasks().Count.ToString();
            LblPendingTasksAmount.Text = _taskRepository.GetPendingTasks().ToList().Count.ToString();
        }
    }
}
