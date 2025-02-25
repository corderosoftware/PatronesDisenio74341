using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface IState
    {
        string PictureName { get; set; }
        void Handle(StateContext context);
    }
}
