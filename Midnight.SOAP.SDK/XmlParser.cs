using Midnight.SOAP.SDK.Models;
using Serilog;
using System.Xml.Linq;

namespace Midnight.SOAP.SDK
{
    /// <summary>
    /// Provides methods for parsing Midnight XML data into various data models.
    /// </summary>
    /// <remarks>The <see cref="XmlParser"/> class includes static methods to extract and convert XML data
    /// into specific data models such as customers, orders, and inventory items. Each method expects a well-formed XML
    /// string as input and returns a list of corresponding data model objects.</remarks>
    public class XmlParser
    {
        /// <summary>
        /// Parses the provided XML input to extract customer data and returns a list of customer models.
        /// </summary>
        /// <remarks>The method expects the XML input to contain customer information structured under
        /// "Customers" and "Customer" elements. Each customer element should include various sub-elements such as
        /// "CustomerID", "CustomerName", "Active", etc.</remarks>
        /// <param name="xmlinput">A string containing XML data representing customers. The XML must conform to the expected structure with
        /// customer details.</param>
        /// <returns>A list of <see cref="CustomerModel"/> objects populated with data extracted from the XML input. The list
        /// will be empty if no customer data is found.</returns>
        public static List<CustomerModel> GetCustomerData(string xmlinput)
        {
            var cxInfo = new List<CustomerModel>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for customer data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var CustomerData = xelement.Elements("Customers").SelectMany(x => x.Elements("Customer")).ToList();
                xelement.Elements("CustomerAddress").Select(y => y.Elements()).ToList();

                foreach (var a in CustomerData)
                {


                    cxInfo.Add(new CustomerModel
                    {
                        CustomerID = Convert.ToInt32(a.Element("CustomerID")?.Value ?? "0"),
                        CustomerCode = Convert.ToString(a.Element("AccountingCode")?.Value ?? ""),
                        CustomerName = Convert.ToString(a.Element("CustomerName")?.Value ?? ""),
                        IsActive = Convert.ToBoolean(a.Element("Active")?.Value ?? "false"),
                        ParentCustomerID = string.IsNullOrWhiteSpace(a.Element("ParentCustomerID")?.Value) ? 0
                            : int.Parse(a.Element("ParentCustomerID")?.Value ?? "0"),
                        CustomerTypeID = Convert.ToInt32(a.Element("CustomerTypeID")?.Value ?? "0"),
                        CustomerTypeName = Convert.ToString(a.Element("CustomerTypeName")?.Value ?? ""),
                        TermsCode = Convert.ToString(a.Element("TermsCode")?.Value ?? ""),
                        SalesRepID = Convert.ToInt32(a.Element("SalesRepID")?.Value ?? "0"),
                        SalesRepName = Convert.ToString(a.Element("SalesRepName")?.Value ?? ""),
                        CsrID = Convert.ToInt32(a.Element("CSRID")?.Value ?? "0"),
                        CsrName = Convert.ToString(a.Element("CSRName")?.Value ?? ""),
                        IsTaxable = Convert.ToBoolean(a.Element("Taxable")?.Value ?? "false"),
                        Website = Convert.ToString(a.Element("URL")?.Value ?? ""),
                        TaxJurisdictionID = Convert.ToInt32(a.Element("TaxJurisdictionID")?.Value ?? "0"),
                        TaxJurisdictionName = Convert.ToString(a.Element("TaxJurisdictionName")?.Value ?? ""),
                        TaxExemptionID = string.IsNullOrWhiteSpace(a.Element("TaxExemptionID")?.Value) ? 0
                            : int.Parse(a.Element("TaxExemptionID")?.Value ?? "0"),
                        TaxExemptionName = Convert.ToString(a.Element("TaxExemptionName")?.Value ?? ""),
                        AccountStatusID = Convert.ToInt32(a.Element("AccountStatusID")?.Value ?? "0"),
                        AccountStatusName = Convert.ToString(a.Element("AccountStatusName")?.Value ?? ""),
                        Address = new CustomerAddress
                        {
                            CustomerAddressLine1 = Convert.ToString(a.Element("CustomerAddress")?.Element("CustomerAddressLine1")?.Value ?? ""),
                            CustomerAddressLine2 = Convert.ToString(a.Element("CustomerAddress")?.Element("CustomerAddressLine2")?.Value ?? ""),
                            CustomerAddressLine3 = Convert.ToString(a.Element("CustomerAddress")?.Element("CustomerAddressLine3")?.Value ?? ""),
                            CustomerAddressCity = Convert.ToString(a.Element("CustomerAddress")?.Element("CustomerAddressCity")?.Value ?? ""),
                            CustomerAddressState = Convert.ToString(a.Element("CustomerAddress")?.Element("CustomerAddressState")?.Value ?? ""),
                            CustomerAddressZip = Convert.ToString(a.Element("CustomerAddress")?.Element("CustomerAddressZip")?.Value ?? ""),
                            CustomerAddressCountry = "United States"
                        },
                        Email = Convert.ToString(a.Element("EmailAddress")?.Value ?? ""),
                        PostageMarkupType = Convert.ToString(a.Element("PostageMarkupType")?.Value ?? ""),
                        PostageMarkupValue = string.IsNullOrWhiteSpace(a.Element("PostageMarkupValue")?.Value) ? 0.00M
                            : decimal.Parse(a.Element("PostageMarkupValue")?.Value ?? "0.00"),
                        UnpaidBalanceLimit = string.IsNullOrWhiteSpace(a.Element("UnpaidBalanceLimit")?.Value) ? 0.00M
                            : decimal.Parse(a.Element("UnpaidBalanceLimit")?.Value ?? "0.00")
                    });

                }

            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for customer data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }


            return cxInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract customer contact information.
        /// </summary>
        /// <remarks>Each <see cref="CustomerContact"/> object in the returned list is populated with data
        /// from the corresponding XML elements. The method expects the XML to contain elements for "CustomerID",
        /// "ContactID", "FirstName", "MiddleName", "LastName", "EmailAddress", and "Active".</remarks>
        /// <param name="xmlinput">A string containing XML data representing customer contacts. The XML must conform to the expected structure
        /// with "CustomerContacts" and "CustomerContact" elements.</param>
        /// <returns>A list of <see cref="CustomerContact"/> objects extracted from the XML input. The list will be empty if no
        /// valid customer contacts are found.</returns>
        public static List<CustomerContact> GetCustomerContactData(string xmlinput)
        {
            var contacts = new List<CustomerContact>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for customer contact data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var ContactData = xelement.Elements("CustomerContacts").SelectMany(z => z.Elements("CustomerContact")).ToList();

                foreach (var a in ContactData)
                {
                    contacts.Add(new CustomerContact
                    {
                        CustomerID = Convert.ToInt32(a.Element("CustomerID")?.Value ?? "0"),
                        ContactID = Convert.ToInt32(a.Element("ContactID")?.Value ?? "0"),
                        FirstName = string.IsNullOrWhiteSpace(a.Element("FirstName")?.Value) ? ""
                            : a.Element("FirstName")?.Value ?? "",
                        MiddleName = string.IsNullOrWhiteSpace(a.Element("MiddleName")?.Value) ? ""
                            : a.Element("MiddleName")?.Value ?? "",
                        LastName = string.IsNullOrWhiteSpace(a.Element("LastName")?.Value) ? ""
                            : a.Element("LastName")?.Value ?? "",
                        EmailAddress = string.IsNullOrWhiteSpace(a.Element("EmailAddress")?.Value) ? ""
                            : a.Element("EmailAddress")?.Value ?? "",
                        Active = Convert.ToBoolean(a.Element("Active")?.Value ?? "false")
                    });
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for customer contact data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return contacts;
        }

        /// <summary>
        /// Parses the provided XML input string to extract order data and returns a list of <see cref="OrderModel"/>
        /// objects.
        /// </summary>
        /// <remarks>The method expects the XML input to contain "Orders" elements, each with multiple
        /// "Order" child elements. Each "Order" element should contain specific child elements such as "OrderID",
        /// "OrderNumber", "CustomerID", etc., which are used to populate the properties of the <see
        /// cref="OrderModel"/>.</remarks>
        /// <param name="xmlinput">A string containing XML data representing orders. The XML must conform to the expected structure with
        /// "Orders" and "Order" elements.</param>
        /// <returns>A list of <see cref="OrderModel"/> objects populated with data extracted from the XML input. The list will
        /// be empty if no valid order data is found.</returns>
        public static List<OrderModel> GetOrderData(string xmlinput)
        {
            var orderInfo = new List<OrderModel>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for order data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var OrderData = xelement.Elements("Orders")
                                    .SelectMany(x => x.Elements("Order"))
                                    .ToList();

                foreach (var b in OrderData)
                {
                    orderInfo.Add(new OrderModel
                    {
                        OrderID = Convert.ToInt32(b.Element("OrderID")?.Value ?? "0"),
                        OrderNumber = b.Element("OrderNumber")?.Value ?? string.Empty,
                        CustomerID = Convert.ToInt32(b.Element("CustomerID")?.Value ?? "0"),
                        CustomerName = b.Element("CustomerName")?.Value ?? string.Empty,
                        ProjectName = b.Element("ProjectName")?.Value ?? string.Empty,
                        QuantityExpected = Convert.ToInt32(b.Element("QuantityExpected")?.Value ?? "0"),
                        OrderTax = string.IsNullOrWhiteSpace(b.Element("OrderTax")?.Value) ? 0.00M
                            : decimal.Parse(b.Element("OrderTax")?.Value ?? "0.00"),
                        OrderTotal = string.IsNullOrWhiteSpace(b.Element("OrderTotal")?.Value) ? 0.00M
                            : decimal.Parse(b.Element("OrderTotal")?.Value ?? "0.00"),
                        PostageTotal = string.IsNullOrWhiteSpace(b.Element("PostageTotal")?.Value) ? 0.00M
                            : decimal.Parse(b.Element("PostageTotal")?.Value ?? "0.00"),
                        OrderDate = b.Element("OrderDate")?.Value ?? string.Empty,
                        DueDate = b.Element("DueDate")?.Value ?? string.Empty,
                        CloseDate = b.Element("CloseDate")?.Value ?? string.Empty,
                        SalesRep = b.Element("SalesRepName")?.Value ?? string.Empty,
                    });
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for order data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return orderInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract order version data and returns a list of <see cref="Versions"/>
        /// objects.
        /// </summary>
        /// <param name="xmlinput">A string containing the XML data representing order versions. This XML must conform to the expected
        /// structure with elements such as "OrderVersion", "VersionID", "VersionName", etc.</param>
        /// <returns>A list of <see cref="Versions"/> objects, each representing an order version extracted from the XML input.
        /// The list will be empty if no order versions are found.</returns>
        public static List<Versions> GetOrderVersionData(string xmlinput)
        {
            var orderVersInfo = new List<Versions>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for order version data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var OrderVersData = xelement.Elements("OrderVersions")
                                    .SelectMany(x => x.Elements("OrderVersion"))
                                    .ToList();

                foreach (var c in OrderVersData)
                {

                    orderVersInfo.Add(new Versions
                    {
                        VersionID = Convert.ToInt32(c.Element("VersionID")?.Value ?? "0"),
                        VersionName = c.Element("VersionName")?.Value ?? string.Empty,
                        Quantity = Convert.ToInt32(c.Element("Quantity")?.Value ?? "0"),
                        SubTotal = string.IsNullOrWhiteSpace(c.Element("SubTotal")?.Value) ? 0.00M
                            : decimal.Parse(c.Element("SubTotal")?.Value ?? "0.00"),
                        TaxAmount = string.IsNullOrWhiteSpace(c.Element("TaxAmt")?.Value) ? 0.00M
                            : decimal.Parse(c.Element("TaxAmt")?.Value ?? "0.00"),
                        Postage = string.IsNullOrWhiteSpace(c.Element("Postage")?.Value) ? 0.00M
                            : decimal.Parse(c.Element("Postage")?.Value ?? "0.00"),
                        PostageAffixID = Convert.ToInt32(c.Element("PostageAffixID")?.Value ?? "0"),
                        PostageAffixName = c.Element("PostageAffixName")?.Value ?? string.Empty,
                        MailClassID = Convert.ToInt32(c.Element("MailClassID")?.Value ?? "0"),
                        MailClassName = c.Element("MailClassName")?.Value ?? string.Empty,
                        TotalDue = string.IsNullOrWhiteSpace(c.Element("TotalDue")?.Value) ? 0.00M
                            : decimal.Parse(c.Element("TotalDue")?.Value ?? "0.00"),
                        VersionDropDate = c.Element("VersionDropDate")?.Value ?? string.Empty,
                        VersionDropActualDate = c.Element("VersionDropActualDate")?.Value ?? string.Empty
                    });

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for order version data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return orderVersInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract order version drop data.
        /// </summary>
        /// <param name="xmlinput">A string containing the XML data representing order version drops.</param>
        /// <returns>A list of <see cref="Drops"/> objects, each representing an order version drop extracted from the XML input.</returns>
        public static List<Drops> GetOrderVersionDropData(string xmlinput)
        {
            var orderVersDropInfo = new List<Drops>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for order version drop data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var OrderVersDropData = xelement.Elements("OrderVersionDrops")
                                    .SelectMany(x => x.Elements("OrderVersionDrop"))
                                    .ToList();

                foreach (var d in OrderVersDropData)
                {
                    orderVersDropInfo.Add(new Drops
                    {
                        OrderVersionDropID = Convert.ToInt32(d.Element("OrderVersionDropID")?.Value ?? "0"),
                        Quantity = Convert.ToInt32(d.Element("Quantity")?.Value ?? "0"),
                        DropName = d.Element("DropName")?.Value ?? string.Empty,
                        DropDate = d.Element("DropDate")?.Value ?? string.Empty,
                        ActualDrop = d.Element("ActualDrop")?.Value ?? string.Empty,
                        DropDateComplete = Convert.ToBoolean(d.Element("DropDateComplete")?.Value ?? "false")
                    });
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for order version drop data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return orderVersDropInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract order version detail data.
        /// </summary>
        /// <param name="xmlinput">A string containing the XML data representing order version details. This XML must conform to the expected
        /// structure with elements such as "OrderVersionDetail", "OrderVersionDetailID", "VersionID", etc.</param>
        /// <returns>A list of <see cref="Details"/> objects, each representing an order version detail extracted from the XML
        /// input. The list will be empty if no valid order version details are found.</returns>
        public static List<Details> GetOrderVersionDetailData(string xmlinput)
        {
            var orderVersDetailInfo = new List<Details>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for order version detail data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var OrderVersDetailData = xelement.Elements("OrderVersionDetails")
                                    .SelectMany(x => x.Elements("OrderVersionDetail"))
                                    .ToList();

                foreach (var e in OrderVersDetailData)
                {

                    orderVersDetailInfo.Add(new Details
                    {
                        OrderVersionDetailID = Convert.ToInt32(e.Element("OrderVersionDetailID")?.Value ?? "0"),
                        VersionID = Convert.ToInt32(e.Element("VersionID")?.Value ?? "0"),
                        ServiceTypeID = Convert.ToInt32(e.Element("ServiceTypeID")?.Value ?? "0"),
                        ServiceID = Convert.ToInt32(e.Element("ServiceID")?.Value ?? "0"),
                        ServiceCode = e.Element("ServiceCode")?.Value ?? string.Empty,
                        ServiceName = e.Element("ServiceName")?.Value ?? string.Empty,
                        Quantity = string.IsNullOrWhiteSpace(e.Element("Quantity")?.Value) ? 0.00M
                            : decimal.Parse(e.Element("Quantity")?.Value ?? "0.00"),
                        UnitPrice = string.IsNullOrWhiteSpace(e.Element("UnitPrice")?.Value) ? 0.00M
                            : decimal.Parse(e.Element("UnitPrice")?.Value ?? "0.00"),
                        LineTotal = string.IsNullOrWhiteSpace(e.Element("LineTotal")?.Value) ? 0.00M
                            : decimal.Parse(e.Element("LineTotal")?.Value ?? "0.00"),
                        IsTaxable = Convert.ToBoolean(e.Element("Taxable")?.Value ?? "false"),
                        TaxablePercent = string.IsNullOrWhiteSpace(e.Element("TaxablePercent")?.Value) ? 0.00M
                            : decimal.Parse(e.Element("TaxablePercent")?.Value ?? "0.00"),
                        TaxAmount = string.IsNullOrWhiteSpace(e.Element("TaxAmount")?.Value) ? 0.00M
                            : decimal.Parse(e.Element("TaxAmount")?.Value ?? "0.00"),
                        UnitOfMeasure = e.Element("UnitOfMeasureName")?.Value ?? string.Empty
                    });

                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for order version detail data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return orderVersDetailInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract order version inventory data.
        /// </summary>
        /// <remarks>The method expects the XML input to contain elements named "OrderVersionInventorys"
        /// with nested "OrderVersionInventory" elements. Each "OrderVersionInventory" element should contain child
        /// elements for "OrderInventoryID", "OrderID", "VersionID", "ItemID", "Description", "QuantityNeeded", "Notes",
        /// and "ItemCode".</remarks>
        /// <param name="xmlinput">A string containing the XML data representing order version inventories.</param>
        /// <returns>A list of <see cref="Inventorys"/> objects, each representing an order version inventory entry extracted
        /// from the XML.</returns>
        public static List<Inventorys> GetOrderVersionInventoryData(string xmlinput)
        {
            var orderVersionInventoryInfo = new List<Inventorys>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for order version inventory data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var OrderVersionInventoryData = xelement.Elements("OrderVersionInventorys")
                                    .SelectMany(x => x.Elements("OrderVersionInventory"))
                                    .ToList();

                foreach (var e in OrderVersionInventoryData)
                {
                    orderVersionInventoryInfo.Add(new Inventorys
                    {
                        OrderInventoryID = Convert.ToInt32(e.Element("OrderInventoryID")?.Value ?? "0"),
                        OrderID = Convert.ToInt32(e.Element("OrderID")?.Value ?? "0"),
                        VersionID = Convert.ToInt32(e.Element("VersionID")?.Value ?? "0"),
                        ItemID = Convert.ToInt32(e.Element("ItemID")?.Value ?? "0"),
                        Description = e.Element("Description")?.Value ?? string.Empty,
                        QuantityNeeded = string.IsNullOrWhiteSpace(e.Element("QuantityNeeded")?.Value) ? 0.00M
                            : decimal.Parse(e.Element("QuantityNeeded")?.Value ?? "0.00"),
                        Notes = e.Element("Notes")?.Value ?? string.Empty,
                        ItemCode = e.Element("ItemCode")?.Value ?? string.Empty
                    });
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for order version inventory data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return orderVersionInventoryInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract inventory data and returns a list of items.
        /// </summary>
        /// <remarks>Each "Item" element in the XML is expected to contain various child elements such as
        /// "ItemID", "CustomerName", "Active", etc. The method will attempt to parse these elements and populate the
        /// corresponding properties of the <see cref="Items"/> class.</remarks>
        /// <param name="xmlinput">A string containing the XML data representing inventory items. The XML must conform to the expected
        /// structure with "Items" and "Item" elements.</param>
        /// <returns>A list of <see cref="Items"/> objects populated with data extracted from the XML input. The list will be
        /// empty if no valid items are found.</returns>
        public static List<Items> GetInventoryData(string xmlinput)
        {
            var inventoryItemInfo = new List<Items>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for inventory data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var InventoryData = xelement.Elements("Items")
                                    .SelectMany(x => x.Elements("Item"))
                                    .ToList();

                foreach (var e in InventoryData)
                {
                    inventoryItemInfo.Add(new Items
                    {
                        ItemID = string.IsNullOrWhiteSpace(e.Element("ItemID")?.Value) ? 0
                            : Convert.ToInt32(e.Element("ItemID")?.Value ?? "0"),
                        CustomerID = string.IsNullOrWhiteSpace(e.Element("CustomerID")?.Value) ? 0
                            : Convert.ToInt32(e.Element("CustomerID")?.Value ?? "0"),
                        Active = string.IsNullOrWhiteSpace(e.Element("Active")?.Value) ? false
                            : Convert.ToBoolean(e.Element("Active")?.Value ?? "false"),
                        CustomerName = e.Element("CustomerName")?.Value ?? "",
                        ItemTypeDescription = e.Element("ItemTypeDescription")?.Value ?? "",
                        ItemCode = e.Element("ItemCode")?.Value ?? "",
                        ItemName = e.Element("ItemName")?.Value ?? "",
                        ItemDescription = e.Element("ItemDescription")?.Value ?? "",
                        CustomerPartNumber = e.Element("CustomerPartNumber")?.Value ?? "",
                        VersionNumber = e.Element("VersionNumber")?.Value ?? "",
                        Lot = e.Element("Lot")?.Value ?? "",
                        ExpirationDate = e.Element("ExpirationDate")?.Value ?? "",
                        Discontinued = string.IsNullOrWhiteSpace(e.Element("Discontinued")?.Value) ? false
                            : Convert.ToBoolean(e.Element("Discontinued")?.Value ?? "false"),
                        Kit = string.IsNullOrWhiteSpace(e.Element("Kit")?.Value) ? false
                            : Convert.ToBoolean(e.Element("Kit")?.Value ?? "false"),
                        Global = string.IsNullOrWhiteSpace(e.Element("Global")?.Value) ? false
                            : Convert.ToBoolean(e.Element("Global")?.Value ?? "false"),
                        UPCCode = e.Element("UPCCode")?.Value ?? "",
                        UnitValue = string.IsNullOrWhiteSpace(e.Element("UnitValue")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("UnitValue")?.Value ?? "0.00"),
                        UnitMeasureCode = e.Element("UnitMeasureCode")?.Value ?? "",
                        UnitMeasureName = e.Element("UnitMeasureName")?.Value ?? "",
                        ReOrderPoint = string.IsNullOrWhiteSpace(e.Element("ReOrderPoint")?.Value) ? 0
                            : Convert.ToInt32(e.Element("ReOrderPoint")?.Value ?? "0"),
                        ReOrderQuantity = string.IsNullOrWhiteSpace(e.Element("ReOrderQuantity")?.Value) ? 0
                            : Convert.ToInt32(e.Element("ReOrderQuantity")?.Value ?? "0"),
                        LeadTime = e.Element("LeadTime")?.Value ?? "",
                        DefaultQuantityPerContainer = e.Element("DefaultQuantityPerContainer")?.Value ?? "",
                        POItem = string.IsNullOrWhiteSpace(e.Element("POItem")?.Value) ? false
                            : Convert.ToBoolean(e.Element("POItem")?.Value ?? "false"),
                        PrintOnDemand = string.IsNullOrWhiteSpace(e.Element("PrintOnDemand")?.Value) ? false
                            : Convert.ToBoolean(e.Element("PrintOnDemand")?.Value ?? "false"),
                        DigitalAsset = string.IsNullOrWhiteSpace(e.Element("DigitalAsset")?.Value) ? false
                            : Convert.ToBoolean(e.Element("DigitalAsset")?.Value ?? "false"),
                        Serialized = string.IsNullOrWhiteSpace(e.Element("Serialized")?.Value) ? false
                            : Convert.ToBoolean(e.Element("Serialized")?.Value ?? "false"),
                        Vendor = e.Element("Vendor")?.Value ?? "",
                        Color = e.Element("Color")?.Value ?? "",
                        UnitCost = string.IsNullOrWhiteSpace(e.Element("UnitCost")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("UnitCost")?.Value ?? "0.00"),
                        ParentSheetLength = string.IsNullOrWhiteSpace(e.Element("ParentSheetLength")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("ParentSheetLength")?.Value ?? "0.00"),
                        ParentSheetWidth = string.IsNullOrWhiteSpace(e.Element("ParentSheetWidth")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("ParentSheetWidth")?.Value ?? "0.00"),
                        BasisWeight = string.IsNullOrWhiteSpace(e.Element("BasisWeight")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("BasisWeight")?.Value ?? "0.00"),
                        MWeight = string.IsNullOrWhiteSpace(e.Element("MWeight")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("MWeight")?.Value ?? "0.00"),
                        Caliper = string.IsNullOrWhiteSpace(e.Element("Caliper")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("Caliper")?.Value ?? "0.00"),
                        Coated = string.IsNullOrWhiteSpace(e.Element("Coated")?.Value) ? false
                            : Convert.ToBoolean(e.Element("Coated")?.Value ?? "false"),
                        CostPerCwt = string.IsNullOrWhiteSpace(e.Element("CostPerCwt")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("CostPerCwt")?.Value ?? "0.00"),
                        CostPerMSheets = string.IsNullOrWhiteSpace(e.Element("CostPerMSheets")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("CostPerMSheets")?.Value ?? "0.00"),
                        PaperWeight = string.IsNullOrWhiteSpace(e.Element("PaperWeight")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("PaperWeight")?.Value ?? "0.00"),
                        PaperMarkup = string.IsNullOrWhiteSpace(e.Element("PaperMarkup")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("PaperMarkup")?.Value ?? "0.00"),
                        WeightPerSqFt = string.IsNullOrWhiteSpace(e.Element("WeightPerSqFt")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("WeightPerSqFt")?.Value ?? "0.00"),
                        ParentRollLength = string.IsNullOrWhiteSpace(e.Element("ParentRollLength")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("ParentRollLength")?.Value ?? "0.00"),
                        ParentRollWidth = string.IsNullOrWhiteSpace(e.Element("ParentRollWidth")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("ParentRollWidth")?.Value ?? "0.00"),
                        RollWeight = string.IsNullOrWhiteSpace(e.Element("RollWeight")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("RollWeight")?.Value ?? "0.00"),
                        CostPerPound = string.IsNullOrWhiteSpace(e.Element("CostPerPound")?.Value) ? 0.00M
                            : Convert.ToDecimal(e.Element("CostPerPound")?.Value ?? "0.00"),
                        ItemQuantity = string.IsNullOrWhiteSpace(e.Element("ItemQuantity")?.Value) ? 0
                            : Convert.ToInt32(e.Element("ItemQuantity")?.Value ?? "0"),
                        OnHandQuantity = string.IsNullOrWhiteSpace(e.Element("OnHandQuantity")?.Value) ? 0
                            : Convert.ToInt32(e.Element("OnHandQuantity")?.Value ?? "0"),
                        ReservedQuantity = string.IsNullOrWhiteSpace(e.Element("ReservedQuantity")?.Value) ? 0
                            : Convert.ToInt32(e.Element("ReservedQuantity")?.Value ?? "0"),
                        ItemComment = e.Element("ItemComment")?.Value ?? "",
                        CreateDateTime = e.Element("CreateDateTime")?.Value ?? ""
                    });
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for inventory data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return inventoryItemInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract inventory lot data and returns a list of <see cref="Lots"/>
        /// objects.
        /// </summary>
        /// <param name="xmlinput">A string containing the XML data representing inventory lots. The XML must conform to the expected structure
        /// with "ItemLots" and "ItemLot" elements.</param>
        /// <returns>A list of <see cref="Lots"/> objects populated with data extracted from the XML input. The list will be
        /// empty if no valid "ItemLot" elements are found.</returns>
        public static List<Lots> GetInventoryLotData(string xmlinput)
        {
            var inventoryLotInfo = new List<Lots>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for inventory lot data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var LotData = xelement.Elements("ItemLots")
                                    .SelectMany(x => x.Elements("ItemLot"))
                                    .ToList();

                foreach (var e in LotData)
                {
                    inventoryLotInfo.Add(new Lots
                    {
                        ItemLotID = Convert.ToInt32(e.Element("ItemLotID")?.Value ?? "0"),
                        ItemLotNumber = e.Element("ItemLotNumber")?.Value ?? "",
                        ItemID = Convert.ToInt32(e.Element("ItemID")?.Value ?? "0"),
                        VendorID = string.IsNullOrWhiteSpace(e.Element("VendorID")?.Value) ? 0
                            : Convert.ToInt32(e.Element("VendorID")?.Value ?? "0"),
                        VendorName = e.Element("VendorName")?.Value ?? "",
                        InvoiceNumber = e.Element("InvoiceNumber")?.Value ?? "",
                        EnterDate = e.Element("EnterDate")?.Value ?? "",
                        ItemCost = string.IsNullOrWhiteSpace(e.Element("ItemCost")?.Value) ? decimal.Zero
                            : Convert.ToDecimal(e.Element("ItemCost")?.Value ?? "0.00"),
                        ExpirationDate = e.Element("ExpirationDate")?.Value ?? "",
                        Active = string.IsNullOrWhiteSpace(e.Element("Active")?.Value) ? true
                            : Convert.ToBoolean(e.Element("Active")?.Value ?? "true"),
                        Weight = string.IsNullOrWhiteSpace(e.Element("Weight")?.Value) ? decimal.Zero
                            : Convert.ToDecimal(e.Element("Weight")?.Value ?? "0.00"),
                        TareWeight = string.IsNullOrWhiteSpace(e.Element("TareWeight")?.Value) ? decimal.Zero
                            : Convert.ToDecimal(e.Element("TareWeight")?.Value ?? "0.00"),
                        Quantity = string.IsNullOrWhiteSpace(e.Element("Quantity")?.Value) ? 0
                            : Convert.ToInt32(e.Element("Quantity")?.Value ?? "0")
                    });
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for inventory lot data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return inventoryLotInfo;
        }

        /// <summary>
        /// Parses the provided XML input to extract inventory location data.
        /// </summary>
        /// <remarks>The method processes XML data structured with "InventoryItemLocations" as the root
        /// element and "InventoryItemLocation" as child elements. Each "InventoryItemLocation" element is expected to
        /// contain details such as ItemID, ItemCode, ItemLotID, and other related fields.</remarks>
        /// <param name="xmlinput">A string containing XML data that describes inventory item locations.</param>
        /// <returns>A list of <see cref="Locations"/> objects, each representing an inventory item location extracted from the
        /// XML input.</returns>
        public static List<Locations> GetInventoryLocationData(string xmlinput)
        {
            var inventoryLocationInfo = new List<Locations>();

            if (string.IsNullOrWhiteSpace(xmlinput))
            {
                Log.Error("XML input for inventory location data is null or empty.");
                throw new ArgumentException("XML input cannot be null or empty.", nameof(xmlinput));
            }

            try
            {
                XElement xelement = XElement.Parse(xmlinput);

                var LocationData = xelement.Elements("InventoryItemLocations")
                                    .SelectMany(x => x.Elements("InventoryItemLocation"))
                                    .ToList();

                foreach (var e in LocationData)
                {
                    inventoryLocationInfo.Add(new Locations
                    {
                        ItemID = Convert.ToInt32(e.Element("ItemID")?.Value ?? "0"),
                        ItemCode = e.Element("ItemCode")?.Value ?? "",
                        ItemLotID = string.IsNullOrWhiteSpace(e.Element("ItemLotID")?.Value) ? 0
                            : Convert.ToInt32(e.Element("ItemLotID")?.Value ?? "0"),
                        ItemLotNumber = e.Element("ItemLotNumber")?.Value ?? "",
                        WarehouseID = string.IsNullOrWhiteSpace(e.Element("WarehouseID")?.Value) ? 0
                            : Convert.ToInt32(e.Element("WarehouseID")?.Value ?? "0"),
                        WarehouseName = e.Element("WarehouseName")?.Value ?? "",
                        WarehouseLocationID = string.IsNullOrWhiteSpace(e.Element("WarehouseLocationID")?.Value) ? 0
                            : Convert.ToInt32(e.Element("WarehouseLocationID")?.Value ?? "0"),
                        WarehouseLocationDescription = e.Element("WarehouseLocationDescription")?.Value ?? "",
                        Quantity = string.IsNullOrWhiteSpace(e.Element("Quantity")?.Value) ? 0
                            : Convert.ToInt32(e.Element("Quantity")?.Value ?? "0")
                    });
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Error parsing XML input for inventory location data.");
                throw new InvalidOperationException("Failed to parse XML input.", ex);
            }

            return inventoryLocationInfo;
        }
    }
}

