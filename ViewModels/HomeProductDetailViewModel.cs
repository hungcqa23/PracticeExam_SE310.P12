using ecommerce_web.Models;

namespace ecommerce_web.ViewModels
{
    public class HomeProductDetailViewModel
    {
        public TDanhMucSp danhMucSp { get; set; }
        public List<TAnhSp> anhSps { get; set; }
    }
}
