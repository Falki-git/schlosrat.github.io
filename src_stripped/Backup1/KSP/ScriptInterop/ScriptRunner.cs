﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.ScriptRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Assets;
using System;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop
{
  public class ScriptRunner : IScriptRunner
  {
    private IScriptEnvironment scriptEnvironment;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptRunner(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunScriptAssetAsync<T>(
      string key,
      AssetProvider assetProvider,
      Action<T> resultCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunScriptAssetAsync(
      string key,
      AssetProvider assetProvider,
      Action<IScriptValue> resultCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RunScriptString(string luaString, Action<IScriptValue> resultCallback = null) => throw null;
  }
}
