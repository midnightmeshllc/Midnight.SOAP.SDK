using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDetailOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionDropOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionOutputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderVersionPostageOutputs;

namespace Midnight.SOAP.SDK.ResponseObjects.OrderOutputs
{
    /// <summary>
    /// Represents the result of an entire order, including all associated versions, version details, version drops, version inventory and version postage.
    /// </summary>
    public class EntireOrderResult : EntireOrderListResult
    {
        /// <summary>
        /// Gets or sets the collection of order versions.
        /// </summary>
        public List<EntireOrderVersionResult> OrderVersions { get; set; } = new List<EntireOrderVersionResult>();
    }

    public class EntireOrderVersionResult : OrderVersion
    {
        /// <summary>
        ///  Maps the properties of an OrderVersion object to an EntireOrderVersionResult object using reflection.
        /// </summary>
        /// <param name="source"></param>
        public EntireOrderVersionResult(OrderVersion source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersion).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }

        /// <summary> Gets or sets the collection of OrderVersionDetails </summary>
        public List<EntireOrderVersionDetailResult> OrderVersionDetails { get; set; } = new List<EntireOrderVersionDetailResult>();

        /// <summary> Gets or sets the collection of OrderVersionDrops </summary>
        public List<EntireOrderVersionDropResult> OrderVersionDrops { get; set; } = new List<EntireOrderVersionDropResult>();

        /// <summary> Gets or sets the collection of OrderVersionInventory </summary>
        public List<EntireOrderVersionInventoryResult> OrderVersionInventory { get; set; } = new List<EntireOrderVersionInventoryResult>();

        /// <summary> Gets or sets the collection of OrderVersionPostage </summary>
        public List<EntireOrderVersionPostageResult> OrderVersionPostage { get; set; } = new List<EntireOrderVersionPostageResult>();
    }

    /// <summary>
    /// Represents the result of retrieving an entire order list.
    /// </summary>
    public class EntireOrderListResult
    {
        public Order Order { get; set; } = new Order();
    }

    /// <summary>
    /// Represents the result of an entire order version detail, providing a copy of writable properties from an
    /// OrderVersionDetailList instance.
    /// </summary>
    public class EntireOrderVersionDetailResult : OrderVersionDetailList
    {
        /// <summary>
        /// Initializes a new instance of the EntireOrderVersionDetailResult class by copying writable properties from
        /// the specified OrderVersionDetailList.
        /// </summary>
        /// <param name="source">The OrderVersionDetailList instance from which property values are copied.</param>
        public EntireOrderVersionDetailResult(OrderVersionDetailList source)
        {
            foreach (var prop in typeof(OrderVersionDetailList).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }

    /// <summary>
    /// Represents the result of an entire order version drop, providing a copy of all writable public properties
    /// from an existing OrderVersionDrop instance.
    /// </summary>
    public class EntireOrderVersionDropResult : OrderVersionDrop
    {
        /// <summary>
        /// Initializes a new instance of the EntireOrderVersionDropResult class by copying public properties from the
        /// specified OrderVersionDrop instance.
        /// </summary>
        /// <param name="source">The source OrderVersionDrop instance from which to copy property values.</param>
        public EntireOrderVersionDropResult(OrderVersionDrop source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersionDrop).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }

    /// <summary>
    /// Represents the result of an entire order version inventory, providing a copy of all writable public properties
    /// from an existing OrderVersionInventory instance.
    /// </summary>
    public class EntireOrderVersionInventoryResult : OrderVersionInventory
    {
        /// <summary>
        /// Initializes a new instance of the EntireOrderVersionInventoryResult class by copying all writable public
        /// properties from the specified OrderVersionInventory instance.
        /// </summary>
        /// <param name="source">The OrderVersionInventory instance from which to copy property values.</param>
        public EntireOrderVersionInventoryResult(OrderVersionInventory source)
        {
            // Use reflection to map all public properties
            foreach (var prop in typeof(OrderVersionInventory).GetProperties().Where(p => p.CanWrite))
            {
                prop.SetValue(this, prop.GetValue(source));
            }
        }
    }

    /// <summary>
    /// Represents the result of postage calculations for an entire order version.
    /// </summary>
    public class EntireOrderVersionPostageResult : OrderVersionPostage
    {
        /// <summary>
        /// Initializes a new instance of the EntireOrderVersionPostageResult class by copying public properties from
        /// the specified OrderVersionPostage instance.
        /// </summary>
        /// <param name="source">The source OrderVersionPostage instance from which to copy property values.</param>
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
