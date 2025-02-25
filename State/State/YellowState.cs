using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State;
public class YellowState: IState
{
    public string PictureName { get; set; } = "luzamarilla";
    public void Handle(StateContext context)
    {
        context.State = new RedState();
    }
}
