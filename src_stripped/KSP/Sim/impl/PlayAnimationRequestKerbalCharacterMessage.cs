﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PlayAnimationRequestKerbalCharacterMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PlayAnimationRequestKerbalCharacterMessage : KerbalCharacterMessage
  {
    public int? PlayAnimTriggerId;
    public int? PlayAnimFloatId;
    public int? PlayAnimBoolId;
    public float PlayAnimFloatValue;
    public bool PlayAnimBoolValue;
    public string AnimationStateName;
    public Action OnAnimStartCallback;
    public Action OnAnimEndCallback;
    public bool DisableEVAFlightInteractInputs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayAnimationRequestKerbalCharacterMessage(
      int? triggerId,
      int? floatId,
      float floatValue,
      int? boolId,
      bool boolValue,
      bool disableEvaFlightInteractInputs,
      Action onAnimStartCallback,
      Action onAnimEndCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayAnimationRequestKerbalCharacterMessage(
      string animationStateName,
      bool disableEvaFlightInteractInputs,
      Action onAnimStartCallback,
      Action onAnimEndCallback)
    {
      throw null;
    }
  }
}
