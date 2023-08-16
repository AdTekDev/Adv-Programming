
public abstract class ACommand {
    protected AReceiver receiver;
    public ACommand(AReceiver receiver) {
        this.receiver = receiver;
    }
    public abstract void Execute();

}