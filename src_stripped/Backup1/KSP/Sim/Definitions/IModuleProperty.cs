﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.IModuleProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;

namespace KSP.Sim.Definitions
{
  public interface IModuleProperty : IPropertyWritable, IProperty, IModuleDataContext
  {
    bool IsReadOnly { get; }

    string ContextKey { get; set; }

    ToStringDelegate ToStringDelegate { get; }
  }
}
