﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartSeparatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/PartSeparatedMessage", true, "Player has removed a part from the assembly", "")]
  public class PartSeparatedMessage : OABPartMessageBase
  {
    public IObjectAssemblyPart partDetachedFrom;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartSeparatedMessage() => throw null;
  }
}
