﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.CameraGimbalHeadingPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Camera/CameraGimbalHeading", true, "Left/Right rotation in degrees of the camera around the gimbal Y axis (0 = gimbal 'forward', increasing clockwise)", "")]
  public class CameraGimbalHeadingPropertyWatcher : CameraGimbalPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraGimbalHeadingPropertyWatcher() => throw null;
  }
}
