using System;

namespace Aliencube.Otp.Services
{
    /// <summary>
    /// This provides interfaces to the <see cref="OtpController"/> class.
    /// </summary>
    public interface IOtpController : IDisposable
    {
        /// <summary>
        /// Generates OTP code and send it.
        /// </summary>
        void Generate();

        /// <summary>
        /// Validates the OTP code generated.
        /// </summary>
        void Validate();

        /// <summary>
        /// Authenticate the request.
        /// </summary>
        /// <returns></returns>
        bool Authenticate();

        /// <summary>
        /// Populates the OTP code.
        /// </summary>
        /// <returns></returns>
        string PopulateCode();

        /// <summary>
        /// Saves the code populated.
        /// </summary>
        void SaveCode();

        /// <summary>
        /// Sends the OTP code populated.
        /// </summary>
        void SendCode();

        /// <summary>
        /// Verifies the code.
        /// </summary>
        /// <returns></returns>
        bool VerifyCode();

        /// <summary>
        /// Deletes the code verified.
        /// </summary>
        void DeleteCode();
    }
}