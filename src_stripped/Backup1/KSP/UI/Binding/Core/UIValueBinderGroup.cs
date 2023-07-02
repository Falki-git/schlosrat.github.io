﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Core.UIValueBinderGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Core
{
  public class UIValueBinderGroup : 
    UIValueBinder,
    IUIValueBindable,
    IUIValueNumberBindable,
    IUIValueEnumBindable
  {
    [SerializeField]
    [Header("Binders to pass 'BindValue' calls to")]
    private UIValueBinder[] binders;
    private bool isBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveCircularReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BindValue(IProperty valueProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty numberProperty, double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedValueRange(double min, double max, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty enumValueProperty, IEnumerable<string> enumValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindValue(IProperty enumValueProperty, System.Type enumType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnumValues(IEnumerable<string> enumValues, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMappedEnum(System.Type enumType, bool shouldRedraw = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValueBinderGroup() => throw null;
  }
}
