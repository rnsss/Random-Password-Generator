using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;  
  
namespace SimpleWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private TextBox textBoxCustomChars;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            // 假设你已经在设计视图中添加了一个TableLayoutPanel控件  
            // 并设置了它的行和列（例如，一行两列）  

            // numericUpDown1.Value = 16;
            checkedListBoxOptions.Items.Add("Contains lowercase letters", true);
            checkedListBoxOptions.Items.Add("Contains uppercase letters", true);
            checkedListBoxOptions.Items.Add("Contains numbers", true);
            checkedListBoxOptions.Items.Add("Contains special characters", true);

            textBoxCustomChars = new TextBox();
            textBoxCustomChars.Visible = true; // 初始时不可见  
            textBoxCustomChars.Location = new System.Drawing.Point(35, 85); // 示例位置  
            textBoxCustomChars.Size = new System.Drawing.Size(200, 20);
            textBoxCustomChars.Text = "!@#$%^&*";
            this.Controls.Add(textBoxCustomChars);
            textBoxCustomChars.BringToFront();

            // 处理CheckedListBox的ItemCheck事件以显示/隐藏textBoxCustomChars  
            checkedListBoxOptions.ItemCheck += checkedListBoxOptions_ItemCheck;

            // 在窗体加载时生成并显示密码  
            this.Load += Form1_Load;
        }

        private void checkedListBoxOptions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == checkedListBoxOptions.Items.IndexOf("Contains special characters"))
            {
                textBoxCustomChars.Text = "!@#$%^&*";
                textBoxCustomChars.Visible = e.NewValue == CheckState.Checked;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string password = GenerateRandomPassword(16, checkedListBoxOptions.CheckedItems);
            txtPassword.Text = password; // 假设你有一个名为txtPassword的TextBox控件  
            // 如果你是用Label来显示密码，并且不想让用户复制，可以这样：  
            // lblPassword.Text = password;  
        }

        // 生成一个指定长度的随机密码  
        private String GenerateRandomPassword(int length, CheckedListBox.CheckedItemCollection checkedItems)
        {
            warnLabel.Visible = false;

            string chars = "";

            if (checkedItems.Contains("Contains special characters") && !string.IsNullOrEmpty(textBoxCustomChars.Text))
            {
                chars += textBoxCustomChars.Text;
            }

            // 根据选中项构建可用的字符集  
            foreach (var item in checkedItems)
            {
                switch (item.ToString())
                {
                    case "Contains lowercase letters":
                        chars += "abcdefghijklmnopqrstuvwxyz";
                        break;
                    case "Contains uppercase letters":
                        chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        break;
                    case "Contains numbers":
                        chars += "0123456789";
                        break;
                }
            }

            if (excludeCharacters.Text != "")
            {
                StringBuilder sb = new StringBuilder();

                foreach (char c in chars)
                {
                    // 如果字符不在要删除的字符集合中，则添加到StringBuilder  
                    if (!excludeCharacters.Text.Contains(c))
                    {
                        sb.Append(c);
                    }
                }

                chars = sb.ToString();
            }

            int number = (int)numberOfPasswords.Value;
            string passwords = "";
            for (int i = 0; i < number; i++)
            {
                String password = GenerateRandomPassword(length, chars);
                password += "\r\n";
                passwords += password;
            }
            Console.WriteLine(passwords);
            return passwords;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text != "\r\n")
            {
                History.Text = txtPassword.Text + History.Text;
            }

            int length = (int)numericUpDown1.Value;
            string password = GenerateRandomPassword(length, checkedListBoxOptions.CheckedItems);
            txtPassword.Text = password;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string GenerateRandomPassword(int length, string allowedChars)
        {
            if (length <= 0)
            {
                return "";
            }

            if (string.IsNullOrEmpty(allowedChars))
            {
                warnLabel.Visible = true;
                return "";
            }

            var passwordChars = new char[length];
            var charArray = allowedChars.ToCharArray();

            for (int i = 0; i < length; i++)
            {
                passwordChars[i] = charArray[random.Next(charArray.Length)];
            }

            return new string(passwordChars);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            History.Text = "";
        }

        private void warnLabel_Click(object sender, EventArgs e)
        {

        }
    }
}