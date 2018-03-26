using System;
using System.Net;
using System.IO;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace JTTT
{
    public class Task
    {
        public string urlPage="default";
        public string textLookingFor = "default";
        public string adressMail = "default";
        public string nameOfTask = "default";
        public string imageName = "default";

        public int actionTypeIndex;
        public int conditionTypeIndex;

        //public object ActionType { get { return actionType; } set { if (value == null) conditionType = "default"; } }
        //public object ConditionType { get { return conditionType; } set { if (value == null) conditionType = "default"; } }

        public void DoAction()
        {
            if (actionTypeIndex == 0)
            {
                SendMail();
            }
            else if (actionTypeIndex == 1)
            {
                Uri u = new Uri(imageName);
                if (Task.DownloadRemoteImageFile(u.ToString(), "obrazekZapisany.jpg") == false)
                    MessageBox.Show("Obraz nie został pobrany poprawnie", "Bład podczas pobierania obrazu!");
            }
            else
            {
                MessageBox.Show("To nie powinno się pojawić.");
            }
        }


        public override string ToString()
        {
            string textTemp = urlPage + "_" + textLookingFor + "_" + adressMail + "_" + nameOfTask;

            return textTemp;
        }
        /// <summary>
        /// KLASSA do warunku i klasa do akcji
        /// </summary>
        /// <param name="isCaseSensitive"></param>
        /// <returns></returns>
        public string SearchForPicture(bool isCaseSensitive)
        {
            var doc = new HtmlAgilityPack.HtmlDocument();

            var html = new WebClient();
 
            var pageHtml = html.DownloadString(this.urlPage);

            if (isCaseSensitive)
            {
                doc.LoadHtml(pageHtml);
            }
            else
            {
                doc.LoadHtml(pageHtml.ToLower());
            }

            var nodes = doc.DocumentNode.Descendants("img");

            string image = "default";

            if (conditionTypeIndex == 0)
            {
                foreach (var node in nodes)
                {
                    Console.WriteLine("---------");

                    if (node.GetAttributeValue("alt", "").Contains(textLookingFor))
                    {
                        image = node.GetAttributeValue("src", "");
                        break;
                    }
                }
                return image;
            }
            else if(conditionTypeIndex == 1)
            {
                foreach (var node in nodes)
                {
                    if (node.GetAttributeValue("href", "").Contains(textLookingFor))
                    {
                        imageName = node.GetAttributeValue("src", "");
                        break;
                    }
                }
                return image;
            }
            else
            {
                MessageBox.Show("To nie powinno się pojawić.");
                return "error";
            }
        }

        private bool SendMail()
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Nadawca", "konto.net.laby@gmail.com"));
                message.To.Add(new MailboxAddress("Adresat", this.adressMail));
                message.Subject = "W załączniku przesyłam zdjęcie";

                var builder = new BodyBuilder();

                message.Body = new TextPart("plain")
                { Text = @"Hey Grzesiek,

                Wysyłam maila z załącznkiem z poziomu programu.

                Kuba
                " };
                builder.Attachments.Add(@"obrazek.jpg");
                message.Body = builder.ToMessageBody();


                using (var client = new SmtpClient())
                {
                    client.ServerCertificateValidationCallback = (s, c, h, j) => true;

                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.Auto);

                    client.AuthenticationMechanisms.Remove("XOAUTH2");

                    client.Authenticate("konto.net.laby", "dotnetlab");

                    client.Send(message);
                    client.Disconnect(true);

                    MessageBox.Show("Mail został wysłany poprawnie", "Potwiedzenie wysłania maila");
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail NIE został wysłany poprawnie. Treść błędu:" + ex.Message, "Błąd przy wysyłaniu maila");
                //throw ex;
                return false;
            }
        }

        
        public static bool DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }

            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                response.ContentType.StartsWith("image", StringComparison.OrdinalIgnoreCase))
            {

                // if the remote file was found, download it
                using (Stream inputStream = response.GetResponseStream())
                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);
                        outputStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead != 0);
                }
                return true;
            }
            else
                return false;
        }

    }
}
