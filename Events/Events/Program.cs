﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Define a delegate
            // 2 - Define an event based on that delegate
            // 3 - Raise an event

            
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  // publisher
            var mailService = new MailService();    // subscriber
            var messageService = new MessageService();  //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);

        }
    }

    
}
