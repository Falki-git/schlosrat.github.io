﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Factory.IClassFactory`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Sim.Factory
{
  public interface IClassFactory<C> where C : class
  {
    C ClassFromData<D>(D data, params object[] additionalParams);

    C ClassFromData(Type dataType, object data, params object[] additionalParams);

    C ClassFromDataCustom(Type dataType, object data, params object[] additionalParams);
  }
}
