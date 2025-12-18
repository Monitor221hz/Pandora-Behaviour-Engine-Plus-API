// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright (C) 2023-2025 Pandora Behaviour Engine Contributors

using Pandora.API.Patch;
using Pandora.API.Patch.Skyrim64;
using System.Collections.Generic;
using System.IO;

namespace Pandora.Models.Patch.Skyrim64.Format.FNIS;

public interface IFNISParser
{
	HashSet<IModInfo> ModInfos { get; }

	void ScanProjectAnimations(IProject project, DirectoryInfo absoluteOutputDirectory);
	void ScanProjectAnimlist(IProject project);
	void SetOutputPath(DirectoryInfo outputPath);
}