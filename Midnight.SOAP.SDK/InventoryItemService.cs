using Midnight.SOAP.SDK.Models;
using Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;
using Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

public class InventoryItemService
{
    private readonly Service1SoapClient.EndpointConfiguration _soapConfig;
    private readonly Service1Soap _soap;
    public InventoryItemService()
    {
        _soapConfig = new Service1SoapClient.EndpointConfiguration();
        _soap = new Service1SoapClient(_soapConfig);
    }

    /// <summary>
    /// Retrieves a list of inventory item locations based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve inventory item location data.  If the operation
    /// fails, detailed error information is logged, and an exception is thrown.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the parameters for the inventory item location query.  This parameter cannot be <see
    /// langword="null"/>.</param>
    /// <returns>An <see cref="InventoryItemLocationListResult"/> object containing the results of the inventory item location
    /// query.</returns>
    /// <exception cref="Exception">Thrown if the operation fails due to a non-zero return code or if an error occurs during the SOAP request.</exception>
    public async Task<InventoryItemLocationListResult> InventoryItemLocationListAsync(ValidationSoapHeader auth, InventoryItemLocationListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(InventoryItemLocationListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(InventoryItemLocationListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        InventoryItemLocationListResponse response;

        Log.Information("Sending InventoryItemLocationListAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLocationListAsync(new InventoryItemLocationListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemLocationListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemLocationListAsync Response: {@res}", response.InventoryItemLocationListResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemLocationListResult>(response.InventoryItemLocationListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemLocationListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"InventoryItemLocationListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of inventory item lots based on the provided request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve inventory item lot data and parses the response
    /// into a list of <see cref="Lots"/>. Ensure that the <paramref name="auth"/> parameter contains valid credentials
    /// and the <paramref name="request"/> parameter is properly populated with the required filtering
    /// criteria.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for filtering and retrieving inventory item lots.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains a list of <see cref="Lots"/> objects
    /// representing the inventory item lots retrieved from the SOAP service.</returns>
    public async Task<InventoryItemLotListResult> InventoryItemLotListAsync(ValidationSoapHeader auth, InventoryItemLotListRequestBody request)
    {

        InventoryItemLotListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryItemLotListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryItemLotListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryItemLotListAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLotListAsync(new InventoryItemLotListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemLotLiistAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemLotListAsync Response: {@res}", response.InventoryItemLotListResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemLotListResult>(response.InventoryItemLotListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemLotListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"InventoryItemLotListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to create a new inventory item lot and retrieves the result.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the error. The caller should handle exceptions
    /// appropriately.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request. Cannot be null.</param>
    /// <param name="request">The request body containing the details of the inventory item lot to be created. Cannot be null.</param>
    /// <returns>An <see cref="InventoryItemLotNewResult"/> object containing the result of the operation, including any return
    /// codes or errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the operation returns a non-zero return code, indicating an error.</exception>
    public async Task<InventoryItemLotNewResult> InventoryItemLotNewAsync(ValidationSoapHeader auth, InventoryItemLotNewRequestBody request)
    {
        InventoryItemLotNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryItemLotNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryItemLotNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryItemLotNewAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLotNewAsync(new InventoryItemLotNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemLotNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemLotNewAsync Response: {@res}", response.InventoryItemLotNewResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemLotNewResult>(response.InventoryItemLotNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemLotNewAsync returned an error: {@error}", result.ReturnErrors);
            throw new Exception($"InventoryItemLotNewAsync failed with error code {result.ReturnCode}: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Retrieves a list of inventory item transaction types asynchronously.
    /// </summary>
    /// <remarks>This method sends a SOAP request to retrieve the inventory item transaction types.  It logs
    /// the request and response details for debugging purposes. If the operation fails,  an exception is thrown with
    /// detailed error information.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for the inventory item transaction type list operation. Cannot be
    /// <see langword="null"/>.</param>
    /// <returns>An <see cref="InventoryItemTransactionTypeListResult"/> object containing the result of the operation, 
    /// including the list of transaction types and any associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the operation fails due to a non-zero return code or if an error occurs during the SOAP request. The
    /// exception message will include the return code and error details.</exception>
    public async Task<InventoryItemTransactionTypeListResult> InventoryItemTransactionTypeListAsync(ValidationSoapHeader auth, InventoryItemTransactionTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(InventoryItemTransactionTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(InventoryItemTransactionTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        InventoryItemTransactionTypeListResponse response;

        Log.Information("Sending InventoryItemTransactionTypeListAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemTransactionTypeListAsync(new InventoryItemTransactionTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemTransactionTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemTransactionTypeListAsync Response: {@res}", response.InventoryItemTransactionTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemTransactionTypeListResult>(response.InventoryItemTransactionTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemTransactionTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"InventoryItemTransactionTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    
    /// <summary>
    /// Retrieves a list of inventory item types asynchronously.
    /// </summary>
    /// <remarks>
    /// This method sends a SOAP request to retrieve inventory item type data. It logs the request and response details for debugging purposes.
    /// If the operation fails, an exception is thrown with detailed error information.
    /// </remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for the inventory item type list operation. Cannot be <see langword="null"/>.</param>
    /// <returns>An <see cref="InventoryItemTypeListResult"/> object containing the result of the operation, including the list of item types and any associated metadata.</returns>
    /// <exception cref="Exception">Thrown if the operation fails due to a non-zero return code or if an error occurs during the SOAP request. The exception message will include the return code and error details.</exception>
    public async Task<InventoryItemTypeListResult> InventoryItemTypeListAsync(ValidationSoapHeader auth, InventoryItemTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(InventoryItemTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(InventoryItemTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        InventoryItemTypeListResponse response;

        Log.Information("Sending InventoryItemTypeListAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemTypeListAsync(new InventoryItemTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("InventoryItemTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("InventoryItemTypeListAsync Response: {@res}", response.InventoryItemTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemTypeListResult>(response.InventoryItemTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"InventoryItemTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
