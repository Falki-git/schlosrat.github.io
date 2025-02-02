﻿// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapManeuverInputTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Map
{
  public class MapManeuverInputTarget : KerbalMonoBehaviour
  {
    [SerializeField]
    private UIActionBinder primaryAction;
    [SerializeField]
    private UIActionBinder secondaryAction;
    [SerializeField]
    private UIActionBinder startHoverAction;
    [SerializeField]
    private UIActionBinder endHoverAction;
    [SerializeField]
    private SpriteRenderer spriteRenderer;
    [SerializeField]
    private Color highlightColor;
    private Color _baseColor;
    private RaycastHit[] _raycastHits;
    private bool _isHighlight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerAction(ManeuverInputType inputType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapManeuverInputTarget() => throw null;
  }
}
