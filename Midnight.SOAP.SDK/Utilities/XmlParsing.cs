using Midnight.SOAP.SDK.ResponseObjects.OrderVersionInventoryOutputs;
using Serilog;
using System.Xml;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.Utilities;

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
