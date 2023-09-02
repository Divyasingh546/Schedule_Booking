using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OTP.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class OTPController : ControllerBase
    {
        // POST api/otp/generate
        [HttpPost("generate")]
        public ActionResult<string> GenerateOTP()
        {
            // Generate a 6-digit OTP
            string generatedOTP = OTPGenerator.GenerateOTP(6);

            // In a real application, you would send the OTP to the user through SMS or email
            // For simplicity, we return the generated OTP in the response.
            return generatedOTP;
        }

        // POST api/otp/verify
        [HttpPost("verify")]
        public ActionResult<bool> VerifyOTP([FromForm] string userEnteredOTP, [FromForm] string generatedOTP)
        {
            // Verify the user-provided OTP
            bool isValid = OTPVerifier.VerifyOTP(userEnteredOTP, generatedOTP);
            return isValid;
        }
    }

}
