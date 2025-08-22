using Midnight.SOAP.SDK.RequestObjects.OrderVersionDropInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class OrderVersionDropServiceTests
    {
        [Fact]
        public async Task OrderVersionDropListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropListResponse
            {
                OrderVersionDropListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropListAsync(It.IsAny<OrderVersionDropListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropListRequestBody
            {
                InputParameter = new OrderVersionDropListInputParameter { VersionID = 1 }
            };

            var result = await service.OrderVersionDropListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDropListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropListResponse
            {
                OrderVersionDropListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropListAsync(It.IsAny<OrderVersionDropListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropListRequestBody
            {
                InputParameter = new OrderVersionDropListInputParameter { VersionID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDropListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDropInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropInsertResponse
            {
                OrderVersionDropInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropInsertAsync(It.IsAny<OrderVersionDropInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropInsertRequestBody
            {
                InputParameter = new OrderVersionDropInsertInputParameter()
            };

            var result = await service.OrderVersionDropInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDropInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropInsertResponse
            {
                OrderVersionDropInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropInsertAsync(It.IsAny<OrderVersionDropInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropInsertRequestBody
            {
                InputParameter = new OrderVersionDropInsertInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDropInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDropUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropUpdateResponse
            {
                OrderVersionDropUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropUpdateAsync(It.IsAny<OrderVersionDropUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropUpdateRequestBody
            {
                InputParameter = new OrderVersionDropUpdateInputParameter { OrderVersionDropID = 1 }
            };

            var result = await service.OrderVersionDropUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDropUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropUpdateResponse
            {
                OrderVersionDropUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropUpdateAsync(It.IsAny<OrderVersionDropUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropUpdateRequestBody
            {
                InputParameter = new OrderVersionDropUpdateInputParameter { OrderVersionDropID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDropUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDropDeleteAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropDeleteResponse
            {
                OrderVersionDropDeleteResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropDeleteAsync(It.IsAny<OrderVersionDropDeleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropDeleteRequestBody
            {
                InputParameter = new OrderVersionDropDeleteinputParameter { OrderVersionDropID = 1 }
            };

            var result = await service.OrderVersionDropDeleteAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDropDeleteAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDropDeleteResponse
            {
                OrderVersionDropDeleteResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDropDeleteAsync(It.IsAny<OrderVersionDropDeleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDropService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDropDeleteRequestBody
            {
                InputParameter = new OrderVersionDropDeleteinputParameter{ OrderVersionDropID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDropDeleteAsync(auth, request);
            });
        }
    }
}
