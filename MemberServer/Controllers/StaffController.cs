using MemberApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web.Http.Description;

namespace MemberServer.Controllers
{
    public class StaffController : ApiController
    {
        // GET: api/Staff
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Staff
        [Route("api/Staff/{account}/{password}")]
        [ResponseType(typeof(List<Staff>))]
        public IHttpActionResult Get(string account, string password)
        {
            List<Staff> Staff = new List<Staff>();
            DataSet ds = new MySQLHelper("MyContext").ExecuteDataSet("SELECT * FROM member.staff where staff_id = '"+account+"' and staff_password = '"+ MD5(password) + "';");
            if (ds!=null)
            {
                DataTable dt = ds.Tables[0];
                for (int count = 0; count < dt.Rows.Count; count++)
                {
                    Staff.Add(new Staff()
                    {
                        Sid = Convert.ToInt32(dt.Rows[count][0]),
                        Staff_Id= dt.Rows[count][1].ToString(),
                        Store_Id= dt.Rows[count][2].ToString(),
                        Staff_Name= dt.Rows[count][3].ToString(),
                        Staff_Password = dt.Rows[count][4].ToString(),
                        Staff_Level = dt.Rows[count][5].ToString(),
                        Layer = dt.Rows[count][6].ToString(),
                        LeaveDate = dt.Rows[count][7].ToString(),
                        Staff_Created_Datetime = dt.Rows[count][8].ToString(),
                        Staff_Altered_Datetime= dt.Rows[count][9].ToString()
                    });
                }
            }
            if (Staff == null)
            {
                return NotFound();
            }
            return Ok(Staff);
        }

        // GET: api/Staff/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Staff
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Staff/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Staff/5
        public void Delete(int id)
        {
        }

        public string MD5(string stringToHash)
        {
            var md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] emailBytes = Encoding.UTF8.GetBytes(stringToHash.ToLower());
            byte[] hashedEmailBytes = md5.ComputeHash(emailBytes);
            StringBuilder sb = new StringBuilder();
            foreach (var b in hashedEmailBytes)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

    }
}
