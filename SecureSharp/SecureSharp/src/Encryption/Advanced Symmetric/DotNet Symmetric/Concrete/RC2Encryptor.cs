﻿using System.Security.Cryptography;

namespace SecureSharp.Encryption.AdvancedSymmetric.DotNetSymmetric
{
    /// <summary>
    /// SymmetricEncryptor class used for encrypting data using the <see cref="RC2CryptoServiceProvider"/> <see cref="SymmetricAlgorithm"/>.
    /// </summary>
    public sealed class RC2Encryptor : SymmetricEncryptor<RC2Encryptor, RC2CryptoServiceProvider>
    {
        /// <summary>
        /// The key size of the <see cref="SymmetricAlgorithm"/>.
        /// </summary>
        protected override int KeySize => 128;

        /// <summary>
        /// The number of bytes to use for the salt and iv for the <see cref="SymmetricAlgorithm"/>.
        /// </summary>
        protected override int SaltIvByteSize => 64;

        /// <summary>
        /// Initializes the <see cref="RC2Encryptor"/> by assigning all additional encryptors to encrypt the data with.
        /// </summary>
        /// <param name="encryptors"> The encryptors to encrypt/decrypt data with. </param>
        public RC2Encryptor(params object[] encryptors) : base(encryptors)
        {
        }

        /// <summary>
        /// Initializes the <see cref="RC2Encryptor"/>.
        /// </summary>
        public RC2Encryptor()
        {
        }
    }
}
