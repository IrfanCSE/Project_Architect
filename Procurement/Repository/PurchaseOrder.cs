using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.DbContexts;
using Core.DTO.Procurement;
using Core.IRepository.Procurement;
using Microsoft.EntityFrameworkCore;

namespace Procurement.Repository
{
    public class PurchaseOrder : IPurchaseOrder
    {
        private readonly ReadDbContext _contextR;
        private readonly IMapper _mapper;
        public PurchaseOrder(ReadDbContext contextR, IMapper mapper)
        {
            _mapper = mapper;
            _contextR = contextR;

        }
        public async Task<List<GetPurchaseOrderDTO>> GetPurchaseOrderList()
        {
            try
            {
                var data = await _contextR.TblPurchaseOrderHeaders.Where(x => x.IsActive == true).Take(100).ToListAsync();

                return _mapper.Map<List<GetPurchaseOrderDTO>>(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}