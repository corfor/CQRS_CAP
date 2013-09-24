using System;
using System.Linq;

namespace CQRS.Service
{
    public class ServiceBase
    {
        protected static AccountBalance GetAccountEntity(string account, CAP_CQRSEntities entities)
        {
            IQueryable<AccountBalance> query =
                from b in entities.AccountBalances
                where b.Account == account
                select b;
            AccountBalance entity = query.FirstOrDefault();
            if (entity == null)
                throw new ApplicationException("No such account.");
            return entity;
        }
    }
}
