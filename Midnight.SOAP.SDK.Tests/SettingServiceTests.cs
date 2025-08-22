using Midnight.SOAP.SDK.RequestObjects.SettingInputs;
using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class SettingServiceTests
    {
        [Fact]
        public async Task CompanyListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CompanyListResponse
            {
                CompanyListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.CompanyListAsync(It.IsAny<CompanyListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CompanyListRequestBody { InputParameter = new CompanyListInputParameter() };

            var result = await service.CompanyListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task CompanyListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CompanyListResponse
            {
                CompanyListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.CompanyListAsync(It.IsAny<CompanyListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CompanyListRequestBody { InputParameter = new CompanyListInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.CompanyListAsync(auth, request);
            });
        }

        [Fact]
        public async Task OperationListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OperationListResponse
            {
                OperationListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.OperationListAsync(It.IsAny<OperationListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OperationListRequestBody { Active = true };

            var result = await service.OperationListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task OperationListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OperationListResponse
            {
                OperationListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.OperationListAsync(It.IsAny<OperationListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OperationListRequestBody { Active = true };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.OperationListAsync(auth, request);
            });
        }

        [Fact]
        public async Task JobFrequencyListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobFrequencyListResponse
            {
                JobFrequencyListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.JobFrequencyListAsync(It.IsAny<JobFrequencyListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobFrequencyListRequestBody { InputParameter = new JobFrequencyListInputParameter() };

            var result = await service.JobFrequencyListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task JobFrequencyListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobFrequencyListResponse
            {
                JobFrequencyListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.JobFrequencyListAsync(It.IsAny<JobFrequencyListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobFrequencyListRequestBody { InputParameter = new JobFrequencyListInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.JobFrequencyListAsync(auth, request);
            });
        }

        [Fact]
        public async Task MailClassListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailClassListResponse
            {
                MailClassListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.MailClassListAsync(It.IsAny<MailClassListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailClassListRequestBody { InputParameter = new MailClassListInputParameter() };

            var result = await service.MailClassListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task MailClassListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailClassListResponse
            {
                MailClassListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.MailClassListAsync(It.IsAny<MailClassListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailClassListRequestBody { InputParameter = new MailClassListInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.MailClassListAsync(auth, request);
            });
        }

        [Fact]
        public async Task MailCategoryListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailCategoryListResponse
            {
                MailCategoryListResult = "<Result><ReturnCode>0</ReturnCode></Result>"
            };
            mockSoap.Setup(s => s.MailCategoryListAsync(It.IsAny<MailCategoryListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailCategoryListRequestBody { InputParameter = new MailCategoryListInputParameter() };

            var result = await service.MailCategoryListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }

        [Fact]
        public async Task MailCategoryListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailCategoryListResponse
            {
                MailCategoryListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>"
            };
            mockSoap.Setup(s => s.MailCategoryListAsync(It.IsAny<MailCategoryListRequest>())).ReturnsAsync(response);

            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailCategoryListRequestBody { InputParameter = new MailCategoryListInputParameter() };

            await Assert.ThrowsAsync<Exception>(async () =>
            {
                await service.MailCategoryListAsync(auth, request);
            });
        }

        [Fact]
        public async Task ContactTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ContactTypeListResponse { ContactTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.ContactTypeListAsync(It.IsAny<ContactTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ContactTypeListRequestBody { InputParameter = new ContactTypeListInputParameter() };
            var result = await service.ContactTypeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task ContactTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ContactTypeListResponse { ContactTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.ContactTypeListAsync(It.IsAny<ContactTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ContactTypeListRequestBody { InputParameter = new ContactTypeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.ContactTypeListAsync(auth, request); });
        }

        [Fact]
        public async Task WarehouseLocationListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new WarehouseLocationListResponse { WarehouseLocationListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.WarehouseLocationListAsync(It.IsAny<WarehouseLocationListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new WarehouseLocationListRequestBody { InputParameter = new WarehouseLocationListInputParameter() };
            var result = await service.WarehouseLocationListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task WarehouseLocationListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new WarehouseLocationListResponse { WarehouseLocationListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.WarehouseLocationListAsync(It.IsAny<WarehouseLocationListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new WarehouseLocationListRequestBody { InputParameter = new WarehouseLocationListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.WarehouseLocationListAsync(auth, request); });
        }

        [Fact]
        public async Task WarehouseListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new WarehouseListResponse { WarehouseListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.WarehouseListAsync(It.IsAny<WarehouseListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new WarehouseListRequestBody { InputParameter = new WarehouseListInputParameter() };
            var result = await service.WarehouseListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task WarehouseListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new WarehouseListResponse { WarehouseListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.WarehouseListAsync(It.IsAny<WarehouseListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new WarehouseListRequestBody { InputParameter = new WarehouseListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.WarehouseListAsync(auth, request); });
        }

        [Fact]
        public async Task TermsListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new TermsListResponse { TermsListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.TermsListAsync(It.IsAny<TermsListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new TermsListRequestBody { InputParameter = new TermsListInputParameter() };
            var result = await service.TermsListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task TermsListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new TermsListResponse { TermsListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.TermsListAsync(It.IsAny<TermsListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new TermsListRequestBody { InputParameter = new TermsListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.TermsListAsync(auth, request); });
        }

        [Fact]
        public async Task ServiceWizardListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ServiceWizardListResponse { ServiceWizardListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.ServiceWizardListAsync(It.IsAny<ServiceWizardListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ServiceWizardListRequestBody();
            var result = await service.ServiceWizardListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task ServiceWizardListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ServiceWizardListResponse { ServiceWizardListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.ServiceWizardListAsync(It.IsAny<ServiceWizardListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ServiceWizardListRequestBody();
            await Assert.ThrowsAsync<Exception>(async () => { await service.ServiceWizardListAsync(auth, request); });
        }

        [Fact]
        public async Task CustomerTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerTypeListResponse { CustomerTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.CustomerTypeListAsync(It.IsAny<CustomerTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerTypeListRequestBody { InputParameter = new CustomerTypeListInputParameter() };
            var result = await service.CustomerTypeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task CustomerTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new CustomerTypeListResponse { CustomerTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.CustomerTypeListAsync(It.IsAny<CustomerTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new CustomerTypeListRequestBody { InputParameter = new CustomerTypeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.CustomerTypeListAsync(auth, request); });
        }

        [Fact]
        public async Task DeliveryMethodListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DeliveryMethodListResponse { DeliveryMethodListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.DeliveryMethodListAsync(It.IsAny<DeliveryMethodListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DeliveryMethodListRequestBody { InputParameter = new DeliveryMethodListInputParameter() };
            var result = await service.DeliveryMethodListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task DeliveryMethodListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DeliveryMethodListResponse { DeliveryMethodListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.DeliveryMethodListAsync(It.IsAny<DeliveryMethodListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DeliveryMethodListRequestBody { InputParameter = new DeliveryMethodListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.DeliveryMethodListAsync(auth, request); });
        }

        [Fact]
        public async Task DocumentTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DocumentTypeListResponse { DocumentTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.DocumentTypeListAsync(It.IsAny<DocumentTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DocumentTypeListRequestBody { InputParameter = new DocumentTypeListInputParameter() };
            var result = await service.DocumentTypeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task DocumentTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new DocumentTypeListResponse { DocumentTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.DocumentTypeListAsync(It.IsAny<DocumentTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new DocumentTypeListRequestBody { InputParameter = new DocumentTypeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.DocumentTypeListAsync(auth, request); });
        }

        [Fact]
        public async Task EmployeeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EmployeeListResponse { EmployeeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.EmployeeListAsync(It.IsAny<EmployeeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EmployeeListRequestBody { InputParameter = new EmployeeListInputParameter() };
            var result = await service.EmployeeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task EmployeeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new EmployeeListResponse { EmployeeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.EmployeeListAsync(It.IsAny<EmployeeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new EmployeeListRequestBody { InputParameter = new EmployeeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.EmployeeListAsync(auth, request); });
        }

        [Fact]
        public async Task JobPriorityListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobPriorityListResponse { JobPriorityListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.JobPriorityListAsync(It.IsAny<JobPriorityListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobPriorityListRequestBody { InputParameter = new JobPriorityListInputParameter() };
            var result = await service.JobPriorityListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task JobPriorityListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobPriorityListResponse { JobPriorityListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.JobPriorityListAsync(It.IsAny<JobPriorityListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobPriorityListRequestBody { InputParameter = new JobPriorityListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.JobPriorityListAsync(auth, request); });
        }

        [Fact]
        public async Task JobProgressListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobProgressListResponse { JobProgressListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.JobProgressListAsync(It.IsAny<JobProgressListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobProgressListRequestBody { InputParameter = new JobProgressListInputParameter() };
            var result = await service.JobProgressListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task JobProgressListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobProgressListResponse { JobProgressListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.JobProgressListAsync(It.IsAny<JobProgressListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobProgressListRequestBody { InputParameter = new JobProgressListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.JobProgressListAsync(auth, request); });
        }

        [Fact]
        public async Task JobTypeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobTypeListResponse { JobTypeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.JobTypeListAsync(It.IsAny<JobTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobTypeListRequestBody { InputParameter = new JobTypeListInputParameter() };
            var result = await service.JobTypeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task JobTypeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new JobTypeListResponse { JobTypeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.JobTypeListAsync(It.IsAny<JobTypeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new JobTypeListRequestBody { InputParameter = new JobTypeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.JobTypeListAsync(auth, request); });
        }

        [Fact]
        public async Task MailGeographyListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailGeographyListResponse { MailGeographyListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.MailGeographyListAsync(It.IsAny<MailGeographyListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailGeographyListRequestBody { InputParameter = new MailGeographyListInputParameter() };
            var result = await service.MailGeographyListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task MailGeographyListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailGeographyListResponse { MailGeographyListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.MailGeographyListAsync(It.IsAny<MailGeographyListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailGeographyListRequestBody { InputParameter = new MailGeographyListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.MailGeographyListAsync(auth, request); });
        }

        [Fact]
        public async Task MailSortListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailSortListResponse { MailSortListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.MailSortListAsync(It.IsAny<MailSortListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailSortListRequestBody { InputParameter = new MailSortListInputParameter() };
            var result = await service.MailSortListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task MailSortListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new MailSortListResponse { MailSortListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.MailSortListAsync(It.IsAny<MailSortListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new MailSortListRequestBody { InputParameter = new MailSortListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.MailSortListAsync(auth, request); });
        }

        [Fact]
        public async Task PostOfficeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PostOfficeListResponse { PostOfficeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.PostOfficeListAsync(It.IsAny<PostOfficeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PostOfficeListRequestBody { InputParameter = new PostOfficeListInputParameter() };
            var result = await service.PostOfficeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task PostOfficeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PostOfficeListResponse { PostOfficeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.PostOfficeListAsync(It.IsAny<PostOfficeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PostOfficeListRequestBody { InputParameter = new PostOfficeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.PostOfficeListAsync(auth, request); });
        }

        [Fact]
        public async Task PostageAffixListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PostageAffixListResponse { PostageAffixListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.PostageAffixListAsync(It.IsAny<PostageAffixListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PostageAffixListRequestBody { InputParameter = new PostageAffixListInputParameter() };
            var result = await service.PostageAffixListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task PostageAffixListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PostageAffixListResponse { PostageAffixListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.PostageAffixListAsync(It.IsAny<PostageAffixListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PostageAffixListRequestBody { InputParameter = new PostageAffixListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.PostageAffixListAsync(auth, request); });
        }

        [Fact]
        public async Task PostageStatusListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PostageStatusListResponse { PostageStatusListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.PostageStatusListAsync(It.IsAny<PostageStatusListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PostageStatusListRequestBody { InputParameter = new PostageStatusListInputParameter() };
            var result = await service.PostageStatusListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task PostageStatusListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new PostageStatusListResponse { PostageStatusListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.PostageStatusListAsync(It.IsAny<PostageStatusListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new PostageStatusListRequestBody { InputParameter = new PostageStatusListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.PostageStatusListAsync(auth, request); });
        }

        [Fact]
        public async Task ReasonCodeListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ReasonCodeListResponse { ReasonCodeListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.ReasonCodeListAsync(It.IsAny<ReasonCodeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ReasonCodeListRequestBody { InputParameter = new ReasonCodeListInputParameter() };
            var result = await service.ReasonCodeListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task ReasonCodeListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ReasonCodeListResponse { ReasonCodeListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.ReasonCodeListAsync(It.IsAny<ReasonCodeListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ReasonCodeListRequestBody { InputParameter = new ReasonCodeListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.ReasonCodeListAsync(auth, request); });
        }

        [Fact]
        public async Task RecordResolutionListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RecordResolutionListResponse { RecordResolutionListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.RecordResolutionListAsync(It.IsAny<RecordResolutionListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new RecordResolutionListRequestBody { InputParameter = new RecordResolutionListInputParameter() };
            var result = await service.RecordResolutionListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task RecordResolutionListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new RecordResolutionListResponse { RecordResolutionListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.RecordResolutionListAsync(It.IsAny<RecordResolutionListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new RecordResolutionListRequestBody { InputParameter = new RecordResolutionListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.RecordResolutionListAsync(auth, request); });
        }

        [Fact]
        public async Task ResidualInstructionListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ResidualInstructionListResponse { ResidualInstructionListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.ResidualInstructionListAsync(It.IsAny<ResidualInstructionListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ResidualInstructionListRequestBody { InputParameter = new ResidualInstructionListInputParameter() };
            var result = await service.ResidualInstructionListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task ResidualInstructionListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ResidualInstructionListResponse { ResidualInstructionListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.ResidualInstructionListAsync(It.IsAny<ResidualInstructionListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ResidualInstructionListRequestBody { InputParameter = new ResidualInstructionListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.ResidualInstructionListAsync(auth, request); });
        }

        [Fact]
        public async Task ServiceListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ServiceListResponse { ServiceListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.ServiceListAsync(It.IsAny<ServiceListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ServiceListRequestBody { InputParameter = new ServiceListInputParameter() };
            var result = await service.ServiceListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task ServiceListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new ServiceListResponse { ServiceListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.ServiceListAsync(It.IsAny<ServiceListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new ServiceListRequestBody { InputParameter = new ServiceListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.ServiceListAsync(auth, request); });
        }

        [Fact]
        public async Task UnitMeasureListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new UnitMeasureListResponse { UnitMeasureListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.UnitMeasureListAsync(It.IsAny<UnitMeasureListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new UnitMeasureListRequestBody { InputParameter = new UnitMeasureListInputParameter() };
            var result = await service.UnitMeasureListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task UnitMeasureListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new UnitMeasureListResponse { UnitMeasureListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.UnitMeasureListAsync(It.IsAny<UnitMeasureListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new UnitMeasureListRequestBody { InputParameter = new UnitMeasureListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.UnitMeasureListAsync(auth, request); });
        }

        [Fact]
        public async Task OrderStatusListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderStatusListResponse { OrderStatusListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.OrderStatusListAsync(It.IsAny<OrderStatusListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderStatusListRequestBody { InputParameter = new OrderStatusListInputParameter() };
            var result = await service.OrderStatusListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task OrderStatusListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderStatusListResponse { OrderStatusListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.OrderStatusListAsync(It.IsAny<OrderStatusListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderStatusListRequestBody { InputParameter = new OrderStatusListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.OrderStatusListAsync(auth, request); });
        }

        [Fact]
        public async Task OrderVersionStatusListAsync_ReturnsResult_WhenSuccess()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionStatusListResponse { OrderVersionStatusListResult = "<Result><ReturnCode>0</ReturnCode></Result>" };
            mockSoap.Setup(s => s.OrderVersionStatusListAsync(It.IsAny<OrderVersionStatusListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionStatusListRequestBody { InputParameter = new OrderVersionStatusListInputParameter() };
            var result = await service.OrderVersionStatusListAsync(auth, request);
            Assert.NotNull(result);
            Assert.Equal(0, result.ReturnCode);
        }
        [Fact]
        public async Task OrderVersionStatusListAsync_ThrowsException_WhenReturnCodeIsNotZero()
        {
            var mockSoap = new Mock<Service1Soap>();
            var response = new OrderVersionStatusListResponse { OrderVersionStatusListResult = "<Result><ReturnCode>1</ReturnCode><ReturnErrors><Error>Some error</Error></ReturnErrors></Result>" };
            mockSoap.Setup(s => s.OrderVersionStatusListAsync(It.IsAny<OrderVersionStatusListRequest>())).ReturnsAsync(response);
            var service = new SettingService(mockSoap.Object);
            var auth = new ValidationSoapHeader { DevToken = "test-token" };
            var request = new OrderVersionStatusListRequestBody { InputParameter = new OrderVersionStatusListInputParameter() };
            await Assert.ThrowsAsync<Exception>(async () => { await service.OrderVersionStatusListAsync(auth, request); });
        }
    }
}
