using PasswordValidator.Services;
using Xunit;

namespace PasswordValidatorTester
{
    public class PasswordVerifierTester
    {
        private PasswordService _service;
        public PasswordVerifierTester()
        {
            _service = new PasswordService();
        }

        [Fact]
        public void TestNullPasswordService()
        {
            var password = "";
            var result = _service.VerifyPassword(password);
            Assert.False(result);
        }

        [Fact]
        public void TestValidPasswordService()
        {
            var password = "AbTp9!fok";
            var result = _service.VerifyPassword(password);
            Assert.True(result);
        }

        [Fact]
        public void TestWrongPasswordServiceRepetition()
        {
            var password = "AbTp9!foo";
            var result = _service.VerifyPassword(password);
            Assert.False(result);
        }

        [Fact]
        public void TestWrongPasswordServiceRepetition2()
        {
            var password = "AbTp9!foA";
            var result = _service.VerifyPassword(password);
            Assert.False(result);
        }

        [Fact]
        public void TestWrongPasswordServiceRepetition3()
        {
            var password = "AbTp9!foa";
            var result = _service.VerifyPassword(password);
            Assert.False(result);
        }

        [Fact]
        public void TestWrongPasswordServiceSpace()
        {
            var password = "AbTp9 fok";
            var result = _service.VerifyPassword(password);
            Assert.False(result);
        }
    }

}