﻿// Decompiled with JetBrains decompiler
// Type: RTG.Singleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public abstract class Singleton<T> where T : class, new()
  {
    private static T _instance;

    public static T Get
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Singleton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Singleton() => throw null;
  }
}
