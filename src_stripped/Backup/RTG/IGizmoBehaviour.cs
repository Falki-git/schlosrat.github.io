﻿// Decompiled with JetBrains decompiler
// Type: RTG.IGizmoBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace RTG
{
  public interface IGizmoBehaviour
  {
    Gizmo Gizmo { get; }

    bool IsEnabled { get; }

    void Init_SystemCall(GizmoBehaviorInitParams initParams);

    void SetEnabled(bool enabled);

    void OnAttached();

    void OnDetached();

    void OnEnabled();

    void OnDisabled();

    void OnGizmoEnabled();

    void OnGizmoDisabled();

    void OnGizmoHandlePicked(int handleId);

    bool OnGizmoCanBeginDrag(int handleId);

    void OnGizmoAttemptHandleDragBegin(int handleId);

    void OnGizmoHoverEnter(int handleId);

    void OnGizmoHoverExit(int handleId);

    void OnGizmoDragBegin(int handleId);

    void OnGizmoDragUpdate(int handleId);

    void OnGizmoDragEnd(int handleId);

    void OnGizmoUpdateBegin();

    void OnGizmoUpdateEnd();

    void OnGUI();

    void OnGizmoRender(Camera camera);
  }
}
