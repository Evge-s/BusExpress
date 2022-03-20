namespace BusExpress.Server.Controllers;

using Microsoft.AspNetCore.Mvc;
using BusExpress.Shared.Entities;

[Controller]
public abstract class BaseController : ControllerBase
{
    // returns the current authenticated account (null if not logged in)
    public Account Account => (Account)HttpContext.Items["Account"];
}