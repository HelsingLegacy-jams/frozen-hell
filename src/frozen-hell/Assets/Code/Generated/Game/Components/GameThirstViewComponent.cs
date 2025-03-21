//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherThirstView;

    public static Entitas.IMatcher<GameEntity> ThirstView {
        get {
            if (_matcherThirstView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ThirstView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherThirstView = matcher;
            }

            return _matcherThirstView;
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

    public Code.Gameplay.Features.Statuses.ThirstView thirstView { get { return (Code.Gameplay.Features.Statuses.ThirstView)GetComponent(GameComponentsLookup.ThirstView); } }
    public Code.Gameplay.Features.Statuses.Behaviours.IStatusView ThirstView { get { return thirstView.Value; } }
    public bool hasThirstView { get { return HasComponent(GameComponentsLookup.ThirstView); } }

    public GameEntity AddThirstView(Code.Gameplay.Features.Statuses.Behaviours.IStatusView newValue) {
        var index = GameComponentsLookup.ThirstView;
        var component = (Code.Gameplay.Features.Statuses.ThirstView)CreateComponent(index, typeof(Code.Gameplay.Features.Statuses.ThirstView));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceThirstView(Code.Gameplay.Features.Statuses.Behaviours.IStatusView newValue) {
        var index = GameComponentsLookup.ThirstView;
        var component = (Code.Gameplay.Features.Statuses.ThirstView)CreateComponent(index, typeof(Code.Gameplay.Features.Statuses.ThirstView));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveThirstView() {
        RemoveComponent(GameComponentsLookup.ThirstView);
        return this;
    }
}
