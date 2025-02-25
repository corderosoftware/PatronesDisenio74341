using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State;
public class RedState : IState
{
    public string PictureName { get; set; } = "luzroja";

    public void Handle(StateContext context)
    {
        context.State = new GreenState();
    }
}
