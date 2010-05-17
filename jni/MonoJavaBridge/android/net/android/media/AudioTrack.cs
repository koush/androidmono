namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AudioTrack : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AudioTrack() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.AudioTrack), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.AudioTrack(@__env); 
			} 
		} 
		protected AudioTrack(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnPlaybackPositionUpdateListener 
		{ 
			void onMarkerReached(android.media.AudioTrack arg0); 
			void onPeriodicNotification(android.media.AudioTrack arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write4187; 
		public virtual int write(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _write4187, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _write4187, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write4188; 
		public virtual int write(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _write4188, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _write4188, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4189; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _stop4189); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _stop4189); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState4190; 
		public virtual int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getState4190); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getState4190); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush4191; 
		public virtual void flush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _flush4191); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _flush4191); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setState4192; 
		protected virtual void setState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _setState4192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _setState4192, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4193; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _release4193); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _release4193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4194; 
		public virtual void play() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _play4194); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _play4194); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSampleRate4195; 
		public virtual int getSampleRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getSampleRate4195); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getSampleRate4195); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioFormat4196; 
		public virtual int getAudioFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getAudioFormat4196); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getAudioFormat4196); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelConfiguration4197; 
		public virtual int getChannelConfiguration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getChannelConfiguration4197); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getChannelConfiguration4197); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelCount4198; 
		public virtual int getChannelCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getChannelCount4198); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getChannelCount4198); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNotificationMarkerPosition4199; 
		public virtual int getNotificationMarkerPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getNotificationMarkerPosition4199); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getNotificationMarkerPosition4199); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionNotificationPeriod4200; 
		public virtual int getPositionNotificationPeriod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getPositionNotificationPeriod4200); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getPositionNotificationPeriod4200); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinBufferSize4201; 
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, _getMinBufferSize4201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationMarkerPosition4202; 
		public virtual int setNotificationMarkerPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _setNotificationMarkerPosition4202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _setNotificationMarkerPosition4202, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositionNotificationPeriod4203; 
		public virtual int setPositionNotificationPeriod(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _setPositionNotificationPeriod4203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _setPositionNotificationPeriod4203, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinVolume4204; 
		public static float getMinVolume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, _getMinVolume4204); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxVolume4205; 
		public static float getMaxVolume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, _getMaxVolume4205); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPlaybackRate4206; 
		public virtual int getPlaybackRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getPlaybackRate4206); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getPlaybackRate4206); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamType4207; 
		public virtual int getStreamType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getStreamType4207); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getStreamType4207); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPlayState4208; 
		public virtual int getPlayState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getPlayState4208); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getPlayState4208); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeFrameCount4209; 
		protected virtual int getNativeFrameCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getNativeFrameCount4209); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getNativeFrameCount4209); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPlaybackHeadPosition4210; 
		public virtual int getPlaybackHeadPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _getPlaybackHeadPosition4210); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _getPlaybackHeadPosition4210); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeOutputSampleRate4211; 
		public static int getNativeOutputSampleRate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, _getNativeOutputSampleRate4211, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackPositionUpdateListener4212; 
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _setPlaybackPositionUpdateListener4212, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _setPlaybackPositionUpdateListener4212, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackPositionUpdateListener4213; 
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _setPlaybackPositionUpdateListener4213, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _setPlaybackPositionUpdateListener4213, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStereoVolume4214; 
		public virtual int setStereoVolume(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _setStereoVolume4214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _setStereoVolume4214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackRate4215; 
		public virtual int setPlaybackRate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _setPlaybackRate4215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _setPlaybackRate4215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackHeadPosition4216; 
		public virtual int setPlaybackHeadPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _setPlaybackHeadPosition4216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _setPlaybackHeadPosition4216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLoopPoints4217; 
		public virtual int setLoopPoints(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _setLoopPoints4217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _setLoopPoints4217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4218; 
		public virtual void pause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, _pause4218); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioTrack.staticClass, _pause4218); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reloadStaticData4219; 
		public virtual int reloadStaticData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, _reloadStaticData4219); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioTrack.staticClass, _reloadStaticData4219); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AudioTrack4220; 
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.AudioTrack.staticClass, _AudioTrack4220, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.AudioTrack.staticClass = @__class; 
			global::android.media.AudioTrack._write4187 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "write", "([BII)I"); 
			global::android.media.AudioTrack._write4188 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "write", "([SII)I"); 
			global::android.media.AudioTrack._stop4189 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "stop", "()V"); 
			global::android.media.AudioTrack._getState4190 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getState", "()I"); 
			global::android.media.AudioTrack._flush4191 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "flush", "()V"); 
			global::android.media.AudioTrack._setState4192 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setState", "(I)V"); 
			global::android.media.AudioTrack._release4193 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "release", "()V"); 
			global::android.media.AudioTrack._play4194 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "play", "()V"); 
			global::android.media.AudioTrack._getSampleRate4195 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getSampleRate", "()I"); 
			global::android.media.AudioTrack._getAudioFormat4196 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I"); 
			global::android.media.AudioTrack._getChannelConfiguration4197 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I"); 
			global::android.media.AudioTrack._getChannelCount4198 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getChannelCount", "()I"); 
			global::android.media.AudioTrack._getNotificationMarkerPosition4199 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I"); 
			global::android.media.AudioTrack._getPositionNotificationPeriod4200 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I"); 
			global::android.media.AudioTrack._getMinBufferSize4201 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I"); 
			global::android.media.AudioTrack._setNotificationMarkerPosition4202 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I"); 
			global::android.media.AudioTrack._setPositionNotificationPeriod4203 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I"); 
			global::android.media.AudioTrack._getMinVolume4204 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F"); 
			global::android.media.AudioTrack._getMaxVolume4205 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F"); 
			global::android.media.AudioTrack._getPlaybackRate4206 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I"); 
			global::android.media.AudioTrack._getStreamType4207 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getStreamType", "()I"); 
			global::android.media.AudioTrack._getPlayState4208 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlayState", "()I"); 
			global::android.media.AudioTrack._getNativeFrameCount4209 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I"); 
			global::android.media.AudioTrack._getPlaybackHeadPosition4210 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I"); 
			global::android.media.AudioTrack._getNativeOutputSampleRate4211 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I"); 
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4212 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V"); 
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4213 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V"); 
			global::android.media.AudioTrack._setStereoVolume4214 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I"); 
			global::android.media.AudioTrack._setPlaybackRate4215 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I"); 
			global::android.media.AudioTrack._setPlaybackHeadPosition4216 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I"); 
			global::android.media.AudioTrack._setLoopPoints4217 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I"); 
			global::android.media.AudioTrack._pause4218 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "pause", "()V"); 
			global::android.media.AudioTrack._reloadStaticData4219 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I"); 
			global::android.media.AudioTrack._AudioTrack4220 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V"); 
		} 
	} 
} 
