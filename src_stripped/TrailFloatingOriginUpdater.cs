﻿// Decompiled with JetBrains decompiler
// Type: TrailFloatingOriginUpdater
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TrailFloatingOriginUpdater : KerbalMonoBehaviour
{
  private const int NumFramesToRenderMessage = 10;
  private TrailRenderer[] _trailRenderers;
  private Vector3[] _positionBuffer;
  private Vector3 _previousFramePosition;
  private SubscriptionHandle _handleReferenceFrameChanged;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void onFrameSnapPositions(Vector3d physicStepVector, List<Action> actionList) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnPhysicsSpaceProviderReferenceChanged(MessageCenterMessage msg) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TrailFloatingOriginUpdater() => throw null;
}
