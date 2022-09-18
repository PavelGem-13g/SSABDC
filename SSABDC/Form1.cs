using System.DirectoryServices;
using System.Security.Policy;

namespace SSABDC
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        
        private List<FileInformation> filesInformation;

        private int level;
        private string encryptionCode;

        public int Level { get { return level; } }
        public Form1()
        {
            instance = this;
            InitializeComponent();
            level = 1;
            filesInformation = new List<FileInformation>();
            YandexDiskHandler.Test();
            UpdateFiles();
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            using (AddFile addFile = new AddFile()) 
            {
                addFile.Owner = this;
                addFile.ShowDialog();
            }

        }

        public void SetLevel(int level) 
        {
            instance.level = level;
        }
        public void SetUserName(string username) 
        {
            instance.label1.Text = username;
        }
        public void SetEncryptionCode(string code) 
        {
            encryptionCode = code;
            label2.Text = "Encryption code: "+encryptionCode;
        }
        public void AddFile(string filePath, int level) 
        {
            filesInformation.Add(new FileInformation(filePath, true, level));
            File.Copy(filePath, $"C:\\Temp\\{Converts.GetStringFromLevel(level)}\\{Path.GetFileName(filePath)}", true);
            File.Copy(filePath, $"C:\\Temp\\Operations\\{Path.GetFileName(filePath)}", true);
            if (level == 2)
            {
                MessageBox.Show("Crypto");
                File.Encrypt($"C:\\Temp\\Operations\\{Path.GetFileName(filePath)}");
            }
            YandexDiskHandler.UploadFile($"C:\\Temp\\Operations\\{Path.GetFileName(filePath)}", level);
            UpdateTable();
        }
        public void UpdateFiles() 
        {
            filesInformation.Clear();
            List<string> files = YandexDiskHandler.GetFiles();
            foreach (string file in files) 
            {
                if (file.Contains("/Ecnrypted"))
                {
                    bool is_used = false;
                    if (file.Contains("/Open"))
                    {
                        filesInformation.Add(new FileInformation(Path.GetFileName(file), true, 1));
                        YandexDiskHandler.DownloadFile(Path.GetFileName(file), 1);
                    }
                    if (file.Contains("/Authorized") && level>=2)
                    {
                        filesInformation.Add(new FileInformation(Path.GetFileName(file), true, 2));
                        YandexDiskHandler.DownloadFile(Path.GetFileName(file), 2);
                    }
                    if (file.Contains("/Encryption") && level >= 3)
                    {
                        filesInformation.Add(new FileInformation(Path.GetFileName(file), true, 3));
                        YandexDiskHandler.DownloadFile(Path.GetFileName(file), 3);
                    }
                    if (file.Contains("/Biometrics") && level >= 4)
                    {
                        filesInformation.Add(new FileInformation(Path.GetFileName(file), true, 4));
                        YandexDiskHandler.DownloadFile(Path.GetFileName(file), 4);
                    }
                }
            }
            UpdateTable();
        }
        private void UpdateTable() 
        {
            dataGridView.Rows.Clear();
            foreach (var item in filesInformation)
            {
                dataGridView.Rows.Add(item.FileName, item.IsSynchronyzed, Converts.GetStringFromLevel(item.Type));
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (Login login = new Login())
            {
                login.Owner = this;
                login.ShowDialog();
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (EncryptionEnter encryptionEnter = new EncryptionEnter())
            {
                encryptionEnter.Owner = this;
                encryptionEnter.ShowDialog();
            }
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            using (BiometricsForm biometrics = new BiometricsForm())
            {
                biometrics.Owner = this;
                biometrics.ShowDialog();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateFiles();
        }
    }
    enum Levels {Base = 1, Authorized, Encryption, Biometrics}
    public static class Converts
    {
        public static int GetLevelFromString(string level) 
        {
            switch (level) 
            {
                case "Authorized":
                    return 2;
                case "Encryption":
                    return 3;
                case "Biometrics":
                    return 4;
            }
            return 1;
        }
        public static string GetStringFromLevel(int level)
        {
            switch (level)
            {
                case 2:
                    return "Authorized";
                case 3:
                    return "Encryption";
                case 4:
                    return "Biometrics";
            }
            return "Open";
        }
    }
}