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
		public interface OnRecordPositionUpdateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onMarkerReached(android.media.AudioRecord arg0);
			void onPeriodicNotification(android.media.AudioRecord arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.AudioRecord.OnRecordPositionUpdateListener))]
		public sealed partial class OnRecordPositionUpdateListener_ : java.lang.Object, OnRecordPositionUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnRecordPositionUpdateListener_()
			{
				InitJNI();
			}
			internal OnRecordPositionUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMarkerReached4866;
			 void android.media.AudioRecord.OnRecordPositionUpdateListener.onMarkerReached(android.media.AudioRecord arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onMarkerReached4866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onMarkerReached4866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onPeriodicNotification4867;
			 void android.media.AudioRecord.OnRecordPositionUpdateListener.onPeriodicNotification(android.media.AudioRecord arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onPeriodicNotification4867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onPeriodicNotification4867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioRecord$OnRecordPositionUpdateListener"));
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onMarkerReached4866 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioRecord;)V");
				global::android.media.AudioRecord.OnRecordPositionUpdateListener_._onPeriodicNotification4867 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.OnRecordPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioRecord;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4868;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._finalize4868);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._finalize4868);
		}
		internal static global::MonoJavaBridge.MethodId _stop4869;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._stop4869);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._stop4869);
		}
		public new int State
		{
			get
			{
				return getState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getState4870;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getState4870);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getState4870);
		}
		internal static global::MonoJavaBridge.MethodId _read4871;
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._read4871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read4871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _read4872;
		public virtual int read(java.nio.ByteBuffer arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._read4872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read4872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _read4873;
		public virtual int read(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._read4873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read4873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _release4874;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._release4874);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._release4874);
		}
		public new int SampleRate
		{
			get
			{
				return getSampleRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSampleRate4875;
		public virtual int getSampleRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getSampleRate4875);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getSampleRate4875);
		}
		public new int AudioSource
		{
			get
			{
				return getAudioSource();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioSource4876;
		public virtual int getAudioSource() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getAudioSource4876);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getAudioSource4876);
		}
		public new int AudioFormat
		{
			get
			{
				return getAudioFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioFormat4877;
		public virtual int getAudioFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getAudioFormat4877);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getAudioFormat4877);
		}
		public new int ChannelConfiguration
		{
			get
			{
				return getChannelConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelConfiguration4878;
		public virtual int getChannelConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getChannelConfiguration4878);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getChannelConfiguration4878);
		}
		public new int ChannelCount
		{
			get
			{
				return getChannelCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelCount4879;
		public virtual int getChannelCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getChannelCount4879);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getChannelCount4879);
		}
		public new int RecordingState
		{
			get
			{
				return getRecordingState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRecordingState4880;
		public virtual int getRecordingState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getRecordingState4880);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getRecordingState4880);
		}
		public new int NotificationMarkerPosition
		{
			get
			{
				return getNotificationMarkerPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNotificationMarkerPosition4881;
		public virtual int getNotificationMarkerPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getNotificationMarkerPosition4881);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getNotificationMarkerPosition4881);
		}
		public new int PositionNotificationPeriod
		{
			get
			{
				return getPositionNotificationPeriod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositionNotificationPeriod4882;
		public virtual int getPositionNotificationPeriod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._getPositionNotificationPeriod4882);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getPositionNotificationPeriod4882);
		}
		internal static global::MonoJavaBridge.MethodId _getMinBufferSize4883;
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getMinBufferSize4883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startRecording4884;
		public virtual void startRecording() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._startRecording4884);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._startRecording4884);
		}
		internal static global::MonoJavaBridge.MethodId _setRecordPositionUpdateListener4885;
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._setRecordPositionUpdateListener4885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setRecordPositionUpdateListener4885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRecordPositionUpdateListener4886;
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioRecord._setRecordPositionUpdateListener4886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setRecordPositionUpdateListener4886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationMarkerPosition4887;
		public virtual int setNotificationMarkerPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._setNotificationMarkerPosition4887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setNotificationMarkerPosition4887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositionNotificationPeriod4888;
		public virtual int setPositionNotificationPeriod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioRecord._setPositionNotificationPeriod4888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setPositionNotificationPeriod4888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AudioRecord4889;
		public AudioRecord(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._AudioRecord4889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
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
			global::android.media.AudioRecord._finalize4868 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "finalize", "()V");
			global::android.media.AudioRecord._stop4869 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "stop", "()V");
			global::android.media.AudioRecord._getState4870 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getState", "()I");
			global::android.media.AudioRecord._read4871 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "read", "([BII)I");
			global::android.media.AudioRecord._read4872 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "read", "(Ljava/nio/ByteBuffer;I)I");
			global::android.media.AudioRecord._read4873 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "read", "([SII)I");
			global::android.media.AudioRecord._release4874 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "release", "()V");
			global::android.media.AudioRecord._getSampleRate4875 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getSampleRate", "()I");
			global::android.media.AudioRecord._getAudioSource4876 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getAudioSource", "()I");
			global::android.media.AudioRecord._getAudioFormat4877 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getAudioFormat", "()I");
			global::android.media.AudioRecord._getChannelConfiguration4878 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getChannelConfiguration", "()I");
			global::android.media.AudioRecord._getChannelCount4879 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getChannelCount", "()I");
			global::android.media.AudioRecord._getRecordingState4880 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getRecordingState", "()I");
			global::android.media.AudioRecord._getNotificationMarkerPosition4881 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getNotificationMarkerPosition", "()I");
			global::android.media.AudioRecord._getPositionNotificationPeriod4882 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getPositionNotificationPeriod", "()I");
			global::android.media.AudioRecord._getMinBufferSize4883 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "getMinBufferSize", "(III)I");
			global::android.media.AudioRecord._startRecording4884 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "startRecording", "()V");
			global::android.media.AudioRecord._setRecordPositionUpdateListener4885 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V");
			global::android.media.AudioRecord._setRecordPositionUpdateListener4886 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V");
			global::android.media.AudioRecord._setNotificationMarkerPosition4887 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setNotificationMarkerPosition", "(I)I");
			global::android.media.AudioRecord._setPositionNotificationPeriod4888 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "setPositionNotificationPeriod", "(I)I");
			global::android.media.AudioRecord._AudioRecord4889 = @__env.GetMethodIDNoThrow(global::android.media.AudioRecord.staticClass, "<init>", "(IIIII)V");
		}
	}
}
