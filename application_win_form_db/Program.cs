using application_win_form_db.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace application_win_form_db
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        private static IServiceProvider? _serviceProvider;

		[STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var services = new ServiceCollection();
            services.Init();

			_serviceProvider = services.BuildServiceProvider();

			ApplicationConfiguration.Initialize();
			Application.Run(new Analytics());
		}
    }

    internal static class DIExtensions
	{
        internal static void Init(this ServiceCollection services)
        {
            services.AddForms();
            services.AddServices();
        }
        
        private static void AddForms(this ServiceCollection services)
		{
            services.AddTransient<Entrance>();
			services.AddTransient<Main>();
			services.AddTransient<CRUD_db>();
			services.AddTransient<Analytics>();
		}

		private static void AddServices(this ServiceCollection services)
		{
			services.AddDbContext<_107g2_PolovykhNA2Context>();
		}
	}
}