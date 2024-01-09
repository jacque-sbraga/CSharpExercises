using Microsoft.Extensions.Configuration;
using OpenPop.Mime;
using OpenPop.Pop3;

namespace EmailCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IConfigurationBuilder builder = new ConfigurationBuilder()
            .SetBasePath(@"C:\myRobots\config\")
            .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            Pop3Client client = new Pop3Client();
            List<Message> messages = new List<Message>();

            string hostname = configuration["hostname"];
            int port = Convert.ToInt32(configuration["port"]);
            bool ssl = Convert.ToBoolean(configuration["ssl"]);
            string username = configuration["username"];
            string password = configuration["password"];

            
            
            client.Connect(hostname, port, ssl);
            client.Authenticate(username, password);


            messages = DownloadMail(client);

            ReadMail(messages);
        }

        static public List<Message> DownloadMail(Pop3Client client) {
            int messageCount = client.GetMessageCount();
            List<Message> messages = new List<Message>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            
            for (int i = 1; i <= messageCount; i++)
            {
                messages.Add(client.GetMessage(i));
                
            }
            return messages;
        }

        static List<string> ReadMail(List<Message> messages)
        {
            List<string> readMails = new List<string>();
            foreach (Message message in messages)
            {
                Console.WriteLine(message.Headers.Subject);
                readMails.Add(message.Headers.Subject);
            }

            return readMails;
        }

    }
}
