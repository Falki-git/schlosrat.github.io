﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.InertialDrive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class InertialDrive : Block
  {
    public float motorInput;
    public float maxMotorTorque;
    public float clutchInput;
    public float inertia;
    public float u1;
    public float u2;
    public float u3;
    public float maxRpm;
    public float damping;
    private Block.Connection m_output;
    private float L;
    private float I;
    private float T;

    public float rpm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeInertia() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetState(ref Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSubstepState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetSubstepDerivative(ref Block.Derivative D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InertialDrive() => throw null;
  }
}
