//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPopupView;

    public static Entitas.IMatcher<GameEntity> PopupView {
        get {
            if (_matcherPopupView == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PopupView);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPopupView = matcher;
            }

            return _matcherPopupView;
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

    public Code.Gameplay.Features.Popups.PopupViewComponent popupView { get { return (Code.Gameplay.Features.Popups.PopupViewComponent)GetComponent(GameComponentsLookup.PopupView); } }
    public Code.Gameplay.Features.Popups.Behaviours.PopupView PopupView { get { return popupView.Value; } }
    public bool hasPopupView { get { return HasComponent(GameComponentsLookup.PopupView); } }

    public GameEntity AddPopupView(Code.Gameplay.Features.Popups.Behaviours.PopupView newValue) {
        var index = GameComponentsLookup.PopupView;
        var component = (Code.Gameplay.Features.Popups.PopupViewComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Popups.PopupViewComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplacePopupView(Code.Gameplay.Features.Popups.Behaviours.PopupView newValue) {
        var index = GameComponentsLookup.PopupView;
        var component = (Code.Gameplay.Features.Popups.PopupViewComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Popups.PopupViewComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemovePopupView() {
        RemoveComponent(GameComponentsLookup.PopupView);
        return this;
    }
}
