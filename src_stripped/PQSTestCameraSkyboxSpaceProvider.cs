﻿// Decompiled with JetBrains decompiler
// Type: PQSTestCameraSkyboxSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PQSTestCameraSkyboxSpaceProvider : ISkyboxSpaceProvider, ISkyboxSpaceFrame
{
  public Transform transform
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public ITransformFrame ReferenceFrame
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSTestCameraSkyboxSpaceProvider(ITransformFrame referenceFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetReferenceFrame(ITransformFrame referenceFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Rotation SkyboxToRotation(QuaternionD sceneRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD SkyboxToRotation(QuaternionD sceneRotation, ICoordinateSystem outputFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD RotationToSkybox(Rotation rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD RotationToSkybox(ICoordinateSystem referenceFrame, QuaternionD localRotation) => throw null;
}
