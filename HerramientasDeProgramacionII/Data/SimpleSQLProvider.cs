using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

public class SQLProviderBase
{
    protected readonly string connectionString;

    public SQLProviderBase()
    {
        //Obtener la cadena de conexión de appsettings.json
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    protected virtual List<object[]> ExecuteReader(string query, Dictionary<string, object> parameters = null)
    {
        var results = new List<object[]>();
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            AddParameters(command, parameters);
            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var row = new object[reader.FieldCount];
                    reader.GetValues(row);
                    results.Add(row);
                }
            }
        }
        return results;
    }

    protected virtual object ExecuteScalar(string query, Dictionary<string, object> parameters = null)
    {
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            AddParameters(command, parameters);
            connection.Open();
            return command.ExecuteScalar();
        }
    }

    protected virtual void ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
    {
        using (var connection = new SqlConnection(connectionString))
        using (var command = new SqlCommand(query, connection))
        {
            AddParameters(command, parameters);
            connection.Open();
            command.ExecuteNonQuery();
        }
    }

    private void AddParameters(SqlCommand command, Dictionary<string, object> parameters)
    {
        if (parameters != null)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }
        }
    }

}
