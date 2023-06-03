namespace Singleton.No_Thread_Safe_Singleton
{
    public class SingletonDemo1
    {
        private SingletonDemo1() { }
        private static SingletonDemo1 instance = null;
        public static SingletonDemo1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonDemo1();
                }
                return instance;
            }
        }
    }
}
