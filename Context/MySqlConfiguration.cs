namespace actividad_3_back.Context
{
    public class MySqlConfiguration
    {
        public MySqlConfiguration(string connectionString) { 
            ConnectionString = connectionString;
        }
        public string ConnectionString { get; set; }
    }
}
