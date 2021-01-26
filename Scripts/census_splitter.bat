@echo off

REM Wowrking
set arg1=%1
shift

REM Loop Rscript for each File in Folder
for %%f in (Data\*) do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f



