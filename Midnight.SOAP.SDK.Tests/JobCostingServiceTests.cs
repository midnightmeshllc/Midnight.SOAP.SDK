using MidnightAPI;
using Midnight.SOAP.SDK;
using Midnight.SOAP.SDK.RequestObjects.JobCostInputs;
using Midnight.SOAP.SDK.ResponseObjects.JobCostOutputs;
using Moq;
using Xunit;
using System;
using System.Collections.Generic;

namespace Midnight.SOAP.SDK.Tests
{
    public class JobCostingServiceTests
    {
        [Fact]
        public async Task JobCostingJobOutAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostingJobOutResponse
            {
                JobCostingJobOutResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostingJobOutAsync(It.IsAny<JobCostingJobOutRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobOutRequestBody { InputParameter = new JobOutInputParameter { JobCostDetailTempID = 1 } };

            var result = await service.JobCostingJobOutAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task JobCostingJobOutAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostingJobOutResponse
            {
                JobCostingJobOutResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostingJobOutAsync(It.IsAny<JobCostingJobOutRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobOutRequestBody { InputParameter = new JobOutInputParameter { JobCostDetailTempID = 1 } };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.JobCostingJobOutAsync(auth, request);
            });
        }

        [Fact]
        public async Task JobCostProductionTimeEntryAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostProductionTimeEntryResponse
            {
                JobCostProductionTimeEntryResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostProductionTimeEntryAsync(It.IsAny<JobCostProductionTimeEntryRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProductionTimeEntryRequestBody 
            { 
                InputParameter = new ProductionTimeEntryInputParameter { EmployeeID = 1234 } 
            };

            var result = await service.JobCostProductionTimeEntryAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task JobCostProductionTimeEntryAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostProductionTimeEntryResponse
            {
                JobCostProductionTimeEntryResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostProductionTimeEntryAsync(It.IsAny<JobCostProductionTimeEntryRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ProductionTimeEntryRequestBody 
            { 
                InputParameter = new ProductionTimeEntryInputParameter { EmployeeID = 1234 }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.JobCostProductionTimeEntryAsync(auth, request);
            });
        }

        [Fact]
        public async Task JobCostServiceTimeEntry_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostServiceTimeEntryResponse
            {
                JobCostServiceTimeEntryResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostServiceTimeEntryAsync(It.IsAny<JobCostServiceTimeEntryRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ServiceTimeEntryRequestBody 
            { 
                EmployeeID = 123,
                ActivityDate = "2024-01-01",
                JobCostItems = new List<ServiceTimeEntryRequestItem>
                {
                    new ServiceTimeEntryRequestItem
                    {
                        OperationCode = "OP123",
                        HelpersCount = 2,
                        TotalTime = 1.0m
                    }
                }
            };

            var result = await service.JobCostServiceTimeEntry(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task JobCostServiceTimeEntry_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostServiceTimeEntryResponse
            {
                JobCostServiceTimeEntryResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostServiceTimeEntryAsync(It.IsAny<JobCostServiceTimeEntryRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ServiceTimeEntryRequestBody 
            { 
                EmployeeID = 123,
                ActivityDate = "2024-01-01",
                JobCostItems = new List<ServiceTimeEntryRequestItem>
                {
                    new ServiceTimeEntryRequestItem
                    {
                        OperationCode = "OP123",
                        HelpersCount = 2,
                        TotalTime = 1.0m
                    }
                }
            };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.JobCostServiceTimeEntry(auth, request);
            });
        }

        [Fact]
        public async Task OrderVersionOtherJobCostInsertAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionOtherJobCostInsertResponse
            {
                OrderVersionOtherJobCostInsertResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionOtherJobCostInsertAsync(It.IsAny<OrderVersionOtherJobCostInsertRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionOtherJobCostInsertRequestBody { OrderID = 1, Date = "01/01/2025", VersionID = 1 };

            var result = await service.OrderVersionOtherJobCostInsertAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionOtherJobCostInsertAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionOtherJobCostInsertResponse
            {
                OrderVersionOtherJobCostInsertResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionOtherJobCostInsertAsync(It.IsAny<OrderVersionOtherJobCostInsertRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionOtherJobCostInsertRequestBody { Date = "01/01/2025", OrderID = 1, VersionID = 1 };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionOtherJobCostInsertAsync(auth, request);
            });
        }

        [Fact]
        public async Task JobCostDetailTempListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostDetailTempListResponse
            {
                JobCostDetailTempListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostDetailTempListAsync(It.IsAny<JobCostDetailTempListRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };

            var result = await service.JobCostDetailTempListAsync(auth);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task JobCostDetailTempListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostDetailTempListResponse
            {
                JobCostDetailTempListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostDetailTempListAsync(It.IsAny<JobCostDetailTempListRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.JobCostDetailTempListAsync(auth);
            });
        }

        [Fact]
        public async Task JobCostOrderVersionServiceSummaryListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostOrderVersionServiceSummaryListResponse
            {
                JobCostOrderVersionServiceSummaryListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostOrderVersionServiceSummaryListAsync(It.IsAny<JobCostOrderVersionServiceSummaryListRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var orderNumber = "ORD123";
            var jobCostingDate = "2024-05-01";

            var result = await service.JobCostOrderVersionServiceSummaryListAsync(auth, orderNumber, jobCostingDate);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task JobCostOrderVersionServiceSummaryListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobCostOrderVersionServiceSummaryListResponse
            {
                JobCostOrderVersionServiceSummaryListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.JobCostOrderVersionServiceSummaryListAsync(It.IsAny<JobCostOrderVersionServiceSummaryListRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var orderNumber = "ORD123";
            var jobCostingDate = "2024-05-01";

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.JobCostOrderVersionServiceSummaryListAsync(auth, orderNumber, jobCostingDate);
            });
        }

        [Fact]
        public async Task OrderVersionOtherJobCostUpdateAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionOtherJobCostUpdateResponse
            {
                OrderVersionOtherJobCostUpdateResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionOtherJobCostUpdateAsync(It.IsAny<OrderVersionOtherJobCostUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionOtherJobCostUpdateRequestBody { OrderVersionOtherJobCostID = 1, Date = "01/01/2025" };

            var result = await service.OrderVersionOtherJobCostUpdateAsync(auth, request);

            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OrderVersionOtherJobCostUpdateAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionOtherJobCostUpdateResponse
            {
                OrderVersionOtherJobCostUpdateResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap
                .Setup(s => s.OrderVersionOtherJobCostUpdateAsync(It.IsAny<OrderVersionOtherJobCostUpdateRequest>()))
                .ReturnsAsync(response);

            var service = new JobCostingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionOtherJobCostUpdateRequestBody { OrderVersionOtherJobCostID = 1, Date = "01/01/2025" };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OrderVersionOtherJobCostUpdateAsync(auth, request);
            });
        }
    }
}
