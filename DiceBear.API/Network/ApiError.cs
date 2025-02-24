using System;

namespace FaceGenerator.Network
{
    /// <summary>
    /// Represents response error
    /// </summary>
    public class ApiError : Exception
    {
        /// <summary>
        /// API error type
        /// </summary>
        public ApiErrorEnum ErrType;

        /// <summary>
        /// API error ctor
        /// </summary>
        /// <param name="errType"></param>
        /// <param name="msg"></param>
        public ApiError(ApiErrorEnum errType, string msg) : base(msg)
        {
            ErrType = errType;
        }
    }

    /// <summary>
    /// Response error type
    /// </summary>
    public enum ApiErrorEnum: byte
    {
        /// <summary>
        /// No connection to network. Local error
        /// </summary>
        NoConnection,
        /// <summary>
        /// 400 status code - bad request
        /// </summary>
        BadRequest,
        /// <summary>
        /// Response timeout
        /// </summary>
        NoResponse,
        /// <summary>
        /// Bad response
        /// </summary>
        BadResponse
    }

    /// <summary>
    /// Response error type extension
    /// </summary>
    public static class ApiErrorExt
    {

        /// <summary>
        /// Enum all values array
        /// </summary>
        public static ApiErrorEnum[] Values
        {
            get
            {
                return Enum.GetValues<ApiErrorEnum>();
            }
        }

        /// <summary>
        /// Humanized english message
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static string Message(this ApiErrorEnum error)
        {
            switch (error)
            {                
                case ApiErrorEnum.NoConnection: return "No network connection";
                case ApiErrorEnum.BadRequest: return "Bad request";
                case ApiErrorEnum.NoResponse: return "Response is null";
                case ApiErrorEnum.BadResponse: return "Bad response data";                
            }
            return string.Empty;
        }

        /// <summary>
        /// Transforms error type as error instance
        /// </summary>
        /// <param name="error">Error type</param>
        /// <param name="message">Error message. If not stated, will be used default type message</param>
        /// <returns></returns>
        public static ApiError AsException(this ApiErrorEnum error, string? message = null)
        {
            return new ApiError(error, message ?? error.Message());
        }
    }
}
