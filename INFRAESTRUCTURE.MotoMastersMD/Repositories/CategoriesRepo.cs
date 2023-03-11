using CORE.MotoMastersMD.Entities;
using CORE.MotoMastersMD.Interfaces;
using INFRAESTRUCTURE.MotoMastersMD.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.MotoMastersMD.Repositories
{
    public class CategoriesRepo : ICategories
    {
        private readonly MOTO_MASTERS_MDContext _context;
        public CategoriesRepo(MOTO_MASTERS_MDContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Categories>> GetCategories()
        {
            var MMD = await _context.Categories.ToListAsync();
            return MMD;
        }

        public async Task<Categories> GetxId(int Id)
        {
            var MMD = await _context.Categories.FirstOrDefaultAsync(x => x.CategorieId == Id);
            return MMD;
        }

        public async Task Post(Categories MMD)
        {
            _context.Add(MMD);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Update(Categories MMD)
        {
            var dat = await GetxId((int)MMD.CategorieId);

            dat.Categorie = MMD.Categorie;
            dat.Status = MMD.Status;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> Delete(int Id)
        {
            var Delete = await GetxId(Id);
            _context.Categories.Remove(Delete);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
