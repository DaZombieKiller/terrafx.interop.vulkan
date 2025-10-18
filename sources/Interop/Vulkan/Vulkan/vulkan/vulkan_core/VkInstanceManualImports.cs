// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkInstanceManualImports
{
    public delegate* unmanaged[Stdcall]<VkInstance, uint*, VkPhysicalDeviceGroupProperties*, VkResult> vkEnumeratePhysicalDeviceGroupsKHR;

    public delegate* unmanaged[Stdcall]<VkInstance, VkDebugReportCallbackCreateInfoEXT*, VkAllocationCallbacks*, VkDebugReportCallbackEXT*, VkResult> vkCreateDebugReportCallbackEXT;

    public delegate* unmanaged[Stdcall]<VkInstance, VkDebugReportCallbackEXT, VkAllocationCallbacks*, void> vkDestroyDebugReportCallbackEXT;

    public delegate* unmanaged[Stdcall]<VkInstance, VkDebugReportFlagsEXT, VkDebugReportObjectTypeEXT, ulong, nuint, int, sbyte*, sbyte*, void> vkDebugReportMessageEXT;

    public delegate* unmanaged[Stdcall]<VkInstance, VkDebugUtilsMessengerCreateInfoEXT*, VkAllocationCallbacks*, VkDebugUtilsMessengerEXT*, VkResult> vkCreateDebugUtilsMessengerEXT;

    public delegate* unmanaged[Stdcall]<VkInstance, VkDebugUtilsMessengerEXT, VkAllocationCallbacks*, void> vkDestroyDebugUtilsMessengerEXT;

    public delegate* unmanaged[Stdcall]<VkInstance, VkDebugUtilsMessageSeverityFlagsEXT, VkDebugUtilsMessageTypeFlagsEXT, VkDebugUtilsMessengerCallbackDataEXT*, void> vkSubmitDebugUtilsMessageEXT;

    public delegate* unmanaged[Stdcall]<VkInstance, VkHeadlessSurfaceCreateInfoEXT*, VkAllocationCallbacks*, VkSurfaceKHR*, VkResult> vkCreateHeadlessSurfaceEXT;
}
