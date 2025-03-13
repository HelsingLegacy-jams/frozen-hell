//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherIncrement;

    public static Entitas.IMatcher<GameEntity> Increment {
        get {
            if (_matcherIncrement == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Increment);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherIncrement = matcher;
            }

            return _matcherIncrement;
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

    public Code.Gameplay.Features.Statuses.Increment increment { get { return (Code.Gameplay.Features.Statuses.Increment)GetComponent(GameComponentsLookup.Increment); } }
    public float Increment { get { return increment.Value; } }
    public bool hasIncrement { get { return HasComponent(GameComponentsLookup.Increment); } }

    public GameEntity AddIncrement(float newValue) {
        var index = GameComponentsLookup.Increment;
        var component = (Code.Gameplay.Features.Statuses.Increment)CreateComponent(index, typeof(Code.Gameplay.Features.Statuses.Increment));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceIncrement(float newValue) {
        var index = GameComponentsLookup.Increment;
        var component = (Code.Gameplay.Features.Statuses.Increment)CreateComponent(index, typeof(Code.Gameplay.Features.Statuses.Increment));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveIncrement() {
        RemoveComponent(GameComponentsLookup.Increment);
        return this;
    }
}
