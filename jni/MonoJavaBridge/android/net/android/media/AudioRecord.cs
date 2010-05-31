namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AudioRecord : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AudioRecord() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.AudioRecord), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.AudioRecord(@__env); 
			} 
		} 
		protected AudioRecord(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnRecordPositionUpdateListener 
		{ 
			void onMarkerReached(android.media.AudioRecord arg0); 
			void onPeriodicNotification(android.media.AudioRecord arg0); 
		} 

		public partial class OnRecordPositionUpdateListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnRecordPositionUpdateListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnRecordPositionUpdateListener : java.lang.Object, OnRecordPositionUpdateListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnRecordPositionUpdateListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.AudioRecord.__OnRecordPositionUpdateListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.AudioRecord.__OnRecordPositionUpdateListener(@__env); 
				} 
			} 
			internal __OnRecordPositionUpdateListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onMarkerReached4395; 
			 void android.media.AudioRecord.OnRecordPositionUpdateListener.onMarkerReached(android.media.AudioRecord arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.AudioRecord.__OnRecordPositionUpdateListener._onMarkerReached4395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.__OnRecordPositionUpdateListener.staticClass, global::android.media.AudioRecord.__OnRecordPositionUpdateListener._onMarkerReached4395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onPeriodicNotification4396; 
			 void android.media.AudioRecord.OnRecordPositionUpdateListener.onPeriodicNotification(android.media.AudioRecord arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (!IsClrObject) 
					@__env.CallVoidMethod(this, global::android.media.AudioRecord.__OnRecordPositionUpdateListener._onPeriodicNotification4396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.__OnRecordPositionUpdateListener.staticClass, global::android.media.AudioRecord.__OnRecordPositionUpdateListener._onPeriodicNotification4396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.AudioRecord.__OnRecordPositionUpdateListener.staticClass = @__class; 
				global::android.media.AudioRecord.__OnRecordPositionUpdateListener._onMarkerReached4395 = @__env.GetMethodID(global::android.media.AudioRecord.__OnRecordPositionUpdateListener.staticClass, "android.media.AudioRecord.OnRecordPositionUpdateListener.onMarkerReached", "(Landroid/media/AudioRecord;)V"); 
				global::android.media.AudioRecord.__OnRecordPositionUpdateListener._onPeriodicNotification4396 = @__env.GetMethodID(global::android.media.AudioRecord.__OnRecordPositionUpdateListener.staticClass, "android.media.AudioRecord.OnRecordPositionUpdateListener.onPeriodicNotification", "(Landroid/media/AudioRecord;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4397; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioRecord._stop4397); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._stop4397); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState4398; 
		public virtual int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getState4398); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getState4398); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read4399; 
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._read4399, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read4399, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read4400; 
		public virtual int read(java.nio.ByteBuffer arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._read4400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read4400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read4401; 
		public virtual int read(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._read4401, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._read4401, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4402; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioRecord._release4402); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._release4402); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSampleRate4403; 
		public virtual int getSampleRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getSampleRate4403); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getSampleRate4403); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioSource4404; 
		public virtual int getAudioSource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getAudioSource4404); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getAudioSource4404); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioFormat4405; 
		public virtual int getAudioFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getAudioFormat4405); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getAudioFormat4405); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelConfiguration4406; 
		public virtual int getChannelConfiguration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getChannelConfiguration4406); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getChannelConfiguration4406); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelCount4407; 
		public virtual int getChannelCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getChannelCount4407); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getChannelCount4407); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRecordingState4408; 
		public virtual int getRecordingState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getRecordingState4408); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getRecordingState4408); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNotificationMarkerPosition4409; 
		public virtual int getNotificationMarkerPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getNotificationMarkerPosition4409); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getNotificationMarkerPosition4409); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionNotificationPeriod4410; 
		public virtual int getPositionNotificationPeriod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._getPositionNotificationPeriod4410); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getPositionNotificationPeriod4410); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinBufferSize4411; 
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._getMinBufferSize4411, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startRecording4412; 
		public virtual void startRecording() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioRecord._startRecording4412); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._startRecording4412); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRecordPositionUpdateListener4413; 
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioRecord._setRecordPositionUpdateListener4413, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setRecordPositionUpdateListener4413, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRecordPositionUpdateListener4414; 
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0, android.os.Handler arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioRecord._setRecordPositionUpdateListener4414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setRecordPositionUpdateListener4414, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationMarkerPosition4415; 
		public virtual int setNotificationMarkerPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._setNotificationMarkerPosition4415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setNotificationMarkerPosition4415, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositionNotificationPeriod4416; 
		public virtual int setPositionNotificationPeriod(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioRecord._setPositionNotificationPeriod4416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioRecord.staticClass, global::android.media.AudioRecord._setPositionNotificationPeriod4416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AudioRecord4417; 
		public AudioRecord(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.AudioRecord.staticClass, global::android.media.AudioRecord._AudioRecord4417, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.AudioRecord.staticClass = @__class; 
			global::android.media.AudioRecord._stop4397 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "stop", "()V"); 
			global::android.media.AudioRecord._getState4398 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getState", "()I"); 
			global::android.media.AudioRecord._read4399 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "read", "([BII)I"); 
			global::android.media.AudioRecord._read4400 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "read", "(Ljava/nio/ByteBuffer;I)I"); 
			global::android.media.AudioRecord._read4401 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "read", "([SII)I"); 
			global::android.media.AudioRecord._release4402 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "release", "()V"); 
			global::android.media.AudioRecord._getSampleRate4403 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getSampleRate", "()I"); 
			global::android.media.AudioRecord._getAudioSource4404 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getAudioSource", "()I"); 
			global::android.media.AudioRecord._getAudioFormat4405 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getAudioFormat", "()I"); 
			global::android.media.AudioRecord._getChannelConfiguration4406 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getChannelConfiguration", "()I"); 
			global::android.media.AudioRecord._getChannelCount4407 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getChannelCount", "()I"); 
			global::android.media.AudioRecord._getRecordingState4408 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getRecordingState", "()I"); 
			global::android.media.AudioRecord._getNotificationMarkerPosition4409 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getNotificationMarkerPosition", "()I"); 
			global::android.media.AudioRecord._getPositionNotificationPeriod4410 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getPositionNotificationPeriod", "()I"); 
			global::android.media.AudioRecord._getMinBufferSize4411 = @__env.GetStaticMethodID(global::android.media.AudioRecord.staticClass, "getMinBufferSize", "(III)I"); 
			global::android.media.AudioRecord._startRecording4412 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "startRecording", "()V"); 
			global::android.media.AudioRecord._setRecordPositionUpdateListener4413 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V"); 
			global::android.media.AudioRecord._setRecordPositionUpdateListener4414 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V"); 
			global::android.media.AudioRecord._setNotificationMarkerPosition4415 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setNotificationMarkerPosition", "(I)I"); 
			global::android.media.AudioRecord._setPositionNotificationPeriod4416 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setPositionNotificationPeriod", "(I)I"); 
			global::android.media.AudioRecord._AudioRecord4417 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "<init>", "(IIIII)V"); 
		} 
	} 
} 
