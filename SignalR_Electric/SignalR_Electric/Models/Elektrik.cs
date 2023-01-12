using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Electric.Models
{
		public enum Ecity
		{
			istanbul = 1,
			ankara = 2,
			izmir = 3,
			konya = 4,
			trabzon = 5,
		}

		public class Elektrik
		{
			public int ElektrikId { get; set; }
			public Ecity City { get; set; }
			public int Count { get; set; }
			public DateTime ElectricDate { get; set; }
		}
	}

