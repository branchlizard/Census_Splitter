@echo off
setlocal enabledelayedexpansion

REM Clean up previous logs
del "%UserProfile%\Documents\Census_Splitter\Logs\failed_log.txt"
del "%UserProfile%\Documents\Census_Splitter\Logs\successful_log.txt"

REM Parameters
set arg1=%1
set arg2=%2
shift
shift

REM Remove all spaces from filenames; consider renaming only .csv files.
cd %arg1%
for %%a in (* *) do (
	set file=%%a
	ren "!file!" "!file: =_!"
	)

REM CD to working directory
cd "%UserProfile%\Documents\Census_Splitter\"

REM Loop Rscript for each File in Folder
REM for /f %%f in ('dir /s/b %arg1%') do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f %arg2% 
>>"%UserProfile%\Documents\Census_Splitter\Logs\failed_log.txt" 2>&1  (
	for /f %%f in ('dir /s/b %arg1%') do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f %arg2% 
	echo.
	)


REM Create successful log
cd %arg2%
dir /b *.* > "%UserProfile%\Documents\Census_Splitter\Logs\successful_log.txt"

REM Remove duplicates from failed log
cd "%UserProfile%\Documents\Census_Splitter\"
call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\failed_log_cleaner_io.R ".\Logs\failed_log.txt"




