using AutoMapper;
using TheLast.Common;
using TradeApp.Model;

namespace TradeApp.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<ElementModel, GeneralModel>()
                .ForMember(dest => dest.Indicator, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.High, opt => opt.MapFrom(src => src.Id == (int)enumChooseData.MACD? src.Value / 10000 : 0))
                .ForMember(dest => dest.Low, opt => opt.MapFrom(src => src.Id == (int)enumChooseData.MACD ? int.Parse(src.Value.ToString().Substring(2, 2)) : 0))
                .ForMember(dest => dest.Signal, opt => opt.MapFrom(src => src.Id == (int)enumChooseData.MACD ? src.Value % 10000 : 0))
                .ForMember(dest => dest.Period, opt => opt.MapFrom(src => src.Id == (int)enumChooseData.MACD ? 0 : src.Value ));
        }
    }
}
