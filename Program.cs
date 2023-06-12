using Microsoft.Data.SqlClient;

if (args.Length == 0) {
    Console.Error.WriteLine("Please supply a connection string.");
    return;
}

using var db = new SqlConnection(args[0]);
using var cmd = new SqlCommand("select 'Connected.'", db);
db.Open();
Console.WriteLine(cmd.ExecuteScalar());
