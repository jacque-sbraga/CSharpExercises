using CsvFile.Entities;
using System.Globalization;

namespace CsvFile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string basePath = @"C:\Users\Jacqueline Braga\Desktop";
            string sourcePath = basePath + @"\products.csv";
            string targetPath = basePath + @"\out\summary.csv";
            
            
            List<Product> products = new List<Product>();
            FileInfo fileInfo = new FileInfo(sourcePath);

            Directory.CreateDirectory(basePath + @"\out");
            fileInfo.CopyTo(targetPath);
            try
            {
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] csvValues = sr.ReadLine()!.Split(";");

                        products.Add(new Product
                        {
                            Name = csvValues[0],
                            Price = Convert.ToDouble(csvValues[1], CultureInfo.InvariantCulture),
                            Quantity = Convert.ToInt32(csvValues[2])
                        });
                    }
                }
                using (StreamWriter sw = File.CreateText(targetPath)) 
                {
 
                    foreach (Product product in products)
                    {
                        sw.WriteLine(product.Name + ";"+ (product.Quantity*product.Price));
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
