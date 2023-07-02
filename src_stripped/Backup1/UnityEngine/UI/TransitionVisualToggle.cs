﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.UI.TransitionVisualToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
