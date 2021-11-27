using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
