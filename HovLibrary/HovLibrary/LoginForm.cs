using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HovLibrary
{
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
           
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = GetSHA256(textBox2.Text);

            using (var context = new HovLibraryEntities()) // Ganti HovLibraryEntities dengan nama DbContext Anda
            {
                var employee = context.Employees.FirstOrDefault(emp => emp.email == email && emp.password == password);

                if (employee != null)
                {
                    // Login berhasil
                    MessageBox.Show("Login successful!");
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                    this.Hide(); 
                }
                else
                {
                    // Login gagal
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
        }

        private string GetSHA256(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }



        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "tbroderick9@twitpic.com";
            textBox2.Text = "admin10";
        }
    }
}
