﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ICompoundPartModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;

namespace KSP.Sim
{
  public interface ICompoundPartModule : IPartModule
  {
    void OnModuleAwake();

    void OnTargetSet(PartComponent target);

    void OnTargetLost();
  }
}
