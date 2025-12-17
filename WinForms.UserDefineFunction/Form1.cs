namespace WinForms.UserDefineFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string firstname;
        string lastname;
        string username;
        string password;

        private void cheakfirstname()
        {
            firstname = textBox1.Text;
            if (string.IsNullOrEmpty(firstname))
            {
                MessageBox.Show("กำหนดให้ชื่อไม่เป็นที่ว่าง");
                textBox1.Focus();
                return;
            }
            if (firstname.Length < 2)
            {
                MessageBox.Show("ชื่อต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();
            }
        }

        private void cheaklastname()
        {
            lastname = textBox5.Text;
            if (string.IsNullOrEmpty(lastname))
            {
                MessageBox.Show("กำหนดให้นามสกุลไม่เป็นที่ว่าง");
                textBox2.Focus();
                return;
            }
            if (lastname.Length < 2)
            {
                MessageBox.Show("นามสกุลต้องมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox2.Focus();
            }
        }
        private void cheakusername()
        {
            username = textBox2.Text;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้ไม่เป็นที่ว่าง");
                textBox3.Focus();
                return;
            }
            if (username.Length > 20)
            {
                MessageBox.Show("ชื่อผู้ใช้ต้องไม่เกิน 20 ตัวอักษร");
                textBox3.Focus();
            }
        }

        private void cheakpassword()
        {
            password = textBox3.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("กำหนดให้รหัสผ่านไม่เป็นที่ว่าง");
                textBox4.Focus();
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("รหัสผ่านต้องมีความยาวอย่างน้อย 8 ตัวอักษร");
                textBox4.Focus();
            }
        }

        private void cheakconpassword()
        {
            string confirmpassword = textBox4.Text;
            if (password != confirmpassword)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน");
                textBox4.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cheakfirstname();
            cheaklastname();
            cheakusername();
            cheakpassword();
            cheakconpassword();
        }
    }
}
