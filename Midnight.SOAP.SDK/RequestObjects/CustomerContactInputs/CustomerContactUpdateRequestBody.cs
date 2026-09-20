using Midnight.SOAP.SDK.CommonObjects;
using System.Xml.Serialization;

namespace Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;

/// <summary>
/// Represents the request body for updating a customer contact in the Midnight SOAP API.
/// </summary>
[XmlRoot("CustomerContactUpdate")]
public class CustomerContactUpdateRequestBody
{
    /// <summary>
    /// Gets or sets the input parameter for the customer contact update request.
    /// </summary>
    public required CustomerContactUpdateInputParameter InputParameter { get; set; }
}

/// <summary>
/// Represents the input parameter for updating customer contacts in the Midnight SOAP API.
/// </summary>
public class CustomerContactUpdateInputParameter
{
    /// <summary>
    /// Gets or sets the list of customer contacts to update.
    /// </summary>
    [XmlArray("CustomerContacts")]
    [XmlArrayItem("CustomerContact")]
    public required List<CustomerContactUpdate> CustomerContacts { get; set; }
}

/// <summary>
/// Represents a customer contact to update in the Midnight SOAP API. Set any values you do not wish to update to null.
/// </summary>
public class CustomerContactUpdate : UserDefinedFields
{
    /// <summary>Gets or sets the contact ID.</summary>
    public required int ContactID { get; set; }

    /// <summary>Gets or sets the salutation.</summary>
    public string? Salutation { get; set; }
    public bool ShouldSerializeSalutation() => IsSet(Salutation);

    /// <summary>Gets or sets the first name.</summary>
    public string? FirstName { get; set; }
    public bool ShouldSerializeFirstName() => IsSet(FirstName);

    /// <summary>Gets or sets the middle name.</summary>
    public string? MiddleName { get; set; }
    public bool ShouldSerializeMiddleName() => IsSet(MiddleName);

    /// <summary>Gets or sets the last name.</summary>
    public string? LastName { get; set; }
    public bool ShouldSerializeLastName() => IsSet(LastName);

    /// <summary>Gets or sets the suffix.</summary>
    public string? Suffix { get; set; }
    public bool ShouldSerializeSuffix() => IsSet(Suffix);

    /// <summary>Gets or sets the title.</summary>
    public string? Title { get; set; }
    public bool ShouldSerializeTitle() => IsSet(Title);

    /// <summary>Gets or sets the company.</summary>
    public string? Company { get; set; }
    public bool ShouldSerializeCompany() => IsSet(Company);

    /// <summary>Gets or sets a value indicating whether the contact is active.</summary>
    public bool? Active { get; set; }
    public bool ShouldSerializeActive() => Active.HasValue;

    /// <summary>Gets or sets the contact type ID.</summary>
    public int? ContactTypeID { get; set; }
    public bool ShouldSerializeContactTypeID() => ContactTypeID.HasValue;

    /// <summary>Gets or sets the comment.</summary>
    public string? Comment { get; set; }
    public bool ShouldSerializeComment() => IsSet(Comment);

    /// <summary>Gets or sets address line 1.</summary>
    public string? Address1 { get; set; }
    public bool ShouldSerializeAddress1() => IsSet(Address1);

    /// <summary>Gets or sets address line 2.</summary>
    public string? Address2 { get; set; }
    public bool ShouldSerializeAddress2() => IsSet(Address2);

    /// <summary>Gets or sets address line 3.</summary>
    public string? Address3 { get; set; }
    public bool ShouldSerializeAddress3() => IsSet(Address3);

    /// <summary>Gets or sets the country code.</summary>
    public string? CountryCode { get; set; }
    public bool ShouldSerializeCountryCode() => IsSet(CountryCode);

    /// <summary>Gets or sets the zip code.</summary>
    public string? ZipCode { get; set; }
    public bool ShouldSerializeZipCode() => IsSet(ZipCode);

    /// <summary>Gets or sets the state code.</summary>
    public string? StateCode { get; set; }
    public bool ShouldSerializeStateCode() => IsSet(StateCode);

    /// <summary>Gets or sets the business phone.</summary>
    public int? BusinessPhone { get; set; }
    public bool ShouldSerializeBusinessPhone() => BusinessPhone.HasValue;

    /// <summary>Gets or sets the business phone extension.</summary>
    public string? BusinessPhoneExtension { get; set; }
    public bool ShouldSerializeBusinessPhoneExtension() => IsSet(BusinessPhoneExtension);

    /// <summary>Gets or sets the other phone.</summary>
    public int? OtherPhone { get; set; }
    public bool ShouldSerializeOtherPhone() => OtherPhone.HasValue;

    /// <summary>Gets or sets the other phone extension.</summary>
    public string? OtherPhoneExtension { get; set; }
    public bool ShouldSerializeOtherPhoneExtension() => IsSet(OtherPhoneExtension);

    /// <summary>Gets or sets the fax number.</summary>
    public int? Fax { get; set; }
    public bool ShouldSerializeFax() => Fax.HasValue;

    /// <summary>Gets or sets the fax extension.</summary>
    public string? FaxExtension { get; set; }
    public bool ShouldSerializeFaxExtension() => IsSet(FaxExtension);

    /// <summary>Gets or sets the business email.</summary>
    public string? BusinessEmail { get; set; }
    public bool ShouldSerializeBusinessEmail() => IsSet(BusinessEmail);

    /// <summary>Gets or sets the other email.</summary>
    public string? OtherEmail { get; set; }
    public bool ShouldSerializeOtherEmail() => IsSet(OtherEmail);

    /// <summary>Shared helper for determining whether a nullable string field has a meaningful value to serialize.</summary>
    private static bool IsSet(string? value) => !string.IsNullOrEmpty(value);
}
