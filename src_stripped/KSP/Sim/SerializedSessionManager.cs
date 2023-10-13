﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedSessionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedSessionManager
  {
    [JsonProperty("DifficultyOptions")]
    public DifficultyOptionsData DifficultyOptions;
    [JsonProperty("DefaultDifficultyOptions")]
    public DifficultyOptionsData DefaultDifficultyOptions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSessionManager() => throw null;
  }
}
