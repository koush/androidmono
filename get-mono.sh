MONO_SVN_BASE=svn://anonsvn.mono-project.com/source/branches/mono-2-6
MONO_SVN_REVISION=147526

pushd $(dirname $0)

function check-result
{
    RESULT=`echo $?`
    if [ "$RESULT" != 0 ]; then
        echo $1
        exit $RESULT
    fi
}

echo
echo =====CHECKING OUT MONO=====
if [ -d mono ]
then
    echo =====UPDATING EXISTING MONO CHECKOUT=====
    echo =====If you get errors, you may want to delete mono and hostbuild to force a clean build=====
    pushd mono
    MONO_SKIP_PATCH=true
    svn up -r $MONO_SVN_REVISION
    popd
    check-result 'Error while updating ./mono'
    pushd hostbuild/mono
    svn up -r $MONO_SVN_REVISION
    popd
    check-result 'Error while updating ./hostbuild/mono'
    pushd hostbuild/mcs
    svn up -r $MONO_SVN_REVISION
    popd
    check-result 'Error while updating ./hostbuild/mcs'
else
    svn co -r $MONO_SVN_REVISION $MONO_SVN_BASE/mono
    mkdir -p hostbuild
    cp -r mono hostbuild/mono
    pushd hostbuild
    svn co -r $MONO_SVN_REVISION $MONO_SVN_BASE/mcs
    popd
fi

echo
echo =====COMPILING MONO CLASS LIBRARIES FOR MCS BUILD=====
sleep 2
pushd hostbuild/mono/eglib
if [ ! -f configure ]
then
    ./autogen.sh
fi
popd
pushd hostbuild/mono
if [ ! -f configure ]
then
    ./autogen.sh --with-glib=embedded --with-moonlight=no
fi
make
popd

pushd mono
echo
echo =====APPLYING ANDROID PATCHES FOR ARM BUILD=====
if [ -z $MONO_SKIP_PATCH ]
then
    patch -p0 -i ../mono.patch
fi
popd

echo "=====Done! Don't forget Rebuild the ARM build using the Android NDK now!====="