using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.SimleForm.Helpers
{
    public static class ImageWorker
    {
        /// <summary>
        /// Збереження фото в папку
        /// </summary>
        /// <param name="url">Адреса фото в мережі</param>
        /// <returns>Повертаємо назву фото</returns>
        public static string ImageSave(string url, string imageName=null)
        {
            try
            {
                using(HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;
                    //список байт фото
                    byte[] imageBytes = response.Content.ReadAsByteArrayAsync().Result;
                    int size = 1200; //розмір фото, яке буде зберігатися
                    //Рандомна величина, яка не може повторится при генерації
                    string fileName = imageName ?? Guid.NewGuid().ToString() + ".png";
                    var dir = Path.Combine(Directory.GetCurrentDirectory(), "Pictures");
                    if(!Directory.Exists(dir))
                    {
                        Directory.CreateDirectory(dir);
                    }
                    var outPath = Path.Combine(dir, fileName);
                    using (SixLabors.ImageSharp.Image image = SixLabors.ImageSharp.Image.Load(imageBytes))
                    {
                        image.Mutate(x =>
                        {
                            x.Resize(new ResizeOptions
                            {
                                Size = new SixLabors.ImageSharp.Size(size, size),
                                Mode = ResizeMode.Max
                            });
                        });
                        using (var ms = new MemoryStream())
                        {
                            image.Save(ms, new PngEncoder());
                            var bytesOut = ms.ToArray();
                            File.WriteAllBytes(outPath, bytesOut);
                            return fileName;
                        }
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Помилка збереження фото {0}", ex.Message);
            }
            return null;
        }
    }
}
