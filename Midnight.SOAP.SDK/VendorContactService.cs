
using Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;
using Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class VendorContactService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public VendorContactService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }


    /// <summary>
    /// Sends a SOAP request to insert a vendor contact and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the vendor contact to be inserted. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="VendorContactInsertResult"/> object containing the result of the operation, including the return
    /// code and any errors.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an error occurs during the SOAP request.</exception>
    public async Task<VendorContactInsertResult> VendorContactInsertAsync(ValidationSoapHeader auth, VendorContactInsertRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(VendorContactInsertRequestBody)} to Xml");
        Log.Debug($"{typeof(VendorContactInsertRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        VendorContactInsertResponse response;

        Log.Information($"Sending VendorContactInsertAsync SOAP request");

        try
        {
            response = await _soap.VendorContactInsertAsync(new VendorContactInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending VendorContactInsertAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(VendorContactInsertResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<VendorContactInsertResult>(response.VendorContactInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("VendorContactInsertAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"VendorContactInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to update vendor contact information and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. Ensure that sensitive 
    /// information is handled appropriately in the logs. The method will throw an exception if the  operation fails, so
    /// callers should handle exceptions as needed.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the vendor contact update details. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="VendorContactUpdateResult"/> object containing the result of the update operation,  including the
    /// return code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code,  indicating an error. The
    /// exception message will include the return code and error details.</exception>
    public async Task<VendorContactUpdateResult> VendorContactUpdateAsync(ValidationSoapHeader auth, VendorContactUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(VendorContactUpdateRequestBody)} to Xml");
        Log.Debug($"{typeof(VendorContactUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        VendorContactUpdateResponse response;

        Log.Information($"Sending VendorContactUpdateAsync SOAP request");

        try
        {
            response = await _soap.VendorContactUpdateAsync(new VendorContactUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending VendorContactUpdateAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(VendorContactUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<VendorContactUpdateResult>(response.VendorContactUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("VendorContactUpdateAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"VendorContactUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
