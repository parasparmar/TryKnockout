using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Dynamic;
using System.Web.Http.Description;
using TryKnockout.DAL;
using TryKnockout.Models;
using TryKnockout.ViewModels;
using AutoMapper;

namespace TryKnockout.Controllers.Api
{
    public class AuthorsController : ApiController
    {
        private BookContext db = new BookContext();
        MapperConfiguration config = new MapperConfiguration(cfg => cfg.CreateMap<Author, AuthorViewModel>());
        // GET api/authors
        public ResultList<AuthorViewModel> Get([FromUri]QueryOptions queryOptions)
        {
            var start = (queryOptions.CurrentPage - 1) * queryOptions.PageSize;
            var authors = db.Authors.
            OrderBy(queryOptions.Sort).
            Skip(start).
            Take(queryOptions.PageSize);
            queryOptions.TotalPages = (int)Math.Ceiling((double)db.Authors.Count() / queryOptions.PageSize);
            IMapper iMapper = config.CreateMapper();


            return new ResultList<AuthorViewModel>
            {
                QueryOptions = queryOptions,
                Results = iMapper.Map<List<AuthorViewModel>>(authors.ToList())
            };
        }
        // PUT: api/Authors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(AuthorViewModel author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IMapper iMapper = config.CreateMapper();
            db.Entry(iMapper.Map<AuthorViewModel, Author>(author)).State= EntityState.Modified;
            db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
        // POST: api/Authors
        [ResponseType(typeof(AuthorViewModel))]
        public IHttpActionResult Post(AuthorViewModel author)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            IMapper iMapper = config.CreateMapper();
            db.Authors.Add(iMapper.Map<AuthorViewModel, Author>(author));
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = author.Id }, author);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}