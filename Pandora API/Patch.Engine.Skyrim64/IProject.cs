namespace Pandora.API.Patch.Engine.Skyrim64;

public interface IProject
{
    public string Identifier { get; }

    public IPackFile GetProjectPackFile();
    public IPackFileCharacter GetCharacterPackFile();
    public IPackFileSkeleton GetSkeletonPackFile();
    public IPackFileGraph GetBehaviorPackFile();
    public IProject GetSibling();

    public bool TryLookupPackFileEx(string name, out IPackFile? packFile);

    public bool ContainsPackFile(string name);
}
