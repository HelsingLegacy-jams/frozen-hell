namespace Code.Gameplay.Features.Statuses.Behaviours
{
  public interface IStatusView
  {
    float ViewCondition { get; }
    void Updating(float condition);
    void Refresh();
  }
}