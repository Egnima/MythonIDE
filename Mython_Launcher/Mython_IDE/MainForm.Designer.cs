namespace Mython_IDE
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Launch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_winpy = new System.Windows.Forms.Button();
            this.btn_vsc = new System.Windows.Forms.Button();
            this.btn_mc = new System.Windows.Forms.Button();
            this.btn_server = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_CtrlPanel = new System.Windows.Forms.Button();
            this.btn_winpyCMD = new System.Windows.Forms.Button();
            this.btn_WinPyFolder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_reInstall = new System.Windows.Forms.Button();
            this.btn_editServer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsPsBar = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Launch
            // 
            this.btn_Launch.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Launch.Location = new System.Drawing.Point(8, 6);
            this.btn_Launch.Name = "btn_Launch";
            this.btn_Launch.Size = new System.Drawing.Size(238, 37);
            this.btn_Launch.TabIndex = 0;
            this.btn_Launch.Text = "Mython 실행";
            this.btn_Launch.UseVisualStyleBackColor = true;
            this.btn_Launch.Click += new System.EventHandler(this.btn_Launch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 459);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_winpy);
            this.tabPage1.Controls.Add(this.btn_vsc);
            this.tabPage1.Controls.Add(this.btn_mc);
            this.tabPage1.Controls.Add(this.btn_server);
            this.tabPage1.Controls.Add(this.btn_Launch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(254, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "홈";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btn_winpy
            // 
            this.btn_winpy.Location = new System.Drawing.Point(130, 78);
            this.btn_winpy.Name = "btn_winpy";
            this.btn_winpy.Size = new System.Drawing.Size(116, 23);
            this.btn_winpy.TabIndex = 5;
            this.btn_winpy.Text = "WinPython 실행";
            this.btn_winpy.UseVisualStyleBackColor = true;
            this.btn_winpy.Click += new System.EventHandler(this.btn_winpy_Click);
            // 
            // btn_vsc
            // 
            this.btn_vsc.Location = new System.Drawing.Point(8, 78);
            this.btn_vsc.Name = "btn_vsc";
            this.btn_vsc.Size = new System.Drawing.Size(116, 23);
            this.btn_vsc.TabIndex = 4;
            this.btn_vsc.Text = "VSCode 실행";
            this.btn_vsc.UseVisualStyleBackColor = true;
            this.btn_vsc.Click += new System.EventHandler(this.btn_vsc_Click);
            // 
            // btn_mc
            // 
            this.btn_mc.Location = new System.Drawing.Point(130, 49);
            this.btn_mc.Name = "btn_mc";
            this.btn_mc.Size = new System.Drawing.Size(116, 23);
            this.btn_mc.TabIndex = 3;
            this.btn_mc.Text = "Minecraft 실행";
            this.btn_mc.UseVisualStyleBackColor = true;
            this.btn_mc.Click += new System.EventHandler(this.btn_mc_Click);
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(8, 49);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(116, 23);
            this.btn_server.TabIndex = 2;
            this.btn_server.Text = "서버 실행";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btn_reInstall);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(256, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "설정";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_CtrlPanel);
            this.groupBox3.Controls.Add(this.btn_winpyCMD);
            this.groupBox3.Controls.Add(this.btn_WinPyFolder);
            this.groupBox3.Location = new System.Drawing.Point(8, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 115);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Winpython 설정";
            // 
            // btn_CtrlPanel
            // 
            this.btn_CtrlPanel.Location = new System.Drawing.Point(6, 78);
            this.btn_CtrlPanel.Name = "btn_CtrlPanel";
            this.btn_CtrlPanel.Size = new System.Drawing.Size(226, 23);
            this.btn_CtrlPanel.TabIndex = 2;
            this.btn_CtrlPanel.Text = "Winpython 패키지 관리자 열기";
            this.btn_CtrlPanel.UseVisualStyleBackColor = true;
            this.btn_CtrlPanel.Click += new System.EventHandler(this.btn_CtrlPanel_Click);
            // 
            // btn_winpyCMD
            // 
            this.btn_winpyCMD.Location = new System.Drawing.Point(6, 49);
            this.btn_winpyCMD.Name = "btn_winpyCMD";
            this.btn_winpyCMD.Size = new System.Drawing.Size(226, 23);
            this.btn_winpyCMD.TabIndex = 1;
            this.btn_winpyCMD.Text = "Winpython CMD 열기";
            this.btn_winpyCMD.UseVisualStyleBackColor = true;
            this.btn_winpyCMD.Click += new System.EventHandler(this.btn_winpyCMD_Click);
            // 
            // btn_WinPyFolder
            // 
            this.btn_WinPyFolder.Location = new System.Drawing.Point(6, 20);
            this.btn_WinPyFolder.Name = "btn_WinPyFolder";
            this.btn_WinPyFolder.Size = new System.Drawing.Size(226, 23);
            this.btn_WinPyFolder.TabIndex = 0;
            this.btn_WinPyFolder.Text = "Winpython 폴더 열기";
            this.btn_WinPyFolder.UseVisualStyleBackColor = true;
            this.btn_WinPyFolder.Click += new System.EventHandler(this.btn_WinPyFolder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(8, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 45);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "에디터 설정";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "VSCode 사용";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_reInstall
            // 
            this.btn_reInstall.Location = new System.Drawing.Point(8, 364);
            this.btn_reInstall.Name = "btn_reInstall";
            this.btn_reInstall.Size = new System.Drawing.Size(238, 35);
            this.btn_reInstall.TabIndex = 8;
            this.btn_reInstall.Text = "파일 재설치";
            this.btn_reInstall.UseVisualStyleBackColor = true;
            this.btn_reInstall.Click += new System.EventHandler(this.btn_reInstall_Click);
            // 
            // btn_editServer
            // 
            this.btn_editServer.Location = new System.Drawing.Point(12, 92);
            this.btn_editServer.Name = "btn_editServer";
            this.btn_editServer.Size = new System.Drawing.Size(210, 32);
            this.btn_editServer.TabIndex = 7;
            this.btn_editServer.Text = "서버 설정";
            this.btn_editServer.UseVisualStyleBackColor = true;
            this.btn_editServer.Click += new System.EventHandler(this.btn_editServer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.btn_editServer);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버 설정";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(101, 66);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(101, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "difficulty : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "level-type : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "online-mode : ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(101, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPsBar,
            this.tsLbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(264, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsPsBar
            // 
            this.tsPsBar.Name = "tsPsBar";
            this.tsPsBar.Size = new System.Drawing.Size(100, 16);
            // 
            // tsLbl_Status
            // 
            this.tsLbl_Status.Name = "tsLbl_Status";
            this.tsLbl_Status.Size = new System.Drawing.Size(40, 17);
            this.tsLbl_Status.Text = "Status";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox2);
            this.groupBox4.Location = new System.Drawing.Point(8, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 44);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "IDE 설정";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 20);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(146, 16);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Mython 실행시 최소화";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.linkLabel1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(410, 125);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "정보";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "제작자 : Egnima";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "이메일 : chooheonoh@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(120, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "깃허브 : ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(180, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Egnima Profile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mython_IDE.Properties.Resources.unity_technologies_squarelogo_1435914706545;
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 459);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MythonIDE";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Launch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsPsBar;
        private System.Windows.Forms.ToolStripStatusLabel tsLbl_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_reInstall;
        private System.Windows.Forms.Button btn_editServer;
        private System.Windows.Forms.Button btn_winpy;
        private System.Windows.Forms.Button btn_vsc;
        private System.Windows.Forms.Button btn_mc;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_CtrlPanel;
        private System.Windows.Forms.Button btn_winpyCMD;
        private System.Windows.Forms.Button btn_WinPyFolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

