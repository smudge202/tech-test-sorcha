using System;
using System.Buffers;
using System.Security.Cryptography;

namespace Speik.TechnicalTest
{
    internal sealed class CryptoRandomNumberGenerator : IRandomNumberGenerator, IDisposable
    {
        private readonly RNGCryptoServiceProvider _provider = new();
        private readonly MemoryPool<byte> _owner = MemoryPool<byte>.Shared;
        
        public int GetNumber(int maximum)
        {
            if (maximum == 0) 
                return 0;
            // scoped for thread safety
            using var buffer = _owner.Rent(4);
            var data = buffer.Memory.Slice(0, 4);
            _provider.GetNonZeroBytes(data.Span);

            var randomInteger = BitConverter.ToUInt16(data.Span);
            return randomInteger % (maximum + 1);
        }

        public void Dispose() => _provider?.Dispose();
    }
}