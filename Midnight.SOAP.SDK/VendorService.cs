using Midnight.SOAP.SDK.RequestObjects.VendorInputs;
using Midnight.SOAP.SDK.ResponseObjects.VendorOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with a SOAP-based vendor service, including operations for inserting, updating, and
/// retrieving vendor information. IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This class acts as a client for a SOAP-based vendor service, enabling the execution of vendor-related
/// operations such as insertion, updates, and retrievals. Each method sends a SOAP request, logs the request and
/// response details for debugging purposes, and handles any errors that occur during the operation. Exceptions are
/// thrown for failed operations, including cases where the service returns a non-zero return code.</remarks>
/// <param name="_soap"></param>
public class VendorService(Service1Soap _soap)
{

    /// <summary>
    /// Sends a SOAP request to insert a vendor and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. If the operation
    /// fails,  an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing vendor details to be inserted. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="VendorInsertResult"/> object containing the result of the vendor insertion operation,  including
    /// the return code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code,  indicating an error during
    /// vendor insertion.</exception>
    public async Task<VendorInsertResult> VendorInsertAsync(ValidationSoapHeader auth, VendorInsertRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(VendorInsertRequestBody)} to Xml");
        Log.Information($"{typeof(VendorInsertRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        VendorInsertResponse response;

        Log.Information($"Sending VendorInsertAsync SOAP request");

        response = await _soap.VendorInsertAsync(new VendorInsertRequest
        {
            ValidationSoapHeader = auth,
            inputXML = inputXml
        });

        Log.Information($"{typeof(VendorInsertResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<VendorInsertResult>(response.VendorInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("VendorInsertAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}",
                result.ReturnCode, result.ReturnErrors.First().Error);
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to update vendor information and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes.  If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing vendor update details. This parameter cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="VendorUpdateResult"/> object containing the result of the vendor update operation,  including the
    /// return code and any error messages if applicable.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code,  indicating an error during
    /// the vendor update process.</exception>
    public async Task<VendorUpdateResult> VendorUpdateAsync(ValidationSoapHeader auth, VendorUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(VendorUpdateRequestBody)} to Xml");
        Log.Information($"{typeof(VendorUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        VendorUpdateResponse response;

        Log.Information($"Sending VendorUpdateAsync SOAP request");

        response = await _soap.VendorUpdateAsync(new VendorUpdateRequest
        {
            ValidationSoapHeader = auth,
            inputXML = inputXml
        });

        Log.Information($"{typeof(VendorUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<VendorUpdateResult>(response.VendorUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("VendorUpdateAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}",
                result.ReturnCode, result.ReturnErrors.First().Error);
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of vendors and returns the result of the operation.
    /// </summary>
    /// <remarks>
    /// This method logs the request and response details for debugging purposes. If the operation fails,
    /// an exception is thrown with details about the failure, including the return code and error messages.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing parameters for retrieving the vendor list. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="VendorListResult"/> object containing the result of the vendor list operation, including the return code, error messages, and the list of vendors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error during vendor list retrieval.</exception>
    public async Task<VendorListResult> VendorListAsync(ValidationSoapHeader auth, VendorListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(VendorListRequestBody)} to Xml");
        Log.Information($"{typeof(VendorListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        VendorListResponse response;

        Log.Information($"Sending VendorListAsync SOAP request");

        response = await _soap.VendorListAsync(new VendorListRequest
        {
            ValidationSoapHeader = auth,
            inputXML = inputXml
        });

        Log.Information($"{typeof(VendorListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<VendorListResult>(response.VendorListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("VendorListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}",
                result.ReturnCode, result.ReturnErrors.First().Error);
        }

        return result;
    }
}