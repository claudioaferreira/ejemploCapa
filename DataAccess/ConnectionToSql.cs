namespace DataAccess
{
    using System.Data.SqlClient;
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Data Source=DESKTOP-62PM8SP\\SQLEXPRESS;Initial Catalog=puntoVenta;Integrated Security=True";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
