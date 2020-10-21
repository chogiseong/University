using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _201501967
{
    public partial class login : Form
    {
        Form1 main1;
        public string usertext = " ";
        public string Usertext
        {
            get { return usertext; }
            set { usertext = value; }
        }
        public login(Form1 _form)
        {
            InitializeComponent();
            main1 = _form;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttongender_Click(object sender, EventArgs e)
        {

            
            if (checkBox_experience1.Checked)
            {
                Usertext = "회원";

            }
            else if (checkBox_experience2.Checked)
            {
                Usertext = "초심자";
            }
            main1.회원정보.Items.Add(usertext);
            main1.회원정보.Items.Add("이름: " + textBox_name.Text);

            string gender = "";

            if (radioButton_man.Checked)
            {
                gender = "성별: 남자";
            }
            else if (radioButton_woman.Checked)
            {
                gender = "성별: 여자";
            }
            main1.회원정보.Items.Add(gender);



            if (textBox_number.Text == "")
            {
                MessageBox.Show("내용을 입력해주세요.");
            }
            else
            {
                main1.회원정보.Items.Add("학번: " + textBox_number.Text);
                textBox_number.Text = "";
            }
            
            main1.회원정보.Items.Add("신장: " + textBox_cm.Text + " kg");
            main1.회원정보.Items.Add("체중: " + textBox_kg.Text + " cm");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
