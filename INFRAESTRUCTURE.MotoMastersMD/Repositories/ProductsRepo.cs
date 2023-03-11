using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class ProductsRepo : IProducts
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public ProductsRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> GetProducts()
        {
            var MMD = await _context.Products.ToListAsync();
            return MMD;
        }

        public async Task<Products> GetxId(int Id)
        {
            var MMD = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == Id);
            return MMD;
        }

        public async Task Post(Products MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Products MMD)
        {
            var dat = await GetxId((int)MMD.ProductId);

            dat.IdxCategorie = MMD.IdxCategorie;
            dat.Product = MMD.Product;
            dat.CostByUnit = MMD.CostByUnit;
            dat.Quantity = MMD.Quantity;
            dat.Status = MMD.Status;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.Products.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
