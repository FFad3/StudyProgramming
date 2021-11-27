﻿using System;
using System.Threading;

namespace Delegate1
{
    public class VideoEventArgs:EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // 2- Define an event based on that delegate
        // 3- Raise the event

        // 1- Defined delegate
            //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //shorter options for delegates
        // EventHandler
        // EventHandler<TEventArgs>

        // 2- Define an event based on that delegate
            //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video....");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video=video});
        }
    }
}