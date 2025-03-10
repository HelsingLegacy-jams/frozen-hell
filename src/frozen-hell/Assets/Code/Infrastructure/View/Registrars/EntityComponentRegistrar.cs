namespace Code.Infrastructure.View.Registrars
{
  public abstract class EntityComponentRegistrar : EntityDependant, IEntityComponentRegistrar
  {
    public abstract void Register();
    public abstract void Unregister();
  }
}