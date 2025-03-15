using Code.Infrastructure.View.Registrars;

namespace Code.Gameplay.Common.Registrars
{
  public class TransformRegistrar : EntityComponentRegistrar
  {
    public override void Register() => 
      Entity.AddTransform(transform);

    public override void Unregister()
    {
      if (Entity.hasTransform)
        Entity.RemoveTransform();
    }
  }
}