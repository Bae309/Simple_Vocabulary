namespace MyVoca1
{
    public partial class MainForm : Form
    {
        private Dictionary<string, string> wordList; // 단어 쌍을 저장하는 Dictionary
        private ShowForm showForm; // ShowForm 클래스의 인스턴스
        public MainForm()
        {
            InitializeComponent();
            wordList = new Dictionary<string, string>(); // wordList 딕셔너리 초기화
            showForm = new ShowForm(wordList); // wordList 딕셔너리를 전달하여 ShowForm 클래스의 인스턴스 생성
        }

        private void AddButton_Click(object sender, EventArgs e) // wordList 딕셔너리와 showForm 인스턴스를 전달하여 AddForm 클래스의 인스턴스 생성
        {
            AddForm addform = new AddForm(wordList, showForm); //AddForm 생성자를 호출시 wordList가 null로 초기화되지 않도록 AddForm 생성자에 매개변수로 wordList 전달 
            addform.Show();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            ShowForm showForm = new ShowForm(wordList); // wordList 딕셔너리를 전달하여 ShowForm 클래스의 인스턴스 생성
            showForm.Show();
        }

        private void VocaTestButton_Click(object sender, EventArgs e)
        {
            TestSelectForm testSelectForm = new TestSelectForm(wordList); // wordList 딕셔너리를 전달하여 TestSelectForm 클래스의 인스턴스 생성
            testSelectForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("My Voca를 종료하시겠습니까?", "My Voca 종료", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // 사용자가 "예"를 선택하면 애플리케이션을 종료.
            }

            else if (result == DialogResult.No)
            {
                // 사용자가 "아니오"를 선택한 경우 아무 작업도 수행하지 않음.
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}