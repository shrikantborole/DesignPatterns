namespace Singleton
{
	public class SingletonDemo
	{
		private static readonly Lazy<SingletonDemo> _instance = new Lazy<SingletonDemo>(() => new SingletonDemo());
		private SingletonDemo()
		{

		}

		public static SingletonDemo Instance
		{
			get
			{
                //This is thread safe also.
                return _instance.Value;
			}
		}

		public void Logger()
		{
			Console.WriteLine("Logger Called");
		}
	}
}
