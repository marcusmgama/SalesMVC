using System.Collections.Generic;


namespace SalesMVC.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Seller Seller { get; set; }
        public ICollection<Departments> Departments { get; set; }
    }
}
