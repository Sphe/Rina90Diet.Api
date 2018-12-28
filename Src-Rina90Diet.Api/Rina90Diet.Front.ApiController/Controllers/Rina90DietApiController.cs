using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Rina90Diet.Service.BusinessImplService.Contract;
using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Rina90Diet.ApiController.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    public class Rina90DietApiController : Controller
    {

        private readonly IRina90DietBusinessService _rina90DietBusinessService;
        private readonly IGenericCrudService<UserBlockchainAdressDto, Userblockchainaddress> _userBlockchainAdressService;

        public Rina90DietApiController(IRina90DietBusinessService rina90DietBusinessService,
            IGenericCrudService<UserBlockchainAdressDto, Userblockchainaddress> userBlockchainAdressService)
        {
            _rina90DietBusinessService = rina90DietBusinessService;
            _userBlockchainAdressService = userBlockchainAdressService;
        }

        [HttpGet]
        [Route("/v1/rina90Diet/useraddresslist")]
        [SwaggerOperation("UserAddressListGet")]
        [ProducesResponseType(typeof(List<UserBlockchainAdressDto>), 200)]
        public async Task<IActionResult> UserAddressListGet([FromQuery] string customerId)
        {
            var addressList = await _userBlockchainAdressService.GetListByPredicateAsync((x => {
                return x.Userid.ToString() == customerId;
            }), d =>
            {
                return d;
            });

            return new JsonResult(addressList);
        }

        [HttpPost]
        [HttpGet]
        [Route("/v1/rina90Diet/whitelistadd")]
        [SwaggerOperation("AddAdressToWhitelistGet")]
        [ProducesResponseType(typeof(JsonResult), 200)]
        public async Task<IActionResult> AddAdressToWhitelistGet([FromQuery] string customerId, [FromQuery] string addressToWhitelist, [FromQuery] string walletName)
        {
            var addressList = await _userBlockchainAdressService.GetListByPredicateAsync((x => {
                return x.Userid.ToString() == customerId;
            }), d =>
            {
                return d;
            });

            if (addressList.Any(x1 => x1.Blockchainpublicaddress.ToLowerInvariant() == addressToWhitelist.ToLowerInvariant()))
            {
                return new JsonResult("already added");
            }

            var str1 = await _rina90DietBusinessService.AddAdressToWhitelist(addressToWhitelist);

            var userAdress = new UserBlockchainAdressDto();

            userAdress.Active = true;
            userAdress.Blockchainentityid = 1;
            userAdress.Userid = Convert.ToInt32(customerId);
            userAdress.Blockchainpublicaddress = addressToWhitelist;
            userAdress.Blockchainprivatekey = string.Empty;
            userAdress.Walletname = walletName;
            userAdress.Isdefault = false;

            var res1 = await _userBlockchainAdressService.CreateAsync(userAdress, (x => { return x.Userblockchainaddressid == userAdress.Userblockchainaddressid; }));
            
            return new JsonResult(str1);
        }

        [HttpGet]
        [Route("/v1/rina90Diet/requestMint")]
        [SwaggerOperation("RequestMint")]
        [ProducesResponseType(typeof(JsonResult), 200)]
        public virtual async Task<IActionResult> RequestMint([FromQuery] string addresstest, [FromQuery] long amount)
        {
            var str1 = await _rina90DietBusinessService.RequestMint(addresstest, amount);

            return new JsonResult(str1);
        }

        [HttpGet]
        [Route("/v1/rina90Diet/balanceOf")]
        [SwaggerOperation("BalanceOf")]
        [ProducesResponseType(typeof(JsonResult), 200)]
        public virtual async Task<IActionResult> BalanceOf([FromQuery] string address)
        {
            var str1 = await _rina90DietBusinessService.BalanceOf(address);

            return new JsonResult(str1);
        }

        [HttpGet]
        [Route("/v1/rina90Diet/globcoinAdress")]
        [SwaggerOperation("GetGlobcoinAdress")]
        [ProducesResponseType(typeof(JsonResult), 200)]
        public virtual async Task<IActionResult> GetGlobcoinAdress()
        {
            return new JsonResult(_rina90DietBusinessService.GetGlobCoinAddress());
        }

    }
}
