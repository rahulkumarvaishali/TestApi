using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestApi.Database;

namespace TestApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class TestController : ApiController
    {
        crudEntities entObj = new crudEntities();

        [Route("Rahul/TableList")]
        public List<TestTable> Getdata()
        {
            var res = entObj.TestTables.ToList();
            return res;
        }
        [HttpPost]
        [Route("Emp/SaveEdit")]
        public HttpResponseMessage SaveEmp(TestTable obj)
        {

            if (obj.Sr_No == 0)
            {
                entObj.TestTables.Add(obj);
                entObj.SaveChanges();
            }
            else
            {
                entObj.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                entObj.SaveChanges();
            }
            HttpResponseMessage resobj = new HttpResponseMessage(HttpStatusCode.OK);
            return resobj;

        }
        [HttpDelete]
        [Route("Emp/Delete")]
        public HttpResponseMessage Delete(int id)
        {
            var delitem = entObj.TestTables.Where(m => m.Sr_No == id).First();
            entObj.TestTables.Remove(delitem);
            entObj.SaveChanges();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
        [Route("Emp/Edit")]
        public TestTable Edit(int id)
        {
            var edititem = entObj.TestTables.Where(m => m.Sr_No == id).First();
            return edititem;
        }
    }
}