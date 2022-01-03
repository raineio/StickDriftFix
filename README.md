# StickDriftFix
Mod commissioned by @Elemental#1657 on Discord.

## Want to help out?

Shoot me an issue here, or fork, make your changes, and Pull Request it!

### Building
Visual Studio 2019 with the [BeatSaberModdingTools](https://github.com/Zingabopp/BeatSaberModdingTools) extension is the recommended development environment.
1. Check out the repository
2. Open `accsaber-plugin.sln`
3. Right-click the `accsaber-plugin` project, go to `Beat Saber Modding Tools` -> `Set Beat Saber Directory`
  * This assumes you have already set the directory for your Beat Saber game folder in `Extensions` -> `Beat Saber Modding Tools` -> `Settings...`
  * If you do not have the BeatSaberModdingTools extension, you will need to manually create a `accsaber-plugin.csproj.user` file to set the location of your game install. An example is showing below.
4. The project should now build.

**Example csproj.user File:**
```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <PropertyGroup>
    <BeatSaberDir>Full\Path\To\Beat Saber</BeatSaberDir>
  </PropertyGroup>
</Project>
```
## License
This project is licensed under the GNU GPL v3.0 License - see the [LICENSE](LICENSE) file for details.
