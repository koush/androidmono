namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AudioTrack : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AudioTrack(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_))]
		public partial interface OnPlaybackPositionUpdateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onMarkerReached(android.media.AudioTrack arg0);
			void onPeriodicNotification(android.media.AudioTrack arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener))]
		internal sealed partial class OnPlaybackPositionUpdateListener_ : java.lang.Object, OnPlaybackPositionUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnPlaybackPositionUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached(android.media.AudioTrack arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioTrack;)V", ref global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification(android.media.AudioTrack arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioTrack;)V", ref global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnPlaybackPositionUpdateListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioTrack$OnPlaybackPositionUpdateListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "finalize", "()V", ref global::android.media.AudioTrack._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual int write(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "write", "([BII)I", ref global::android.media.AudioTrack._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int write(short[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "write", "([SII)I", ref global::android.media.AudioTrack._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "stop", "()V", ref global::android.media.AudioTrack._m3);
		}
		public new int State
		{
			get
			{
				return getState();
			}
			set
			{
				setState(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getState", "()I", ref global::android.media.AudioTrack._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void flush()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "flush", "()V", ref global::android.media.AudioTrack._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected virtual void setState(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "setState", "(I)V", ref global::android.media.AudioTrack._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "release", "()V", ref global::android.media.AudioTrack._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void play()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "play", "()V", ref global::android.media.AudioTrack._m8);
		}
		public new int SampleRate
		{
			get
			{
				return getSampleRate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getSampleRate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getSampleRate", "()I", ref global::android.media.AudioTrack._m9);
		}
		public new int AudioFormat
		{
			get
			{
				return getAudioFormat();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getAudioFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I", ref global::android.media.AudioTrack._m10);
		}
		public new int ChannelConfiguration
		{
			get
			{
				return getChannelConfiguration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getChannelConfiguration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I", ref global::android.media.AudioTrack._m11);
		}
		public new int ChannelCount
		{
			get
			{
				return getChannelCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getChannelCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getChannelCount", "()I", ref global::android.media.AudioTrack._m12);
		}
		public new int NotificationMarkerPosition
		{
			get
			{
				return getNotificationMarkerPosition();
			}
			set
			{
				setNotificationMarkerPosition(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getNotificationMarkerPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I", ref global::android.media.AudioTrack._m13);
		}
		public new int PositionNotificationPeriod
		{
			get
			{
				return getPositionNotificationPeriod();
			}
			set
			{
				setPositionNotificationPeriod(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual int getPositionNotificationPeriod()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I", ref global::android.media.AudioTrack._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static int getMinBufferSize(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioTrack._m15.native == global::System.IntPtr.Zero)
				global::android.media.AudioTrack._m15 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I");
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int setNotificationMarkerPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I", ref global::android.media.AudioTrack._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int setPositionNotificationPeriod(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I", ref global::android.media.AudioTrack._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static float MinVolume
		{
			get
			{
				return getMinVolume();
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public static float getMinVolume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioTrack._m18.native == global::System.IntPtr.Zero)
				global::android.media.AudioTrack._m18 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F");
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._m18);
		}
		public static float MaxVolume
		{
			get
			{
				return getMaxVolume();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static float getMaxVolume()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioTrack._m19.native == global::System.IntPtr.Zero)
				global::android.media.AudioTrack._m19 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F");
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._m19);
		}
		public new int PlaybackRate
		{
			get
			{
				return getPlaybackRate();
			}
			set
			{
				setPlaybackRate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getPlaybackRate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I", ref global::android.media.AudioTrack._m20);
		}
		public new int StreamType
		{
			get
			{
				return getStreamType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual int getStreamType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getStreamType", "()I", ref global::android.media.AudioTrack._m21);
		}
		public new int PlayState
		{
			get
			{
				return getPlayState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual int getPlayState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getPlayState", "()I", ref global::android.media.AudioTrack._m22);
		}
		protected new int NativeFrameCount
		{
			get
			{
				return getNativeFrameCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		protected virtual int getNativeFrameCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I", ref global::android.media.AudioTrack._m23);
		}
		public new int PlaybackHeadPosition
		{
			get
			{
				return getPlaybackHeadPosition();
			}
			set
			{
				setPlaybackHeadPosition(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getPlaybackHeadPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I", ref global::android.media.AudioTrack._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public static int getNativeOutputSampleRate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioTrack._m25.native == global::System.IntPtr.Zero)
				global::android.media.AudioTrack._m25 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I");
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V", ref global::android.media.AudioTrack._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.media.AudioTrack.OnPlaybackPositionUpdateListener PlaybackPositionUpdateListener
		{
			set
			{
				setPlaybackPositionUpdateListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V", ref global::android.media.AudioTrack._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual int setStereoVolume(float arg0, float arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I", ref global::android.media.AudioTrack._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual int setPlaybackRate(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I", ref global::android.media.AudioTrack._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual int setPlaybackHeadPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I", ref global::android.media.AudioTrack._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual int setLoopPoints(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I", ref global::android.media.AudioTrack._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void pause()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioTrack.staticClass, "pause", "()V", ref global::android.media.AudioTrack._m32);
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int reloadStaticData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I", ref global::android.media.AudioTrack._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioTrack._m34.native == global::System.IntPtr.Zero)
				global::android.media.AudioTrack._m34 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		public static int PLAYSTATE_STOPPED
		{
			get
			{
				return 1;
			}
		}
		public static int PLAYSTATE_PAUSED
		{
			get
			{
				return 2;
			}
		}
		public static int PLAYSTATE_PLAYING
		{
			get
			{
				return 3;
			}
		}
		public static int MODE_STATIC
		{
			get
			{
				return 0;
			}
		}
		public static int MODE_STREAM
		{
			get
			{
				return 1;
			}
		}
		public static int STATE_UNINITIALIZED
		{
			get
			{
				return 0;
			}
		}
		public static int STATE_INITIALIZED
		{
			get
			{
				return 1;
			}
		}
		public static int STATE_NO_STATIC_DATA
		{
			get
			{
				return 2;
			}
		}
		public static int SUCCESS
		{
			get
			{
				return 0;
			}
		}
		public static int ERROR
		{
			get
			{
				return -1;
			}
		}
		public static int ERROR_BAD_VALUE
		{
			get
			{
				return -2;
			}
		}
		public static int ERROR_INVALID_OPERATION
		{
			get
			{
				return -3;
			}
		}
		static AudioTrack()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AudioTrack.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioTrack"));
		}
		internal static void InitJNI()
		{
		}
	}
}
