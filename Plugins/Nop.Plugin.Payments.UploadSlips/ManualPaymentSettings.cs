using Nop.Core.Configuration;

namespace Nop.Plugin.Payments.UploadSlips
{
    /// <summary>
    /// Represents settings of UploadSlips payment plugins
    /// </summary>
    public class UploadSlipsPaymentSettings : ISettings
    {
        /// <summary>
        /// Gets or sets payment transaction mode s 
        /// </summary>
        public TransactMode TransactMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to "additional fee" is specified as percentage. true - percentage, false - fixed value.
        /// </summary>
        public bool AdditionalFeePercentage { get; set; }

        /// <summary>
        /// Gets or sets an additional fee
        /// </summary>
        public decimal AdditionalFee { get; set; }
    }
}
