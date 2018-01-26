// <auto-generated>
using CodeGenHero.EAMVCXamPOCO;
using NorWnd.Repository.Entities.NW;
using System;

namespace NorWnd.Repository.Interface
{
	public partial interface INWRepository : INWRepositoryCrud
	{

		#region DeleteEntity

		RepositoryActionResult<Category> DeleteCategory(int categoryId);

		RepositoryActionResult<CustomerCustomerDemo> DeleteCustomerCustomerDemo(string customerId, string customerTypeId);

		RepositoryActionResult<CustomerDemographic> DeleteCustomerDemographic(string customerTypeId);

		RepositoryActionResult<Customer> DeleteCustomer(string customerId);

		RepositoryActionResult<Employee> DeleteEmployee(int employeeId);

		RepositoryActionResult<EmployeeTerritory> DeleteEmployeeTerritory(int employeeId, string territoryId);

		RepositoryActionResult<OrderDetail> DeleteOrderDetail(int orderId, int productId);

		RepositoryActionResult<Order> DeleteOrder(int orderId);

		RepositoryActionResult<Product> DeleteProduct(int productId);

		RepositoryActionResult<Region> DeleteRegion(int regionId);

		RepositoryActionResult<Shipper> DeleteShipper(int shipperId);

		RepositoryActionResult<Supplier> DeleteSupplier(int supplierId);

		RepositoryActionResult<Sysdiagram> DeleteSysdiagram(int diagramId);

		RepositoryActionResult<Territory> DeleteTerritory(string territoryId);


		#endregion DeleteEntity

		#region FirstOrDefault

		Category GetCategory(int categoryId);

		CustomerCustomerDemo GetCustomerCustomerDemo(string customerId, string customerTypeId);

		CustomerDemographic GetCustomerDemographic(string customerTypeId);

		Customer GetCustomer(string customerId);

		Employee GetEmployee(int employeeId);

		EmployeeTerritory GetEmployeeTerritory(int employeeId, string territoryId);

		OrderDetail GetOrderDetail(int orderId, int productId);

		Order GetOrder(int orderId);

		Product GetProduct(int productId);

		Region GetRegion(int regionId);

		Shipper GetShipper(int shipperId);

		Supplier GetSupplier(int supplierId);

		Sysdiagram GetSysdiagram(int diagramId);

		Territory GetTerritory(string territoryId);


		#endregion FirstOrDefault

	}
}
