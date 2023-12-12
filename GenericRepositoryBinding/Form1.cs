using GenericRepository.Dao;
using GenericRepository.Entity;

namespace GenericRepository
{
    public partial class Form1 : Form
    {
        EntityState objState = EntityState.Unchanged;
        GenericRepository<Student> _dao;
        public Form1()
        {
            InitializeComponent();

            _dao = new GenericRepository<Student>();
        }

        void Display()
        {
            dataGridView.DataSource = _dao.GetAll();

            //한번에 모든 바인딩 지우기 => (https://learn.microsoft.com/ko-kr/dotnet/api/system.windows.forms.controlbindingscollection.clear?view=windowsdesktop-7.0)
            studentIDTextBox.DataBindings.Clear();
            fullNameTextBox.DataBindings.Clear();
            genderCheckBox.DataBindings.Clear();
            ageTextBox.DataBindings.Clear();
            addressTextBox.DataBindings.Clear();

            // 아래는 디자인에서 바인딩 한 것을 참조하였음
            studentIDTextBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "StudentID", true));
            fullNameTextBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "FullName", true));
            genderCheckBox.DataBindings.Add(new Binding("CheckState", dataGridView.DataSource, "Gender", true));
            ageTextBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Age", true));
            addressTextBox.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Address", true));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView 컬럼 중복 추가 방지
            // AutoGenerateColumns의 기본값이 true이다.
            // 그러므로, Form 디자이너에서 컬럼을 추가한 후
            // 1) DataSource 셋팅을 런타임에서 하면 기본값이 true이므로 자동으로 컬럼이 추가된다. => 이를 방지하기 위해서 false로 바꿔준다.
            // 2) DataSource 셋팅을 Form 디자이너에서 하면 AutoGenerateColumns = false;로 자동으로 되므로 필요없다.
            dataGridView.AutoGenerateColumns = false;
            Display();
            objState = EntityState.Unchanged;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            studentIDTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;
            genderCheckBox.Checked = false;
            ageTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            objState = EntityState.Added;

            fullNameTextBox.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studentIDTextBox.Text))
            {
                GenericRepository<Student> dao = new();
                bool isDelete = dao.Delete(Convert.ToInt32(studentIDTextBox.Text));
                if (isDelete)
                {
                    objState = EntityState.Unchanged;
                    //ClearInput();// DataBinding에서 처리하여 주석처리
                    Display();
                }
                else
                {
                    MessageBox.Show("Student not delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GenericRepository<Student> dao = new();
            bool isComplete;
            if (objState == EntityState.Added)
            {
                isComplete = dao.Insert(new Student() { FullName = fullNameTextBox.Text, Gender = genderCheckBox.Checked, Age = Convert.ToInt32(ageTextBox.Text), Address = addressTextBox.Text });
            }
            else
            {
                isComplete = dao.Update(new Student() { StudentID = Convert.ToInt32(studentIDTextBox.Text), FullName = fullNameTextBox.Text, Gender = genderCheckBox.Checked, Age = Convert.ToInt32(ageTextBox.Text), Address = addressTextBox.Text });
            }

            if (isComplete)
            {
                objState = EntityState.Unchanged;
                //ClearInput(); // DataBinding에서 처리하여 주석처리
                Display();
            }
            else
            {
                MessageBox.Show($"Student not {Enum.GetName(typeof(EntityState), objState)}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            objState = EntityState.Unchanged;
        }
    }
}