﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIList_ListView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.UI.Binding.Core;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.UI.Binding
{
  public class UIList_ListView : UIListBinder
  {
    [FormerlySerializedAs("keysToInject")]
    [Header("Values Injected in each view element")]
    public ContextListView.InjectKeys injectKeys;
    [Header("Leave blank to get prefab from context")]
    [SerializeField]
    protected ContextBindRoot elementPrefab;
    [SerializeField]
    [Header("if set will be resolve Element Prefab")]
    protected string elementPropertyKeyPath;
    [SerializeField]
    [Header("if set will resolve Element Pool")]
    protected string _elementPoolPropetyKeyPath;
    protected MultiDragDropLogic multiDragDropLogic;
    [Header("if set will be resolve MultiDragDropLogic Reference")]
    [SerializeField]
    protected string multiDragDropPropertyKeyPath;
    private bool multiDragDropAdded;
    protected HighlightedDragDropLogic highlightedDragDropLogic;
    [SerializeField]
    [Tooltip("If set will be resolve HighlightDragDropLogic Reference")]
    protected string highlightedDragDropPropertyKeyPath;
    private bool highlightedDragDropAdded;
    [SerializeField]
    protected string useHighlightedDragDropPropertyKeyPath;
    [Space]
    public Transform elementContainer;
    [SerializeField]
    protected bool destroyChildrenOnStart;
    [SerializeField]
    [Space]
    protected bool reverseOrder;
    protected GameObjectPool<ContextBindRoot> _elementPool;
    public UIList_ListView.ElementModifyDelegate modifyElementOnCreation;
    public UIList_ListView.ElementModifyDelegate modifyElementOnDeletion;
    public RectTransform DragDropDummyObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void HandleListRebind() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CheckForKeyRebinds(IDataContextReadonly context) => throw null;

    public ContextListView ListView
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetSourceIndexFromUnityIndex(int unityChildIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ManageListViewCreation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private UIList_ListElement CreateListElement(Transform newParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyListElement(UIList_ListElement toDelete) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIList_ListView() => throw null;

    public delegate void ElementModifyDelegate(UIList_ListElement elementPrefab);
  }
}
