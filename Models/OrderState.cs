using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvidersDomain.Models
{
    public enum OrderState
    {
        New,
        ConfirmedByProvider,
        DeclinedByProvider,
        ApprovedConfirmationByProvider,
        ApprovedDeclineByProvider,
        DeclinedByRecipient,
        EditedByProvider,
    }
}
