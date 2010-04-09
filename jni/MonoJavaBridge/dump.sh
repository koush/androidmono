pushd bin
for file in $(find net); do if [ ! -d $file ]; then echo -n '<ItemGroup><Compile Include="'; echo -n $file; echo '"/></ItemGroup>'; fi ;done > ../dump.txt
popd