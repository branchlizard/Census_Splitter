REM @echo off

cd "%UserProfile%\Documents\Census_Splitter\"
for %%f in (Data\*) do call R-Portable\App\R-Portable\bin\Rscript.exe Scripts\census_splitter_io.R %%f Output\






