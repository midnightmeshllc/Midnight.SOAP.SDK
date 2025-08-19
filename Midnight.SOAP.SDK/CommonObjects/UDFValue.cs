using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.CommonObjects;

public class UDFValue
{
    // Stores the value as an object, can be string, decimal, int, DateTime, or TimeSpan
    [XmlIgnore]
    public object? Value { get; set; }

    // Serializes the value as the text content of the UDF tag
    [XmlText]
    public string? Text
    {
        get => ValueToString(Value);
        set => Value = value;
    }

    // Helper to convert the value to string for XML serialization
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
