// SPDX-License-Identifier: GPL-3.0-or-later
// Copyright (C) 2023-2025 Pandora Behaviour Engine Contributors

using System.Xml.Linq;
using XmlCake.Linq;

namespace Pandora.API.Patch.Skyrim64;

public interface IPackFileEditor
{
    static abstract string AppendElement(IXMap xmap, string path, XElement element);
    static abstract void AppendText(IXMap xmap, string path, string newValue);
    static abstract string InsertElement(IXMap xmap, string path, XElement element);
    static abstract bool InsertText(IXMap xmap, string path, string markerValue, string newValue);
    static abstract string PushElement(IXMap xmap, string path, XElement element);
    static abstract XElement RemoveElement(IXMap xmap, string path);
    static abstract void RemoveText(IXMap xmap, string path, string value);
    static abstract XElement ReplaceElement(IXMap xmap, string path, XElement element);
    static abstract bool ReplaceText(
        IXMap xmap,
        string path,
        string preValue,
        string oldValue,
        string newValue
    );
    static abstract bool SetText(IXMap xmap, string path, string newValue);
}
