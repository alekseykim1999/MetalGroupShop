using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.WorkClasses
{
    public class FileWorker
    {
        public static List<string> readFile(int _group, int _album)
        {

            string path = "D:\\Институт\\MusicShopProject\\MusicShop\\wwwroot\\songs\\" + _group + "\\" + _album + ".txt";
            List<string> songs = new List<string>();
            using (StreamReader _sw = new StreamReader(path, Encoding.Default))
            {
                while (!_sw.EndOfStream)
                {
                    try
                    {
                        songs.Add(_sw.ReadLine());

                    }
                    catch
                    {

                    }

                }
                _sw.Close();
            }

            return songs;
        }
        
    }
}
