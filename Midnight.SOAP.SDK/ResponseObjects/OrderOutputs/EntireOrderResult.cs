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

        public EntireOrderVersionResult(OrderVersion source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersion).GetProperties())
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }


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
        public EntireOrderVersionDetailResult(OrderVersionDetailList source)
        {
            foreach (var prop in typeof(OrderVersionDetailList).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }

    public class EntireOrderVersionDropResult : OrderVersionDrop
    {
        public EntireOrderVersionDropResult(OrderVersionDrop source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersionDrop).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }

    public class EntireOrderVersionInventoryResult : OrderVersionInventory
    {

        public EntireOrderVersionInventoryResult(OrderVersionInventory source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersionInventory).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }

    public class EntireOrderVersionPostageResult : OrderVersionPostage
    {

        public EntireOrderVersionPostageResult(OrderVersionPostage source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersionPostage).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }
}
