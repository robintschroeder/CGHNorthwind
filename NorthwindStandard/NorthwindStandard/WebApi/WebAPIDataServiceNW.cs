// <auto-generated>
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NorWnd.DTO.NW;
using CodeGenHero.EAMVCXamPOCO;
using CodeGenHero.EAMVCXamPOCO.Interface;
using NorWnd.API.Client.Interface;
using NorWnd.Client.Shared;

namespace NorWnd.API.Client
{
	public partial class WebApiDataServiceNW : WebApiDataServiceBase, IWebApiDataServiceNW
	{
		public WebApiDataServiceNW(ILoggingService log, IWebApiExecutionContext context) : base(log, context)
		{ }

		private WebApiDataServiceNW() : base()
		{ }

			#region GetAllPages

			public async Task<List<Category>> GetAllPagesCategoriesAsync()
			{
				return await GetAllPageDataResultsAsync<Category>(GetCategoriesAsync);
			}

			public async Task<List<CustomerCustomerDemo>> GetAllPagesCustomerCustomerDemosAsync()
			{
				return await GetAllPageDataResultsAsync<CustomerCustomerDemo>(GetCustomerCustomerDemosAsync);
			}

			public async Task<List<CustomerDemographic>> GetAllPagesCustomerDemographicsAsync()
			{
				return await GetAllPageDataResultsAsync<CustomerDemographic>(GetCustomerDemographicsAsync);
			}

			public async Task<List<Customer>> GetAllPagesCustomersAsync()
			{
				return await GetAllPageDataResultsAsync<Customer>(GetCustomersAsync);
			}

			public async Task<List<Employee>> GetAllPagesEmployeesAsync()
			{
				return await GetAllPageDataResultsAsync<Employee>(GetEmployeesAsync);
			}

			public async Task<List<EmployeeTerritory>> GetAllPagesEmployeeTerritoriesAsync()
			{
				return await GetAllPageDataResultsAsync<EmployeeTerritory>(GetEmployeeTerritoriesAsync);
			}

			public async Task<List<OrderDetail>> GetAllPagesOrder DetailsAsync()
			{
				return await GetAllPageDataResultsAsync<OrderDetail>(GetOrder DetailsAsync);
			}

			public async Task<List<Order>> GetAllPagesOrdersAsync()
			{
				return await GetAllPageDataResultsAsync<Order>(GetOrdersAsync);
			}

			public async Task<List<Product>> GetAllPagesProductsAsync()
			{
				return await GetAllPageDataResultsAsync<Product>(GetProductsAsync);
			}

			public async Task<List<Region>> GetAllPagesRegionsAsync()
			{
				return await GetAllPageDataResultsAsync<Region>(GetRegionsAsync);
			}

			public async Task<List<Shipper>> GetAllPagesShippersAsync()
			{
				return await GetAllPageDataResultsAsync<Shipper>(GetShippersAsync);
			}

			public async Task<List<Supplier>> GetAllPagesSuppliersAsync()
			{
				return await GetAllPageDataResultsAsync<Supplier>(GetSuppliersAsync);
			}

			public async Task<List<Sysdiagram>> GetAllPagessysdiagramsAsync()
			{
				return await GetAllPageDataResultsAsync<Sysdiagram>(GetsysdiagramsAsync);
			}

			public async Task<List<Territory>> GetAllPagesTerritoriesAsync()
			{
				return await GetAllPageDataResultsAsync<Territory>(GetTerritoriesAsync);
			}

			#endregion GetAllPages

			#region GetOnePage

			public async Task<PageData<List<Category>>> GetCategoriesAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Category>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Categories", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<CustomerCustomerDemo>>> GetCustomerCustomerDemosAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<CustomerCustomerDemo>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}CustomerCustomerDemos", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<CustomerDemographic>>> GetCustomerDemographicsAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<CustomerDemographic>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}CustomerDemographics", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Customer>>> GetCustomersAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Customer>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Customers", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Employee>>> GetEmployeesAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Employee>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Employees", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<EmployeeTerritory>>> GetEmployeeTerritoriesAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<EmployeeTerritory>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}EmployeeTerritories", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<OrderDetail>>> GetOrder DetailsAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<OrderDetail>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Order Details", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Order>>> GetOrdersAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Order>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Orders", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Product>>> GetProductsAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Product>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Products", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Region>>> GetRegionsAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Region>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Regions", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Shipper>>> GetShippersAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Shipper>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Shippers", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Supplier>>> GetSuppliersAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Supplier>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Suppliers", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Sysdiagram>>> GetsysdiagramsAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Sysdiagram>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}sysdiagrams", filter, page: page, pageSize: pageSize); 
			}

			public async Task<PageData<List<Territory>>> GetTerritoriesAsync(int page = 1, int pageSize = 100)
			{
				List<string> filter = null;
				return await SerializationHelper.SerializeCallResultsGet<List<Territory>>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Territories", filter, page: page, pageSize: pageSize); 
			}

			#endregion GetOnePage

			#region Get By PK

			public async Task<HttpCallResult<Category>> GetCategoryAsync(int categoryId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Category>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Categories/{categoryID}");
				return retVal;
			}

			public async Task<HttpCallResult<CustomerCustomerDemo>> GetCustomerCustomerDemoAsync(string customerId, string customerTypeId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<CustomerCustomerDemo>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}CustomerCustomerDemos/{customerID}/{customerTypeID}");
				return retVal;
			}

			public async Task<HttpCallResult<CustomerDemographic>> GetCustomerDemographicAsync(string customerTypeId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<CustomerDemographic>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}CustomerDemographics/{customerTypeID}");
				return retVal;
			}

			public async Task<HttpCallResult<Customer>> GetCustomerAsync(string customerId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Customer>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Customers/{customerID}");
				return retVal;
			}

			public async Task<HttpCallResult<Employee>> GetEmployeeAsync(int employeeId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Employee>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Employees/{employeeID}");
				return retVal;
			}

			public async Task<HttpCallResult<EmployeeTerritory>> GetEmployeeTerritoryAsync(int employeeId, string territoryId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<EmployeeTerritory>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}EmployeeTerritories/{employeeID}/{territoryID}");
				return retVal;
			}

			public async Task<HttpCallResult<OrderDetail>> GetOrderDetailAsync(int orderId, int productId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<OrderDetail>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Order Details/{orderID}/{productID}");
				return retVal;
			}

			public async Task<HttpCallResult<Order>> GetOrderAsync(int orderId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Order>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Orders/{orderID}");
				return retVal;
			}

			public async Task<HttpCallResult<Product>> GetProductAsync(int productId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Product>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Products/{productID}");
				return retVal;
			}

			public async Task<HttpCallResult<Region>> GetRegionAsync(int regionId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Region>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Regions/{regionID}");
				return retVal;
			}

			public async Task<HttpCallResult<Shipper>> GetShipperAsync(int shipperId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Shipper>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Shippers/{shipperID}");
				return retVal;
			}

			public async Task<HttpCallResult<Supplier>> GetSupplierAsync(int supplierId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Supplier>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Suppliers/{supplierID}");
				return retVal;
			}

			public async Task<HttpCallResult<Sysdiagram>> GetSysdiagramAsync(int diagramId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Sysdiagram>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}sysdiagrams/{diagram_id}");
				return retVal;
			}

			public async Task<HttpCallResult<Territory>> GetTerritoryAsync(string territoryId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsGet<Territory>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Territories/{territoryID}");
				return retVal;
			}

			#endregion Get By PK

			#region Create

			public async Task<HttpCallResult<Category>> CreateCategoryAsync(Category item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Category>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Categories/", item);
				return retVal;
			}

			public async Task<HttpCallResult<CustomerCustomerDemo>> CreateCustomerCustomerDemoAsync(CustomerCustomerDemo item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<CustomerCustomerDemo>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}CustomerCustomerDemos/", item);
				return retVal;
			}

			public async Task<HttpCallResult<CustomerDemographic>> CreateCustomerDemographicAsync(CustomerDemographic item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<CustomerDemographic>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}CustomerDemographics/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Customer>> CreateCustomerAsync(Customer item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Customer>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Customers/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Employee>> CreateEmployeeAsync(Employee item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Employee>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Employees/", item);
				return retVal;
			}

			public async Task<HttpCallResult<EmployeeTerritory>> CreateEmployeeTerritoryAsync(EmployeeTerritory item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<EmployeeTerritory>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}EmployeeTerritories/", item);
				return retVal;
			}

			public async Task<HttpCallResult<OrderDetail>> CreateOrderDetailAsync(OrderDetail item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<OrderDetail>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Order Details/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Order>> CreateOrderAsync(Order item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Order>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Orders/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Product>> CreateProductAsync(Product item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Product>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Products/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Region>> CreateRegionAsync(Region item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Region>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Regions/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Shipper>> CreateShipperAsync(Shipper item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Shipper>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Shippers/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Supplier>> CreateSupplierAsync(Supplier item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Supplier>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Suppliers/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Sysdiagram>> CreateSysdiagramAsync(Sysdiagram item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Sysdiagram>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}sysdiagrams/", item);
				return retVal;
			}

			public async Task<HttpCallResult<Territory>> CreateTerritoryAsync(Territory item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPost<Territory>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Territories/", item);
				return retVal;
			}

			#endregion Create

			#region Update

			public async Task<HttpCallResult<Category>> UpdateCategoryAsync(Category item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Category>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Categories/{item.CategoryID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<CustomerCustomerDemo>> UpdateCustomerCustomerDemoAsync(CustomerCustomerDemo item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<CustomerCustomerDemo>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}CustomerCustomerDemos/{item.CustomerID}/{item.CustomerTypeID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<CustomerDemographic>> UpdateCustomerDemographicAsync(CustomerDemographic item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<CustomerDemographic>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}CustomerDemographics/{item.CustomerTypeID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Customer>> UpdateCustomerAsync(Customer item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Customer>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Customers/{item.CustomerID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Employee>> UpdateEmployeeAsync(Employee item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Employee>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Employees/{item.EmployeeID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<EmployeeTerritory>> UpdateEmployeeTerritoryAsync(EmployeeTerritory item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<EmployeeTerritory>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}EmployeeTerritories/{item.EmployeeID}/{item.TerritoryID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<OrderDetail>> UpdateOrderDetailAsync(OrderDetail item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<OrderDetail>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Order Details/{item.OrderID}/{item.ProductID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Order>> UpdateOrderAsync(Order item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Order>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Orders/{item.OrderID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Product>> UpdateProductAsync(Product item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Product>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Products/{item.ProductID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Region>> UpdateRegionAsync(Region item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Region>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Regions/{item.RegionID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Shipper>> UpdateShipperAsync(Shipper item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Shipper>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Shippers/{item.ShipperID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Supplier>> UpdateSupplierAsync(Supplier item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Supplier>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Suppliers/{item.SupplierID}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Sysdiagram>> UpdateSysdiagramAsync(Sysdiagram item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Sysdiagram>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}sysdiagrams/{item.diagram_id}", item);
				return retVal;
			}

			public async Task<HttpCallResult<Territory>> UpdateTerritoryAsync(Territory item)
			{
				var retVal = await SerializationHelper.SerializeCallResultsPut<Territory>(
					Log, GetClient(),
					$"{ExecutionContext.BaseWebApiUrl}Territories/{item.TerritoryID}", item);
				return retVal;
			}

			#endregion Update

			#region Delete

			public async Task<HttpCallResult<Category>> DeleteCategoryAsync(int categoryId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Category>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Categories/{categoryID}");
				return retVal;
			}

			public async Task<HttpCallResult<CustomerCustomerDemo>> DeleteCustomerCustomerDemoAsync(string customerId, string customerTypeId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<CustomerCustomerDemo>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}CustomerCustomerDemos/{customerID}/{customerTypeID}");
				return retVal;
			}

			public async Task<HttpCallResult<CustomerDemographic>> DeleteCustomerDemographicAsync(string customerTypeId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<CustomerDemographic>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}CustomerDemographics/{customerTypeID}");
				return retVal;
			}

			public async Task<HttpCallResult<Customer>> DeleteCustomerAsync(string customerId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Customer>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Customers/{customerID}");
				return retVal;
			}

			public async Task<HttpCallResult<Employee>> DeleteEmployeeAsync(int employeeId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Employee>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Employees/{employeeID}");
				return retVal;
			}

			public async Task<HttpCallResult<EmployeeTerritory>> DeleteEmployeeTerritoryAsync(int employeeId, string territoryId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<EmployeeTerritory>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}EmployeeTerritories/{employeeID}/{territoryID}");
				return retVal;
			}

			public async Task<HttpCallResult<OrderDetail>> DeleteOrderDetailAsync(int orderId, int productId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<OrderDetail>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Order Details/{orderID}/{productID}");
				return retVal;
			}

			public async Task<HttpCallResult<Order>> DeleteOrderAsync(int orderId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Order>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Orders/{orderID}");
				return retVal;
			}

			public async Task<HttpCallResult<Product>> DeleteProductAsync(int productId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Product>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Products/{productID}");
				return retVal;
			}

			public async Task<HttpCallResult<Region>> DeleteRegionAsync(int regionId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Region>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Regions/{regionID}");
				return retVal;
			}

			public async Task<HttpCallResult<Shipper>> DeleteShipperAsync(int shipperId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Shipper>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Shippers/{shipperID}");
				return retVal;
			}

			public async Task<HttpCallResult<Supplier>> DeleteSupplierAsync(int supplierId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Supplier>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Suppliers/{supplierID}");
				return retVal;
			}

			public async Task<HttpCallResult<Sysdiagram>> DeleteSysdiagramAsync(int diagramId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Sysdiagram>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}sysdiagrams/{diagram_id}");
				return retVal;
			}

			public async Task<HttpCallResult<Territory>> DeleteTerritoryAsync(string territoryId)
			{
				var retVal = await SerializationHelper.SerializeCallResultsDelete<Territory>(Log, GetClient(), $"{ExecutionContext.BaseWebApiUrl}Territories/{territoryID}");
				return retVal;
			}

			#endregion Delete
	}
}
