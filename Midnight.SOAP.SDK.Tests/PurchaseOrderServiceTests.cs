using Midnight.SOAP.SDK.RequestObjects.PurchaseOrderInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class PurchaseOrderServiceTests
    {
        [Fact]
        public async Task PurchaseOrderNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PurchaseOrderNewResponse
            {
                PurchaseOrderNewResult = "<Result><ReturnCode>0</ReturnCode><PurchaseOrderID>123</PurchaseOrderID></Result>"
            };
            mockSoap.Setup(s => s.PurchaseOrderNewAsync(It.IsAny<PurchaseOrderNewRequest>())).ReturnsAsync(response);

            var service = new PurchaseOrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PurchaseOrderNewRequestBody
            {
                InputParameter = new PurchaseOrderNewInputParameter
                {
                    PurchaseOrders = new List<PurchaseOrderNew> {
                        new PurchaseOrderNew { PurchaseOrderType = "PO", VendorID = 1 }
                    }
                }
            };

            var result = await service.PurchaseOrderNewAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(123, result.PurchaseOrderID);
        }

        [Fact]
        public async Task PurchaseOrderNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PurchaseOrderNewResponse
            {
                PurchaseOrderNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.PurchaseOrderNewAsync(It.IsAny<PurchaseOrderNewRequest>())).ReturnsAsync(response);

            var service = new PurchaseOrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PurchaseOrderNewRequestBody
            {
                InputParameter = new PurchaseOrderNewInputParameter
                {
                    PurchaseOrders = new List<PurchaseOrderNew> {
                        new PurchaseOrderNew { PurchaseOrderType = "PO", VendorID = 1 }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.PurchaseOrderNewAsync(auth, request);
            });
        }

        [Fact]
        public async Task PurchaseOrderListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PurchaseOrderListResponse
            {
                PurchaseOrderListResult = "<Result><ReturnCode>0</ReturnCode><PurchaseOrders></PurchaseOrders></Result>"
            };
            mockSoap.Setup(s => s.PurchaseOrderListAsync(It.IsAny<PurchaseOrderListRequest>())).ReturnsAsync(response);

            var service = new PurchaseOrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PurchaseOrderListRequestBody
            {
                InputParameter = new PurchaseOrderListInputParameter()
            };

            var result = await service.PurchaseOrderListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task PurchaseOrderListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PurchaseOrderListResponse
            {
                PurchaseOrderListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.PurchaseOrderListAsync(It.IsAny<PurchaseOrderListRequest>())).ReturnsAsync(response);

            var service = new PurchaseOrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PurchaseOrderListRequestBody
            {
                InputParameter = new PurchaseOrderListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.PurchaseOrderListAsync(auth, request);
            });
        }

        [Fact]
        public async Task PurchaseOrderUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PurchaseOrderUpdateResponse
            {
                PurchaseOrderUpdateResult = "<Result><ReturnCode>0</ReturnCode><PurchaseOrderID>456</PurchaseOrderID></Result>"
            };
            mockSoap.Setup(s => s.PurchaseOrderUpdateAsync(It.IsAny<PurchaseOrderUpdateRequest>())).ReturnsAsync(response);

            var service = new PurchaseOrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PurchaseOrderUpdateRequestBody
            {
                InputParameter = new PurchaseOrderUpdateInputParameter
                {
                    PurchaseOrder = new List<PurchaseOrderUpdateInput> {
                        new PurchaseOrderUpdateInput { PurchaseOrderID = 1, VendorID = 2 }
                    }
                }
            };

            var result = await service.PurchaseOrderUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(456, result.PurchaseOrderID);
        }

        [Fact]
        public async Task PurchaseOrderUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PurchaseOrderUpdateResponse
            {
                PurchaseOrderUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.PurchaseOrderUpdateAsync(It.IsAny<PurchaseOrderUpdateRequest>())).ReturnsAsync(response);

            var service = new PurchaseOrderService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PurchaseOrderUpdateRequestBody
            {
                InputParameter = new PurchaseOrderUpdateInputParameter
                {
                    PurchaseOrder = new List<PurchaseOrderUpdateInput> {
                        new PurchaseOrderUpdateInput { PurchaseOrderID = 1, VendorID = 2 }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.PurchaseOrderUpdateAsync(auth, request);
            });
        }
    }
}
