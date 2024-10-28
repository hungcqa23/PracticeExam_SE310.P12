using ecommerce_web.Models;
using ecommerce_web.Models.ProductModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        QlBanValiContext db = new QlBanValiContext();

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            //return db.TDanhMucSps.ToList();
            var products = (from p in db.TDanhMucSps
                            select new Product
                            {
                                MaSp = p.MaSp,
                                TenSp = p.TenSp,
                                MaLoai = p.MaLoai,
                                AnhDaiDien = p.AnhDaiDien,
                                GiaNhoNhat = p.GiaNhoNhat
                            }).ToList();

            return products;
        }

        [HttpGet("{maloai}")]
        public IEnumerable<Product> GetAllProductsByCategory(string maloai)
        {
            //return db.TDanhMucSps.ToList();
            var products = (from p in db.TDanhMucSps
                            where p.MaLoai == maloai
                            select new Product
                            {
                                MaSp = p.MaSp,
                                TenSp = p.TenSp,
                                MaLoai = p.MaLoai,
                                AnhDaiDien = p.AnhDaiDien,
                                GiaNhoNhat = p.GiaNhoNhat
                            }).ToList();

            return products;
        }
    }
}
