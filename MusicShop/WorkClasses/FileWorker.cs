using MusicShop.Interfaces;
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
        public static List<string> readFileSongs(int _group, int _album)
        {
            string path = "E:\\Дипломная работа\\MusicShopProject\\MusicShop\\wwwroot\\songs\\" + _group + "\\" + _album + ".txt";
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


        public static async Task<string> readFileReview(int _group, int _album)
        {
            string path = "E:\\Дипломная работа\\MusicShopProject\\MusicShop\\wwwroot\\reviews\\" + _group + "\\" + _album + ".txt";
            string review="";
            using (StreamReader _sw = new StreamReader(path, Encoding.Default))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                       review = await sr.ReadToEndAsync();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return await Task.FromResult(review);
        }

        public static void CreateData(int _numGroup, int _numAlbum, string text)
        {
            string path = "E:\\Дипломная работа\\MusicShopProject\\MusicShop\\wwwroot\\reviews\\" + _numGroup + "\\" + _numAlbum + ".txt";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
            {
                sw.WriteAsync("\n>>>\n" + text);

            }
        }


        internal static string readFileReviews(int idgroup, int idAlbum)
        {
            throw new NotImplementedException();
        }
    }
}
