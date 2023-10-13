﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DrivelineHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class DrivelineHelper
  {
    public DrivelineHelper.Settings settings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Driveline.Settings GetDrivelineSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Differential.Settings GetAxleDifferentialSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Differential.Settings GetCenterDifferentialSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DrivelineHelper() => throw null;

    public enum DriveWheels
    {
      Rear,
      Front,
      AllWheel,
    }

    public enum DifferentialType
    {
      Open,
      LimitedSlip,
      Locked,
    }

    public enum TransferCase
    {
      Open,
      Locked,
    }

    [Serializable]
    public class Settings
    {
      public DrivelineHelper.DriveWheels driveWheels;
      public DrivelineHelper.DifferentialType differentialType;
      public float limitedSlipRatio;
      public float finalRatio;
      public DrivelineHelper.TransferCase transferCase;
      public float transferCaseRatio;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
