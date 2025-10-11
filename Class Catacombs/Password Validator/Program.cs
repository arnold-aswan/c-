
// Rules
// 1. > 6 & <13
// 2. must contain at least 1 Uppercase, lowercase, number
// 3. must not have T | & 


namespace Password_Validator
{
    class PasswordValidator
    {
        // properties
        private string Password { get; set; }
        
        // constructor
        public PasswordValidator()
        {
            SetPassword();
        }
        // methods
        private void SetPassword()
        {
           do
            {
               Console.WriteLine("Please enter a valid password");
               string password =  Console.ReadLine();
               Password = password;
               
               if (ValidatePassword(password))
                   Console.WriteLine("Valid password ✅");
               else
                   Console.WriteLine("Invalid password ❌");
            }
            while (true);
        }

        // static methods
        private static bool ValidatePassword(string password)
        {
            return ValidatePasswordLength(password.Trim())
                && DoesNotHasAmpersand(password.Trim())
                && DoesNotHasLetterT(password.Trim())
                && HasRequiredCharacters(password.Trim());
        }
        private static bool ValidatePasswordLength(string password) => password.Length >= 6 && password.Length <= 13;
        private static bool DoesNotHasAmpersand(string password) => !password.Contains('&');
        private static bool DoesNotHasLetterT(string password) => !password.Contains('T');
        private static bool HasRequiredCharacters(string password)
        {
            bool hasUpperChars = false,  hasLowerChars = false, hasNumbers = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperChars = true;
                else if (char.IsLower(c)) hasLowerChars = true;
                else if (char.IsDigit(c)) hasNumbers = true;

                if (hasUpperChars && hasLowerChars && hasNumbers)
                    return true;
            }
            return false;
        }
        
    }

    class Program
    {
        public static void Main()
        {
            PasswordValidator passcode = new PasswordValidator();
        }
    }
};

