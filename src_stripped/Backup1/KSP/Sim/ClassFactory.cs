﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ClassFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class ClassFactory : Attribute
  {
    public Type classType;
    public Type dataType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClassFactory(Type classType, Type dataType) => throw null;
  }
}
