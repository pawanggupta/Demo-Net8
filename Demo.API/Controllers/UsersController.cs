using Demo.API.Data;
using Demo.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    private readonly DataContext _dataContext = context;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _dataContext.Users.ToListAsync();
        return users;
    }


    [HttpGet("{id:int}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _dataContext.Users.FindAsync(id);
        if (user == null) { return NotFound(); }
        return user;
    }
}
