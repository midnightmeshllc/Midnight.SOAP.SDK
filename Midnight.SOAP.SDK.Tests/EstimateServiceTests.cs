using Midnight.SOAP.SDK.RequestObjects.EstimateInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class EstimateServiceTests
    {
        [Fact]
        public async Task EstimateListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateListResponse
            {
                EstimateListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateListAsync(It.IsAny<EstimateListRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateListRequestBody
            {
                InputParameter = new EstimateListInputParameter()
            };

            var result = await service.EstimateListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task EstimateListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateListResponse
            {
                EstimateListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateListAsync(It.IsAny<EstimateListRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateListRequestBody
            {
                InputParameter = new EstimateListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.EstimateListAsync(auth, request);
            });
        }

        [Fact]
        public async Task EstimateDetailListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateDetailListResponse
            {
                EstimateDetailListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateDetailListAsync(It.IsAny<EstimateDetailListRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateDetailListRequestBody
            {
                InputParameter = new EstimateDetailListInputParameter { EstimateID = 1 }
            };

            var result = await service.EstimateDetailListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task EstimateDetailListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateDetailListResponse
            {
                EstimateDetailListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateDetailListAsync(It.IsAny<EstimateDetailListRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateDetailListRequestBody
            {
                InputParameter = new EstimateDetailListInputParameter { EstimateID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.EstimateDetailListAsync(auth, request);
            });
        }

        [Fact]
        public async Task EstimateInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateInsertResponse
            {
                EstimateInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateInsertAsync(It.IsAny<EstimateInsertRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateInsertRequestBody();

            var result = await service.EstimateInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task EstimateInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateInsertResponse
            {
                EstimateInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateInsertAsync(It.IsAny<EstimateInsertRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateInsertRequestBody();

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.EstimateInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task PrintTemplatePreviewPriceAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PrintTemplatePreviewPriceResponse
            {
                PrintTemplatePreviewPriceResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.PrintTemplatePreviewPriceAsync(It.IsAny<PrintTemplatePreviewPriceRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PrintTemplatePreviewPriceRequestBody { ProjectTypeID = 1, CustomerID = 1, Quantity = 1 };

            var result = await service.PrintTemplatePreviewPriceAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task PrintTemplatePreviewPriceAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PrintTemplatePreviewPriceResponse
            {
                PrintTemplatePreviewPriceResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.PrintTemplatePreviewPriceAsync(It.IsAny<PrintTemplatePreviewPriceRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PrintTemplatePreviewPriceRequestBody { ProjectTypeID = 1, CustomerID = 1, Quantity = 1 };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.PrintTemplatePreviewPriceAsync(auth, request);
            });
        }

        [Fact]
        public async Task WideFormatPreviewPriceAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new WideFormatPreviewPriceResponse
            {
                WideFormatPreviewPriceResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.WideFormatPreviewPriceAsync(It.IsAny<WideFormatPreviewPriceRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new WideFormatPreviewPriceRequestBody { WideFormatProductTypeID = 1, CustomerID = 1, Quantity = 1 };

            var result = await service.WideFormatPreviewPriceAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task WideFormatPreviewPriceAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new WideFormatPreviewPriceResponse
            {
                WideFormatPreviewPriceResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.WideFormatPreviewPriceAsync(It.IsAny<WideFormatPreviewPriceRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new WideFormatPreviewPriceRequestBody { WideFormatProductTypeID = 1, CustomerID = 1, Quantity = 1 };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.WideFormatPreviewPriceAsync(auth, request);
            });
        }

        [Fact]
        public async Task EstimateUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateUpdateResponse
            {
                EstimateUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateUpdateAsync(It.IsAny<EstimateUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateUpdateRequestBody { EstimateID = 1 };

            var result = await service.EstimateUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task EstimateUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EstimateUpdateResponse
            {
                EstimateUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.EstimateUpdateAsync(It.IsAny<EstimateUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new EstimateService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EstimateUpdateRequestBody { EstimateID = 1 };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.EstimateUpdateAsync(auth, request);
            });
        }
    }
}
