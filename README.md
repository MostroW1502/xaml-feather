# xaml-feather
XAML version of feathericons for usage in WPF.

[FeatherIcons Github Page](https://github.com/feathericons/feather)
[FeatherIcons Webpage](https://feathericons.com)

Basic usage:

Copy the FeatherIcons.xaml file to your project by including it as an existing item or drag it unto your project.

Open up your "App.xaml" file and add these lines between the application resources tags.

<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    <ResourceDictionary Source="pack://application:,,,/Resources/FeatherIcons.xaml"/>
  </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>

To use an icon you can refer to it as a "StaticResource" e.g.

<Button Grid.Column="0" HorizontalAlignment="Stretch" VerticalAlignment="Stretch" Padding="3" Margin="3">
  <ContentControl Content="{StaticResource File}"/>
</Button>

This would create a button with the File icon drawn unto it's surface.

Icons can be added programatically as well, check the example application code for usage!
