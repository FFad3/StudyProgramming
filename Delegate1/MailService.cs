using System;

namespace Delegate1
{
    public class MailService
    {
        public void OnVideoEncoded(object sourc, VideoEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Tittle);
        }
    }
}
