if [ -z $1 ]
then
    echo 'Usage: ndk-setup.sh <ANDROID_NDK_ROOT>'
    exit 1
fi

if [ ! -d $1/apps ]
then
    echo $1 does not contain an apps directory.
    exit 1
fi

ANDROIDMONO_ROOT=$(pwd)/$(dirname $0)
rm -f $1/apps/androidmono
ln -s $ANDROIDMONO_ROOT $1/apps/androidmono
