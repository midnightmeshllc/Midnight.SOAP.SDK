using Midnight.SOAP.SDK.RequestObjects.OrderVersionDetailInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class OrderVersionDetailServiceTests
    {
        [Fact]
        public async Task OrderVersionDetailListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailListResponse
            {
                OrderVersionDetailListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailListAsync(It.IsAny<OrderVersionDetailListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailListRequestBody
            {
                InputParameter = new OrderVersionDetailListInputParameter { VersionID = 12345 }
            };

            var result = await service.OrderVersionDetailListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDetailListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailListResponse
            {
                OrderVersionDetailListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailListAsync(It.IsAny<OrderVersionDetailListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailListRequestBody
            {
                InputParameter = new OrderVersionDetailListInputParameter { VersionID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDetailListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDetailInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailInsertResponse
            {
                OrderVersionDetailInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailInsertAsync(It.IsAny<OrderVersionDetailInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailInsertRequestBody
            {
                InputParameter = new OrderVersionDetailInsertInputParameter()
            };

            var result = await service.OrderVersionDetailInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDetailInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailInsertResponse
            {
                OrderVersionDetailInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailInsertAsync(It.IsAny<OrderVersionDetailInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailInsertRequestBody
            {
                InputParameter = new OrderVersionDetailInsertInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDetailInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDetailUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailUpdateResponse
            {
                OrderVersionDetailUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailUpdateAsync(It.IsAny<OrderVersionDetailUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailUpdateRequestBody
            {
                InputParameter = new OrderVersionDetailUpdateInputParameter { OrderVersionDetailID = 12345 }
            };

            var result = await service.OrderVersionDetailUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDetailUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailUpdateResponse
            {
                OrderVersionDetailUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailUpdateAsync(It.IsAny<OrderVersionDetailUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailUpdateRequestBody
            {
                InputParameter = new OrderVersionDetailUpdateInputParameter { OrderVersionDetailID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDetailUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDetailEstimatedTimeAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailEstimatedTimeResponse
            {
                OrderVersionDetailEstimatedTimeResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailEstimatedTimeAsync(It.IsAny<OrderVersionDetailEstimatedTimeRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailEstimatedTimeRequestBody
            {
                InputParameter = new OrderVersionDetailEstimatedTimeInputParameter()
            };

            var result = await service.OrderVersionDetailEstimatedTimeAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDetailEstimatedTimeAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailEstimatedTimeResponse
            {
                OrderVersionDetailEstimatedTimeResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailEstimatedTimeAsync(It.IsAny<OrderVersionDetailEstimatedTimeRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailEstimatedTimeRequestBody
            {
                InputParameter = new OrderVersionDetailEstimatedTimeInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDetailEstimatedTimeAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionDetailDeleteAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailDeleteResponse
            {
                OrderVersionDetailDeleteResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailDeleteAsync(It.IsAny<OrderVersionDetailDeleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailDeleteRequestBody
            {
                InputParameter = new OrderVersionDetailDeleteInputParameter { OrderVersionDetailID = 12345 }
            };

            var result = await service.OrderVersionDetailDeleteAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionDetailDeleteAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionDetailDeleteResponse
            {
                OrderVersionDetailDeleteResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionDetailDeleteAsync(It.IsAny<OrderVersionDetailDeleteRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionDetailService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionDetailDeleteRequestBody
            {
                InputParameter = new OrderVersionDetailDeleteInputParameter { OrderVersionDetailID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionDetailDeleteAsync(auth, request);
            });
        }
    }
}