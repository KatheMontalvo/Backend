using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace backend_tc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get;}

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "backend_tc", Version = "v1" });
            });

            services.AddDbContext<AplicationsDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
        }

    }
}
