﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IScaledSpaceFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using System.Collections.Generic;
using UnityEngine;

namespace KSP.Sim
{
  public interface IScaledSpaceFrame
  {
    ITransformFrame ReferenceFrame { get; }

    double SceneToUniverseScalar { get; }

    double UniverseToSceneScalar { get; }

    Position ScaledToPosition(Vector3d physicsSpacePosition);

    Vector3d ScaledToPosition(Vector3d physicsSpacePosition, ICoordinateSystem outputFrame);

    Vector3d PositionToScaled(Position position);

    Vector3d PositionToScaled(ICoordinateSystem referenceFrame, Vector3d localPosition);

    void PositionsToScaled(
      ICoordinateSystem frame,
      Vector3d[] localPosition,
      List<Vector3> scenePoints);

    void ScaledToPositions(
      Vector3d[] scenePositions,
      ICoordinateSystem frame,
      List<Vector3> framePoints);

    Rotation ScaledToRotation(QuaternionD physicsSpaceRotation);

    QuaternionD ScaledToRotation(QuaternionD physicsSpaceRotation, ICoordinateSystem outputFrame);

    QuaternionD RotationToScaled(Rotation rotation);

    QuaternionD RotationToScaled(ICoordinateSystem referenceFrame, QuaternionD localRotation);

    Vector ScaledToVector(Vector3d physicsSpaceVector);

    Vector3d ScaledToVector(Vector3d physicsSpaceVector, ICoordinateSystem outputFrame);

    Vector3d VectorToScaled(Vector vector);

    Vector3d VectorToScaled(ICoordinateSystem referenceFrame, Vector3d localPosition);
  }
}
