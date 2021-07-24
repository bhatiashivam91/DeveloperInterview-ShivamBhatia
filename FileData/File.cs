using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class File : IFile
    {
        private FileDetails fileDetails;

        public File()
        {
            fileDetails = new FileDetails();
        }

        public string PrintFileDetails(string[] args)
        {
            var versionStr = new List<string>() { "-v", "--v", "/v", "--version" };
            var sizeStr = new List<string>() { "-s", "--s", "/s", "--size" };

            if (versionStr.Contains(args.First().ToLower()))
            {
                return PrintVersion(args.Last());
            }
            else if (sizeStr.Contains(args.First().ToLower()))
            {
                return PrintSize(args.Last());
            }
            else
            {
                string str = "Invalid Args";
                return str;
            }
        }

        private string PrintSize(string filePath)
        {
            var info = fileDetails.Size(filePath);
            return info.ToString();
        }

        private string PrintVersion(string filePath)
        {
            var info = fileDetails.Version(filePath);
            return info;
        }
    }
}
