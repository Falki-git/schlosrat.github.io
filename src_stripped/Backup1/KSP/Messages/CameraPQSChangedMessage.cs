﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CameraPQSChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Camera/CurrentPQSChangedMessage", true, "The observed PQS planet has changed", "")]
  public class CameraPQSChangedMessage : CameraMessageBase
  {
    public string BodyName;
    public PQS PqsReference;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraPQSChangedMessage() => throw null;
  }
}
