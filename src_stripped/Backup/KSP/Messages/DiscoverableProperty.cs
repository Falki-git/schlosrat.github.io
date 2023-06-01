﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.DiscoverableProperty
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [AttributeUsage(AttributeTargets.Class)]
  public class DiscoverableProperty : Attribute
  {
    public string discoveryName;
    public bool isActive;
    public string userNotes;
    public string implNotes;
    public uint ID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableProperty(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableProperty(string name, string implementationNotes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableProperty(string name, uint id, string implementationNotes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableProperty(
      string name,
      bool propertyIsActive = true,
      string UserNotes = "",
      string ImplementationNotes = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableProperty(string name, uint id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DiscoverableProperty(
      string name,
      uint id,
      bool propertyIsActive = true,
      string UserNotes = "",
      string ImplementationNotes = "")
    {
      throw null;
    }
  }
}
