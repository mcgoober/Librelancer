﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreLancer.Shaders
{
    using System;
    
    public class DetailMap2Dm1Msk2PassMaterial
    {
        static ShaderVariables[] variants;
        private static bool iscompiled = false;
        private static int GetIndex(ShaderFeatures features)
        {
            ShaderFeatures masked = (features & ((ShaderFeatures)(16)));
            if ((masked == ((ShaderFeatures)(16))))
            {
                return 1;
            }
            return 0;
        }
        public static ShaderVariables Get(ShaderFeatures features)
        {
            AllShaders.Compile();
            return variants[GetIndex(features)];
        }
        public static ShaderVariables Get()
        {
            AllShaders.Compile();
            return variants[0];
        }
        internal static void Compile(string sourceBundle)
        {
            if (iscompiled)
            {
                return;
            }
            iscompiled = true;
            ShaderVariables.Log("Compiling DetailMap2Dm1Msk2PassMaterial");
            variants = new ShaderVariables[2];
            if (GLExtensions.Features430)
            {
                variants[0] = ShaderVariables.Compile(sourceBundle.Substring(248669, 1450), sourceBundle.Substring(250119, 7053));
                variants[1] = ShaderVariables.Compile(sourceBundle.Substring(263861, 4374), sourceBundle.Substring(268235, 2997));
            }
            else
            {
                variants[0] = ShaderVariables.Compile(sourceBundle.Substring(243112, 1109), sourceBundle.Substring(244221, 4448));
                variants[1] = ShaderVariables.Compile(sourceBundle.Substring(257172, 4033), sourceBundle.Substring(261205, 2656));
            }
        }
    }
}
