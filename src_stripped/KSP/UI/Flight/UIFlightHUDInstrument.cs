﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Flight.UIFlightHUDInstrument
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Flight
{
  public class UIFlightHUDInstrument : KerbalMonoBehaviour
  {
    [SerializeField]
    protected ContextBindRoot _bindRoot;
    [SerializeField]
    protected Canvas _parentCanvas;
    [SerializeField]
    private bool _isVesselInstrument;
    [SerializeField]
    private bool _isColonyInstrument;

    public bool IsVesselInstrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsColonyInstrument
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize(Camera uiRenderCamera, ViewDataProvider viewDataProvider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIFlightHUDInstrument() => throw null;
  }
}
