﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPAxle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  [Serializable]
  public class VPAxle
  {
    public VPWheelCollider leftWheel;
    public VPWheelCollider rightWheel;
    public Brakes.BrakeCircuit brakeCircuit;
    public Steering.SteeringMode steeringMode;
    public float steeringRatio;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPAxle() => throw null;
  }
}
