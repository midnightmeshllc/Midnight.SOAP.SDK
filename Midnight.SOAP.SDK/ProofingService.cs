
using Midnight.SOAP.SDK.RequestObjects.ProofingInputs;
using Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class ProofingService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public ProofingService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to create a new proof and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the details of the proof to be created. Cannot be null.</param>
    /// <returns>A <see cref="ProofNewResult"/> object containing the result of the operation, including the return code and any
    /// errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<ProofNewResult> RequestNewAsync(ValidationSoapHeader auth, ProofNewRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofNewRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofNewRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestNewResponse response;

        Log.Information($"Sending RequestNewAsync SOAP request");

        try
        {
            response = await _soap.RequestNewAsync(new RequestNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestNewAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofNewResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofNewResult>(response.RequestNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestNewAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to add an attachment to an existing proof request and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  the method logs the error and throws an exception with relevant details.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the attachment to be added. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="ProofAddAtachmentResult"/> object containing the result of the operation, including the return code
    /// and any errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation completes with a non-zero return code.  The exception
    /// message will include the return code and error details.</exception>
    public async Task<ProofAddAtachmentResult> RequestAddAttachmentAsync(ValidationSoapHeader auth, ProofAddAttachmentRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofAddAttachmentRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofAddAttachmentRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestAddAttachmentResponse response;

        Log.Information($"Sending RequestAddAtachmentAsync SOAP request");

        try
        {
            response = await _soap.RequestAddAttachmentAsync(new RequestAddAttachmentRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestAddAtachmentAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofAddAtachmentResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofAddAtachmentResult>(response.RequestAddAttachmentResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestAddAtachmentAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestAddAtachmentAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to insert an approver to an existing proof request and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the approver to be added. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="ProofAddApproverResult"/> object containing the result of the operation, including the return code
    /// and any errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<ProofAddApproverResult> RequestApproverInsertAsync(ValidationSoapHeader auth, ProofAddApproverRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofAddApproverRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofAddApproverRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestApproverInsertResponse response;

        Log.Information($"Sending RequestApproverInsertAsync SOAP request");

        try
        {
            response = await _soap.RequestApproverInsertAsync(new RequestApproverInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestApproverInsertAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofAddApproverResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofAddApproverResult>(response.RequestApproverInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestApproverInsertAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestApproverInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

}
