using Midnight.SOAP.SDK.RequestObjects.OrderVersionInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class OrderVersionServiceTests
    {
        [Fact]
        public async Task OrderVersionListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionListResponse
            {
                OrderVersionListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionListAsync(It.IsAny<OrderVersionListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionListRequestBody
            {
                InputParameter = new OrderVersionListInputParameter()
            };

            var result = await service.OrderVersionListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionListResponse
            {
                OrderVersionListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionListAsync(It.IsAny<OrderVersionListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionListRequestBody
            {
                InputParameter = new OrderVersionListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionQuickAddAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionQuickAddResponse
            {
                OrderVersionQuickAddResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionQuickAddAsync(It.IsAny<OrderVersionQuickAddRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionQuickAddRequestBody
            {
                OrderVersion = new OrderVersionQuickAddInputParameter { OrderNumber = "12345" }
            };

            var result = await service.OrderVersionQuickAddAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionQuickAddAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionQuickAddResponse
            {
                OrderVersionQuickAddResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionQuickAddAsync(It.IsAny<OrderVersionQuickAddRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionQuickAddRequestBody
            {
                OrderVersion = new OrderVersionQuickAddInputParameter { OrderNumber = "12345" }
            };

            await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await service.OrderVersionQuickAddAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionUpdateResponse
            {
                OrderVersionUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionUpdateAsync(It.IsAny<OrderVersionUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionUpdateRequestBody
            {
                InputParameter = new OrderVersionUpdateInputParameter { VersionID = 12345 }
            };

            var result = await service.OrderVersionUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionUpdateResponse
            {
                OrderVersionUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionUpdateAsync(It.IsAny<OrderVersionUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionUpdateRequestBody
            {
                InputParameter = new OrderVersionUpdateInputParameter { VersionID = 12345 }
            };

            await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await service.OrderVersionUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDeleteAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDeleteResponse
            {
                OrderVersionDeleteResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDeleteAsync(It.IsAny<OrderVersionDeleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDeleteRequestBody
            {
                InputParameter = new OrderVersionDeleteInputParameter { VersionID = 12345 }
            };

            var result = await service.OrderVersionDeleteAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDeleteAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDeleteResponse
            {
                OrderVersionDeleteResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDeleteAsync(It.IsAny<OrderVersionDeleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDeleteRequestBody
            {
                InputParameter = new OrderVersionDeleteInputParameter { VersionID = 12345 }
            };

            await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await service.OrderVersionDeleteAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionNewResponse
            {
                OrderVersionNewResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionNewAsync(It.IsAny<OrderVersionNewRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionNewRequestBody
            {
                InputParameter = new OrderVersionNewInputParameter()
            };

            var result = await service.OrderVersionNewAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionNewResponse
            {
                OrderVersionNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionNewAsync(It.IsAny<OrderVersionNewRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionNewRequestBody
            {
                InputParameter = new OrderVersionNewInputParameter()
            };

            await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await service.OrderVersionNewAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionCompleteAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionCompleteResponse
            {
                OrderVersionCompleteResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionCompleteAsync(It.IsAny<OrderVersionCompleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionCompleteRequestBody
            {
                InputParameter = new OrderVersionCompleteInputParameter { Complete = true, VersionID = 12345 }
            };

            var result = await service.OrderVersionCompleteAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionCompleteAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionCompleteResponse
            {
                OrderVersionCompleteResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionCompleteAsync(It.IsAny<OrderVersionCompleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionCompleteRequestBody
            {
                InputParameter = new OrderVersionCompleteInputParameter { Complete = true, VersionID = 12345 }
            };

            await Assert.ThrowsAsync<InvalidOperationException>(async () =>
            {
                await service.OrderVersionCompleteAsync(auth, request);
            });
        }
    }
}
