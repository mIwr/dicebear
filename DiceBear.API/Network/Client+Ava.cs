using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace FaceGenerator.Network
{
    internal partial class Client
    {
        /// <summary>
        /// Downloads ava image
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        internal async Task<Result<byte[], ApiError>> DownloadAvaImg(Uri link)
        {           
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = link
            };
            var response = await RequestAsGenResponse(request);
            var err = response.Error;
            if (err != null)
            {
                return new Result<byte[], ApiError>(err);
            }
            var dat = response.Data;
            if (dat == null || dat.Length == 0)
            {
                return new Result<byte[], ApiError>(error: ApiErrorEnum.BadResponse.AsException(message: "0 bytes downloaded. Possible the file doesn't exist"));
            }
            return new Result<byte[], ApiError>(dat);
        }
    }
}
