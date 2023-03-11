using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class SoldProductsRepo : ISoldProducts
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public SoldProductsRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SoldProducts>> GetSoldProducts()
        {
            var MMD = await _context.SoldProducts.ToListAsync();
            return MMD;
        }

        public async Task<SoldProducts> GetxId(int Id)
        {
            var MMD = await _context.SoldProducts.FirstOrDefaultAsync(x => x.IdSoldProduct == Id);
            return MMD;
        }

        public async Task Post(SoldProducts MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(SoldProducts MMD)
        {
            var dat = await GetxId((int)MMD.IdSoldProduct);

            dat.IdxServiceGiven = MMD.IdxServiceGiven;
            dat.IdxProduct = MMD.IdxProduct;
            dat.Quantity = MMD.Quantity;
            dat.TotalCost = MMD.TotalCost;
            
            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.SoldProducts.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
