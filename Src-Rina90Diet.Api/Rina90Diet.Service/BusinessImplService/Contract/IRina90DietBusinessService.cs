using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Rina90Diet.Service.BusinessImplService.Contract
{
    public interface IRina90DietBusinessService
    {
        string GetGlobCoinAddress();

        Task<object> AddAdressToWhitelist(string adress);

        Task<object> RequestMint(string adress, long amount);

        Task<BigInteger> BalanceOf(string owner);

    }
}
