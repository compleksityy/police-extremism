### Prerequisites
* **Visual Studio 2022** (with the `.NET desktop development` workload installed).
* **Schedule I** installed on your computer with **MelonLoader** already setup.

---

### Step-by-Step Build Instructions

1. **Extract the Project**
   * Extract the contents of `PoliceExtremism_Refactored-v2.zip` to a folder on your desktop.

2. **Open the Solution**
   * Double-click the `PoliceExtremism.csproj` file to automatically open the project in Visual Studio.

3. **Verify References (If needed)**
   * If you see yellow warning symbols under **Dependencies > Assemblies**, right-click the warning, select **Remove**, and re-add `MelonLoader.dll` and `UnityEngine.dll` directly from your game installation directory.

4. **Compile the Mod**
   * Go to the top menu bar and select **Build > Build Solution** (or press `Ctrl + Shift + B`).

5. **Install to Your Game**
   * Navigate to the project's output folder: `...\PoliceExtremism-Schedule1-main\bin\Debug\net472\`
   * Copy the newly generated **`PoliceExtremism.dll`** file.
   * Paste it directly into your game's **`Mods`** folder.

6. **Launch the Game**
   * Launch *Schedule I*. The MelonLoader console will open and log that `Police Extremism by Compleksity` has been successfully loaded.
