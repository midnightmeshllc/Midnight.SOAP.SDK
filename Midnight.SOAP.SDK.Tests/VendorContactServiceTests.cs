using Midnight.SOAP.SDK.RequestObjects.VendorContactInputs;
using Midnight.SOAP.SDK.ResponseObjects.VendorContactOutputs;
using MidnightAPI;
using Moq;
using Xunit;
using System.Collections.Generic;

namespace Midnight.SOAP.SDK.Tests
{
    public class VendorContactServiceTests
    {
        [Fact]
        public async Task VendorContactInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorContactInsertResponse
            {
                VendorContactInsertResult = "<Result><ReturnCode>0</ReturnCode><VendorContacts></VendorContacts></Result>"
            };
            mockSoap.Setup(s => s.VendorContactInsertAsync(It.IsAny<VendorContactInsertRequest>())).ReturnsAsync(response);

            var service = new VendorContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorContactInsertRequestBody
            {
                InputParameter = new VendorContactInsertInputParameter
                {
                    VendorContacts = new List<VendorContactInsert> 
                    {
                        new VendorContactInsert { VendorID = 1, FirstName = "John", LastName = "Doe", Active = true }
                    }
                }
            };

            var result = await service.VendorContactInsertAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task VendorContactInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorContactInsertResponse
            {
                VendorContactInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.VendorContactInsertAsync(It.IsAny<VendorContactInsertRequest>())).ReturnsAsync(response);

            var service = new VendorContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorContactInsertRequestBody
            {
                InputParameter = new VendorContactInsertInputParameter
                {
                    VendorContacts = new List<VendorContactInsert> 
                    {
                        new VendorContactInsert { VendorID = 1, FirstName = "John", LastName = "Doe", Active = true }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.VendorContactInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task VendorContactUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorContactUpdateResponse
            {
                VendorContactUpdateResult = "<Result><ReturnCode>0</ReturnCode><VendorContacts></VendorContacts></Result>"
            };
            mockSoap.Setup(s => s.VendorContactUpdateAsync(It.IsAny<VendorContactUpdateRequest>())).ReturnsAsync(response);

            var service = new VendorContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorContactUpdateRequestBody
            {
                VendorContact = new VendorContactUpdateInputParameter { ContactID = 1, VendorID = 1 }
            };

            var result = await service.VendorContactUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task VendorContactUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorContactUpdateResponse
            {
                VendorContactUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.VendorContactUpdateAsync(It.IsAny<VendorContactUpdateRequest>())).ReturnsAsync(response);

            var service = new VendorContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorContactUpdateRequestBody
            {
                VendorContact = new VendorContactUpdateInputParameter { ContactID = 1, VendorID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.VendorContactUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task VendorContactListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorContactListResponse
            {
                VendorContactListResult = "<Result><ReturnCode>0</ReturnCode><VendorContacts></VendorContacts></Result>"
            };
            mockSoap.Setup(s => s.VendorContactListAsync(It.IsAny<VendorContactListRequest>())).ReturnsAsync(response);

            var service = new VendorContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorContactListRequestBody
            {
                InputParameter = new VendorContactListInputParameter()
            };

            var result = await service.VendorContactListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task VendorContactListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new VendorContactListResponse
            {
                VendorContactListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.VendorContactListAsync(It.IsAny<VendorContactListRequest>())).ReturnsAsync(response);

            var service = new VendorContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new VendorContactListRequestBody
            {
                InputParameter = new VendorContactListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.VendorContactListAsync(auth, request);
            });
        }
    }
}
