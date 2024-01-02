# High Effort Scrap-Posts

## Contributing

Fork this repository to make PRs to the main branch.

This project uses custom variables in `HighEffortScrapPosts.csproj.user`. Below is the template to use for your `.user` file:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current">
    <PropertyGroup>
        <DependenciesDirectory>...\Lethal Company\Lethal Company_Data\Managed</DependenciesDirectory>
        <ExportDirectory>...\Lethal Company\BepInEx\plugins</ExportDirectory>
    </PropertyGroup>

    <Target Name="CopyFiles" AfterTargets="PostBuildEvent">
        <Copy SourceFiles="$(TargetPath)" DestinationFolder="$(ExportDirectory)" />
        <Copy SourceFiles="$(TargetDir)\$(TargetName).pdb" DestinationFolder="$(ExportDirectory)" />
    </Target>
</Project>
```

`ExportDirectory` is only useful if you want to have the built files automatically put into your `plugins` folder.