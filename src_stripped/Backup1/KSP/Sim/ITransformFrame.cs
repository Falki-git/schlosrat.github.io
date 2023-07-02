﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ITransformFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim
{
  public interface ITransformFrame : ICoordinateSystem
  {
    TransformFrameType type { get; }

    ITransformModel transform { get; }

    IMotionFrame motionFrame { get; }
  }
}
