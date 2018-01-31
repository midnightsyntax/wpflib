##### wpflib

# CHANGELOG
---

# 1.2.0 
##### 2018-01-31

### Added

- New converter: 'NullableBoolConverter'

### Change

- Namespaces for all converters are now WpfLib.Converter
- Cleanup unused namespaces

---

# 1.1.0 
##### 2018-01-27

### Added

- Converters!
	- BoolToStringConverter
	- ColorToSolidBrushConverter
	- DoubleAddSubstractConverter
	- HeightToMarginConverter
- ViewModelBase

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