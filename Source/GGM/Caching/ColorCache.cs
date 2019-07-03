﻿using System.Collections.Generic;
using GGM.Config;
using UnityEngine;
using UnityEngine.UI;
using UnityEngineInternal;

namespace GGM.Caching
{
    public class ColorCache
    {
        public static Dictionary<Color, Texture2D> colors = null;

        public Color Value { get; }

        public Texture2D Texture;

        public ColorCache(Color color)
        {
            Value = color;
            Cache(color);
            Texture = GetTexture2D(color);
        }

        public static readonly ColorCache Black = new ColorCache(Color.black);
        public static readonly ColorCache Blue = new ColorCache(Color.blue);
        public static readonly ColorCache Clear = new ColorCache(Color.clear);
        public static readonly ColorCache Cyan = new ColorCache(Color.cyan);
        public static readonly ColorCache Empty = new ColorCache(new Color(0f, 0f, 0f, 0f));
        public static readonly ColorCache Gray = new ColorCache(Color.gray);
        public static readonly ColorCache Green = new ColorCache(Color.green);
        public static readonly ColorCache Grey = new ColorCache(Color.grey);
        public static readonly ColorCache Magenta = new ColorCache(Color.magenta);
        public static readonly ColorCache Melon = new ColorCache(new Color(0.992f, 0.737f, 0.706f));
        public static readonly ColorCache Froly = new ColorCache(new Color(0.941f, 0.502f, 0.502f));
        public static readonly ColorCache Orange = new ColorCache(new Color(1f, 0.35f, 0f, 1f));
        public static readonly ColorCache RC = new ColorCache(new Color(1f, 0.753f, 0f, 1f));
        public static readonly ColorCache Red = new ColorCache(Color.red);
        public static readonly ColorCache White = new ColorCache(Color.white);
        public static readonly ColorCache Yellow = new ColorCache(Color.yellow);

        private static void Cache(Color color)
        {
            if (colors == null) colors = new Dictionary<Color, Texture2D>();
            colors.Add(color, new Texture2D(1, 1, TextureFormat.ARGB32, false));
        }

        private static Texture2D GetTexture2D(Color color)
        {
            if (colors == null) return null;
            colors[color].SetPixel(0, 0, color);
            colors[color].Apply();
            return colors[color];
        }

        public static implicit operator Color(ColorCache color)
        {
            return color.Value;
        }
    }
}