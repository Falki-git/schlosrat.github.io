﻿// Decompiled with JetBrains decompiler
// Type: KSP.DebugTools.OABDebugOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.DebugTools
{
  public class OABDebugOverlay : MonoBehaviour
  {
    [SerializeField]
    private OABDebugOverlayText template;
    [SerializeField]
    private float pollRateSeconds;
    [SerializeField]
    private bool autoRefresh;
    [SerializeField]
    [Range(0.1f, 0.8f)]
    private float locFromPartToCam;
    private GameObjectPool<OABDebugOverlayText> textPool;
    private double timeRemaining;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABDebugOverlay() => throw null;
  }
}
