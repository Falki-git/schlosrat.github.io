﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UpdateRigidBody
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.Sim.impl
{
  public delegate void UpdateRigidBody(
    Position oldPosition,
    out Position newPosition,
    Rotation oldRotation,
    out Rotation newRotation,
    Velocity oldVelocity,
    out Velocity newVelocity,
    AngularVelocity oldAngularVelocity,
    out AngularVelocity newAngularVelocity);
}
