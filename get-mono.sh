pushd $(dirname $0)
echo =====CLEARING OLD MONO BITS=====

if [ -d mono ]
then
  rm -rf mono
fi

if [ -d hostbuild ]
then
  rm -rf hostbuild
fi

MONO_SVN_BASE=svn://anonsvn.mono-project.com/source/branches/mono-2-6
MONO_SVN_REVISION=147505

echo
echo =====CHECKING OUT MONO AND MCS=====
svn co -r $MONO_SVN_REVISION $MONO_SVN_BASE/mono
mkdir -p hostbuild
cp -r mono hostbuild/mono
pushd hostbuild
svn co -r $MONO_SVN_REVISION $MONO_SVN_BASE/mcs

pushd mono/eglib
echo
echo =====COMPILING MONO CLASS LIBRARIES=====
sleep 2
./autogen.sh
popd
cd mono
./autogen.sh --with-glib=embedded --with-moonlight=no
make
popd


cd mono
echo
echo =====APPLYING ANDROID PATCHES=====
patch -p0 -i ../mono.patch

popd