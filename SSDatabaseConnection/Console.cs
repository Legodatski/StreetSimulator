
using SSDatabaseConnection.Data;

Context context = new Context();

context.Database.EnsureCreated();
Console.WriteLine("db created");
Import();


void Import()
{

}
