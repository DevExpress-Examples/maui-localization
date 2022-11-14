<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/550126095/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1121002)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DevExpress .NET MAUI Controls - Localize Controls

This repository shows you how to localize the DevExpress .NET MAUI Scheduler. 

DevExpress .NET MAUI Controls contain localization strings that are translated into the following languages **out-of-the box**:

* [English (default language)](/CS/BasicLocalization/Resources/DevExpressMaui.resx)
* [Deutsch](/CS/BasicLocalization/Resources/DevExpressMaui.de.resx)
* [French](/CS/BasicLocalization/Resources/DevExpressMaui.fr.resx)

The repository contains the following projects:

| Project Name | Description |
|---|---|
| [BasicLocalization](/CS/BasicLocalization) | The project shows you how to use **out-of-the box** resource files. Refer to the [BasicLocalization/Resources](/CS/BasicLocalization/Resources) folder to get these resource files. |
| [CustomLanguageResource](/CS/CustomLanguageResource)| The project shows you how to use the resource file to translate our controls into the custom language (Portuguese). |
| [CustomLocalizedString](/CS/CustomLocalizedString)| The project shows you how to translate a localization string into a custom language (Spanish). |

## Files to Review

- [BasicLocalization/MauiProgram.cs](https://github.com/DevExpress-Examples/maui-localization/blob/22.2.2%2B/CS/BasicLocalization/MauiProgram.cs#L14)
- [CustomLanguageResource/App.xaml.cs](https://github.com/DevExpress-Examples/maui-localization/blob/22.2.2%2B/CS/CustomLanguageResource/App.xaml.cs#L10)
- [CustomLocalizedString/App.xaml.cs](https://github.com/DevExpress-Examples/maui-localization/blob/22.2.2%2B/CS/CustomLocalizedString/App.xaml.cs#L6)

## Documentation

- [Localization](https://docs.devexpress.com/MAUI/404120)
- [Get Started with DevExpress Controls for .NET Multi-platform App UI (.NET MAUI)](https://docs.devexpress.com/MAUI/403249/get-started/get-started)
