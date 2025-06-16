# VR Radiation Detection Simulator

## Project Overview
This Virtual Reality project is a radiation detection simulation built using Unity and Meta's XR technology stack. It demonstrates the implementation of an interactive VR environment where users can manipulate a radiation detector to identify and analyze different types of radiation sources.

## Technical Stack
- **Engine**: Unity
- **VR SDK**: Meta XR All-in-One SDK
- **Testing Environment**: Meta XR Simulator
- **Target Platform**: Meta Quest Devices

## Core Features
1. **VR Interaction System**
   - Implemented using Meta XR's interaction framework
   - Supports both direct and distance grabbing of the detector
   - Natural hand presence and interaction in VR

2. **Radiation Detection System**
   - Radiation source detection
   - Multiple radiation types support
   - Dynamic audio-visual feedback system
   - Proximity-based detection mechanics

3. **User Feedback System**
   - Text Mesh Pro UI display showing radiation type
   - Dynamic spatial audio feedback with looping capability
   - Camera-following UI system for optimal visibility
   - Real-time status updates with proper text formatting

## Project Architecture

### Scripts Overview

1. **DetectorMechanism.cs**
   - Core radiation detector component
   - Implements event-based detection system
   - Broadcasts radiation detection events globally

2. **RadiationSource.cs**
   - Handles trigger-based radiation detection zones
   - Contains radiation type and properties
   - Implements enter/exit trigger logic

3. **RadiationData.cs**
   - Serializable data structure for radiation properties
   - Stores radiation type identifier
   - Manages associated audio feedback

4. **GameManager.cs**
   - Central game state controller
   - Processes and formats radiation detection events

5. **FollowVRSetupUI.cs**
   - Manages UI positioning in VR space
   - Implements camera-relative UI following
   - Handles UI rotation to face the user
   - Supports custom offset positioning

6. **ObjectFollower.cs**
   - Utility script for object following behavior
   - (Currently implemented as a placeholder)

## VR Implementation Details
- **Grabbing System**: Utilizes Meta XR's `Grabbable` and `DistanceGrabbable` components
- **Hand Tracking**: Full support for Meta Quest hand tracking
- **Interaction Zones**: Proximity-based radiation detection zones
- **Performance Optimization**: Optimized for VR performance requirements

## Dependencies
- Meta XR All-in-One SDK
- Meta XR Interaction Toolkit
- Meta XR Simulator (for development testing)
- TextMeshPro (for UI rendering)

## Testing
- Tested with Meta XR Simulator

This project demonstrates proficiency in:
- Meta XR SDK implementation
- Interactive VR system design