using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State;

public class GreenState : IState
{
    public string PictureName { get; set; } = "luzverde";

    public void Handle(StateContext context)
    {
        context.State = new YellowState();
    }
}
