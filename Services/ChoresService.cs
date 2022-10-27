namespace chorescore.Services;

public class ChoresService
{
  private readonly ChoresRepository _choresRepo;

  public ChoresService(ChoresRepository choresRepo)
  {
    _choresRepo = choresRepo;
  }

  public List<Chore> GetChores()
  {
    return _choresRepo.GetChores();
  }

  public Chore GetChore(int id)
  {
    var chore = _choresRepo.GetChore(id);
    if (chore == null)
    {
      throw new Exception("Invalid Id");
    }
    return chore;
  }

  public Chore AddChore(Chore choreData)
  {
    _choresRepo.AddChore(choreData);
    return choreData;
  }

  public string RemoveChore(int id)
  {
    return _choresRepo.RemoveChore(id);
  }

  public Chore EditChore(int id, Chore choreData)
  {
    var chore = _choresRepo.UpdateChore(id, choreData);
    return chore;
  }
}