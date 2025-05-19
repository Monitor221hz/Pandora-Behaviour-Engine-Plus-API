namespace Pandora.API.Patch.Engine.Skyrim64;

public interface ISkyrim64Patch
{
	public RuntimeMode Mode { get; }
	public RunOrder Order { get; }
	public void Run(IProjectManager projectManager);
}
