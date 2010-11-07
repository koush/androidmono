function checkresult
{
    RESULT=`echo $?`
    if [ "$RESULT" != 0 ]; then
        echo $1
        exit $RESULT
    fi
}

if [ -z "$1" ]
then
    echo No local mono directory supplied. Cloning mono from Github. This may take a while...
    echo You can provide a local mono checkout using: $0 \<path-to-mono-git-repository\>
    MONO_GIT=git://github.com/mono/mono.git
else
    MONO_GIT=$1/.git
fi

echo =====CHECKING OUT MONO FROM $MONO_GIT=====
MONO_GIT_CHECKOUT=origin/master
echo $MONO_GIT_CHECKOUT

ROOT_DIR=$(basename $0)
pushd $(dirname $0)

echo
echo =====CHECKING OUT MONO=====
if [ -d MonoActivity/jni/mono ]
then
    echo =====UPDATING EXISTING MONO CHECKOUT=====
    echo =====If you get errors, you may want to delete mono and hostbuild to force a clean build=====
    pushd MonoActivity/jni/mono
    MONO_SKIP_PATCH=true
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    popd
    checkresult 'Error while updating ./mono'
    pushd hostbuild/mono
    git fetch origin
    git checkout $MONO_GIT_CHECKOUT
    popd
    checkresult 'Error while updating ./hostbuild/mono'
else
    pushd MonoActivity/jni
    git clone $MONO_GIT mono
    git checkout $MONO_GIT_CHECKOUT
    popd

    rm -rf hostbuild
    mkdir -p hostbuild
    pushd hostbuild
    git clone $MONO_GIT mono
    pushd mono
    git checkout $MONO_GIT_CHECKOUT
    popd
    popd
fi

echo
echo =====COMPILING MONO CLASS LIBRARIES FOR MCS BUILD=====
sleep 2
export CC=$(which gcc-4.0)
export CXX=$(which g++-4.0)
#pushd ../hostbuild/mono/eglib
#if [ ! -f configure ]
#then
#    ./autogen.sh --prefix=$ROOT_DIR/hostbuild/install
#fi
#popd

mkdir -p hostbuild/install
pushd hostbuild/install
INSTALL_PREFIX=$(pwd)
echo INSTALL_PREFIX=$INSTALL_PREFIX
popd

pushd hostbuild/mono
UNAME=$(uname -a | grep Darwin | grep x86_64)
if [ ! -z "$UNAME" ]
then
    echo Using gcc-4.0 on Darwin x86_64!
    export CC=gcc-4.0
fi
if [ ! -f configure ]
then
    echo Running configure...
    ./autogen.sh --with-glib=embedded --with-moonlight=no --prefix=$INSTALL_PREFIX --with-monodroid=yes
fi
make && make install
popd

if [ ! -f MonoActivity/jni/mono.patch ]
then
    echo =====NO LOCAL MONO PATCH FOUND=====
    MONO_SKIP_PATCH=true
fi

if [ -z $MONO_SKIP_PATCH ]
then
    pushd MonoActivity/jni/mono
    echo
    echo =====APPLYING ANDROID PATCHES FOR ARM BUILD=====
    git apply ../mono.patch
    popd
fi

echo "=====Done! Don't forget Rebuild the ARM build using the Android NDK now!====="