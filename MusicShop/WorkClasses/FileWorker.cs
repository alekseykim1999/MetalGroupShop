using Microsoft.AspNetCore.Hosting;
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
        private IHostingEnvironment env;
        public FileWorker(IHostingEnvironment _environment)
        {
            this.env = _environment;
        }
        public List<string> readFileSongs(int _group, int _album)
        {
            string path = this.env.WebRootPath + "/songs/" + _group + "/" + _album + ".txt";
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


        public async Task<string> readFileReview(int _group, int _album)
        {
            string path = this.env.WebRootPath + "/reviews/" + _group + "/" + _album + ".txt";
            string review="";
            using (StreamReader _sw = new StreamReader(path, Encoding.Default))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                       review = await sr.ReadToEndAsync();
                       review.Replace(">>>", "\n"); 
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return await Task.FromResult(review);
        }

        public async void CreateData(int _numGroup, int _numAlbum, string text)
        {
            string path = this.env.WebRootPath + "/reviews/" + _numGroup + "/" + _numAlbum + ".txt";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                await sw.WriteAsync("\n>>>\n"+text);

            }
        }
        internal static string readFileReviews(int idgroup, int idAlbum)
        {
            throw new NotImplementedException();
        }
    }
}
