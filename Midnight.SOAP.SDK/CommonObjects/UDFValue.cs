using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.CommonObjects;

/// <summary>
/// Represents a user defined field value in the Midnight SOAP API. Can be string, decimal, int, DateTime, or TimeSpan.
/// </summary>
public class UDFValue
{
    /// <summary>
    /// Stores the value as an object, can be string, decimal, int, DateTime, or TimeSpan.
    /// </summary>
    [XmlIgnore]
    public object? Value { get; set; }

    /// <summary>
    /// Serializes the value as the text content of the UDF tag.
    /// </summary>
    [XmlText]
    public string? Text
    {
        get => ValueToString(Value);
        set => Value = value;
    }

    /// <summary>
    /// Helper to convert the value to string for XML serialization.
    /// </summary>
    private static string? ValueToString(object? value)
    {
        return value switch
        {
            null => null,
            string s => s,
            decimal d => d.ToString(System.Globalization.CultureInfo.InvariantCulture),
            int i => i.ToString(),
            DateTime dt => dt.ToString("o"), // ISO 8601 format
            TimeSpan ts => ts.ToString(),
            _ => value.ToString()
        };
    }
}
