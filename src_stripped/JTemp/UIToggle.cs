﻿// Decompiled with JetBrains decompiler
// Type: JTemp.UIToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

namespace JTemp
{
  public class UIToggle : UIInteract
  {
    private static Dictionary<string, List<UIToggle>> radios;
    private static UIToggle firstToggle;
    public string radioSet;
    public Toggle toggle;
    private bool stateChange;
    private bool partOfSet;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void GetComponents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnStateChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static UIToggle() => throw null;
  }
}
