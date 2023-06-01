﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TransitionVisualToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Inspector;
using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UI
{
  [Serializable]
  public struct TransitionVisualToggle
  {
    [DisableArrayPagination]
    public Graphic[] targetGraphics;
    public TransitionVisualData transitionDataOn;
    public TransitionVisualData transitionDataOff;

    public static TransitionVisualToggle Default
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
