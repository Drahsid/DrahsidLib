﻿using Dalamud.Plugin;

namespace DrahsidLib; 

public static class DrahsidLib {
    public static void Initialize(DalamudPluginInterface pluginInterface, DrawToolTipDelegate? DrawToolTipFn = null) {
        Service.Initialize(pluginInterface);
        if (DrawToolTipFn != null) {
            WindowDrawHelpers.DrawTooltip = DrawToolTipFn;
        }
    }
}
