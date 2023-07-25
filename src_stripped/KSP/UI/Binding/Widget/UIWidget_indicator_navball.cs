﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_indicator_navball
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_indicator_navball : UIWidget
  {
    [SerializeField]
    [Header("Navball - Readonly")]
    private UIValueBinder navballRotation;
    [SerializeField]
    [Header("Indicators - Readonly")]
    [Header("NOTE: see TODO in code here")]
    private UIValue_ReadObject_NavMarker normalMarker;
    [SerializeField]
    private UIValue_ReadObject_NavMarker antiNormalMarker;
    [SerializeField]
    private UIValue_ReadObject_NavMarker progradeMarker;
    [SerializeField]
    private UIValue_ReadObject_NavMarker retrogradeMarker;
    [SerializeField]
    private UIValue_ReadObject_NavMarker radialInMarker;
    [SerializeField]
    private UIValue_ReadObject_NavMarker radialOutMarker;
    [SerializeField]
    [Header("Maneuver Marker")]
    private UIValue_ReadObject_NavMarker maneuverMarker;
    [SerializeField]
    private UIValueBinder haveManeuvers;
    [SerializeField]
    [Header("Enum for Velocity Mode")]
    private UIValueBinder velocityMode;

    public IUIValueBindable<Quaternion> NavballRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker NormalMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker AntiNormalMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker ProgradeMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker RetrogradeMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker RadialInMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker RadialOutMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UIValue_ReadObject_NavMarker ManeuverMarker
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueEnumBindable HaveManeuvers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueEnumBindable VelocityMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_indicator_navball() => throw null;
  }
}
