﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPTelemetryDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using EdyCommonTools;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class VPTelemetryDisplay : VehicleBehaviour, ISerializationCallbackReceiver
  {
    public int currentTemplate;
    public TelemetryTemplateAssetBase[] templates;
    [Header("Template Preferences")]
    public TelemetryTemplateBase.DataReference reference;
    public TelemetryTemplateBase.DataDrawMode drawMode;
    public TelemetryTemplateBase.ValueDisplayMode valueMode;
    [Range(0.1f, 4f)]
    public float plotDensity;
    [Header("Data")]
    public int dataRangeFirst;
    public float dataRangeSpan;
    public bool autoUpdate;
    [Header("Display")]
    public int displayX;
    public int displayY;
    public int displayWidth;
    public int displayHeight;
    public bool autoDisplayHeight;
    [Space(5f)]
    public bool thickLines;
    public Color displayColor;
    [Range(0.0f, 1f)]
    public float displayOpacity;
    [Space(5f)]
    public Font font;
    [Range(4f, 30f)]
    public int fontSize;
    public Color fontColor;
    private GUICanvasBox m_display;
    private TelemetryTemplateAssetBase m_currentTemplateAsset;
    private TelemetryTemplateBase m_activeTemplate;
    private TelemetryTemplateBase.Context m_context;
    private float m_templateAspectRatio;
    private string m_header;
    private TelemetryDataset m_dataset;
    private float m_dataEntriesPerSecond;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReadTelemetryData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateAfterFixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareCanvas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateContextDataRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPointerInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPTelemetryDisplay() => throw null;
  }
}
