using Midnight.SOAP.SDK.RequestObjects.InventoryInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class InventoryServiceTests
    {
        [Fact]
        public async Task InventoryListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryListResponse
            {
                InventoryListResult = "<Result><ReturnCode>0</ReturnCode><Items></Items></Result>"
            };
            mockSoap.Setup(s => s.InventoryListAsync(It.IsAny<InventoryListRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryListRequestBody
            {
                InputParameter = new InventoryListInputParameter
                {
                    Item = new List<InventoryListItem>
                    {
                        new InventoryListItem { ItemID = 1 }
                    }
                }
            };

            var result = await service.InventoryListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryListResponse
            {
                InventoryListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.InventoryListAsync(It.IsAny<InventoryListRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryListRequestBody
            {
                InputParameter = new InventoryListInputParameter
                {
                    Item = new List<InventoryListItem>
                    {
                        new InventoryListItem { ItemID = 1 }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryListAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryUpdateResponse
            {
                InventoryUpdateResult = "<Result><ReturnCode>0</ReturnCode><ItemID>123</ItemID></Result>"
            };
            mockSoap.Setup(s => s.InventoryUpdateAsync(It.IsAny<InventoryUpdateRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryUpdateRequestBody
            {
                InputParameter = new InventoryUpdateInputParameter
                {
                    ItemID = 123,
                    CustomerID = 1
                }
            };

            var result = await service.InventoryUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(123, result.ItemID);
        }

        [Fact]
        public async Task InventoryUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryUpdateResponse
            {
                InventoryUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.InventoryUpdateAsync(It.IsAny<InventoryUpdateRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryUpdateRequestBody
            {
                InputParameter = new InventoryUpdateInputParameter
                {
                    ItemID = 123,
                    CustomerID = 1
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryTransactionUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryTransactionUpdateResponse
            {
                InventoryTransactionUpdateResult = "<Result><ReturnCode>0</ReturnCode><ItemID>456</ItemID></Result>"
            };
            mockSoap.Setup(s => s.InventoryTransactionUpdateAsync(It.IsAny<InventoryTransactionUpdateRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryTransactionUpdateRequestBody
            {
                InputParameter = new InventoryTransactionUpdateInputParameter
                {
                    Item = new InventoryTransactionUpdateItem
                    {
                        ItemID = 456,
                        ItemTransactionTypeID = 1
                    }
                }
            };

            var result = await service.InventoryTransactionUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(456, result.ItemID);
        }

        [Fact]
        public async Task InventoryTransactionUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryTransactionUpdateResponse
            {
                InventoryTransactionUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.InventoryTransactionUpdateAsync(It.IsAny<InventoryTransactionUpdateRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryTransactionUpdateRequestBody
            {
                InputParameter = new InventoryTransactionUpdateInputParameter
                {
                    Item = new InventoryTransactionUpdateItem
                    {
                        ItemID = 456,
                        ItemTransactionTypeID = 1
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryTransactionUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryNewResponse
            {
                InventoryNewResult = "<Result><ReturnCode>0</ReturnCode><ItemID>789</ItemID></Result>"
            };
            mockSoap.Setup(s => s.InventoryNewAsync(It.IsAny<InventoryNewRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryNewRequestBody
            {
                InputParameter = new InventoryNewInputParameter
                {
                    Items = new List<Item>
                    {
                        new Item { CustomerID = 1 }
                    }
                }
            };

            var result = await service.InventoryNewAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(789, result.ItemID);
        }

        [Fact]
        public async Task InventoryNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryNewResponse
            {
                InventoryNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.InventoryNewAsync(It.IsAny<InventoryNewRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryNewRequestBody
            {
                InputParameter = new InventoryNewInputParameter
                {
                    Items = new List<Item>
                    {
                        new Item { CustomerID = 1 }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryNewAsync(auth, request);
            });
        }

        [Fact]
        public async Task ItemRequestNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ItemRequestNewResponse
            {
                ItemRequestNewResult = "<Result><ReturnCode>0</ReturnCode><ItemRequestID>321</ItemRequestID></Result>"
            };
            mockSoap.Setup(s => s.ItemRequestNewAsync(It.IsAny<ItemRequestNewRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ItemRequestNewRequestBody
            {
                InputParameter = new ItemRequestNewInputParameter
                {
                    ItemRequests = new List<ItemRequest>
                    {
                        new ItemRequest { ItemRequestTypeID = 1, CustomerVendorID = 1 }
                    }
                }
            };

            var result = await service.ItemRequestNewAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
            Assert.Equal(321, result.ItemRequestID);
        }

        [Fact]
        public async Task ItemRequestNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ItemRequestNewResponse
            {
                ItemRequestNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.ItemRequestNewAsync(It.IsAny<ItemRequestNewRequest>())).ReturnsAsync(response);

            var service = new InventoryService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ItemRequestNewRequestBody
            {
                InputParameter = new ItemRequestNewInputParameter
                {
                    ItemRequests = new List<ItemRequest>
                    {
                        new ItemRequest { ItemRequestTypeID = 1, CustomerVendorID = 1 }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.ItemRequestNewAsync(auth, request);
            });
        }
    }
}
