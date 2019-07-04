# oic - Objects Into Code

Introduction
============

Prototype of converting Delphi Dfm definitions to code.

This simple project is really a proof of concept.

Often times I need to create an item dynamically and add it to a ListView or Layout at runtime. I thought it would be nice if you could mock up the design in the Delphi Form Editor, then copy the item and paste into the Code Editor window and have Delphi automatically generate the code and function to create the object. 

The first step is to get it working in an external program. If it works well, then it may be worth looking at building a Delphi plugin to do it within thr IDE.

This C# WinForms program is that first step. I used C# as it is the language I am most comfortable with, and allows me to focus on the problem rather than the tooling.

Currently working for a number of examples, hopefully more will be on the way soon.

As mentioned, it is a prototype, so the code is written with less care for quality than usual.

Instructions
============

For a quick test, click on of the example button (buttons 1, 2, 3, ...)

This will load a DFM into the left code editor, and generate the code in the right code editor.

If you edit the DFM, click the >> button to generate the code again.

You can paste DFM snippets directly into the DFM code editor, and click the >> button to generate the code.
