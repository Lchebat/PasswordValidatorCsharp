
using PasswordValidator.Verifiers;
using Xunit;

namespace PasswordValidatorTester
{
    public class StringVerifierTester
    {
        [Fact]
        public void TestLengthVerifier()
        {
            var password = "aaabbbccc";
            var result = password.HasLengthVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestDigitVerifier()
        {
            var password = "aa1bb";
            var result = password.HasDigitVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestUppercaseVerifier()
        {
            var password = "aaaBbbccc";
            var result = password.HasUppercaseVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestLowercaseVerifier()
        {
            var password = "AAABBBCcC";
            var result = password.HasLowercaseVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestSpecialCharVerifier()
        {
            var password = "AAAB+BCCC";
            var result = password.HasSpecialCharVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestCharRepetitionVerifier()
        {
            var password = "AaBcA";
            var result = password.HasCharRepetitionVerifier();
            Assert.True(result);
        }

        [Fact]
        public void TestSpaceVerifier()
        {
            var password = "Aa BcA";
            var result = password.HasSpaceVerifier();
            Assert.True(result);
        }
    }
}
