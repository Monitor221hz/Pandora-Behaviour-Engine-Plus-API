namespace Pandora.API.Patch.Engine.Skyrim64.AnimData;

public interface IProjectAnimData
{
    public IProjectAnimDataHeader GetHeader();

    public IMotionData? GetBoundMotionData();
    public IList<IClipDataBlock> GetBlocks();
    void AddDummyClipData(string clipName);
    int GetLineCount();
    string ToString();
}
