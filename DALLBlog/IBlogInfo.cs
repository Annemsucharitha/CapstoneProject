using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLBlog
{
    public interface IBlogInfo
    {
        IEnumerable<BlogInfo> GetAllBlogInfo();
        void Insert(BlogInfo blogInfo);
        void Delete(int id);
        void Update(BlogInfo blogInfo);
        void Save();
        BlogInfo GetBlogId(int id);

    }
}
