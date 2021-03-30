using System;
using System.Windows.Forms;
namespace recaptcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox4.Text = string.Format("REQUEST GET \""+textBox3.Text+"\""+Environment.NewLine+"  HEADER \"User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36\""+Environment.NewLine+"  HEADER \"Pragma: no-cache\""+Environment.NewLine+"  HEADER \"Accept: */*\""+Environment.NewLine+Environment.NewLine+"PARSE \"<SOURCE>\" LR \"<input type=\\\"hidden\\\" id=\\\"recaptcha-token\\\" value=\\\"\" \"\\\">\" -> VAR \""+textBox2.Text+"\""+Environment.NewLine+Environment.NewLine+"REQUEST POST \"https://www.google.com/recaptcha/api2/reload?k="+textBox1.Text+"\""+Environment.NewLine+"  CONTENT \"reason=q&c=<"+textBox2.Text+">&k="+textBox1.Text+"&size=invisible\""+Environment.NewLine+"  CONTENTTYPE \"application/x-www-form-urlencoded\""+Environment.NewLine+"  HEADER \"User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36\""+Environment.NewLine+"  HEADER \"Pragma: no-cache\""+Environment.NewLine+"  HEADER \"Accept: */*\""+Environment.NewLine+Environment.NewLine+"PARSE \"<SOURCE>\" LR \"rresp\\\",\\\"\" \"\\\",\" -> VAR \""+textBox5.Text+"\"");
                MessageBox.Show("Successfully generated!"+Environment.NewLine+Environment.NewLine+Environment.NewLine+Environment.NewLine+"by @mrflooky", "Success!");
            }
            else if (radioButton2.Checked == true)
            {
                textBox4.Text = string.Format("REQUEST GET \""+textBox3.Text+"\""+Environment.NewLine+"  HEADER \"User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36\""+Environment.NewLine+"  HEADER \"Pragma: no-cache\""+Environment.NewLine+"  HEADER \"Accept: */*\""+Environment.NewLine+Environment.NewLine+"PARSE \"<SOURCE>\" LR \"<input type=\\\"hidden\\\" id=\\\"recaptcha-token\\\" value=\\\"\" \"\\\">\" -> VAR \""+textBox2.Text+"\""+Environment.NewLine+Environment.NewLine+"REQUEST POST \"https://www.google.com/recaptcha/enterprise/reload?k="+textBox1.Text+"\""+Environment.NewLine+"  CONTENT \"reason=q&c=<"+textBox2.Text+">&k="+textBox1.Text+"&size=invisible\""+Environment.NewLine+"  CONTENTTYPE \"application/x-www-form-urlencoded\""+Environment.NewLine+"  HEADER \"User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36\""+Environment.NewLine+"  HEADER \"Pragma: no-cache\""+Environment.NewLine+"  HEADER \"Accept: */*\""+Environment.NewLine+Environment.NewLine+"PARSE \"<SOURCE>\" LR \"rresp\\\",\\\"\" \"\\\",\" -> VAR \""+textBox5.Text+"\"");
                MessageBox.Show("Successfully generated!"+Environment.NewLine+Environment.NewLine+Environment.NewLine+Environment.NewLine+"by @mrflooky", "Success!");
            }
            else
            {
                MessageBox.Show("Please select any of checkboxes!", "Error!");
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Please click the button \"Generate!\"", "Error!");
            }
            else
            {
                Clipboard.SetText(textBox4.Text);
                MessageBox.Show("Successfully copied to clipboard!"+Environment.NewLine+Environment.NewLine+Environment.NewLine+Environment.NewLine+"by @mrflooky", "Success!");
            }
        }
    }
}
