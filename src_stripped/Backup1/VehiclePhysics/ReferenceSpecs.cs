﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ReferenceSpecs
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  [Serializable]
  public class ReferenceSpecs
  {
    public float maxSpeed;
    public float maxRpm;
    public float maxTorque;
    public float maxPower;
    public int numGears;
    public float maxSuspensionDistance;
    public float maxSpringRate;
    public float maxAccelerationG;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReferenceSpecs() => throw null;
  }
}
