﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSP2UIWindowControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.UI
{
  [RequireComponent(typeof (Graphic))]
  public class KSP2UIWindowControl : KerbalMonoBehaviour, IPointerDownHandler, IEventSystemHandler
  {
    [Header("Window Components")]
    public KSP2UIWindow TargetWindow;
    protected RectTransform _canvasTransform;
    protected Vector2 _mouseDownOffset;

    protected bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Oninitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPointerDown(PointerEventData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2UIWindowControl() => throw null;
  }
}
