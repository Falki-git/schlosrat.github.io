﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ContextualTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [RequireComponent(typeof (CanvasGroup))]
  public class KSP2ContextualTooltip : Basic2DTooltip
  {
    [SerializeField]
    private GameObject _icon;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void UpdateTooltip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ContextualTooltip() => throw null;
  }
}
