﻿// Decompiled with JetBrains decompiler
// Type: CameraFXModules.WobbleModes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace CameraFXModules
{
  [Flags]
  public enum WobbleModes
  {
    None = 0,
    X = 1,
    Y = 2,
    Z = 4,
    Linear = Z | Y | X, // 0x00000007
    Pitch = 8,
    Yaw = 16, // 0x00000010
    Roll = 32, // 0x00000020
    Rot = Roll | Yaw | Pitch, // 0x00000038
    All = -1, // 0xFFFFFFFF
  }
}
