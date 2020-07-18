using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Statics
{
    public static class InputStatic
    {
        private static InputMaster _inputs;
        public static InputMaster Inputs
        {
            get
            {
                if (_inputs == null)
                    _inputs = new InputMaster();

                return _inputs;
            }
        }
    }
}
