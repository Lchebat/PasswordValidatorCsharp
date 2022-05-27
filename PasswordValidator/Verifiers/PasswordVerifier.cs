namespace PasswordValidator.Verifiers
{
    public static class PasswordVerifier
    {

        public static bool LengthVerifier(this string password)
        {
            if (password.Length >= 9) return true;
            return false;
        }

        public static bool DigitVerifier(this string password)
        {
            return false;
        }
        public static bool UppercaseVerifier(this string password)
        {
            return false;
        }
        public static bool LowercaseVerifier(this string password)
        {
            return false;
        }
        public static bool SpecialCharVerifier(this string password)
        {
            return false;
        }

        public static bool CharRepetitionVerifier(this string password)
        {
            return false;
        }
    }
}
