// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright (C) 2023-2025 Pandora Behaviour Engine Contributors

using System.Diagnostics.CodeAnalysis;
using Pandora.API.Patch.Skyrim64.AnimData;

namespace Pandora.API.Patch.Skyrim64;

public interface IProject
{
    IProjectAnimData? AnimData { get; set; }
    IPackFileGraph BehaviorFile { get; }
    IPackFileCharacter CharacterPackFile { get; }
    string Identifier { get; }
    DirectoryInfo? ProjectDirectory { get; }
    IPackFile ProjectFile { get; }
    IProject? Sibling { get; set; }
    IPackFileSkeleton SkeletonFile { get; }
    bool Valid { get; }
    bool ContainsPackFile(string name);
    bool Equals(IProject? other);
    int GetHashCode();
    bool Load(IPackFileCache cache);
    IPackFile LookupPackFile(string name);
    List<string> MapFiles(IPackFileCache cache);
    bool TryLookupPackFile(string name, [NotNullWhen(true)] out IPackFile? packFile);
    bool TryLookupPackFileEx(string name, [NotNullWhen(true)] out IPackFile? packFile);
}
