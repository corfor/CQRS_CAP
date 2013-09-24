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
using System.Threading;
using CQRS.Client.AccountServiceReference;

namespace CQRS.Client
{
	public class LoadTestThread
	{
		private static string[] _accounts =
		{
			"1234",
			"2345",
			"3456"
		};

		private Thread _thread;
		private ManualResetEvent _interrupt = new ManualResetEvent(false);

		public LoadTestThread()
		{
			_thread = new Thread(ThreadProc);
			_thread.Name = "Load test thread";
		}

		public void Start()
		{
			_thread.Start();
		}

		public void Interrupt()
		{
			_interrupt.Set();
		}

		private void ThreadProc()
		{
			Random random = new Random();

			while (!_interrupt.WaitOne(100))
			{
				try
				{
					int fromIndex = random.Next(_accounts.Length);
					int toIndex = (fromIndex + random.Next(_accounts.Length - 1) + 1) % _accounts.Length;
					string fromAccount = _accounts[fromIndex];
					string toAccount = _accounts[toIndex];
                    using (AccountServiceClient service = new AccountServiceClient())
                    {
                        service.Transfer(fromAccount, toAccount, 0.01m);
                    }
				}
				catch (Exception ex)
				{
				}
			}
		}
	}
}
