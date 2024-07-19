# wild_hog

Wild Hog takes out exclusive access on a file in Windows.

![screenshot](hero_shot.png)

This can be useful to determine how other applications behave when a file they try to open is being accessed exclusively by something else.

## Installation

Wild Hog is only released for Windows on x86-64.

Go to the releases directory, select a version and download the zip file.  Unzip the file to a new directory, where you'd like Wild Hog to be installed.  Done.  It's installed.

Run wild_hog.exe to start the application.

## Use

Enter a valid, absolute Windows file path, with no quotes.

Press the Hog button to open the specified file for exclusive access momentarily (while the button is held).

Or use the Autohog checkbox to keep the specified file open with exclusive access.

## Bugs

Wild Hog may not gracefully handle file paths containing invalid characters.
