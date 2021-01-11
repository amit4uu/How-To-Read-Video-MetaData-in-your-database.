using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GleamTech.VideoUltimate;
using System.Web.Mvc;
using Videodetail.Models;
using System.IO;

namespace Videodetail.Controllers
{
    public class VideoController : Controller
    {
        VideoDetailsEntities db = new VideoDetailsEntities();
        // GET: Video
        public ActionResult Index()
        {
            string root = @"E:\VidCheck";
            string[] VidEntries = Directory.GetFiles(root);
            foreach (string VidFiles in VidEntries)
            {
                
                using (var VideoFrameReader= new VideoFrameReader(VidFiles))
                {
                    var Duration = VideoFrameReader.Duration;
                    var Width = VideoFrameReader.Width;
                    var Height = VideoFrameReader.Height;
                    var CodecName = VideoFrameReader.CodecName;
                    var CodecTag = VideoFrameReader.CodecTag;
                    var BitRate = VideoFrameReader.BitRate;
                    var FrameRate = VideoFrameReader.FrameRate;
                    var CodecDescription = VideoFrameReader.CodecDescription;



                    VideoDetail video = new VideoDetail();
                    video.Length = Duration.ToString();
                    video.FrameWidth = Width.ToString();
                    video.FrameHeight = Height.ToString();
                    video.CodecName = CodecName.ToString();
                    video.CodecTag = CodecTag.ToString();
                    video.BitRate = BitRate.ToString();
                    video.FrameRate = FrameRate.ToString();
                    video.CodecDescription = CodecDescription.ToString();
                    db.VideoDetails.Add(video);
                }
            
                db.SaveChanges();
            }
            return View();
           
        }

    }
}