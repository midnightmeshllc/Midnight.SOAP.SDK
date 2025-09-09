using Midnight.SOAP.SDK.RequestObjects.OrderInputs;
using Midnight.SOAP.SDK.ResponseObjects.OrderOutputs;
using Midnight.SOAP.SDK.Utilities;
using MidnightAPI;
using Serilog;

namespace Midnight.SOAP.SDK;

/// <summary>
/// Provides methods for interacting with orders through a SOAP-based service.
/// IMPORTANT: Must inject output of Utilities.SoapClient.Configure().
/// </summary>
/// <remarks>The <see cref="OrderService"/> class offers a set of asynchronous methods to manage orders, including
/// retrieving, creating, updating, and attaching files to orders. Each method communicates with a SOAP service, sending
/// requests and processing responses. Ensure that valid authentication credentials are provided for all operations.
/// <para> This class is designed to handle common order-related operations, such as retrieving order lists, adding new
/// orders, updating existing orders, and managing attachments. Exceptions are thrown for invalid inputs or when the
/// SOAP service returns an error. </para> <para> Usage of this class requires familiarity with the SOAP service's
/// request and response structures. Ensure that all required parameters are properly populated before invoking any
/// methods. </para></remarks>
/// <param name="_soap"></param>
public class OrderService(Service1Soap _soap)
{

    /// <summary>
    /// Sends a SOAP request to retrieve an ordered list based on the specified request parameters.
    /// </summary>
    /// <remarks>This method sends a SOAP request to the configured service endpoint and processes the
    /// response. If the operation fails, an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the parameters for the order list operation. Cannot be <see langword="null"/>.</param>
    /// <returns>An <see cref="OrderListResult"/> object containing the results of the order list operation.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating a failure. The exception message includes
    /// the return code and any associated error messages.</exception>
    public async Task<OrderListResult> OrderListAsync(ValidationSoapHeader auth, OrderListRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        OrderListResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderListRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderListRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderListAsync SOAP request");

        try
        {
            response = await _soap.OrderListAsync(new OrderListRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error("OrderListAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderListAsync Response: {@res}", response.OrderListResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderListResult>(response.OrderListResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderListAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderListAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends a SOAP request to perform a quick add operation for an order and returns the result.
    /// </summary>
    /// <remarks>This method converts the provided <paramref name="request"/> object into XML format and sends
    /// it as part of a SOAP request. If the operation fails, an exception is thrown with details about the
    /// failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the details of the order to be added.</param>
    /// <returns>An <see cref="OrderQuickAddResult"/> object containing the result of the operation, including the return code
    /// and any errors.</returns>
    /// <exception cref="Exception">Thrown if the operation fails, including cases where the return code indicates an error.</exception>
    public async Task<OrderQuickAddResult> OrderQuickAddAsync(ValidationSoapHeader auth, OrderQuickAddRequestBody request)
    {

        OrderQuickAddResponse response;

        Log.Information("Covnerting {@type} to Xml", typeof(OrderQuickAddRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderQuickAddRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderQuickAddAsync SOAP request");

        try
        {
            response = await _soap.OrderQuickAddAsync(new OrderQuickAddRequest
            {
                ValidationSoapHeader = auth,
                sXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderQuickAddAsync Excpetion: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderQuickAddAsync Response: {@res}", response.OrderQuickAddResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderQuickAddResult>(response.OrderQuickAddResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderQuickAddAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderQuickAddAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Sends an asynchronous SOAP request to update an order and returns the result of the operation.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails,  an exception is thrown with details about the failure.</remarks>
    /// <param name="auth">The authentication header containing credentials required to authorize the request.</param>
    /// <param name="request">The request body containing the details of the order to be updated.</param>
    /// <returns>An <see cref="OrderUpdateResult"/> object containing the result of the order update operation,  including the
    /// return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code or if an error occurs during the request.</exception>
    public async Task<OrderUpdateResult> OrderUpdateAsync(ValidationSoapHeader auth, OrderUpdateRequestBody request)
    {

        OrderUpdateResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderUpdateRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderUpdateRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderUpdateAsync SOAP request");

        try
        {
            response = await _soap.OrderUpdateAsync(new OrderUpdateRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderUpdateAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderUpdateAsync Response: {@res}", response.OrderUpdateResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderUpdateResult>(response.OrderUpdateResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderUpdateAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderUpdateAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }

    /// <summary>
    /// Sends a new order request asynchronously using SOAP and returns the response.
    /// </summary>
    /// <param name="auth">The authentication header containing credentials required for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the new order to be processed.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the response from the SOAP service, 
    /// including the result of the order processing.</returns>
    public async Task<OrderNewResult> OrderNewAsync(ValidationSoapHeader auth, OrderNewRequestBody request)
    {
        OrderNewResponse response;

        Log.Information("Converting {@type} to Xml", typeof(OrderNewRequestBody));
        Log.Debug("{@type}: {@req}", typeof(OrderNewRequestBody), FileOutput.CreateXmlFromClass(request));

        var inputXml = FileOutput.CreateXmlFromClass(request);

        Log.Information("Sending OrderNewAsync SOAP request");
        try
        {
            response = await _soap.OrderNewAsync(new OrderNewRequest
            {
                ValidationSoapHeader = auth,
                sXML = inputXml
            });
        }
        catch (Exception ex)
        {
            Log.Error("OrderNewAsync Exception: {@ex}", ex.Message);
            throw;
        }

        Log.Debug("OrderNewAsync Response: {@res}", response.OrderNewResult);

        var result = XmlParsing.DeserializeXmlToObject<OrderNewResult>(response.OrderNewResult);

        if ( result.ReturnCode != 0)
        {
            Log.Error("OrderNewAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }


    /// <summary>
    /// Adds an attachment to an order asynchronously.
    /// </summary>
    /// <remarks>This method validates the input parameters and ensures that the file content is non-empty
    /// before attempting to add the attachment. If the operation fails, an exception is thrown or an error result is
    /// returned, depending on the failure condition.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP service.</param>
    /// <param name="fileContent">Must be a non-0 byte array. Valid file types are - .jpg, .jpeg, .png, .gif, .bmp, .pdf, and .eps </param>
    /// <param name="fileName">The name of the file to be attached. Cannot be null or whitespace.</param>
    /// <param name="documentTypeId">The optional document type identifier for the attachment. Can be null if not applicable.</param>
    /// <param name="orderId">The identifier of the order to which the attachment will be added. Must be a valid, non-null integer.</param>
    /// <returns>An <see cref="OrderAddAttachmentResult"/> object containing the result of the operation, including a return code
    /// and any errors encountered.</returns>
    /// <exception cref="Exception">Thrown if the SOAP service returns a non-zero return code, indicating a failure in adding the attachment.</exception>
    public async Task<OrderAddAttachmentResult> OrderAddAttachmentAsync(ValidationSoapHeader auth, byte[] fileContent, 
        string fileName, int? documentTypeId, int orderId)
    {
        ArgumentNullException.ThrowIfNull(fileContent);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(fileName);
        ArgumentNullException.ThrowIfNullOrWhiteSpace(orderId.ToString());

        OrderAddAttachmentResponse response;
        
        if (fileContent.Any(b => b != 0))
        {
            Log.Information("fileContent confirmed as non-zero byte array");

            try
            {
                response = await _soap.OrderAddAttachmentAsync(new OrderAddAttachmentRequest
                {
                    ValidationSoapHeader = auth,
                    fileContent = fileContent,
                    fileName = fileName,
                    documentTypeId = documentTypeId,
                    orderId = orderId
                });
            }
            catch (Exception ex)
            {
                Log.Error("OrderAddAttachmentAsync Exception: {@ex}", ex.Message);
                throw;
            }

            Log.Debug("OrderAddAttachmentAsync Response: {@res}", response.OrderAddAttachmentResult);

            var result = XmlParsing.DeserializeXmlToObject<OrderAddAttachmentResult>(response.OrderAddAttachmentResult);

            if (result.ReturnCode != 0)
            {
                Log.Error("OrderAddAttachmentAsync failed with ReturnCode: {@code}, Errors: {@errors}", result.ReturnCode, result.ReturnErrors);
                throw new Exception($"OrderAddAttachmentAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
            }

            return result;

        }
        else
        {
            Log.Error("File content byte array must be non-zero");
            return new OrderAddAttachmentResult
            {
                ReturnCode = -1,
                ReturnErrors = new List<CommonObjects.ReturnError>
                {
                    new CommonObjects.ReturnError{ Error = "File content byte array must be non-zero" }
                }
            };
        }
    }

    /// <summary>
    /// Sends a SOAP request to create a new shipment order and processes the response.
    /// </summary>
    /// <remarks>This method logs the request and response details for debugging purposes. If the operation
    /// fails, an exception is thrown with details about the failure, including the return code and error
    /// messages.</remarks>
    /// <param name="auth">The authentication header containing credentials for the SOAP request.</param>
    /// <param name="request">The request body containing the details of the shipment order to be created. Cannot be <see langword="null"/>.</param>
    /// <returns>An <see cref="OrderShipmentNewResult"/> object containing the result of the shipment order creation, including
    /// the return code and any associated errors.</returns>
    /// <exception cref="Exception">Thrown if the SOAP request fails or if the response indicates an error, as determined by a non-zero return code.</exception>
    public async Task<OrderShipmentNewResult> OrderShipmentNewAsync(ValidationSoapHeader auth, OrderShipmentNewRequestBody request)
    {
        ArgumentNullException.ThrowIfNull(request);

        Log.Information($"Converting {typeof(OrderShipmentNewRequestBody)} to Xml");
        Log.Debug($"{typeof(OrderShipmentNewRequestBody)}: {FileOutput.CreateXmlFromClass(request)}");

        var inputXml = FileOutput.CreateXmlFromClass(request);

        OrderShipmentNewResponse response;

        Log.Information($"Sending OrderShipmentNewAsync SOAP request");

        try
        {
            response = await _soap.OrderShipmentNewAsync(new OrderShipmentNewRequest
            {
                ValidationSoapHeader = auth,
                inputXML = inputXml
            });

        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error occurred while sending OrderShipmentNewAsync SOAP request");
            throw;
        }

        Log.Debug($"{typeof(OrderShipmentNewResult)}: {FileOutput.CreateXmlFromClass(response)}");

        var result = XmlParsing.DeserializeXmlToObject<OrderShipmentNewResult>(response.OrderShipmentNewResult);

        if (result.ReturnCode != 0)
        {
            Log.Error("OrderShipmentNewAsync failed with ReturnCode: {ReturnCode}, Errors: {Message}", result.ReturnCode, result.ReturnErrors);
            throw new Exception($"OrderShipmentNewAsync failed with ReturnCode: {result.ReturnCode}, Errors: {result.ReturnErrors}");
        }

        return result;
    }
}
