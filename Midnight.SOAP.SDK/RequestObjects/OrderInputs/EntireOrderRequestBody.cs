
namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs
{
    public class EntireOrderRequestBody
    {
        public required string OrderNumber { get; set; } = string.Empty;

        /// <summary> Whether or not to return a closed order </summary>
        public bool OpenOrdersOnly { get; set; } = true;

        /// <summary> Whether or not to return the order version details/line items. </summary>
        public bool IncludeServices { get; set; } = false;

        /// <summary> Whether or not to return the order version drops. </summary>
        public bool IncludeDrops { get; set; } = false;

        /// <summary> Whether or not to return the order version inventory. </summary>
        public bool IncludeInventory { get; set; } = false;

        /// <summary> Whether or not to return the order version postage. </summary>
        public bool IncludePostage { get; set; } = false;
    }
}
