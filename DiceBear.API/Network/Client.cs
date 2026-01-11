using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

using FaceGenerator.Network.Response;
using System.Net;

namespace FaceGenerator.Network
{
    internal partial class Client
    {
        protected HttpClient ApiClient;
        protected int CountRequest;

        internal Client()
        {
            var decompressHandler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };
            ApiClient = new HttpClient(decompressHandler);
            CountRequest = 0;
        }

        internal async Task<GenResponse> RequestAsGenResponse(HttpRequestMessage request)
        {
            ++CountRequest;

            try
            {
                var response = await ApiClient.SendAsync(request);
                if (response == null)
                {
                    return new GenResponse(statusCode: -1, error: ApiErrorEnum.NoResponse.AsException());
                }
                var statusCode = (int)response.StatusCode;

                var reader = new BinaryReader(await response.Content.ReadAsStreamAsync());
                var outStream = new MemoryStream();
                var buffer = new byte[4096];
                var count = 1;
                do
                {
                    count = reader.Read(buffer, 0, buffer.Length);
                    if (count <= 0)
                    {
                        break;
                    }
                    outStream.Write(buffer, 0, count);
                } while (count > 0);
                reader.Close();
                reader.Dispose();

                var responseData = outStream.ToArray();
                outStream.Close();
                return new GenResponse(statusCode, responseData);
            }
            catch (IOException ex)
            {
                Debug.WriteLine(ex);
                return new GenResponse(statusCode: -1, error: ApiErrorEnum.NoConnection.AsException());
            }
        }
    }
}
