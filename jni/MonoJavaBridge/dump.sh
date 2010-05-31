pushd bin/generated
for file in $(find .); do if [ ! -d $file ]; then echo -n '<Compile Include="'; echo -n $file; echo '"/>'; fi ;done > ../../dump.txt
popd