using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.JobCostInputs;

/// <summary>
/// Represents the request body for a job out operation in the Midnight SOAP API.
/// </summary>
[XmlRoot("JobOut")]
public class JobOutRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the job out request.
    /// </summary>
    public required JobOutInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for a job out operation in the Midnight SOAP API.
/// </summary>
public class JobOutInputParameter
{
    /// <summary>Gets or sets the job cost detail temp ID.</summary>
    public required int JobCostDetailTempID { get; set; }
    /// <summary>Gets or sets the stop time.</summary>
    public DateTime StopTime { get; set; }
    /// <summary>Gets or sets the stop count.</summary>
    public int StopCount { get; set; }
    /// <summary>Gets or sets a value indicating whether the job is complete.</summary>
    public bool Complete { get; set; } = true;
    /// <summary>Gets or sets the DJB status ID.</summary>
    [XmlElement(IsNullable = true)]
    public int? DJBStatusID { get; set; }
    /// <summary>Gets or sets a value indicating whether the job is a rework.</summary>
    public bool Rework { get; set; } = false;
}