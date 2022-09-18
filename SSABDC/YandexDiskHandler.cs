using YandexDiskNET;

namespace SSABDC
{
    public static class YandexDiskHandler
    {
        static string oauth = "y0_AgAAAAAo0zfGAAhrwgAAAADPIFLWaYFs6bSySjy8D9eHDud4uUDcqb0";
        public static void Test()
        {
            YandexDiskRest disk = new YandexDiskRest(oauth);
            DiskInfo diskInfo = disk.GetDiskInfo();

            DiskInfo diskInfoFeilds = disk.GetDiskInfo(new DiskFields[] {
                //DiskFields.Is_paid,
                //DiskFields.Max_file_size,
                //DiskFields.System_folders,
                DiskFields.Total_space,
                ////DiskFields.Trash_size,
                //DiskFields.Unlimited_autoupload_enabled,
                DiskFields.Used_space,
                DiskFields.User
            });
            if (diskInfoFeilds.ErrorResponse.Message == null)
                Console.WriteLine("User: {0}\nTotal: size {1} bytes\nUsed: {2} bytes", diskInfoFeilds.User.Login, diskInfoFeilds.Total_space, diskInfoFeilds.Used_space);
            else
                Console.WriteLine("No connect to disk");
        }
        public static List<string> GetFiles()
        {
            List<string> files = new List<string>();
            YandexDiskRest disk = new YandexDiskRest(oauth);
            ResInfo filesByNameFields = disk.GetResourceByName(
                1000000,
                new Media_type[]
                {
                    Media_type.Audio,
                    Media_type.Backup,
                    Media_type.Compressed,
                    Media_type.Book,
                    Media_type.Data,
                    Media_type.Development,
                    Media_type.Diskimage,
                    Media_type.Document,
                    Media_type.Encoded,
                    Media_type.Executable,
                    Media_type.Flash,
                    Media_type.Font,
                    Media_type.Image,
                    Media_type.Settings,
                    Media_type.Spreadsheet,
                    Media_type.Text,
                    Media_type.Unknown,
                    Media_type.Video,
                    Media_type.Web
                },
                SortField.Path,
                new ResFields[] {
                    //ResFields.Antivirus_status,
                    //ResFields.Created,
                    //ResFields.Md5,
                    //ResFields.Media_type,
                    //ResFields.Mime_type,
                    //ResFields.Modified,
                    //ResFields.Name,
                    ResFields.Path,
                    //ResFields.Preview,
                    //ResFields.Public_key,
                    //ResFields.Public_url,
                    //ResFields.Sha256,
                    //ResFields.Size,
                    //ResFields.Type,
                    //ResFields._Embedded
                },
                0, true, "120x240"
                );
            if (filesByNameFields.ErrorResponse.Message == null)
            {
                Console.WriteLine("{0} - {1}", filesByNameFields.Name, filesByNameFields.Type);

                if (filesByNameFields._Embedded.Items.Count != 0)
                    foreach (var s in filesByNameFields._Embedded.Items)
                        files.Add(s.Path);
            }
            else
                Console.WriteLine(filesByNameFields.ErrorResponse.Message);
            Console.WriteLine("Count of files -" + files.Count);
            return files;
        }

        public static void DownloadFile(string filename, int level)
        {
            string sourceFileName = $"Ecnrypted/{filename}";
            string destFileName = $"C:\\Temp\\{Converts.GetStringFromLevel(level)}\\{filename}";

            YandexDiskRest disk = new YandexDiskRest(oauth);

            var err = disk.DownloadResource(sourceFileName, destFileName);

            if (err.Message == null)
            {
                Console.WriteLine("Success downloaded {0}", Path.GetFileName(sourceFileName) + "\r\n");
                File.Decrypt($"C:\\Temp\\{Converts.GetStringFromLevel(level)}\\{filename}");
            }
            else
                Console.WriteLine(err.Message + "\r\n");
        }

        public static void UploadFile(string filePath, int level)
        {
            string sourceFileName = $"Ecnrypted/{Converts.GetStringFromLevel(level)}/{Path.GetFileName(filePath)}";
            string destFileName = filePath;

            YandexDiskRest disk = new YandexDiskRest(oauth);

            var err = disk.UploadResource(sourceFileName, destFileName);
            if (err.Message == null)
                Console.WriteLine("Success uploaded {0}", Path.GetFileName(sourceFileName) + "\r\n");
            else
                Console.WriteLine(err.Message + "\r\n");
        }
    }
}
