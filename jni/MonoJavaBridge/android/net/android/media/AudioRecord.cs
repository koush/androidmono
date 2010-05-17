namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AudioRecord : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AudioRecord() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.AudioRecord), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _stop4166; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				@__env.CallVoidMethod(this, _stop4166); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioRecord.staticClass, _stop4166); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState4167; 
		public virtual int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getState4167); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getState4167); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read4168; 
		public virtual int read(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _read4168, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _read4168, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read4169; 
		public virtual int read(java.nio.ByteBuffer arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _read4169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _read4169, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _read4170; 
		public virtual int read(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _read4170, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _read4170, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4171; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				@__env.CallVoidMethod(this, _release4171); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioRecord.staticClass, _release4171); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSampleRate4172; 
		public virtual int getSampleRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getSampleRate4172); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getSampleRate4172); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioSource4173; 
		public virtual int getAudioSource() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getAudioSource4173); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getAudioSource4173); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioFormat4174; 
		public virtual int getAudioFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getAudioFormat4174); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getAudioFormat4174); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelConfiguration4175; 
		public virtual int getChannelConfiguration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getChannelConfiguration4175); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getChannelConfiguration4175); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelCount4176; 
		public virtual int getChannelCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getChannelCount4176); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getChannelCount4176); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRecordingState4177; 
		public virtual int getRecordingState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getRecordingState4177); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getRecordingState4177); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNotificationMarkerPosition4178; 
		public virtual int getNotificationMarkerPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getNotificationMarkerPosition4178); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getNotificationMarkerPosition4178); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionNotificationPeriod4179; 
		public virtual int getPositionNotificationPeriod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _getPositionNotificationPeriod4179); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _getPositionNotificationPeriod4179); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinBufferSize4180; 
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.AudioRecord.staticClass, _getMinBufferSize4180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startRecording4181; 
		public virtual void startRecording() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				@__env.CallVoidMethod(this, _startRecording4181); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioRecord.staticClass, _startRecording4181); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRecordPositionUpdateListener4182; 
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				@__env.CallVoidMethod(this, _setRecordPositionUpdateListener4182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioRecord.staticClass, _setRecordPositionUpdateListener4182, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRecordPositionUpdateListener4183; 
		public virtual void setRecordPositionUpdateListener(android.media.AudioRecord.OnRecordPositionUpdateListener arg0, android.os.Handler arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				@__env.CallVoidMethod(this, _setRecordPositionUpdateListener4183, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioRecord.staticClass, _setRecordPositionUpdateListener4183, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationMarkerPosition4184; 
		public virtual int setNotificationMarkerPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _setNotificationMarkerPosition4184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _setNotificationMarkerPosition4184, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositionNotificationPeriod4185; 
		public virtual int setPositionNotificationPeriod(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioRecord)) 
				return @__env.CallIntMethod(this, _setPositionNotificationPeriod4185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioRecord.staticClass, _setPositionNotificationPeriod4185, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AudioRecord4186; 
		public AudioRecord(int arg0, int arg1, int arg2, int arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.AudioRecord.staticClass, _AudioRecord4186, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
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
			global::android.media.AudioRecord._stop4166 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "stop", "()V"); 
			global::android.media.AudioRecord._getState4167 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getState", "()I"); 
			global::android.media.AudioRecord._read4168 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "read", "([BII)I"); 
			global::android.media.AudioRecord._read4169 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "read", "(Ljava/nio/ByteBuffer;I)I"); 
			global::android.media.AudioRecord._read4170 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "read", "([SII)I"); 
			global::android.media.AudioRecord._release4171 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "release", "()V"); 
			global::android.media.AudioRecord._getSampleRate4172 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getSampleRate", "()I"); 
			global::android.media.AudioRecord._getAudioSource4173 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getAudioSource", "()I"); 
			global::android.media.AudioRecord._getAudioFormat4174 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getAudioFormat", "()I"); 
			global::android.media.AudioRecord._getChannelConfiguration4175 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getChannelConfiguration", "()I"); 
			global::android.media.AudioRecord._getChannelCount4176 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getChannelCount", "()I"); 
			global::android.media.AudioRecord._getRecordingState4177 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getRecordingState", "()I"); 
			global::android.media.AudioRecord._getNotificationMarkerPosition4178 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getNotificationMarkerPosition", "()I"); 
			global::android.media.AudioRecord._getPositionNotificationPeriod4179 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "getPositionNotificationPeriod", "()I"); 
			global::android.media.AudioRecord._getMinBufferSize4180 = @__env.GetStaticMethodID(global::android.media.AudioRecord.staticClass, "getMinBufferSize", "(III)I"); 
			global::android.media.AudioRecord._startRecording4181 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "startRecording", "()V"); 
			global::android.media.AudioRecord._setRecordPositionUpdateListener4182 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;)V"); 
			global::android.media.AudioRecord._setRecordPositionUpdateListener4183 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setRecordPositionUpdateListener", "(Landroid/media/AudioRecord$OnRecordPositionUpdateListener;Landroid/os/Handler;)V"); 
			global::android.media.AudioRecord._setNotificationMarkerPosition4184 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setNotificationMarkerPosition", "(I)I"); 
			global::android.media.AudioRecord._setPositionNotificationPeriod4185 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "setPositionNotificationPeriod", "(I)I"); 
			global::android.media.AudioRecord._AudioRecord4186 = @__env.GetMethodID(global::android.media.AudioRecord.staticClass, "<init>", "(IIIII)V"); 
		} 
	} 
} 
