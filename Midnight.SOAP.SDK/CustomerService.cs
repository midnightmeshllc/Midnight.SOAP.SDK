using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.CustomerInputs;
using Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with customer data through SOAP-based web services.
/// </summary>
/// <remarks>The <see cref="CustomerService"/> class facilitates operations such as retrieving customer lists and
/// updating customer information by sending SOAP requests to a configured endpoint. This class requires valid
/// authentication headers and properly formatted request objects for its methods. It is designed to handle asynchronous
/// operations and return structured responses.</remarks>
public class CustomerService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public CustomerService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
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
    public async Task<List<CustomerModel>> CustomerListAsync(ValidationSoapHeader auth, CustomerListRequestBody request)
    {

        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(CustomerListRequestBody)} to Xml");
        Log.Debug($"{typeof(CustomerListRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        CustomerListResponse response;
        List<CustomerModel> parsedResponse;

        Log.Information($"Sending CustomerListAsync SOAP request");

        try
        {
            response = await _soap.CustomerListAsync(new CustomerListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

            Log.Information("Parsing CustomerListAsync response into List of {@type}", typeof(CustomerModel));

            parsedResponse = XmlParser.GetCustomerData(response.CustomerListResult);

        }
        catch (Exception ex)
        {
            Log.Error("CustomerListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("CustomerListAsync Response: {@res}", response.CustomerListResult);

        return parsedResponse;
    }


    /// <summary>
    /// Sends a SOAP request to update customer information based on the provided input parameters.
    /// </summary>
    /// <remarks>This method converts the <see cref="CustomerUpdateRequestBody"/> into XML format before sending the
    /// SOAP request. Ensure that the <paramref name="auth"/> parameter contains valid credentials and the <paramref
    /// name="request"/> parameter includes all required fields for the update operation.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing customer update details, including the customer code and other parameters.</param>
    /// <returns>A <see cref="CustomerUpdateResponse"/> object containing the result of the customer update operation.</returns>
    public async Task<CustomerUpdateResponse> CustomerUpdateAsync(ValidationSoapHeader auth, CustomerUpdateRequestBody request)
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

        return response;
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
}
