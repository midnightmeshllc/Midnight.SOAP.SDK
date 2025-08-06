using Midnight.SOAP.SDK.RequestObjects.JobCostInputs;
using Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class JobCostingService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public JobCostingService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Sends a SOAP request to perform a "Job Out" operation and processes the response.
    /// </summary>
    /// <remarks>This method converts the <paramref name="request"/> object to XML, sends it as part of a SOAP
    /// request,  and deserializes the response into a <see cref="JobOutResult"/> object. If the operation fails, 
    /// detailed error information is logged, and an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the details required for the "Job Out" operation. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="JobOutResult"/> object containing the result of the "Job Out" operation, including the return code
    /// and any errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation completes with a non-zero return code.  The exception
    /// message includes the return code and any associated error messages.</exception>
    public async Task<JobOutResult> JobCostingJobOutAsync(ValidationSoapHeader auth, JobOutRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(JobOutRequestBody)} to Xml");
        Log.Debug($"{typeof(JobOutRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        JobCostingJobOutResponse response;

        Log.Information($"Sending JobOutAsync SOAP request");

        try
        {
            response = await _soap.JobCostingJobOutAsync(new JobCostingJobOutRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending JobOutAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(JobOutResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<JobOutResult>(response.JobCostingJobOutResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("JobOutAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobOutAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to create a production time entry and processes the response.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into XML, sends it as
    /// part of a SOAP request,  and deserializes the response into a <see cref="ProductionTimeEntryResult"/> object. 
    /// If the operation fails, detailed error information is logged, and an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the production time entry details to be submitted.</param>
    /// <returns>A <see cref="ProductionTimeEntryResult"/> object containing the result of the operation,  including the return
    /// code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error,  such as a non-zero return code or
    /// associated error messages.</exception>
    public async Task<ProductionTimeEntryResult> JobCostProductionTimeEntryAsync(ValidationSoapHeader auth, ProductionTimeEntryRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ProductionTimeEntryRequestBody)} to Xml");
        Log.Debug($"{typeof(ProductionTimeEntryRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        JobCostProductionTimeEntryResponse response;

        Log.Information($"Sending ProductionTimeEntryAsync SOAP request");

        try
        {
            response = await _soap.JobCostProductionTimeEntryAsync(new JobCostProductionTimeEntryRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending ProductionTimeEntryAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ProductionTimeEntryResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ProductionTimeEntryResult>(response.JobCostProductionTimeEntryResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("ProductionTimeEntryAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ProductionTimeEntryAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to process a job cost service time entry and returns the result.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object to XML and sends it as
    /// part of a SOAP request. If the operation fails, detailed error information is logged, and an exception is
    /// thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the service time entry to be processed. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="ServiceTimeEntryResult"/> object containing the result of the service time entry operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<ServiceTimeEntryResult> JobCostServiceTimeEntry(ValidationSoapHeader auth, ServiceTimeEntryRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ServiceTimeEntryRequestBody)} to Xml");
        Log.Debug($"{typeof(ServiceTimeEntryRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        JobCostServiceTimeEntryResponse response;

        Log.Information($"Sending ServiceTimeEntryAsync SOAP request");

        try
        {
            response = await _soap.JobCostServiceTimeEntryAsync(new JobCostServiceTimeEntryRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending ServiceTimeEntryAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(ServiceTimeEntryResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<ServiceTimeEntryResult>(response.JobCostServiceTimeEntryResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("ServiceTimeEntryAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ServiceTimeEntryAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to insert other job costs for a specific order version and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes.  Ensure that sensitive
    /// information is handled appropriately in the logs.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the other job costs to be inserted.  This parameter cannot be <see
    /// langword="null"/>.</param>
    /// <returns>An <see cref="OrderVersionOtherJobCostInsertResult"/> object containing the result of the operation,  including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code,  indicating an error. The
    /// exception message will include the return code and error details.</exception>
    public async Task<OrderVersionOtherJobCostInsertResult> OrderVersionOtherJobCostInsertAsync(ValidationSoapHeader auth, OrderVersionOtherJobCostInsertRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        Log.Information($"Converting {typeof(OrderVersionOtherJobCostInsertRequestBody)} to Xml");
        Log.Debug($"{typeof(OrderVersionOtherJobCostInsertRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        OrderVersionOtherJobCostInsertResponse response;

        Log.Information($"Sending OrderVersionOtherJobCostInsertAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionOtherJobCostInsertAsync(new OrderVersionOtherJobCostInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending OrderVersionOtherJobCostInsertAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(OrderVersionOtherJobCostInsertResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionOtherJobCostInsertResult>(response.OrderVersionOtherJobCostInsertResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionOtherJobCostInsertAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionOtherJobCostInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
