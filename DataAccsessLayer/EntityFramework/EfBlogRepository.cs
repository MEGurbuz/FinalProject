using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrate;
using DataAccsessLayer.Repositories;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetlistwithCategory()
        {
            using(var c = new Context())
            {

                return c.Blogs.Include(x => x.Category).ToList();


            }
        }
    }
}
