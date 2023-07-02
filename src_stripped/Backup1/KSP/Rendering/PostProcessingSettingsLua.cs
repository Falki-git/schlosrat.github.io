﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PostProcessingSettingsLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  public class PostProcessingSettingsLua
  {
    public const string POST_PROCESSING_ENABLED_NAME = "PostProcessingEnabled";
    public const string TUTORIAL_OVERLAY_ENABLED_NAME = "TutorialOverlayEnabled";
    private IScriptEnvironment scriptEnvironment;
    private GraphicsSettings graphicsSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PostProcessingSettingsLua(GraphicsSettings settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetPostProcessingEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPostProcessingEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetTutorialOverlayEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetTutorialOverlayEnabled() => throw null;
  }
}
