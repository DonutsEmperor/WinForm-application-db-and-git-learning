﻿namespace MyWinFormsAppForDb.Services
{
	public class DatabaseInspector
	{
		private AppDbContext _context;

		public DatabaseInspector(AppDbContext context)
		{
			_context = context;
		}

		public void InspectDatabase()
		{
			if (!_context.Database.CanConnect())
			{
				MessageBox.Show("App has no bound with db");
				Application.Exit();
			}

			_context.Users.Load();

			if (_context.Users.Count() == 0)
			{
				MessageBox.Show("Db has no items inside");
				return;
			}
		}
	}
}
