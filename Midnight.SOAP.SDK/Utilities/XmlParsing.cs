using Serilog;
using System.Xml;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.Utilities;

/// <summary>
/// Provides utility methods for parsing and processing XML data, including capturing specific XML element content and
/// deserializing XML strings into objects.
/// </summary>
/// <remarks>This class contains static methods for working with XML data. It includes functionality for
/// extracting the text content of a specific XML element and for deserializing XML strings into strongly-typed objects.
/// The methods are designed to simplify common XML processing tasks while ensuring proper error handling and
/// validation.</remarks>
public class XmlParsing
{

    /// <summary>
    /// Asynchronously captures the text content of a specified XML element from a given XML string.
    /// </summary>
    /// <param name="xmlToRead">The XML string to be read and parsed.</param>
    /// <param name="elementToCapture">The name of the XML element whose text content is to be captured.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the text content of the specified
    /// XML element. If the element is not found, returns "Unspecified Error".</returns>
    public static async Task<string> CaptureSingleElementFromXMLAsync(string xmlToRead, string elementToCapture)
    {
        string currentElement = "";
        using (XmlReader CaptureVersionID = XmlReader.Create(new StringReader(xmlToRead)))
        {
            while (await CaptureVersionID.ReadAsync())
            {
                if (CaptureVersionID.NodeType == XmlNodeType.Element)
                {
                    currentElement = CaptureVersionID.Name;
                }

                if (CaptureVersionID.NodeType == XmlNodeType.Text)
                {
                    if (currentElement == elementToCapture)
                    {
                        return CaptureVersionID.Value;
                    }
                }
            } 
            return "Unspecified Error";
        }
    }

    /// <summary>
    /// Deserializes the specified XML string into an object of the specified type.
    /// </summary>
    /// <remarks>This method uses the <see cref="System.Xml.Serialization.XmlSerializer"/> to perform the
    /// deserialization. Ensure that the XML string matches the structure expected by the type <typeparamref
    /// name="T"/>.</remarks>
    /// <typeparam name="T">The type of the object to deserialize. Must be a reference type with a parameterless constructor.</typeparam>
    /// <param name="xml">The XML string to deserialize. Cannot be null, empty, or whitespace.</param>
    /// <returns>An instance of type <typeparamref name="T"/> populated with the data from the XML string.</returns>
    /// <exception cref="ArgumentException">Thrown if <paramref name="xml"/> is null, empty, or consists only of whitespace.</exception>
    /// <exception cref="InvalidOperationException">Thrown if deserialization fails, or if the deserialized object is null. The inner exception contains details
    /// about the deserialization error.</exception>
    public static T DeserializeXmlToObject<T>(string xml)
        where T : class, new()
    {
        var serializer = new XmlSerializer(typeof(T));
        using var reader = new StringReader(xml);

        if (string.IsNullOrWhiteSpace(xml))
        {
            Log.Error("XML input cannot be null or empty.");
            throw new ArgumentException("XML input cannot be null or empty.", nameof(xml));
        }

        try
        {
            var result = serializer.Deserialize(reader) as T;

            if (result == null)
            {
                throw new InvalidOperationException($"Deserialization of {typeof(T).Name} returned null.");
            }

            return result;
        }
        catch (Exception ex)
        {
            Log.Error($"Error deserializing XML to {typeof(T).Name}: {ex.Message}");
            throw new InvalidOperationException($"Error deserializing XML to {typeof(T).Name}: {ex.Message}", ex);
        }
    }
}
