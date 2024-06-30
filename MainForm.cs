using FubarDev.FtpServer;
using FubarDev.FtpServer.AccountManagement;
using FubarDev.FtpServer;
using FubarDev.FtpServer.FileSystem.DotNet;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Claims;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Globalization;

namespace EasyFTPServer
{
    public partial class MainForm : Form
    {
        public static string username = "";
        public static string password = "";
        ServiceProvider service;
        LanguageManager languageManager;
        string defaultLanguage = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName.ToLower();
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            languageManager = new LanguageManager();
            foreach(Control c in Controls)
            {
                languageManager.controls.Add(c);
            }
            languageManager.form = this;
            languageManager.controls.Add(notifyIcon1.ContextMenuStrip);
            if (!LanguageManager.Languages.ContainsKey(defaultLanguage))
            {
                defaultLanguage = "en";
            }
            languageManager.LoadLanguage(defaultLanguage);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StartFTPServer())
            {
                tsmi_start.Enabled = false;
                bt_start.Enabled = false;
                tsmi_stop.Enabled = true;
                bt_stop.Enabled = true;
                gb_config.Enabled = false;
            }
        }
        private bool StartFTPServer()
        {
            username = tb_username.Text;
            password = tb_password.Text;
            int port = 21;
            if (!int.TryParse(tb_port.Text, out port))
            {
                MessageBox.Show(languageManager.Get("InvaildPort"));
                return false;
            }

            if (username == "" && password == "" && MessageBox.Show(languageManager.Get("EmptyWarning"),
                languageManager.Get("EmptyWarningTitle"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return false;
            }

            service = new ServiceCollection().Configure<DotNetFileSystemOptions>(opt => opt.RootPath = tb_rootdir.Text)
                .Configure<FtpServerOptions>(opt => { opt.ServerAddress = "*"; opt.Port = port; })
                .AddFtpServer(builder => builder.UseDotNetFileSystem())
                .AddSingleton<IMembershipProvider, CustomMembershipProvider>()
                .BuildServiceProvider();

            service.GetRequiredService<IFtpServerHost>().StartAsync(CancellationToken.None);

            return true;
        }

        private void bt_selectdir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                tb_rootdir.Text = selectedFolderPath;
            }
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            service.GetRequiredService<IFtpServerHost>().StopAsync(CancellationToken.None).Wait();
            service.Dispose();
            tsmi_start.Enabled = true;
            bt_start.Enabled = true;
            tsmi_stop.Enabled = false;
            bt_stop.Enabled = false;
            gb_config.Enabled = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            Focus();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void tsmi_start_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void tsmi_stop_Click(object sender, EventArgs e)
        {
            bt_stop_Click(sender, e);
        }
        private void tsmi_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tssi_en_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("en");
        }

        private void tssi_zh_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("zh");
        }

        private void tssi_es_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("es");
        }

        private void tssi_fr_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("fr");
        }

        private void tssi_de_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("de");
        }

        private void tssi_pt_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("pt");
        }

        private void tssi_ja_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("ja");
        }

        private void tssi_ru_Click(object sender, EventArgs e)
        {
            languageManager.LoadLanguage("ru");
        }
    }

    public class CustomMembershipProvider : IMembershipProvider
    {
        public Task<MemberValidationResult> ValidateUserAsync(string username, string password)
        {
            if ((MainForm.username == "" && MainForm.password == "") || username == MainForm.username && password == MainForm.password)
            {
                return Task.FromResult(new MemberValidationResult(MemberValidationStatus.AuthenticatedUser, new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, username) }))));
            }
            return Task.FromResult(new MemberValidationResult(MemberValidationStatus.InvalidLogin));
        }
    }
    
}
