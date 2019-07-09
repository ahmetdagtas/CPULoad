using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CPULoad
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 50; i++)
			{
				Test t = new Test();
				t.CreateThread();
			}
		}

		private class Test
		{
			public void CreateThread()
			{
				new Thread(Write) { }.Start();
			}

			private void Write()
			{
				for (long i = 0; i < long.MaxValue; i++)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
