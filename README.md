# xaml-feather
XAML version of feathericons for usage in WPF.

[FeatherIcons Github Page](https://github.com/feathericons/feather)
[FeatherIcons Webpage](https://feathericons.com)

Basic usage:

Copy the FeatherIcons.xaml file to your project by including it as an existing item or drag it unto your project.

Open up your "App.xaml" file and add these lines between the application resources tags.

```XML
<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    <ResourceDictionary Source="pack://application:,,,/Resources/FeatherIcons.xaml"/>
  </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```

To use an icon you can refer to it as a "StaticResource" e.g.

```XML
<Button HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Padding="3" Margin="3">
  <Viewbox>
    <ContentControl Content="." ContentTemplate="{StaticResource File}"/>
  </Viewbox>
</Button>
```

This would create a button with the File icon drawn unto it's surface.

Icons can be added programatically as well, check the example application code for usage!
