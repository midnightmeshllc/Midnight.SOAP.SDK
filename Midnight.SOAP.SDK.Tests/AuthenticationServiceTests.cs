using MidnightAPI;
using Moq;

namespace Midnight.SOAP.SDK.Tests
{
    public class AuthenticationServiceTests
    {
        [Fact]
        public async Task AuthenticateAsync_ReturnsValidationSoapHeader_WithCorrectDevToken()
        {
            // Arrange
            var mockSoap = new Mock<Service1Soap>();
            mockSoap
                .Setup(s => s._GetWebServiceVersionAsync())
                .ReturnsAsync("1.0.0");

            var service = new AuthenticationService(mockSoap.Object);
            var devToken = "test-token";

            // Act
            var result = await service.AuthenticateAsync(devToken);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(devToken, result.DevToken);
        }
    }
}