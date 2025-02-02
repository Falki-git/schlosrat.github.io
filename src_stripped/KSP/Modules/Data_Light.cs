﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Light
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Light : ModuleData
  {
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 1)]
    [LocalizedField("PartModules/Light/LightSwitch")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> isLightEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 2)]
    [LocalizedField("PartModules/Light/ColorR")]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [HideInInspector]
    public ModuleProperty<float> lightColorR;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Light/ColorG")]
    [PAMDisplayControl(SortIndex = 3)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [HideInInspector]
    public ModuleProperty<float> lightColorG;
    [LocalizedField("PartModules/Light/ColorB")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 4)]
    [SteppedRange(0.0f, 1f, 0.01f)]
    [HideInInspector]
    public ModuleProperty<float> lightColorB;
    [PAMDisplayControl(SortIndex = 8)]
    [LocalizedField("PartModules/Light/LightEmission")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> castLight;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 9)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Light/BlinkOn")]
    public ModuleProperty<bool> isBlinkEnabled;
    [LocalizedField("PartModules/Light/BlinkRate")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 10)]
    [HideInInspector]
    [SteppedRange(0.2f, 2f, 0.1f)]
    public ModuleProperty<float> blinkRate;
    [HideInInspector]
    [SteppedRange(0.0f, 360f, 5f)]
    [PAMDisplayControl(SortIndex = 5)]
    [LocalizedField("PartModules/Light/RotationAngle")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> rotationAngle;
    [LocalizedField("PartModules/Light/PitchAngle")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    [SteppedRange(0.0f, 360f, 5f)]
    public ModuleProperty<float> pitchAngle;
    [LocalizedField("PartModules/Gimbal/AdvancedSettings")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 7)]
    [HideInInspector]
    public ModuleProperty<bool> IsAdvancedControlsShown;
    [HideInInspector]
    [KSPDefinition]
    public bool isSmoothTransitionEnabled;
    [Tooltip("Name of the mesh renderer for emissive")]
    [Header("GameObject Config")]
    [KSPDefinition]
    public string LightMeshRendererName;
    [Tooltip("Whether the light consumes resources")]
    [KSPDefinition]
    public bool useResources;
    [KSPDefinition]
    [Tooltip("Resource required to operate this module if consumes resources")]
    public PartModuleResourceSetting requiredResource;
    [KSPDefinition]
    public float lightBrightenDuration;
    [KSPDefinition]
    public float lightDimDuration;
    [KSPDefinition]
    public bool simpleLightControls;
    [KSPDefinition]
    public bool canRotate;
    [KSPDefinition]
    public bool canPitch;
    [KSPDefinition]
    public Vector3 rotationAxis;
    [KSPDefinition]
    public Vector3 pitchAxis;
    [KSPDefinition]
    public float rotateMin;
    [KSPDefinition]
    public float rotateMax;
    [KSPDefinition]
    public float pitchMin;
    [KSPDefinition]
    public float pitchMax;
    [KSPDefinition]
    public bool canBlink;
    [KSPDefinition]
    public float blinkRateMin;
    [KSPDefinition]
    public float blinkRateMax;
    [Tooltip("Default of whether the light is on when pulled out of the editor")]
    [KSPDefinition]
    [Header("Default PAM values")]
    public bool IsOn;
    [Tooltip("Default red component of the light color")]
    [KSPDefinition]
    public float LightR;
    [Tooltip("Default green component of the light color")]
    [KSPDefinition]
    public float LightG;
    [Tooltip("Default blue component of the light color")]
    [KSPDefinition]
    public float LightB;
    [HideInInspector]
    public bool HasResourcesToOperate;
    public ResourceFlowRequestCommandConfig RequestConfig;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetColorComponentString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAngleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetBlinkString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Light() => throw null;
  }
}
