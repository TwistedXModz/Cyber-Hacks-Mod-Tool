; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Cyber Hacks Mod Tool installer"
#define MyAppVersion "2.6.7.5"
#define MyAppPublisher "Twisted X Modz"
#define MyAppURL "https://www.twistedxmodz.com/"
#define MyAppExeName "Cyber Hacks Mod Tool.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{A3DF2DF6-3507-4551-AEBC-F7525958F613}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\Cyber Hacks Mod Tool
DisableDirPage=yes
DefaultGroupName=Cyber Hacks Mod Tool
AllowNoIcons=yes
; The [Icons] "quicklaunchicon" entry uses {userappdata} but its [Tasks] entry has a proper IsAdminInstallMode Check.
UsedUserAreasWarning=no
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir=C:\Users\Twisted X Modz\Documents\Source codes\installer
OutputBaseFilename=Cyber Hacks Mod Tool installer 
SetupIconFile=C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\favicon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 6.1; Check: not IsAdminInstallMode

[Files]
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\Apps*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\Apps\Mod Menus*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\BouncyCastle.Crypto.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.vshost.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.vshost.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.vshost.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.vshost.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Cyber Hacks Mod Tool.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Google.Protobuf.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\MySql.Data.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Renci.SshNet.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\Twisted X Modz\Documents\Source codes\Cyber Hacks Mod Tool\bin\Debug\Renci.SshNet.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:ProgramOnTheWeb,{#MyAppName}}"; Filename: "{#MyAppURL}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

