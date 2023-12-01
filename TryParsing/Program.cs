using Microsoft.EntityFrameworkCore;
using TryParsing;
//  Postgres only
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
MainContext context = new();
//var lines = File.ReadAllLines(@"C:\Users\New\Desktop\client_b_import.txt")
//    .ToList();
//lines.RemoveAt(0);
//var clients = new List<Client>();
//foreach (var line in lines)
//{
//    var columns = line.Split(',').Select(x => x.Trim())
//        .ToArray();
//    var fullName = columns[0];
//    if(fullName.Contains(" "))
//    {
//        var names = fullName.Split(' ');
//        columns[0] = names[0];
//        columns[1] = names[1];
//        columns[2] = names[2];
//    }
//    columns[3] = columns[3].ToLower()[0].ToString();
//    var birthday = DateTime.Parse(columns[5]);
//    var regDate = DateTime.Parse(columns[7]);
//    clients.Add(new Client
//    {
//        Birthday = birthday,
//        RegistrationDate = regDate,
//        FirstName = columns[0],
//        LastName = columns[1],
//        Patronymic = columns[2],
//        IsMen = columns[3] == "м",
//        Phone = columns[4],
//        Email = columns[6],
//    });
//}
//context.Clients.AddRange(clients);
//context.SaveChanges();

var clients = context.Clients.ToList();
foreach (var client in clients)
{
    Console.WriteLine(client.ToString());
}