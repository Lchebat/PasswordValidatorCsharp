using PasswordValidator.Interfaces;
using PasswordValidator.Verifiers;

namespace PasswordValidator.Services
{
    public class PasswordService : IPasswordService
    {
        public PasswordService()
        {
        }

        public bool VerifyPassword(string password)
        {
            if( password.HasLengthVerifier() &&
                password.HasDigitVerifier() &&
                password.HasUppercaseVerifier() &&
                password.HasLowercaseVerifier() &&
                password.HasSpecialCharVerifier() &&
                !password.HasCharRepetitionVerifier() &&
                !password.HasSpaceVerifier())
            {
                return true;
            }
            return false;
        }

    }
}
