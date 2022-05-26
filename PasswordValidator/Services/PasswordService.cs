using PasswordValidator.Verifiers;

namespace PasswordValidator.Services
{
    public class PasswordService
    {
        public PasswordService()
        {
        }

        public bool VerifyPassword(string password)
        {
            return password.LengthVerifier();
        }

    }
}
