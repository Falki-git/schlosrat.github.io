﻿// Decompiled with JetBrains decompiler
// Type: PQSTestCameraSkyboxCameraStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Rendering;
using KSP.Rendering.impl;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PQSTestCameraSkyboxCameraStack : CameraRenderStackBase, ICameraRenderStack
{
  private GameObject cameraRoot;
  private Camera skyboxCam;
  private Camera cubemapCam;
  [SerializeField]
  private PostProcessLayer _postProcessLayer;
  [SerializeField]
  private CameraEffectsSystem _cameraEffectsSystem;

  public override RenderSpaceType RenderSpace
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Cleanup() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override Camera GetCubemapRenderCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override Camera GetDebugRenderCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override PostProcessLayer GetPostProcessLayer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override CameraEffectsSystem GetCameraEffectsSystem() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override Camera GetMainRenderCamera() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override Camera[] GetRenderCameras(bool includeDebugCameras = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void InternalApplyShotToRenderCamera(ICameraShot shot, Camera renderCamera) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSTestCameraSkyboxCameraStack() => throw null;
}
