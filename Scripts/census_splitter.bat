@echo off

REM Working
set arg1=%1
set arg2=%2
shift
shift

REM Loop Rscript for each File in Folder
REM cd /d %arg1%
for /f %%f in ('dir /s/b %arg1%') do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f %arg2%






