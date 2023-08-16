
public class Invoker {
    private ACommand  command;
    public Invoker(ACommand command) {
        this.command = command;
    }
    public void setCommand(ACommand command) {
        this.command = command;
    }
    public void executeCommand() {
        command.Execute();
    }


}