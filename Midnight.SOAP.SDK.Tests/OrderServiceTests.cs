using Midnight.SOAP.SDK.RequestObjects.OrderInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class OrderServiceTests
    {
        [Fact]
        public async Task OrderListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderListResponse
            {
                OrderListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderListAsync(It.IsAny<OrderListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderListRequestBody { InputParameter = new OrderListInputParameter() };

            var result = await service.OrderListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderListResponse
            {
                OrderListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderListAsync(It.IsAny<OrderListRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderListRequestBody { InputParameter = new OrderListInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderQuickAddAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderQuickAddResponse
            {
                OrderQuickAddResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderQuickAddAsync(It.IsAny<OrderQuickAddRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderQuickAddRequestBody { Order = new OrderQuickAddInputParameter() };

            var result = await service.OrderQuickAddAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderQuickAddAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderQuickAddResponse
            {
                OrderQuickAddResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderQuickAddAsync(It.IsAny<OrderQuickAddRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderQuickAddRequestBody { Order = new OrderQuickAddInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderQuickAddAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderUpdateResponse
            {
                OrderUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderUpdateAsync(It.IsAny<OrderUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderUpdateRequestBody { InputParameter = new OrderUpdateInputParameter { OrderID = 1 } };

            var result = await service.OrderUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderUpdateResponse
            {
                OrderUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderUpdateAsync(It.IsAny<OrderUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderUpdateRequestBody { InputParameter = new OrderUpdateInputParameter { OrderID = 1 } };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderNewResponse
            {
                OrderNewResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderNewAsync(It.IsAny<OrderNewRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderNewRequestBody { Order = new OrderNewInputParameter() };

            var result = await service.OrderNewAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderNewResponse
            {
                OrderNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderNewAsync(It.IsAny<OrderNewRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderNewRequestBody { Order = new OrderNewInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderNewAsync(auth, request);
            });
        }

        [Fact]
        public async Task OrderAddAttachmentAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderAddAttachmentResponse
            {
                OrderAddAttachmentResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderAddAttachmentAsync(It.IsAny<OrderAddAttachmentRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var fileContent = new byte[] { 1, 2, 3 };
            var fileName = "test.pdf";
            int? documentTypeId = 1;
            int orderId = 123;

            var result = await service.OrderAddAttachmentAsync(auth, fileContent, fileName, documentTypeId, orderId);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderAddAttachmentAsync_ReturnsError_WhenFileContentIsZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var fileContent = new byte[] { 0, 0, 0 };
            var fileName = "test.pdf";
            int? documentTypeId = 1;
            int orderId = 123;

            var result = await service.OrderAddAttachmentAsync(auth, fileContent, fileName, documentTypeId, orderId);

            Assert.NotNull(result);
            Assert.Equal(-1, result.ReturnCode);
            Assert.Contains(result.ReturnErrors, e => e.Error != null 
                && e.Error.Contains("File content byte array must be non-zero"));
        }

        [Fact]
        public async Task OrderAddAttachmentAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderAddAttachmentResponse
            {
                OrderAddAttachmentResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderAddAttachmentAsync(It.IsAny<OrderAddAttachmentRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var fileContent = new byte[] { 1, 2, 3 };
            var fileName = "test.pdf";
            int? documentTypeId = 1;
            int orderId = 123;

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderAddAttachmentAsync(auth, fileContent, fileName, documentTypeId, orderId);
            });
        }

        [Fact]
        public async Task OrderShipmentNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderShipmentNewResponse
            {
                OrderShipmentNewResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderShipmentNewAsync(It.IsAny<OrderShipmentNewRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderShipmentNewRequestBody 
            { 
                OrderID = 1, ShippedDate = "01/01/2025", TrackingNo = "TR1234", VersionID = 1 
            };

            var result = await service.OrderShipmentNewAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderShipmentNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderShipmentNewResponse
            {
                OrderShipmentNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderShipmentNewAsync(It.IsAny<OrderShipmentNewRequest>()))
                .ReturnsAsync(response);

            var service = new OrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderShipmentNewRequestBody
            {
                OrderID = 1,
                ShippedDate = "01/01/2025",
                TrackingNo = "TR1234",
                VersionID = 1
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderShipmentNewAsync(auth, request);
            });
        }
    }
}
