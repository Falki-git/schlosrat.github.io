﻿// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.DynamicGroupExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Navigation
{
  public static class DynamicGroupExtension
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Extend<NavElementGroup> DynamicGroup(this Extend<NavElementGroup> extend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KSP.Navigation.DynamicGroup DynamicGroup(
      this IExtendable<NavElementGroup> target,
      bool createIfNotExist = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KSP.Navigation.DynamicGroup DynamicGroup(
      this Decorator<NavElementGroup> decorator,
      bool createIfNotExist = false)
    {
      throw null;
    }
  }
}
