﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.UpdateVelocities
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim.impl
{
  public delegate void UpdateVelocities(
    Velocity oldVelocity,
    out Velocity newVelocity,
    AngularVelocity oldAngularVelocity,
    out AngularVelocity newAngularVelocity,
    Position observerPosition);
}
