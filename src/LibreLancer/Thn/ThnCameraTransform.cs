﻿// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

using System;
using System.Numerics;

namespace LibreLancer.Thn
{
	public class ThnCameraTransform
	{
		public float FovH = 17;
		public float AspectRatio = 4f / 3f;
		public Vector3 Position = Vector3.Zero;
		public Matrix4x4 Orientation = Matrix4x4.Identity;
        public float Znear = 2.5f;
        public float Zfar = 10000000f;
    }
}
