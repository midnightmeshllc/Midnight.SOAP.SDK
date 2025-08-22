
using Midnight.SOAP.SDK.RequestObjects.DJBInputs;
using Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with the DJB SOAP service, including operations for retrieving job statuses,
/// fetching DJB lists, and updating DJB statuses. IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This class acts as a client for the DJB SOAP service, enabling the execution of various operations
/// such as querying job statuses, retrieving DJB lists, and updating DJB statuses. Each method sends a SOAP request to
/// the corresponding endpoint, processes the response, and returns the result as a strongly-typed object.  Exceptions
/// are thrown for any errors encountered during the SOAP request or if the response indicates a failure. Ensure that
/// valid authentication headers and properly populated request objects are provided when calling the methods.</remarks>
/// <param name="_soap"></param>
public class DJBService(Service1Soap _soap)
{

    /// <summary>
    /// Sends a SOAP request to retrieve the status of DJB jobs and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the response
    /// contains a non-zero return code, an exception is thrown with the associated error details. Ensure that the
    /// <paramref name="auth"/> parameter contains valid credentials and that the <paramref name="request"/> parameter
    /// is properly populated before calling this method.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for the DJB job status query.</param>
    /// <returns>A <see cref="DJBJobStatusListResult"/> object containing the status of DJB jobs, including return codes and any
    /// errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, as determined by a non-zero return code.</exception>
    public async Task<DJBJobStatusListResult> DJBJobStatusListAsync(ValidationSoapHeader auth, DJBJobStatusListRequestBody request)
    {
        DJBJobStatusListResponse response;

        Log.Information($"Converting {typeof(DJBJobStatusListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DJBJobStatusListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending DJBJobStatusListAsync SOAP request");
        try
        {
            response = await _soap.DJBJobStatusListAsync(new DJBJobStatusListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DJBJobStatusListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DJBJobStatusListAsync Response: {@res}", response.DJBJobStatusListResult);

        var result = XmlParsing.DeserializeXmlToObject<DJBJobStatusListResult>(response.DJBJobStatusListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("DJBJobStatusListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DJBJobStatusListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a DJB list and processes the response.
    /// </summary>
    /// <remarks>This method sends a SOAP request to the DJBList endpoint, processes the XML response, and
    /// deserializes it into a <see cref="DJBListResult"/> object. If the operation fails, an exception is thrown with
    /// details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters for the DJB list operation. Cannot be null.</param>
    /// <returns>A <see cref="DJBListResult"/> object containing the result of the DJB list operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP response indicates a failure, as determined by a non-zero <c>ReturnCode</c> in the <see
    /// cref="DJBListResult"/>. The exception message includes the return code and error details.</exception>
    public async Task<DJBListResult> DJBListAsync(ValidationSoapHeader auth, DJBListRequestBody request)
    {
        DJBListResponse response;

        Log.Information($"Converting {typeof(DJBListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DJBListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending DJBListAsync SOAP request");
        try
        {
            response = await _soap.DJBListAsync(new DJBListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DJBListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DJBListAsync Response: {@res}", response.DJBListResult);

        var result = XmlParsing.DeserializeXmlToObject<DJBListResult>(response.DJBListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("DJBListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DJBListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to update the DJB status and retrieves the result.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into an XML format and
    /// sends it as part of a SOAP request. If the operation fails, an exception is thrown with details about the
    /// failure, including the return code and error messages.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the data to be sent for the DJB status update.</param>
    /// <returns>A <see cref="DJBStatusUpdateResult"/> object containing the result of the DJB status update operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates a failure with a non-zero return code.</exception>
    public async Task<DJBStatusUpdateResult> DJBStatusUpdateAsync(ValidationSoapHeader auth, DJBStatusUpdateRequestBody request)
    {
        DJBStatusUpdateResponse response;

        Log.Information($"Converting {typeof(DJBStatusUpdateRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DJBStatusUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending DJBStatusUpdateAsync SOAP request");
        try
        {
            response = await _soap.DJBStatusUpdateAsync(new DJBStatusUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DJBStatusUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DJBStatusUpdateAsync Response: {@res}", response.DJBStatusUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<DJBStatusUpdateResult>(response.DJBStatusUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("DJBStatusUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DJBStatusUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
