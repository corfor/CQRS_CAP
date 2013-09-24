using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CQRS.Client.AccountServiceReference;

namespace CQRS.Client
{
    public static class ServiceAgent
    {
        public static void Transfer(string fromAccount, string toAccount, decimal transferAmount)
        {
            using (AccountServiceClient service = new AccountServiceClient())
            {
                service.Transfer(fromAccount, toAccount, transferAmount);
            }
        }

        public static decimal GetAccountBalance(string account)
        {
            using (AccountServiceClient service = new AccountServiceClient())
            {
                return service.GetAccountBalance(account);
            }
        }
    }
}
