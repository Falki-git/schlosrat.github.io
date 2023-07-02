﻿// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.Scripting.ScriptMethodReference
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Utilities.Scripting
{
  [Serializable]
  public class ScriptMethodReference
  {
    [JsonProperty]
    public ScriptExecutionContext TargetContext;
    [JsonProperty]
    public string ScriptFileAsset;
    [JsonProperty]
    public string ScriptMethod;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScriptMethodReference() => throw null;
  }
}
