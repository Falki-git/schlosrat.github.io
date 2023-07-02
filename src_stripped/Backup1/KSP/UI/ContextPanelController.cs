﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ContextPanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class ContextPanelController : KerbalMonoBehaviour
  {
    [SerializeField]
    public ContextPanel _contextPanel;
    [SerializeField]
    private Canvas _panelParent;
    [SerializeField]
    public float _contextClickTimeout;
    private ContextPanel _currentPanel;
    private GameObject _currentHoverTarget;
    private GameObject _currentActiveTarget;
    private GameObject _panelStartTarget;
    private float _panelStartInteractionTime;
    private RaycastHit[] _physicsRaycastResults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RaycastListener() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PanelCloseListener() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject CheckHitUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject CheckHitPhysics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PanelActivationStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PanelActivationEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivatePanel(IContextPanelTarget target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideOnEvent(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetActiveTargetPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextPanelController() => throw null;
  }
}
