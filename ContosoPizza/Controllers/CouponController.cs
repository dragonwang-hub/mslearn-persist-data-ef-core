using ContosoPizza.Data;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CouponController : ControllerBase
{
    private readonly PromotionsContext _context;
    public CouponController(PromotionsContext promotionsContext)
    {
        _context = promotionsContext;
    }

    [HttpGet]
    public IEnumerable<Coupon> GetAll()
    {
        return _context.Coupons
            .AsNoTracking()
            .ToList();
    }

}