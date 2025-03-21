//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCharacterMover;

    public static Entitas.IMatcher<GameEntity> CharacterMover {
        get {
            if (_matcherCharacterMover == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CharacterMover);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCharacterMover = matcher;
            }

            return _matcherCharacterMover;
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

    public Code.Gameplay.Features.Movement.CharacterMoverComponent characterMover { get { return (Code.Gameplay.Features.Movement.CharacterMoverComponent)GetComponent(GameComponentsLookup.CharacterMover); } }
    public Code.Gameplay.Features.Movement.Behaviours.ICharacterMover CharacterMover { get { return characterMover.Value; } }
    public bool hasCharacterMover { get { return HasComponent(GameComponentsLookup.CharacterMover); } }

    public GameEntity AddCharacterMover(Code.Gameplay.Features.Movement.Behaviours.ICharacterMover newValue) {
        var index = GameComponentsLookup.CharacterMover;
        var component = (Code.Gameplay.Features.Movement.CharacterMoverComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.CharacterMoverComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceCharacterMover(Code.Gameplay.Features.Movement.Behaviours.ICharacterMover newValue) {
        var index = GameComponentsLookup.CharacterMover;
        var component = (Code.Gameplay.Features.Movement.CharacterMoverComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.CharacterMoverComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveCharacterMover() {
        RemoveComponent(GameComponentsLookup.CharacterMover);
        return this;
    }
}
