powershell "Get-ChildItem .\ -include bin,obj,ClientBin -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }"