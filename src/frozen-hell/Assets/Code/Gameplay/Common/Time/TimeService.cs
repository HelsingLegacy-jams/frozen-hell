namespace Code.Gameplay.Common.Time
{
  public class TimeService : ITimeService
  {
    private bool _paused;
    
    public float DeltaTime => !_paused ? UnityEngine.Time.deltaTime : 0f;
    public void StopTime()=> _paused = true;
    public void StartTime()=> _paused = false;
  }
}