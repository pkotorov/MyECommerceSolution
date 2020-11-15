namespace MyECommerceSolution.Web.Areas.Administration.Controllers
{
    using MyECommerceSolution.Common;
    using MyECommerceSolution.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
