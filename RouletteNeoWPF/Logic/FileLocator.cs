using System.IO;
using System.Linq;

namespace RouletteNeoWPF.Logic
{
    public static class FileLocator
    {
        public static string TickSoundLocation(string currentPath = null)
        {
            DirectoryInfo soultionDirectory = new DirectoryInfo(currentPath ?? Directory.GetCurrentDirectory());

            while (soultionDirectory != null && !soultionDirectory.GetFiles("*.sln").Any())
            {
                soultionDirectory = soultionDirectory.Parent;
            }

            string fileLocation = soultionDirectory.FullName.ToString() + $@"\RouletteNeoWPF\Resources\tick.wav";

            return fileLocation;
        }
    }
}
