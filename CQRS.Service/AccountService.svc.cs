/**********************************************************************
 * 
 * The CAP Theorem and its Implications
 * 
 * Michael L Perry
 * http://qedcode.com
 * 
 * Copyright 2010
 * Creative Commons Attribution 3.0
 * 
 **********************************************************************/

using System;
using System.Linq;
using System.Transactions;
using System.ServiceModel;

namespace CQRS.Service
{
    public class AccountService : ServiceBase, IAccountService
    {
        private const string IncreaseQueueName = @".\Private$\cqrs_increase";
        private const string DecreaseQueueName = @".\Private$\cqrs_decrease";

        public decimal GetAccountBalance(string account)
        {
            try
            {
                using (CAP_CQRSEntities entities = new CAP_CQRSEntities())
                {
                    AccountBalance entity = GetAccountEntity(account, entities);
                    return entity.Balance;
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        public void Transfer(string fromAccount, string toAccount, decimal amount)
        {
            try
            {
                using (CAP_CQRSEntities entities = new CAP_CQRSEntities())
                {
                    using (var tx = new TransactionScope())
                    {
                        AccountBalance from = GetAccountEntity(fromAccount, entities);

                        if (from.Balance < amount)
                            throw new ApplicationException("Insufficient funds.");

                        // INSERT
                        entities.AddToTransfers(new Transfer()
                        {
                            From = fromAccount,
                            To = toAccount,
                            Amount = amount
                        });

                        from.Balance -= amount;
                        AccountBalance to = GetAccountEntity(toAccount, entities);
                        to.Balance += amount;

                        entities.SaveChanges();
                        tx.Complete();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }
    }
}
