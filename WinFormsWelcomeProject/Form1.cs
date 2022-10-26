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
            //MessageBox.Show("������ ���! Hello World!");
            lblHello.Text = "����������� ���� " + txtName.Text;
            btnHello.Text = "������� ��� ���";
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
            f2Label.Text = "��������� ����";
            modalForm.ShowDialog();
        }

        private void btnNotModalForm_Click(object sender, EventArgs e)
        {
            ModalForm notmodalForm = new ModalForm(this);
            var f2Label = notmodalForm.Controls["label1"];
            f2Label.Text = "�� ��������� ����";
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