using Dapper;
using GenericRepository.Dao;
using GenericRepository.Entity;
using System.Windows.Forms;

namespace GenericRepository
{
    public partial class Form1 : Form
    {
        private bool _isNew = false;
        readonly IGenericRepository<Student> _dao;

        public Form1()
        {
            InitializeComponent();

            _dao = new GenericRepository<Student>();
        }

        void Display()
        {
           
            dataGridView.DataSource = _dao.GetAll();
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
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            studentIDTextBox.Text = string.Empty;
            fullNameTextBox.Text = string.Empty;
            genderCheckBox.Checked = false;
            ageTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            _isNew = true;

            fullNameTextBox.Focus();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(studentIDTextBox.Text))
            {
                bool isDelete = _dao.Delete(Convert.ToInt32(studentIDTextBox.Text));
                if (isDelete)
                {
                    _isNew = false;
                    //ClearInput(); //dataGridView_SelectionChanged()에서 처리됨
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
            bool isComplete = false;
            if (_isNew)
            {
                isComplete = _dao.Insert(new Student() { FullName = fullNameTextBox.Text, Gender = genderCheckBox.Checked, Age = Convert.ToInt32(ageTextBox.Text), Address = addressTextBox.Text });
            }
            else
            {
                isComplete = _dao.Update(new Student() { StudentID = Convert.ToInt32(studentIDTextBox.Text), FullName = fullNameTextBox.Text, Gender = genderCheckBox.Checked, Age = Convert.ToInt32(ageTextBox.Text), Address = addressTextBox.Text });
            }

            if (isComplete)
            {
                _isNew = false;
                //ClearInput(); //dataGridView_SelectionChanged()에서 처리됨
                Display();
            }
            else
            {
                var state = _isNew ? "Added" : "Updated";
                MessageBox.Show($"Student not {state})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null)
            {
                int row = dataGridView.CurrentCell.RowIndex;

                studentIDTextBox.Text = dataGridView.Rows[row].Cells[0].Value.ToString();
                fullNameTextBox.Text = dataGridView.Rows[row].Cells[1].Value.ToString();
                genderCheckBox.Checked = Convert.ToBoolean(dataGridView.Rows[row].Cells[2].Value);
                ageTextBox.Text = dataGridView.Rows[row].Cells[3].Value.ToString();
                addressTextBox.Text = dataGridView.Rows[row].Cells[4].Value.ToString();
                _isNew = false;
            }
        }

        private void genderCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (genderCheckBox.CheckState == CheckState.Checked)
                genderCheckBox.Text = "Female";
            else if (genderCheckBox.CheckState == CheckState.Unchecked)
                genderCheckBox.Text = "Male";
            else
                genderCheckBox.Text = "???";
        }
    }
}