using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Videodetail.Models
{
    public class VideoInfoModel
    {
        public VideoInfoModel()
        {
            Properties = new Dictionary<string, string>();
            Metadata = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Properties { get; }

        public Dictionary<string, string> Metadata { get; }
    }


    public class VideoDetail1
    {
        public int FileId { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string CodecName { get; set; }
        public string CodecDescription { get; set; }
        public string CodecTag { get; set; }
        public string BitRate { get; set; }
        public string FrameRate { get; set; }

        public Dictionary<string, string> DictionaryTest { get; set; }

    }

    public class Property1
    {
        public int FileId { get; set; }
        public Nullable<System.TimeSpan> Duration { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string CodecName { get; set; }
        public string CodecDescription { get; set; }
        public string CodecTag { get; set; }
        public string BitRate { get; set; }
        public string FrameRate { get; set; }



        public IEnumerable<Metadata> metadatas { get; set; }

        public IEnumerable<Metadatainfo> metadatainfos { get; set; }
    }

    public class Metadata
    {
        public int Key { get; set; }

        public string value { get; set; }

    }

    public class Metadatainfo
    {
        public string MajorBrand { get; set; }
        public string MinorVersion { get; set; }
        public string CompatibleBrands { get; set; }
        public string Encoder { get; set; }

    }
}
