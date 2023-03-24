using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace z3
{
    class Program
    {
        class SQL
        {
            static void Main(string[] args)
            {
                string conn_string = @"Data Source=WIN-QO76G3A37LJ;Initial Catalog=avto;Integrated Security=True";
                SqlConnection sql_conn = new SqlConnection(conn_string);
                SQL cmd = new SQL("select количество from заказы where количество > 2");
                SQL sql_comm = new SQL(cmd.CommandText, sql_conn);
                sql_conn.Open();
                Console.WriteLine(sql_comm.ExecuteScalar());
                sql_conn.Close();
                Console.ReadKey(true);
            }

            private string _commandtext;
            string conn_string = @"Data Source=WIN-QO76G3A37LJ;Initial Catalog=avto;Integrated Security=True";
            public string CommandText
            {
                get
                {
                    return _commandtext;
                }
                private set
                {
                    _commandtext = UpperCommandTextOperators(value);
                }
            }
            private string UpperCommandTextOperators(string commandText)
            {
                string[] operators = { "create", "alter", "drop", "select", "insert", "update", "delete", "table",
                    "from", "where", "and", "or", "not", "in", "between", "like", "order by", "asc", "desc", "group by",
                    "not null", "default", "values", "set", "is null", "as", "database", "avg", "sum", "min", "max", "count"};
                for (int i = 0; i < operators.Length; i++)
                {
                    commandText = commandText.Replace(operators[i], operators[i].ToUpper());
                }
                return commandText;
            }
            public SQL(string commandText)
            {
                CommandText = commandText;
            }
        }
        
    }
}
