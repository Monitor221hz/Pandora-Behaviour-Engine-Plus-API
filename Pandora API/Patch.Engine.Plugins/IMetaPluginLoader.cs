using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Pandora.API.Patch.Engine.Plugins;

namespace Pandora.Models.Patch.Engine.Plugins;

public interface IMetaPluginLoader
{
    Assembly LoadPlugin(DirectoryInfo directory, IPluginInfo pluginInfo);

    bool TryLoadMetadata(DirectoryInfo directory, [NotNullWhen(true)] out IPluginInfo? pluginInfo);
}
