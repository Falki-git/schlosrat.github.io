﻿// Decompiled with JetBrains decompiler
// Type: OABThumbnailCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using EdyCommonTools;
using KSP.Game.Flow;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OABThumbnailCreator : SaveGameThumbnailCreator
{
  public const int DEFAULT_VESSEL_THUMBNAIL_HEIGHT = 512;
  public const float SCALE_TO_FIT_BUFFER_MULTIPLIER = 0.85f;
  private const float CUBENESS_RATIO_THRESHOLD = 0.1f;
  private const float MINIMUM_CAMERA_SIZE = 0.01f;
  private static Dictionary<OABThumbnailCreator.DominantBoundsSide, Vector2> BOUNDS_SHAPE_TO_PITCHYAW_DATA;
  private Transform _renderCamParent;
  private Camera _renderCam;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OABThumbnailCreator(GameObject renderCamObject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void AsyncCreateThumbnail(string outputFilePath, int thumbnailHeightOverride = 512) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected IEnumerator CaptureAsyncImage(string path, int finalWidth, int finalHeight) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected IEnumerator CaptureOABPartsIntoRenderTexture(RenderTexture outputRenderTexture) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected float CalculateCameraRollForVesselThumbnail(
    OABThumbnailCreator.DominantBoundsSide domBoundsSide,
    MathUtility.Axis vesselFacingAxis)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected OABThumbnailCreator.DominantBoundsSide GetDominantBoundsSide(Bounds assemblyBounds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void SetCameraSizeToFitAssemblyWithBuffer(Bounds assemblyBounds) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected bool TryEnableRenderCam(bool enabledState) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected Vector3 GetThrustVectorForActiveAssembly() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected MathUtility.Axis GetVesselCardinalFacingAxis() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static OABThumbnailCreator() => throw null;

  protected enum DominantBoundsSide
  {
    EQUAL,
    X,
    XY,
    Y,
    YZ,
    Z,
    ZX,
  }
}
