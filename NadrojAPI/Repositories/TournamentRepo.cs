using System;
using System.Text;
using Dapper;
using NadrojAPI.Models;
using Npgsql;

namespace NadrojAPI.Repositories
{
    public class TournamentRepo : ITournamentRepo
    {

        private readonly IConfiguration _config;

        public TournamentRepo(IConfiguration config)
        {
            _config = config;
        }



        public IEnumerable<TournamentModel> GetAll()
        {
            string sqlCommand = "SELECT * FROM public.tournaments;";
            using (var connection = new NpgsqlConnection(_config.GetConnectionString("Demo")))
            {
                return connection.Query<TournamentModel>(sqlCommand).AsEnumerable();
            }
        }

        public TournamentModel GetById(int Id)
        {
            string sqlCommand = "select * from public.tournaments where \"tournamentId\" = " + Id + ";";
            using (var connection = new NpgsqlConnection(_config.GetConnectionString("Demo")))
            {
                var tourney = connection.Query<TournamentModel>(sqlCommand).FirstOrDefault();

                return tourney;

            }
        }

        public void Insert(TournamentModel model)
        {
            using (var connection = new NpgsqlConnection(_config.GetConnectionString("Demo")))
            {
                var sqlCommand = new StringBuilder();

                sqlCommand.AppendFormat(@"
                INSERT INTO public.tournaments(
	            ""nickName"", ""numEntries"", ""prizePool"", ""entryFee"")
	            VALUES ('{0}', {1}, {2}, {3});
                ", model.nickName, model.numEntries, model.prizePool, model.entryFee);

                connection.Execute(sqlCommand.ToString());
               
            }
        }
    }
}
