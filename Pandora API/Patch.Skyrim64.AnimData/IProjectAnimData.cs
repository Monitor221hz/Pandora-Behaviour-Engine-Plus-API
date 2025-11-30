namespace Pandora.API.Patch.Skyrim64.AnimData;

public interface IProjectAnimData
{
    public IProjectAnimDataHeader Header { get; }
    public IMotionData? BoundMotionDataProject { get; set; }
    public IList<IClipDataBlock> Blocks { get; }
    void AddDummyClipData(string clipName);
    int GetLineCount();
    string ToString();
}
