namespace FaceGenerator.Network.Response
{
    /// <summary>
    /// Low-level response data
    /// </summary>
    internal class GenResponse
    {
        /// <summary>
        /// Response status code
        /// </summary>
        internal readonly int StatusCode;
        /// <summary>
        /// Response payload data
        /// </summary>
        internal readonly byte[]? Data;
        /// <summary>
        /// Response parsed error
        /// </summary>
        internal readonly ApiError? Error;

        internal bool Success
        {
            get
            {
                return StatusCode >= 200 && StatusCode < 300 && Error == null;
            }
        }

        internal GenResponse(int statusCode, byte[] data, ApiError error)
        {
            StatusCode = statusCode;
            Data = data;
            Error = error;
        }
        internal GenResponse(int statusCode, byte[]? data)
        {
            StatusCode = statusCode;
            Data = data;
            Error = null;
        }

        internal GenResponse(int statusCode, ApiError error)
        {
            StatusCode = statusCode;
            Data = null;
            Error = error;
        }
    }
}
