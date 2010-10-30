namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AudioRecord : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AudioRecord(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.AudioRecord.OnRecordPositionUpdateListener_))]
		public partial interface OnRecordPositionUpdateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onMarkerReached(android.media.AudioRecord arg0);
			void onPeriodicNotification(android.media.AudioRecord arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.AudioRecord.OnRecordPositionUpdateListener))]
		internal sealed partial class OnRecordPositionUpdateListener_ : java.lang.Object, OnRecordPositionUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnRecordPositionUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.AudioRecord.OnRecordPositionUpdateListener.onMarkerReached(android.media.AudioRecord arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioRecord;)V", ref global::android.media.AudioRecord.OnRecordPositionUpdateListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			void android.media.AudioRecord.OnRecordPositionUpdateListener.onPeriodicNotification(android.media.AudioRecord arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioRecord;)V", ref global::android.media.AudioRecord.OnRecordPositionUpdateListener_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnRecordPositionUpdateListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioRecord$OnRecordPositionUpdateListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.staticClass, "finalize", "()V", ref global::android.media.AudioRecord._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.staticClass, "stop", "()V", ref global::android.media.AudioRecord._m1);
		}
		public new int State
		{
			get
			{
				return getState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getState", "()I", ref global::android.media.AudioRecord._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int read(byte[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "read", "([BII)I", ref global::android.media.AudioRecord._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int read(java.nio.ByteBuffer arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "read", "(Ljava/nio/ByteBuffer;I)I", ref global::android.media.AudioRecord._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int read(short[] arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "read", "([SII)I", ref global::android.media.AudioRecord._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.staticClass, "release", "()V", ref global::android.media.AudioRecord._m6);
		}
		public new int SampleRate
		{
			get
			{
				return getSampleRate();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getSampleRate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getSampleRate", "()I", ref global::android.media.AudioRecord._m7);
		}
		public new int AudioSource
		{
			get
			{
				return getAudioSource();
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual int getAudioSource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getAudioSource", "()I", ref global::android.media.AudioRecord._m8);
		}
		public new int AudioFormat
		{
			get
			{
				return getAudioFormat();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getAudioFormat()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getAudioFormat", "()I", ref global::android.media.AudioRecord._m9);
		}
		public new int ChannelConfiguration
		{
			get
			{
				return getChannelConfiguration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getChannelConfiguration()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getChannelConfiguration", "()I", ref global::android.media.AudioRecord._m10);
		}
		public new int ChannelCount
		{
			get
			{
				return getChannelCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getChannelCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getChannelCount", "()I", ref global::android.media.AudioRecord._m11);
		}
		public new int RecordingState
		{
			get
			{
				return getRecordingState();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int getRecordingState()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getRecordingState", "()I", ref global::android.media.AudioRecord._m12);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getNotificationMarkerPosition", "()I", ref global::android.media.AudioRecord._m13);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "getPositionNotificationPeriod", "()I", ref global::android.media.AudioRecord._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public static int getMinBufferSize(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioRecord._m15.native == global::System.IntPtr.Zero)
				global::android.media.AudioRecord._m15 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getMinBufferSize", "(III)I");
			return @__env.CallStaticIntMethod(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void startRecording()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.staticClass, "startRecording", "()V", ref global::android.media.AudioRecord._m16);
		}
		public new global::android.media.AudioRecord.OnRecordPositionUpdateListener RecordPositionUpdateListener
		{
			set
			{
				setRecordPositionUpdateListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V", ref global::android.media.AudioRecord._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0, android.os.Handler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V", ref global::android.media.AudioRecord._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int setNotificationMarkerPosition(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "setNotificationMarkerPosition", "(I)I", ref global::android.media.AudioRecord._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int setPositionNotificationPeriod(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioRecord.staticClass, "setPositionNotificationPeriod", "(I)I", ref global::android.media.AudioRecord._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public AudioRecord(int arg0, int arg1, int arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.AudioRecord._m21.native == global::System.IntPtr.Zero)
				global::android.media.AudioRecord._m21 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "<init>", "(IIIII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
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
		public static int RECORDSTATE_STOPPED
		{
			get
			{
				return 1;
			}
		}
		public static int RECORDSTATE_RECORDING
		{
			get
			{
				return 3;
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
		static AudioRecord()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AudioRecord.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioRecord"));
		}
		internal static void InitJNI()
		{
		}
	}
}
