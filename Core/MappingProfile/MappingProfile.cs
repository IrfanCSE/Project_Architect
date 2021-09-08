using AutoMapper;
using Core.DTO.Procurement;

namespace Core.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            string[] pre = { "str", "dte", "int", "num", "mon" };
            RecognizePrefixes(pre);
            CreateMap<Core.Models.Read.TblPurchaseOrderHeader, GetPurchaseOrderDTO>().ReverseMap();
        }
    }
}