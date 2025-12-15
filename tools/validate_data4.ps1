$json = Get-Content 'Data\4.json' -Raw | ConvertFrom-Json
Write-Output "Count:$($json.products.Count)"
for($i=0;$i -lt $json.products.Count;$i++){
	$p = $json.products[$i]
	if($p -eq $null){
		Write-Output "index:$i <null>"
		continue
	}
	$missing = @()
	if(-not $p.id){ $missing += 'id' }
	if(-not $p.title){ $missing += 'title' }
	if(-not $p.image){ $missing += 'image' }
	if(-not $p.price){ $missing += 'price' }
	if($missing.Count -eq 0){
		Write-Output ("index:{0} OK" -f $i)
	} else {
		Write-Output ("index:{0} MISSING:{1}" -f $i, ($missing -join ','))
	}
}