using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemleri
{
    class DirectoryTest
    {
        static void Main()
        {
            //gerekli dosya konumlarını tanımlıyoruz.
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini";
            try
            {
                //exist static metodu ile dizinin var olup olmadıgının kontrolü
                if (!Directory.Exists(path))
                {
                    //createdirectory metodu ile dizin oluşturma işlemi
                    Directory.CreateDirectory(path);
                    Console.WriteLine("olusturulma tarihi : " + Directory.GetCreationTime(path));
                    Console.WriteLine("son erisim tarihi : " + Directory.GetLastAccessTime(path));
                    Console.WriteLine("son degistirilme tarihi : " + Directory.GetLastWriteTime(path));
                    Console.WriteLine("bulundugu dizinin  adı : " + Directory.GetParent(path));
                    Console.ReadLine();
                }
                if (Directory.Exists(target))
                {
                    //delete medtodu il dizin silme işlemi
                    Directory.Delete(target, true);
                }
                //move metodu ile dizini tasıma islemi
                Directory.Move(path, target);
                //getdirectory ile dizindeki klasörlerin seçimi
                string[] directories = Directory.GetDirectories(@"C:\Test\");
                foreach(string dir in directories)
                {
                    Console.WriteLine(dir);
                }
                //yeni bir metin belgesi olusturma
                File.CreateText(target + @"\NewFile.txt");
                //getfiles ile dizindeki dosyaların secimi
                Console.WriteLine("{0} dizinindeki dosya sayısı {1} ", target, Directory.GetFiles(target));
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("islem basarısız: {0} ", e.ToString());
            }
            finally { }
        }
    }
}
