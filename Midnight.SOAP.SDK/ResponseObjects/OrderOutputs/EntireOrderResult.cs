
using Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs
{

    public class EntireOrderResult : EntireOrderListResult
    {
        public List<EntireOrderVersionResult> OrderVersions { get; set; } = new List<EntireOrderVersionResult>();
    }

    public class EntireOrderVersionResult : OrderVersion
    {
        public List<EntireOrderVersionDetailResult> OrderVersionDetails { get; set; } = new List<EntireOrderVersionDetailResult>();
        public List<EntireOrderVersionDropResult> OrderVersionDrops { get; set; } = new List<EntireOrderVersionDropResult>();
        public List<EntireOrderVersionInventoryResult> OrderVersionInventory { get; set; } = new List<EntireOrderVersionInventoryResult>();
        public List<EntireOrderVersionPostageResult> OrderVersionPostage { get; set; } = new List<EntireOrderVersionPostageResult>();
    }

    public class EntireOrderListResult
    {
        public Order Order { get; set; } = new Order();
    }

    public class EntireOrderVersionDetailResult : OrderVersionDetailList
    {
    }

    public class EntireOrderVersionDropResult : OrderVersionDrop
    {
    }

    public class EntireOrderVersionInventoryResult : OrderVersionInventory
    {
    }

    public class EntireOrderVersionPostageResult : OrderVersionPostage
    {
    }
}
