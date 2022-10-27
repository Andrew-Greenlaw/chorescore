using chorescore.Enums;
namespace chorescore.Models;
public class Chore
{
  public int Id { get; set; }
  public string createdAt { get; set; }
  public string updatedAt { get; set; }
  public string Name { get; set; }
  public int Importance { get; set; }
  public bool Completed { get; set; }
  public ChoreDay Day { get; set; }
  public string creatorId { get; set; }


  // public void EditChore(string name, int importance, bool completed, ChoreDay day)
  // {
  //   Name = name;
  //   Importance = importance;
  //   Completed = completed;
  //   Day = day;
  // }
}