// See https://aka.ms/new-console-template for more information

using SlowCompileUsesLotOfMem;

// Uncomment if you dare, here be dragons.
// #if WINDOWS
// if (OperatingSystem.IsWindows())
// {
//     Task.Run(() =>
//     {
//         try
//         {
//             // TODO: Reimplement FirstTimeForm to give users chance to consent
//             if (!WindowsAPI.CheckCustomUploaderExtension())
//                 WindowsAPI.CreateCustomUploaderExtension(true);
//
//             if (!WindowsAPI.CheckImageEffectExtension())
//                 WindowsAPI.CreateImageEffectExtension(true);
//
//             if (!WindowsAPI.CheckShellContextMenuButton())
//                 WindowsAPI.CreateShellContextMenuButton(true);
//
//             if (!WindowsAPI.CheckSendToMenuButton())
//                 WindowsAPI.CreateSendToMenuButton(true);
//
//             if (!WindowsAPI.CheckChromeExtensionSupport())
//                 WindowsAPI.CreateChromeExtensionSupport(true);
//
//             if (!WindowsAPI.CheckFirefoxAddonSupport())
//                 WindowsAPI.CreateFirefoxAddonSupport(true);
//         }
//         catch (Exception ex)
//         {
//             // Consider logging the exception or notifying the user
//             DebugHelper.WriteLine($"Windows API setup failed: {ex}");
//         }
//     });
// }
// #endif

var windows = Methods.GetWindowList();
foreach (var window in windows)
{
    Console.WriteLine(window.Title);
}

var pos = Methods.GetCursorPosition();
Console.WriteLine($"Cursor Position: {pos.X}, {pos.Y}");

var screen = await Methods.CaptureScreen(pos);
Console.WriteLine(screen != null ? "Screen captured." : "Capture failed.");

var foreground = Methods.GetForegroundWindow();
Console.WriteLine($"Foreground window: {foreground.Title ?? foreground.ProcessName}");

Methods.CopyText("Hello, world!");
