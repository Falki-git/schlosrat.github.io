﻿// Decompiled with JetBrains decompiler
// Type: KSP.Tools.PQSFreeCamState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Tools
{
  [Serializable]
  public class PQSFreeCamState
  {
    public float latitude;
    public float longitude;
    public float altitude;
    public AltitudeMode altitudeMode;
    public float heading;
    public float pitch;
    public float speedMultiplier;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyValues(PQSFreeCamState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSFreeCamState() => throw null;
  }
}
