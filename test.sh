#!/bin/bash

status1=$(dotnet fsi 28_1.fsx)
if [[ $status1 != "669171001" ]]; then
	exit 28
fi
status1=$(dotnet fsi 28_2.fsx)
if [[ $status1 != "669171001" ]]; then
	exit 28
fi
status1=$(dotnet fsi 28_3.fsx)
if [[ $status1 != "669171001" ]]; then
	exit 28
fi
status1=$(dotnet fsi 28_4.fsx)
if [[ $status1 != "669171001" ]]; then
	exit 28
fi

status1=$(dotnet fsi 3_1.fsx)
if [[ $status1 != "6857UL" ]]; then
	exit 3
fi

exit 0
