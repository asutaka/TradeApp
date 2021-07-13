using System.Collections.Generic;

namespace TheLast.Model
{
    public class CryptonDataModel
    {
        public List<CryptonDetailDataModel> Data { get; set; }
    }
    public class CryptonDetailDataModel
    {
        public string S { get; set; }
        public string AN { get; set; }
    }
}
