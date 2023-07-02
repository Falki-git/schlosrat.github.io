﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public class ObjectAssemblyMarker : KerbalMonoBehaviour
  {
    [SerializeField]
    protected GameObject posMarkerObject;
    [SerializeField]
    protected GameObject dirMarkerObject;
    protected IObjectAssemblyPart rootPart;
    protected ObjectAssemblyBuilder CurrentOAB;
    private bool _isToggledOn;
    protected bool _hasValidPosition;
    protected bool _hasValidDirection;
    private bool _isDirty;
    private bool _isDirtyLoad;
    private Coroutine _waitProceduralPartsBaked;
    private Coroutine _waitDirtyAfterVesselLoaded;
    private int _framesToWaitAfterLoad;
    private Vector3 _position;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetToggledStatus(bool newToggleState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool TryUpdatePosition(ref Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual Vector3 UpdateDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPlacedMessage(MessageCenterMessage partPlacedMessage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartManipulationCompleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMainAssemblyChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartDeleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnProceduralWingChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitProceduralPartsBaked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitDirtyAfterVesselLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHistoryManipulation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AnyPartsBaking() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RecurseParts(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOabUnloaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnNewVessel(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLoaded(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyMarker() => throw null;
  }
}
