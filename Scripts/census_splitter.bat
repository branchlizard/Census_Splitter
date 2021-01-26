@echo off

REM Wowrking
set arg1=%1
set arg2=%2
shift

REM Loop Rscript for each File in Folder
for %%f in %arg1% do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f %arg2%



