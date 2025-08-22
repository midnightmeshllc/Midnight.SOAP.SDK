using Midnight.SOAP.SDK.RequestObjects.OrderVersionPostageInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class OrderVersionPostageServiceTests
    {
        [Fact]
        public async Task OrderVersionPostageInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageInsertResponse
            {
                OrderVersionPostageInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageInsertAsync(It.IsAny<OrderVersionPostageInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageInsertRequestBody
            {
                InputParameter = new OrderVersionPostageInsertInputParameter()
            };

            var result = await service.OrderVersionPostageInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionPostageInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageInsertResponse
            {
                OrderVersionPostageInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageInsertAsync(It.IsAny<OrderVersionPostageInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageInsertRequestBody
            {
                InputParameter = new OrderVersionPostageInsertInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionPostageInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionPostageUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageUpdateResponse
            {
                OrderVersionPostageUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageUpdateAsync(It.IsAny<OrderVersionPostageUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageUpdateRequestBody
            {
                InputParameter = new OrderVersionPostageUpdateInputParameter { OrderVersionPostageID = 12345 }
            };

            var result = await service.OrderVersionPostageUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionPostageUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageUpdateResponse
            {
                OrderVersionPostageUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageUpdateAsync(It.IsAny<OrderVersionPostageUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageUpdateRequestBody
            {
                InputParameter = new OrderVersionPostageUpdateInputParameter { OrderVersionPostageID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionPostageUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionPostageListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageListResponse
            {
                OrderVersionPostageListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageListAsync(It.IsAny<OrderVersionPostageListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageListRequestBody
            {
                InputParameter = new OrderVersionPostageListInputParameter { VersionID = 12345 }
            };

            var result = await service.OrderVersionPostageListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionPostageListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageListResponse
            {
                OrderVersionPostageListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageListAsync(It.IsAny<OrderVersionPostageListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageListRequestBody
            {
                InputParameter = new OrderVersionPostageListInputParameter { VersionID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionPostageListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionPostageDetailInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageDetailInsertResponse
            {
                OrderVersionPostageDetailInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageDetailInsertAsync(It.IsAny<OrderVersionPostageDetailInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageDetailInsertRequestBody
            {
                InputParameter = new OrderVersionPostageDetailInputParameter()
            };

            var result = await service.OrderVersionPostageDetailInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionPostageDetailInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageDetailInsertResponse
            {
                OrderVersionPostageDetailInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageDetailInsertAsync(It.IsAny<OrderVersionPostageDetailInsertRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageDetailInsertRequestBody
            {
                InputParameter = new OrderVersionPostageDetailInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionPostageDetailInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionPostageDetailListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageDetailListResponse
            {
                OrderVersionPostageDetailListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageDetailListAsync(It.IsAny<OrderVersionPostageDetailListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageDetailListRequestBody
            {
                InputParameter = new OrderVersionPostageDetailListInputParameter { OrderVersionPostageID = 12345 }
            };

            var result = await service.OrderVersionPostageDetailListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionPostageDetailListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageDetailListResponse
            {
                OrderVersionPostageDetailListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageDetailListAsync(It.IsAny<OrderVersionPostageDetailListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageDetailListRequestBody
            {
                InputParameter = new OrderVersionPostageDetailListInputParameter { OrderVersionPostageID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionPostageDetailListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionPostageDetailUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageDetailUpdateResponse
            {
                OrderVersionPostageDetailUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageDetailUpdateAsync(It.IsAny<OrderVersionPostageDetailUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageDetailUpdateRequestBody
            {
                InputParameter = new OrderVersionPostageDetailUpdateInputParameter { OrederVersionPostageDetailID = 12345 }
            };

            var result = await service.OrderVersionPostageDetailUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionPostageDetailUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionPostageDetailUpdateResponse
            {
                OrderVersionPostageDetailUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionPostageDetailUpdateAsync(It.IsAny<OrderVersionPostageDetailUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderVersionPostageService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionPostageDetailUpdateRequestBody
            {
                InputParameter = new OrderVersionPostageDetailUpdateInputParameter { OrederVersionPostageDetailID = 12345 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionPostageDetailUpdateAsync(auth, request);
            });
        }
    }
}
