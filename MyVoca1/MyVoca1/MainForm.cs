namespace MyVoca1
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> wordList; // �ܾ� ���� �����ϴ� Dictionary
        private ShowForm showForm; // ShowForm Ŭ������ �ν��Ͻ�
        public MainForm()
        {
            InitializeComponent();
            wordList = new Dictionary<string, string>(); // wordList ��ųʸ� �ʱ�ȭ
            showForm = new ShowForm(wordList); // wordList ��ųʸ��� �����Ͽ� ShowForm Ŭ������ �ν��Ͻ� ����
        }

        private void AddButton_Click(object sender, EventArgs e) // wordList ��ųʸ��� showForm �ν��Ͻ��� �����Ͽ� AddForm Ŭ������ �ν��Ͻ� ����
        {
            AddForm addform = new AddForm(wordList, showForm); //AddForm �����ڸ� ȣ��� wordList�� null�� �ʱ�ȭ���� �ʵ��� AddForm �����ڿ� �Ű������� wordList ���� 
            addform.Show();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm(wordList); // wordList ��ųʸ��� �����Ͽ� ShowForm Ŭ������ �ν��Ͻ� ����
            showForm.Show();
        }

        private void VocaTestButton_Click(object sender, EventArgs e)
        {
            TestSelectForm testSelectForm = new TestSelectForm(wordList); // wordList ��ųʸ��� �����Ͽ� TestSelectForm Ŭ������ �ν��Ͻ� ����
            testSelectForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("My Voca�� �����Ͻðڽ��ϱ�?", "My Voca ����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // ����ڰ� "��"�� �����ϸ� ���ø����̼��� ����.
            }

            else if (result == DialogResult.No)
            {
                // ����ڰ� "�ƴϿ�"�� ������ ��� �ƹ� �۾��� �������� ����.
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}