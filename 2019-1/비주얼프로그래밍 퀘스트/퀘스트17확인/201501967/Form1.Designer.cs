namespace _201501967
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_kcal = new System.Windows.Forms.Label();
            this.textBox_kcal = new System.Windows.Forms.TextBox();
            this.button_kcal = new System.Windows.Forms.Button();
            this.label_walk = new System.Windows.Forms.Label();
            this.label_run = new System.Windows.Forms.Label();
            this.label_cycle = new System.Windows.Forms.Label();
            this.label_swim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_exe3 = new System.Windows.Forms.Label();
            this.label_exe2 = new System.Windows.Forms.Label();
            this.label_exe1 = new System.Windows.Forms.Label();
            this.button_exercise = new System.Windows.Forms.Button();
            this.textBox_exercise = new System.Windows.Forms.TextBox();
            this.label_exercise = new System.Windows.Forms.Label();
            this.labelm4 = new System.Windows.Forms.Label();
            this.labelm3 = new System.Windows.Forms.Label();
            this.labelm2 = new System.Windows.Forms.Label();
            this.labelm1 = new System.Windows.Forms.Label();
            this.label_walka = new System.Windows.Forms.Label();
            this.label_runa = new System.Windows.Forms.Label();
            this.label_swima = new System.Windows.Forms.Label();
            this.label_cyclea = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_foodname = new System.Windows.Forms.Button();
            this.label_foodname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_q = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label_main = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_information2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_information = new System.Windows.Forms.Label();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.회원정보 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.회원가입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보입력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보불러오기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_kcal
            // 
            this.label_kcal.AutoSize = true;
            this.label_kcal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_kcal.Location = new System.Drawing.Point(28, 16);
            this.label_kcal.Name = "label_kcal";
            this.label_kcal.Size = new System.Drawing.Size(201, 12);
            this.label_kcal.TabIndex = 2;
            this.label_kcal.Text = "오늘 섭취한 칼로리를 입력해주세요.";
            // 
            // textBox_kcal
            // 
            this.textBox_kcal.Location = new System.Drawing.Point(5, 31);
            this.textBox_kcal.Name = "textBox_kcal";
            this.textBox_kcal.Size = new System.Drawing.Size(255, 21);
            this.textBox_kcal.TabIndex = 3;
            // 
            // button_kcal
            // 
            this.button_kcal.Location = new System.Drawing.Point(5, 58);
            this.button_kcal.Name = "button_kcal";
            this.button_kcal.Size = new System.Drawing.Size(255, 23);
            this.button_kcal.TabIndex = 4;
            this.button_kcal.Text = "건강해지기 위해 운동을 얼마나 해야할까요?";
            this.button_kcal.UseVisualStyleBackColor = true;
            this.button_kcal.Click += new System.EventHandler(this.button_kcal_Click);
            // 
            // label_walk
            // 
            this.label_walk.AutoSize = true;
            this.label_walk.Location = new System.Drawing.Point(15, 84);
            this.label_walk.Name = "label_walk";
            this.label_walk.Size = new System.Drawing.Size(29, 12);
            this.label_walk.TabIndex = 5;
            this.label_walk.Text = "걷기";
            // 
            // label_run
            // 
            this.label_run.AutoSize = true;
            this.label_run.Location = new System.Drawing.Point(15, 104);
            this.label_run.Name = "label_run";
            this.label_run.Size = new System.Drawing.Size(29, 12);
            this.label_run.TabIndex = 6;
            this.label_run.Text = "뛰기";
            // 
            // label_cycle
            // 
            this.label_cycle.AutoSize = true;
            this.label_cycle.Location = new System.Drawing.Point(133, 104);
            this.label_cycle.Name = "label_cycle";
            this.label_cycle.Size = new System.Drawing.Size(41, 12);
            this.label_cycle.TabIndex = 7;
            this.label_cycle.Text = "자전거";
            // 
            // label_swim
            // 
            this.label_swim.AutoSize = true;
            this.label_swim.Location = new System.Drawing.Point(133, 84);
            this.label_swim.Name = "label_swim";
            this.label_swim.Size = new System.Drawing.Size(29, 12);
            this.label_swim.TabIndex = 8;
            this.label_swim.Text = "수영";
            this.label_swim.Click += new System.EventHandler(this.label_swim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label_exe3);
            this.panel1.Controls.Add(this.label_exe2);
            this.panel1.Controls.Add(this.label_exe1);
            this.panel1.Controls.Add(this.button_exercise);
            this.panel1.Controls.Add(this.textBox_exercise);
            this.panel1.Controls.Add(this.label_exercise);
            this.panel1.Controls.Add(this.labelm4);
            this.panel1.Controls.Add(this.labelm3);
            this.panel1.Controls.Add(this.labelm2);
            this.panel1.Controls.Add(this.labelm1);
            this.panel1.Controls.Add(this.label_walka);
            this.panel1.Controls.Add(this.label_runa);
            this.panel1.Controls.Add(this.label_swima);
            this.panel1.Controls.Add(this.label_cyclea);
            this.panel1.Controls.Add(this.label_kcal);
            this.panel1.Controls.Add(this.label_cycle);
            this.panel1.Controls.Add(this.label_swim);
            this.panel1.Controls.Add(this.textBox_kcal);
            this.panel1.Controls.Add(this.button_kcal);
            this.panel1.Controls.Add(this.label_run);
            this.panel1.Controls.Add(this.label_walk);
            this.panel1.Location = new System.Drawing.Point(274, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 333);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_exe3
            // 
            this.label_exe3.AutoSize = true;
            this.label_exe3.Location = new System.Drawing.Point(111, 286);
            this.label_exe3.Name = "label_exe3";
            this.label_exe3.Size = new System.Drawing.Size(134, 12);
            this.label_exe3.TabIndex = 23;
            this.label_exe3.Text = "Kcal가 소모되었습니다.";
            // 
            // label_exe2
            // 
            this.label_exe2.AutoSize = true;
            this.label_exe2.Location = new System.Drawing.Point(28, 286);
            this.label_exe2.Name = "label_exe2";
            this.label_exe2.Size = new System.Drawing.Size(17, 12);
            this.label_exe2.TabIndex = 22;
            this.label_exe2.Text = "총";
            // 
            // label_exe1
            // 
            this.label_exe1.AutoSize = true;
            this.label_exe1.Location = new System.Drawing.Point(65, 286);
            this.label_exe1.Name = "label_exe1";
            this.label_exe1.Size = new System.Drawing.Size(0, 12);
            this.label_exe1.TabIndex = 21;
            // 
            // button_exercise
            // 
            this.button_exercise.Location = new System.Drawing.Point(5, 228);
            this.button_exercise.Name = "button_exercise";
            this.button_exercise.Size = new System.Drawing.Size(255, 23);
            this.button_exercise.TabIndex = 20;
            this.button_exercise.Text = "몇 칼로리가 소모되었을까요?";
            this.button_exercise.UseVisualStyleBackColor = true;
            this.button_exercise.Click += new System.EventHandler(this.button_exercise_Click);
            // 
            // textBox_exercise
            // 
            this.textBox_exercise.Location = new System.Drawing.Point(5, 201);
            this.textBox_exercise.Name = "textBox_exercise";
            this.textBox_exercise.Size = new System.Drawing.Size(255, 21);
            this.textBox_exercise.TabIndex = 19;
            // 
            // label_exercise
            // 
            this.label_exercise.AutoSize = true;
            this.label_exercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_exercise.Location = new System.Drawing.Point(16, 178);
            this.label_exercise.Name = "label_exercise";
            this.label_exercise.Size = new System.Drawing.Size(229, 12);
            this.label_exercise.TabIndex = 18;
            this.label_exercise.Text = "유산소운동을 몇 분 했는지 입력해주세요.";
            // 
            // labelm4
            // 
            this.labelm4.AutoSize = true;
            this.labelm4.Location = new System.Drawing.Point(212, 104);
            this.labelm4.Name = "labelm4";
            this.labelm4.Size = new System.Drawing.Size(17, 12);
            this.labelm4.TabIndex = 17;
            this.labelm4.Text = "분";
            // 
            // labelm3
            // 
            this.labelm3.AutoSize = true;
            this.labelm3.Location = new System.Drawing.Point(212, 84);
            this.labelm3.Name = "labelm3";
            this.labelm3.Size = new System.Drawing.Size(17, 12);
            this.labelm3.TabIndex = 16;
            this.labelm3.Text = "분";
            // 
            // labelm2
            // 
            this.labelm2.AutoSize = true;
            this.labelm2.Location = new System.Drawing.Point(82, 104);
            this.labelm2.Name = "labelm2";
            this.labelm2.Size = new System.Drawing.Size(17, 12);
            this.labelm2.TabIndex = 15;
            this.labelm2.Text = "분";
            // 
            // labelm1
            // 
            this.labelm1.AutoSize = true;
            this.labelm1.Location = new System.Drawing.Point(82, 84);
            this.labelm1.Name = "labelm1";
            this.labelm1.Size = new System.Drawing.Size(17, 12);
            this.labelm1.TabIndex = 14;
            this.labelm1.Text = "분";
            // 
            // label_walka
            // 
            this.label_walka.BackColor = System.Drawing.Color.White;
            this.label_walka.Location = new System.Drawing.Point(50, 84);
            this.label_walka.Name = "label_walka";
            this.label_walka.Size = new System.Drawing.Size(26, 12);
            this.label_walka.TabIndex = 10;
            // 
            // label_runa
            // 
            this.label_runa.BackColor = System.Drawing.Color.White;
            this.label_runa.Location = new System.Drawing.Point(50, 104);
            this.label_runa.Name = "label_runa";
            this.label_runa.Size = new System.Drawing.Size(26, 12);
            this.label_runa.TabIndex = 11;
            // 
            // label_swima
            // 
            this.label_swima.BackColor = System.Drawing.Color.White;
            this.label_swima.Location = new System.Drawing.Point(180, 84);
            this.label_swima.Name = "label_swima";
            this.label_swima.Size = new System.Drawing.Size(26, 12);
            this.label_swima.TabIndex = 12;
            // 
            // label_cyclea
            // 
            this.label_cyclea.BackColor = System.Drawing.Color.White;
            this.label_cyclea.Location = new System.Drawing.Point(180, 104);
            this.label_cyclea.Name = "label_cyclea";
            this.label_cyclea.Size = new System.Drawing.Size(26, 12);
            this.label_cyclea.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button_foodname);
            this.panel2.Controls.Add(this.label_foodname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_q);
            this.panel2.Location = new System.Drawing.Point(274, 393);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 182);
            this.panel2.TabIndex = 21;
            // 
            // button_foodname
            // 
            this.button_foodname.Location = new System.Drawing.Point(8, 145);
            this.button_foodname.Name = "button_foodname";
            this.button_foodname.Size = new System.Drawing.Size(119, 23);
            this.button_foodname.TabIndex = 24;
            this.button_foodname.Text = "무슨 음식 일까요?";
            this.button_foodname.UseVisualStyleBackColor = true;
            this.button_foodname.Click += new System.EventHandler(this.button_foodname_Click);
            // 
            // label_foodname
            // 
            this.label_foodname.Location = new System.Drawing.Point(6, 46);
            this.label_foodname.Name = "label_foodname";
            this.label_foodname.Size = new System.Drawing.Size(121, 90);
            this.label_foodname.TabIndex = 23;
            this.label_foodname.Text = "오늘의 추천 건강식품";
            this.label_foodname.Click += new System.EventHandler(this.label_foodname_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(155, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_q
            // 
            this.label_q.AutoSize = true;
            this.label_q.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_q.Location = new System.Drawing.Point(6, 8);
            this.label_q.Name = "label_q";
            this.label_q.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_q.Size = new System.Drawing.Size(81, 12);
            this.label_q.TabIndex = 21;
            this.label_q.Text = "건강한 식습관";
            // 
            // label_main
            // 
            this.label_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_main.Location = new System.Drawing.Point(13, 10);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(203, 18);
            this.label_main.TabIndex = 22;
            this.label_main.Text = "안녕하세요! 헬스케어서비스 입니다. ";
            this.label_main.Click += new System.EventHandler(this.label_main_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label_information2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label_information);
            this.panel3.Controls.Add(this.pictureBox_main);
            this.panel3.Controls.Add(this.회원정보);
            this.panel3.Controls.Add(this.label_main);
            this.panel3.Location = new System.Drawing.Point(23, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 532);
            this.panel3.TabIndex = 34;
            // 
            // label_information2
            // 
            this.label_information2.AutoSize = true;
            this.label_information2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_information2.Location = new System.Drawing.Point(79, 204);
            this.label_information2.Name = "label_information2";
            this.label_information2.Size = new System.Drawing.Size(57, 12);
            this.label_information2.TabIndex = 38;
            this.label_information2.Text = "회원 목록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "회원가입 후 이용해주세요!";
            // 
            // label_information
            // 
            this.label_information.AutoSize = true;
            this.label_information.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_information.Location = new System.Drawing.Point(13, 28);
            this.label_information.Name = "label_information";
            this.label_information.Size = new System.Drawing.Size(123, 12);
            this.label_information.TabIndex = 36;
            this.label_information.Text = "이용이 처음이신가요?";
            this.label_information.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_main.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_main.Image")));
            this.pictureBox_main.Location = new System.Drawing.Point(65, 82);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(97, 97);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_main.TabIndex = 1;
            this.pictureBox_main.TabStop = false;
            this.pictureBox_main.Click += new System.EventHandler(this.pictureBox_main_Click);
            // 
            // 회원정보
            // 
            this.회원정보.FormattingEnabled = true;
            this.회원정보.ItemHeight = 12;
            this.회원정보.Location = new System.Drawing.Point(15, 219);
            this.회원정보.Name = "회원정보";
            this.회원정보.Size = new System.Drawing.Size(201, 292);
            this.회원정보.TabIndex = 35;
            this.회원정보.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원가입ToolStripMenuItem,
            this.불러오기ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 회원가입ToolStripMenuItem
            // 
            this.회원가입ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원정보입력ToolStripMenuItem,
            this.회원정보저장ToolStripMenuItem,
            this.회원정보삭제ToolStripMenuItem});
            this.회원가입ToolStripMenuItem.Name = "회원가입ToolStripMenuItem";
            this.회원가입ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.회원가입ToolStripMenuItem.Text = "회원가입";
            this.회원가입ToolStripMenuItem.Click += new System.EventHandler(this.회원가입ToolStripMenuItem_Click);
            // 
            // 회원정보입력ToolStripMenuItem
            // 
            this.회원정보입력ToolStripMenuItem.Name = "회원정보입력ToolStripMenuItem";
            this.회원정보입력ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.회원정보입력ToolStripMenuItem.Text = "회원정보입력";
            this.회원정보입력ToolStripMenuItem.Click += new System.EventHandler(this.회원정보입력ToolStripMenuItem_Click);
            // 
            // 회원정보저장ToolStripMenuItem
            // 
            this.회원정보저장ToolStripMenuItem.Name = "회원정보저장ToolStripMenuItem";
            this.회원정보저장ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.회원정보저장ToolStripMenuItem.Text = "회원정보저장";
            this.회원정보저장ToolStripMenuItem.Click += new System.EventHandler(this.회원정보저장ToolStripMenuItem_Click);
            // 
            // 회원정보삭제ToolStripMenuItem
            // 
            this.회원정보삭제ToolStripMenuItem.Name = "회원정보삭제ToolStripMenuItem";
            this.회원정보삭제ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.회원정보삭제ToolStripMenuItem.Text = "회원정보삭제";
            this.회원정보삭제ToolStripMenuItem.Click += new System.EventHandler(this.회원정보삭제ToolStripMenuItem_Click);
            // 
            // 불러오기ToolStripMenuItem
            // 
            this.불러오기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.회원정보불러오기ToolStripMenuItem});
            this.불러오기ToolStripMenuItem.Name = "불러오기ToolStripMenuItem";
            this.불러오기ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.불러오기ToolStripMenuItem.Text = "불러오기";
            // 
            // 회원정보불러오기ToolStripMenuItem
            // 
            this.회원정보불러오기ToolStripMenuItem.Name = "회원정보불러오기ToolStripMenuItem";
            this.회원정보불러오기ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.회원정보불러오기ToolStripMenuItem.Text = "회원정보불러오기";
            this.회원정보불러오기ToolStripMenuItem.Click += new System.EventHandler(this.회원정보불러오기ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem1});
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.종료ToolStripMenuItem.Text = "기타";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem1
            // 
            this.종료ToolStripMenuItem1.Name = "종료ToolStripMenuItem1";
            this.종료ToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem1.Text = "종료";
            this.종료ToolStripMenuItem1.Click += new System.EventHandler(this.종료ToolStripMenuItem1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.progressBar1.Location = new System.Drawing.Point(23, 594);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 39;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(549, 629);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "헬스케어";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Label label_kcal;
        private System.Windows.Forms.TextBox textBox_kcal;
        private System.Windows.Forms.Button button_kcal;
        private System.Windows.Forms.Label label_walk;
        private System.Windows.Forms.Label label_run;
        private System.Windows.Forms.Label label_cycle;
        private System.Windows.Forms.Label label_swim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_walka;
        private System.Windows.Forms.Label label_runa;
        private System.Windows.Forms.Label label_swima;
        private System.Windows.Forms.Label label_cyclea;
        private System.Windows.Forms.Label labelm4;
        private System.Windows.Forms.Label labelm3;
        private System.Windows.Forms.Label labelm2;
        private System.Windows.Forms.Label labelm1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_q;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_exercise;
        private System.Windows.Forms.TextBox textBox_exercise;
        private System.Windows.Forms.Label label_exercise;
        private System.Windows.Forms.Label label_exe1;
        private System.Windows.Forms.Label label_exe3;
        private System.Windows.Forms.Label label_exe2;
        private System.Windows.Forms.Label label_foodname;
        private System.Windows.Forms.Button button_foodname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 회원정보저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원정보삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        public System.Windows.Forms.ToolStripMenuItem 회원가입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원정보입력ToolStripMenuItem;
        public System.Windows.Forms.ListBox 회원정보;
        private System.Windows.Forms.Label label_information;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_information2;
        private System.Windows.Forms.ToolStripMenuItem 불러오기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원정보불러오기ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

