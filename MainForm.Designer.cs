namespace EasyFTPServer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bt_start = new Button();
            gb_config = new GroupBox();
            tb_port = new TextBox();
            l_port = new Label();
            tb_password = new TextBox();
            l_password = new Label();
            l_rootdir = new Label();
            tb_username = new TextBox();
            l_username = new Label();
            bt_selectdir = new Button();
            tb_rootdir = new TextBox();
            bt_stop = new Button();
            notifyIcon1 = new NotifyIcon(components);
            cms_icon = new ContextMenuStrip(components);
            tsmi_start = new ToolStripMenuItem();
            tsmi_stop = new ToolStripMenuItem();
            tsmi_exit = new ToolStripMenuItem();
            cms_language = new ContextMenuStrip(components);
            tssi_en = new ToolStripMenuItem();
            tssi_zh = new ToolStripMenuItem();
            tssi_es = new ToolStripMenuItem();
            tssi_fr = new ToolStripMenuItem();
            tssi_de = new ToolStripMenuItem();
            tssi_pt = new ToolStripMenuItem();
            tssi_ja = new ToolStripMenuItem();
            tssi_ru = new ToolStripMenuItem();
            gb_config.SuspendLayout();
            cms_icon.SuspendLayout();
            cms_language.SuspendLayout();
            SuspendLayout();
            // 
            // bt_start
            // 
            bt_start.Location = new Point(424, 57);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(87, 36);
            bt_start.TabIndex = 0;
            bt_start.Text = "Start";
            bt_start.UseVisualStyleBackColor = true;
            bt_start.Click += button1_Click;
            // 
            // gb_config
            // 
            gb_config.Controls.Add(tb_port);
            gb_config.Controls.Add(l_port);
            gb_config.Controls.Add(tb_password);
            gb_config.Controls.Add(l_password);
            gb_config.Controls.Add(l_rootdir);
            gb_config.Controls.Add(tb_username);
            gb_config.Controls.Add(l_username);
            gb_config.Controls.Add(bt_selectdir);
            gb_config.Controls.Add(tb_rootdir);
            gb_config.Location = new Point(12, 11);
            gb_config.Name = "gb_config";
            gb_config.Size = new Size(406, 148);
            gb_config.TabIndex = 1;
            gb_config.TabStop = false;
            gb_config.Text = "Configuration";
            // 
            // tb_port
            // 
            tb_port.Location = new Point(132, 121);
            tb_port.Name = "tb_port";
            tb_port.Size = new Size(140, 23);
            tb_port.TabIndex = 8;
            tb_port.Text = "21";
            // 
            // l_port
            // 
            l_port.AutoSize = true;
            l_port.ImeMode = ImeMode.NoControl;
            l_port.Location = new Point(16, 123);
            l_port.Name = "l_port";
            l_port.Size = new Size(32, 15);
            l_port.TabIndex = 7;
            l_port.Text = "Port:";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(132, 88);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(140, 23);
            tb_password.TabIndex = 6;
            // 
            // l_password
            // 
            l_password.AutoSize = true;
            l_password.ImeMode = ImeMode.NoControl;
            l_password.Location = new Point(16, 90);
            l_password.Name = "l_password";
            l_password.Size = new Size(60, 15);
            l_password.TabIndex = 5;
            l_password.Text = "Password:";
            // 
            // l_rootdir
            // 
            l_rootdir.AutoSize = true;
            l_rootdir.Location = new Point(16, 25);
            l_rootdir.Name = "l_rootdir";
            l_rootdir.Size = new Size(68, 15);
            l_rootdir.TabIndex = 0;
            l_rootdir.Text = "RootFolder:";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(132, 56);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(140, 23);
            tb_username.TabIndex = 4;
            // 
            // l_username
            // 
            l_username.AutoSize = true;
            l_username.Location = new Point(16, 57);
            l_username.Name = "l_username";
            l_username.Size = new Size(63, 15);
            l_username.TabIndex = 3;
            l_username.Text = "Username:";
            // 
            // bt_selectdir
            // 
            bt_selectdir.Location = new Point(278, 22);
            bt_selectdir.Name = "bt_selectdir";
            bt_selectdir.Size = new Size(116, 21);
            bt_selectdir.TabIndex = 2;
            bt_selectdir.Text = "SelectFolder";
            bt_selectdir.UseVisualStyleBackColor = true;
            bt_selectdir.Click += bt_selectdir_Click;
            // 
            // tb_rootdir
            // 
            tb_rootdir.Location = new Point(132, 23);
            tb_rootdir.Name = "tb_rootdir";
            tb_rootdir.Size = new Size(140, 23);
            tb_rootdir.TabIndex = 1;
            // 
            // bt_stop
            // 
            bt_stop.Enabled = false;
            bt_stop.ImeMode = ImeMode.NoControl;
            bt_stop.Location = new Point(424, 115);
            bt_stop.Name = "bt_stop";
            bt_stop.Size = new Size(87, 36);
            bt_stop.TabIndex = 2;
            bt_stop.Text = "Stop";
            bt_stop.UseVisualStyleBackColor = true;
            bt_stop.Click += bt_stop_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = cms_icon;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "EasyFTPServer";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // cms_icon
            // 
            cms_icon.Items.AddRange(new ToolStripItem[] { tsmi_start, tsmi_stop, tsmi_exit });
            cms_icon.Name = "cms_icon";
            cms_icon.Size = new Size(181, 92);
            // 
            // tsmi_start
            // 
            tsmi_start.Name = "tsmi_start";
            tsmi_start.Size = new Size(180, 22);
            tsmi_start.Text = "Start Server";
            tsmi_start.Click += tsmi_start_Click;
            // 
            // tsmi_stop
            // 
            tsmi_stop.Enabled = false;
            tsmi_stop.Name = "tsmi_stop";
            tsmi_stop.Size = new Size(180, 22);
            tsmi_stop.Text = "Stop Server";
            tsmi_stop.Click += tsmi_stop_Click;
            // 
            // tsmi_exit
            // 
            tsmi_exit.Name = "tsmi_exit";
            tsmi_exit.Size = new Size(180, 22);
            tsmi_exit.Text = "Exit Program";
            tsmi_exit.Click += tsmi_exit_Click;
            // 
            // cms_language
            // 
            cms_language.Items.AddRange(new ToolStripItem[] { tssi_en, tssi_zh, tssi_es, tssi_fr, tssi_de, tssi_pt, tssi_ja, tssi_ru });
            cms_language.Name = "cms_language";
            cms_language.Size = new Size(129, 180);
            // 
            // tssi_en
            // 
            tssi_en.Name = "tssi_en";
            tssi_en.Size = new Size(128, 22);
            tssi_en.Text = "English";
            tssi_en.Click += tssi_en_Click;
            // 
            // tssi_zh
            // 
            tssi_zh.Name = "tssi_zh";
            tssi_zh.Size = new Size(128, 22);
            tssi_zh.Text = "中文";
            tssi_zh.Click += tssi_zh_Click;
            // 
            // tssi_es
            // 
            tssi_es.Name = "tssi_es";
            tssi_es.Size = new Size(128, 22);
            tssi_es.Text = "Español";
            tssi_es.Click += tssi_es_Click;
            // 
            // tssi_fr
            // 
            tssi_fr.Name = "tssi_fr";
            tssi_fr.Size = new Size(128, 22);
            tssi_fr.Text = "Français";
            tssi_fr.Click += tssi_fr_Click;
            // 
            // tssi_de
            // 
            tssi_de.Name = "tssi_de";
            tssi_de.Size = new Size(128, 22);
            tssi_de.Text = "Deutsch";
            tssi_de.Click += tssi_de_Click;
            // 
            // tssi_pt
            // 
            tssi_pt.Name = "tssi_pt";
            tssi_pt.Size = new Size(128, 22);
            tssi_pt.Text = "Português";
            tssi_pt.Click += tssi_pt_Click;
            // 
            // tssi_ja
            // 
            tssi_ja.Name = "tssi_ja";
            tssi_ja.Size = new Size(128, 22);
            tssi_ja.Text = "日本語";
            tssi_ja.Click += tssi_ja_Click;
            // 
            // tssi_ru
            // 
            tssi_ru.Name = "tssi_ru";
            tssi_ru.Size = new Size(128, 22);
            tssi_ru.Text = "Русский";
            tssi_ru.Click += tssi_ru_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 167);
            ContextMenuStrip = cms_language;
            Controls.Add(bt_stop);
            Controls.Add(gb_config);
            Controls.Add(bt_start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EasyFTPServer";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load_1;
            gb_config.ResumeLayout(false);
            gb_config.PerformLayout();
            cms_icon.ResumeLayout(false);
            cms_language.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bt_start;
        private GroupBox gb_config;
        private Button bt_selectdir;
        private TextBox tb_rootdir;
        private Label l_rootdir;
        private TextBox tb_password;
        private Label l_password;
        private TextBox tb_username;
        private Label l_username;
        private Button bt_stop;
        private TextBox tb_port;
        private Label l_port;
        private ContextMenuStrip cms_icon;
        private ToolStripMenuItem tsmi_start;
        private ToolStripMenuItem tsmi_stop;
        private ToolStripMenuItem tsmi_exit;
        private ContextMenuStrip cms_language;
        private ToolStripMenuItem tssi_en;
        private ToolStripMenuItem tssi_zh;
        public NotifyIcon notifyIcon1;
        private ToolStripMenuItem tssi_es;
        private ToolStripMenuItem tssi_fr;
        private ToolStripMenuItem tssi_de;
        private ToolStripMenuItem tssi_pt;
        private ToolStripMenuItem tssi_ja;
        private ToolStripMenuItem tssi_ru;
    }
}
