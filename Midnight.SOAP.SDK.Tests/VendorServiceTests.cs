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
            var request = new VendorInsertRequestBody { VendorName = "Test Vendor" };

            var result = await service.VendorInsertAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(123, result.VendorID);
        }

        [Fact]
        public async Task VendorInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorInsertResponse
            {
                VendorInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.VendorInsertAsync(It.IsAny<VendorInsertRequest>())).ReturnsAsync(response);

            var service = new VendorService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorInsertRequestBody { VendorName = "Test Vendor" };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.VendorInsertAsync(auth, request);
            });
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
            var request = new VendorUpdateRequestBody { VendorID = 456, VendorName = "Updated Vendor" };

            var result = await service.VendorUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(456, result.VendorID);
        }

        [Fact]
        public async Task VendorUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorUpdateResponse
            {
                VendorUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.VendorUpdateAsync(It.IsAny<VendorUpdateRequest>())).ReturnsAsync(response);

            var service = new VendorService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorUpdateRequestBody { VendorID = 456, VendorName = "Updated Vendor" };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.VendorUpdateAsync(auth, request);
            });
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

        [Fact]
        public async Task VendorListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorListResponse
            {
                VendorListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.VendorListAsync(It.IsAny<VendorListRequest>())).ReturnsAsync(response);

            var service = new VendorService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorListRequestBody
            {
                InputParameter = new VendorListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.VendorListAsync(auth, request);
            });
        }
    }
}
