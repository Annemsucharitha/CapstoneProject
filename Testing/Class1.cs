using DALLBlog;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing

    {
    [TestFixture]
    public class Class1
    {
        [Test]
        public void checkEmployeeExistWithNunit()
        {
            var obj = new EmpInfoRepository();
            var res = obj.GetEmpInfo("sneha@gmail.com");
            Assert.That(res, Is.Not.Null);
        }
        [Test]
        public void checkEmployeeCreateWithNunit()
        {
            EmpInfo emp = new EmpInfo
            {
                Name = "Dheek",
                EmailId = "Dheek@gmail.com",
                PassCode = 4246,
                DateOfJoining = DateTime.Now,
            };
            var obj = new BlogDbContext();
            EmpInfo res = obj.EmpInfo.Add(emp);
            obj.SaveChanges();
            ClassicAssert.AreEqual(emp.Name, res.Name);
            ClassicAssert.AreEqual(emp.EmailId, res.EmailId);
        }
    }
}
