namespace chorescore.Services;

public class ChoresService
{
  private readonly FakeDb _db;

  public ChoresService(FakeDb db)
  {
    _db = db;
  }

  public List<Chore> GetChores()
  {
    return _db.Chores;
  }

  public Chore GetChore(string id)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    return chore;
  }

  public Chore AddChore(Chore choreData)
  {
    _db.Chores.Add(choreData);
    return choreData;
  }

  public Chore RemoveChore(string id)
  {
    var chore = GetChore(id);
    _db.Chores.Remove(chore);
    return chore;
  }

  public Chore EditChore(string id, Chore choreData)
  {
    var chore = _db.Chores.Find(c => c.Id == id);
    return chore;
  }
}