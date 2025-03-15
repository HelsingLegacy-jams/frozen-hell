namespace Code.Infrastructure.View.Registrars
{
  public interface IEntityComponentRegistrar
  {
    void Register();
    void Unregister();
  }
}