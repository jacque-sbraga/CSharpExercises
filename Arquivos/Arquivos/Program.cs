using System.IO;
using System.Timers;

namespace Arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Jacqueline Braga\Desktop\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            //string targetPath = @"C:\Users\Jacqueline Braga\Desktop\file2.txt";

            try
            {
                // Forma completa de como utilizar FileStream/StreamReader:
                //fs = new FileStream(sourcePath, FileMode.Open);
                //sr = new StreamReader(fs);

                /* Forma simplificada de criar um StreamReader:
                 * O File.OpenText, já instancia o FileStrem e
                 * StreamReader implicitamente
                */
                //sr = File.OpenText(sourcePath); 

                // Tudo que estiver dentro do bloco using será executado e ao
                // final o recurso instanciado será encerrado.
                using (FileStream fs = new FileStream(sourcePath, FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(fs))
                    {
                        while (!reader.EndOfStream)
                        {
                            Console.WriteLine(reader.ReadLine());

                        }
                    }
                }

                //Ler o arquivo até o final
                /*while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());

                }
                */
                // Demo - File e FileInfo:
                /*FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                */

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            /*finally
            {
                // É necessário fechar a stream manualmente:
                if (fs != null) { 
                    fs.Close();
                }
                
                if (sr != null) { 
                    sr.Close();
                }
            }
            */
        }
    }
}
