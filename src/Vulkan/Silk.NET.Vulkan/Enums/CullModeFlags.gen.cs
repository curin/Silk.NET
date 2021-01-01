// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkCullModeFlags")]
    public enum CullModeFlags : int
    {
        [NativeName("Name", "VK_CULL_MODE_NONE")]
        CullModeNone = 0,
        [NativeName("Name", "VK_CULL_MODE_FRONT_BIT")]
        CullModeFrontBit = 1,
        [NativeName("Name", "VK_CULL_MODE_BACK_BIT")]
        CullModeBackBit = 2,
        [NativeName("Name", "VK_CULL_MODE_FRONT_AND_BACK")]
        CullModeFrontAndBack = 3,
    }
}
