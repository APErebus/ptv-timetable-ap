using System.Text;
using PCLCrypto;

namespace Ptv.Timetable.Api
{
    static class RequestSigner
    {
        public static string ComputeHash(string key, string data)
        {
            //Compute the HMAC-SHA1 Hash
            //get a HMAC-SHA1 Mac Algorithm
            var algorithm = WinRTCrypto.MacAlgorithmProvider.OpenAlgorithm(MacAlgorithm.HmacSha1);

            var keyBuffer = WinRTCrypto.CryptographicBuffer.ConvertStringToBinary(key, Encoding.UTF8);
            var urlBuffer = WinRTCrypto.CryptographicBuffer.ConvertStringToBinary(data, Encoding.UTF8);

            var hmacKey = algorithm.CreateKey(keyBuffer);

            var signedData = WinRTCrypto.CryptographicEngine.Sign(hmacKey, urlBuffer);

            return WinRTCrypto.CryptographicBuffer.EncodeToHexString(signedData).ToUpperInvariant();
        }
    }
}
