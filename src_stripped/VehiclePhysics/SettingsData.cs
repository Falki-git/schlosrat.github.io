﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SettingsData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  [StructLayout(LayoutKind.Sequential, Size = 1)]
  public struct SettingsData
  {
    public const int DifferentialLock = 0;
    public const int DrivelineLock = 1;
    public const int AutoShiftOverride = 2;
    public const int AbsOverride = 3;
    public const int EscOverride = 4;
    public const int TcsOverride = 5;
    public const int AsrOverride = 6;
    public const int SteeringAidsOverride = 7;
    public const int Max = 10;
  }
}
