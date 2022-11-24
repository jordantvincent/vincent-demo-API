using System;
using NadrojAPI.Models;

namespace NadrojAPI.Repositories
{
	public interface ITournamentRepo
	{
		public IEnumerable<TournamentModel> GetAll();
		public TournamentModel GetById(int Id);
		void Insert(TournamentModel model);
    }
}

