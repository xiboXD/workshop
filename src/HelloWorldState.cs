using System.Diagnostics.CodeAnalysis;
using AElf.Contracts.Consensus.AEDPoS;
using AElf.Sdk.CSharp.State;
using AElf.Types;
using AElf.Standards.ACS6;

namespace AElf.Contracts.HelloWorld
{
    // The state class is used to communicate with the blockchain.
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class HelloWorldState : ContractState 
    {
        // StringState is used to put the single data.
        public StringState Message { get; set; }
        public StringState Character { get; set; }
       internal RandomNumberAccessorContractContainer.RandomNumberAccessorContractReferenceState ConsensusContract { get; set; }
    }
}