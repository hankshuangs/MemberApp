using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberServer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           //DataSet Dt1 = new MySQLHelper("MyContext").ExecuteDataSet("SELECT i_id,i_name FROM member.item;");

           //     DataTable dt1; //查詢結果
           // //查詢
           // string SQL = "SELECT i_id,i_name FROM member.item;";
           // string MyContext = ConfigurationManager.ConnectionStrings["MyContext"].ConnectionString;
           // string[] TitleName;
           // TitleName = new string[] { "序號", "名稱" };
           // dt1 = new DataTable();
           // dt1.Columns.Add(TitleName[0], typeof(string));
           // dt1.Columns.Add(TitleName[1], typeof(string));
           // using (MySqlConnection conn = new MySqlConnection())
           // {
           //     conn.ConnectionString = MyContext;
           //     if (conn.State != ConnectionState.Open)
           //     {
           //         conn.Open();
           //         MySqlCommand cmd = new MySqlCommand(SQL, conn);
           //         MySqlDataReader data = cmd.ExecuteReader();
           //         //列出查詢到的資料
           //         while (data.Read())
           //         {
           //             DataRow dr = dt1.NewRow();
           //             dr[TitleName[0]] = data["i_id"].ToString();
           //             dr[TitleName[1]] = data["i_name"].ToString();
           //             dt1.Rows.Add(dr);
           //         }
           //         data.Close();
           //         conn.Close();
           //     }

           // }
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
