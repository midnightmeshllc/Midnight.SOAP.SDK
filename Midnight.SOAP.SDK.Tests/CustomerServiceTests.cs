using MidnightAPI;
using Midnight.SOAP.SDK;
using Midnight.SOAP.SDK.RequestObjects.CustomerInputs;
using Midnight.SOAP.SDK.ResponseObjects.CustomerOutputs;
using Moq;
using Xunit;

namespace Midnight.SOAP.SDK.Tests
{
    public class CustomerServiceTests
    {
        [Fact]
        public async Task CustomerPostageAccountListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerPostageAccountListResponse
            {
                CustomerPostageAccountListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerPostageAccountListAsync(It.IsAny<CustomerPostageAccountListRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerPostageAccountListRequestBody
            {
                InputParameter = new CustomerPostageAccountListInputParameter { CustomerID = 12345 }
            };

            var result = await service.CustomerPostageAccountListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerPostageAccountListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerPostageAccountListResponse
            {
                CustomerPostageAccountListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerPostageAccountListAsync(It.IsAny<CustomerPostageAccountListRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerPostageAccountListRequestBody
            {
                InputParameter = new CustomerPostageAccountListInputParameter { CustomerID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerPostageAccountListAsync(auth, request);
            });
        }

        [Fact]
        public async Task CustomerListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerListResponse
            {
                CustomerListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerListAsync(It.IsAny<CustomerListRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerListRequestBody
            {
                InputParameter = new CustomerListInputParameter()
            };

            var result = await service.CustomerListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerListResponse
            {
                CustomerListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerListAsync(It.IsAny<CustomerListRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerListRequestBody
            {
                InputParameter = new CustomerListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerListAsync(auth, request);
            });
        }

        [Fact]
        public async Task CustomerUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerUpdateResponse
            {
                CustomerUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerUpdateAsync(It.IsAny<CustomerUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerUpdateRequestBody
            {
                InputParameter = new CustomerUpdateInputParameter { CustomerCode = "CUST123" }
            };

            var result = await service.CustomerUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerUpdateResponse
            {
                CustomerUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerUpdateAsync(It.IsAny<CustomerUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerUpdateRequestBody
            {
                InputParameter = new CustomerUpdateInputParameter { CustomerCode = "CUST123" }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task CustomerInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerInsertResponse
            {
                CustomerInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerInsertAsync(It.IsAny<CustomerInsertRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerInsertRequestBody
            {
                InputParameter = new CustomerInsertInputParameter { CustomerCode = "ABCD" }
            };

            var result = await service.CustomerInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CustomerInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerInsertResponse
            {
                CustomerInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.CustomerInsertAsync(It.IsAny<CustomerInsertRequest>()))
                .ReturnsAsync(response);

            var service = new CustomerService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerInsertRequestBody
            {
                InputParameter = new CustomerInsertInputParameter { CustomerCode = "ABCD" }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CustomerInsertAsync(auth, request);
            });
        }
    }
}