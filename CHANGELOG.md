##### wpflib

# CHANGELOG

---

# 1.0.0 
##### 2018-01-26

- Initial release

### Added

- 'WindowBase' class file for window position and size state management.
- Save window position, size and state (maximized, minimized, normal) on application exit.
- Load and use last window position, size and state on application start.
- Event `Moved`. Triggers once after the window has been moved.
- Event `Resized`. Triggers once after the window has been resized.

Derive from `wpflib.WindowBase` instead of `System.Windows.Window` to automatically use the windows last position and size on application startup. Check the README for details how to use the DLL.