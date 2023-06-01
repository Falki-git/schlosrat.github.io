﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.PartControlToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class PartControlToggle : IDisposable
  {
    private DataContext _elementContext;
    private OffsetSliderSystem.OffsetToggleData _controlData;
    private Property<string> _controlLabel;
    private PropertyExternal<bool> _controlValue;
    private const string LABEL_KEY = "PartControlLabel";
    private const string VALUE_KEY = "PartControlValue";

    public ContextBindRoot ControlElement
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartControlToggle(
      ContextBindRoot controlElement,
      OffsetSliderSystem.OffsetToggleData data,
      Action onToggle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetDataValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDataValue(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
