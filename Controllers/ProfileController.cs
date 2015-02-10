using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using Jander.HspService.Models;

namespace Jander.HspService.Controllers
{

    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        static readonly List<Profile> _items = new List<Profile>()
        {
            new Profile { Id = 1, Email = "ella@jander.me" }
        };

        [HttpGet]
        public IEnumerable<Profile> GetAll()
        {
            return _items;
        }

        [HttpGet("{id:int}", Name = "GetByIdRoute")]
        public IActionResult GetById (int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public void CreateProfile([FromBody] Profile profile)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                profile.Id = 1+ _items.Max(x => (int?)x.Id) ?? 0;
                _items.Add(profile);

                string url = Url.RouteUrl("GetByIdRoute", new { id = profile.Id },
                    Request.Scheme, Request.Host.ToUriComponent());

                Context.Response.StatusCode = 201;
                Context.Response.Headers["Location"] = url;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return HttpNotFound();
            }
            _items.Remove(item);
            return new HttpStatusCodeResult(204); // 201 No Content
        }
    }
}
