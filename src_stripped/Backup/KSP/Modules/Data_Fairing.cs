﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Fairing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Fairing : ModuleData, IMassModifier
  {
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Fairings/FairingEnabled")]
    public ModuleProperty<bool> FairingEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Fairings/ConstructionType")]
    public ModuleProperty<KSP.OAB.FairingConstructionType> FairingConstructionType;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Fairings/FloatingNodeEnabled")]
    public ModuleProperty<bool> FloatingNodeEnabled;
    [LocalizedField("PartModules/Fairings/Length")]
    [SteppedRange(0.0f, 1f, 0.1f)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> Length;
    [LocalizedField("PartModules/Fairings/DeployType")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<FairingDeployType> DeployType;
    [KSPState(CopyToSymmetrySet = true)]
    [SteppedRange(0.0f, 1000f, 10f)]
    [LocalizedField("PartModules/Fairings/EjectionForce")]
    public ModuleProperty<float> EjectionForce;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Fairings/IsStagingEnabled")]
    public ModuleProperty<bool> IsStagingEnabled;
    [LocalizedField("PartModules/Fairings/IsDeployed")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> IsDeployed;
    [KSPDefinition]
    [Tooltip("The attach node size of the floating node")]
    [Header("Floating node")]
    public float FloatingNodeSize;
    [KSPDefinition]
    [Tooltip("Attach node tag that will be given to the dynamic attach node")]
    public string FloatingAttachNodeTag;
    [Tooltip("Local position of the floating node relative to the part")]
    [KSPDefinition]
    public Vector3 FloatingNodePosition;
    [KSPDefinition]
    [Tooltip("Local direction that the floating node moves when the Length value is changed")]
    public Vector3 FloatingNodeDirection;
    [KSPDefinition]
    [Tooltip("Whether the floating attach node will produce a multi-joint connection")]
    public bool FloatingNodeIsMultiJoint;
    [KSPDefinition]
    [Tooltip("If FloatingNodeIsMultiJoint, the amount of joints the array should have")]
    public int FloatingNodeMultiJointMaxCount;
    [Tooltip("If FloatingNodeIsMultiJoint, the distance between joints. Does nothing otherwise")]
    [KSPDefinition]
    public float FloatingNodeMultiJointOffset;
    [Tooltip("ID of the attach node, other than the floater, that will yield an automatic fairing")]
    [Header("Fairing construction parameters")]
    [KSPDefinition]
    public string FairingNode;
    [Tooltip("How \"pointy\" the cap panel is")]
    [KSPDefinition]
    public float NoseTip;
    [Tooltip("Roughness of the sides of the mesh.")]
    [KSPDefinition]
    public float EdgeWarp;
    [Tooltip("Max steepness to prevent normal artifacting in the mesh")]
    [KSPDefinition]
    public float AberrantNormalLimit;
    [Tooltip("The \"up\" direction of the fairing")]
    [KSPDefinition]
    public Vector3 LocalUpAxis;
    [Tooltip("The relative center of the procedural mesh")]
    [KSPDefinition]
    public Vector3 Pivot;
    [KSPDefinition]
    [Tooltip("Name of the base object")]
    public string BaseModelTransformName;
    [Tooltip("Max radius of the cap")]
    [KSPDefinition]
    public float CapRadius;
    [Tooltip("Radius of the base object")]
    [KSPDefinition]
    public float BaseRadius;
    [KSPDefinition]
    public float CloseRadius;
    [Tooltip("Max radius of a cross section")]
    [KSPDefinition]
    public float MaxRadius;
    [Tooltip("If less than this increment, new increment will be the last valid value")]
    [KSPDefinition]
    public float SnapThreshold;
    [Tooltip("Whether to create shell colliders or not")]
    [KSPDefinition]
    public bool CreateShellColliders;
    [Tooltip("Amount of colliders per cross section")]
    [KSPDefinition]
    public int NumberOfCollidersPerCrossSection;
    [Tooltip("Measure to avoid fairings being flat or too skinny")]
    [KSPDefinition]
    public float MinHeightRadiusRatio;
    [Tooltip("Min allowed height per cross section")]
    [KSPDefinition]
    public float CrossSectionHeightMin;
    [Tooltip("Max allowed height per cross section")]
    [KSPDefinition]
    public float CrossSectionHeightMax;
    [Tooltip("Whether the fairing should check its contents for aero occlusion")]
    [KSPState]
    public bool AerodynamicallyShieldContents;
    [Tooltip("Amount of rays per sweep. Used to determine payload intersection")]
    [KSPDefinition]
    public int ConeSweepRays;
    [Tooltip("Distance apart from each ray. Used to determine payload intersections")]
    [KSPDefinition]
    public float ConeSweepPrecision;
    [Tooltip("Number of colliders per arc")]
    [KSPState]
    public int AmountOfCollidersPerArc;
    [Tooltip("Whether an automatically generated fairing should be capped (does nothing for ConstructionType = Custom)")]
    [KSPDefinition]
    public bool ShouldCapOnAutoGenerate;
    [HideInInspector]
    [KSPState]
    public bool IsCapped;
    [KSPState]
    public bool IsShroud;
    [Header("Procedural Generation Tuneables")]
    [Tooltip("Mass per square unit of paneling")]
    [KSPDefinition]
    public float MassAreaRatio;
    [Tooltip("Max amount of edges that the 3D mesh will have. More sides is more rounded but more RAM usage")]
    [KSPDefinition]
    public int FairingSideCount;
    [Tooltip("The amount of each vertical \"step\" increment when VAB snap is on")]
    [KSPDefinition]
    public float FairingLengthSnapIncrement;
    [KSPDefinition]
    [Tooltip("The amount of each horizontal \"step\" increment when VAB snap is on")]
    public float FairingRadiusSnapIncrement;
    [KSPDefinition]
    [Tooltip("The smoothing angle of the fairing mesh, in degrees")]
    public float FairingSmoothingAngle;
    [Tooltip("The thickness of the fairing mesh")]
    [KSPDefinition]
    public float FairingThickness;
    [Tooltip("Position along the fairing axis on the host part where the procedural mesh starts. Zero = part prefab origin")]
    [KSPDefinition]
    public float FairingStartHeight;
    [Header("Procedural Controls")]
    [Tooltip("Allow change of construction mode in the PAM")]
    [KSPDefinition]
    public bool AllowConstructionTypeChange;
    [KSPDefinition]
    [Tooltip("Allow change of floating node vis in the PAM")]
    public bool AllowFloatingNodeChange;
    [KSPDefinition]
    [Tooltip("Whether the fairing will be enabled by default")]
    public bool DefaultFairingEnabledToggle;
    [Tooltip("Whether the fairing will have automatic construction set by default")]
    [KSPDefinition]
    public bool DefaultAutoConstruction;
    [Tooltip("Deploy Type set by default")]
    [KSPDefinition]
    public FairingDeployType DefaultDeployType;
    [Tooltip("The starting state of the floating node")]
    [KSPDefinition]
    public bool DefaultFloatingNodeState;
    [KSPDefinition]
    [Tooltip("The minimum distance of the Length value. Should be greater or equal to the min cross section length")]
    public float LengthEditMinimum;
    [KSPDefinition]
    [Tooltip("The maximum distance of the Length value")]
    public float LengthEditMaximum;
    [KSPDefinition]
    [Tooltip("The default distance of the Length value")]
    public float LengthEditDefault;
    [KSPDefinition]
    [Tooltip("Default value for the Staging toggle")]
    public bool StageToggleDefault;
    [Tooltip("The highest part radius an auto-generated fairing should target when constructing. Part size index, [0,10] range, -1 being automatic")]
    [KSPDefinition]
    public int MaxAutoFairingTargetRadius;
    [KSPDefinition]
    [Tooltip("The smallest part radius an auto-generated fairing should target when constructing. Part size index, [0,10] range, -1 being automatic")]
    public int MinAutoFairingTargetRadius;
    [KSPState(CopyToSymmetrySet = true)]
    public List<FairingCrossSection> CrossSections;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    public float MassModifierAmount;
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public int DragCubeIndex;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetLengthString(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetEjectionForceString(object value) => throw null;

    public float MassModifier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsValidConfiguration() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNumberOfGroupsForDeployType(FairingDeployType deployType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsStageableDeployType(FairingDeployType deployType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Fairing() => throw null;
  }
}
