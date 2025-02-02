﻿// Decompiled with JetBrains decompiler
// Type: KSP.Research.ResearchDevelopmentTechTreeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Research
{
  [Obsolete("System has been replaced by KSP.Game.Science.RDCenterUIController")]
  public class ResearchDevelopmentTechTreeController : KerbalMonoBehaviour
  {
    public const string RD_TECH_TREE_PREFAB = "ResearchDevelopmentTechTree.prefab";
    public TechnologyNode TechNodePrefab;
    public ContextBindRoot BindRoot;
    [SerializeField]
    private RectTransform _pinMapBoundries;
    [SerializeField]
    private GameObject _panel1;
    private bool _isLoaded;
    private Camera _rdCamera;
    private TechnologyContextData _data;
    private TechnologyNode _firstNode;

    public bool IsLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 PinMapBoundries
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTechTree(string lastSelectedNode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private TechnologyNode GetTechnologyByID(TechnologyContextData techData, string ID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetNodeOrder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTechNodesSelection(string selectedNodeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTechNodesSelection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetRDCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RDCameraEnable(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResearchDevelopmentTechTreeController() => throw null;
  }
}
