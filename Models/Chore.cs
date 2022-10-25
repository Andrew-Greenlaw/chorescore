using chorescore.Enums;
namespace chorescore.Models;
public class Chore
{
  public string Id { get; private set; }
  public string Name { get; private set; }
  public int Importance { get; private set; }
  public bool Completed { get; private set; }
  public ChoreDay Day { get; private set; }

  public Chore(string name, int importance, bool completed, ChoreDay day)
  {
    Id = Guid.NewGuid().ToString();
    Name = name;
    Importance = importance;
    Completed = completed;
    Day = day;
  }
  public void EditChore(string name, int importance, bool completed, ChoreDay day)
  {
    Name = name;
    Importance = importance;
    Completed = completed;
    Day = day;
  }
}