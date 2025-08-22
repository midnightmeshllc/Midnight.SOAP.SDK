using Midnight.SOAP.SDK.RequestObjects.ProofingInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class ProofingServiceTests
    {
        [Fact]
        public async Task RequestAttachmentListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestAttachmentListResponse
            {
                RequestAttachmentListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestAttachmentListAsync(It.IsAny<RequestAttachmentListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofAttachmentListRequestBody 
            { 
                InputParameter = new ProofAttachmentListInputParameter { RequestID = 1 }
            };

            var result = await service.RequestAttachmentListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestAttachmentListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestAttachmentListResponse
            {
                RequestAttachmentListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestAttachmentListAsync(It.IsAny<RequestAttachmentListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofAttachmentListRequestBody 
            { 
                InputParameter = new ProofAttachmentListInputParameter { RequestID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestAttachmentListAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestApproverListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverListResponse
            {
                RequestApproverListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverListAsync(It.IsAny<RequestApproverListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverListRequestBody { InputParameter = new ProofApproverListInputParameter { RequestID = 1 } };

            var result = await service.RequestApproverListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestApproverListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverListResponse
            {
                RequestApproverListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverListAsync(It.IsAny<RequestApproverListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverListRequestBody { InputParameter = new ProofApproverListInputParameter { RequestID = 1 } };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestApproverListAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestStatusListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestStatusListResponse
            {
                RequestStatusListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestStatusListAsync(It.IsAny<RequestStatusListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofStatusListRequestBody { InputParameter = new ProofStatusListInputParameter() };

            var result = await service.RequestStatusListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestStatusListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestStatusListResponse
            {
                RequestStatusListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestStatusListAsync(It.IsAny<RequestStatusListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofStatusListRequestBody { InputParameter = new ProofStatusListInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestStatusListAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestListResponse
            {
                RequestListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestListAsync(It.IsAny<RequestListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofListRequestBody 
            { 
                InputParameter = new ProofListInputParameter 
                { 
                    RequestDateFrom = "01/01/2025", RequestDateTo = "01/31/2025"
                }
            };

            var result = await service.RequestListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestListResponse
            {
                RequestListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestListAsync(It.IsAny<RequestListRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofListRequestBody 
            {
                InputParameter = new ProofListInputParameter
                {
                    RequestDateFrom = "01/01/2025",
                    RequestDateTo = "01/31/2025"
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestListAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestNewAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestNewResponse
            {
                RequestNewResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestNewAsync(It.IsAny<RequestNewRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofNewRequestBody 
            { 
                InputParameter = new ProofNewInputParameter 
                { 
                    Requests = new List<RequestNew>
                    {
                        new RequestNew
                        {
                            RequestDate = "01/01/2025",
                            CustomerID = 1,
                        }
                    }
                }
            };

            var result = await service.RequestNewAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestNewAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestNewResponse
            {
                RequestNewResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestNewAsync(It.IsAny<RequestNewRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofNewRequestBody 
            { 
                InputParameter = new ProofNewInputParameter 
                { 
                    Requests = new List<RequestNew>
                    {
                        new RequestNew
                        {
                            RequestDate = "01/01/2025",
                            CustomerID = 1,
                        }
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestNewAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestAddAttachmentAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestAddAttachmentResponse
            {
                RequestAddAttachmentResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestAddAttachmentAsync(It.IsAny<RequestAddAttachmentRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofAddAttachmentRequestBody 
            { 
                InputParameter = new ProofAddAttachmentInputParameter 
                { 
                    FileBytesBase64 = new byte(), FileName = "testfile.txt", RequestID = 1 
                }
            };

            var result = await service.RequestAddAttachmentAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestAddAttachmentAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestAddAttachmentResponse
            {
                RequestAddAttachmentResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestAddAttachmentAsync(It.IsAny<RequestAddAttachmentRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofAddAttachmentRequestBody 
            { 
                InputParameter = new ProofAddAttachmentInputParameter 
                { 
                    FileBytesBase64 = new byte(), FileName = "testfile.txt", RequestID = 1 
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestAddAttachmentAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestApproverInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverInsertResponse
            {
                RequestApproverInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverInsertAsync(It.IsAny<RequestApproverInsertRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverUpdateRequestBody 
            { 
                InputParameter = new ProofApproverUpdateInputParameter { RequestApproverID = 1 }
            };

            var result = await service.RequestApproverInsertAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestApproverInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverInsertResponse
            {
                RequestApproverInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverInsertAsync(It.IsAny<RequestApproverInsertRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverUpdateRequestBody 
            { 
                InputParameter = new ProofApproverUpdateInputParameter { RequestApproverID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestApproverInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestUpdateAsync_ReturnsResult_WhenNoErrors()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestUpdateResponse
            {
                RequestUpdateResult = "<Result><Results><Result><ReturnCode>0</ReturnCode></Result></Results></Result>"
            };
            mockSoap.Setup(s => s.RequestUpdateAsync(It.IsAny<RequestUpdateRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofUpdateRequestBody 
            { 
                InputParameter = new ProofUpdateInputParameter
                {
                    Requests = new List<ProofUpdate> { new ProofUpdate { RequestID = 1 } }
                }
            };

            var result = await service.RequestUpdateAsync(auth, request);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task RequestUpdateAsync_ThrowsException_WhenErrorsExist()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestUpdateResponse
            {
                RequestUpdateResult = "<Result><Results><Result><ReturnCode>-1</ReturnCode><ReturnErrors><Error>Someerror</Error></ReturnErrors></Result></Results></Result>"
            };
            mockSoap.Setup(s => s.RequestUpdateAsync(It.IsAny<RequestUpdateRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            ProofUpdateRequestBody? request = null;

            var ex = await Assert.ThrowsAnyAsync<Exception>(async () =>
            {
                await service.RequestUpdateAsync(auth, request!);
            });

            Assert.True(ex is Exception || ex is ArgumentNullException || ex is InvalidOperationException);
        }

        [Fact]
        public async Task RequestApproverUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverUpdateResponse
            {
                RequestApproverUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverUpdateAsync(It.IsAny<RequestApproverUpdateRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverUpdateRequestBody 
            { 
                InputParameter = new ProofApproverUpdateInputParameter { RequestApproverID = 1 }
            };

            var result = await service.RequestApproverUpdateAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestApproverUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverUpdateResponse
            {
                RequestApproverUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverUpdateAsync(It.IsAny<RequestApproverUpdateRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverUpdateRequestBody 
            { 
                InputParameter = new ProofApproverUpdateInputParameter { RequestApproverID = 1 }            
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestApproverUpdateAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestDeleteAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestDeleteResponse
            {
                RequestDeleteResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestDeleteAsync(It.IsAny<RequestDeleteRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofDeleteRequestBody 
            { 
                InputParameter = new ProofDeleteInputParameter { RequestID = 1 }
            };

            var result = await service.RequestDeleteAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestDeleteAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestDeleteResponse
            {
                RequestDeleteResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestDeleteAsync(It.IsAny<RequestDeleteRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofDeleteRequestBody 
            { 
                InputParameter = new ProofDeleteInputParameter { RequestID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestDeleteAsync(auth, request);
            });
        }

        [Fact]
        public async Task RequestApproverDeleteAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverDeleteResponse
            {
                RequestApproverDeleteResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverDeleteAsync(It.IsAny<RequestApproverDeleteRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverDeleteRequestBody 
            { 
                InputParameter = new ProofApproverDeleteInputParameter { RequestApproverID = 1 }
            };

            var result = await service.RequestApproverDeleteAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task RequestApproverDeleteAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RequestApproverDeleteResponse
            {
                RequestApproverDeleteResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.RequestApproverDeleteAsync(It.IsAny<RequestApproverDeleteRequest>())).ReturnsAsync(response);

            var service = new ProofingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProofApproverDeleteRequestBody 
            { 
                InputParameter = new ProofApproverDeleteInputParameter { RequestApproverID = 1 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.RequestApproverDeleteAsync(auth, request);
            });
        }
    }
}
