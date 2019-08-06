# Xamarin.Forms.MaskedEntry

Use mask in your Xamarin.Forms apps

Based on MaskedBehavior by [Adam Pedley](https://github.com/adamped) (https://xamarinhelp.com/masked-entry-in-xamarin-forms/).

When we need to use masks in Xamarin.Forms we end up customizing a control or using behaviors.

MaskedEntry is a custom entry to use any type of mask. just use X between the sequence of characters you want to configure.

X can be used both to demonstrate where values ​​should be in the masks, and to limit the amount of characters in a field.

###### This is the component, works on iOS, Android and UWP.

**NuGet**

|Name|Info|
| ------------------- | :------------------: |
|Xamarin.Forms.MaskedEntry|[![NuGet](https://buildstats.info/nuget/Xamarin.Forms.MaskedEntry)](https://www.nuget.org/packages/Xamarin.Forms.MaskedEntry/)|


**Platform Support**

Xamarin.Forms.MaskedEntry is a .NET Standard 2.0 library.Its only dependency is the Xamarin.Forms

## Setup / Usage

Does not require additional configuration. Just install the package in the shared project and use.

You just need to add the reference in your xaml file.

```csharp
     xmlns:control="clr-namespace:Xamarin.Forms.MaskedEntry;assembly=Xamarin.Forms.MaskedEntry"
```

**Sample**

```csharp
    <StackLayout>
        <Label Text="Phone"></Label>
        <control:MaskedEntry Placeholder="Phone" Mask="(XX)XXXX-XXXX" Keyboard="Numeric" ></control:MaskedEntry>
        <Label Text="Number of registration"></Label>
        <control:MaskedEntry Placeholder="Number of registration" Mask="XXXXX.XXXXX.XX-XX  (XX)" ></control:MaskedEntry>
    </StackLayout>
```

The complete example can be downloaded here: https://github.com/TBertuzzi/Xamarin.Forms.MaskedEntry/tree/master/MaskedEntrySample


