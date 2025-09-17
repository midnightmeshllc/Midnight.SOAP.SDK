using Midnight.SOAP.SDK.RequestObjects.OrderVersionInventoryInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class OrderVersionInventoryServiceTests
    {
        [Fact]
        public async Task OrderVersionInventoryListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionInventoryListResponse
            {
                OrderVersionInventoryListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionInventoryListAsync(It.IsAny<OrderVersionInventoryListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionInventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionInventoryListRequestBody
            {
                InputParameter = new OrderVersionInventoryListInputParameter()
            };

            var result = await service.OrderVersionInventoryListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionInventoryListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionInventoryListResponse
            {
                OrderVersionInventoryListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionInventoryListAsync(It.IsAny<OrderVersionInventoryListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionInventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionInventoryListRequestBody
            {
                InputParameter = new OrderVersionInventoryListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionInventoryListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionInventoryUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionInventoryUpdateResponse
            {
                OrderVersionInventoryUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionInventoryUpdateAsync(It.IsAny<OrderVersionInventoryUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionInventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionInventoryUpdateRequestBody
            {
                InputParameter = new OrderVersionInventoryUpdateInputParameter { OrderInventoryID = 12345 }
            };

            var result = await service.OrderVersionInventoryUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionInventoryUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionInventoryUpdateResponse
            {
                OrderVersionInventoryUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionInventoryUpdateAsync(It.IsAny<OrderVersionInventoryUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionInventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionInventoryUpdateRequestBody
            {
                InputParameter = new OrderVersionInventoryUpdateInputParameter { OrderInventoryID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionInventoryUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionInventoryInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionInventoryInsertResponse
            {
                OrderVersionInventoryInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionInventoryInsertAsync(It.IsAny<OrderVersionInventoryInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionInventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionInventoryInsertRequestBody
            {
                InputParameter = new OrderVersionInventoryInsertInputParameter { ItemID = 1, VersionID = 1 }
            };

            var result = await service.OrderVersionInventoryInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionInventoryInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionInventoryInsertResponse
            {
                OrderVersionInventoryInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionInventoryInsertAsync(It.IsAny<OrderVersionInventoryInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionInventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionInventoryInsertRequestBody
            {
                InputParameter = new OrderVersionInventoryInsertInputParameter { ItemID= 1, VersionID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionInventoryInsertAsync(auth, request);
            });
        }
    }
}
