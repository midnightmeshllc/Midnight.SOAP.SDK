using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

[XmlRoot("JobOut")]
public class JobOutRequestBody
{
    public required JobOutInputParameter InputParameter { get; set; }
}

public class JobOutInputParameter
{
    [Required]
    public int JobCostDetailTempID { get; set; }
    public DateTime StopTime { get; set; }
    public int StopCount { get; set; }
    public bool Complete { get; set; }
    public int? DJBStatusID { get; set; }
    public bool Rework { get; set; }
}