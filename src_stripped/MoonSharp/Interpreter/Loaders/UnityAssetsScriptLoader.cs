﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.UnityAssetsScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Loaders
{
  public class UnityAssetsScriptLoader : ScriptLoaderBase
  {
    private Dictionary<string, string> m_Resources;
    public const string DEFAULT_PATH = "MoonSharp/Scripts";

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityAssetsScriptLoader(string assetsPath = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UnityAssetsScriptLoader(Dictionary<string, string> scriptToCodeMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadResourcesWithReflection(string assetsPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetFileName(string filename) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object LoadFile(string file, Table globalContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ScriptFileExists(string file) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string[] GetLoadedScripts() => throw null;
  }
}
