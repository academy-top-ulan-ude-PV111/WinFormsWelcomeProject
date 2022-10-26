namespace WinFormsWelcomeProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblHello.Text = "";
            btnHello.Enabled = false;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Привет Мир! Hello World!");
            lblHello.Text = "Приветствую тебя " + txtName.Text;
            btnHello.Text = "Сказать еще раз";
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "")
                btnHello.Enabled = true;
        }

        private void btnModalForm_Click(object sender, EventArgs e)
        {
            ModalForm modalForm = new ModalForm();
            var f2Label = modalForm.Controls["label1"];
            f2Label.Text = "Модальное окно";
            modalForm.ShowDialog();
        }

        private void btnNotModalForm_Click(object sender, EventArgs e)
        {
            ModalForm notmodalForm = new ModalForm(this);
            var f2Label = notmodalForm.Controls["label1"];
            f2Label.Text = "Не модальное окно";
            notmodalForm.Show();
        }

        private void btnHello_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        private void btnHello_MouseLeave(object sender, EventArgs e)
        {
            btnHello.BackColor = SystemColors.Highlight;
        }
    }
}