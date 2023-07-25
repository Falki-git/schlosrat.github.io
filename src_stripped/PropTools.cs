﻿// Decompiled with JetBrains decompiler
// Type: PropTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("KSP/Prop Tools")]
[ExecuteInEditMode]
public class PropTools : MonoBehaviour
{
  private static char[] charTrim;
  private static char[] charDelimiters;
  public string propRootDirectory;
  public List<PropTools.Prop> props;
  public Vector2 propScrollPosition;
  public Rect lastRect;
  public string filePath;
  public string filename;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool CreatePropInfoList(string propRoot) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PropTools.Prop CreatePropInfo(FileInfo file) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PropTools.Proxy CreateProxyInfo(string propName, string proxyString) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ProxyError(string propName, string proxyString) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PropTools() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static PropTools() => throw null;

  [Serializable]
  public class Proxy
  {
    public Vector3 center;
    public Vector3 size;
    public Color color;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Proxy() => throw null;
  }

  [Serializable]
  public class Prop
  {
    public string directory;
    public string configName;
    public string propName;
    public List<PropTools.Proxy> proxies;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Prop(string directory, string configName, string propName) => throw null;
  }
}
