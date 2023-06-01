﻿// Decompiled with JetBrains decompiler
// Type: RTG.GameObjectTypeHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RTG
{
  public static class GameObjectTypeHelper
  {
    private static int _numTypes;
    private static List<GameObjectType> _allObjectTypes;
    private static GameObjectType _allCombined;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GameObjectTypeHelper() => throw null;

    public static int NumTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static GameObjectType[] AllObjectTypes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static GameObjectType AllCombined
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is3DObjectType(GameObjectType objectType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DObjectType(GameObjectType objectType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasVolume(GameObjectType objectType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsTypeBitSet(int objectTypeMask, GameObjectType typeBit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int SetTypeBit(int objectTypeMask, GameObjectType typeBit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ClearTypeBit(int objectTypeMask, GameObjectType typeBit) => throw null;
  }
}
