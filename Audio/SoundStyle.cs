﻿// Decompiled with JetBrains decompiler
// Type: Terraria.Audio.SoundStyle
// Assembly: Terraria, Version=1.3.4.4, Culture=neutral, PublicKeyToken=null
// MVID: DEE50102-BCC2-472F-987B-153E892583F1
// Assembly location: C:\Users\Zhi Cai\Documents\terraria source\Terraria1.3.4.4\Terraria\Terraria-cleaned.exe

using Microsoft.Xna.Framework.Audio;
using Terraria.Utilities;

namespace Terraria.Audio
{
  public abstract class SoundStyle
  {
    private static UnifiedRandom _random = new UnifiedRandom();
    private float _volume;
    private float _pitchVariance;
    private SoundType _type;

    public float Volume
    {
      get
      {
        return this._volume;
      }
    }

    public float PitchVariance
    {
      get
      {
        return this._pitchVariance;
      }
    }

    public SoundType Type
    {
      get
      {
        return this._type;
      }
    }

    public abstract bool IsTrackable { get; }

    public SoundStyle(float volume, float pitchVariance, SoundType type = SoundType.Sound)
    {
      this._volume = volume;
      this._pitchVariance = pitchVariance;
      this._type = type;
    }

    public SoundStyle(SoundType type = SoundType.Sound)
    {
      this._volume = 1f;
      this._pitchVariance = 0.0f;
      this._type = type;
    }

    public float GetRandomPitch()
    {
      return (float) ((double) SoundStyle._random.NextFloat() * (double) this.PitchVariance - (double) this.PitchVariance * 0.5);
    }

    public abstract SoundEffect GetRandomSound();
  }
}