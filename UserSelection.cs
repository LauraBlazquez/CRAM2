namespace CRAM2
{
    public partial class UserSelection : Form
    {
        public UserSelection()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            const int TecExp = 45, VetExp = 80;
            if (Validation())
            {
                UserDTO user = new UserDTO(NameInput.Text, RolComboBox.Text, RolComboBox.Text == "Tècnic/a" ? TecExp : VetExp);
                MainMenu mainMenu = new MainMenu(user);
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
        }

        private bool Validation()
        {
            if (NameInput.Text == "")
            {
                MessageBox.Show("Introdueix un nom", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (RolComboBox.Text == "")
            {
                MessageBox.Show("Selecciona un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
