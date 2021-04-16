using MusicShop.Interfaces;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShop.WorkClasses
{
    public class SoundConverter :IConvertable
    { 
        public StringBuilder ConvertSound(string _path)
        {
            StringBuilder notes = new StringBuilder();
            using (var rdr = new AudioFileReader("E:\\Дипломная работа\\MusicShopProject\\MusicShop\\audio3.wav"))
            {
                int steps = 100;
                int stepSize = (int)rdr.Length / steps;
                byte[] bytesBuffer = new byte[rdr.Length];
                int read = rdr.Read(bytesBuffer, 0, stepSize);
                var floatSamples = new double[read / 2];
                for (int sampleIndex = 0; sampleIndex < read / 2; sampleIndex += 2)
                {
                    var intSampleValue = BitConverter.ToInt16(bytesBuffer, sampleIndex * 2);
                    double result = intSampleValue / 32768.0;
                    switch (result)
                    {
                        case 0:
                            break;
                        case -0.5:
                            notes.Append("C ");
                            break;
                        case 0.5:
                            notes.Append("D ");
                            break;
                        case -0.75:
                            notes.Append("E ");
                            break;
                        case -0.625:
                            notes.Append("G ");
                            break;
                        case -0.375:
                            notes.Append("H ");
                            break;
                        case 0.25:
                            notes.Append("A ");
                            break;
                        case 0.125:
                            notes.Append("F ");
                            break;
                        case 0.875:
                            notes.Append("B ");
                            break;
                        case -0.25:
                            notes.Append("C# ");
                            break;
                        case 1:
                            break;
                    }
                }
            }
            return notes;
        }
    }
}
