using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            primeTextLabel.Text = "Бажаємо\n непохитного...";
            loginTextBox.Text = "Enter your login:";
            passwordTextBox.Text = " and password:";
        }

        private void logInbutton_Click(object sender, EventArgs e)
        {
            string logName = loginTextBox.Text;
            string logPassword = passwordTextBox.Text;

            DataBase db_obj = new DataBase();
            db_obj.openConnection();

            DataTable db_table = new DataTable();
            MySqlDataAdapter db_adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `registered_list` WHERE `login` = @pif AND `password` = @puf", db_obj.getConnection());
            command.Parameters.AddWithValue("@pif", logName);
            command.Parameters.AddWithValue("@puf", logPassword);
            
            db_adapter.SelectCommand = command;
            db_adapter.Fill(db_table);

            if (db_table.Rows.Count > 0)
            {
                db_obj.closeConnection();
                MessageBox.Show("Wellcome");
                MenuForm form2 = new MenuForm(loginTextBox.Text);

                form2.Show();
                this.Hide();
            }
            else
            {
                db_obj.closeConnection();
                MessageBox.Show("Invalid login or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void RegButton_Click(object sender, EventArgs e)
        {

        }

        #region simple events for text boxes
        private void loginTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "Enter your login:")
            {
                loginTextBox.Text = "";
            }
        }

        private void loginTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "")
            {
                loginTextBox.Text = "Enter your login:";
            }
        }

        private void passwordTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == " and password:")
            {
                passwordTextBox.Text = "";
            }
        }

        private void passwordTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
            {
                passwordTextBox.Text = " and password:";
            }
        }

        private void primeTextLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple sample of a Windows Forms application.", "Prime Text", MessageBoxButtons.OK);
        }
        #endregion

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loginTextBox.TextLength > 20)
            {
                loginTextBox.Text = loginTextBox.Text.Substring(0, 20);
                loginTextLabel.Text = "Login must be\nmax 20 chars.";
            }
            else
            {
                loginTextLabel.Text = "Login";
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.TextLength > 20)
            {
                passwordTextBox.Text = passwordTextBox.Text.Substring(0, 20);
                passwordTextLabel.Text = "Password must be\nmax 20 chars.";
            }
            else
            {
                passwordTextLabel.Text = "Password";
            }
        }
    }
}