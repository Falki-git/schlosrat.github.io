﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class IResourceContainerExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnionAll(
      this IResourceContainer target,
      IResourceContainerReadOnly source,
      bool restrictToSharedResources = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnionCapacities(
      this IResourceContainer target,
      IResourceContainerReadOnly source,
      bool restrictToSharedResources = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TransferFrom(this IResourceContainer target, IResourceContainer source) => throw null;
  }
}
