using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace Tarefas
{
    public class SQLiteConnectionManager
    {
        private string connectionString;

        public SQLiteConnectionManager(string databasePath)
        {
            connectionString = $"Data Source={databasePath};";
        }
        public SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }
        public void OpenConnection(SqliteConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection(SqliteConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public void ExecuteNonQuery(String query)
        {
            using (var connection = GetConnection())
            {
                OpenConnection(connection);
                using (var command = new SqliteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                CloseConnection(connection);
            }
        }


        public void CriarTabelaTarefas()
        {
            string createTableQuery = @"CREATE TABLE IF NOT EXISTS Tarefas (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Descricao TEXT NOT NULL,
                                        Concluida INTEGER NOT NULL
                                     );";
            ExecuteNonQuery(createTableQuery);
        }

        
    }
}
