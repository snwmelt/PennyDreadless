namespace PennyDreadless.Models.Core.Enums
{
    /// <summary>
    /// For use with a PennyDreadless.Models.Core.DataRequestEventArgs instance 
    /// to denote the result of a data request.
    /// </summary>
    public enum DataRequestResult
    {
        Failed   = 0,
        Success  = 2,
        Fetching = 1
    }
}
