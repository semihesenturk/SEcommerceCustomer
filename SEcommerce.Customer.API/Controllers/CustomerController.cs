using Newtonsoft.Json;
using SEcommerce.Customer.Business.Abstract;
using SEcommerce.Customer.Business.Concrete;
using SEcommerce.Customer.DataAccess.Concrete.EntityFramework;
using System.Web.Mvc;

namespace SEcommerce.Customer.API.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerManager(new EfCustomerDal());
        }

        // GET: Customer
        public JsonResult GetAllCustomers()
        {
            var customers = _customerService.GetCustomers();
            return Json(customers, JsonRequestBehavior.AllowGet);
        }
    }
}