using Midnight.SOAP.SDK.RequestObjects.InventoryItemInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class InventoryItemServiceTests
    {
        [Fact]
        public async Task InventoryItemLocationListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLocationListResponse
            {
                InventoryItemLocationListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLocationListAsync(It.IsAny<InventoryItemLocationListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLocationListRequestBody
            {
                InputParameter = new InventoryItemLocationListInputParameter()
            };

            var result = await service.InventoryItemLocationListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryItemLocationListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLocationListResponse
            {
                InventoryItemLocationListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLocationListAsync(It.IsAny<InventoryItemLocationListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLocationListRequestBody
            {
                InputParameter = new InventoryItemLocationListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryItemLocationListAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryItemLotListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLotListResponse
            {
                InventoryItemLotListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLotListAsync(It.IsAny<InventoryItemLotListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLotListRequestBody
            {
                InputParameter = new InventoryItemLotListInputParameter()
            };

            var result = await service.InventoryItemLotListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryItemLotListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLotListResponse
            {
                InventoryItemLotListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLotListAsync(It.IsAny<InventoryItemLotListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLotListRequestBody
            {
                InputParameter = new InventoryItemLotListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryItemLotListAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryItemLotNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLotNewResponse
            {
                InventoryItemLotNewResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLotNewAsync(It.IsAny<InventoryItemLotNewRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLotNewRequestBody
            {
                InputParameter = new InventoryItemLotNewInputParameter()
            };

            var result = await service.InventoryItemLotNewAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryItemLotNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLotNewResponse
            {
                InventoryItemLotNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLotNewAsync(It.IsAny<InventoryItemLotNewRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLotNewRequestBody
            {
                InputParameter = new InventoryItemLotNewInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryItemLotNewAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryItemTransactionTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemTransactionTypeListResponse
            {
                InventoryItemTransactionTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemTransactionTypeListAsync(It.IsAny<InventoryItemTransactionTypeListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemTransactionTypeListRequestBody
            {
                InputParameter = new InventoryItemTransactionTypeListInputParameter()
            };

            var result = await service.InventoryItemTransactionTypeListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryItemTransactionTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemTransactionTypeListResponse
            {
                InventoryItemTransactionTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemTransactionTypeListAsync(It.IsAny<InventoryItemTransactionTypeListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemTransactionTypeListRequestBody
            {
                InputParameter = new InventoryItemTransactionTypeListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryItemTransactionTypeListAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryItemTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemTypeListResponse
            {
                InventoryItemTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemTypeListAsync(It.IsAny<InventoryItemTypeListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemTypeListRequestBody
            {
                InputParameter = new InventoryItemTypeListInputParameter()
            };

            var result = await service.InventoryItemTypeListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryItemTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemTypeListResponse
            {
                InventoryItemTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemTypeListAsync(It.IsAny<InventoryItemTypeListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemTypeListRequestBody
            {
                InputParameter = new InventoryItemTypeListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryItemTypeListAsync(auth, request);
            });
        }

        [Fact]
        public async Task ItemRequestTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ItemRequestTypeListResponse
            {
                ItemRequestTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.ItemRequestTypeListAsync(It.IsAny<ItemRequestTypeListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ItemRequestTypeListRequestBody
            {
                InputParameter = new ItemRequestTypeListInputParameter()
            };

            var result = await service.ItemRequestTypeListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task ItemRequestTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ItemRequestTypeListResponse
            {
                ItemRequestTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.ItemRequestTypeListAsync(It.IsAny<ItemRequestTypeListRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ItemRequestTypeListRequestBody
            {
                InputParameter = new ItemRequestTypeListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.ItemRequestTypeListAsync(auth, request);
            });
        }

        [Fact]
        public async Task InventoryItemLotUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLotUpdateResponse
            {
                InventoryItemLotUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLotUpdateAsync(It.IsAny<InventoryItemLotUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLotUpdateRequestBody
            {
                InputParameter = new InventoryItemLotUpdateInputParameter 
                { 
                    ItemLot = new InventoryItemLotUpdate { ItemLotID = 1 } 
                }
            };

            var result = await service.InventoryItemLotUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task InventoryItemLotUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new InventoryItemLotUpdateResponse
            {
                InventoryItemLotUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.InventoryItemLotUpdateAsync(It.IsAny<InventoryItemLotUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new InventoryItemService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new InventoryItemLotUpdateRequestBody
            {
                InputParameter = new InventoryItemLotUpdateInputParameter
                {
                    ItemLot = new InventoryItemLotUpdate { ItemLotID = 1 }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.InventoryItemLotUpdateAsync(auth, request);
            });
        }
    }
}
