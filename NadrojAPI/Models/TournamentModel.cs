using System;
using System.ComponentModel.DataAnnotations;

namespace NadrojAPI.Models
{
	public class TournamentModel
	{
		[Key]
		public int tournamentId { get; set; }

		[Required]
		public string? nickName { get; set; }

		[Required]
		public int numEntries { get; set; }

		[Required]
		public double entryFee { get; set; }

		[Required]
        public double prizePool { get; set; }
    }
}

