﻿using Org.BouncyCastle.Crypto.Digests;

namespace SecureSharp.Encryption.PBKDF2
{
    public sealed class WhirlpoolPasswordHashing : PBKDF2PasswordHashing<WhirlpoolDigest>
    {
    }
}