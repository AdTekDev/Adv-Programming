
using System;

public class OnlineBuyCommand : ACommand {

    public OnlineBuyCommand(AReceiver receiver)
     : base(receiver) {}
    public override void Execute()
    {
        Console.WriteLine("Dat mua hang .... ");
        receiver.Action();
    }
}