﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.StagingUIBindRoot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI
{
  public class StagingUIBindRoot : ContextBindRoot
  {
    [Space(order = 0)]
    [SerializeField]
    [Header("The Subcontext we will inject", order = 2)]
    [Header("==== Data To Inject ===", order = 1)]
    private string uiSubContextKey;
    [Header("Properties to inject")]
    public string isAllExpandedKey;
    public bool isAllExpandedValue;
    public string isPartMoveVisibleKey;
    public bool isPartMoveVisibleValue;
    public bool useHighlightDragDropLogic;
    public string useHighlightedDragDropLogicKey;
    [Header("Prefabs To Inject")]
    public string stageElementPrefabKey;
    public ContextBindRoot flightStageElementPrefab;
    [Space]
    [FormerlySerializedAs("partGroupElementPrefabKey")]
    public string partElementPrefabKey;
    [FormerlySerializedAs("flightPartGroupElementPrefab")]
    public ContextBindRoot flightPartElementPrefab;
    [Space]
    [FormerlySerializedAs("partFolderElementPrefabKey")]
    public string partGroupElementPrefabKey;
    [FormerlySerializedAs("flightPartFolderElementPrefab")]
    public ContextBindRoot flightPartGroupElementPrefab;
    [Space]
    public string stageBinPrefabKey;
    public ContextBindRoot flightStageBinPrefab;
    public MultiDragDropLogic MultiDragDropLogic;
    public string multiDragDropLogicKey;
    public HighlightedDragDropLogic HighlightedDragDropLogic;
    public string highlightedDragDropLogicKey;
    [Space(order = 1)]
    [Header("==== Elements To Bind ===", order = 2)]
    public RectTransform stagingBinLocator;
    private const string PROPERTY_STAGE_ELEMENT_POOL_KEY = "stageElementPool";
    private const string PROPERTY_PART_ELEMENT_POOL_KEY = "partElementPool";
    private const string PROPERTY_PART_GROUP_ELEMENT_POOL_KEY = "partGroupElementPool";
    private const string PROPERTY_STAGE_BIN_POOL_KEY = "stageBinPool";
    private GameObjectPool<ContextBindRoot> _stageElementPrefabPool;
    private GameObjectPool<ContextBindRoot> _partElementPrefabPool;
    private GameObjectPool<ContextBindRoot> _partGroupElementPrefabPool;
    private GameObjectPool<ContextBindRoot> _stageBinPrefabPool;

    public PropertyExternal<bool> IsAllExpandedProp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<bool> IsPartMoveVisibleProp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PropertyExternal<bool> useHighlightDragDropLogicValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private PropertyReadonly<ContextBindRoot> StageElementPrefab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private PropertyReadonly<ContextBindRoot> PartPrefabProp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private PropertyReadonly<ContextBindRoot> PartGroupPrefabProp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private PropertyReadonly<ContextBindRoot> StageBinPrefab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private PropertyReadonly<MultiDragDropLogic> MultiDragDropLogicComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private PropertyReadonly<HighlightedDragDropLogic> HighlightedDragDropLogicComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private DataContext UISubContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingUIBindRoot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void BindContext(IDataContextReadonly parentContext) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;
  }
}
