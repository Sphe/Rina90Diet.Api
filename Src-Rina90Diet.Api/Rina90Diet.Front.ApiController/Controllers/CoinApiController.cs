using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

using IO.Swagger.Models;
using Swashbuckle.AspNetCore.Annotations;
using Rina90Diet.Service.Contract;
using Rina90Diet.Dto;
using Rina90Diet.Model.FullDomain;
using Rina90Diet.Service.BusinessImplService.Contract;

namespace Rina90Diet.ApiController.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CoinApiController : Controller
    {

        private readonly IDbContextService _dbContext;
        private readonly IGenericCrudService<CoinWalletDto, Coinwallet> _coinWalletService;
        private readonly IGenericCrudService<UserBlockchainAdressDto, Userblockchainaddress> _userBlockchainAdressService;

        public CoinApiController(IDbContextService dbContext,
            IGenericCrudService<CoinWalletDto, Coinwallet> coinWalletService,
            IGenericCrudService<UserBlockchainAdressDto, Userblockchainaddress> userBlockchainAdressService)
        {
            _dbContext = dbContext;
            _coinWalletService = coinWalletService;
            _userBlockchainAdressService = userBlockchainAdressService;
        }



        [HttpGet]
        [Route("/v1/coin/walletlist")]

        [SwaggerOperation("WalletlistGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<CoinWalletDto>))]
        public async Task<IActionResult> WalletlistGet([FromQuery]string customerId)
        {

            _dbContext.RefreshFullDomain();
            var res1 = await _coinWalletService.GetAllAsync();

            return new ObjectResult(res1);

        }
                          
        /// <summary>
        /// 
        /// </summary>

        /// <param name="customerId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/coin/balance")]
        
        [SwaggerOperation("CoinBalanceGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<CoinBalanceKycProcess>))]
        public virtual IActionResult CoinBalanceGet([FromQuery]string customerId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<CoinBalanceKycProcess>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"reason\" : \"reason\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"activate\" : true,\n  \"balanceAvailable\" : 0.8008281904610115,\n  \"debitAmount\" : 1.4658129805029452,\n  \"history\" : [ {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ],\n  \"creditAmount\" : 6.027456183070403,\n  \"coinBalanceKycProcessId\" : \"coinBalanceKycProcessId\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"reason\" : \"reason\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"activate\" : true,\n  \"balanceAvailable\" : 0.8008281904610115,\n  \"debitAmount\" : 1.4658129805029452,\n  \"history\" : [ {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ],\n  \"creditAmount\" : 6.027456183070403,\n  \"coinBalanceKycProcessId\" : \"coinBalanceKycProcessId\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<CoinBalanceKycProcess>>(exampleJson)
            : default(List<CoinBalanceKycProcess>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="customerId"></param>
        /// <param name="contentId"></param>
        /// <param name="transactionId"></param>
        /// <param name="amount"></param>
        /// <param name="reason"></param>
        /// <param name="source"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/coin/mint")]
        
        [SwaggerOperation("CoinCreditGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(CoinBalanceKycProcess))]
        public virtual IActionResult CoinCreditGet([FromQuery]string customerId, [FromQuery]string contentId, [FromQuery]string transactionId, [FromQuery]double? amount, [FromQuery]string reason, [FromQuery]string source)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoinBalanceKycProcess));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"reason\" : \"reason\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"activate\" : true,\n  \"balanceAvailable\" : 0.8008281904610115,\n  \"debitAmount\" : 1.4658129805029452,\n  \"history\" : [ {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ],\n  \"creditAmount\" : 6.027456183070403,\n  \"coinBalanceKycProcessId\" : \"coinBalanceKycProcessId\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoinBalanceKycProcess>(exampleJson)
            : default(CoinBalanceKycProcess);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="customerId"></param>
        /// <param name="contentId"></param>
        /// <param name="transactionId"></param>
        /// <param name="amount"></param>
        /// <param name="reason"></param>
        /// <param name="source"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/coin/burn")]
        
        [SwaggerOperation("CoinDebitGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(CoinBalanceKycProcess))]
        public virtual IActionResult CoinDebitGet([FromQuery]string customerId, [FromQuery]string contentId, [FromQuery]string transactionId, [FromQuery]double? amount, [FromQuery]string reason, [FromQuery]string source)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoinBalanceKycProcess));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"reason\" : \"reason\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"customerId\" : \"customerId\",\n  \"contentId\" : \"contentId\",\n  \"activate\" : true,\n  \"balanceAvailable\" : 0.8008281904610115,\n  \"debitAmount\" : 1.4658129805029452,\n  \"history\" : [ {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"contentId\" : \"contentId\",\n    \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n    \"validated\" : true,\n    \"createdBy\" : \"createdBy\",\n    \"voucherId\" : \"voucherId\",\n    \"customerId\" : \"customerId\",\n    \"activate\" : true,\n    \"modifiedBy\" : \"modifiedBy\",\n    \"credit\" : 5.962133916683182,\n    \"debit\" : 5.637376656633329,\n    \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ],\n  \"creditAmount\" : 6.027456183070403,\n  \"coinBalanceKycProcessId\" : \"coinBalanceKycProcessId\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoinBalanceKycProcess>(exampleJson)
            : default(CoinBalanceKycProcess);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="customerId"></param>
        /// <param name="contentIdSource"></param>
        /// <param name="contentIdDestination"></param>
        /// <param name="amountToExchange"></param>
        /// <param name="reason"></param>
        /// <param name="source"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpPost]
        [Route("/v1/coin/exchange")]
        
        [SwaggerOperation("CoinExchangePost")]
        [ProducesResponseType(statusCode: 200, type: typeof(CoinExchange))]
        public virtual IActionResult CoinExchangePost([FromQuery]string customerId, [FromQuery]string contentIdSource, [FromQuery]string contentIdDestination, [FromQuery]double? amountToExchange, [FromQuery]string reason, [FromQuery]string source)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoinExchange));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"reason\" : \"reason\",\n  \"success\" : true,\n  \"coinDestination\" : {\n    \"coinBalance\" : 0.8008281904610115,\n    \"contentId\" : \"contentId\",\n    \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\"\n  },\n  \"coinSource\" : {\n    \"coinBalance\" : 0.8008281904610115,\n    \"contentId\" : \"contentId\",\n    \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\"\n  },\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoinExchange>(exampleJson)
            : default(CoinExchange);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="customerIdSource"></param>
        /// <param name="customerIdDestination"></param>
        /// <param name="contentId"></param>
        /// <param name="amount"></param>
        /// <param name="reason"></param>
        /// <param name="source"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/coin/transfer")]
        
        [SwaggerOperation("CoinTransferGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(CoinTransfer))]
        public virtual IActionResult CoinTransferGet([FromQuery]string customerIdSource, [FromQuery]string customerIdDestination, [FromQuery]string contentId, [FromQuery]double? amount, [FromQuery]string reason, [FromQuery]string source)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CoinTransfer));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "{\n  \"customerIdSource\" : \"customerIdSource\",\n  \"reason\" : \"reason\",\n  \"coinValueDebitFromSource\" : {\n    \"coinBalance\" : 0.8008281904610115,\n    \"contentId\" : \"contentId\",\n    \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\"\n  },\n  \"coinValueCreditToDestination\" : {\n    \"coinBalance\" : 0.8008281904610115,\n    \"contentId\" : \"contentId\",\n    \"blockchainBlockchainAssetSymbol\" : \"blockchainBlockchainAssetSymbol\"\n  },\n  \"success\" : true,\n  \"contentId\" : \"contentId\",\n  \"customerIdDestination\" : \"customerIdDestination\",\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<CoinTransfer>(exampleJson)
            : default(CoinTransfer);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="deviceId"></param>
        /// <response code="200">Success</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbidden</response>
        [HttpGet]
        [Route("/v1/coin/todayBalanceEntries")]
        
        [SwaggerOperation("TodayBalanceEntriesGet")]
        [ProducesResponseType(statusCode: 200, type: typeof(List<CoinBalanceEntry>))]
        public virtual IActionResult TodayBalanceEntriesGet([FromQuery]string deviceId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<CoinBalanceEntry>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403);

            string exampleJson = null;
            exampleJson = "[ {\n  \"contentId\" : \"contentId\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n  \"validated\" : true,\n  \"createdBy\" : \"createdBy\",\n  \"voucherId\" : \"voucherId\",\n  \"customerId\" : \"customerId\",\n  \"activate\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"credit\" : 5.962133916683182,\n  \"debit\" : 5.637376656633329,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n}, {\n  \"contentId\" : \"contentId\",\n  \"createdOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"modifiedOn\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"coinBalanceEntryId\" : \"coinBalanceEntryId\",\n  \"validated\" : true,\n  \"createdBy\" : \"createdBy\",\n  \"voucherId\" : \"voucherId\",\n  \"customerId\" : \"customerId\",\n  \"activate\" : true,\n  \"modifiedBy\" : \"modifiedBy\",\n  \"credit\" : 5.962133916683182,\n  \"debit\" : 5.637376656633329,\n  \"timestamp\" : \"2000-01-23T04:56:07.000+00:00\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<CoinBalanceEntry>>(exampleJson)
            : default(List<CoinBalanceEntry>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
