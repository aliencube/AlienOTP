namespace Aliencube.Otp.Services
{
    /// <summary>
    /// This represents the controller entity for OTP processing.
    /// </summary>
    public class OtpController : IOtpController
    {
        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="OtpController"/> class.
        /// </summary>
        public OtpController()
        {
        }


        /// <summary>
        /// Generates OTP code and send it.
        /// </summary>
        public void Generate()
        {
            this.Authenticate();
            this.PopulateCode();
            this.SaveCode();
            this.SendCode();
        }

        /// <summary>
        /// Validates the OTP code generated.
        /// </summary>
        public void Validate()
        {
            this.Authenticate();
            this.VerifyCode();
            this.DeleteCode();
        }

        /// <summary>
        /// Authenticate the request.
        /// </summary>
        /// <returns></returns>
        public bool Authenticate()
        {
            return true;
        }

        /// <summary>
        /// Populates the OTP code.
        /// </summary>
        /// <returns></returns>
        public string PopulateCode()
        {
            return null;
        }

        /// <summary>
        /// Saves the code populated.
        /// </summary>
        public void SaveCode()
        {
        }

        /// <summary>
        /// Sends the OTP code populated.
        /// </summary>
        public void SendCode()
        {
        }

        /// <summary>
        /// Verifies the code.
        /// </summary>
        /// <returns></returns>
        public bool VerifyCode()
        {
            return true;
        }

        /// <summary>
        /// Deletes the code verified.
        /// </summary>
        public void DeleteCode()
        {
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;
        }
    }
}
