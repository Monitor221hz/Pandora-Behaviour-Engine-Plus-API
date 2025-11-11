using HKX2E;

namespace Pandora.API.Patch.Engine.Skyrim64;

public interface IPackFileCharacter
{
    string BehaviorFileName { get; }
    hkbCharacterData Data { get; set; }
    uint InitialAnimationCount { get; }
    uint NewAnimationCount { get; }
    string SkeletonFileName { get; }
    hkbCharacterStringData StringData { get; set; }
    public bool AddUniqueAnimation(string name);
}
