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
    
    public class AllShaders
    {
        private static bool iscompiled = false;
        private static byte[] shader_bytes = new byte[5824] {
91, 160, 31, 37, 138, 96, 227, 128, 4, 56, 191, 121, 68, 74, 78, 118, 192, 186, 128, 59, 172, 62, 184, 0, 42, 202, 90, 204, 67, 251,
224, 248, 54, 181, 54, 95, 28, 241, 136, 71, 232, 228, 68, 246, 181, 90, 243, 191, 187, 151, 83, 111, 158, 169, 98, 41, 65, 111, 156, 54,
164, 56, 197, 10, 186, 188, 0, 150, 226, 255, 217, 82, 93, 85, 245, 117, 171, 177, 246, 136, 231, 1, 168, 181, 18, 195, 179, 31, 236, 68,
105, 16, 133, 157, 158, 132, 177, 35, 61, 208, 126, 133, 51, 12, 146, 8, 204, 201, 164, 237, 39, 77, 182, 233, 9, 61, 97, 16, 72, 28,
71, 75, 223, 225, 229, 233, 209, 233, 34, 101, 177, 228, 151, 165, 0, 101, 69, 233, 207, 213, 88, 155, 255, 159, 63, 211, 86, 50, 232, 28,
247, 193, 162, 79, 81, 165, 50, 119, 238, 146, 170, 207, 206, 157, 63, 239, 120, 37, 45, 160, 17, 195, 56, 111, 222, 128, 244, 165, 77, 44,
105, 55, 38, 170, 2, 220, 37, 37, 65, 155, 182, 74, 91, 232, 255, 0, 160, 31, 174, 125, 218, 43, 90, 13, 36, 245, 237, 230, 111, 10,
168, 207, 232, 250, 102, 3, 83, 0, 52, 182, 194, 171, 100, 242, 38, 175, 8, 182, 126, 63, 166, 190, 216, 40, 109, 232, 86, 17, 7, 4,
207, 187, 207, 112, 196, 198, 248, 189, 63, 99, 97, 0, 226, 137, 241, 220, 250, 49, 150, 109, 187, 186, 239, 109, 73, 104, 246, 8, 73, 142,
38, 247, 238, 183, 222, 24, 226, 136, 211, 215, 114, 252, 169, 249, 252, 239, 251, 82, 201, 32, 53, 51, 227, 235, 54, 228, 59, 175, 201, 247,
212, 60, 230, 214, 205, 33, 141, 77, 109, 167, 155, 191, 125, 237, 161, 168, 12, 37, 35, 131, 228, 184, 0, 152, 114, 212, 193, 221, 93, 206,
250, 115, 21, 125, 226, 55, 190, 46, 233, 204, 213, 188, 39, 180, 113, 232, 208, 198, 165, 198, 51, 17, 250, 166, 190, 87, 148, 166, 34, 41,
194, 110, 180, 95, 0, 34, 110, 181, 54, 114, 29, 121, 237, 69, 183, 73, 139, 207, 169, 161, 148, 23, 19, 188, 102, 149, 42, 239, 190, 45,
209, 184, 154, 170, 73, 101, 199, 59, 18, 55, 151, 13, 0, 76, 7, 25, 90, 57, 5, 137, 94, 102, 0, 93, 108, 103, 64, 208, 60, 74,
219, 61, 149, 145, 30, 238, 136, 241, 43, 158, 136, 238, 191, 187, 133, 181, 231, 23, 36, 72, 5, 92, 154, 104, 50, 104, 165, 168, 216, 44,
95, 92, 23, 253, 165, 37, 115, 134, 2, 144, 254, 6, 128, 138, 251, 123, 92, 215, 96, 175, 254, 158, 221, 102, 98, 164, 53, 59, 143, 144,
165, 51, 111, 251, 73, 153, 230, 210, 113, 175, 101, 61, 38, 209, 93, 223, 212, 254, 202, 169, 99, 245, 6, 55, 53, 129, 238, 226, 95, 61,
191, 107, 163, 251, 137, 165, 13, 0, 172, 171, 54, 97, 183, 46, 246, 49, 158, 244, 64, 55, 157, 92, 227, 213, 250, 224, 103, 153, 116, 49,
133, 32, 152, 214, 168, 75, 132, 140, 123, 237, 199, 97, 75, 69, 97, 164, 165, 46, 150, 2, 65, 197, 210, 209, 39, 165, 93, 163, 145, 108,
52, 214, 29, 248, 232, 178, 153, 129, 28, 103, 58, 21, 86, 155, 120, 131, 249, 204, 194, 190, 157, 16, 157, 1, 58, 6, 2, 109, 214, 237,
23, 24, 114, 230, 56, 25, 215, 198, 161, 62, 24, 64, 20, 38, 242, 57, 228, 93, 38, 18, 113, 86, 112, 214, 118, 85, 39, 199, 240, 215,
178, 221, 203, 167, 181, 130, 255, 248, 204, 46, 10, 25, 160, 179, 100, 205, 148, 233, 147, 188, 105, 15, 85, 141, 8, 240, 121, 132, 30, 188,
17, 7, 211, 188, 78, 0, 16, 127, 10, 44, 40, 247, 180, 129, 208, 205, 196, 127, 28, 24, 155, 213, 242, 188, 249, 58, 0, 75, 143, 25,
169, 16, 190, 43, 198, 44, 146, 55, 127, 105, 127, 58, 128, 79, 38, 151, 37, 27, 201, 23, 200, 114, 92, 104, 237, 11, 234, 121, 10, 198,
192, 135, 177, 99, 59, 122, 139, 19, 125, 128, 59, 248, 227, 76, 174, 48, 31, 204, 244, 100, 152, 58, 244, 157, 206, 168, 136, 42, 219, 210,
174, 64, 160, 113, 97, 81, 154, 99, 70, 84, 189, 95, 178, 173, 209, 180, 191, 114, 202, 59, 181, 80, 243, 243, 37, 66, 154, 236, 159, 140,
64, 86, 62, 102, 4, 250, 116, 86, 118, 188, 113, 108, 8, 32, 182, 183, 83, 182, 207, 15, 0, 123, 6, 20, 240, 200, 90, 239, 204, 252,
32, 233, 119, 0, 42, 103, 91, 51, 121, 44, 4, 111, 159, 14, 50, 15, 184, 249, 244, 39, 225, 116, 50, 222, 153, 65, 225, 15, 167, 139,
72, 201, 16, 80, 234, 27, 179, 243, 253, 61, 100, 201, 26, 38, 211, 159, 139, 42, 88, 89, 163, 239, 67, 184, 190, 53, 235, 112, 68, 147,
246, 2, 73, 185, 14, 197, 76, 173, 220, 4, 27, 169, 140, 60, 87, 194, 206, 233, 183, 171, 214, 104, 72, 73, 64, 7, 69, 203, 108, 239,
73, 128, 143, 155, 53, 224, 145, 231, 179, 117, 165, 205, 161, 17, 39, 65, 149, 61, 61, 236, 72, 48, 5, 232, 34, 27, 94, 2, 195, 69,
16, 119, 243, 80, 20, 219, 91, 135, 133, 156, 247, 153, 38, 25, 203, 152, 15, 141, 212, 107, 183, 229, 36, 90, 209, 235, 180, 87, 166, 189,
62, 38, 34, 74, 113, 216, 78, 193, 120, 77, 11, 17, 186, 77, 11, 227, 221, 83, 6, 72, 122, 12, 115, 144, 234, 121, 178, 23, 99, 121,
103, 5, 228, 96, 91, 142, 214, 46, 219, 43, 198, 105, 243, 169, 202, 215, 56, 240, 237, 207, 72, 25, 149, 81, 19, 163, 38, 104, 17, 36,
15, 8, 163, 62, 253, 196, 170, 24, 86, 9, 35, 234, 152, 162, 224, 157, 90, 24, 79, 157, 178, 166, 34, 55, 72, 41, 6, 157, 84, 202,
211, 167, 136, 84, 85, 166, 39, 138, 157, 98, 195, 177, 43, 164, 226, 158, 55, 161, 212, 215, 160, 150, 70, 90, 79, 79, 89, 161, 102, 249,
228, 48, 43, 67, 105, 156, 18, 129, 26, 99, 47, 137, 32, 139, 113, 183, 255, 255, 5, 116, 115, 20, 169, 51, 85, 84, 28, 46, 136, 172,
227, 123, 163, 126, 203, 41, 85, 100, 163, 196, 105, 49, 74, 109, 245, 43, 75, 159, 0, 93, 23, 215, 174, 23, 187, 81, 33, 121, 117, 43,
152, 24, 102, 106, 66, 116, 39, 35, 73, 9, 33, 243, 144, 93, 240, 30, 55, 59, 15, 28, 199, 109, 141, 143, 202, 96, 23, 7, 132, 35,
91, 8, 4, 172, 176, 24, 58, 247, 2, 73, 24, 106, 67, 137, 182, 106, 244, 200, 229, 208, 101, 144, 116, 21, 123, 200, 148, 208, 110, 67,
162, 121, 253, 134, 240, 212, 88, 97, 77, 14, 37, 106, 246, 110, 213, 232, 152, 66, 11, 85, 201, 93, 139, 219, 74, 60, 123, 15, 54, 13,
119, 248, 232, 150, 108, 64, 75, 84, 65, 223, 121, 65, 43, 69, 91, 130, 83, 134, 177, 189, 226, 82, 163, 14, 91, 73, 46, 33, 61, 92,
114, 219, 45, 241, 140, 201, 216, 161, 194, 85, 164, 91, 51, 186, 35, 200, 155, 101, 72, 110, 147, 198, 24, 117, 141, 197, 230, 58, 25, 212,
28, 234, 54, 229, 169, 206, 13, 111, 191, 99, 188, 93, 99, 105, 212, 124, 237, 143, 230, 104, 148, 2, 67, 60, 60, 6, 132, 42, 176, 79,
32, 161, 74, 101, 246, 64, 20, 106, 14, 238, 4, 245, 81, 155, 212, 33, 107, 85, 253, 216, 42, 78, 30, 44, 117, 213, 122, 21, 24, 160,
121, 57, 13, 238, 173, 188, 182, 123, 112, 202, 49, 83, 211, 12, 32, 36, 35, 0, 109, 155, 167, 162, 238, 244, 159, 19, 199, 117, 182, 221,
71, 252, 106, 206, 251, 193, 107, 101, 87, 153, 46, 173, 187, 99, 231, 22, 210, 220, 132, 42, 77, 189, 71, 32, 107, 188, 57, 233, 230, 184,
171, 2, 195, 150, 67, 204, 188, 83, 155, 181, 250, 25, 180, 143, 24, 208, 151, 194, 203, 126, 13, 6, 248, 40, 186, 12, 154, 104, 151, 42,
183, 195, 174, 235, 5, 198, 135, 202, 161, 92, 234, 155, 214, 138, 164, 40, 36, 86, 143, 46, 144, 7, 51, 46, 246, 21, 163, 172, 154, 147,
30, 166, 123, 123, 90, 107, 232, 59, 56, 254, 163, 15, 95, 64, 250, 246, 109, 28, 227, 34, 42, 100, 200, 126, 62, 162, 253, 67, 92, 31,
250, 106, 129, 120, 82, 212, 92, 94, 53, 142, 125, 70, 215, 218, 168, 129, 92, 241, 96, 124, 108, 45, 216, 55, 100, 105, 70, 247, 171, 11,
2, 128, 97, 24, 159, 97, 145, 42, 3, 228, 254, 2, 150, 122, 90, 0, 74, 179, 122, 26, 116, 212, 11, 72, 182, 249, 233, 81, 71, 254,
217, 180, 231, 236, 34, 61, 177, 164, 67, 124, 241, 24, 20, 123, 229, 160, 199, 76, 4, 211, 77, 60, 0, 146, 120, 24, 182, 22, 133, 84,
6, 40, 11, 150, 179, 168, 232, 105, 155, 77, 146, 187, 29, 102, 38, 67, 241, 46, 23, 58, 90, 52, 158, 35, 46, 86, 97, 1, 112, 157,
182, 142, 228, 129, 234, 126, 113, 110, 75, 76, 222, 164, 148, 3, 108, 158, 140, 241, 155, 91, 121, 132, 96, 3, 182, 44, 148, 138, 28, 98,
135, 112, 93, 164, 177, 87, 90, 215, 253, 202, 76, 45, 21, 115, 192, 250, 180, 110, 166, 123, 205, 229, 78, 110, 180, 145, 21, 170, 112, 25,
144, 78, 153, 26, 79, 210, 38, 109, 205, 166, 148, 53, 232, 118, 199, 79, 156, 123, 64, 213, 228, 117, 235, 157, 166, 1, 103, 70, 204, 98,
60, 254, 39, 172, 39, 53, 107, 49, 67, 34, 228, 203, 54, 237, 249, 101, 123, 186, 16, 205, 140, 123, 106, 240, 64, 130, 108, 131, 65, 193,
30, 137, 222, 237, 21, 210, 49, 231, 18, 245, 191, 121, 146, 103, 243, 66, 197, 182, 246, 52, 41, 98, 72, 72, 28, 23, 62, 146, 97, 16,
155, 87, 11, 136, 48, 65, 146, 147, 132, 73, 42, 250, 10, 145, 219, 177, 66, 13, 20, 234, 88, 161, 6, 11, 181, 8, 49, 108, 114, 121,
132, 15, 237, 55, 64, 66, 205, 10, 37, 248, 126, 143, 55, 145, 53, 46, 47, 95, 56, 116, 232, 50, 22, 36, 116, 140, 169, 25, 190, 72,
6, 166, 184, 136, 7, 238, 152, 175, 39, 153, 229, 56, 75, 20, 42, 136, 108, 88, 180, 80, 253, 133, 18, 165, 56, 75, 17, 106, 74, 40,
105, 214, 249, 155, 31, 41, 1, 127, 201, 103, 94, 124, 118, 94, 198, 250, 153, 94, 6, 210, 153, 114, 149, 67, 16, 4, 89, 64, 86, 178,
226, 165, 141, 49, 55, 126, 113, 110, 255, 23, 123, 110, 67, 12, 130, 14, 19, 180, 132, 67, 84, 5, 177, 74, 168, 32, 70, 70, 206, 138,
130, 150, 96, 160, 246, 130, 110, 32, 215, 103, 217, 225, 5, 215, 61, 217, 161, 133, 134, 246, 3, 102, 19, 138, 251, 246, 184, 248, 73, 68,
185, 6, 176, 173, 87, 54, 106, 192, 133, 17, 4, 144, 55, 170, 17, 197, 219, 36, 32, 76, 8, 249, 230, 216, 113, 101, 37, 147, 199, 46,
13, 180, 3, 30, 232, 21, 236, 41, 35, 180, 183, 54, 208, 254, 150, 96, 30, 49, 190, 170, 35, 21, 39, 4, 162, 105, 213, 190, 186, 89,
110, 49, 229, 204, 197, 178, 177, 229, 124, 133, 197, 97, 197, 149, 79, 16, 243, 233, 95, 182, 39, 61, 160, 29, 110, 159, 10, 147, 14, 99,
105, 81, 241, 118, 240, 20, 24, 194, 109, 152, 74, 112, 63, 125, 2, 0, 15, 234, 39, 57, 255, 14, 226, 24, 122, 12, 154, 167, 99, 237,
136, 208, 242, 3, 111, 65, 235, 119, 28, 213, 79, 237, 238, 175, 109, 233, 16, 19, 229, 117, 246, 67, 130, 190, 81, 66, 182, 249, 23, 215,
90, 187, 17, 97, 248, 66, 40, 37, 232, 50, 1, 216, 39, 107, 62, 199, 111, 120, 83, 238, 77, 252, 230, 203, 173, 155, 146, 107, 178, 18,
95, 34, 5, 72, 195, 89, 6, 191, 158, 232, 141, 205, 95, 43, 171, 203, 169, 223, 50, 199, 185, 228, 145, 135, 103, 64, 158, 164, 109, 57,
6, 18, 225, 234, 79, 247, 62, 156, 122, 135, 163, 1, 107, 89, 53, 73, 110, 176, 228, 244, 95, 149, 143, 78, 189, 181, 157, 69, 23, 125,
234, 43, 82, 221, 141, 126, 199, 40, 170, 164, 249, 42, 119, 220, 98, 32, 150, 1, 109, 178, 90, 95, 233, 183, 236, 43, 13, 64, 216, 139,
32, 234, 171, 67, 158, 183, 134, 159, 31, 115, 112, 121, 17, 26, 239, 137, 148, 3, 0, 172, 115, 42, 5, 0, 68, 132, 170, 178, 49, 10,
144, 0, 57, 241, 114, 229, 178, 239, 234, 165, 215, 78, 2, 29, 132, 198, 83, 246, 24, 167, 37, 243, 140, 27, 113, 6, 166, 220, 49, 62,
130, 46, 98, 83, 51, 113, 10, 164, 227, 80, 173, 241, 153, 157, 83, 220, 1, 70, 131, 189, 150, 51, 53, 187, 71, 194, 35, 14, 198, 14,
31, 139, 5, 175, 82, 191, 99, 24, 207, 19, 151, 100, 96, 182, 186, 219, 146, 54, 247, 11, 247, 90, 35, 234, 42, 178, 24, 59, 48, 17,
244, 121, 209, 52, 242, 165, 55, 247, 216, 251, 29, 17, 30, 114, 220, 187, 70, 198, 210, 213, 73, 111, 185, 37, 215, 65, 9, 112, 185, 249,
133, 163, 166, 161, 1, 87, 131, 159, 99, 158, 0, 29, 19, 250, 4, 88, 147, 194, 59, 252, 236, 132, 194, 84, 9, 143, 223, 28, 66, 97,
134, 203, 35, 89, 124, 95, 113, 131, 44, 161, 32, 187, 24, 233, 229, 41, 137, 208, 102, 22, 193, 110, 54, 84, 217, 145, 96, 191, 224, 211,
131, 231, 132, 89, 21, 58, 55, 124, 172, 174, 79, 252, 224, 193, 236, 205, 135, 251, 177, 141, 108, 105, 83, 160, 7, 92, 52, 29, 156, 73,
237, 7, 236, 241, 238, 248, 200, 185, 180, 0, 94, 73, 38, 234, 201, 188, 215, 115, 135, 3, 141, 85, 248, 146, 142, 243, 159, 207, 196, 144,
175, 18, 25, 9, 15, 150, 210, 189, 62, 60, 164, 141, 3, 41, 102, 197, 231, 143, 200, 82, 66, 210, 96, 7, 188, 133, 145, 8, 254, 249,
22, 57, 50, 57, 124, 232, 41, 4, 201, 111, 142, 7, 207, 12, 48, 10, 159, 184, 136, 15, 201, 236, 3, 0, 169, 18, 120, 248, 47, 223,
196, 0, 0, 172, 168, 78, 60, 166, 145, 50, 201, 104, 158, 235, 15, 184, 199, 255, 247, 32, 167, 99, 89, 182, 162, 52, 200, 30, 187, 184,
210, 26, 130, 200, 141, 126, 181, 56, 80, 110, 154, 92, 159, 210, 177, 124, 126, 92, 145, 79, 82, 251, 165, 229, 10, 81, 137, 203, 170, 33,
232, 191, 26, 92, 249, 224, 102, 213, 109, 238, 6, 29, 5, 26, 57, 15, 101, 110, 174, 220, 150, 99, 152, 226, 254, 227, 213, 16, 99, 199,
135, 88, 207, 225, 66, 244, 121, 123, 255, 148, 238, 89, 208, 65, 247, 220, 148, 205, 148, 200, 140, 149, 248, 139, 81, 0, 0, 89, 19, 253,
172, 132, 154, 135, 89, 182, 133, 238, 7, 230, 123, 19, 110, 242, 4, 140, 186, 139, 193, 189, 111, 29, 23, 205, 189, 252, 65, 130, 203, 109,
232, 62, 192, 134, 212, 154, 225, 155, 207, 201, 172, 48, 127, 243, 20, 38, 95, 53, 153, 156, 123, 139, 207, 86, 245, 102, 12, 231, 177, 88,
239, 56, 254, 185, 223, 45, 0, 191, 27, 26, 93, 162, 97, 251, 204, 68, 133, 103, 198, 62, 196, 29, 0, 224, 76, 83, 41, 0, 32, 231,
159, 239, 82, 40, 211, 32, 113, 175, 42, 206, 48, 239, 7, 0, 68, 27, 191, 135, 134, 2, 184, 159, 86, 225, 155, 225, 222, 81, 131, 45,
134, 186, 152, 34, 151, 134, 180, 14, 126, 9, 142, 136, 86, 152, 62, 46, 247, 150, 131, 27, 14, 0, 32, 83, 92, 75, 153, 154, 206, 70,
184, 250, 68, 223, 165, 114, 10, 214, 47, 181, 120, 205, 30, 255, 10, 6, 0, 132, 130, 117, 6, 75, 21, 161, 9, 227, 155, 253, 98, 85,
249, 236, 96, 91, 7, 40, 154, 154, 67, 35, 224, 26, 4, 102, 34, 251, 29, 10, 101, 26, 146, 188, 0, 79, 185, 3, 104, 110, 0, 32,
176, 1, 15, 199, 98, 3, 230, 100, 33, 0, 128, 20, 108, 72, 75, 2, 225, 58, 74, 50, 79, 0, 0, 152, 113, 184, 166, 70, 117, 206,
179, 49, 155, 42, 74, 160, 184, 24, 79, 0, 80, 64, 194, 55, 162, 131, 177, 225, 72, 158, 128, 179, 48, 133, 40, 206, 169, 145, 138, 3,
0, 60, 24, 190, 8, 0, 20, 5, 14, 187, 178, 37, 74, 23, 0, 192, 80, 203, 198, 93, 133, 52, 147, 129, 255, 15, 0, 224, 85, 27,
32, 145, 106, 10, 242, 218, 152, 128, 100, 93, 84, 51, 226, 43, 53, 13, 118, 99, 7, 1, 54, 171, 36, 18, 1, 0, 208, 160, 67, 90,
118, 157, 13, 144, 135, 242, 4, 0, 128, 201, 103, 3, 40, 87, 117, 19, 173, 20, 75, 151, 50, 149, 227, 72, 43, 3, 128, 131, 202, 83,
242, 132, 162, 60, 233, 67, 228, 236, 110, 119, 137, 234, 176, 215, 82, 249, 237, 136, 197, 162, 112, 195, 225, 121, 62, 196, 58, 126, 250, 30,
220, 60, 186, 159, 77, 251, 147, 0, 54, 163, 252, 236, 180, 17, 119, 0, 128, 51, 196, 23, 1, 128, 220, 220, 113, 115, 8, 229, 58, 69,
226, 69, 9, 3, 0, 200, 46, 254, 202, 70, 174, 21, 235, 131, 126, 16, 0, 64, 95, 203, 36, 39, 211, 37, 147, 47, 105, 177, 141, 196,
238, 228, 13, 171, 143, 96, 70, 111, 0, 157, 224, 117, 254, 97, 57, 23, 0, 64, 25, 15, 105, 137, 56, 203, 36, 209, 6, 108, 137, 10,
8, 17, 0, 64, 79, 11, 178, 81, 249, 116, 0, 176, 111, 252, 202, 197, 164, 48, 34, 101, 66, 32, 234, 3, 192, 222, 253, 235, 37, 29,
227, 147, 1, 0, 20, 24, 171, 229, 201, 215, 138, 77, 66, 63, 8, 0, 0, 177, 21, 147, 169, 233, 150, 129, 91, 190, 136, 71, 62, 119,
183, 145, 93, 185, 20, 48, 182, 143, 222, 202, 17, 124, 134, 162, 12, 11, 52, 8, 0, 160, 162, 135, 180, 149, 21, 147, 170, 3, 182, 108,
12, 228, 9, 0, 160, 189, 91, 185, 158, 183, 194, 147, 33, 169, 195, 245, 121, 82, 199, 169, 149, 44, 122, 186, 36, 125, 181, 167, 203, 191,
0, 125, 99, 164, 104, 252, 167, 223, 47, 218, 147, 196, 19, 142, 36, 122, 217, 65, 38, 158, 242, 164, 107, 145, 35, 190, 173, 23, 204, 115,
198, 37, 206, 27, 118, 61, 253, 196, 63, 199, 148, 13, 135, 220, 135, 238, 52, 252, 61, 148, 95, 97, 54, 227, 143, 181, 132, 28, 225, 217,
110, 112, 40, 79, 242, 182, 114, 10, 82, 245, 11, 9, 169, 66, 0, 112, 202, 82, 45, 26, 123, 153, 235, 7, 0, 28, 153, 109, 230, 1,
20, 112, 105, 245, 33, 44, 226, 183, 235, 91, 20, 8, 10, 46, 54, 42, 229, 113, 201, 161, 151, 185, 27, 236, 150, 196, 81, 95, 226, 179,
27, 77, 104, 179, 85, 93, 141, 192, 72, 218, 214, 116, 80, 73, 28, 2, 128, 139, 53, 192, 206, 49, 168, 225, 3, 142, 38, 162, 1, 0,
203, 6, 105, 232, 233, 24, 118, 35, 110, 219, 13, 217, 122, 203, 254, 22, 110, 90, 76, 92, 58, 104, 58, 244, 82, 11, 14, 124, 229, 190,
101, 23, 140, 247, 106, 207, 63, 143, 55, 67, 175, 205, 230, 58, 8, 162, 130, 64, 225, 112, 150, 42, 4, 0, 73, 89, 255, 174, 253, 20,
214, 4, 46, 88, 227, 208, 4, 125, 51, 205, 0, 128, 223, 83, 5, 98, 188, 195, 96, 121, 2, 252, 2, 104, 164, 144, 125, 217, 149, 164,
169, 73, 56, 101, 76, 210, 182, 54, 230, 193, 182, 2, 178, 42, 21, 179, 102, 109, 57, 104, 98, 19, 1, 64, 10, 208, 22, 138, 1, 75,
190, 3, 0, 22, 137, 169, 22, 79, 98, 149, 233, 205, 198, 253, 173, 7, 37, 199, 85, 36, 13, 96, 2, 58, 62, 226, 141, 175, 235, 47,
11, 176, 8, 78, 176, 89, 102, 0, 246, 12, 85, 189, 46, 212, 55, 231, 71, 246, 2, 205, 253, 206, 234, 18, 98, 214, 61, 107, 253, 129,
87, 201, 241, 245, 44, 215, 121, 253, 56, 179, 20, 214, 108, 180, 211, 243, 21, 202, 191, 216, 27, 231, 160, 7, 95, 198, 66, 163, 217, 183,
238, 136, 225, 125, 9, 159, 213, 175, 195, 146, 189, 254, 252, 18, 41, 87, 114, 128, 123, 104, 249, 15, 48, 158, 211, 49, 224, 114, 58, 85,
185, 64, 187, 54, 168, 167, 33, 174, 55, 232, 141, 241, 6, 145, 203, 107, 137, 8, 78, 130, 229, 45, 166, 208, 41, 127, 234, 39, 111, 196,
31, 101, 107, 114, 13, 203, 210, 107, 232, 244, 26, 183, 112, 141, 210, 229, 187, 66, 87, 87, 137, 242, 185, 151, 22, 130, 27, 102, 146, 57,
135, 43, 40, 177, 200, 156, 88, 162, 26, 107, 236, 41, 147, 117, 225, 246, 37, 160, 64, 152, 37, 241, 18, 115, 49, 11, 231, 11, 3, 197,
70, 137, 79, 81, 149, 189, 128, 232, 171, 30, 0, 0, 186, 48, 21, 33, 246, 115, 104, 1, 92, 74, 136, 2, 42, 62, 50, 166, 172, 136,
159, 175, 116, 7, 0, 74, 166, 147, 142, 95, 248, 51, 104, 213, 176, 44, 181, 134, 78, 175, 113, 43, 25, 253, 115, 104, 213, 168, 210, 107,
232, 244, 26, 183, 47, 72, 106, 45, 229, 45, 125, 89, 242, 111, 128, 86, 253, 85, 236, 2, 0, 51, 86, 198, 60, 250, 178, 235, 156, 88,
64, 235, 197, 228, 26, 152, 80, 249, 14, 139, 151, 190, 75, 125, 190, 166, 47, 110, 6, 232, 246, 222, 113, 36, 159, 245, 218, 189, 58, 228,
101, 248, 8, 224, 66, 55, 200, 30, 240, 178, 243, 153, 86, 90, 87, 51, 85, 219, 203, 110, 240, 190, 95, 230, 247, 90, 86, 85, 181, 124,
23, 143, 95, 119, 6, 229, 148, 105, 233, 244, 234, 205, 86, 221, 13, 117, 101, 197, 180, 140, 54, 239, 227, 50, 51, 143, 2, 199, 80, 50,
137, 39, 65, 54, 95, 255, 55, 230, 248, 169, 228, 213, 204, 26, 46, 11, 158, 92, 110, 165, 170, 230, 98, 129, 48, 125, 211, 178, 157, 131,
183, 217, 68, 199, 164, 72, 46, 15, 100, 162, 0, 230, 204, 113, 6, 233, 76, 188, 144, 106, 111, 43, 235, 169, 211, 125, 227, 121, 211, 79,
7, 210, 45, 135, 127, 153, 18, 207, 90, 87, 116, 212, 218, 111, 165, 79, 57, 58, 243, 72, 43, 71, 79, 2, 197, 180, 57, 160, 6, 215,
162, 32, 158, 204, 0, 172, 226, 237, 115, 43, 81, 229, 40, 136, 71, 64, 46, 82, 33, 232, 74, 98, 97, 52, 148, 81, 119, 97, 71, 135,
103, 94, 62, 88, 206, 195, 168, 121, 132, 27, 57, 210, 131, 144, 225, 139, 218, 226, 197, 124, 207, 232, 93, 152, 232, 154, 222, 251, 161, 227,
186, 160, 35, 32, 53, 211, 175, 252, 50, 152, 202, 115, 190, 226, 149, 25, 151, 192, 163, 62, 79, 21, 32, 87, 104, 226, 186, 105, 235, 95,
105, 240, 132, 121, 119, 174, 10, 110, 189, 98, 242, 25, 163, 120, 27, 60, 183, 25, 198, 106, 233, 189, 125, 102, 210, 206, 191, 92, 17, 144,
36, 135, 51, 71, 211, 134, 214, 85, 164, 88, 75, 245, 244, 250, 98, 104, 54, 219, 211, 28, 140, 57, 136, 37, 17, 70, 103, 85, 13, 232,
173, 62, 120, 210, 171, 165, 214, 49, 194, 205, 107, 154, 50, 57, 208, 98, 95, 77, 238, 165, 179, 44, 103, 37, 26, 153, 58, 206, 126, 193,
57, 8, 204, 86, 24, 7, 157, 1, 6, 237, 168, 80, 133, 186, 182, 49, 183, 16, 38, 86, 209, 218, 168, 147, 129, 214, 194, 45, 239, 135,
96, 115, 124, 178, 0, 200, 132, 156, 26, 236, 154, 106, 168, 175, 65, 169, 23, 118, 218, 72, 215, 14, 205, 140, 224, 71, 4, 175, 235, 61,
200, 55, 157, 167, 13, 226, 143, 25, 241, 196, 169, 34, 2, 31, 211, 172, 148, 121, 80, 112, 93, 212, 91, 130, 54, 143, 38, 90, 157, 228,
1, 6, 108, 192, 209, 60, 72, 228, 4, 184, 50, 215, 153, 52, 99, 31, 48, 101, 41, 110, 106, 201, 97, 117, 17, 181, 63, 113, 253, 115,
61, 102, 179, 146, 114, 192, 2, 30, 104, 40, 64, 58, 196, 221, 68, 147, 37, 74, 63, 109, 216, 81, 59, 253, 43, 46, 110, 44, 141, 47,
155, 143, 218, 241, 189, 215, 121, 195, 43, 190, 60, 128, 26, 254, 249, 238, 125, 91, 235, 43, 96, 2, 0, 22, 195, 231, 31, 42, 170, 221,
68, 213, 58, 181, 169, 170, 111, 178, 78, 203, 181, 169, 170, 31, 249, 214, 41, 183, 7, 155, 78, 200, 101, 72, 107, 98, 27, 129, 118, 101,
96, 234, 186, 121, 0, 171, 6, 0, 110, 40, 165, 1, 146, 45, 209, 202, 6, 158, 245, 169, 90, 26, 120, 34, 41, 236, 220, 134, 156, 56,
213, 184, 170, 61, 96, 18, 229, 236, 242, 14, 122, 5, 227, 100, 188, 1, 0, 231, 13, 60, 148, 145, 111, 236, 1, 0, 150, 157, 217, 21,
187, 97, 98, 156, 1, 64, 83, 178, 153, 254, 104, 120, 239, 75, 30, 33, 133, 119, 178, 100, 2, 142, 184, 52, 127, 9, 0, 200, 82, 68,
19, 0, 216, 115, 7, 226, 216, 109, 234, 102, 134, 27, 141, 55, 136, 91, 131, 196, 176, 124, 10, 18, 5, 0, 172, 150, 23, 222, 87, 178,
188, 169, 151, 41, 46, 239, 92, 75, 245, 142, 10, 138, 53, 148, 207, 25, 195, 139, 103, 216, 100, 110, 126, 180, 253, 139, 248, 229, 37, 59,
250, 217, 85, 111, 178, 253, 11, 145, 222, 126, 46, 70, 220, 21, 198, 121, 138, 40, 91, 125, 220, 249, 0, 254, 15, 211, 60, 246, 133, 130,
99, 97, 211, 21, 31, 125, 76, 51, 155, 202, 188, 184, 93, 121, 8, 104, 140, 179, 207, 32, 165, 232, 125, 35, 239, 169, 226, 228, 144, 230,
47, 157, 159, 252, 175, 188, 149, 46, 218, 118, 33, 173, 211, 159, 84, 12, 0, 76, 25, 125, 213, 42, 21, 18, 191, 167, 65, 175, 119, 174,
24, 243, 48, 171, 221, 218, 191, 85, 59, 19, 145, 219, 6, 181, 1, 95, 215, 81, 173, 104, 52, 87, 193, 131, 39, 182, 32, 17, 150, 154,
150, 246, 172, 173, 76, 85, 123, 251, 148, 223, 182, 242, 142, 249, 187, 48, 67, 88, 187, 89, 211, 172, 221, 84, 141, 147, 104, 110, 144, 243,
21, 158, 19, 135, 174, 59, 38, 168, 140, 1, 169, 91, 245, 143, 1, 57, 66, 209, 228, 228, 248, 83, 154, 115, 243, 36, 65, 135, 59, 5,
0, 84, 65, 42, 8, 0, 8, 232, 177, 119, 220, 206, 54, 54, 213, 215, 134, 249, 54, 140, 46, 242, 156, 189, 91, 129, 135, 160, 252, 40,
18, 12, 0, 164, 138, 226, 23, 213, 246, 210, 205, 51, 3, 0, 153, 66, 189, 36, 197, 199, 127, 45, 162, 147, 167, 117, 221, 13, 154, 238,
213, 117, 216, 107, 230, 87, 23, 194, 103, 120, 233, 146, 198, 103, 239, 213, 98, 244, 204, 24, 139, 151, 165, 199, 11, 181, 70, 185, 92, 32,
86, 20, 0, 208, 236, 168, 32, 0, 32, 241, 199, 102, 241, 34, 117, 42, 114, 208, 24, 92, 30, 143, 205, 90, 189, 134, 160, 76, 29, 138,
10, 0, 164, 89, 26, 210, 171, 229, 67, 55, 173, 66, 45, 117, 144, 73, 146, 14, 190, 71, 188, 44, 235, 253, 123, 255, 254, 207, 170, 222,
114, 49, 91, 171, 115, 75, 138, 46, 158, 247, 39, 18, 143, 94, 190, 182, 86, 35, 151, 78, 230, 214, 216, 201, 250, 174, 95, 162, 84, 199,
95, 154, 72, 196, 73, 65, 136, 243, 130, 214, 47, 189, 62, 27, 189, 125, 179, 116, 171, 243, 242, 153, 77, 203, 192, 192, 200, 213, 109, 118,
104, 116, 75, 87, 85, 186, 217, 180, 248, 129, 145, 64, 32, 160, 216, 120, 217, 25, 89, 201, 223, 13, 126, 207, 160, 237, 211, 130, 112, 122,
239, 186, 102, 101, 107, 238, 149, 175, 248, 147, 87, 9, 183, 114, 81, 191, 36, 205, 236, 74, 70, 171, 152, 132, 214, 16, 27, 30, 63, 127,
163, 222, 7, 63, 214, 159, 92, 58, 74, 23, 160, 52, 25, 34, 24, 235, 62, 49, 156, 200, 137, 183, 97, 186, 171, 50, 6, 85, 34, 113,
196, 47, 66, 248, 234, 116, 196, 75, 11, 36, 133, 87, 56, 131, 124, 40, 148, 87, 154, 0, 141, 63, 250, 43, 12, 114, 200, 213, 206, 25,
34, 120, 250, 244, 199, 156, 106, 50, 67, 238, 178, 109, 228, 233, 144, 55, 127, 21, 103, 6, 235, 177, 179, 63, 48, 188, 50, 143, 238, 242,
90, 220, 103, 142, 137, 192, 246, 93, 208, 87, 241, 149, 219, 57, 84, 70, 108, 173, 248, 106, 55, 77, 111, 72, 150, 250, 238, 105, 168, 7,
152, 155, 199, 209, 147, 166, 206, 142, 155, 41, 198, 205, 255, 246, 83, 126, 95, 105, 86, 218, 158, 238, 131, 173, 66, 111, 228, 157, 19, 64,
86, 92, 118, 231, 26, 233, 255, 116, 26, 129, 30, 200, 108, 180, 150, 180, 189, 89, 51, 64, 66, 74, 196, 103, 62, 170, 95, 27, 234, 154,
6, 17, 88, 30, 191, 22, 110, 83, 77, 42, 195, 57, 179, 175, 29, 211, 46, 9, 100, 67, 165, 148, 78, 105, 169, 38, 47, 92, 102, 143,
143, 130, 204, 18, 217, 52, 76, 200, 95, 7, 3, 99, 61, 218, 23, 83, 126, 132, 46, 162, 241, 34, 187, 124, 143, 84, 139, 248, 11, 252,
109, 183, 109, 238, 46, 202, 114, 200, 71, 244, 10, 165, 5, 14, 194, 72, 22, 51, 199, 186, 103, 133, 205, 165, 186, 97, 65, 25, 150, 178,
81, 158, 181, 201, 239, 197, 155, 103, 181, 118, 230, 73, 50, 186, 210, 70, 73, 39, 184, 207, 178, 29, 65, 189, 67, 91, 143, 142, 174, 253,
227, 86, 42, 154, 35, 146, 136, 54, 114, 22, 217, 58, 139, 170, 182, 74, 61, 149, 81, 194, 223, 111, 239, 133, 111, 31, 180, 172, 121, 93,
49, 141, 73, 30, 212, 126, 6, 204, 145, 38, 109, 73, 27, 171, 73, 46, 37, 163, 79, 67, 163, 177, 24, 49, 158, 122, 136, 71, 170, 131,
42, 117, 221, 215, 252, 210, 191, 179, 158, 124, 135, 90, 105, 189, 20, 10, 76, 113, 189, 244, 42, 43, 175, 87, 114, 90, 201, 107, 152, 207,
190, 74, 236, 13, 167, 48, 83, 136, 197, 77, 57, 132, 38, 17, 28, 141, 255, 172, 56, 124, 149, 126, 40, 21, 98, 235, 153, 198, 12, 74,
75, 22, 46, 161, 88, 220, 25, 135, 188, 240, 117, 52, 209, 23, 185, 165, 60, 249, 164, 15, 252, 66, 76, 103, 229, 20, 208, 142, 12, 49,
202, 176, 24, 55, 222, 200, 21, 251, 63, 34, 197, 133, 99, 134, 208, 182, 150, 122, 253, 192, 160, 247, 88, 112, 126, 39, 57, 215, 114, 179,
188, 118, 64, 87, 125, 134, 99, 176, 1, 19, 216, 56, 79, 153, 149, 38, 179, 137, 201, 119, 81, 47, 202, 155, 26, 37, 145, 157, 214, 173,
179, 231, 131, 153, 121, 251, 153, 45, 103, 188, 81, 138, 222, 70, 116, 236, 81, 242, 193, 201, 85, 163, 110, 72, 73, 219, 222, 206, 101, 173,
117, 234, 145, 144, 37, 195, 44, 159, 54, 213, 64, 26, 170, 81, 152, 13, 96, 230, 172, 217, 94, 108, 3, 204, 161, 29, 167, 17, 25, 160,
5, 24, 115, 219, 170, 122, 29, 95, 171, 76, 103, 117, 79, 145, 130, 155, 206, 69, 14, 114, 57, 131, 101, 84, 2, 73, 186, 53, 15, 226,
127, 156, 248, 190, 172, 157, 227, 151, 74, 186, 210, 73, 71, 49, 137, 50, 61, 145, 39, 177, 7, 232, 118, 253, 68, 80, 118, 216, 145, 43,
227, 210, 108, 233, 234, 128, 252, 102, 218, 11, 198, 142, 145, 134, 111, 159, 154, 44, 117, 136, 111, 3, 193, 73, 238, 152, 94, 13, 194, 44,
235, 220, 80, 53, 17, 175, 239, 113, 101, 135, 58, 55, 238, 223, 111, 175, 140, 177, 49, 176, 69, 90, 199, 192, 195, 118, 37, 97, 67, 163,
5, 153, 146, 40, 104, 209, 7, 141, 245, 184, 229, 187, 78, 81, 182, 235, 216, 252, 159, 175, 215, 76, 160, 17, 68, 236, 10, 145, 157, 66,
39, 30, 245, 9, 159, 1, 135, 236, 82, 11, 227, 57, 205, 227, 180, 240, 4, 64, 116, 219, 173, 139, 196, 183, 121, 40, 42, 174, 249, 31,
211, 38, 5, 134, 51, 174, 96, 231, 243, 193, 183, 160, 220, 113, 43, 31, 3, 136, 10, 228, 253, 67, 157, 248, 246, 233, 137, 216, 196, 166,
150, 196, 83, 36, 169, 101, 115, 244, 120, 131, 213, 253, 67, 221, 123, 57, 34, 225, 173, 250, 152, 64, 247, 102, 232, 209, 97, 204, 87, 231,
142, 6, 66, 50
};
        public static void Compile()
        {
            if (iscompiled)
            {
                return;
            }
            iscompiled = true;
            ShaderVariables.Log("Compiling all shaders");
            string shadersrc;
            shadersrc = ShCompHelper.FromArray(shader_bytes);
            AsteroidBand.Compile(shadersrc);
            Atmosphere.Compile(shadersrc);
            Basic_PositionColor.Compile(shadersrc);
            Basic_PositionNormalColorTexture.Compile(shadersrc);
            Basic_PositionNormalTexture.Compile(shadersrc);
            Basic_PositionNormalTextureTwo.Compile(shadersrc);
            Basic_PositionTexture.Compile(shadersrc);
            Basic_Skinned.Compile(shadersrc);
            Billboard.Compile(shadersrc);
            DepthPass_AlphaTest.Compile(shadersrc);
            DepthPass_Normal.Compile(shadersrc);
            DetailMap2Dm1Msk2PassMaterial.Compile(shadersrc);
            DetailMapMaterial.Compile(shadersrc);
            EnvMapTest.Compile(shadersrc);
            IllumDetailMapMaterial.Compile(shadersrc);
            Masked2DetailMapMaterial.Compile(shadersrc);
            NebulaExtPuff.Compile(shadersrc);
            NebulaInterior.Compile(shadersrc);
            NebulaMaterial.Compile(shadersrc);
            Nomad.Compile(shadersrc);
            Normals.Compile(shadersrc);
            Particle.Compile(shadersrc);
            PhysicsDebug.Compile(shadersrc);
            Polyline.Compile(shadersrc);
            Projectile.Compile(shadersrc);
            SunRadial.Compile(shadersrc);
            SunSpine.Compile(shadersrc);
            ZoneVolume.Compile(shadersrc);
        }
    }
}
