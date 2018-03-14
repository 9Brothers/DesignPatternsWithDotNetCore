namespace DesignPatterns.Shared.Patterns.Command {
  public interface ICommand {
    void Execute();
    void Undo();
  }
}