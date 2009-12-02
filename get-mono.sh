if [ -d mono ]
then
  rm -rf mono
fi
svn co -r 147278 svn://anonsvn.mono-project.com/source/branches/mono-2-6/mono
cd mono
patch -p0 -i ../mono.patch

