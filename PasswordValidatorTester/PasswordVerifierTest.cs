using PasswordValidator.Verifiers;
using Xunit;

namespace PasswordValidatorTester
{
    public class PasswordVerifierTest
    {
        [Fact]
        public void TestFalseLengthVerifier()
        {
            var password = "aaa";
            var result = password.LengthVerifier();
            Assert.False(result);
        }

        [Fact]
        public void TestTrueLengthVerifier()
        {
            var password = "aaabbbccc";
            var result = password.LengthVerifier();
            Assert.True(result);
        }
    }

}