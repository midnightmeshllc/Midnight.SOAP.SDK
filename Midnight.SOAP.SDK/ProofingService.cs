using Midnight.SOAP.SDK.RequestObjects.ProofingInputs;
using Midnight.SOAP.SDK.ResponseObjects.ProofingOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with a SOAP-based proofing service.
/// </summary>
/// <remarks>The <see cref="ProofingService"/> class encapsulates functionality for sending SOAP requests to
/// manage proofs,  including creating, updating, deleting, and querying proof-related data. Each method in this class
/// handles  serialization of request objects to XML, communication with the SOAP service, and deserialization of
/// responses  into strongly-typed result objects. Exceptions are thrown for errors, including non-zero return codes
/// from the  SOAP service. <para> This class is designed to simplify interaction with the SOAP service by abstracting
/// the details of XML  serialization and deserialization, as well as error handling. Callers should ensure that all
/// required  authentication headers and request parameters are provided when invoking methods. </para></remarks>
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
    /// <returns>A <see cref="ProofApproverUpdateResult"/> object containing the result of the operation, including the return code
    /// and any errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<ProofApproverUpdateResult> RequestApproverInsertAsync(ValidationSoapHeader auth, ProofApproverUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofApproverUpdateRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofApproverUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

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

        Log.Debug($"{typeof(ProofApproverUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofApproverUpdateResult>(response.RequestApproverInsertResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestApproverInsertAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestApproverInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to update proof data and retrieves the result.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. Ensure that sensitive
    /// information is handled appropriately in the logs. If the response contains errors, an exception is
    /// thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the proof update data. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="ProofUpdateResult"/> object containing the results of the proof update operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response contains errors.</exception>
    public async Task<ProofUpdateResult> RequestUpdateAsync(ValidationSoapHeader auth, ProofUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofUpdateRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestUpdateResponse response;

        Log.Information($"Sending RequestUpdateAsync SOAP request");

        try
        {
            response = await _soap.RequestUpdateAsync(new RequestUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestUpdateAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofUpdateResult>(response.RequestUpdateResult);

        if (result.Results.Select(r => r.ReturnErrors).Any())
        {
            Log.Error("RequestUpdateAsync failed");
            throw new Exception($"RequestUpdateAsync failed");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to update the proof approver and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes.  Ensure that
    /// sensitive information is handled appropriately in the logs.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the details of the proof approver update. Cannot be null.</param>
    /// <returns>A <see cref="ProofApproverUpdateResult"/> object containing the result of the update operation,  including the
    /// return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code,  indicating an error. The
    /// exception message will include the return code and error details.</exception>
    public async Task<ProofApproverUpdateResult> RequestApproverUpdateAsync(ValidationSoapHeader auth, ProofApproverUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofApproverUpdateRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofApproverUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestApproverUpdateResponse response;

        Log.Information($"Sending RequestApproverUpdateAsync SOAP request");

        try
        {
            response = await _soap.RequestApproverUpdateAsync(new RequestApproverUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestApproverUpdateAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofApproverUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofApproverUpdateResult>(response.RequestApproverUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestApproverUpdateAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestApproverUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to delete a proof and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. Ensure that
    /// sensitive information is handled appropriately in the logs. The method will throw an exception if the operation
    /// fails, so callers should handle exceptions as needed.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the proof to be deleted. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="ProofDeleteResult"/> object containing the result of the delete operation, including any return
    /// codes or errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error. The
    /// exception message will include the return code and error details.</exception>
    public async Task<ProofDeleteResult> RequestDeleteAsync(ValidationSoapHeader auth, ProofDeleteRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofDeleteRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofDeleteRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestDeleteResponse response;

        Log.Information($"Sending RequestDeleteAsync SOAP request");

        try
        {
            response = await _soap.RequestDeleteAsync(new RequestDeleteRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestDeleteAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofDeleteResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofDeleteResult>(response.RequestDeleteResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestDeleteAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestDeleteAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to delete a proof approver and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the error.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the proof approver to be deleted. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="ProofApproverDeleteResult"/> object containing the result of the delete operation, including the
    /// return code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<ProofApproverDeleteResult> RequestApproverDeleteAsync(ValidationSoapHeader auth, ProofApproverDeleteRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProofApproverDeleteRequestBody)} to Xml");
        Log.Debug($"{typeof(ProofApproverDeleteRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        RequestApproverDeleteResponse response;

        Log.Information($"Sending RequestApproverDeleteAsync SOAP request");

        try
        {
            response = await _soap.RequestApproverDeleteAsync(new RequestApproverDeleteRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending RequestApproverDeleteAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProofApproverDeleteResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProofApproverDeleteResult>(response.RequestApproverDeleteResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("RequestApproverDeleteAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RequestApproverDeleteAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
