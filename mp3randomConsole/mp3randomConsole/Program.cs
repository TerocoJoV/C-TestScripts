using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mp3randomConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string locatieMP3 = @"D:\MP3\_notcheck";
            string locatieUSB = @"E:\Random2\";
            int aantal = 500;
            /*
            locatieMP3 = @"D:\MP3\_check\__punk rock";
            locatieUSB = @"E:\punkrock\";
            aantal = 50;
            *//*
            locatieMP3 = @"D:\MP3\MP3 - sorted\ska";
            locatieUSB = @"E:\ska\";
            aantal = 50;
            *//*

            locatieMP3 = @"D:\MP3\MP3 - sorted\Rock";
            locatieUSB = @"E:\rock\";
            aantal = 50;
            */

            
            //locatieMP3 = @"D:\MP3\MP3 - sorted\other";
            //locatieMP3 = @"D:\MP3\MP3 - sorted\alternative";
            //locatieUSB = @"E:\other\";
            //aantal = 50;


            //DateTime test = new DateTime(2001, 03, 01);
            

            //Console.WriteLine(test.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("nl-BE")));
            //Console.ReadLine();
            
            var rand = new Random();
            string[] aAllFiles = mp3(locatieMP3);

            for (int i = 0; i < aantal; i++)
            {
                var mp3 = aAllFiles[rand.Next(aAllFiles.Length)];
                Console.WriteLine(mp3);
                CopyFiles(mp3, locatieUSB);
            }

            Console.WriteLine("DONE");
            Console.ReadKey();
        }


        static string[] mp3(string locatieMP3)
        {

            var files = Directory.GetFiles(locatieMP3, "*.mp3", SearchOption.AllDirectories);

            Console.WriteLine(files.GetType().ToString());

            return files;
        }



        static void CopyFiles(string file, string locatieUSB)
        {
            string onlyName = file.Split('\\').Last();


            if (!Directory.Exists(locatieUSB))
                Directory.CreateDirectory(locatieUSB);
            try
            {


                File.Copy(file, locatieUSB + onlyName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            


        }
    }
}
