# =======================================
# Build NuGet Packages for Tethys.Logging
# =======================================

cd Tethys.Xml
nuget pack Tethys.Xml.nuspec
Move-Item Tethys.Xml.*.nupkg .. -Force
cd ..


# ============================
# ============================
