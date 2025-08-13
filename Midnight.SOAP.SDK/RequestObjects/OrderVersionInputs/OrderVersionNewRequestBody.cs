
using Midnight.SOAP.SDK.CommonObjects;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;

[XmlRoot("OrderVersionNew")]
public class OrderVersionNewRequestBody
{
    public required OrderVersionNewInputParameter InputParameter { get; set; }
}

public class OrderVersionNewInputParameter : UserDefinedFields
{
    [Required]
    public int OrderID { get; set; }
    public string? DueDate { get; set; }
    public int Quantity { get; set; }
    public string? Name { get; set; }
    public string? Comment { get; set; }
    public int DataProcessingStatusID { get; set; }
    public int JobTypeID { get; set; }
    public int UrgencyID { get; set; }
    public List<OrderVersionDetail>? OrderVersionDetails { get; set; }
    public List<OrderVersionInventoryNew>? OrderVersionInventories { get; set; }
}

public class OrderVersionInventoryNew
{
    public int ItemID { get; set; }
    public string? Description { get; set; }
    public int QuantityNeeded { get; set; }
    public int ItemPriority { get; set; }
    public string? Notes { get; set; }
}

public class OrderVersionDetail
{
    public int ServiceID { get; set; }
    public string? ServiceName { get; set; }
    public int ServiceQuantity { get; set; }
    public decimal ServiceUnitPrice { get; set; }
    public bool ServiceTaxable { get; set; }
    public int ServicePriority { get; set; }
    public string? Servicehyperlink { get; set; }
    public string? FileLocation { get; set; }
    public string? ServiceComment { get; set; }
}