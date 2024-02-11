using ApplicationTibiDatas.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder  =  Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddDbContext<DataContext>(x => x.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Education\\c-sharp\\ApplicationTibiDatas\\ApplicationTibiDatas\\Data\\database_local.mdf;Integrated Security=True;Connect Timeout=30"));


}).Build();