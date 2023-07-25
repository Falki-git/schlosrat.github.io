﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSTargetProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  public class PQSTargetProvider
  {
    private Transform _pqsTransform;
    private ITransformFrame _pqsBodyFrame;
    private IUniverseObserver _observerRef;
    private Camera _renderCamera;

    public Camera RenderCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSTargetProvider(Transform pqsTransform, Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSTargetProvider(
      Transform pqsTransform,
      Camera cam,
      ITransformFrame pqsBodyFrame,
      IUniverseObserver observerRef)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeCameraPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeCameraDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeCameraRight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeTargetPosition(float offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelativeObserverPosition() => throw null;
  }
}
