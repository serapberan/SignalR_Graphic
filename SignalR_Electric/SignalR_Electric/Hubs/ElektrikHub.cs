using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalR_Electric.Hubs
{
    public class ElektrikHub : Hub
    {
		private readonly ElektrikService _service;

		public ElektrikHub(ElektrikService service)
		{
			_service = service;
		}

		public async Task GetElektricList()
		{
			await Clients.All.SendAsync("ReceiveElectricList", _service.GetElectricChartsList());
		}
	}
}
