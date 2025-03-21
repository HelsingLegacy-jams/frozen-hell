//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherOffset;

    public static Entitas.IMatcher<GameEntity> Offset {
        get {
            if (_matcherOffset == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Offset);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherOffset = matcher;
            }

            return _matcherOffset;
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

    public Code.Gameplay.Features.Cameras.Offset offset { get { return (Code.Gameplay.Features.Cameras.Offset)GetComponent(GameComponentsLookup.Offset); } }
    public float Offset { get { return offset.Value; } }
    public bool hasOffset { get { return HasComponent(GameComponentsLookup.Offset); } }

    public GameEntity AddOffset(float newValue) {
        var index = GameComponentsLookup.Offset;
        var component = (Code.Gameplay.Features.Cameras.Offset)CreateComponent(index, typeof(Code.Gameplay.Features.Cameras.Offset));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceOffset(float newValue) {
        var index = GameComponentsLookup.Offset;
        var component = (Code.Gameplay.Features.Cameras.Offset)CreateComponent(index, typeof(Code.Gameplay.Features.Cameras.Offset));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveOffset() {
        RemoveComponent(GameComponentsLookup.Offset);
        return this;
    }
}
