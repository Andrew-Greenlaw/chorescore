using chorescore.Enums;

namespace chorescore.Data;

public class FakeDb
{
  public List<Chore> Chores = new List<Chore>()
  {
    new Chore("Do The Dishes 📡", 5,false, ChoreDay.Monday)
  };
}