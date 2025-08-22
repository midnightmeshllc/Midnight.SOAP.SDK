using Midnight.SOAP.SDK.RequestObjects.CustomerInputs;
using Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with customer-related data and operations through a SOAP service.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>The <see cref="CustomerService"/> class acts as a client for a SOAP-based API, enabling operations
/// such as retrieving customer data,  updating customer information, and managing customer-related entities like
/// postage accounts, registration IDs, and permit numbers.  Each method in this class sends a SOAP request, processes
/// the response, and returns the result in a strongly-typed object. <para> This class requires an instance of <see
/// cref="Service1Soap"/> to be provided during initialization, which is used to send SOAP requests. </para> <para>
/// Exceptions are thrown for invalid input parameters or if the SOAP service returns an error. Ensure that all required
/// parameters are  properly populated and that the authentication header contains valid credentials. </para></remarks>
/// <param name="_soap"></param>
public class CustomerService(Service1Soap _soap)
{

    ///GetCustomerOrders
    ///GetOrderVersions
    ///GetOrderVersionsByName
    ///GetVersionDetails
    ///GetVersionDrops
    ///GetVersionDropsByOrder
    ///GetVersionDetailsByOrder
    ///ValidateOrderVersionDrops
    ///AggregateOrderVersionDetailsByServiceID > List of Aggregated Details
    ///AggregateOrderVersionDetailsByServiceIDForOrderID > List of Aggregated Details for order > overloads
    ///AggregateOrderVersionDetailsByServiceIDByParentCustomerID
    ///



    /// <summary>
    /// Sends a SOAP request to retrieve a list of customer postage accounts and returns the result.
    /// </summary>
    /// <remarks>
    /// This method serializes the provided <paramref name="request"/> to XML and sends it to the SOAP service using the authentication header.
    /// The response is deserialized into a <see cref="CustomerPostageAccountListResult"/> object. If the operation fails, an exception is thrown with details from the response.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the SOAP request.</param>
    /// <param name="request">The request body specifying the parameters for the customer postage account list query. Cannot be <c>null</c>.</param>
    /// <returns>
    /// A <see cref="CustomerPostageAccountListResult"/> containing postage account details and status information for the requested query.
    /// </returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="request"/> is <c>null</c>.</exception>
    /// <exception cref="Exception">
    /// Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes the return code and error details.
    /// </exception>
    public async Task<CustomerPostageAccountListResult> CustomerPostageAccountListAsync(ValidationSoapHeader auth, CustomerPostageAccountListRequestBody request)
    {

        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerPostageAccountListRequestBody)} to Xml");
        Log.Debug($"{typeof(CustomerPostageAccountListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerPostageAccountListResponse response;

        Log.Information($"Sending CustomerPostageAccountListAsync SOAP request");

        try
        {
            response = await _soap.CustomerPostageAccountListAsync(new CustomerPostageAccountListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("CustomerPostageAccountListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerPostageAccountListAsync Response: {@res}", response.CustomerPostageAccountListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerPostageAccountListResult>(response.CustomerPostageAccountListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerPostageAccountListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerPostageAccountListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Retrieves a list of customers based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve customer data and parses the response into a
    /// list  of <see cref="CustomerModel"/> objects. Ensure that the <paramref name="auth"/> parameter contains  valid
    /// credentials and the <paramref name="request"/> parameter is properly populated.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing parameters for filtering and retrieving customer data. Cannot be <see
    /// langword="null"/>.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of  <see
    /// cref="CustomerModel"/> objects representing the retrieved customer data.</returns>
    /// <exception cref="ArgumentNullException">Thrown if the <paramref name="request"/> parameter is <see langword="null"/>.</exception>
    public async Task<CustomerListResult> CustomerListAsync(ValidationSoapHeader auth, CustomerListRequestBody request)
    {

        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerListRequestBody)} to Xml");
        Log.Debug($"{typeof(CustomerListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerListResponse response;

        Log.Information($"Sending CustomerListAsync SOAP request");

        try
        {
            response = await _soap.CustomerListAsync(new CustomerListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("CustomerListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerListAsync Response: {@res}", response.CustomerListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerListResult>(response.CustomerListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Updates customer information by sending a SOAP request with the specified authentication header and request
    /// body.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing customer update details, including the customer code and other parameters.</param>
    /// <returns>A <see cref="CustomerUpdateResult"/> object containing the result of the update operation, including the return
    /// code and any error messages.</returns>
    /// <exception cref="Exception">Thrown if the update operation fails, as indicated by a non-zero return code or other errors in the response.</exception>
    public async Task<CustomerUpdateResult> CustomerUpdateAsync(ValidationSoapHeader auth, CustomerUpdateRequestBody request)
    {
        CustomerUpdateResponse response;

        Log.Information($"Converting {typeof(CustomerUpdateRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending CustomerUpdateAsync SOAP request for CustomerCode: {@id}", request.InputParameter.CustomerCode);

        try
        {
            response = await _soap.CustomerUpdateAsync(new CustomerUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerUpdateAsync Response: {@res}", response.CustomerUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerUpdateResult>(response.CustomerUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    public async Task<CustomerInsertResult> CustomerInsertAsync(ValidationSoapHeader auth, CustomerInsertRequestBody request)
    {
        CustomerInsertResponse response;

        Log.Information($"Converting {typeof(CustomerInsertRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerInsertRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending CustomerInsertAsync SOAP request for CustomerCode: {@id}", request.InputParameter.CustomerCode);
        try
        {
            response = await _soap.CustomerInsertAsync(new CustomerInsertRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerInsertAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerInsertAsync Response: {@res}", response.CustomerInsertResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerInsertResult>(response.CustomerInsertResult);

        if(result.ReturnCode != 0)
        {
            Log.Error("CustomerInsertAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerInsertAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of ghost numbers associated with a customer.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the operation. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="CustomerGhostNumberListResult"/> object containing the result of the operation,  including the list
    /// of ghost numbers and any associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an error occurs during the SOAP request.</exception>
    public async Task<CustomerGhostNumberListResult> CustomerGhostNumberListAsync(ValidationSoapHeader auth, CustomerGhostNumberListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerGhostNumberListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerGhostNumberListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        CustomerGhostNumberListResponse response;

        Log.Information("Sending CustomerGhostNumberListAsync SOAP request for CustomerID: {@id}", request.InputParameter.CustomerID);

        try
        {
            response = await _soap.CustomerGhostNumberListAsync(new CustomerGhostNumberListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerGhostNumberListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerGhostNumberListAsync Response: {@res}", response.CustomerGhostNumberListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerGhostNumberListResult>(response.CustomerGhostNumberListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerGhostNumberListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerGhostNumberListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of customer registration IDs (CRID) based on the provided input parameters.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, the method logs the error and throws an exception with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing input parameters for the operation. Cannot be <see langword="null"/>.</param>
    /// <returns>A <see cref="CustomerRegIDListResult"/> object containing the result of the operation, including the list of
    /// customer registration IDs.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an error occurs during the SOAP request.</exception>
    public async Task<CustomerRegIDListResult> CustomerRegIDListAsync(ValidationSoapHeader auth, CustomerRegIDListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        Log.Information($"Converting {typeof(CustomerRegIDListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerRegIDListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerRegIDListResponse response;

        Log.Information("Sending CustomerRegIDListAsync SOAP request for CustomerID: {@id}", request.InputParameter.CustomerID);

        try
        {
            response = await _soap.CustomerRegIDListAsync(new CustomerRegIDListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerRegIDListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerRegIDListAsync Response: {@res}", response.CustomerRegIDListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerRegIDListResult>(response.CustomerRegIDListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerRegIDListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerRegIDListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a SOAP request to retrieve a list of customer permit numbers based on the provided request parameters.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, the method logs the error and throws an exception with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the input parameters for the operation, including the customer ID and other relevant
    /// details.</param>
    /// <returns>A <see cref="CustomerPermitNumberListResult"/> object containing the result of the operation, including the list
    /// of permit numbers and any associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the operation fails with a non-zero return code or if an error occurs during the SOAP request or
    /// response processing.</exception>
    public async Task<CustomerPermitNumberListResult> CustomerPermitNumberListAsync(ValidationSoapHeader auth, CustomerPermitNumberListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        Log.Information($"Converting {typeof(CustomerPermitNumberListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerPermitNumberListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerPermitNumberListResponse response;

        Log.Information("Sending CustomerPermitNumberListAsync SOAP request for CustomerID: {@id}", request.InputParameter.CustomerID);

        try
        {
            response = await _soap.CustomerPermitNumberListAsync(new CustomerPermitNumberListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerPermitNumberListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerPermitNumberListAsync Response: {@res}", response.CustomerPermitNumberListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerPermitNumberListResult>(response.CustomerPermitNumberListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerPermitNumberListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerPermitNumberListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of non-profit authorization numbers for a specified customer.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve non-profit authorization numbers for a customer.
    /// Ensure that the <paramref name="auth"/> parameter contains valid authentication credentials  and that the
    /// <paramref name="request"/> parameter includes the required input data.</remarks>
    /// <param name="auth">The SOAP header containing authentication information for the request. Cannot be null.</param>
    /// <param name="request">The request body containing input parameters, including the customer ID.  Must not be null and must contain
    /// valid data.</param>
    /// <returns>A <see cref="CustomerNonProfitAuthNumberListResult"/> object containing the list of non-profit authorization
    /// numbers  and associated metadata. If the operation fails, an exception is thrown.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request.</exception>
    public async Task<CustomerNonProfitAuthNumberListResult> CustomerNonProfitAuthNumberListAsync(ValidationSoapHeader auth, CustomerNonProfitAuthNumberListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);
        Log.Information($"Converting {typeof(CustomerNonProfitAuthNumberListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(CustomerNonProfitAuthNumberListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerNonProfitAuthNumberListResponse response;

        Log.Information("Sending CustomerNonProfitAuthNumberListAsync SOAP request for CustomerID: {@id}", request.InputParameter.CustomerID);

        try
        {
            response = await _soap.CustomerNonProfitAuthNumberListAsync(new CustomerNonProfitAuthNumberListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("CustomerNonProfitAuthNumberListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerNonProfitAuthNumberListAsync Response: {@res}", response.CustomerNonProfitAuthNumberListResult);

        var result = XmlParsing.DeserializeXmlToObject<CustomerNonProfitAuthNumberListResult>(response.CustomerNonProfitAuthNumberListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("CustomerNonProfitAuthNumberListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"CustomerNonProfitAuthNumberListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

}
