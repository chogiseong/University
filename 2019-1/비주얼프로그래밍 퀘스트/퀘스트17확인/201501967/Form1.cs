using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace _201501967
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        OpenFileDialog ofg = new OpenFileDialog();
        private int timerCount = 0;
        private void pictureBox_main_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                    MessageBox.Show("건강에 도움을 주는 헬스케어 서비스 입니다.");
                if (i == 1)
                    MessageBox.Show("다이어트 및 식이요법에 도움을 드릴 수 있습니다.");
                if (i == 2)
                    MessageBox.Show("이용해주셔서 감사합니다.");
            }
            
        }

        private void button_end_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_kcal_Click(object sender, EventArgs e)
        {
            int kcal = int.Parse(textBox_kcal.Text);
            int walk = kcal / 5;
            int run = kcal / 15;
            int swim = kcal / 13;
            int cycle = kcal / 11;
            label_walka.Text = walk.ToString();
            label_runa.Text = run.ToString();
            label_swima.Text = swim.ToString();
            label_cyclea.Text = cycle.ToString();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }
            int asum = 0;
            while (asum < 100)
            {
                asum += 5;
            }
        }

        private void label_swim_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radiogroup(object sender, EventArgs e)
        {
            exam();
        }

        private void exam()
        {
            Random r = new Random();
            int b;
            b = r.Next() % 4 + 1;
            if (b == 1)
                pictureBox1.Image = Properties.Resources.q1;
            if (b == 2)
                pictureBox1.Image = Properties.Resources.q2;
            if (b == 3)
                pictureBox1.Image = Properties.Resources.q3;
            if (b == 4)
                pictureBox1.Image = Properties.Resources.q4;
        }

        private void label_main_Click(object sender, EventArgs e)
        {
        }
        private void label_number_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_exercise_Click(object sender, EventArgs e)
        {
            float f1 = int.Parse(textBox_exercise.Text);
            health_1 cl = new _201501967.health_1();
            float pay = cl.classhealth(f1);
            label_exe1.Text = pay.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string fn = Path.GetFileNameWithoutExtension(ofg.FileName);
            label_foodname.Text = fn;
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofg.FileName);
                pictureBox1.Image = img;
            }
            
        }

        private void label_foodname_Click(object sender, EventArgs e)
        {

        }

        private void button_foodname_Click(object sender, EventArgs e)
        {
            
            string fn = Path.GetFileNameWithoutExtension(ofg.FileName);
            label_foodname.Text = fn;
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 회원정보삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            회원정보.Items.Clear();
        }

        private void 회원정보저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "텍스트 파일|*.txt|모든 파일|*.*"; //파일 형식
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                int nCount = 회원정보.Items.Count;
                for (int i = 0; i < nCount; i++)
                {
                    회원정보.Items[i] += "\r\n";
                    sw.Write(회원정보.Items[i]);
                }
                sw.Close();
            }
        }

        private void 회원정보입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login myForm = new login (this);
            //myForm.ShowDialog();
            myForm.Show();

        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void 종료ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void 회원가입ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 회원정보불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                string[] lines = File.ReadAllLines(ofd.FileName);

                회원정보.DataSource = lines;

                sr.Close();
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ProgressBar_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Marquee;  // style은 continuous, blocks를 줄 수 있다. 
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            timer1.Start();  //timer Start를 해주어야 Event가 발생한다.
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text += ".";
            if (++timerCount == 5)
            {
                timer1.Stop();
                progressBar1.Enabled = false;
                this.Close();
            }
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0; //크로스 쓰레딩을 피하기 위해 설정은 메인쓰레드가 실행하는 곳에 넣었습니다
            progressBar1.Maximum = 1000000;

            Thread thread1 = new Thread(new ThreadStart(ThreadGOGO));
            thread1.Start();  //ThreadGOGO메소드를 새로운 쓰레드가 실행합니다
        }

        //이번엔 파라미터를 하나 넘겨줘야 하기에 델리게이트를 직접 정의 했습니다
        delegate void ProgvarCall(int var);

        private void ThreadGOGO()
        {
            for (int i = 0; i < 1000000; i++)
            {    
                progressBar1.Invoke(new ProgvarCall(ProgValueSetting), new object[] { i });
            }
        }

        private void ProgValueSetting(int var)
        {
            progressBar1.Value = var;
        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}