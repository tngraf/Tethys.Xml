# =========================================
# Build NuGet Packages for Tethys.Logging
#
# SPDX-License-Identifier: Apache-2.0
# SPDX-FileCopyrightText: 2017-2020 T. Graf
# =========================================

cd Tethys.Xml
nuget pack Tethys.Xml.nuspec
Move-Item Tethys.Xml.*.nupkg .. -Force
cd ..


# ============================
# ============================
