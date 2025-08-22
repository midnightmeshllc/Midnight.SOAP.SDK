using MidnightAPI;
using Midnight.SOAP.SDK.RequestObjects.CustomerContactInputs;
using Midnight.SOAP.SDK.ResponseObjects.CustomerContactOutputs;
using Moq;
using Xunit;

namespace Midnight.SOAP.SDK.Tests
{
    public class CustomerContactServiceTests
    {
        [Fact]
        public async Task CustomerContactInsertAsync_ReturnsResult_WhenSuccess()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            var expectedResult = new CustomerContactInsertResult { ReturnCode = 0 };
            var response = new CustomerContactInsertResponse
            {
                CustomerContactInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };

            mockSoap
                .Setup(s => s.CustomerContactInsertAsync(It.IsAny<CustomerContactInsertRequest>()))
                .ReturnsAsync(response);

            // Mock XmlParsing to return expectedResult
            // If XmlParsing is static, use a wrapper or abstraction for testability.
            // For this example, assume XmlParsing.DeserializeXmlToObject returns expectedResult.

            var service = new CustomerContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerContactListRequestBody
            {
                InputParameter = new CustomerContactListInputParameter()
            };

            // Act
            var result = await service.CustomerContactInsertAsync(auth, request);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerContactInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            var errorResult = new CustomerContactInsertResult { ReturnCode = 1, ReturnErrors = new() { new() { Error = "Some error" } } };
            var response = new CustomerContactInsertResponse
            {
                CustomerContactInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };

            mockSoap
                .Setup(s => s.CustomerContactInsertAsync(It.IsAny<CustomerContactInsertRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerContactListRequestBody
            {
                InputParameter = new CustomerContactListInputParameter()
            };

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerContactInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task CustomerContactListAsync_ReturnsResult_WhenSuccess()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            var expectedResult = new CustomerContactListResult { ReturnCode = 0 };
            var response = new CustomerContactListResponse
            {
                CustomerContactListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };

            mockSoap
                .Setup(s => s.CustomerContactListAsync(It.IsAny<CustomerContactListRequest>()))
                .ReturnsAsync(response);

            // Assume XmlParsing.DeserializeXmlToObject returns expectedResult.
            var service = new CustomerContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerContactListRequestBody
            {
                InputParameter = new CustomerContactListInputParameter()
            };

            // Act
            var result = await service.CustomerContactListAsync(auth, request);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerContactListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            var errorResult = new CustomerContactListResult { ReturnCode = 1, ReturnErrors = new() { new() { Error = "Some error" } } };
            var response = new CustomerContactListResponse
            {
                CustomerContactListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };

            mockSoap
                .Setup(s => s.CustomerContactListAsync(It.IsAny<CustomerContactListRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerContactListRequestBody
            {
                InputParameter = new CustomerContactListInputParameter()
            };

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerContactListAsync(auth, request);
            });
        }

        [Fact]
        public async Task CustomerContactUpdateAsync_ReturnsResult_WhenSuccess()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            var expectedResult = new CustomerContactUpdateResult { ReturnCode = 0 };
            var response = new CustomerContactUpdateResponse
            {
                CustomerContactUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };

            mockSoap
                .Setup(s => s.CustomerContactUpdateAsync(It.IsAny<CustomerContactUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerContactUpdateRequestBody
            {
                InputParameter = new CustomerContactUpdateInputParameter { 
                    CustomerContacts = new() { new CustomerContactUpdate { ContactID = 1 } } }
            };

            // Act
            var result = await service.CustomerContactUpdateAsync(auth, request);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerContactUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            var errorResult = new CustomerContactUpdateResult { ReturnCode = 1, ReturnErrors = new() { new() { Error = "Some error" } } };
            var response = new CustomerContactUpdateResponse
            {
                CustomerContactUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };

            mockSoap
                .Setup(s => s.CustomerContactUpdateAsync(It.IsAny<CustomerContactUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerContactService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerContactUpdateRequestBody
            {
                InputParameter = new CustomerContactUpdateInputParameter { 
                CustomerContacts = new() { new CustomerContactUpdate { ContactID = 0 } }
            }
            };

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerContactUpdateAsync(auth, request);
            });
        }
    }
}