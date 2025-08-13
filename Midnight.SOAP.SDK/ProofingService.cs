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
    /// Sends a SOAP request to retrieve a list of proof attachments and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="ProofAttachmentListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the proof attachment list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="ProofAttachmentListResult"/> containing proof attachment details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<ProofAttachmentListResult> RequestAttachmentListAsync(ValidationSoapHeader auth, ProofAttachmentListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofAttachmentListRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofAttachmentListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestAttachmentListResponse response;

        Log.Information($"Sending RequestAttachmentListAsync SOAP request");

        try
        {
            response = await _soap.RequestAttachmentListAsync(new RequestAttachmentListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestAttachmentListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofAttachmentListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofAttachmentListResult>(response.RequestAttachmentListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestAttachmentListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestAttachmentListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to retrieve a list of proof approvers and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="ProofApproverListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the proof approver list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="ProofApproverListResult"/> containing proof approver details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<ProofApproverListResult> RequestApproverListAsync(ValidationSoapHeader auth, ProofApproverListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofApproverListRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofApproverListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestApproverListResponse response;

        Log.Information($"Sending RequestApproverListAsync SOAP request");

        try
        {
            response = await _soap.RequestApproverListAsync(new RequestApproverListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestApproverListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofApproverListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofApproverListResult>(response.RequestApproverListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestApproverListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestApproverListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to retrieve a list of proof request statuses and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="ProofStatusListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the proof status list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="ProofStatusListResult"/> containing proof request status details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<ProofStatusListResult> RequestStatusListAsync(ValidationSoapHeader auth, ProofStatusListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofStatusListRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofStatusListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestStatusListResponse response;

        Log.Information($"Sending RequestStatusListAsync SOAP request");

        try
        {
            response = await _soap.RequestStatusListAsync(new RequestStatusListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestStatusListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofStatusListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofStatusListResult>(response.RequestStatusListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestStatusListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestStatusListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to retrieve a list of proof requests and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="ProofListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the proof list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="ProofListResult"/> containing proof request details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<ProofListResult> RequestListAsync(ValidationSoapHeader auth, ProofListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofListRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestListResponse response;

        Log.Information($"Sending RequestListAsync SOAP request");

        try
        {
            response = await _soap.RequestListAsync(new RequestListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofListResult>(response.RequestListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
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
