using Midnight.SOAP.SDK.RequestObjects.VendorInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class VendorServiceTests
    {
        [Fact]
        public async Task VendorInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorInsertResponse
            {
                VendorInsertResult = "<Result><ReturnCode>0</ReturnCode><VendorID>123</VendorID></Result>"
            };
            mockSoap.Setup(s => s.VendorInsertAsync(It.IsAny<VendorInsertRequest>())).ReturnsAsync(response);

            var service = new VendorService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorInsertRequestBody { VendorName = "Test Vendor", TermsCode = "NET30", Code = "T123" };

            var result = await service.VendorInsertAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(123, result.VendorID);
        }

        [Fact]
        public async Task VendorUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorUpdateResponse
            {
                VendorUpdateResult = "<Result><ReturnCode>0</ReturnCode><VendorID>456</VendorID></Result>"
            };
            mockSoap.Setup(s => s.VendorUpdateAsync(It.IsAny<VendorUpdateRequest>())).ReturnsAsync(response);

            var service = new VendorService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorUpdateRequestBody { VendorId = 456, VendorName = "Updated Vendor", Terms = "Net 30 Days" };

            var result = await service.VendorUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(456, result.VendorID);
        }

        [Fact]
        public async Task VendorListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorListResponse
            {
                VendorListResult = "<Result><ReturnCode>0</ReturnCode><Vendors></Vendors></Result>"
            };
            mockSoap.Setup(s => s.VendorListAsync(It.IsAny<VendorListRequest>())).ReturnsAsync(response);

            var service = new VendorService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorListRequestBody
            {
                InputParameter = new VendorListInputParameter()
            };

            var result = await service.VendorListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

    }
}
