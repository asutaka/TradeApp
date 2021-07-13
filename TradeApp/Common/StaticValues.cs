using AutoMapper;
using System.Collections.Generic;
using TheLast.Model;
using TradeApp.Mapping;

namespace TheLast.Common
{
    public class StaticValues
    {
        public static BasicSettingModel basicModel = 0.LoadBasicJson();
        public static AdvanceSettingModel advanceModel = 0.LoadAdvanceJson();
        public static List<CryptonDetailDataModel> lstCoin = SeedData.GetCryptonList();
        public static Mapper MapperConfig = new Mapper(new MapperConfiguration(config => { config.AddProfile(new MapProfile()); }));
    }
}
