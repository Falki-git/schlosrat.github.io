﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyStrutRelationship
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyStrutRelationship : IObjectAssemblyRelationship
  {
    private StackObjectsBetweenTwoPoints displayMesh;

    public IObjectAssemblyPart First
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IObjectAssemblyPart Second
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartRelationshipType RelationshipType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyStrutRelationship(
      IObjectAssemblyPart first,
      IObjectAssemblyPart second,
      StackObjectsBetweenTwoPoints displayMesh)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Visualize() => throw null;
  }
}
