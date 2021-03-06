﻿/**********************************************************************
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

using System.ServiceModel;

namespace CQRS.Service
{
    [ServiceContract]
    public interface IAccountService
    {
        [OperationContract]
        decimal GetAccountBalance(string account);

        [OperationContract]
        void Transfer(string fromAccount, string toAccount, decimal amount);
    }
}
