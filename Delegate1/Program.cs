using System;

namespace Delegate1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Tittle = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var textService = new TextService(); //subscriber

            //subscription of the event
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }

}
