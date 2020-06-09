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
    
    public class NebulaInterior
    {
        private static byte[] vertex_bytes = new byte[190] {
27, 29, 1, 0, 156, 5, 57, 25, 190, 26, 162, 156, 95, 9, 101, 136, 97, 252, 184, 85, 35, 105, 6, 63, 239, 243, 94, 73, 23, 39,
53, 57, 206, 21, 252, 70, 42, 128, 184, 164, 20, 17, 22, 68, 238, 192, 30, 56, 208, 0, 176, 107, 181, 213, 74, 90, 128, 1, 181, 37,
242, 24, 122, 210, 60, 133, 116, 110, 17, 58, 192, 63, 64, 221, 12, 38, 139, 54, 174, 104, 34, 85, 116, 91, 166, 94, 17, 2, 244, 0,
197, 19, 94, 243, 168, 225, 53, 223, 30, 243, 167, 69, 84, 35, 40, 42, 212, 230, 121, 155, 149, 65, 206, 207, 135, 56, 93, 199, 243, 249,
54, 25, 174, 87, 243, 177, 127, 232, 31, 29, 211, 12, 91, 9, 62, 77, 138, 127, 153, 212, 12, 75, 206, 47, 39, 255, 97, 252, 81, 175,
121, 212, 113, 57, 223, 97, 69, 147, 116, 176, 176, 196, 24, 100, 106, 116, 193, 103, 62, 101, 153, 49, 80, 235, 161, 205, 252, 22, 172, 46,
231, 123, 44, 116, 11, 171, 29, 14, 111, 38
};
        private static byte[] fragment_bytes = new byte[160] {
27, 183, 0, 32, 28, 133, 141, 51, 217, 136, 197, 229, 239, 42, 242, 97, 140, 24, 129, 110, 44, 213, 193, 83, 125, 176, 27, 186, 96, 49,
8, 31, 154, 87, 222, 149, 116, 113, 82, 19, 19, 212, 161, 127, 79, 42, 5, 16, 168, 201, 1, 251, 47, 250, 21, 96, 22, 7, 18, 0,
180, 157, 219, 216, 240, 181, 203, 194, 17, 129, 187, 148, 139, 97, 55, 49, 60, 223, 9, 178, 188, 203, 176, 157, 4, 104, 170, 33, 199, 25,
197, 18, 222, 137, 55, 204, 218, 99, 89, 167, 86, 98, 97, 107, 107, 145, 236, 245, 95, 36, 96, 15, 204, 179, 180, 71, 221, 247, 83, 35,
233, 179, 192, 173, 9, 250, 44, 249, 124, 249, 144, 108, 253, 171, 249, 95, 178, 146, 197, 220, 16, 126, 160, 194, 34, 81, 168, 148, 201, 218,
169, 251, 126, 106, 176, 120, 232, 170, 12, 0
};
        static ShaderVariables[] variants;
        private static bool iscompiled = false;
        private static int GetIndex(ShaderFeatures features)
        {
            ShaderFeatures masked = (features & ((ShaderFeatures)(0)));
            return 0;
        }
        public static ShaderVariables Get(ShaderFeatures features)
        {
            Compile();
            return variants[GetIndex(features)];
        }
        public static ShaderVariables Get()
        {
            Compile();
            return variants[0];
        }
        public static void Compile()
        {
            if (iscompiled)
            {
                return;
            }
            iscompiled = true;
            ShaderVariables.Log("Compiling NebulaInterior");
            string vertsrc;
            string fragsrc;
            vertsrc = ShCompHelper.FromArray(vertex_bytes);
            fragsrc = ShCompHelper.FromArray(fragment_bytes);
            variants = new ShaderVariables[1];
            variants[0] = ShaderVariables.Compile(vertsrc, fragsrc, "");
        }
    }
}