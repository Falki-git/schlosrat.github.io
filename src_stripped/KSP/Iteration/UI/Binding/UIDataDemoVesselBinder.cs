﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIDataDemoVesselBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Iteration.Data;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI.Binding
{
  public abstract class UIDataDemoVesselBinder : UIDataBinder<IDemoVessel>
  {
    [SerializeField]
    private CanvasGroup visibilityGroup;

    protected CanvasGroup VisibilityGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected RectTransform VisibilityGroupTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    protected IDemoView View
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InjectDependencies(IDemoView view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void RedrawOnIsBoundChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected UIDataDemoVesselBinder() => throw null;
  }
}
