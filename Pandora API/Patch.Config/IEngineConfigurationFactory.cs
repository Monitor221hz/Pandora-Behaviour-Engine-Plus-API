using Pandora.API.Patch.Engine.Config;

namespace Pandora.API.Patch.Config;

public interface IEngineConfigurationFactory
{
    public string Name { get; }
    public IEngineConfiguration? Config { get; }
    public bool Selectable => Config != null;
}
