﻿// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.PartAudioEventBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace KSP.FX.Timeline
{
  [Serializable]
  public class PartAudioEventBehavior : PlayableBehaviour
  {
    public string audioEventCategory;
    public string targetTagName;
    private bool active;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate(TimelineAdapter adapter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartAudioEventBehavior() => throw null;
  }
}
