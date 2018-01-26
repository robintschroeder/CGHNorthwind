// <auto-generated>
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using Marvin.JsonPatch;
using NorWnd.Repository.Interface;
using CodeGenHero.EAMVCXamPOCO.Repository.Factories;
using dtoNW = NorWnd.DTO.NW;
using entNW = NorWnd.Repository.Entities.NW;
using appEnums = CodeGenHero.EAMVCXamPOCO.Enums;
using CodeGenHero.EAMVCXamPOCO.Interface;
using CodeGenHero.EAMVCXamPOCO.API.Helpers;
using CodeGenHero.EAMVCXamPOCO;

namespace NorWnd.API.Controllers.NW
{
public partial class EmployeesNWController : NWBaseApiController
{
	private const string GET_LIST_ROUTE_NAME = "EmployeesNWList";
	private const int maxPageSize = 100;

	private GenericFactory<entNW.Employee, dtoNW.Employee> _factory 
	= new GenericFactory<entNW.Employee, dtoNW.Employee>();

		public EmployeesNWController() : base()
		{
		}

		public EmployeesNWController(ILoggingService log, INWRepository repository)
		: base(log, repository)
		{
		}

		[HttpDelete]
		[VersionedRoute(template: "Employees/{employeeID}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Delete(int employeeId)
		{
			try
			{
				base.OnActionExecuting();

				var result = Repo.DeleteEmployee(employeeID);

				if (result.Status == appEnums.RepositoryActionStatus.Deleted)
				{
					return StatusCode(HttpStatusCode.NoContent);
				}
				else if (result.Status == appEnums.RepositoryActionStatus.NotFound)
				{
					return NotFound();
				}

				Warn("Unable to delete object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpGet]
		[VersionedRoute(template: "Employees", allowedVersion: 1, Name = GET_LIST_ROUTE_NAME)]
		public async Task<IHttpActionResult> Get(string sort = null,
		string fields = null, string filter = null, int page = 1, int pageSize = maxPageSize)
		{
			try
			{
				base.OnActionExecuting();

				var fieldList = GetListByDelimiter(fields);
				bool childrenRequested = false; // TODO: set this based upon actual fields requested.

				var filterList = GetListByDelimiter(filter);
				var dbItems = Repo.GetQueryableEmployee();
				RunCustomLogicAfterGetQueryableList(ref dbItems, ref filterList);
				dbItems = dbItems.ApplyFilter(filterList);
				dbItems = dbItems.ApplySort(sort ?? (typeof(entNW.Employee).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance)).First().Name);

				if (pageSize > maxPageSize)
				{ // ensure the page size isn't larger than the maximum.
					pageSize = maxPageSize;
				}

				var urlHelper = new UrlHelper(Request);
				PageData paginationHeader = BuildPaginationHeader(urlHelper, GET_LIST_ROUTE_NAME, page: page, totalCount: dbItems.Count(), pageSize: pageSize, sort: sort);
				HttpContext.Current.Response.Headers.Add("X-Pagination", Newtonsoft.Json.JsonConvert.SerializeObject(paginationHeader));

				// return result
				return Ok(dbItems
				.Skip(pageSize * (page - 1))
				.Take(pageSize)
				.ToList()
				.Select(x => _factory.CreateDataShapedObject(x, fieldList, childrenRequested)));
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpGet]
		[VersionedRoute(template: "Employees/{employeeID}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Get(int employeeId)
		{
			try
			{
				base.OnActionExecuting();

				var qryItem = Repo.GetQueryableEmployee();
				RunCustomLogicAfterGetQueryableByPK(ref qryItem, employeeID);

				var dbItem = qryItem.Where(x => x.EmployeeId == employeeId).FirstOrDefault();

				if (dbItem == null)
				{
					Warn("Unable to get object via Web API", appEnums.LogMessageType.Warn_WebApi, httpResponseStatusCode: 404, url: Request.RequestUri.ToString());
					return NotFound();
				}

				return Ok(_factory.Create(dbItem));
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPatch]
		[VersionedRoute(template: "Employees/{employeeID}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Patch(int employeeId, [FromBody]JsonPatchDocument<dtoNW.Employee> patchDocument)
		{
			try
			{
				base.OnActionExecuting();

				if (patchDocument == null)
				{
					return BadRequest();
				}

				var dbItem = Repo.GetEmployee(employeeID);
				if (dbItem == null)
				{
					return NotFound();
				}

				var dtoItem = _factory.Create(dbItem); // map

				// apply changes to the DTO
				patchDocument.ApplyTo(dtoItem);
				dtoItem.EmployeeID = employeeID;

				// map the DTO with applied changes to the entity, & update
				var updatedDBItem = _factory.Create(dtoItem); // map
				var result = Repo.Update(updatedDBItem);

				if (result.Status == appEnums.RepositoryActionStatus.Updated)
				{
					// map to dto
					var patchedDTOItem = _factory.Create(result.Entity);
					return Ok(patchedDTOItem);
				}

				Warn("Unable to patch object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPost]
		[VersionedRoute(template: "Employees", allowedVersion: 1)]
		public async Task<IHttpActionResult> Post([FromBody]dtoNW.Employee dtoItem)
		{
			try
			{
				base.OnActionExecuting();

				if (dtoItem == null)
				{
					return BadRequest();
				}

				// try mapping & saving
				var newDBItem = _factory.Create(dtoItem);

				var result = Repo.Insert(newDBItem);
				if (result.Status == appEnums.RepositoryActionStatus.Created)
				{   // map to dto
					RunCustomLogicAfterInsert(newDBItem);

					var newDTOItem = _factory.Create(result.Entity);
					var uriFormatted = Request.RequestUri.ToString().EndsWith("/") == true ? Request.RequestUri.ToString().Substring(0, Request.RequestUri.ToString().Length - 1) : Request.RequestUri.ToString();
					return Created($"{uriFormatted}/{newDTOItem.EmployeeID}", newDTOItem);
				}

				Warn("Unable to create object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		[HttpPut]
		[VersionedRoute(template: "Employees/{employeeID}", allowedVersion: 1)]
		public async Task<IHttpActionResult> Put(int employeeId, [FromBody]dtoNW.Employee dtoItem)
		{
			try
			{
				base.OnActionExecuting();

				if (dtoItem == null)
				{
					return BadRequest();
				}

				dtoItem.EmployeeID = employeeID;

				var updatedDBItem = _factory.Create(dtoItem); // map
				var result = Repo.Update(updatedDBItem);

				if (result.Status == appEnums.RepositoryActionStatus.Updated)
				{
					// map to dto
					var updatedDTOItem = _factory.Create(result.Entity);
					return Ok(updatedDTOItem);
				}
				else if (result.Status == appEnums.RepositoryActionStatus.NotFound)
				{
					return NotFound();
				}

				Warn("Unable to update object via Web API", appEnums.LogMessageType.Warn_WebApi, result.Exception, httpResponseStatusCode: 400, url: Request.RequestUri.ToString());
				return BadRequest();
			}
			catch (Exception ex)
			{
				Error(message: ex.Message, logMessageType: appEnums.LogMessageType.Exception_WebApi, ex: ex);

				if (System.Diagnostics.Debugger.IsAttached)
				System.Diagnostics.Debugger.Break();

				return InternalServerError();
			}
		}

		partial void RunCustomLogicAfterInsert(entNW.Employee newDBItem);

	partial void RunCustomLogicAfterGetQueryableByPK(ref IQueryable<entNW.Employee> dbItems, int employeeId);

	/// <summary>
	/// A sample implementation of custom logic used to include related entities to return with a DTO.
	/// </summary>
	/// <param name="dbItem"></param>
	/// <param name="id"></param>
	// partial void RunCustomLogicAfterGetQueryableByPK(ref IQueryable<entMmsInstance.SecurityPermissionGroup> qryItem, System.Guid id)
	// {
		// qryItem = qryItem.Include(x => x.RelatedParentEntity)
			// .Include(x => x.RelatedChildEntities);

	// }

	partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entNW.Employee> dbItems, ref List<string> filterList);

	/// <summary>
	/// A sample implementation of custom logic used to filter on a field that exists in a related, parent, table.
	/// </summary>
	/// <param name="dbItems"></param>
	/// <param name="filterList"></param>
	//partial void RunCustomLogicAfterGetQueryableList(ref IQueryable<entNW.Employee> dbItems, ref List<string> filterList)
	//{
	//	var queryableFilters = filterList.ToQueryableFilter();
	//	var myFilterCriterion = queryableFilters.Where(y => y.Member.ToLowerInvariant() == "<myFieldName>").FirstOrDefault(); // Examine the incoming filter for the presence of a field name which does not exist on the target entity.

	//	if (myFilterCriterion != null)
	//	{   // myFieldName is a criterion that has to be evaluated at a level other than our target entity.
	//		dbItems = dbItems.Include(x => x.myFKRelatedEntity).Where(x => x.myFKRelatedEntity.myFieldName == new Guid(myFilterCriterion.Value));
	//		queryableFilters.Remove(myFilterCriterion);  // The evaluated criterion needs to be removed from the list of filters before we invoke the ApplyFilter() extension method.
	//		filterList = queryableFilters.ToQueryableStringList();
	//	}
	//}
	}
}
