using System.Collections.Generic;
using FacebookApi.Enums;
using FacebookApi.Enums.Api;
using RestSharp.Deserializers;

namespace FacebookApi.Entities
{
    public class AdCreativeTemplateURLSpec
    {
        public AdCreativeAndroidData android { get; set; }
        public AdCreativeConfigData config { get; set; }
        public AdCreativeIosData ios { get; set; }
        public AdCreativeIphoneData ipad { get; set; }
        public AdCreativeIpadData iphone { get; set; }
        public AdCreativeWebData web { get; set; }
        public AdCreativeWindowsPhoneData windows_phone { get; set; }
    }
}
