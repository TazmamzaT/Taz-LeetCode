#!/bin/bash
args=("$@")
dotnet test --logger "console;verbosity=detailed" --filter $"FullyQualifiedname~${args[0]}" 