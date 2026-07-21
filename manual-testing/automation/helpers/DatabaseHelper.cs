namespace automation;

using Microsoft.Data.Sqlite;

public class DatabaseHelper
{
    private readonly string _connectionString;

    public DatabaseHelper()
    {
        _connectionString = "Data Source=../Database/QA_Test.db";
    }

    public string GetLastLogin(string email)
    {
        using var connection = new SqliteConnection(_connectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = """
            SELECT LastLogin
            FROM Users
            WHERE Email = @Email;
            """;

        command.Parameters.AddWithValue("@Email", email);

        var result = command.ExecuteScalar();
        return result?.ToString() ?? string.Empty;
    }
}
