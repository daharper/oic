# oic - Objects Into Code

Introduction
============

Prototype of converting Delphi Dfm definitions to code.

This simple project is really a proof of concept.

Often times I need to create an item dynamically and add it to a ListView or Layout at runtime. I thought it would be nice if you could mock up the design in the Delphi Form Editor, then copy the item and paste into the Code Editor window and have Delphi automatically generate the code to create the object. 

The first step is to get it working in an external program. If it works well, then perhaps it is worth building a Delphi IDE plugin.

This C# WinForms program is that first step. I used C# as it is the language I am most comfortable with, and allows me to focus on the problem rather than the tooling.

It is currently working well for a few examples of various complexity, hopefully more will follow soon.

As mentioned, it is a prototype, the code is written with less care for quality than usual; features are added as needed, code refactored accordingly.

Instructions
============

For a quick test, click one of the example buttons (buttons 1, 2, 3, ...)

This will load a DFM into the left code editor, and generate the code in the right code editor.

If you edit the DFM, click the >> button to generate the code again.

You can paste DFM snippets directly into the DFM code editor, click the >> button to generate the code.

The log tab gives very basic debugging information.

Tooling
=======

* .Net Framework 4.7.2

* C# 7.3

* Visual Studio 2019

* WinForms

