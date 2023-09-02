
using System;
using System.Linq;

namespace OTP
{
    
        
public class OTPGenerator
    {
        private static readonly Random random = new Random();

        // Generate a random numeric OTP of specified length
        public static string GenerateOTP(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

