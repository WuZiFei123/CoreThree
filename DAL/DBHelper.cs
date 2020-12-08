using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        static string StrConn = "Data Source=.;Initial Catalog=CoreTwo;Integrated Security=True";
        //查询
        public static List<T> GetList<T>(string sql)
        {
            using (SqlConnection conn = new SqlConnection (StrConn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string Str = JsonConvert.SerializeObject(dt);
                List<T> List = JsonConvert.DeserializeObject<List<T>>(Str);
                return List;
            }
        }
        //查询单个
        public static T GetOne<T>(string sql)
        {
            using (SqlConnection conn = new SqlConnection (StrConn))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql,conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                string Str = JsonConvert.SerializeObject(dt);
                List<T> List = JsonConvert.DeserializeObject<List<T>>(Str);
                if(List.Count>0)
                {
                    return List[0];
                }
                else
                {
                    return default(T);
                }
            }
        }
        //增删改
        public static int CDU(string sql)
        {
            using (SqlConnection conn = new SqlConnection(StrConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql,conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
