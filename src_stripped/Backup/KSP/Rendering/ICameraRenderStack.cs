﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ICameraRenderStack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace KSP.Rendering
{
  public interface ICameraRenderStack
  {
    RenderSpaceType RenderSpace { get; }

    Transform RenderCameraMount { get; }

    Transform RenderCameraGimbal { get; }

    void ApplyCameraShot(ICameraShot cameraShot);

    void SetRenderCamerasEnabled(bool enabled);

    void RenderShotToTexture(ICameraShot cameraShot, RenderTexture renderTarget);

    Camera[] GetRenderCameras(bool includeDebugRenderCameras = false);

    Camera GetMainRenderCamera();

    Camera GetCubemapRenderCamera();

    Camera GetDebugRenderCamera();

    PostProcessLayer GetPostProcessLayer();

    CameraEffectsSystem GetCameraEffectsSystem();

    Ray ScreenPointToRay(Vector3 position);

    Vector3 ScreenToViewportPoint(Vector3 position);

    Vector3 ScreenToWorldPoint(Vector3 position);

    Ray ViewportPointToRay(Vector3 position);

    Vector3 ViewportToScreenPoint(Vector3 position);

    Vector3 ViewportToWorldPoint(Vector3 position);

    Vector3 WorldToScreenPoint(Vector3 position);

    Vector3 WorldToViewportPoint(Vector3 position);
  }
}
