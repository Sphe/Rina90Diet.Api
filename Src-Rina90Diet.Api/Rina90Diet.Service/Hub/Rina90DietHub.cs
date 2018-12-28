using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rina90Diet.Service
{
    public class Rina90DietHub : Hub
    {
        private static long _userCount = 0;
        private ILogger<Rina90DietHub> _logger;

        public Rina90DietHub(ILogger<Rina90DietHub> logger)
        {
            _logger = logger;
        }

        public long GetOnline()
        {
            return _userCount;
        }

        public override async Task OnConnectedAsync()
        {
            Interlocked.Increment(ref _userCount);

            await Clients.All.SendCoreAsync("online", new object[] { _userCount });

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            if (Interlocked.Read(ref _userCount) > 0)
            {
                Interlocked.Decrement(ref _userCount);
            }

            await Clients.All.SendCoreAsync("online", new object[] { _userCount });

            await base.OnDisconnectedAsync(exception);
        }
    }
}
