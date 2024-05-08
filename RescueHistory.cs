namespace CRAM2
{
    public partial class RescueHistory : Form
    {
        public RescueHistory()
        {
            InitializeComponent();
            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            List<RescueDTO> rescues = rescueDAO.GetAllRescues();
            DataGridContent(rescues);
        }

        private void DataGridContent(List<RescueDTO> rescues)
        {
            dataGridView1.DataSource = rescues;
        }
        private void DataGridContent(RescueDTO rescue)
        {
            dataGridView1.DataSource = new List<RescueDTO> { rescue };
        }
        private void Search_Click(object sender, EventArgs e)
        {
            RescueDAO rescueDAO = new RescueDAO(NpgsqlUtils.OpenConnection());
            RescueDTO rescue = rescueDAO.SelectById(IdInput.Text);
            if (rescue.RescueId != "RES-")
                DataGridContent(rescue);
            else
                dataGridView1.DataSource = null;
        }
        private void Return_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
