﻿// Decompiled with JetBrains decompiler
// Type: KSP.Assets.IAsyncHandleAccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.Assets
{
  public interface IAsyncHandleAccess
  {
    AsyncOperationHandle<GameObject> GetAsyncHandle();
  }
}
