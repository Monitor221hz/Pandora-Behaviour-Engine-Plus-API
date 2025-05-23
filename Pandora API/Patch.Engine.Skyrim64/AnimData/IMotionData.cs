using System.Diagnostics.CodeAnalysis;

namespace Pandora.API.Patch.Engine.Skyrim64.AnimData;

public interface IMotionData
{
	void AddDummyClipMotionData(string id);
	IList<IClipMotionDataBlock> GetBlocks();
	int GetLineCount();
	string ToString();
	bool TryGetBlock(int id, [NotNullWhen(true)] out IClipMotionDataBlock? block);
}
