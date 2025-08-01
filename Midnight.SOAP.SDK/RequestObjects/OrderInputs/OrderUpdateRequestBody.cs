using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.OrderInputs;

[XmlRoot("OrderUpdate")]
public class OrderUpdateRequestBody
{
    public required OrderUpdateInputParameter InputParameter { get; set; }
}

public class OrderUpdateInputParameter
{
    [Required]
    public int OrderID { get; set; }
    public int? CustomerID { get; set; }
    public int? ContactID { get; set; }
    public int? SalesRepID { get; set; }
    public string? CSRID { get; set; } = string.Empty;
    public string? ProjectName { get; set; } = string.Empty;
    public string? PONumber { get; set; } = string.Empty;
    public string? Terms { get; set; } = string.Empty;
    public bool? Taxable { get; set; } = true;
    public int? OrderStatusID { get; set; }
    public string? OrderDate { get; set; } = string.Empty;
    public string? DataInDate { get; set; } = string.Empty;
    public bool? DataInYN { get; set; } = false;
    public string? MaterialInDate { get; set; } = string.Empty;
    public bool? MaterialInYN { get; set; } = true;
    public string? ArtworkInDate { get; set; } = string.Empty;
    public bool? ArtworkInYN { get; set; } = true;
    public string? DueDate { get; set; } = string.Empty;
    public bool? DueDateYN { get; set; } = false;
    public string? TimeDue { get; set; } = string.Empty;
    public string? ShipDate { get; set; } = string.Empty;
    public string? CloseDate { get; set; } = string.Empty;
    public int? ExpectedQty { get; set; }
    public int? ResidualInstructionID { get; set; }
    public string? JobProgressCode { get; set; } = string.Empty;
    public int? JobPriorityID { get; set; }
    public int? JobFrequencyID { get; set; }
    public int? JobTypeID { get; set; }
    public int? ShipToContactID { get; set; }
    public string? ShipToCountry { get; set; } = string.Empty;
    public int? ShiptToMethodID { get; set; }
    public int? BillToContactID { get; set; }
    public string? BillToCountry { get; set; } = string.Empty;

}