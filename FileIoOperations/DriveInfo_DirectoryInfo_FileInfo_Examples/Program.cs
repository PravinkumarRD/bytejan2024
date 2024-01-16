namespace DriveInfo_DirectoryInfo_FileInfo_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Examples of DriveInfo, DirectoryInfo and FileInfo classes!");

            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.DriveType == DriveType.Removable)
                {
                    Console.WriteLine("This is removable drive!");
                }
                Console.WriteLine(drive.DriveType);
                Console.WriteLine(drive.Name);
                DirectoryInfo directoryInfo = new DirectoryInfo(drive.Name);
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    Console.WriteLine(directory.Name);
                    try
                    {
                        foreach (var fileInfo in directory.GetFiles())
                        {
                            Console.WriteLine(fileInfo.Name);
                        }
                    }
                    catch (UnauthorizedAccessException uae)
                    {
                        Console.WriteLine(uae.Message);
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                
            }
        }
    }
}
