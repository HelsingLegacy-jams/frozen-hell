namespace Code.Gameplay.Features.Survivor.Provider
{
  public interface ISurvivorProvider
  {
    GameEntity Entity { get; }
    void SetSurvivor(GameEntity entity);
  }
}