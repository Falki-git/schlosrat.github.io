﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VirtualConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public struct VirtualConnection
  {
    public PartComponent host;
    public PartComponent target;
    public PartRelationshipType relationshipType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VirtualConnection(
      PartComponent host,
      PartComponent target,
      PartRelationshipType relationshipType)
    {
      throw null;
    }
  }
}
