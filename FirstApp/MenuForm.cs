using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FirstApp
{
    public partial class MenuForm : Form
    {
        public MenuForm(string data)
        {
            InitializeComponent();
            label2.Text = "...i " + data;
            File.AppendAllText("log.txt", "User logged in: " + data + Environment.NewLine);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logRead()
        {
            string foundPath = null;

            string[] tryDirs = new[] { Directory.GetCurrentDirectory(), Application.StartupPath };

            foreach (var dir in tryDirs)
            {
                var tryPath = Path.Combine(dir, "log.txt");
                if (File.Exists(tryPath))
                {
                    foundPath = tryPath;
                    break;
                }
            }

            if (foundPath != null)
            {
                var lines = File.ReadAllLines(foundPath);
                if (lines.Length == 0)
                {
                    MessageBox.Show("Log is empty.", "Log File Content", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var lastLines = lines.Skip(Math.Max(0, lines.Length - 10));
                string textLog = string.Join(Environment.NewLine, lastLines);
                MessageBox.Show(textLog, "Last log entries:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("log.txt not found in project/current directories.");
            }
        }

        private void logOpenButton_Click(object sender, EventArgs e)
        {
            logRead();
        }

        private void regTableOpenButton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Це пасхалка до гри.\n  відкрити посилання?", "Пасхалка", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    Process.Start(new ProcessStartInfo("https://uk.wikipedia.org/wiki/The_Neverhood") { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вдалося відкрити посилання: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Try to find an existing LoginForm instance (it was hidden, not closed)
            foreach (Form form1 in Application.OpenForms)
            {
                if (form1 is LoginForm)
                {
                    form1.Show();
                    form1.BringToFront();
                    form1.Activate();
                    this.Close();
                    return;
                }
            }

            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
