<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/550126095/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1121002)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DevExpress .NET MAUI Controls - Localize Controls

This repository shows how to localize the [DevExpress .NET MAUI Scheduler Control](https://docs.devexpress.com/MAUI/403734/scheduler-and-calendar/index?v=22.2). 

DevExpress .NET MAUI Controls contain localization strings that are translated into the following languages:

* [English (default language)](/CS/BasicLocalization/Resources/DevExpressMaui.resx)
* [Deutsch](/CS/BasicLocalization/Resources/DevExpressMaui.de.resx)
* [French](/CS/BasicLocalization/Resources/DevExpressMaui.fr.resx)

![image](https://user-images.githubusercontent.com/12169834/203095398-f5a50b4c-94b9-428c-9a67-23a7cf1554d8.png)


The repository contains the following projects:

| Project Name | Description |
|---|---|
| [BasicLocalization](/CS/BasicLocalization) | The project shows you how to use **built-in** resource files. Refer to the [BasicLocalization/Resources](/CS/BasicLocalization/Resources) folder to get these resource files. |
| [CustomLanguageResource](/CS/CustomLanguageResource)| The project shows how to use the resource file to translate our controls into a custom language (Portuguese). |
| [CustomLocalizedString](/CS/CustomLocalizedString)| The project shows how to translate a localization string into a custom language (Spanish). |

## Requirements

Please register the DevExpress NuGet Gallery in Visual Studio to restore the NuGet packages used in this solution. See the following topic for more information: [Get Started with DevExpress Mobile UI for .NET MAUI](https://docs.devexpress.com/MAUI/403249/get-started).

You can also refer to the following YouTube video for more information on how to get started with the DevExpress .NET MAUI Controls: [Setting up a .NET MAUI Project](https://www.youtube.com/watch?v=juJvl5UicIQ).

## Files to Review

- [BasicLocalization/MauiProgram.cs](https://github.com/DevExpress-Examples/maui-localization/blob/22.2.2%2B/CS/BasicLocalization/MauiProgram.cs#L14)
- [CustomLanguageResource/App.xaml.cs](https://github.com/DevExpress-Examples/maui-localization/blob/22.2.2%2B/CS/CustomLanguageResource/App.xaml.cs#L10)
- [CustomLocalizedString/App.xaml.cs](https://github.com/DevExpress-Examples/maui-localization/blob/22.2.2%2B/CS/CustomLocalizedString/App.xaml.cs#L6)

## Documentation

- [Localization](https://docs.devexpress.com/MAUI/404120)
- [Get Started with DevExpress Controls for .NET Multi-platform App UI (.NET MAUI)](https://docs.devexpress.com/MAUI/403249/get-started/get-started)

## More Examples

* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Data Grid](https://github.com/DevExpress-Examples/maui-data-grid-get-started)
* [Data Form](https://github.com/DevExpress-Examples/maui-data-form-get-started)
* [Data Editors](https://github.com/DevExpress-Examples/maui-editors-get-started)
* [Charts](https://github.com/DevExpress-Examples/maui-charts)
* [Scheduler](https://github.com/DevExpress-Examples/maui-scheduler-get-started)
* [Tab Page](https://github.com/DevExpress-Examples/maui-tab-page-get-started)
* [Tab View](https://github.com/DevExpress-Examples/maui-tab-view-get-started)
* [Drawer Page](https://github.com/DevExpress-Examples/maui-drawer-page-get-started)
* [Drawer View](https://github.com/DevExpress-Examples/maui-drawer-view-get-started)
* [Collection View](https://github.com/DevExpress-Examples/maui-collection-view-get-started)
* [Popup](https://github.com/DevExpress-Examples/maui-popup-get-started)
