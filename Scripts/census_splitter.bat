@echo off
setlocal enabledelayedexpansion

REM Parameters
set arg1=%1
set arg2=%2
shift
shift

REM Remove all spaces from .csv files only
cd %arg1%
for %%a in (* *) do (
	set file=%%a
	ren "!file!" "!file: =_!"
	)

REM CD to working directory
cd "%UserProfile%\Documents\Census_Splitter\"

REM Loop Rscript for each File in Folder
for /f %%f in ('dir /s/b %arg1%') do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f %arg2%






