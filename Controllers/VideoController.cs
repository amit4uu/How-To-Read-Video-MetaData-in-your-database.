using GleamTech.VideoUltimate;
using System.Web.Mvc;
using Videodetail.Models;
using System.IO;
using System.Collections.Generic;

namespace Videodetail.Controllers
{
    public class VideoController : Controller
    {
        VideoDetailsEntities1 db = new VideoDetailsEntities1();
        // GET: Video
        public ActionResult Index()
        {

            string root = @"E:\VidCheck";
            string[] VidEntries = Directory.GetFiles(root);
            foreach (string VidFiles in VidEntries)
            {

                using (var VideoFrameReader = new VideoFrameReader(VidFiles))
                {
                    var Duration = VideoFrameReader.Duration;
                    var Width = VideoFrameReader.Width;
                    var Height = VideoFrameReader.Height;
                    var CodecName = VideoFrameReader.CodecName;
                    var CodecTag = VideoFrameReader.CodecTag;
                    var BitRate = VideoFrameReader.BitRate;
                    var FrameRate = VideoFrameReader.FrameRate;
                    var CodecDescription = VideoFrameReader.CodecDescription;
                    var CurrentFrameNumber = VideoFrameReader.CurrentFrameNumber;

                    /*VideoDetail1 viewModel = new VideoDetail1();
                    viewModel.DictionaryTest = new Dictionary<string, string>();
                    viewModel.DictionaryTest.Add("key1", "value1");
                    viewModel.DictionaryTest.Add("key2", "value2");*/

                    VideoDetail video = new VideoDetail();
                    video.Length = Duration.ToString();
                    video.FrameWidth = Width.ToString();
                    video.FrameHeight = Height.ToString();
                    video.CodecName = CodecName.ToString();
                    video.CodecTag = CodecTag.ToString();
                    video.BitRate = BitRate.ToString();
                    video.FrameRate = FrameRate.ToString();
                    video.CodecDescription = CodecDescription.ToString();
                    video.CurrentFrameNumber = CurrentFrameNumber.ToString();
                    db.VideoDetails.Add(video);
                }

                db.SaveChanges();
            }
            return View();

        }

    }
}