//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherReadyToResetCold;

    public static Entitas.IMatcher<GameEntity> ReadyToResetCold {
        get {
            if (_matcherReadyToResetCold == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ReadyToResetCold);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherReadyToResetCold = matcher;
            }

            return _matcherReadyToResetCold;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.Gameplay.Features.Statuses.ReadyToResetCold readyToResetColdComponent = new Code.Gameplay.Features.Statuses.ReadyToResetCold();

    public bool isReadyToResetCold {
        get { return HasComponent(GameComponentsLookup.ReadyToResetCold); }
        set {
            if (value != isReadyToResetCold) {
                var index = GameComponentsLookup.ReadyToResetCold;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : readyToResetColdComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
