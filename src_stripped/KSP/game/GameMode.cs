﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.GameMode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;

namespace KSP.Game
{
  public struct GameMode
  {
    public string Id;
    public List<GameModeFeature> GameModeFeatures;
    public List<DifficultyOption> DifficultyOptions;
    public List<DifficultyPreset> DifficultyPresets;
  }
}
