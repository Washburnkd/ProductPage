using Dapper;
using Microsoft.Data.SqlClient;
using ProductPage.Data;
using ProductPage.Models;
using ProductPage.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ProductPage.Repository.Service
{
    public static class UploadingImages
        //: IUploadingImages
    {
        private static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Server=tcp:pinitgoserver.database.windows.net,1433;Initial Catalog=pinitgodb;Persist Security Info=False;User ID=pinitgoadmin;Password=Goldclaw1!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
        

        public static long UploadImages(Upload model)
        {

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@AID", model.AID);
                    param.Add("@Name", model.Name);
                    var reader = conn.ExecuteScalar<long>("AddImage", param, commandType: CommandType.StoredProcedure);
                    return reader;
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            }
        }
        public static OfferModel GetUploadImages(int offer)
        {

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    OfferModel model = new OfferModel();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@Offer", offer);
                    var reader = conn.QueryMultiple("GetImaginator", param, commandType: CommandType.StoredProcedure); // multiple result
                    model.Uploadlist = reader.Read<UploadModel>().ToList();
                    model.Formlist = reader.Read<XformModel>().ToList();
                    model.Selectionlist = reader.Read<SelectionModel>().ToList();
                   
                    return model;
                }
                catch (Exception ex)
                {

                    throw;
                }

            }
        }
        public static bool UpdateWidth(int XID)
        {

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    OfferModel model = new OfferModel();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@XID", XID);
                    var reader = conn.ExecuteScalar("UpdateWidth", param, commandType: CommandType.StoredProcedure); // multiple result
                   
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }
    }
}
