﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.Widget.UIWidget_modedisplay_missiontime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI.Binding.Widget
{
  public class UIWidget_modedisplay_missiontime : UIWidget
  {
    [Header("Enum of Mission Time Mode - Writable")]
    [SerializeField]
    private UIValueBinder timeMode;
    [Header("Mission Time Value for current Time Mode - Readonly")]
    [SerializeField]
    private UIValueBinder timeDisplay;
    [SerializeField]
    [Header("Warp Factor - Readonly")]
    private UIValueBinder timewarpRateDisplay;

    public IUIValueEnumBindable TimeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueNumberBindable TimeDisplay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IUIValueNumberBindable TimewarpRateDisplay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIWidget_modedisplay_missiontime() => throw null;
  }
}
