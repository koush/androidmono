namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AudioRecord : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AudioRecord()
		{
			InitJNI();
		}
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
			static OnRecordPositionUpdateListener_()
			{
				InitJNI();
			}
			internal OnRecordPositionUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMarkerReached7145;
			 void android.media.AudioRecord.OnRecordPositionUpdateListener.onMarkerReached(android.media.AudioRecord arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onMarkerReached7145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onMarkerReached7145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onPeriodicNotification7146;
			 void android.media.AudioRecord.OnRecordPositionUpdateListener.onPeriodicNotification(android.media.AudioRecord arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onPeriodicNotification7146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onPeriodicNotification7146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioRecord$OnRecordPositionUpdateListener"));
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onMarkerReached7145 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioRecord;)V");
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onPeriodicNotification7146 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioRecord;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7147;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._finalize7147);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._finalize7147);
		}
		internal static global::MonoJavaBridge.MethodId _stop7148;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._stop7148);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._stop7148);
		}
		public new int State
		{
			get
			{
				return getState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState7149;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getState7149);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getState7149);
		}
		internal static global::MonoJavaBridge.MethodId _read7150;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._read7150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read7150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read7151;
		public virtual int read(java.nio.ByteBuffer arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._read7151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read7151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _read7152;
		public virtual int read(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._read7152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read7152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _release7153;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._release7153);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._release7153);
		}
		public new int SampleRate
		{
			get
			{
				return getSampleRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSampleRate7154;
		public virtual int getSampleRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getSampleRate7154);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getSampleRate7154);
		}
		public new int AudioSource
		{
			get
			{
				return getAudioSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioSource7155;
		public virtual int getAudioSource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getAudioSource7155);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getAudioSource7155);
		}
		public new int AudioFormat
		{
			get
			{
				return getAudioFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioFormat7156;
		public virtual int getAudioFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getAudioFormat7156);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getAudioFormat7156);
		}
		public new int ChannelConfiguration
		{
			get
			{
				return getChannelConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelConfiguration7157;
		public virtual int getChannelConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getChannelConfiguration7157);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getChannelConfiguration7157);
		}
		public new int ChannelCount
		{
			get
			{
				return getChannelCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelCount7158;
		public virtual int getChannelCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getChannelCount7158);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getChannelCount7158);
		}
		public new int RecordingState
		{
			get
			{
				return getRecordingState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRecordingState7159;
		public virtual int getRecordingState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getRecordingState7159);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getRecordingState7159);
		}
		public new int NotificationMarkerPosition
		{
			get
			{
				return getNotificationMarkerPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNotificationMarkerPosition7160;
		public virtual int getNotificationMarkerPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getNotificationMarkerPosition7160);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getNotificationMarkerPosition7160);
		}
		public new int PositionNotificationPeriod
		{
			get
			{
				return getPositionNotificationPeriod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositionNotificationPeriod7161;
		public virtual int getPositionNotificationPeriod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getPositionNotificationPeriod7161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getPositionNotificationPeriod7161);
		}
		internal static global::MonoJavaBridge.MethodId _getMinBufferSize7162;
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getMinBufferSize7162, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startRecording7163;
		public virtual void startRecording() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._startRecording7163);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._startRecording7163);
		}
		internal static global::MonoJavaBridge.MethodId _setRecordPositionUpdateListener7164;
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._setRecordPositionUpdateListener7164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setRecordPositionUpdateListener7164, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRecordPositionUpdateListener7165;
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._setRecordPositionUpdateListener7165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setRecordPositionUpdateListener7165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationMarkerPosition7166;
		public virtual int setNotificationMarkerPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._setNotificationMarkerPosition7166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setNotificationMarkerPosition7166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositionNotificationPeriod7167;
		public virtual int setPositionNotificationPeriod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._setPositionNotificationPeriod7167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setPositionNotificationPeriod7167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AudioRecord7168;
		public AudioRecord(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._AudioRecord7168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AudioRecord.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioRecord"));
			global::android.media.AudioRecord._finalize7147 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "finalize", "()V");
			global::android.media.AudioRecord._stop7148 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "stop", "()V");
			global::android.media.AudioRecord._getState7149 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getState", "()I");
			global::android.media.AudioRecord._read7150 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "read", "([BII)I");
			global::android.media.AudioRecord._read7151 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "read", "(Ljava/nio/ByteBuffer;I)I");
			global::android.media.AudioRecord._read7152 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "read", "([SII)I");
			global::android.media.AudioRecord._release7153 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "release", "()V");
			global::android.media.AudioRecord._getSampleRate7154 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getSampleRate", "()I");
			global::android.media.AudioRecord._getAudioSource7155 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getAudioSource", "()I");
			global::android.media.AudioRecord._getAudioFormat7156 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getAudioFormat", "()I");
			global::android.media.AudioRecord._getChannelConfiguration7157 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getChannelConfiguration", "()I");
			global::android.media.AudioRecord._getChannelCount7158 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getChannelCount", "()I");
			global::android.media.AudioRecord._getRecordingState7159 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getRecordingState", "()I");
			global::android.media.AudioRecord._getNotificationMarkerPosition7160 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getNotificationMarkerPosition", "()I");
			global::android.media.AudioRecord._getPositionNotificationPeriod7161 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getPositionNotificationPeriod", "()I");
			global::android.media.AudioRecord._getMinBufferSize7162 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getMinBufferSize", "(III)I");
			global::android.media.AudioRecord._startRecording7163 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "startRecording", "()V");
			global::android.media.AudioRecord._setRecordPositionUpdateListener7164 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V");
			global::android.media.AudioRecord._setRecordPositionUpdateListener7165 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V");
			global::android.media.AudioRecord._setNotificationMarkerPosition7166 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setNotificationMarkerPosition", "(I)I");
			global::android.media.AudioRecord._setPositionNotificationPeriod7167 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setPositionNotificationPeriod", "(I)I");
			global::android.media.AudioRecord._AudioRecord7168 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "<init>", "(IIIII)V");
		}
	}
}
