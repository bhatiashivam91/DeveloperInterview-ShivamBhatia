using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                if (args == null || args.Length !=2 )
                {
                    Console.WriteLine("Invalid Args");
                }
                else
                {
                    IFile file = new File();
                    Console.WriteLine(file.PrintFileDetails(args));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
