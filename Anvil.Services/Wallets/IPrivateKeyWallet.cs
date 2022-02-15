﻿using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anvil.Services.Wallets
{
    /// <summary>
    /// A private key based wallet.
    /// </summary>
    public interface IPrivateKeyWallet : IAliasedWallet
    {
        /// <summary>
        /// The path to the keystore.
        /// </summary>
        string Path { get; }
    }
}
