using Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;
using Midnight.SOAP.SDK.ResponseObjects.InventoryItemOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with inventory item data through SOAP-based service.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>The <see cref="InventoryItemService"/> class offers a set of asynchronous methods to retrieve,
/// create, update,  and manage inventory item data, including locations, lots, transaction types, and item types. Each
/// method  communicates with a SOAP service, serializing request objects to XML and deserializing responses into 
/// strongly-typed result objects. Exceptions are thrown for non-zero return codes or SOAP request failures,  and
/// detailed logging is performed for debugging purposes.</remarks>
/// <param name="_soap"></param>
public class InventoryItemService(Service1Soap _soap)
{

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
    /// Sends a SOAP request to retrieve a list of inventory item lots based on the specified request parameters.
    /// </summary>
    /// <remarks>This method communicates with a SOAP service to retrieve inventory item lot data. If the
    /// operation fails, an exception is thrown with details about the failure. Ensure that the <paramref name="auth"/>
    /// parameter contains valid credentials and that the <paramref name="request"/> parameter is properly
    /// populated.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the parameters for the inventory item lot query.</param>
    /// <returns>An <see cref="InventoryItemLotListResult"/> object containing the result of the inventory item lot query,
    /// including the return code, any errors, and the list of inventory item lots.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, such as a non-zero return code.</exception>
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

    /// <summary>
    /// Sends a SOAP request to retrieve a list of item request types based on the specified criteria.
    /// </summary>
    /// <remarks>This method serializes the request body to XML and communicates with the SOAP service using
    /// the provided authentication header. If the service response indicates a failure (non-zero return code), an
    /// exception is thrown containing the error details.</remarks>
    /// <param name="auth">The authentication header containing validation credentials required for the SOAP request.</param>
    /// <param name="request">The request body specifying the criteria for retrieving item request types. Cannot be <c>null</c>.</param>
    /// <returns>An <see cref="ItemRequestTypeListResult"/> containing the list of item request types and associated metadata
    /// returned by the service.</returns>
    /// <exception cref="Exception">Thrown if the service response indicates a failure, or if an error occurs during the request or response
    /// processing.</exception>
    public async Task<ItemRequestTypeListResult> ItemRequestTypeListAsync(ValidationSoapHeader auth, ItemRequestTypeListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(ItemRequestTypeListRequestBody)} to Xml");
        Log.Debug("{@type}: {@request}", typeof(ItemRequestTypeListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);
        ItemRequestTypeListResponse response;

        Log.Information("Sending ItemRequestTypeListAsync SOAP request");

        try
        {
            response = await _soap.ItemRequestTypeListAsync(new ItemRequestTypeListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("ItemRequestTypeListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("ItemRequestTypeListAsync Response: {@res}", response.ItemRequestTypeListResult);

        var result = XmlParsing.DeserializeXmlToObject<ItemRequestTypeListResult>(response.ItemRequestTypeListResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("ItemRequestTypeListAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"ItemRequestTypeListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Updates inventory item lot information asynchronously using the provided SOAP request.
    /// </summary>
    /// <remarks>This method sends a SOAP request to update inventory item lot information. The request is
    /// serialized  to XML before being sent, and the response is deserialized into an <see
    /// cref="InventoryItemLotUpdateResult"/> object. If the operation fails, an exception is thrown with details about
    /// the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the inventory item lot update details.</param>
    /// <returns>An <see cref="InventoryItemLotUpdateResult"/> object containing the result of the update operation,  including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the returned result indicates a failure, as determined by a non-zero 
    /// return code in the <see cref="InventoryItemLotUpdateResult"/>.</exception>
    public async Task<InventoryItemLotUpdateResult> InventoryItemLotUpdateAsync(ValidationSoapHeader auth, InventoryItemLotUpdateRequestBody request)
    {

        InventoryItemLotUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(InventoryItemLotUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(InventoryItemLotUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending InventoryItemLotUpdateAsync SOAP request");

        try
        {
            response = await _soap.InventoryItemLotUpdateAsync(new InventoryItemLotUpdateRequest
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

        Log.Debug("InventoryItemLotUpdateAsync Response: {@res}", response.InventoryItemLotUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<InventoryItemLotUpdateResult>(response.InventoryItemLotUpdateResult);
        if (result.ReturnCode != 0)
        {
            Log.Error("InventoryItemLotUpdateAsync failed with ReturnCode: {@code}, Errors: {@message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"InventoryItemLotUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
