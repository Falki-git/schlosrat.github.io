﻿// Decompiled with JetBrains decompiler
// Type: DebugVisualizer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DebugVisualizer : MonoBehaviour
{
  private bool _enableTimer;
  private GUIStyle textStyle;
  private bool showTextureStreamingStats;
  private bool _showAuthenticationInfo;
  private DebugVisualizer.kTextPos textPosition;
  private IScriptEnvironment ScriptInjector;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool ToggleLocalizationDebugMode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool QAPrintPartsInBuildersCSVs() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int ShowFrameTimes(bool show) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetShowFrameTimes() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int SetTextureStreaming(bool enabled) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetTextureStreaming() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int ShowTextureStreamingStats(bool show) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool GetShowTextureStreamingStats() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int GetTextureStreamingBudget() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int SetTextureStreamingBudget(int newValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool SetTextPosition(string textPos) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleVesselTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleVesselScience() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleKerbalTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleScienceTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleScienceExperimentResearchReportTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleSimObjectTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleOABAssemblyOverlay() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleOABSizeLimits() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleFXTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleRenderingTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void TogglePlanetViewer() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleTeleportWindow() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleLogConsole() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleThermalDebugTool() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleVesselCoordinateLocation() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PassiveTierNotification(string text, bool isTextOnly) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AdminTierNotification(
    string titleContentText,
    string bodyContentText,
    bool isTextOnly,
    bool isTextAndIcon)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AlertTierNotification(
    string titleText,
    string firstLineItemtext,
    string secondLineItemtext,
    string thirdLineItemtext,
    float timerDuration,
    bool isHighLevelOfImportance,
    bool isMediumLevelOfImportance)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void EnableNotificationTimer(bool enableTimer) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleShowDebugLoginButtons() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlaceKerbal() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RestartLegalAcceptance() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleNotificationsCanvasVisibility(bool hidden) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleAuthenticationInfo() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void RenderAuthenticationInfo(
    string playFabId,
    string firstPartyId,
    string firstPartyUsername,
    string pDId,
    string pDUsername,
    ref float textLeft,
    ref float textTop,
    ref float textWidth,
    ref float textHeight)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void RenderText(
    string text,
    ref float textLeft,
    ref float textTop,
    ref float textWidth,
    ref float textHeight)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public DebugVisualizer() => throw null;

  private enum kTextPos
  {
    TOPLEFT,
    TOPCENTER,
    TOPRIGHT,
  }
}
