﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DirectDrive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class DirectDrive : Block
  {
    public float motorInput;
    public float maxMotorTorque;
    public float maxRpm;
    public float damping;
    private Block.Connection m_output;
    private float m_sensorLoad;

    public float angularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float torque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorLoad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DirectDrive() => throw null;
  }
}
