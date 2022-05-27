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
            var result = password.HasLengthVerifier();
            Assert.False(result);
        }

        [Fact]
        public void TestTrueLengthVerifier()
        {
            var password = "aaabbbccc";
            var result = password.HasLengthVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestTrueDigitVerifier()
        {
            var password = "aa1bb";
            var result = password.HasDigitVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestFalseDigitVerifier()
        {
            var password = "aaabbbccc";
            var result = password.HasDigitVerifier();
            Assert.False(result);
        }
    }

}