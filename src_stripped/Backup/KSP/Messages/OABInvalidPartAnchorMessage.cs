﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OABInvalidPartAnchorMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/OABInvalidPartAnchorMessage", true, "Player has attempted to select new anchor on an invalid part.", "")]
  public class OABInvalidPartAnchorMessage : OABMessageBase
  {
    public string Message;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABInvalidPartAnchorMessage() => throw null;
  }
}
