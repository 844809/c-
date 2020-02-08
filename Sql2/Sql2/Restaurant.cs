using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sql2
{
    class Restaurant

    {

        public void show()
        {
            string constr = @"Data Source=BLT1079\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    string querystr = "select *  from [Restaurnt]";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querystr, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2],reader[3],reader[4]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
        public void insert()
        {
            string constr = @"Data Source=BLT1079\SQLEXPRESS2014;Initial Catalog=EmployeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    // string querystr = "insert into Restaurnt(resname,resloc,opentime,closetime;)";
                    string r = Console.ReadLine();
                    con.Open();
                    SqlCommand cmd = new SqlCommand(r, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3],reader[4]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
