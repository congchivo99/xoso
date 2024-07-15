using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace xoso
{
    public struct thamsosql
    {
        public string ten;
        public string giatri;
        public SqlDbType kieu;
    }

    class XLDL
    {
        static string chuoi_ket_noi = System.Configuration.ConfigurationManager.ConnectionStrings["xosoConn"].ConnectionString;

        public static DataTable Doc_bang(string LenhSQL)
        {
            DataTable bang = new DataTable();
            using (SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi))
            {
                SqlDataAdapter bo_doc_ghi = new SqlDataAdapter(LenhSQL, ket_noi);
                bo_doc_ghi.Fill(bang);
            }
            return bang;
        }//Doc_bang

        public static DataTable Doc_bang(string Ten_Proc, thamsosql[] thamso)
        {
            using (SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi))
            {
                DataTable bang = new DataTable();
                try
                {
                    ket_noi.Open();
                    SqlCommand bo_lenh = new SqlCommand(Ten_Proc, ket_noi);
                    bo_lenh.CommandType = CommandType.StoredProcedure;
                    bo_lenh.Parameters.Clear();
                    for (int i = 0; i < thamso.Length; i++)
                    {
                        bo_lenh.Parameters.Add(thamso[i].ten, thamso[i].kieu).Value = thamso[i].giatri;
                    }
                    SqlDataAdapter bo_doc_ghi = new SqlDataAdapter(bo_lenh);
                    bo_doc_ghi.FillSchema(bang, SchemaType.Mapped);
                    bo_doc_ghi.Fill(bang);
                    return bang;
                }
                catch (Exception ex)
                {
                    DataTable dt = new DataTable();
                    /*
                    DataColumn dc = new DataColumn("Message", typeof(String));
                    DataRow dr = dt.NewRow();

                    dt.Columns.Add(dc);
                    dr[0] = ex.Message;
                    dt.Rows.Add(dr);
                    */
                    return dt;
                }
            }
        }//Doc_bang
        public static DataTable Doc_bang2(string Ten_Proc)
        {
            using (SqlConnection ket_noi = new SqlConnection(chuoi_ket_noi))
            {
                DataTable bang = new DataTable();
                try
                {
                    ket_noi.Open();
                    SqlCommand bo_lenh = new SqlCommand(Ten_Proc, ket_noi);
                    bo_lenh.CommandType = CommandType.StoredProcedure;
                    bo_lenh.Parameters.Clear();

                    SqlDataAdapter bo_doc_ghi = new SqlDataAdapter(bo_lenh);
                    bo_doc_ghi.FillSchema(bang, SchemaType.Mapped);
                    bo_doc_ghi.Fill(bang);
                    return bang;
                }
                catch (Exception ex)
                {
                    DataTable dt = new DataTable();
                    /*
                    DataColumn dc = new DataColumn("Message", typeof(String));
                    DataRow dr = dt.NewRow();

                    dt.Columns.Add(dc);
                    dr[0] = ex.Message;
                    dt.Rows.Add(dr);
                    */
                    return dt;
                }
            }
        }//Doc_bang2

    }//class XLDL
}//namespace xoso
