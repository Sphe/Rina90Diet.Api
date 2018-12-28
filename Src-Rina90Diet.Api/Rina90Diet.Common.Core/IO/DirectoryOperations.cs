using System.IO;

namespace Rina90Diet.Common.Core
{
    public class DirectoryOperations
    {
        public static void CheckForCreateDirectory(string pathDir)
        {
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
        }
    }
}
