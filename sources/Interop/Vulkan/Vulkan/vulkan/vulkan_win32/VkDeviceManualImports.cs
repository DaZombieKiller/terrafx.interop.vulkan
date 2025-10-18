// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceManualImports
{
    public delegate* unmanaged[Stdcall]<VkDevice, VkMemoryGetWin32HandleInfoKHR*, void**, VkResult> vkGetMemoryWin32HandleKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryWin32HandlePropertiesKHR*, VkResult> vkGetMemoryWin32HandlePropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImportSemaphoreWin32HandleInfoKHR*, VkResult> vkImportSemaphoreWin32HandleKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSemaphoreGetWin32HandleInfoKHR*, void**, VkResult> vkGetSemaphoreWin32HandleKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImportFenceWin32HandleInfoKHR*, VkResult> vkImportFenceWin32HandleKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkFenceGetWin32HandleInfoKHR*, void**, VkResult> vkGetFenceWin32HandleKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceMemory, VkExternalMemoryHandleTypeFlagsNV, void**, VkResult> vkGetMemoryWin32HandleNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, VkResult> vkAcquireFullScreenExclusiveModeEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, VkResult> vkReleaseFullScreenExclusiveModeEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkDeviceGroupPresentModeFlagsKHR*, VkResult> vkGetDeviceGroupSurfacePresentModes2EXT;
}
