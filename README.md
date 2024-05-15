<a href="https://www.buymeacoffee.com/vosongtoan" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>


# VUI - Vietnam User Interfaces

## Description

VUI, short for Vietnam User Interfaces, is a Razor Class Library for Blazor apps. This library provides reusable UI components such as buttons, forms, and more, making it easier for developers to build interactive web interfaces with Blazor.

## Creator

This project was created by Vo Song Toan with the purpose of contributing to the developer community in Vietnam and around the world. The goal is to provide a free, open-source library of Razor components that can be used in any Blazor application.

## Getting Started

To use VUI in your Blazor application, follow these steps:

1. Install the VUI library in your project (add instructions on how to do this).
2. Import the necessary VUI components in your Razor files.
3. Use the VUI components as needed in your application.

## Live Demo with WeExpressIt

Experience the power and flexibility of VUI components in action with our live demo application, WeExpressIt. Follow the steps below to see how VUI enhances Blazor apps:

Visit the WeExpressIt app at WeExpressIt Live Demo.
Explore the various UI components in a real-world context.
See how VUI components can be customized and integrated seamlessly.

Code Examples from WeExpressIt
Dive into the code behind WeExpressIt to understand the implementation of VUI components:

```csharp
@page "/counter"
@using VUI
@rendermode InteractiveWebAssembly

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>


<VUI.VUIButton Text="Click me"
               Normal_BackgroundColor="#0000ff"
               MouseEnter_BackgroundColor="#00ff00"
               Clicked_BackgroundColor="#ff0000"
               OnClicked="onclicked"
               OnMouseUp="onmouseup"/>

<p role="status">Current count: @currentCount</p>

@code {

    private int currentCount = 0;


    private void onclicked(VUIButton btn)
    {
        currentCount++;
    }

    private void onmouseup(VUIButton btn)
    {
        StateHasChanged();
    }
}
