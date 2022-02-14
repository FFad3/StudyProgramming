using System;

namespace Delegate1
{
    public class TextService
    {
        public void OnVideoEncoded(object sourc, VideoEventArgs e)
        {
            Console.WriteLine("TextService: Sending an message..." + e.Video.Tittle);
        }
    }
}
