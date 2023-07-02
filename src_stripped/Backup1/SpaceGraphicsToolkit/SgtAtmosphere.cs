﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtAtmosphere
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace SpaceGraphicsToolkit
{
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtAtmosphere")]
  [RequireComponent(typeof (SgtSharedMaterial))]
  [ExecuteInEditMode]
  [AddComponentMenu("Space Graphics Toolkit/SGT Atmosphere")]
  public class SgtAtmosphere : MonoBehaviour
  {
    [SerializeField]
    [FormerlySerializedAs("Color")]
    private Color color;
    [SerializeField]
    [FormerlySerializedAs("Brightness")]
    private float brightness;
    [SerializeField]
    [FormerlySerializedAs("RenderQueue")]
    private SgtRenderQueue renderQueue;
    [SerializeField]
    [FormerlySerializedAs("InnerDepthTex")]
    private Texture innerDepthTex;
    [SerializeField]
    [FormerlySerializedAs("InnerMeshRadius")]
    private float innerMeshRadius;
    [SerializeField]
    [FormerlySerializedAs("OuterDepthTex")]
    private Texture2D outerDepthTex;
    [FormerlySerializedAs("OuterMesh")]
    [SerializeField]
    private Mesh outerMesh;
    [FormerlySerializedAs("OuterMeshRadius")]
    [SerializeField]
    private float outerMeshRadius;
    [Range(0.0f, 1000f)]
    [SerializeField]
    private float outerSoftness;
    [FormerlySerializedAs("Height")]
    [SerializeField]
    private float height;
    [FormerlySerializedAs("InnerFog")]
    [SerializeField]
    private float innerFog;
    [FormerlySerializedAs("OuterFog")]
    [SerializeField]
    private float outerFog;
    [FormerlySerializedAs("Sky")]
    [SerializeField]
    private float sky;
    [FormerlySerializedAs("Middle")]
    [Range(0.0f, 1f)]
    [SerializeField]
    private float middle;
    [FormerlySerializedAs("CameraOffset")]
    [SerializeField]
    private float cameraOffset;
    [FormerlySerializedAs("Lit")]
    [SerializeField]
    private bool lit;
    [SerializeField]
    [FormerlySerializedAs("LightingTex")]
    private Texture lightingTex;
    [FormerlySerializedAs("Scattering")]
    [SerializeField]
    private bool scattering;
    [SerializeField]
    [FormerlySerializedAs("GroundScattering")]
    private bool groundScattering;
    [FormerlySerializedAs("ScatteringTex")]
    [SerializeField]
    private Texture scatteringTex;
    [FormerlySerializedAs("ScatteringStrength")]
    [SerializeField]
    private float scatteringStrength;
    [FormerlySerializedAs("ScatteringMie")]
    [SerializeField]
    private float scatteringMie;
    [FormerlySerializedAs("ScatteringRayleigh")]
    [SerializeField]
    private float scatteringRayleigh;
    [SerializeField]
    [FormerlySerializedAs("Night")]
    private bool night;
    [FormerlySerializedAs("NightSky")]
    [SerializeField]
    private float nightSky;
    [FormerlySerializedAs("NightEase")]
    [SerializeField]
    private SgtEase.Type nightEase;
    [FormerlySerializedAs("NightStart")]
    [SerializeField]
    [Range(0.0f, 1f)]
    private float nightStart;
    [Range(0.0f, 1f)]
    [FormerlySerializedAs("NightEnd")]
    [SerializeField]
    private float nightEnd;
    [FormerlySerializedAs("NightPower")]
    [SerializeField]
    private float nightPower;
    [SerializeField]
    private SgtAtmosphereModel model;
    [NonSerialized]
    private Material innerMaterial;
    [NonSerialized]
    private Material outerMaterial;
    [NonSerialized]
    private SgtSharedMaterial cachedSharedMaterial;
    [NonSerialized]
    private bool cachedSharedMaterialSet;
    [NonSerialized]
    private Transform cachedTransform;
    [NonSerialized]
    private bool cachedTransformSet;

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Brightness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtRenderQueue RenderQueue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture InnerDepthTex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float InnerMeshRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D OuterDepthTex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Mesh OuterMesh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float OuterMeshRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float OuterSoftness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHeight(float value) => throw null;

    public float InnerFog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInnerFog(float value) => throw null;

    public float OuterFog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOuterFog(float value) => throw null;

    public float Sky
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Middle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CameraOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Lit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture LightingTex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool Scattering
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool GroundScattering
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture ScatteringTex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScatteringStrength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScatteringStrength(float value) => throw null;

    public float ScatteringMie
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScatteringMie(float value) => throw null;

    public float ScatteringRayleigh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScatteringRayleigh(float value) => throw null;

    public bool Night
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float NightSky
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtEase.Type NightEase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float NightStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float NightEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float NightPower
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float OuterRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Material InnerMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtSharedMaterial CachedSharedMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInnerDepthTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateOuterDepthTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLightingTex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateScatteringTex() => throw null;

    [ContextMenu("Update Materials")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterials() => throw null;

    [ContextMenu("Update Model")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtAtmosphere Create(int layer = 0, Transform parent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SgtAtmosphere Create(
      int layer,
      Transform parent,
      Vector3 localPosition,
      Quaternion localRotation,
      Vector3 localScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPreCull(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CameraPreRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetSky(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CacheTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtAtmosphere() => throw null;
  }
}
