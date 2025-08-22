using Midnight.SOAP.SDK.RequestObjects.JobCostInputs;
using Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with the Job Costing SOAP service, including operations for job costing, 
/// production time entries, service time entries, and other job cost updates.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>This service acts as a client for the Job Costing SOAP API, enabling various job costing operations
/// such as  creating, updating, and retrieving job cost details. Each method in this class sends a SOAP request,
/// processes  the response, and returns the result as a strongly-typed object. Exceptions are thrown for errors such as
/// invalid input, SOAP request failures, or non-zero return codes from the service. <para> Logging is performed for
/// debugging purposes, including request and response data. Ensure that sensitive  information is handled appropriately
/// in the logs. </para> <para> Callers must provide valid authentication credentials via the <see
/// cref="ValidationSoapHeader"/> parameter  for all methods. Additionally, input parameters must meet the specified
/// requirements (e.g., non-null values)  to avoid exceptions. </para></remarks>
/// <param name="_soap"></param>
public class JobCostingService(Service1Soap _soap)
{

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

    /// <summary>
    /// Retrieves a list of temporary job cost details from the SOAP service asynchronously.
    /// </summary>
    /// <remarks>This method sends a request to the SOAP service to obtain temporary job cost details. The
    /// caller must provide valid authentication credentials via the <paramref name="auth"/> parameter.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request. Cannot be null.</param>
    /// <returns>A <see cref="JobCostDetailTempListResult"/> containing the job cost detail data and status information returned
    /// by the service.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request.</exception>
    public async Task<JobCostDetailTempListResult> JobCostDetailTempListAsync(ValidationSoapHeader auth)
    {

        JobCostDetailTempListResponse response;

        Log.Information($"Sending JobCostDetailTempListAsync SOAP request");

        try
        {
            response = await _soap.JobCostDetailTempListAsync(new JobCostDetailTempListRequest
            {
                ValidationSoapHeader = auth
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending JobCostDetailTempListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(JobCostDetailTempListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<JobCostDetailTempListResult>(response.JobCostDetailTempListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("JobCostDetailTempListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobCostDetailTempListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a summary list of job cost order versions for the specified order number and job costing date.
    /// </summary>
    /// <remarks>This method sends a SOAP request to obtain job cost order version summaries. The <paramref
    /// name="jobCostingDate"/> parameter must be a valid date string; otherwise, an exception is thrown. The result
    /// includes a return code and any associated errors.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="orderNumber">The order number for which to retrieve job cost order version summaries.</param>
    /// <param name="jobCostingDate">The job costing date as a string. Must be in a format parsable by <see cref="DateTime.TryParse"/> (e.g.,
    /// "yyyy-MM-dd").</param>
    /// <returns>A <see cref="JobCostOrderVersionServiceSummaryListResult"/> containing the summary list and result information
    /// for the specified order and date.</returns>
    /// <exception cref="Exception">Thrown if <paramref name="jobCostingDate"/> cannot be parsed into a valid date, or if the SOAP service returns a
    /// non-zero return code.</exception>
    public async Task<JobCostOrderVersionServiceSummaryListResult> JobCostOrderVersionServiceSummaryListAsync(ValidationSoapHeader auth, string orderNumber, string jobCostingDate)
    {
        JobCostOrderVersionServiceSummaryListResponse response;


        try
        {
            bool parsed = DateTime.TryParse(jobCostingDate, out var jobCostingDateParsed);

            if (parsed)
            {
                response = await _soap.JobCostOrderVersionServiceSummaryListAsync(new JobCostOrderVersionServiceSummaryListRequest
                {
                    ValidationSoapHeader = auth,
                    orderNumber = orderNumber,
                    jobCostingDate = jobCostingDateParsed.ToString("yyyy-MM-dd")
                });
            }
            else
            {
                Log.Error("Error parsing {@param} into a valid Date", jobCostingDate);
                throw new Exception("Unable to parse supplied parameter value for jobCostingDate into a valid Date");
            }

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending JobCostOrderVersionServiceSummaryListAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(JobCostOrderVersionServiceSummaryListResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<JobCostOrderVersionServiceSummaryListResult>(response.JobCostOrderVersionServiceSummaryListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("JobCostOrderVersionServiceSummaryListAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobCostOrderVersionServiceSummaryListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to update other job costs for a specific order version and returns the result of the
    /// operation.
    /// </summary>
    /// <remarks>This method logs the request and response data for debugging purposes. Ensure that sensitive
    /// information is handled appropriately in the logs. The method will throw an exception if the operation fails, so
    /// callers should handle exceptions as needed.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the order version and job cost updates to be processed. This
    /// parameter cannot be <see langword="null"/>.</param>
    /// <returns>An <see cref="OrderVersionOtherJobCostUpdateResult"/> object containing the result of the update operation,
    /// including the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation completes with a non-zero return code. The exception
    /// message will include the return code and any associated error messages.</exception>
    public async Task<OrderVersionOtherJobCostUpdateResult> OrderVersionOtherJobCostUpdateAsync(ValidationSoapHeader auth, OrderVersionOtherJobCostUpdateRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        Log.Information($"Converting {typeof(OrderVersionOtherJobCostUpdateRequestBody)} to Xml");
        Log.Debug($"{typeof(OrderVersionOtherJobCostUpdateRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        OrderVersionOtherJobCostUpdateResponse response;

        Log.Information($"Sending OrderVersionOtherJobCostUpdateAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionOtherJobCostUpdateAsync(new OrderVersionOtherJobCostUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending OrderVersionOtherJobCostUpdateAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(OrderVersionOtherJobCostUpdateResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionOtherJobCostUpdateResult>(response.OrderVersionOtherJobCostUpdateResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionOtherJobCostUpdateAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionOtherJobCostUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
