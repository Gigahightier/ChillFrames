﻿using System.Numerics;
using System.Reflection;
using Dalamud.Interface;
using Dalamud.Interface.Internal.Notifications;
using Dalamud.Interface.Windowing;
using ImGuiNET;

namespace ChillFrames
{
    internal class SaveAndCloseButtons
    {
        private readonly Window targetWindow;

        public SaveAndCloseButtons(Window targetWindow)
        {
            this.targetWindow = targetWindow;
        }

        public void Draw()
        {
            ImGui.SetCursorPos(new Vector2(5, ImGui.GetWindowHeight() - 30 * ImGuiHelpers.GlobalScale));

            if (ImGui.Button($"Save", ImGuiHelpers.ScaledVector2(100, 25)))
            {
                Service.PluginInterface.UiBuilder.AddNotification("Configuration Saved", "Daily Duty", NotificationType.Success);
                Service.Configuration.Save();
            }

            ImGui.SameLine(ImGui.GetWindowWidth() - 105 * ImGuiHelpers.GlobalScale);

            if (ImGui.Button($"Save & Close", ImGuiHelpers.ScaledVector2(100, 25)))
            {
                Service.PluginInterface.UiBuilder.AddNotification("Configuration Saved", "Daily Duty", NotificationType.Success);
                Service.Configuration.Save();
                targetWindow.IsOpen = false;
            }
        }
    }
}