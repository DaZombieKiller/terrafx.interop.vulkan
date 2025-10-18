// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkCommandBufferManualImports
{
    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkVideoBeginCodingInfoKHR*, void> vkCmdBeginVideoCodingKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkVideoEndCodingInfoKHR*, void> vkCmdEndVideoCodingKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkVideoCodingControlInfoKHR*, void> vkCmdControlVideoCodingKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkVideoDecodeInfoKHR*, void> vkCmdDecodeVideoKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkRenderingInfo*, void> vkCmdBeginRenderingKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, void> vkCmdEndRenderingKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetDeviceMaskKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> vkCmdDispatchBaseKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkWriteDescriptorSet*, void> vkCmdPushDescriptorSetKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkDescriptorUpdateTemplate, VkPipelineLayout, uint, void*, void> vkCmdPushDescriptorSetWithTemplateKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkRenderPassBeginInfo*, VkSubpassBeginInfo*, void> vkCmdBeginRenderPass2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkSubpassBeginInfo*, VkSubpassEndInfo*, void> vkCmdNextSubpass2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkSubpassEndInfo*, void> vkCmdEndRenderPass2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectCountKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndexedIndirectCountKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkExtent2D*, VkFragmentShadingRateCombinerOpKHR*, void> vkCmdSetFragmentShadingRateKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkEvent, VkDependencyInfo*, void> vkCmdSetEvent2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkEvent, VkPipelineStageFlags2, void> vkCmdResetEvent2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkEvent*, VkDependencyInfo*, void> vkCmdWaitEvents2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkDependencyInfo*, void> vkCmdPipelineBarrier2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPipelineStageFlags2, VkQueryPool, uint, void> vkCmdWriteTimestamp2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPipelineStageFlags2, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarker2AMD;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyBufferInfo2*, void> vkCmdCopyBuffer2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyImageInfo2*, void> vkCmdCopyImage2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyBufferToImageInfo2*, void> vkCmdCopyBufferToImage2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyImageToBufferInfo2*, void> vkCmdCopyImageToBuffer2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBlitImageInfo2*, void> vkCmdBlitImage2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkResolveImageInfo2*, void> vkCmdResolveImage2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, ulong, void> vkCmdTraceRaysIndirect2KHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerBeginEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, void> vkCmdDebugMarkerEndEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkDebugMarkerMarkerInfoEXT*, void> vkCmdDebugMarkerInsertEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, void> vkCmdBindTransformFeedbackBuffersEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdBeginTransformFeedbackEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> vkCmdEndTransformFeedbackEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkQueryPool, uint, VkQueryControlFlags, uint, void> vkCmdBeginQueryIndexedEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkQueryPool, uint, uint, void> vkCmdEndQueryIndexedEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectByteCountEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCuLaunchInfoNVX*, void> vkCmdCuLaunchKernelNVX;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndirectCountAMD;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawIndexedIndirectCountAMD;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkConditionalRenderingBeginInfoEXT*, void> vkCmdBeginConditionalRenderingEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, void> vkCmdEndConditionalRenderingEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkViewportWScalingNV*, void> vkCmdSetViewportWScalingNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetDiscardRectangleEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdBeginDebugUtilsLabelEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, void> vkCmdEndDebugUtilsLabelEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkDebugUtilsLabelEXT*, void> vkCmdInsertDebugUtilsLabelEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkSampleLocationsInfoEXT*, void> vkCmdSetSampleLocationsEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindShadingRateImageNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkShadingRatePaletteNV*, void> vkCmdSetViewportShadingRatePaletteNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> vkCmdSetCoarseSampleOrderNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkAccelerationStructureInfoNV*, VkBuffer, ulong, uint, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> vkCmdBuildAccelerationStructureNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkAccelerationStructureNV, VkAccelerationStructureNV, VkCopyAccelerationStructureModeKHR, void> vkCmdCopyAccelerationStructureNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, VkBuffer, ulong, ulong, uint, uint, uint, void> vkCmdTraceRaysNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkAccelerationStructureNV*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPipelineStageFlags, VkBuffer, ulong, uint, void> vkCmdWriteBufferMarkerAMD;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, void> vkCmdDrawMeshTasksNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> vkCmdDrawMeshTasksIndirectCountNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkRect2D*, void> vkCmdSetExclusiveScissorNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, void*, void> vkCmdSetCheckpointNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPerformanceMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceMarkerINTEL;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPerformanceStreamMarkerInfoINTEL*, VkResult> vkCmdSetPerformanceStreamMarkerINTEL;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPerformanceOverrideInfoINTEL*, VkResult> vkCmdSetPerformanceOverrideINTEL;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, ushort, void> vkCmdSetLineStippleEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCullModeFlags, void> vkCmdSetCullModeEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkFrontFace, void> vkCmdSetFrontFaceEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPrimitiveTopology, void> vkCmdSetPrimitiveTopologyEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkViewport*, void> vkCmdSetViewportWithCountEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkRect2D*, void> vkCmdSetScissorWithCountEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, ulong*, ulong*, void> vkCmdBindVertexBuffers2EXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetDepthTestEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetDepthWriteEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCompareOp, void> vkCmdSetDepthCompareOpEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetDepthBoundsTestEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetStencilTestEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkStencilFaceFlags, VkStencilOp, VkStencilOp, VkStencilOp, VkCompareOp, void> vkCmdSetStencilOpEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkGeneratedCommandsInfoNV*, void> vkCmdPreprocessGeneratedCommandsNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkGeneratedCommandsInfoNV*, void> vkCmdExecuteGeneratedCommandsNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, uint, void> vkCmdBindPipelineShaderGroupNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkFragmentShadingRateNV, VkFragmentShadingRateCombinerOpKHR*, void> vkCmdSetFragmentShadingRateEnumNV;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkVertexInputBindingDescription2EXT*, uint, VkVertexInputAttributeDescription2EXT*, void> vkCmdSetVertexInputEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, void> vkCmdSubpassShadingHUAWEI;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkImageView, VkImageLayout, void> vkCmdBindInvocationMaskHUAWEI;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetPatchControlPointsEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetRasterizerDiscardEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetDepthBiasEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkLogicOp, void> vkCmdSetLogicOpEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetPrimitiveRestartEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, uint*, void> vkCmdSetColorWriteEnableEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkMultiDrawInfoEXT*, uint, uint, uint, void> vkCmdDrawMultiEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkMultiDrawIndexedInfoEXT*, uint, uint, uint, int*, void> vkCmdDrawMultiIndexedEXT;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, void> vkCmdBuildAccelerationStructuresKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, ulong*, uint*, uint**, void> vkCmdBuildAccelerationStructuresIndirectKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyAccelerationStructureInfoKHR*, void> vkCmdCopyAccelerationStructureKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyAccelerationStructureToMemoryInfoKHR*, void> vkCmdCopyAccelerationStructureToMemoryKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkCopyMemoryToAccelerationStructureInfoKHR*, void> vkCmdCopyMemoryToAccelerationStructureKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> vkCmdWriteAccelerationStructuresPropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, uint, uint, uint, void> vkCmdTraceRaysKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, VkStridedDeviceAddressRegionKHR*, ulong, void> vkCmdTraceRaysIndirectKHR;

    public delegate* unmanaged[Stdcall]<VkCommandBuffer, uint, void> vkCmdSetRayTracingPipelineStackSizeKHR;
}
