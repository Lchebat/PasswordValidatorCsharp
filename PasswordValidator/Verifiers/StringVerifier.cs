

namespace PasswordValidator.Verifiers
{
    public static class StringVerifier
    {

        public static bool HasLengthVerifier(this string password)
        {
            if (password.Length >= 9) return true;
            return false;
        }

        public static bool HasDigitVerifier(this string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasUppercaseVerifier(this string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasLowercaseVerifier(this string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool HasSpecialCharVerifier(this string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i].HasSpecialChar())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool HasCharRepetitionVerifier(this string password)
        {

            //Maiúscula e minúscula contam?

            // password.ToUpper();

            for (int i = 0; i < password.Length; i++)
            {
                var value = password[i];
                for (int j = 0; j < password.Length; j++)
                {
                    if (i != j)
                    {
                        if(value == password[j])
                            return true;
;                    }
                }
            }
            return false;
        }

        public static bool HasSpaceVerifier(this string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsWhiteSpace(password[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
