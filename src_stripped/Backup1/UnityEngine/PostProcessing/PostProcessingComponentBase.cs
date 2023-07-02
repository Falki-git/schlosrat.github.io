﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponentBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public abstract class PostProcessingComponentBase
  {
    public PostProcessingContext context;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual DepthTextureMode GetCameraFlags() => throw null;

    public abstract bool active
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract PostProcessingModel GetModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PostProcessingComponentBase() => throw null;
  }
}
