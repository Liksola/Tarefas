using Microsoft.Data.Sqlite;

namespace Tarefas
{
    public partial class Form1 : Form
    {
        private SQLiteConnectionManager connectionManager;

        public Form1()
        {
            InitializeComponent();
            connectionManager = new SQLiteConnectionManager("tarefas.db");
            connectionManager.CriarTabelaTarefas();
            
        }

        private void CarregarTarefas()
        {
            checkedListBoxTarefas.Items.Clear();

            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);
                string query = "SELECT * FROM Tarefas";
                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string descricao = reader["Descricao"].ToString();
                        bool concluida = Convert.ToBoolean(reader["Concluida"]);
                        checkedListBoxTarefas.Items.Add(descricao, concluida);
                    }
                }
                connectionManager.CloseConnection(connection);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            CarregarTarefas();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);
                    string query = "INSERT INTO Tarefas (Descricao, Concluida) VALUES (@Descricao, 0)";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Descricao", txtTarefa.Text);
                        command.ExecuteNonQuery();
                    }
                    connectionManager.CloseConnection(connection);
                }

                txtTarefa.Clear();
                CarregarTarefas();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Deseja excluir essa tarefa?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                if (checkedListBoxTarefas.SelectedIndex >= 0)
                {
                    string descricao = checkedListBoxTarefas.SelectedItem.ToString();

                    using (var connection = connectionManager.GetConnection())
                    {
                        connectionManager.OpenConnection(connection);
                        string query = "DELETE FROM Tarefas WHERE Descricao = @Descricao";
                        using (var command = new SqliteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Descricao", descricao);
                            command.ExecuteNonQuery();
                        }
                        connectionManager.CloseConnection(connection);
                    }

                    CarregarTarefas();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var connection = connectionManager.GetConnection())
            {
                connectionManager.OpenConnection(connection);

                foreach (var item in checkedListBoxTarefas.Items)
                {
                    string descricao = item.ToString();
                    bool concluida = checkedListBoxTarefas.CheckedItems.Contains(item);

                    string query = "UPDATE Tarefas SET Concluida = @Concluida WHERE Descricao = @Descricao";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Concluida", concluida ? 1 : 0);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.ExecuteNonQuery();
                    }
                }
                connectionManager.CloseConnection(connection);
            }

            MessageBox.Show("Tarefas salvas com sucesso!");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show(
                "Deseja limpar todas as tarefas?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (var connection = connectionManager.GetConnection())
                {
                    connectionManager.OpenConnection(connection);
                    string query = "DELETE FROM Tarefas";
                    using (var command = new SqliteCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                    connectionManager.CloseConnection(connection);
                }

                CarregarTarefas();
            }
        }

        private void btnSait_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
