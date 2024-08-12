using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesginPattern
{
    public class SingeltonClass
    {
        private static SingeltonClass? _instance;

        public static SingeltonClass Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new SingeltonClass();
                }
                return _instance;

            }

        }

        private SingeltonClass()
        {

        }
    }

    public class ThreadSafeSingeltonClass
    {
        private static readonly Lazy<ThreadSafeSingeltonClass>? _lazyInstance = new Lazy<ThreadSafeSingeltonClass>(()=>new ThreadSafeSingeltonClass());

        public static ThreadSafeSingeltonClass Instance
        {

            get
            {
                 return _lazyInstance.Value;

            }

        }

        private ThreadSafeSingeltonClass()
        {

        }
    }

}
