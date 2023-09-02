namespace OTP
{
    public class OTPVerifier
    {
        // Method to verify the OTP entered by the user
        public static bool VerifyOTP(string userEnteredOTP, string generatedOTP)
        {
            return userEnteredOTP == generatedOTP;
        }
    }
}
