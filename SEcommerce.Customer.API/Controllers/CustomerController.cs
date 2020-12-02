using Newtonsoft.Json;
using SEcommerce.Customer.Business.Abstract;
using SEcommerce.Customer.Business.Concrete;
using SEcommerce.Customer.DataAccess.Concrete.EntityFramework;
using System.Web.Http;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

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
        public ActionResult GetAllCustomers()
        {
            var customers = _customerService.GetCustomers();
            var seriliazedObject = JsonConvert.SerializeObject(customers, Formatting.Indented);
            return Json(seriliazedObject, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetCustomerByEmail(string email)
        {
            var customer = _customerService.GetCustomerByEmail(email);
            var seriliazedObject = JsonConvert.SerializeObject(customer, Formatting.Indented);
            return Json(seriliazedObject, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AddCustomer([FromBody] Entites.Concrete.Customer customer)
        {
            var resultCheck = _customerService.SaveCustomer(customer);
            if (resultCheck > 0)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }

            return Json(false, JsonRequestBehavior.AllowGet);
        }
    }
}