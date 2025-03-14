namespace Code.Gameplay.Features.Survivor.Provider
{
  public class SurvivorProvider : ISurvivorProvider
  {
    private GameEntity _entity;
    public GameEntity Entity => _entity;

    public void SetSurvivor(GameEntity entity) => 
      _entity = entity;
  }
}