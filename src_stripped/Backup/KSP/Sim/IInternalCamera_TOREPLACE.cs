﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IInternalCamera_TOREPLACE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.Sim
{
  public interface IInternalCamera_TOREPLACE : IKSPCamera
  {
    void SetTransform(Transform cameraTransform, bool resetCamera);

    void EnableCamera();

    void DisableCamera();

    void ResetCamera();

    void Destroy();
  }
}
