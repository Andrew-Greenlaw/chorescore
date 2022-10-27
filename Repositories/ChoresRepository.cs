namespace chorescore.Repositories;
public class ChoresRepository
{
  private readonly IDbConnection _db;

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }
  public List<Chore> GetChores()
  {
    var sql = "SELECT * FROM chores";
    return _db.Query<Chore>(sql).ToList();
  }
  public Chore GetChore(int id)
  {
    var sql = "SELECT * WHERE chores WHERE id = @id";
    return _db.Query<Chore>(sql, new { id }).FirstOrDefault();
  }
  public Chore AddChore(Chore choreData)
  {
    var sql = @"
    INSERT INTO chores(
      name,importance,completed,day,creatorId
    )
    VALUES{
      @Name,@Importance,@Completed,@Day,@CreatorId
    };
    SELECT LAST_INSERT_ID();
    ";
    choreData.Id = _db.ExecuteScalar<int>(sql, choreData);
    return choreData;
  }
  public string RemoveChore(int id)
  {
    var sql = "DELETE FROM chores WHERE Id = @id";
    _db.Execute(sql, new { id });
    return "You Deleted this Chore!";
  }
  public Chore UpdateChore(int id, Chore choredata)
  {
    choredata.Id = id;
    var sql = @"
    UPDATE chores SET
    name = @Name,
    importance = @Importance,
    completed = @Completed,
    day = @Day,
    creatorId = @creatorId
    WHERE Id = @id;";
    _db.Execute(sql, choredata);
    return choredata;
  }

}