using System;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Configuration;
using System.Data.OleDb;
using System.Data;


namespace MVCTareaa.Controllers
{
    public class LectorArchivosController : Controller
    {
        // GET: LectorArchivos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase postedFile)
        {
            string path = Server.MapPath("~/Uploads/");
            string filePath = string.Empty;
            string extension = string.Empty;
            DataTable dtSheet = new DataTable();
            DataSet ExcelData = new DataSet();

            if (postedFile != null)
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                filePath = path + Path.GetFileName(postedFile.FileName);
                extension = Path.GetExtension(postedFile.FileName);
                postedFile.SaveAs(filePath);
                
            }
            string connectionString = connectionString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;

            switch (extension)
            {
                case ".xls":
                    connectionString = ConfigurationManager.ConnectionStrings["Excel03ConString"].ConnectionString;
                    break;

                case "xlsx":
                    connectionString = ConfigurationManager.ConnectionStrings["Excel07ConString"].ConnectionString;
                    break;
            }

            connectionString = string.Format(connectionString, filePath);

            using (OleDbConnection connExcel = new OleDbConnection(connectionString))
            {
                using (OleDbCommand cmdExcel = new OleDbCommand())
                {
                    using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                    {
                        cmdExcel.Connection = connExcel;

                        connExcel.Open();
                        DataTable dtExcelSchema;
                        dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        connExcel.Close();


                        connExcel.Open();
                        cmdExcel.CommandText = "Select * From [" + sheetName + "]";
                        odaExcel.SelectCommand = cmdExcel;
                        odaExcel.Fill(dtSheet);
                        connExcel.Close();

                    }
                }
            }
            ExcelData.Tables.Add(dtSheet);
            return View(ExcelData);

        }


    }
}