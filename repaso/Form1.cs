namespace repaso
{
    public partial class Form1 : Form
    {
        private List<Task> tasks = new List<Task>();

        public class Task
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public string Priority { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            loadPriorityTasks();
            table_tasks.AutoGenerateColumns = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadPriorityTasks()
        {
            cmb_priority.Items.Add("Select priority");
            cmb_priority.Items.Add("High");
            cmb_priority.Items.Add("Medium");
            cmb_priority.Items.Add("Low");

            cmb_priority.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validateFields();

        }

        private void validateFields()
        {
            try
            {
                string title = txt_title.Text;
                string opt = cmb_priority.Text;
                string description = txt_description.Text;

                if (string.IsNullOrEmpty(title) || cmb_priority.SelectedItem == null || string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("You have to complete all fields.", "Error");
                    return;
                }
                else if (cmb_priority.SelectedIndex == 0)
                {
                    MessageBox.Show("You have to select a option of priority of task.", "Error");
                    return;
                }

                registerTask(title, opt, description);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void registerTask(string title, string opt, string description)
        {
            Task newTask = new Task
            {
                Title = title,
                Description = description,
                Priority = opt
            };

            tasks.Add(newTask);

            clearForm();

            MessageBox.Show("Task registered successfully.", "Success");
        }

        private void clearForm()
        {
            txt_title.Text = "";
            txt_description.Text = "";
            cmb_priority.SelectedIndex = 0;
        }

        private void RefreshDataGridView()
        {
            table_tasks.DataSource = null;
            table_tasks.DataSource = tasks;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}