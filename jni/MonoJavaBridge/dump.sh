pushd bin
for file in $(find net); do if [ ! -d $file ]; then echo -n '<Compile Include="'; echo -n $file; echo '"/>'; fi ;done > ../dump.txt
popd