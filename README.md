Using the Yoctopuce C# on Windows, Linux and macOS
===================================================

This is the source code of the application that is discussed on our article [Using the Yoctopuce C# on Windows, Linux and macOS](https://www.yoctopuce.com/EN/article/use-the-c-library-on-linux-and-macos-with-mono)

This is two very simple applications that use the Yoctopuce Library
an that can be run on Window, Linux and macOS.

## Content of this package

* YoctopuceLib

		[The Yoctopuce C# library](https://github.com/yoctopuce/yoctolib_cs) extracted.
		Both application will use the files in the *Source* subfolder.

* ConsoleApp1

		A simple console application.

* MultiPlatormApp

		A simple Windows Form application.

## ConsoleApp1

This simple console application use the C# library to list all Yoctopuce device plugged
on the USB port. This application can be compiled on Windows with Visual Studio and
then be run on
* Windows 32 bits
* Windows 64 bits
* Linux Intel 32 bits
* Linux Intel 64 bits
* Linux ARM hard float (i.e. Raspberry PI)
* macOS with mono 32 bits
* macOS with mono 64 bits


## MultiPlatormApp


This simple graphical application use the C# library to display the value of the first Yoctopuce sensors connected by USB. This application can be compiled on Windows with Visual Studio and then be run on
* Windows 32 bits
* Windows 64 bits
* Linux Intel 32 bits
* Linux Intel 64 bits
* Linux ARM hard float (i.e. Raspberry PI)
* macOS 32 bits

*Note : This application will not work on macOS with the 64 bit version of mono, because the
Windows.Form API use Carbon which is no more available on 64 bits: https://www.mono-project.com/docs/about-mono/supported-platforms/macos/*
