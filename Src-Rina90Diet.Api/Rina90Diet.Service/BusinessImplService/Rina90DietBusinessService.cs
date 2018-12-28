using Microsoft.Extensions.Logging;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.HdWallet;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.RPC.NonceServices;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using Rina90Diet.Service.BusinessImplService.Contract;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using Nethereum.Contracts;

namespace Rina90Diet.Service.BusinessImplService
{




    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
    }






    public class Rina90DietBusinessService : IRina90DietBusinessService
    {

        private readonly ILogger<Rina90DietBusinessService> _logger;

        private string contractAdress = "0x32d39d520fb14bde8beeb22705408057223ac483";
        //private string registryAdress = "0x687c90bf5714341a9cf2fae9566e37e167206666";

        private string abi = @"[{'constant':true,'inputs':[],'name':'totalSupply','outputs':[{'name':'','type':'uint256'}],'payable':false,'stateMutability':'view','type':'function'},{'constant':false,'inputs':[{'name':'from','type':'address'}],'name':'wipeAddress','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[],'name':'unpause','outputs':[],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'to','type':'address'},{'name':'amount','type':'uint256'}],'name':'mint','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'amount','type':'uint256'}],'name':'burn','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':true,'inputs':[],'name':'paused','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'view','type':'function'},{'constant':true,'inputs':[{'name':'owner','type':'address'}],'name':'balanceOf','outputs':[{'name':'balance','type':'uint256'}],'payable':false,'stateMutability':'view','type':'function'},{'constant':false,'inputs':[],'name':'renounceOwnership','outputs':[],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':true,'inputs':[{'name':'who','type':'address'}],'name':'getIfWhitelisted','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'view','type':'function'},{'constant':false,'inputs':[],'name':'pause','outputs':[],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':true,'inputs':[],'name':'owner','outputs':[{'name':'','type':'address'}],'payable':false,'stateMutability':'view','type':'function'},{'constant':false,'inputs':[{'name':'who','type':'address'}],'name':'whitelist','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':true,'inputs':[{'name':'owner','type':'address'},{'name':'spender','type':'address'}],'name':'allowance','outputs':[{'name':'','type':'uint256'}],'payable':false,'stateMutability':'view','type':'function'},{'constant':false,'inputs':[{'name':'who','type':'address'}],'name':'unWhitelist','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'_newOwner','type':'address'}],'name':'transferOwnership','outputs':[],'payable':false,'stateMutability':'nonpayable','type':'function'},{'anonymous':false,'inputs':[],'name':'Pause','type':'event'},{'anonymous':false,'inputs':[],'name':'Unpause','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'from','type':'address'}],'name':'Wiped','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'to','type':'address'}],'name':'Whitelisted','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'to','type':'address'}],'name':'UnWhitelisted','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'to','type':'address'},{'indexed':false,'name':'amount','type':'uint256'}],'name':'Burn','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'to','type':'address'},{'indexed':false,'name':'amount','type':'uint256'}],'name':'Mint','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'previousOwner','type':'address'}],'name':'OwnershipRenounced','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'previousOwner','type':'address'},{'indexed':true,'name':'newOwner','type':'address'}],'name':'OwnershipTransferred','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'owner','type':'address'},{'indexed':true,'name':'spender','type':'address'},{'indexed':false,'name':'value','type':'uint256'}],'name':'Approval','type':'event'},{'anonymous':false,'inputs':[{'indexed':true,'name':'from','type':'address'},{'indexed':true,'name':'to','type':'address'},{'indexed':false,'name':'value','type':'uint256'}],'name':'Transfer','type':'event'},{'constant':false,'inputs':[{'name':'_to','type':'address'},{'name':'_value','type':'uint256'}],'name':'transfer','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'_from','type':'address'},{'name':'_to','type':'address'},{'name':'_value','type':'uint256'}],'name':'transferFrom','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'_spender','type':'address'},{'name':'_value','type':'uint256'}],'name':'approve','outputs':[{'name':'','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'_spender','type':'address'},{'name':'_addedValue','type':'uint256'}],'name':'increaseApproval','outputs':[{'name':'success','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'},{'constant':false,'inputs':[{'name':'_spender','type':'address'},{'name':'_subtractedValue','type':'uint256'}],'name':'decreaseApproval','outputs':[{'name':'success','type':'bool'}],'payable':false,'stateMutability':'nonpayable','type':'function'}]";
        private string byteCode = "0x608060405234801561001057600080fd5b50604051602080610e968339810180604052602081101561003057600080fd5b8101908080519060200190929190505050806040805190810160405280600d81526020017f476c6f62436f696e2054657374000000000000000000000000000000000000008152506040805190810160405280600481526020017f474c585400000000000000000000000000000000000000000000000000000000815250600682828286806000800160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505033600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550826003908051906020019061014f92919061018f565b50816004908051906020019061016692919061018f565b5080600560006101000a81548160ff021916908360ff1602179055505050505050505050610234565b828054600181600116156101000203166002900490600052602060002090601f016020900481019282601f106101d057805160ff19168380011785556101fe565b828001600101855582156101fe579182015b828111156101fd5782518255916020019190600101906101e2565b5b50905061020b919061020f565b5090565b61023191905b8082111561022d576000816000905550600101610215565b5090565b90565b610c53806102436000396000f3fe6080604052600436106100af576000357c0100000000000000000000000000000000000000000000000000000000900463ffffffff16806306fdde03146101d05780632e0f262514610260578063313ce567146102915780633659cfe6146102c25780635c60da1b14610313578063715018a61461036a5780638da5cb5b1461038157806395d89b41146103d8578063a3f4df7e14610468578063f2fde38b146104f8578063f76f8d7814610549575b60006100b96105d9565b9050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614151515610160576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252600d8152602001807f61646472657373206572726f720000000000000000000000000000000000000081525060200191505060405180910390fd5b60606000368080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f820116905080830192505050505050509050600080825160208401855af43d604051816000823e82600081146101cc578282f35b8282fd5b3480156101dc57600080fd5b506101e5610603565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561022557808201518184015260208101905061020a565b50505050905090810190601f1680156102525780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b34801561026c57600080fd5b506102756106a1565b604051808260ff1660ff16815260200191505060405180910390f35b34801561029d57600080fd5b506102a66106a6565b604051808260ff1660ff16815260200191505060405180910390f35b3480156102ce57600080fd5b50610311600480360360208110156102e557600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506106b9565b005b34801561031f57600080fd5b506103286105d9565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b34801561037657600080fd5b5061037f610888565b005b34801561038d57600080fd5b5061039661098d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b3480156103e457600080fd5b506103ed6109b3565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561042d578082015181840152602081019050610412565b50505050905090810190601f16801561045a5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b34801561047457600080fd5b5061047d610a51565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156104bd5780820151818401526020810190506104a2565b50505050905090810190601f1680156104ea5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b34801561050457600080fd5b506105476004803603602081101561051b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610a8a565b005b34801561055557600080fd5b5061055e610af2565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561059e578082015181840152602081019050610583565b50505050905090810190601f1680156105cb5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6000600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60038054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156106995780601f1061066e57610100808354040283529160200191610699565b820191906000526020600020905b81548152906001019060200180831161067c57829003601f168201915b505050505081565b600681565b600560009054906101000a900460ff1681565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614151561071557600080fd5b8073ffffffffffffffffffffffffffffffffffffffff16600260009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614151515610801576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252602e8152602001807f6e65772061646472657373206d75737420646966666572732066726f6d20637581526020017f7272656e742075736564206f6e6500000000000000000000000000000000000081525060400191505060405180910390fd5b80600260006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055508073ffffffffffffffffffffffffffffffffffffffff167fbc7cd75a20ee27fd9adebab32041f755214dbc6bffa90cc0225b39da2e5c2d3b60405160405180910390a250565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161415156108e457600080fd5b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167ff8df31144d9c2f0f6b59d69b8b98abd5459d07f2742c4df920b25aae33c6482060405160405180910390a26000600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60048054600181600116156101000203166002900480601f016020809104026020016040519081016040528092919081815260200182805460018160011615610100020316600290048015610a495780601f10610a1e57610100808354040283529160200191610a49565b820191906000526020600020905b815481529060010190602001808311610a2c57829003601f168201915b505050505081565b6040805190810160405280600d81526020017f476c6f62436f696e20546573740000000000000000000000000000000000000081525081565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16141515610ae657600080fd5b610aef81610b2b565b50565b6040805190810160405280600481526020017f474c58540000000000000000000000000000000000000000000000000000000081525081565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614151515610b6757600080fd5b8073ffffffffffffffffffffffffffffffffffffffff16600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea165627a7a72305820ca7225a8e84e7b7383cdb6974565f43af527d61967e679f3c180e2ed534ff9e30029";
        private string fromAdress = "0x5b0392f39a45f28ec0eb5f07f879d8efc92309b2";
        

        private string urlRpc = "https://mainnet.infura.io/48c1d612d0ca4debb79575c8ef2f50af";

        private string wordlist = "dove apology alert strike achieve enhance human common raven tone kite voice";

        const long _Gas = 300000;
        const long _GasPrice = 10000000000;

        private Web3 web3Account;
        private Nethereum.Contracts.Contract _contract;

        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);


        public Rina90DietBusinessService(ILogger<Rina90DietBusinessService> logger)
        {
            _logger = logger;

            var account = GetAccount();
            web3Account = new Web3(account, urlRpc);
            _contract = web3Account.Eth.GetContract(abi, contractAdress);
            account.NonceService = new InMemoryNonceService(fromAdress, web3Account.Client);
        }

        private Account GetAccount()
        {
            var account = new Wallet(wordlist, null).GetAccount(fromAdress);
            return account;
        }

        private void AjustGasLimit(Web3 w3)
        {
            //var gp = await w3.Eth.GasPrice.SendRequestAsync();

            //var lastBlock = await w3.Eth.Blocks.GetBlockWithTransactionsByNumber.SendRequestAsync(new BlockParameter(await w3.Eth.Blocks.GetBlockNumber.SendRequestAsync()));

            w3.TransactionManager.DefaultGasPrice = _GasPrice;
            w3.TransactionManager.DefaultGas = _Gas;
        }

        public async Task<TransactionReceipt> MineAndGetReceiptAsync(Web3 web3, string transactionHash)
        {
            var receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);

            while (receipt == null)
            {
                await Task.Delay(1000);
                receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
            }

            return receipt;
        }

        public string GetGlobCoinAddress()
        {

            return "0x32d39d520fb14bde8beeb22705408057223ac483";

        }

        public async Task<object> AddAdressToWhitelist(string adress)
        {

            var w3 = web3Account;

            if (w3 != null)
            {
                await semaphoreSlim.WaitAsync();
                try
                {

                    AjustGasLimit(w3);

                    var contract = w3.Eth.GetContract(abi, contractAdress);

                    var addAddressToWhitelistFunction = contract.GetFunction("whitelist");

                    //var gas = await addAddressToWhitelistFunction.EstimateGasAsync(adress);
                    //var gas = new HexBigInteger(9990000);

                    var trx1 = await addAddressToWhitelistFunction.SendTransactionAsync(fromAdress, adress);

                    await MineAndGetReceiptAsync(w3, trx1);

                    return trx1;

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error whitelist");
                    return string.Concat("Error: ", ex.Message);
                }
                finally
                {
                    semaphoreSlim.Release();
                }
            }


            return null;

        }

        public async Task<object> RequestMint(string adress, long amount)
        {
            var w3 = web3Account;

            if (w3 != null)
            {

                await semaphoreSlim.WaitAsync();
                try
                {

                    AjustGasLimit(w3);

                    var contract = w3.Eth.GetContract(abi, contractAdress);

                    var transferFunction = contract.GetFunction("mint");

                    //var gas = await transferFunction.EstimateGasAsync(fromAdress, adress, amount);
                    //var gas = new HexBigInteger(9990000);

                    var trx1 = await transferFunction.SendTransactionAsync(fromAdress, adress, amount);

                    await MineAndGetReceiptAsync(w3, trx1);

                    return trx1;

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error mint");
                    return string.Concat("Error: ", ex.Message);
                }
                finally
                {
                    semaphoreSlim.Release();
                }

            }

            return null;
        }

        public async Task<BigInteger> BalanceOf(string owner)
        {
            var w3 = web3Account;

            if (w3 != null)
            {
                try
                {

                    AjustGasLimit(w3);

                    var contract = w3.Eth.GetContract(abi, contractAdress);

                    var contractHandler = w3.Eth.GetContractHandler(contractAdress);


                    var balanceOfFunction = new BalanceOfFunction();
                    balanceOfFunction.Owner = owner;

                    return await contractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, null);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error mint");
                    return 0;
                }
                finally
                {
                }

            }

            return 0;
        }

    }

}
