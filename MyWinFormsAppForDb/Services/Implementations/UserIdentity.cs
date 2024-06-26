﻿namespace MyWinFormsAppForDb.Services.Implementations
{
	internal class UserIdentity : IUserIdentity
	{
		private User? _currentUser = null;	

		public void Login(User user)
		{
			_currentUser = user;
		}

		public User GetUser() => _currentUser ?? null!;

		public string GetRole() => _currentUser?.Role ?? string.Empty;

		public void LogOut()
		{
			_currentUser = null;
		}
	}
}
