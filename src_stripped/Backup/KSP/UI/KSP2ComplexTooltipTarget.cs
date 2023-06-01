﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2ComplexTooltipTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class KSP2ComplexTooltipTarget : KerbalMonoBehaviour, ITooltipTarget
  {
    public int TabCount;
    [SerializeField]
    private UIValue_ReadString_String[] _readTitleValue;
    [SerializeField]
    private UIValue_ReadString_String[] _readDescriptionValue;
    [SerializeField]
    private UIValue_ReadSprite_Sprite[] _readSpriteValue;
    [SerializeField]
    private KSP2ComplexTooltip _tooltipPrefab;
    private KSP2ComplexTooltip _currentTooltip;
    private ComplexTooltipData _tooltipData;

    public int Priority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string title, string description, Sprite icon = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(string[] title, string[] description, Sprite[] icon = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnExit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2ComplexTooltipTarget() => throw null;
  }
}
