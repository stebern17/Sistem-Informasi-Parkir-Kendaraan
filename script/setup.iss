[Setup]
AppName=SI Parkir Kendaraan
AppVerName=SI Parkir Kendaraan 1.0.0
AppPublisher= Kelompok 4 
AppCopyright=Copyright © 2021. Kel4
DefaultDirName={pf}\SI Parkir Kendaraan
DefaultGroupName=SI Parkir
OutputDir=file setup
OutputBaseFilename=SetupSIParkirKendaraan
DisableProgramGroupPage = yes
CreateUninstallRegKey = yes
Uninstallable = yes
UninstallFilesDir={app}\uninst
UninstallDisplayIcon={app}\SistemParkir.exe,0
UninstallDisplayName=SI Parkir Kendaraan
VersionInfoVersion=1.0.0.0
SetupIconFile=Setup.ico

[Languages]
Name: ina; MessagesFile: Indonesian.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked


[Files]
;file-file aplikasi
Source: Debug\SistemParkir.exe; DestDir: {app}; Flags: ignoreversion
Source: Debug\SistemParkir.exe.config; DestDir: {app}; Flags: ignoreversion
Source: Debug\Database\SistemParkir.db; DestDir: {app}\Database; Flags: ignoreversion

; file-file pendukung
Source: Debug\System.Data.SQLite.dll; DestDir: {app}; Flags: ignoreversion
Source: Debug\x64\SQLite.Interop.dll; DestDir: {app}\x64; Flags: ignoreversion
Source: Debug\x86\SQLite.Interop.dll; DestDir: {app}\x86; Flags: ignoreversion

Source: moto.ico; DestDir: {app}; Flags: ignoreversion

[Icons]
Name: {group}\SI Parkir Kendaraan; Filename: {app}\SistemParkir.exe; WorkingDir: {app}; IconFilename: {app}\moto.ico
Name: {userdesktop}\SI Parkir Kendaraan; Filename: {app}\SistemParkir.exe; WorkingDir: {app}; IconFilename: {app}\moto.ico; Tasks: desktopicon

[Registry]
;mencatat lokasi instalasi program, ini dibutuhkan jika kita ingin membuat paket instalasi update
Root: HKCU; Subkey: "Software\SI Parkir"; ValueName: "installDir"; ValueType: String; ValueData: {app}; Flags: uninsdeletevalue