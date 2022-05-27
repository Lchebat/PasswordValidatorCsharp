namespace PasswordValidator.Verifiers
{
    public static class CharVerifier
    {
        public static bool HasSpecialChar(this char value)
        {
            if( value == '!' || value == '@' || 
                value == '#' || value == '$' || 
                value == '%' || value == '^' || 
                value == '&' || value == '*' || 
                value == '(' || value == ')' || 
                value == '-' || value == '+')
            {
                return true;
            }
            return false;
        }
    }
}
