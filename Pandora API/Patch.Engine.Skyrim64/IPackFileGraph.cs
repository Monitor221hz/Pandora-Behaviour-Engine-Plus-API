using HKX2E;

namespace Pandora.API.Patch.Engine.Skyrim64;

public interface IPackFileGraph
{
    public hkbBehaviorGraphData Data { get; }
    public hkbBehaviorGraphStringData StringData { get; }
    public hkbVariableValueSet VariableValueSet { get; }
}
