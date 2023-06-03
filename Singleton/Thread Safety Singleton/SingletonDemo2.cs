using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Thread_Safety_Singleton
{
    public class SingletonDemo2
    {
        private SingletonDemo2()
        {

        }
        private static readonly object demo = new object();
        private static SingletonDemo2 instance = null;
        public static SingletonDemo2 Instance
        {
            get
            {
                //The biggest problem with this is performance; performance suffers since a
                //lock is required every time an instance is requested
                lock (demo)
                {
                    if (instance == null)
                    {
                        instance = new SingletonDemo2();
                    }
                    return instance;
                }
            }
        }
    }
}
