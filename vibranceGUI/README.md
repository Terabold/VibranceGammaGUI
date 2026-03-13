# VibranceGammaGUI v2.0.0 - VibranceGUI+ Enhanced Edition

VibranceGammaGUI is an enhanced Windows utility written in C# that provides advanced control over NVIDIA's Digital Vibrance and optimized gamma/shadow boost settings for Games. This modern edition features mathematical precision gamma ramps, hardware-level NVAPI access, and mutual exclusivity controls for maximum stability.

> [!NOTE]
> **Vibe Coded Disclaimer**: I didn't bother checking exactly how everything works under the hood, but it works! It's vibe coded.

> [!IMPORTANT]
> **NVIDIA GPU ONLY**: This software communicates directly with NVIDIA driver APIs (NVAPI) and Windows Gamma Ramps. Hard-requirement: NVIDIA Graphics Card.

## Technical Compatibility & Limitations

### Why Games and not Chrome/Desktop Apps?
You might notice that gamma/vibrance changes apply perfectly to games but don't seem to affect applications like Google Chrome or the general Windows desktop consistently. 

**Here's why**:
- **Exclusive Access**: Games often use "Exclusive Fullscreen" or specific DirectX/Vulkan rendering paths that obey the hardware gamma ramp we manipulate.
- **App-Level Color Management**: Modern browsers like Chrome and many Windows 10/11 apps use advanced color management or "Composite Redirection" (WDDM) which can bypass or override global gamma ramps to ensure their own UI looks "correct" regardless of global settings.
- **Hardware Overlays**: Some apps use hardware overlays that the driver treats differently than a standard 3D game.

**VibranceGUI+ is optimized for 3D Game Environments where performance and visual clarity are critical.**

## Support the Developer

If you find VibranceGammaGUI helpful and would like to support its ongoing development, please consider making a donation:

**[💎 Donate via PayPal](https://www.paypal.com/donate/?hosted_button_id=C8MSD3F55XDPY)**

Your support helps fund bug fixes, new features, and continued maintenance of this enhanced edition. Every contribution is deeply appreciated!

## Compiling

When compiling, make sure to compile for x86 target platform.  

## Contributing

Every contribution is greatly appreciated. Do not hesitate to submit issues and pull requests.

For bug reports and feature requests, please use the GitHub issues section.
