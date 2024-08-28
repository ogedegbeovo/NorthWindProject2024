using Microsoft.AspNetCore.Mvc;
using NorthWindProject2024.Models;
using SQLTest;
using System.Diagnostics;
using System.Net;

namespace NorthWindProject2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }

        //[Route("/GetProducts")]
        public IActionResult GetProducts()
        {
            DBGateway aGateway = new DBGateway();


            List<Product> aListOfProducts = aGateway.GetProducts();

            ViewBag.ListOfProducts = aListOfProducts;



            return View();

        }

        public IActionResult GetProductsById(int aProductId)
        {
            DBGateway aGateway = new DBGateway();


            List<Product> aListOfProducts = aGateway.GetProductsById(aProductId);

            ViewBag.ListOfProducts = aListOfProducts;



            return View();

        }




        [Route("/GetCategories")]
        public IActionResult GetCategories()
        {
            DBGateway aGateway = new DBGateway();

            List<Categories> aListOfCategories = aGateway.GetCategories();

            ViewBag.ListOfCategories = aListOfCategories;

            return View();

        }
        
        [Route("/GetSupplers")]
        public IActionResult GetSuppliers()
        {
            DBGateway aGateway = new DBGateway();

            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();

            ViewBag.ListOfSuppliers = aListOfSuppliers;

            return View();
        }

        [Route("/GetCustomers")]
        public IActionResult GetCustomers()
        {
            DBGateway aGateway = new DBGateway();

            List<Customer> aListOfCustomers = aGateway.GetCustomers();

            ViewBag.ListOfCustomers = aListOfCustomers;

            return View();
        }

        public IActionResult GetEmployees()
        {
            DBGateway aGateway = new DBGateway();

            List<Employee> aListOfEmployees = aGateway.GetEmployees();

            ViewBag.ListOfEmployees = aListOfEmployees;

            return View();

        }

        public IActionResult GetOrders()
        {
            DBGateway aGateway = new DBGateway();

            List<Order> aListOfOrders = aGateway.GetOrders();

            ViewBag.ListOfOrders = aListOfOrders;
            
            return View();
        }
        public IActionResult GetOrderDetails()
        {
            DBGateway aGateway = new DBGateway();

            List<OrderDetails> aListOfOrderDetails = aGateway.GetOrderDetails();

            ViewBag.ListOfOrderDetails = aListOfOrderDetails;

            return View();
        }

        public IActionResult GetShippers()
        {
            DBGateway aGateway = new DBGateway();

            List<Shipper> aListOfShippers = aGateway.GetShippers();

            ViewBag.ListOfShippers = aListOfShippers;

            return View();


        }
        // [Route("/InsertAProduct")]

        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################


        public IActionResult InsertAProduct(string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, double aUnitPrice, string aUnitsInStock, string aUnitsOnOrder,
            string aReorderLevel, string aDiscontinued)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertAProduct( aProductName,  aSupplierId,  aCategoryId,  aQuantityPerUnit,  aUnitPrice,  aUnitsInStock,  aUnitsOnOrder,
             aReorderLevel,  aDiscontinued);


            List<Product> aListOfProducts = aGateway.GetProducts();

            ViewBag.ListOfProducts = aListOfProducts;

            return View("GetProducts");
        }

        
        public IActionResult InsertAProductForm()
        {

            DBGateway aGateway = new DBGateway();

            //aGateway.InsertAProduct(aProductName, aSupplierId, aCategoryId, aUnitPrice);

            List<Categories> alistOfCategories = aGateway.GetCategories();
            List<Supplier> alistOfSuppliers = aGateway.GetSuppliers();

            //reason we are returnong GetPRoducts is because if you are an employee and you insert a PRoduct, you will probablt want to see it was actually added so I am returing them to teh getproducts view
            ViewBag.ListOfSuppliers = alistOfSuppliers;
            ViewBag.ListOfCategories = alistOfCategories;
            

            return View();
        }
        
        public IActionResult UpdateAProductForm(int aProductId)
        {


            DBGateway aGateway = new DBGateway();

            List<Product> aListOfProducts = new List<Product>();         

            List<Categories> alistOfCategories = aGateway.GetCategories();
            List<Supplier> alistOfSuppliers = aGateway.GetSuppliers();
            //List<UnitPrice> alistOfUnitPrice = aGateway.GetUnitPrice();

            //suppliers

            aListOfProducts = aGateway.GetProductsById(aProductId);
           // aGateway.GetProductsById(aProductId);

            ViewBag.ListOfProducts = aListOfProducts;
            ViewBag.ListOfCategories = alistOfCategories;
            ViewBag.ListOfSuppliers = alistOfSuppliers;
            //ViewBag.ListOfUnitPrice = aListOfUnitPrice;

            return View();
        }

        public IActionResult UpdateAProduct(int aProductId, string aProductName, int aSupplierId, int aCategoryId, string aQuantityPerUnit, double aUnitPrice, string aUnitsInStock, string aUnitsOnOrder,
            string aReorderLevel, string aDiscontinued)
        {

            DBGateway aGateway = new DBGateway();

            aGateway.UpdateAProduct(aProductId,  aProductName,  aSupplierId,  aCategoryId,  aQuantityPerUnit,  aUnitPrice,  aUnitsInStock,  aUnitsOnOrder,
             aReorderLevel,  aDiscontinued);

            List<Product> aListOfProducts = new List<Product>();

            ViewBag.ListOfProducts = aGateway.GetProducts();


            return View("GetProducts");

        }
        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################
        //Logan Krupa


        public IActionResult InsertAOrder(string aCustomerId, string aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipVia, string aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertAOrder(aCustomerId, aEmployeeId, aOrderDate, aRequiredDate, aShippedDate, aShipVia, aFreight, aShipName, aShipAddress, aShipCity, aShipRegion, aShipPostalCode, aShipCountry);

            List<Order> aListOfOrders = aGateway.GetOrders();

            ViewBag.ListOfOrders = aListOfOrders;

            return View("GetOrders");
        }


        public IActionResult InsertAOrderForm()
        {

            DBGateway aGateway = new DBGateway();


            List<Customer> alistOfCustomers = aGateway.GetCustomers();
            List<Employee> alistOfEmployees = aGateway.GetEmployees();
            List<Shipper> alistOfShippers = aGateway.GetShippers();

            //reason we are returnong GetPRoducts is because if you are an employee and you insert a PRoduct, you will probablt want to see it was actually added so I am returing them to teh getproducts view
            ViewBag.ListOfEmployees = alistOfEmployees;
            ViewBag.ListOfCustomers = alistOfCustomers;
            ViewBag.ListOfShippers = alistOfShippers;


            return View();
        }

        public IActionResult GetOrdersById(int aOrderId)
        {
            DBGateway aGateway = new DBGateway();


            List<Order> aListOfOrders = aGateway.GetOrdersById(aOrderId);

            ViewBag.ListOfOrders = aListOfOrders;



            return View();

        }


        public IActionResult UpdateAOrderForm(int aOrderId)
        {


            DBGateway aGateway = new DBGateway();

            List<Order> aListOfOrders = new List<Order>();

            List<Customer> alistOfCustomers = aGateway.GetCustomers();
            List<Employee> alistOfEmployees = aGateway.GetEmployees();
            List<Shipper> alistOfShippers = aGateway.GetShippers();
            //List<UnitPrice> alistOfUnitPrice = aGateway.GetUnitPrice();

            //suppliers

            aListOfOrders = aGateway.GetOrdersById(aOrderId);
            // aGateway.GetProductsById(aProductId);

            ViewBag.ListOfOrders = aListOfOrders;
            ViewBag.ListOfEmployees = alistOfEmployees;
            ViewBag.ListOfCustomers = alistOfCustomers;
            ViewBag.ListOfShippers = alistOfShippers;

            return View();
        }

        public IActionResult UpdateAOrder(int aOrderId, string aCustomerId, string aEmployeeId, string aOrderDate, string aRequiredDate, string aShippedDate, string aShipVia, string aFreight, string aShipName, string aShipAddress, string aShipCity, string aShipRegion, string aShipPostalCode, string aShipCountry)
        {

            DBGateway aGateway = new DBGateway();

            aGateway.UpdateAOrder(aOrderId, aCustomerId,  aEmployeeId,  aOrderDate,  aRequiredDate,  aShippedDate,  aShipVia,  aFreight,  aShipName,  aShipAddress,  aShipCity,  aShipRegion,  aShipPostalCode,  aShipCountry);

            List<Order> aListOfOrders = new List<Order>();

            ViewBag.ListOfOrders = aGateway.GetOrders();


            return View("GetOrders");

        }



        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################
        //Logan Krupa

        public IActionResult InsertAEmployee(string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, string aReportsTo)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertAEmployee(aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aNotes, aReportsTo);

            List<Employee> aListOfEmployees= aGateway.GetEmployees();

            ViewBag.ListOfEmployees = aListOfEmployees;

            return View("GetEmployees");
        }

        public IActionResult InsertAEmployeeForm()
        {
            DBGateway aGateway = new DBGateway();

            return View();
        }


        public IActionResult GetEmployeesById(int aEmployeeId)
        {
            DBGateway aGateway = new DBGateway();


            List<Employee> aListOfEmployees = aGateway.GetEmployeesById(aEmployeeId);

            ViewBag.ListOfEmployees = aListOfEmployees;



            return View();

        }


        public IActionResult UpdateAEmployeeForm(int aEmployeeId)
        {


            DBGateway aGateway = new DBGateway();

            List<Employee> aListOfEmployees = new List<Employee>();


            aListOfEmployees = aGateway.GetEmployeesById(aEmployeeId);
            

            ViewBag.ListOfEmployees = aListOfEmployees;


            return View();
        }

        public IActionResult UpdateAEmployee(int aEmployeeId, string aLastName, string aFirstName, string aTitle, string aTitleOfCourtesy, string aBirthDate, string aHireDate, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aHomePhone, string aExtension, string aNotes, string aReportsTo)
        {

            DBGateway aGateway = new DBGateway();

            aGateway.UpdateAEmployee(aEmployeeId, aLastName, aFirstName, aTitle, aTitleOfCourtesy, aBirthDate, aHireDate, aAddress, aCity, aRegion, aPostalCode, aCountry, aHomePhone, aExtension, aNotes, aReportsTo);

            List<Employee> aListOfEmployees = new List<Employee>();

            ViewBag.ListOfEmployees = aGateway.GetEmployees();

            return View("GetEmployees");

        }



        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################
        //Logan Krupa

        public IActionResult InsertASupplier(string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {

            DBGateway aGateway = new DBGateway();

            aGateway.InsertASupplier(aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);

            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();

            ViewBag.ListOfSuppliers = aListOfSuppliers;


            return View("GetSuppliers");
        }


        public IActionResult InsertASupplierForm()
        {
            DBGateway aGateway = new DBGateway();

            return View();
        }



        //Fanial W - UpdateASupplier


        public IActionResult UpdateASupplier(int aSupplierId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax, string aHomePage)
        {

            DBGateway aGateway = new DBGateway();

            aGateway.UpdateASupplier(aSupplierId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax, aHomePage);

            List<Supplier> aListOfSuppliers = new List<Supplier>();

            ViewBag.ListOfSuppliers = aGateway.GetSuppliers();


            return View("GetSuppliers");


        }



        //Fanial W - UpdateASupplierForm

        public IActionResult UpdateASupplierForm(int aSupplierId)
        {


            DBGateway aGateway = new DBGateway();

            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers();


            aListOfSuppliers = aGateway.GetSuppliersById(aSupplierId);
            // aGateway.GetProductsById(aProductId);

            ViewBag.ListOfSuppliers = aListOfSuppliers;


            return View();


        }



        //Fanial W - GetSupplierById
        public IActionResult GetSupplierById(int aSupplierId)
        {
            DBGateway aGateway = new DBGateway();


            List<Supplier> aListOfSuppliers = aGateway.GetSuppliersById(aSupplierId);



            ViewBag.ListOfSuppliers = aListOfSuppliers;



            return View();

        }


        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################

        //[9:33 PM] Apaloo, Jacques-Philipp
// Home Controller Code: Jacques Apaloo

    public IActionResult InsertShippers(string aCompanyName, string aPhone)

        {

            DBGateway aGateway = new DBGateway();

            aGateway.InsertShippers(aCompanyName, aPhone);

            List<Shipper> aListAShippers = aGateway.GetShippers();

            ViewBag.ListOfShippers = aListAShippers;

            return View("GetShippers");

        }


        public IActionResult UpdateAShipper(int aShipperId, string aCompanyName, string aPhone)

        {

            DBGateway aGateway = new DBGateway();

            aGateway.UpdateAShipper(aShipperId, aCompanyName, aPhone);

            List<Shipper> aListOfShippers = aGateway.GetShippers();

            ViewBag.ListOfShippers = aListOfShippers;

            return View("GetShippers");

        }

        // Jacques Apaloo

        public IActionResult GetShipperById(int aShipperId)

        {

            DBGateway aGateway = new DBGateway();

            List<Shipper> aListOfShippers = aGateway.GetShipperById(aShipperId);

            ViewBag.ListOfShippers = aListOfShippers;

            return View();

        }

        public IActionResult UpdateAShipperForm(int aShipperId)

        {


            DBGateway aGateway = new DBGateway();

            List<Shipper> aListOfShippers = new List<Shipper>();


            aListOfShippers = aGateway.GetShipperById(aShipperId);


            ViewBag.ListOfShippers = aListOfShippers;


            return View();

        }

        public IActionResult InsertAShipperForm()

        {

            DBGateway aGateway = new DBGateway();

            List<Shipper> aListOfShippers = aGateway.GetShippers();

            ViewBag.ListOfShippers = aListOfShippers;


            return View();

        }
        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################

        //###############################################################################################################################
        //###############################################################################################################################



        //Fanial W - InsertAnOrderDetail
        public IActionResult InsertAnOrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {

            DBGateway aGateway = new DBGateway();

            aGateway.InsertAnOrderDetail(aOrderId, aProductId, aUnitPrice, aQuantity, aDiscount);


            List<OrderDetails> aListOfOrderDetails = aGateway.GetOrderDetails();
            List<Order> aListOfOrders = aGateway.GetOrders();
            List<Product> aListOfProducts = aGateway.GetProducts();



            //reason we are returnong GetPRoducts is because if you are an employee and you insert a PRoduct, you will probablt want to see it was actually added so I am returing them to teh getproducts view
            ViewBag.ListOfOrderDetails = aListOfOrderDetails;
            ViewBag.ListOfOrders = aListOfOrders;
            ViewBag.ListOfProducts = aListOfProducts;





            return View("GetOrderDetails");

        }







        //Fanial W - InsertAnOrderDetailForm
        public IActionResult InsertAnOrderDetailForm()
        {

            DBGateway aGateway = new DBGateway();

            List<OrderDetails> aListOfOrderDetails = aGateway.GetOrderDetails();
            List<Order> aListOfOrders = aGateway.GetOrders();
            List<Product> aListOfProducts = aGateway.GetProducts();



            //reason we are returnong GetPRoducts is because if you are an employee and you insert a PRoduct, you will probablt want to see it was actually added so I am returing them to teh getproducts view
            ViewBag.ListOfOrderDetails = aListOfOrderDetails;
            ViewBag.ListOfOrders = aListOfOrders;
            ViewBag.ListOfProducts = aListOfProducts;




            return View();
        }






        //Fanial W - UpdateAnOrderDetail

        public IActionResult UpdateAnOrderDetail(int aOrderId, int aProductId, double aUnitPrice, int aQuantity, double aDiscount)
        {

            DBGateway aGateway = new DBGateway();
            aGateway.UpdateAnOrderDetail(aOrderId, aProductId, aUnitPrice, aQuantity, aDiscount);

            List<OrderDetails> aListOfOrderDetails = new List<OrderDetails>();
            List<Order> aListOfOrders = aGateway.GetOrders();
            List<Product> aListOfProducts = aGateway.GetProducts();


            ViewBag.ListOfOrderDetails = aGateway.GetOrderDetails();
            ViewBag.ListOfOrders = aListOfOrders;
            ViewBag.ListOfProducts = aListOfProducts;

            return View("GetOrderDetails");


        }


        //Fanial W - UpdateAnOrderDetailForm

        public IActionResult UpdateAnOrderDetailForm(int aOrderId, int aProductId)
        {


            DBGateway aGateway = new DBGateway();

            List<OrderDetails> aListOfOrderDetails = aGateway.GetOrderDetails();

            aListOfOrderDetails = aGateway.GetOrderDetailById(aOrderId, aProductId);

            ViewBag.ListOfOrderDetails = aGateway.GetOrderDetails();


            return View();


        }




        //Fanial W - GetOrderDetailById
        public IActionResult GetOrderDetailById(int aOrderId, int aProductId)
        {
            DBGateway aGateway = new DBGateway();


            List<OrderDetails> aListOfOrderDetails = aGateway.GetOrderDetailById(aOrderId, aProductId);
            List<Order> aListOfOrders = aGateway.GetOrders();
            List<Product> aListOfProducts = aGateway.GetProducts();


            ViewBag.ListOfOrderDetails = aGateway.GetOrderDetails();
            ViewBag.ListOfOrders = aListOfOrders;
            ViewBag.ListOfProducts = aListOfProducts;





            return View();

        }



        //Fanial W - GetCustomerById
        public IActionResult GetCustomerById(string aCustomerId)
        {
            DBGateway aGateway = new DBGateway();


            List<Customer> aListOfCustomers = aGateway.GetCustomerById(aCustomerId);

            ViewBag.ListOfCustomers = aListOfCustomers;



            return View();

        }

        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################



        //Fanial W - UpdateACustomer
        public IActionResult UpdateACustomer(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {


            DBGateway aGateway = new DBGateway();
            aGateway.UpdateACustomer(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);

            List<Customer> aListOfCustomers = new List<Customer>();
            ViewBag.ListOfCustomers = aGateway.GetCustomers();
            return View("GetCustomers");
        }



        //Fanial W - UpdateACustomerForm
        public IActionResult UpdateACustomerForm(string aCustomerId)
        {
            DBGateway aGateway = new DBGateway();

            List<Customer> aListOfCustomers = new List<Customer>();



            //suppliers

            aListOfCustomers = aGateway.GetCustomerById(aCustomerId);
            // aGateway.GetProductsById(aProductId);

            ViewBag.ListOfCustomers = aListOfCustomers;


            return View();


        }





        //Fanial W - InsertACustomer
        public IActionResult InsertACustomer(string aCustomerId, string aCompanyName, string aContactName, string aContactTitle, string aAddress, string aCity, string aRegion, string aPostalCode, string aCountry, string aPhone, string aFax)
        {
            DBGateway aGateway = new DBGateway();

            aGateway.InsertACustomer(aCustomerId, aCompanyName, aContactName, aContactTitle, aAddress, aCity, aRegion, aPostalCode, aCountry, aPhone, aFax);


            List<Customer> aListOfCustomers = aGateway.GetCustomers();

            ViewBag.ListOfCustomers = aListOfCustomers;



            return View("GetCustomers");

        }



        //Fanial W - InsertACustomerForm
        public IActionResult InsertACustomerForm()
        {

            DBGateway aGateway = new DBGateway();

            List<Customer> aListOfCustomers = aGateway.GetCustomers();

            ViewBag.ListOfCustomers = aListOfCustomers;



            return View();
        }



        //###############################################################################################################################
        //###############################################################################################################################
        //###############################################################################################################################


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
