using FMS.Services.AzueFileUploadAPI.Model.DropdownOptions;
using FMS.Services.AzueFileUploadAPI.Services.IService;
using System.Data;
using System.Data.SqlClient;

namespace FMS.Services.AzueFileUploadAPI.Services.Service
{
    public class DrowpdownOptionsService : IDrowpdownOptionsService
    {
        string connectionString = "Data Source=OCTOCAT\\SQLEXPRESS;Initial Catalog=IncedoFMSDb;Integrated Security=True";
        public async Task<IEnumerable<DelimiterOptions>> GetDelimiterOptionsAsync()
        {
            List<DelimiterOptions> data = new List<DelimiterOptions>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM DelimiterDetailsMaster";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DelimiterDetailsMaster");

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int id = Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString());
                            string name = ds.Tables[0].Rows[i]["Name"].ToString();
                            string description = ds.Tables[0].Rows[i]["Symbol"].ToString();

                            DelimiterOptions delimiterOptions = new DelimiterOptions
                            {
                                Id = id,
                                Name = name,
                                Description = description
                            };

                            data.Add(delimiterOptions);
                        }
                    }
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public async Task<IEnumerable<VendorOptions>> GetVendorOptionsAsync()
        {
            List<VendorOptions> data = new List<VendorOptions>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM VendorDetailsMaster";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DelimiterDetailsMaster");

                    if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            int id = Convert.ToInt32(ds.Tables[0].Rows[i]["id"].ToString());
                            string name = ds.Tables[0].Rows[i]["Name"].ToString();

                            VendorOptions vendorOptions = new VendorOptions
                            {
                                Id = id,
                                Name = name,
                            };

                            data.Add(vendorOptions);
                        }
                    }
                }
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
