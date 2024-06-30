using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace EasyFTPServer
{
    public class LanguageManager
    {
        public Form form;
        public List<Control> controls = new List<Control>();
        public string lang = "en";
        public void LoadLanguage(string language)
        {
            if (Languages.ContainsKey(language))
            {
                lang = language;
                Language l = Languages[language];
                if (l.Data.ContainsKey(form.Name))
                {
                    form.Text = l.Data[form.Name];
                }
                foreach (Control c in controls)
                {
                    UpdateControlText(c, l.Data);
                }
            }
        }

        public string Get(string key)
        {
            if (Languages.ContainsKey(lang))
            {
                return Languages[lang].Data[key];
            }
            return null;
        }

        private void UpdateControlText(Control control, Dictionary<string, string> data)
        {
            if (data.ContainsKey(control.Name))
            {
                control.Text = data[control.Name];
            }
            if (control.ContextMenuStrip != null)
            {
                UpdateContextMenuItems(control.ContextMenuStrip, data);
            }
            if(control is ContextMenuStrip cms)
            {
                UpdateContextMenuItems(cms, data);
            }
            foreach (Control c in control.Controls)
            {
                UpdateControlText(c, data);
            }
        }

        private void UpdateContextMenuItems(ContextMenuStrip cms, Dictionary<string, string> data)
        {
            foreach (ToolStripItem i in cms.Items)
            {
                if (data.ContainsKey(i.Name))
                {
                    i.Text = data[i.Name];
                }
            }
        }

        public static Dictionary<string, Language> Languages = new Dictionary<string, Language>()
        {
            {"zh",new Language()
            {
                Name="zh",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm","简单FTP服务器" },
                    {"gb_config","服务器配置" },
                    {"l_rootdir","主文件夹:" },
                    {"l_username","用户名:" },
                    {"l_password","密码:" },
                    {"l_port","端口:" },
                    {"bt_selectdir","选择文件夹" },
                    {"bt_start","开启" },
                    {"bt_stop","关闭" },
                    {"notifyIcon1","简单FTP服务器" },
                    {"tsmi_start","开启服务器" },
                    {"tsmi_stop","关闭服务器" },
                    {"tsmi_exit","退出程序" },

                    {"InvaildPort","端口必须是1到65535之间的数字！" },
                    {"EmptyWarningTitle","空密码警告" },
                    {"EmptyWarning","您正在使用空用户名和密码，这意味着网络上的所有计算机都可以访问您的文件。您确定要继续吗？" },
                }
            }},
            {"en",new Language()
            {
                Name="en",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Configuration"},
                    {"l_rootdir", "RootFolder:"},
                    {"l_username", "Username:"},
                    {"l_password", "Password:"},
                    {"l_port", "Port:"},
                    {"bt_selectdir", "SelectFolder"},
                    {"bt_start", "Start"},
                    {"bt_stop", "Stop"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "Start Server"},
                    {"tsmi_stop", "Stop Server"},
                    {"tsmi_exit", "Exit Program"},

                    {"InvaildPort","port must be a number between 1 and 65535!" },
                    {"EmptyWarningTitle","Empty Password Warning" },
                    {"EmptyWarning","You are using a empty username and password, which means all computer on the network can access your files. Are you sure to continue?" },
                }
            }},
            {"es",new Language()
            {
                Name="es",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Configuración"},
                    {"l_rootdir", "CarpetaRaíz:"},
                    {"l_username", "NombreUsuario:"},
                    {"l_password", "Contraseña:"},
                    {"l_port", "Puerto:"},
                    {"bt_selectdir", "SeleccionarCarpeta"},
                    {"bt_start", "Iniciar"},
                    {"bt_stop", "Detener"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "Iniciar Servidor"},
                    {"tsmi_stop", "Detener Servidor"},
                    {"tsmi_exit", "Salir del Programa"},

                    {"InvaildPort","¡El puerto debe ser un número entre 1 y 65535!" },
                    {"EmptyWarningTitle","Advertencia de contraseña vacía" },
                    {"EmptyWarning","Estás utilizando un nombre de usuario y contraseña vacíos, lo que significa que todos los equipos de la red pueden acceder a tus archivos. ¿Estás seguro/a de que quieres continuar?" },
                }
            }},
            {"fr",new Language()
            {
                Name="fr",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Configuration"},
                    {"l_rootdir", "DossierRacine:"},
                    {"l_username", "NomUtilisateur:"},
                    {"l_password", "MotDePasse:"},
                    {"l_port", "Port:"},
                    {"bt_selectdir", "SélectionnerDossier"},
                    {"bt_start", "Démarrer"},
                    {"bt_stop", "Arrêter"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "Démarrer le serveur"},
                    {"tsmi_stop", "Arrêter le serveur"},
                    {"tsmi_exit", "Quitter le programme"},

                    {"InvaildPort","Le port doit être un nombre compris entre 1 et 65535 !" },
                    {"EmptyWarningTitle","Avertissement de mot de passe vide" },
                    {"EmptyWarning","Vous utilisez un nom d'utilisateur et un mot de passe vides, ce qui signifie que tous les ordinateurs du réseau peuvent accéder à vos fichiers. Êtes-vous sûr(e) de vouloir continuer?" },
                }
            }},
            {"de",new Language()
            {
                Name="de",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Konfiguration"},
                    {"l_rootdir", "Stammverzeichnis:"},
                    {"l_username", "Benutzername:"},
                    {"l_password", "Passwort:"},
                    {"l_port", "Port:"},
                    {"bt_selectdir", "OrdnerAuswählen"},
                    {"bt_start", "Starten"},
                    {"bt_stop", "Stoppen"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "ServerStarten"},
                    {"tsmi_stop", "ServerStoppen"},
                    {"tsmi_exit", "ProgrammBeenden"},

                    {"InvaildPort","Der Port muss eine Zahl zwischen 1 und 65535 sein!" },
                    {"EmptyWarningTitle","Warnung vor leerem Passwort" },
                    {"EmptyWarning","Sie verwenden einen leeren Benutzernamen und ein leeres Passwort, was bedeutet, dass alle Computer im Netzwerk auf Ihre Dateien zugreifen können. Sind Sie sicher, dass Sie fortfahren möchten?" },
                }
            }},
            {"pt",new Language()
            {
                Name="pt",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Configuração"},
                    {"l_rootdir", "PastaRaiz:"},
                    {"l_username", "NomeUsuário:"},
                    {"l_password", "Senha:"},
                    {"l_port", "Porta:"},
                    {"bt_selectdir", "SelecionarPasta"},
                    {"bt_start", "Iniciar"},
                    {"bt_stop", "Parar"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "Iniciar Servidor"},
                    {"tsmi_stop", "Parar Servidor"},
                    {"tsmi_exit", "Sair do Programa"},

                    {"InvaildPort","A porta deve ser um número entre 1 e 65535!" },
                    {"EmptyWarningTitle","Aviso de senha vazia" },
                    {"EmptyWarning","Você está usando um nome de usuário e senha vazios, o que significa que todos os computadores na rede podem acessar seus arquivos. Tem certeza de que deseja continuar?" },
                }
            }},
            {"ja",new Language()
            {
                Name="ja",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Configuration"},
                    {"l_rootdir", "RootFolder:"},
                    {"l_username", "ユーザー名:"},
                    {"l_password", "パスワード:"},
                    {"l_port", "ポート:"},
                    {"bt_selectdir", "フォルダーの選択"},
                    {"bt_start", "開始"},
                    {"bt_stop", "停止"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "サーバーの開始"},
                    {"tsmi_stop", "サーバーの停止"},
                    {"tsmi_exit", "プログラムの終了"},

                    {"InvaildPort","ポートは1から65535の間の数字である必要があります！" },
                    {"EmptyWarningTitle","空のパスワード警告" },
                    {"EmptyWarning","空のユーザー名とパスワードを使用しています。これにより、ネットワーク上のすべてのコンピュータがあなたのファイルにアクセスできます。続行してもよろしいですか？" },
                }
            }},
            {"ru",new Language()
            {
                Name="ru",
                Data=new Dictionary<string, string>()
                {
                    {"MainForm", "EasyFTPServer"},
                    {"gb_config", "Конфигурация"},
                    {"l_rootdir", "КорневаяПапка:"},
                    {"l_username", "ИмяПользователя:"},
                    {"l_password", "Пароль:"},
                    {"l_port", "Порт:"},
                    {"bt_selectdir", "ВыбратьПапку"},
                    {"bt_start", "Запуск"},
                    {"bt_stop", "Остановка"},
                    {"notifyIcon1", "EasyFTPServer"},
                    {"tsmi_start", "ЗапуститьСервер"},
                    {"tsmi_stop", "ОстановитьСервер"},
                    {"tsmi_exit", "Выход"},

                    {"InvaildPort","Порт должен быть числом от 1 до 65535!" },
                    {"EmptyWarningTitle","Предупреждение о пустом пароле" },
                    {"EmptyWarning","Вы используете пустое имя пользователя и пароль, что означает, что все компьютеры в сети могут получить доступ к вашим файлам. Вы уверены, что хотите продолжить?" },
                }
            }},
        };
    }

    public class Language
    {
        public string Name { get; set; }
        public Dictionary<string, string> Data { get; set; }
    }
}
