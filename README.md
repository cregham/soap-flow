# soap-flow
Sample app that creates a fake SOAP API and a basic user interface to run SpecFlow automated tests against.
https://docs.specflow.org/en/latest/
## Setup
Download the solution files. All dependencies included.
net472

 - Install SpecFlow Extensions via 'Manage Extensions' in VS
 - Open SpecFlowExample.sln 
 - Build
 - Run soap-api (start not-debugging ctrl+f5)
 - Update api endpoints in App.configs
 - In automation-tests/Core/Settings.cs set the UI exe to ui.exe in ui project output folder
 - Run tests or UI

## Test Structure
Drivers - UI Interaction Base
Built using Test Stack White
Fire up a window, creates a hook into the window then uses UserInterfaceObject.cs to extract elements and perform events/actions on them.

Features - Business Readable Tests
Write your tests here FIRST then generate the step definitions through the context menu. If the test doesn't make sense in English then its probably not a test.

Hooks - Special Specflow methods for configuring your test suite before or after its ran.
https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html
GlobalHooks.cs is a personal preference class and not necessarily best practice.
During [BeforeTestRun] or [BeforeFeature] when starting test run, set global static variables so they're accessible in all your tests, avoids duplicate instances of projects.
 
Steps - Your actual test code, Arrange/Act/Assert. 
Scenario context helps share values between step definitions
https://docs.specflow.org/projects/specflow/en/latest/Bindings/ScenarioContext.html



