﻿// Decompiled with JetBrains decompiler
// Type: KSP.Test.ITransformFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Test
{
  public interface ITransformFrame
  {
    TransformFrameType type { get; }

    ITransformModel transform { get; }

    Vector3d ToLocalPosition(ITransformFrame referenceFrame, Vector3d referenceFramePosition);

    QuaternionD ToLocalRotation(ITransformFrame referenceFrame, QuaternionD referenceFramePosition);

    QuaternionD ToWorldRotation(QuaternionD thisLocalRotation);
  }
}
