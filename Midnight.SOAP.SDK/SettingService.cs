using Midnight.SOAP.SDK.RequestObjects.SettingInputs;
using Midnight.SOAP.SDK.ResponseObjects.SettingOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class SettingService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public SettingService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }




    /// <summary>
    /// Sends a SOAP request to retrieve a list of warehouse locations and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="WarehouseLocationListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the warehouse location list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="WarehouseLocationListResult"/> containing warehouse location details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<WarehouseLocationListResult> WarehouseLocationListAsync(ValidationSoapHeader auth, WarehouseLocationListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(WarehouseLocationListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(WarehouseLocationListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        WarehouseLocationListResponse response;

        Log.Information("Sending WarehouseLocationListAsync SOAP request");

        try
        {
            response = await _soap.WarehouseLocationListAsync(new WarehouseLocationListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("WarehouseLocationListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("WarehouseLocationListAsync Response: {@res}", response.WarehouseLocationListResult);

        var result = XmlParsing.DeserializeXmlToObject<WarehouseLocationListResult>(response.WarehouseLocationListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("WarehouseLocationListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"WarehouseLocationListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of warehouses and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="WarehouseListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the warehouse list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="WarehouseListResult"/> containing warehouse details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<WarehouseListResult> WarehouseListAsync(ValidationSoapHeader auth, WarehouseListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(WarehouseListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(WarehouseListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        WarehouseListResponse response;

        Log.Information("Sending WarehouseListAsync SOAP request");

        try
        {
            response = await _soap.WarehouseListAsync(new WarehouseListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("WarehouseListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("WarehouseListAsync Response: {@res}", response.WarehouseListResult);

        var result = XmlParsing.DeserializeXmlToObject<WarehouseListResult>(response.WarehouseListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("WarehouseListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"WarehouseListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of terms asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="TermsListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the terms list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="TermsListResult"/> containing terms details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<TermsListResult> TermsListAsync(ValidationSoapHeader auth, TermsListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(TermsListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(TermsListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        TermsListResponse response;

        Log.Information("Sending TermsListAsync SOAP request");

        try
        {
            response = await _soap.TermsListAsync(new TermsListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("TermsListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("TermsListAsync Response: {@res}", response.TermsListResult);

        var result = XmlParsing.DeserializeXmlToObject<TermsListResult>(response.TermsListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("TermsListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"TermsListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of service wizards asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="ServiceWizardListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the service wizard list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="ServiceWizardListResult"/> containing service wizard details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<ServiceWizardListResult> ServiceWizardListAsync(ValidationSoapHeader auth, ServiceWizardListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ServiceWizardListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(ServiceWizardListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        ServiceWizardListResponse response;

        Log.Information("Sending ServiceWizardListAsync SOAP request");

        try
        {
            response = await _soap.ServiceWizardListAsync(new ServiceWizardListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("ServiceWizardListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("ServiceWizardListAsync Response: {@res}", response.ServiceWizardListResult);

        var result = XmlParsing.DeserializeXmlToObject<ServiceWizardListResult>(response.ServiceWizardListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("ServiceWizardListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ServiceWizardListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to retrieve a list of customer types and returns the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, the method logs the error and throws an exception.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters required for the customer type list operation. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="CustomerTypeListResult"/> object containing the list of customer types and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, as determined by a non-zero return code.</exception>
    public async Task<CustomerTypeListResult> CustomerTypeListAsync(ValidationSoapHeader auth, CustomerTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        CustomerTypeListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.CustomerTypeListAsync(new CustomerTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerTypeListAsync Response: {@res}", response.CustomerTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerTypeListResult>(response.CustomerTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of delivery methods based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve delivery methods and processes the response.  If
    /// the operation fails, detailed error information is logged, and an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing parameters for retrieving the delivery methods. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="DeliveryMethodListResult"/> object containing the list of delivery methods and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request. The
    /// exception message will include the return code and error details.</exception>
    public async Task<DeliveryMethodListResult> DeliveryMethodListAsync(ValidationSoapHeader auth, DeliveryMethodListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(DeliveryMethodListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DeliveryMethodListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        DeliveryMethodListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.DeliveryMethodListAsync(new DeliveryMethodListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DeliveryMethodListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DeliveryMethodListAsync Response: {@res}", response.DeliveryMethodListResult);

        var result = XmlParsing.DeserializeXmlToObject<DeliveryMethodListResult>(response.DeliveryMethodListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("DeliveryMethodListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DeliveryMethodListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of document types and returns the result.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object to XML format and sends
    /// it as part of a SOAP request. If the operation fails, an exception is thrown with details about the
    /// failure.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters for the document type list operation. Cannot be null.</param>
    /// <returns>A <see cref="DocumentTypeListResult"/> object containing the list of document types and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, such as a non-zero return code.</exception>
    public async Task<DocumentTypeListResult> DocumentTypeListAsync(ValidationSoapHeader auth, DocumentTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(DocumentTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(DocumentTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        DocumentTypeListResponse response;

        Log.Information("Sending CustomerTypeListAsync SOAP request");

        try
        {
            response = await _soap.DocumentTypeListAsync(new DocumentTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("DocumentTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("DocumentTypeListAsync Response: {@res}", response.DocumentTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<DocumentTypeListResult>(response.DocumentTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("DocumentTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"DocumentTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of employees and returns the result.
    /// </summary>
    /// <remarks>This method communicates with a SOAP service to fetch employee data. The request is
    /// serialized to XML before being sent,  and the response is deserialized into an <see cref="EmployeeListResult"/>
    /// object. If the operation fails, an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the parameters for the employee list query. Cannot be null.</param>
    /// <returns>An <see cref="EmployeeListResult"/> object containing the list of employees and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request or response
    /// processing.</exception>
    public async Task<EmployeeListResult> EmployeeListAsync(ValidationSoapHeader auth, EmployeeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(EmployeeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(EmployeeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        EmployeeListResponse response;

        Log.Information("Sending EmployeeListAsync SOAP request");

        try
        {
            response = await _soap.EmployeeListAsync(new EmployeeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("EmployeeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("EmployeeListAsync Response: {@res}", response.EmployeeListResult);

        var result = XmlParsing.DeserializeXmlToObject<EmployeeListResult>(response.EmployeeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("EmployeeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"EmployeeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of job priorities from settings.
    /// </summary>
    /// <remarks>This method serializes the request body to XML and communicates with the SOAP service using
    /// the provided authentication header. If the operation fails or the service returns a non-zero return code, an
    /// exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the criteria for retrieving the job priority list. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="JobPriorityListResult"/> containing the prioritized list of jobs and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<JobPriorityListResult> JobPriorityListAsync(ValidationSoapHeader auth, JobPriorityListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(JobPriorityListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(JobPriorityListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        JobPriorityListResponse response;

        Log.Information("Sending JobPriorityListAsync SOAP request");

        try
        {
            response = await _soap.JobPriorityListAsync(new JobPriorityListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("JobPriorityListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("JobPriorityListAsync Response: {@res}", response.JobPriorityListResult);

        var result = XmlParsing.DeserializeXmlToObject<JobPriorityListResult>(response.JobPriorityListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("JobPriorityListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobPriorityListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve the job progress list from settings.
    /// </summary>
    /// <remarks>This method serializes the specified request body to XML and sends it to the SOAP service
    /// using the provided authentication header. The returned result contains job progress information and status
    /// codes. If the operation fails, an exception is thrown with details from the response.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the job(s) for which progress information is to be retrieved. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A <see cref="JobProgressListResult"/> containing progress details and status information for the requested jobs.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes
    /// the return code and error details.</exception>
    public async Task<JobProgressListResult> JobProgressListAsync(ValidationSoapHeader auth, JobProgressListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(JobProgressListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(JobProgressListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        JobProgressListResponse response;

        Log.Information("Sending JobProgressListAsync SOAP request");

        try
        {
            response = await _soap.JobProgressListAsync(new JobProgressListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("JobProgressListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("JobProgressListAsync Response: {@res}", response.JobProgressListResult);

        var result = XmlParsing.DeserializeXmlToObject<JobProgressListResult>(response.JobProgressListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("JobProgressListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobProgressListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of job types from settings asynchronously.
    /// </summary>
    /// <remarks>This method sends a SOAP request using the provided authentication header and request body,
    /// and returns the parsed result containing job type information.</remarks>
    /// <param name="auth">The authentication header used to validate the request with the remote service.</param>
    /// <param name="request">The request body containing parameters for the job type list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="JobTypeListResult"/> containing the job type data returned by the service.</returns>
    /// <exception cref="Exception">Thrown if the service response indicates a failure, or if an error occurs during the request or response
    /// processing.</exception>
    public async Task<JobTypeListResult> JobTypeListAsync(ValidationSoapHeader auth, JobTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(JobTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(JobTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        JobTypeListResponse response;

        Log.Information("Sending JobTypeListAsync SOAP request");

        try
        {
            response = await _soap.JobTypeListAsync(new JobTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("JobTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("JobTypeListAsync Response: {@res}", response.JobTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<JobTypeListResult>(response.JobTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("JobTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of job frequencies from settings.
    /// </summary>
    /// <remarks>This asynchronous method communicates with a remote SOAP service to obtain job frequency
    /// information. The request is serialized to XML before transmission, and the response is deserialized into a <see
    /// cref="JobFrequencyListResult"/> object. If the operation fails, an exception is thrown containing error details
    /// from the response.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying parameters for the job frequency query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="JobFrequencyListResult"/> containing the job frequency data returned by the SOAP service.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating an error. The exception message includes
    /// the return code and error details.</exception>
    public async Task<JobFrequencyListResult> JobFrequencyListAsync(ValidationSoapHeader auth, JobFrequencyListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(JobFrequencyListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(JobFrequencyListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        JobFrequencyListResponse response;

        Log.Information("Sending JobFrequencyListAsync SOAP request");

        try
        {
            response = await _soap.JobFrequencyListAsync(new JobFrequencyListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("JobFrequencyListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("JobFrequencyListAsync Response: {@res}", response.JobFrequencyListResult);

        var result = XmlParsing.DeserializeXmlToObject<JobFrequencyListResult>(response.JobFrequencyListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("JobFrequencyListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"JobFrequencyListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of mail categories based on the specified request parameters.
    /// </summary>
    /// <remarks>This asynchronous method communicates with the remote mail service using the provided
    /// authentication header and request body. The result includes the list of mail categories and any associated
    /// status or error information.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the mail category list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="MailCategoryListResult"/> containing the retrieved mail categories and related response details.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<MailCategoryListResult> MailCategoryListAsync(ValidationSoapHeader auth, MailCategoryListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(MailCategoryListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(MailCategoryListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        MailCategoryListResponse response;

        Log.Information("Sending MailCategoryListAsync SOAP request");

        try
        {
            response = await _soap.MailCategoryListAsync(new MailCategoryListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("MailCategoryListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("MailCategoryListAsync Response: {@res}", response.MailCategoryListResult);

        var result = XmlParsing.DeserializeXmlToObject<MailCategoryListResult>(response.MailCategoryListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("MailCategoryListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"MailCategoryListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of mail classes from settings.
    /// </summary>
    /// <remarks>
    /// This asynchronous method communicates with the remote mail service using the provided authentication header and request body.
    /// The result includes the list of mail classes and any associated status or error information. If the operation fails, an exception is thrown.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the mail class list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="MailClassListResult"/> containing the retrieved mail classes and related response details.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<MailClassListResult> MailClassListAsync(ValidationSoapHeader auth, MailClassListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(MailClassListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(MailClassListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        MailClassListResponse response;

        Log.Information("Sending MailClassListAsync SOAP request");

        try
        {
            response = await _soap.MailClassListAsync(new MailClassListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("MailClassListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("MailClassListAsync Response: {@res}", response.MailClassListResult);

        var result = XmlParsing.DeserializeXmlToObject<MailClassListResult>(response.MailClassListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("MailClassListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"MailClassListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of mail geographies from settings.
    /// </summary>
    /// <remarks>
    /// This asynchronous method communicates with the remote mail service using the provided authentication header and request body.
    /// The result includes the list of mail geographies and any associated status or error information. If the operation fails, an exception is thrown.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the mail geography list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="MailGeographyListResult"/> containing the retrieved mail geographies and related response details.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<MailGeographyListResult> MailGeographyListAsync(ValidationSoapHeader auth, MailGeographyListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(MailGeographyListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(MailGeographyListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        MailGeographyListResponse response;

        Log.Information("Sending MailGeographyListAsync SOAP request");

        try
        {
            response = await _soap.MailGeographyListAsync(new MailGeographyListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("MailGeographyListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("MailGeographyListAsync Response: {@res}", response.MailGeographyListResult);

        var result = XmlParsing.DeserializeXmlToObject<MailGeographyListResult>(response.MailGeographyListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("MailGeographyListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"MailGeographyListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of mail sorts from settings.
    /// </summary>
    /// <remarks>
    /// This asynchronous method communicates with the remote mail service using the provided authentication header and request body.
    /// The result includes the list of mail sorts and any associated status or error information. If the operation fails, an exception is thrown.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the mail sort list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="MailSortListResult"/> containing the retrieved mail sorts and related response details.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<MailSortListResult> MailSortListAsync(ValidationSoapHeader auth, MailSortListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(MailSortListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(MailSortListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        MailSortListResponse response;

        Log.Information("Sending MailSortListAsync SOAP request");

        try
        {
            response = await _soap.MailSortListAsync(new MailSortListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("MailSortListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("MailSortListAsync Response: {@res}", response.MailSortListResult);

        var result = XmlParsing.DeserializeXmlToObject<MailSortListResult>(response.MailSortListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("MailSortListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"MailSortListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of post offices based on the specified criteria.
    /// </summary>
    /// <remarks>This method serializes the request body to XML and communicates with the SOAP service using
    /// the provided authentication header. If the response indicates a failure (non-zero return code), an exception is
    /// thrown containing the error details.</remarks>
    /// <param name="auth">The authentication header used to authorize the SOAP request.</param>
    /// <param name="request">The request body containing the criteria for retrieving the post office list. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="PostOfficeListResult"/> containing the list of post offices and related response information.</returns>
    /// <exception cref="Exception">Thrown if the SOAP response indicates a failure (non-zero return code), with error details included in the
    /// exception message.</exception>
    public async Task<PostOfficeListResult> PostOfficeListAsync(ValidationSoapHeader auth, PostOfficeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PostOfficeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(PostOfficeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        PostOfficeListResponse response;

        Log.Information("Sending PostOfficeListAsync SOAP request");

        try
        {
            response = await _soap.PostOfficeListAsync(new PostOfficeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("PostOfficeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("PostOfficeListAsync Response: {@res}", response.PostOfficeListResult);

        var result = XmlParsing.DeserializeXmlToObject<PostOfficeListResult>(response.PostOfficeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("PostOfficeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PostOfficeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of postage affixes based on the specified request parameters.
    /// </summary>
    /// <remarks>This asynchronous method communicates with the remote service using the provided
    /// authentication header and request body. The returned result includes the list of postage affixes and associated
    /// status information.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the criteria for retrieving postage affixes. Cannot be <see langword="null"/>.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a <see
    /// cref="PostageAffixListResult"/> with the retrieved postage affix data and status information.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<PostageAffixListResult> PostageAffixListAsync(ValidationSoapHeader auth, PostageAffixListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PostageAffixListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(PostageAffixListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        PostageAffixListResponse response;

        Log.Information("Sending PostageAffixListAsync SOAP request");

        try
        {
            response = await _soap.PostageAffixListAsync(new PostageAffixListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("PostageAffixListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("PostageAffixListAsync Response: {@res}", response.PostageAffixListResult);

        var result = XmlParsing.DeserializeXmlToObject<PostageAffixListResult>(response.PostageAffixListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("PostageAffixListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PostageAffixListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve the list of postage statuses asynchronously.
    /// </summary>
    /// <remarks>This method serializes the provided request body to XML and sends it using the specified
    /// authentication header. If the response indicates a failure (non-zero return code), an exception is thrown
    /// containing the error details.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the postage status list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="PostageStatusListResult"/> containing the list of postage statuses and associated metadata.
    /// </returns>
    /// <exception cref="Exception">Thrown if the SOAP response indicates a failure, as determined by a non-zero return code.</exception>
    public async Task<PostageStatusListResult> PostageStatusListAsync(ValidationSoapHeader auth, PostageStatusListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(PostageStatusListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(PostageStatusListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        PostageStatusListResponse response;

        Log.Information("Sending PostageStatusListAsync SOAP request");

        try
        {
            response = await _soap.PostageStatusListAsync(new PostageStatusListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("PostageStatusListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("PostageStatusListAsync Response: {@res}", response.PostageStatusListResult);

        var result = XmlParsing.DeserializeXmlToObject<PostageStatusListResult>(response.PostageStatusListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("PostageStatusListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"PostageStatusListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of reason codes based on the specified request parameters.
    /// </summary>
    /// <remarks>This method serializes the <paramref name="request"/> to XML and communicates with the SOAP
    /// service using the provided authentication header. If the SOAP service returns a non-zero return code, an
    /// exception is thrown containing the error details.</remarks>
    /// <param name="auth">The authentication header used to authorize the SOAP request.</param>
    /// <param name="request">The request body containing parameters for the reason code list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="ReasonCodeListResult"/> containing the retrieved reason codes and associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating an error. The exception message includes
    /// the return code and error details.</exception>
    public async Task<ReasonCodeListResult> ReasonCodeListAsync(ValidationSoapHeader auth, ReasonCodeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ReasonCodeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(ReasonCodeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        ReasonCodeListResponse response;

        Log.Information("Sending ReasonCodeListAsync SOAP request");

        try
        {
            response = await _soap.ReasonCodeListAsync(new ReasonCodeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("ReasonCodeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("ReasonCodeListAsync Response: {@res}", response.ReasonCodeListResult);

        var result = XmlParsing.DeserializeXmlToObject<ReasonCodeListResult>(response.ReasonCodeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("ReasonCodeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ReasonCodeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of record resolutions based on the specified request parameters.
    /// </summary>
    /// <remarks>This method serializes the <see cref="RecordResolutionListRequestBody"/> to XML and transmits
    /// it via a SOAP request.  If the operation fails, an exception is thrown containing the return code and error
    /// details from the response.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the resolution list data to be recorded. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="RecordResolutionListResult"/> containing the result of the record operation, including status and
    /// any error information.</returns>
    /// <exception cref="Exception">Thrown if the SOAP response indicates a failure, including a non-zero return code or error details.</exception>
    public async Task<RecordResolutionListResult> RecordResolutionListAsync(ValidationSoapHeader auth, RecordResolutionListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(RecordResolutionListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(RecordResolutionListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        RecordResolutionListResponse response;

        Log.Information("Sending RecordResolutionListAsync SOAP request");

        try
        {
            response = await _soap.RecordResolutionListAsync(new RecordResolutionListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("RecordResolutionListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("RecordResolutionListAsync Response: {@res}", response.RecordResolutionListResult);

        var result = XmlParsing.DeserializeXmlToObject<RecordResolutionListResult>(response.RecordResolutionListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("RecordResolutionListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"RecordResolutionListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of residual instructions based on the specified request parameters.
    /// </summary>
    /// <remarks>This asynchronous method serializes the provided request body to XML and communicates with
    /// the SOAP service using the supplied authentication header. If the response indicates a failure (non-zero return
    /// code), an exception is thrown containing the error details.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the residual instruction list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="ResidualInstructionListResult"/> containing the list of residual instructions and associated
    /// metadata returned by the SOAP service.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service response indicates a failure (non-zero return code), or if an error occurs during the
    /// request.</exception>
    public async Task<ResidualInstructionListResult> ResidualInstructionListAsync(ValidationSoapHeader auth, ResidualInstructionListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ResidualInstructionListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(ResidualInstructionListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        ResidualInstructionListResponse response;

        Log.Information("Sending ResidualInstructionListAsync SOAP request");

        try
        {
            response = await _soap.ResidualInstructionListAsync(new ResidualInstructionListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("ResidualInstructionListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("ResidualInstructionListAsync Response: {@res}", response.ResidualInstructionListResult);

        var result = XmlParsing.DeserializeXmlToObject<ResidualInstructionListResult>(response.ResidualInstructionListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("ResidualInstructionListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ResidualInstructionListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of services based on the specified request parameters.
    /// </summary>
    /// <remarks>
    /// This asynchronous method serializes the provided request body to XML and communicates with the SOAP service using the supplied authentication header.
    /// The result includes the list of services and any associated status or error information. If the operation fails, an exception is thrown.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the service list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="ServiceListResult"/> containing the retrieved services and related response details.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<ServiceListResult> ServiceListAsync(ValidationSoapHeader auth, ServiceListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ServiceListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(ServiceListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        ServiceListResponse response;

        Log.Information("Sending ServiceListAsync SOAP request");

        try
        {
            response = await _soap.ServiceListAsync(new ServiceListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("ServiceListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("ServiceListAsync Response: {@res}", response.ServiceListResult);

        var result = XmlParsing.DeserializeXmlToObject<ServiceListResult>(response.ServiceListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("ServiceListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ServiceListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of unit measures based on the specified request parameters.
    /// </summary>
    /// <remarks>
    /// This asynchronous method serializes the provided request body to XML and communicates with the SOAP service using the supplied authentication header.
    /// The result includes the list of unit measures and any associated status or error information. If the operation fails, an exception is thrown.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the unit measure list query. Cannot be <c>null</c>.</param>
    /// <returns>A <see cref="UnitMeasureListResult"/> containing the retrieved unit measures and related response details.</returns>
    /// <exception cref="Exception">Thrown if the remote service returns a non-zero return code, indicating an error in processing the request.</exception>
    public async Task<UnitMeasureListResult> UnitMeasureListAsync(ValidationSoapHeader auth, UnitMeasureListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(UnitMeasureListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(UnitMeasureListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        UnitMeasureListResponse response;

        Log.Information("Sending UnitMeasureListAsync SOAP request");

        try
        {
            response = await _soap.UnitMeasureListAsync(new UnitMeasureListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("UnitMeasureListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("UnitMeasureListAsync Response: {@res}", response.UnitMeasureListResult);

        var result = XmlParsing.DeserializeXmlToObject<UnitMeasureListResult>(response.UnitMeasureListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("UnitMeasureListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"UnitMeasureListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    
    /// <summary>
    /// Sends a SOAP request to retrieve a list of order statuses asynchronously.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="OrderStatusListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the order status query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="OrderStatusListResult"/> containing order status details and status information for the requested order.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<OrderStatusListResult> OrderStatusListAsync(ValidationSoapHeader auth, OrderStatusListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(OrderStatusListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(OrderStatusListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        OrderStatusListResponse response;

        Log.Information("Sending OrderStatusListAsync SOAP request");

        try
        {
            response = await _soap.OrderStatusListAsync(new OrderStatusListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderStatusListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderStatusListAsync Response: {@res}", response.OrderStatusListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderStatusListResult>(response.OrderStatusListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderStatusListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderStatusListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    
    /// <summary>
    /// Retrieves a list of order version statuses asynchronously via a SOAP request.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided request body to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into an <see cref="OrderVersionStatusListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the order version status list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// An <see cref="OrderVersionStatusListResult"/> containing order version status details and status information for the requested order version.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<OrderVersionStatusListResult> OrderVersionStatusListAsync(ValidationSoapHeader auth, OrderVersionStatusListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(OrderVersionStatusListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(OrderVersionStatusListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        OrderVersionStatusListResponse response;

        Log.Information("Sending OrderVersionStatusListAsync SOAP request");

        try
        {
            response = await _soap.OrderVersionStatusListAsync(new OrderVersionStatusListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderVersionStatusListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderVersionStatusListAsync Response: {@res}", response.OrderVersionStatusListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderVersionStatusListResult>(response.OrderVersionStatusListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("OrderVersionStatusListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderVersionStatusListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
