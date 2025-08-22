using MidnightAPI;
using Midnight.SOAP.SDK;
using Midnight.SOAP.SDK.RequestObjects.DJBInputs;
using Midnight.SOAP.SDK.ResponseObjects.DJBOutputs;
using Moq;
using Xunit;

namespace Midnight.SOAP.SDK.Tests
{
    public class DJBServiceTests
    {
        [Fact]
        public async Task DJBJobStatusListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DJBJobStatusListResponse
            {
                DJBJobStatusListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.DJBJobStatusListAsync(It.IsAny<DJBJobStatusListRequest>()))
                .ReturnsAsync(response);

            var service = new DJBService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DJBJobStatusListRequestBody
            {
                InputParameter = new DJBStatusListInputParameter()
            };

            var result = await service.DJBJobStatusListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task DJBJobStatusListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DJBJobStatusListResponse
            {
                DJBJobStatusListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.DJBJobStatusListAsync(It.IsAny<DJBJobStatusListRequest>()))
                .ReturnsAsync(response);

            var service = new DJBService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DJBJobStatusListRequestBody
            {
                InputParameter = new DJBStatusListInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.DJBJobStatusListAsync(auth, request);
            });
        }

        [Fact]
        public async Task DJBListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DJBListResponse
            {
                DJBListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.DJBListAsync(It.IsAny<DJBListRequest>()))
                .ReturnsAsync(response);

            var service = new DJBService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DJBListRequestBody
            {
                InputParameter = new DJBListRequestInputParameter()
            };

            var result = await service.DJBListAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task DJBListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DJBListResponse
            {
                DJBListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.DJBListAsync(It.IsAny<DJBListRequest>()))
                .ReturnsAsync(response);

            var service = new DJBService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DJBListRequestBody
            {
                InputParameter = new DJBListRequestInputParameter()
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.DJBListAsync(auth, request);
            });
        }

        [Fact]
        public async Task DJBStatusUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DJBStatusUpdateResponse
            {
                DJBStatusUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.DJBStatusUpdateAsync(It.IsAny<DJBStatusUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new DJBService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DJBStatusUpdateRequestBody
            {
                InputParameter = new DJBStatusUpdateInputParameter { DJBDetailID = 1, DJBStatusID = 2 }
            };

            var result = await service.DJBStatusUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task DJBStatusUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DJBStatusUpdateResponse
            {
                DJBStatusUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.DJBStatusUpdateAsync(It.IsAny<DJBStatusUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new DJBService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DJBStatusUpdateRequestBody
            {
                InputParameter = new DJBStatusUpdateInputParameter { DJBDetailID = 1, DJBStatusID = 2 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.DJBStatusUpdateAsync(auth, request);
            });
        }
    }
}
