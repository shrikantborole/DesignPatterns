namespace Singleton.Thread_Safety_Singleton_using_Double_Check_Locking
{
    public class SingletonDemo3
    {
        private SingletonDemo3() { }
        private static readonly object demo = new object();
        private static SingletonDemo3 instance = null;
        public static SingletonDemo3 Instance
        {
            get
            {
                //the thread is locked on a shared object and checks whether an instance
                //has been created or not with double checking.
                if (instance == null)
                {
                    lock (demo)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonDemo3();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
