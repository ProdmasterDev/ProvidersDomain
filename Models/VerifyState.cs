using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Models
{
    /// <summary>
    /// Verify states
    /// </summary>
    public enum VerifyState
    {
        /// <summary>
        /// Verified
        /// </summary>
        Verified,
        /// <summary>
        /// Sended
        /// </summary>
        Sended,
        /// <summary>
        /// Not verified
        /// </summary>
        NotVerified,
        /// <summary>
        /// Not sended
        /// </summary>
        NotSended,
        /// <summary>
        /// Corrected
        /// </summary>
        Corrected,
        /// <summary>
        /// Draft
        /// </summary>
        Draft,
    }
}
