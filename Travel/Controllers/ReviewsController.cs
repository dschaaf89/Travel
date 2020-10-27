using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelContext _db;

    public ReviewsController(TravelContext db)
    {
      _db = db;
    }

    // GET api/reviews?search=
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string search)
    {
      var query = _db.Reviews.AsQueryable();

      if (Int32.TryParse(search, out int number))
      {
        if (search != null)
        {
          query = query.Where(entry => entry.Rating == number);
        }
      }
      else if (search != null)
      {
        query = query.Where(entry => entry.Country.ToUpper() == search.ToUpper() || entry.City.ToUpper() == search.ToUpper());
      }

      return query.OrderByDescending(x => x.Rating).ToList();
    }

    [Authorize]
    // POST api/reviews
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }

    // GET api/reviews/{id}
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
      return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
    }

    [Authorize]
    // PUT api/reviews/{id}
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Review review)
    {
      review.ReviewId = id;
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [Authorize]
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(reviewToDelete);
      _db.SaveChanges();
    }

    [HttpGet("popular")]
    public ActionResult<IEnumerable<Review>> GetMostPopular()
    {
      IEnumerable<Review> query = _db.Reviews.AsQueryable();
      var destinationGroup = query.GroupBy(x => x.Destination);
      var maxCount = destinationGroup.Max(g => g.Count());
      var mostPopular = destinationGroup.Where(x => x.Count() == maxCount).Select(x => x.Key).ToList();
      query = query.Where(entry => entry.Destination == mostPopular[0]);
      return query.OrderByDescending(x => x.Rating).ToList();
    }

    [HttpGet("random")]
    public ActionResult<Review> GetRandom()
    {
      List<Review> allReviews = _db.Reviews.ToList();
      var rand = new Random();
      int temp = rand.Next(0, allReviews.Count()-1);
      return allReviews[temp];
    }

  }
}