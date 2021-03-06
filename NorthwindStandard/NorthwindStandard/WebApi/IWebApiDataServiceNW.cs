// <auto-generated>
using CodeGenHero.EAMVCXamPOCO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NorWnd.DTO.NW;

namespace NorWnd.API.Client.Interface
{
	public partial interface IWebApiDataServiceNW : IWebApiDataServiceBase
	{
		#region GetAllPages

		Task<List<Category>> GetAllPagesCategoriesAsync();

		Task<List<CustomerCustomerDemo>> GetAllPagesCustomerCustomerDemosAsync();

		Task<List<CustomerDemographic>> GetAllPagesCustomerDemographicsAsync();

		Task<List<Customer>> GetAllPagesCustomersAsync();

		Task<List<Employee>> GetAllPagesEmployeesAsync();

		Task<List<EmployeeTerritory>> GetAllPagesEmployeeTerritoriesAsync();

		Task<List<OrderDetail>> GetAllPagesOrder DetailsAsync();

		Task<List<Order>> GetAllPagesOrdersAsync();

		Task<List<Product>> GetAllPagesProductsAsync();

		Task<List<Region>> GetAllPagesRegionsAsync();

		Task<List<Shipper>> GetAllPagesShippersAsync();

		Task<List<Supplier>> GetAllPagesSuppliersAsync();

		Task<List<Sysdiagram>> GetAllPagessysdiagramsAsync();

		Task<List<Territory>> GetAllPagesTerritoriesAsync();


		#endregion GetAllPages

		#region GetPageData

		Task<PageData<List<Category>>> GetCategoriesAsync(int page, int pageSize);

		Task<PageData<List<CustomerCustomerDemo>>> GetCustomerCustomerDemosAsync(int page, int pageSize);

		Task<PageData<List<CustomerDemographic>>> GetCustomerDemographicsAsync(int page, int pageSize);

		Task<PageData<List<Customer>>> GetCustomersAsync(int page, int pageSize);

		Task<PageData<List<Employee>>> GetEmployeesAsync(int page, int pageSize);

		Task<PageData<List<EmployeeTerritory>>> GetEmployeeTerritoriesAsync(int page, int pageSize);

		Task<PageData<List<OrderDetail>>> GetOrder DetailsAsync(int page, int pageSize);

		Task<PageData<List<Order>>> GetOrdersAsync(int page, int pageSize);

		Task<PageData<List<Product>>> GetProductsAsync(int page, int pageSize);

		Task<PageData<List<Region>>> GetRegionsAsync(int page, int pageSize);

		Task<PageData<List<Shipper>>> GetShippersAsync(int page, int pageSize);

		Task<PageData<List<Supplier>>> GetSuppliersAsync(int page, int pageSize);

		Task<PageData<List<Sysdiagram>>> GetsysdiagramsAsync(int page, int pageSize);

		Task<PageData<List<Territory>>> GetTerritoriesAsync(int page, int pageSize);


		#endregion GetPageData

		#region Get By PK

		Task<HttpCallResult<Category>> GetCategoryAsync(int categoryId);

		Task<HttpCallResult<CustomerCustomerDemo>> GetCustomerCustomerDemoAsync(string customerId, string customerTypeId);

		Task<HttpCallResult<CustomerDemographic>> GetCustomerDemographicAsync(string customerTypeId);

		Task<HttpCallResult<Customer>> GetCustomerAsync(string customerId);

		Task<HttpCallResult<Employee>> GetEmployeeAsync(int employeeId);

		Task<HttpCallResult<EmployeeTerritory>> GetEmployeeTerritoryAsync(int employeeId, string territoryId);

		Task<HttpCallResult<OrderDetail>> GetOrderDetailAsync(int orderId, int productId);

		Task<HttpCallResult<Order>> GetOrderAsync(int orderId);

		Task<HttpCallResult<Product>> GetProductAsync(int productId);

		Task<HttpCallResult<Region>> GetRegionAsync(int regionId);

		Task<HttpCallResult<Shipper>> GetShipperAsync(int shipperId);

		Task<HttpCallResult<Supplier>> GetSupplierAsync(int supplierId);

		Task<HttpCallResult<Sysdiagram>> GetSysdiagramAsync(int diagramId);

		Task<HttpCallResult<Territory>> GetTerritoryAsync(string territoryId);


		#endregion Get By PK

		#region Create

		Task<HttpCallResult<Category>> CreateCategoryAsync(Category item);

		Task<HttpCallResult<CustomerCustomerDemo>> CreateCustomerCustomerDemoAsync(CustomerCustomerDemo item);

		Task<HttpCallResult<CustomerDemographic>> CreateCustomerDemographicAsync(CustomerDemographic item);

		Task<HttpCallResult<Customer>> CreateCustomerAsync(Customer item);

		Task<HttpCallResult<Employee>> CreateEmployeeAsync(Employee item);

		Task<HttpCallResult<EmployeeTerritory>> CreateEmployeeTerritoryAsync(EmployeeTerritory item);

		Task<HttpCallResult<OrderDetail>> CreateOrderDetailAsync(OrderDetail item);

		Task<HttpCallResult<Order>> CreateOrderAsync(Order item);

		Task<HttpCallResult<Product>> CreateProductAsync(Product item);

		Task<HttpCallResult<Region>> CreateRegionAsync(Region item);

		Task<HttpCallResult<Shipper>> CreateShipperAsync(Shipper item);

		Task<HttpCallResult<Supplier>> CreateSupplierAsync(Supplier item);

		Task<HttpCallResult<Sysdiagram>> CreateSysdiagramAsync(Sysdiagram item);

		Task<HttpCallResult<Territory>> CreateTerritoryAsync(Territory item);

		#endregion Create

		#region Update

		Task<HttpCallResult<Category>> UpdateCategoryAsync(Category item);

		Task<HttpCallResult<CustomerCustomerDemo>> UpdateCustomerCustomerDemoAsync(CustomerCustomerDemo item);

		Task<HttpCallResult<CustomerDemographic>> UpdateCustomerDemographicAsync(CustomerDemographic item);

		Task<HttpCallResult<Customer>> UpdateCustomerAsync(Customer item);

		Task<HttpCallResult<Employee>> UpdateEmployeeAsync(Employee item);

		Task<HttpCallResult<EmployeeTerritory>> UpdateEmployeeTerritoryAsync(EmployeeTerritory item);

		Task<HttpCallResult<OrderDetail>> UpdateOrderDetailAsync(OrderDetail item);

		Task<HttpCallResult<Order>> UpdateOrderAsync(Order item);

		Task<HttpCallResult<Product>> UpdateProductAsync(Product item);

		Task<HttpCallResult<Region>> UpdateRegionAsync(Region item);

		Task<HttpCallResult<Shipper>> UpdateShipperAsync(Shipper item);

		Task<HttpCallResult<Supplier>> UpdateSupplierAsync(Supplier item);

		Task<HttpCallResult<Sysdiagram>> UpdateSysdiagramAsync(Sysdiagram item);

		Task<HttpCallResult<Territory>> UpdateTerritoryAsync(Territory item);

		#endregion Update

		#region Delete

		Task<HttpCallResult<Category>> DeleteCategoryAsync(int categoryId);

		Task<HttpCallResult<CustomerCustomerDemo>> DeleteCustomerCustomerDemoAsync(string customerId, string customerTypeId);

		Task<HttpCallResult<CustomerDemographic>> DeleteCustomerDemographicAsync(string customerTypeId);

		Task<HttpCallResult<Customer>> DeleteCustomerAsync(string customerId);

		Task<HttpCallResult<Employee>> DeleteEmployeeAsync(int employeeId);

		Task<HttpCallResult<EmployeeTerritory>> DeleteEmployeeTerritoryAsync(int employeeId, string territoryId);

		Task<HttpCallResult<OrderDetail>> DeleteOrderDetailAsync(int orderId, int productId);

		Task<HttpCallResult<Order>> DeleteOrderAsync(int orderId);

		Task<HttpCallResult<Product>> DeleteProductAsync(int productId);

		Task<HttpCallResult<Region>> DeleteRegionAsync(int regionId);

		Task<HttpCallResult<Shipper>> DeleteShipperAsync(int shipperId);

		Task<HttpCallResult<Supplier>> DeleteSupplierAsync(int supplierId);

		Task<HttpCallResult<Sysdiagram>> DeleteSysdiagramAsync(int diagramId);

		Task<HttpCallResult<Territory>> DeleteTerritoryAsync(string territoryId);

		#endregion Delete
	}
}
