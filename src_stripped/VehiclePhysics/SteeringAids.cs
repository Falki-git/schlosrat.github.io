﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SteeringAids
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class SteeringAids
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Apply(
      VehicleBase vehicle,
      Steering.Settings steering,
      SteeringAids.Settings settings,
      ref float steerInput)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplySteeringHelp(
      VehicleBase vehicle,
      Steering.Settings steering,
      SteeringAids.Settings settings,
      ref float steerInput)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplySteeringLimit(
      VehicleBase vehicle,
      Steering.Settings steering,
      SteeringAids.Settings settings,
      ref float steerInput)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SteeringAids() => throw null;

    public enum HelpMode
    {
      Disabled,
      AssistedSteerAngle,
    }

    public enum LimitMode
    {
      Disabled,
      Street,
      Sport,
      CustomSlip,
    }

    public enum Priority
    {
      PreferDrifting,
      PreferGoStraight,
    }

    [Serializable]
    public class Settings
    {
      public SteeringAids.Priority priority;
      [Header("Steering Help")]
      public SteeringAids.HelpMode helpMode;
      [Range(0.0f, 1f)]
      public float helpRatio;
      [Range(0.0f, 0.9f)]
      public float helpGravity;
      [Header("Steering Limit")]
      public SteeringAids.LimitMode limitMode;
      [Range(0.0f, 1f)]
      public float limitRatio;
      [Range(0.0f, 1f)]
      public float limitProportionality;
      public float limitCustomSlip;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
