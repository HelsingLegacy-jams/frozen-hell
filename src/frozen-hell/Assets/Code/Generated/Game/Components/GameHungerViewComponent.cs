//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHungerView;

    public static Entitas.IMatcher<GameEntity> HungerView {
        get {
            if (_matcherHungerView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HungerView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHungerView = matcher;
            }

            return _matcherHungerView;
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

    public Code.Gameplay.Features.Statuses.HungerView hungerView { get { return (Code.Gameplay.Features.Statuses.HungerView)GetComponent(GameComponentsLookup.HungerView); } }
    public Code.Gameplay.Features.Statuses.Behaviours.IStatusView HungerView { get { return hungerView.Value; } }
    public bool hasHungerView { get { return HasComponent(GameComponentsLookup.HungerView); } }

    public GameEntity AddHungerView(Code.Gameplay.Features.Statuses.Behaviours.IStatusView newValue) {
        var index = GameComponentsLookup.HungerView;
        var component = (Code.Gameplay.Features.Statuses.HungerView)CreateComponent(index, typeof(Code.Gameplay.Features.Statuses.HungerView));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceHungerView(Code.Gameplay.Features.Statuses.Behaviours.IStatusView newValue) {
        var index = GameComponentsLookup.HungerView;
        var component = (Code.Gameplay.Features.Statuses.HungerView)CreateComponent(index, typeof(Code.Gameplay.Features.Statuses.HungerView));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveHungerView() {
        RemoveComponent(GameComponentsLookup.HungerView);
        return this;
    }
}
