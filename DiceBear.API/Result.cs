namespace FaceGenerator
{
    /// <summary>
    /// Abstract result class
    /// </summary>
    /// <typeparam name="T">Payload data type</typeparam>
    /// <typeparam name="X">Error data type</typeparam>
    public class Result<T, X>
    {
        /// <summary>
        /// Result payload data
        /// </summary>
        public readonly T? Data;
        /// <summary>
        /// Result error
        /// </summary>
        public readonly X? Error;

        /// <summary>
        /// Successful result flag
        /// </summary>
        public bool Success
        {
            get
            {
                return Data != null && Error == null;
            }
        }

        /// <summary>
        /// Result with payload data ctor
        /// </summary>
        /// <param name="data"></param>
        public Result(T? data)
        {
            Data = data;
            Error = default;
        }

        /// <summary>
        /// Result with error ctor
        /// </summary>
        /// <param name="error"></param>
        public Result(X? error)
        {
            Data = default;
            Error = error;
        }

        /// <summary>
        /// Result with payload data and error ctor
        /// </summary>
        /// <param name="data"></param>
        /// <param name="error"></param>
        public Result(T? data, X? error)
        {
            Data = data;
            Error = error;
        }
    }
}
