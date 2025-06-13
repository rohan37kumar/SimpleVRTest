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
   - Visual UI display showing radiation type
   - Spatial audio feedback for detection events
   - Real-time status updates

## Project Architecture

### Scripts Overview

1. **DetectorMechanism.cs**
   - Core detection component
   - Handles trigger-based radiation detection
   - Implements event system for radiation detection
   - Maintains detector position and state

2. **RadiationSource.cs**
   - Defines radiation source behavior
   - Contains radiation type and properties
   - Interacts with detector mechanism

3. **RadiationData.cs**
   - Data structure for radiation properties
   - Serializable for Unity inspector integration
   - Stores radiation type and associated audio

4. **GameManager.cs**
   - Central game state controller
   - Manages UI updates
   - Handles audio feedback system
   - Processes radiation detection events

## VR Implementation Details
- **Grabbing System**: Utilizes Meta XR's `Grabbable` and `DistanceGrabbable` components
- **Hand Tracking**: Full support for Meta Quest hand tracking
- **Interaction Zones**: Proximity-based radiation detection zones
- **Performance Optimization**: Optimized for VR performance requirements

## Dependencies
- Meta XR All-in-One SDK
- Meta XR Interaction Toolkit
- Meta XR Simulator (for development testing)


## Design Decisions
- Event-driven architecture for loose coupling
- Modular script design for easy maintenance
- Scalable radiation type system
- VR-optimized interaction system

## Testing
- Tested with Meta XR Simulator

This project demonstrates proficiency in:
- VR development with Unity
- Meta XR SDK implementation
- Interactive VR system design
- Clean, maintainable code architecture
- Performance optimization for VR
- Event-driven programming
- Unity best practices