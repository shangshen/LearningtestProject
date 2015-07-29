using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.UI
{
    public class Entrytest
    {
        private string name;
        private int old;

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       
        /// <summary>
        /// 年龄
        /// </summary>
        public int Old
        {
            get { return old; }
            set { old = value; }
        }
    }
}
