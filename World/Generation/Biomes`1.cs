﻿// Decompiled with JetBrains decompiler
// Type: Terraria.World.Generation.Biomes`1
// Assembly: Terraria, Version=1.3.4.4, Culture=neutral, PublicKeyToken=null
// MVID: DEE50102-BCC2-472F-987B-153E892583F1
// Assembly location: C:\Users\Zhi Cai\Documents\terraria source\Terraria1.3.4.4\Terraria\Terraria-cleaned.exe

using Microsoft.Xna.Framework;
using System;

namespace Terraria.World.Generation
{
  public static class Biomes<T> where T : MicroBiome, new()
  {
    private static T _microBiome = Biomes<T>.CreateInstance();

    public static bool Place(int x, int y, StructureMap structures)
    {
      return Biomes<T>._microBiome.Place(new Point(x, y), structures);
    }

    public static bool Place(Point origin, StructureMap structures)
    {
      return Biomes<T>._microBiome.Place(origin, structures);
    }

    public static T Get()
    {
      return Biomes<T>._microBiome;
    }

    private static T CreateInstance()
    {
      T instance = Activator.CreateInstance<T>();
      BiomeCollection.Biomes.Add((MicroBiome) instance);
      return instance;
    }
  }
}
