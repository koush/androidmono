namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AudioTrack : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AudioTrack()
		{
			InitJNI();
		}
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
			static OnPlaybackPositionUpdateListener_()
			{
				InitJNI();
			}
			internal OnPlaybackPositionUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMarkerReached7177;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached(android.media.AudioTrack arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached7177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached7177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onPeriodicNotification7178;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification(android.media.AudioTrack arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification7178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification7178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioTrack$OnPlaybackPositionUpdateListener"));
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached7177 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioTrack;)V");
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification7178 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioTrack;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7179;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._finalize7179);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._finalize7179);
		}
		internal static global::MonoJavaBridge.MethodId _write7180;
		public virtual int write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._write7180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write7180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write7181;
		public virtual int write(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._write7181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write7181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stop7182;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._stop7182);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._stop7182);
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
		internal static global::MonoJavaBridge.MethodId _getState7183;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getState7183);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getState7183);
		}
		internal static global::MonoJavaBridge.MethodId _flush7184;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._flush7184);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._flush7184);
		}
		internal static global::MonoJavaBridge.MethodId _setState7185;
		protected virtual void setState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setState7185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setState7185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release7186;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._release7186);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._release7186);
		}
		internal static global::MonoJavaBridge.MethodId _play7187;
		public virtual void play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._play7187);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._play7187);
		}
		public new int SampleRate
		{
			get
			{
				return getSampleRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSampleRate7188;
		public virtual int getSampleRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getSampleRate7188);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getSampleRate7188);
		}
		public new int AudioFormat
		{
			get
			{
				return getAudioFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioFormat7189;
		public virtual int getAudioFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getAudioFormat7189);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getAudioFormat7189);
		}
		public new int ChannelConfiguration
		{
			get
			{
				return getChannelConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelConfiguration7190;
		public virtual int getChannelConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getChannelConfiguration7190);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelConfiguration7190);
		}
		public new int ChannelCount
		{
			get
			{
				return getChannelCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelCount7191;
		public virtual int getChannelCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getChannelCount7191);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelCount7191);
		}
		public new int NotificationMarkerPosition
		{
			get
			{
				return getNotificationMarkerPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNotificationMarkerPosition7192;
		public virtual int getNotificationMarkerPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getNotificationMarkerPosition7192);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNotificationMarkerPosition7192);
		}
		public new int PositionNotificationPeriod
		{
			get
			{
				return getPositionNotificationPeriod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositionNotificationPeriod7193;
		public virtual int getPositionNotificationPeriod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPositionNotificationPeriod7193);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPositionNotificationPeriod7193);
		}
		internal static global::MonoJavaBridge.MethodId _getMinBufferSize7194;
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinBufferSize7194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationMarkerPosition7195;
		public virtual int setNotificationMarkerPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setNotificationMarkerPosition7195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setNotificationMarkerPosition7195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositionNotificationPeriod7196;
		public virtual int setPositionNotificationPeriod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPositionNotificationPeriod7196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPositionNotificationPeriod7196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static float MinVolume
		{
			get
			{
				return getMinVolume();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinVolume7197;
		public static float getMinVolume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinVolume7197);
		}
		public static float MaxVolume
		{
			get
			{
				return getMaxVolume();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxVolume7198;
		public static float getMaxVolume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMaxVolume7198);
		}
		public new int PlaybackRate
		{
			get
			{
				return getPlaybackRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlaybackRate7199;
		public virtual int getPlaybackRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlaybackRate7199);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackRate7199);
		}
		public new int StreamType
		{
			get
			{
				return getStreamType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStreamType7200;
		public virtual int getStreamType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getStreamType7200);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getStreamType7200);
		}
		public new int PlayState
		{
			get
			{
				return getPlayState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlayState7201;
		public virtual int getPlayState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlayState7201);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlayState7201);
		}
		protected new int NativeFrameCount
		{
			get
			{
				return getNativeFrameCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeFrameCount7202;
		protected virtual int getNativeFrameCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getNativeFrameCount7202);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeFrameCount7202);
		}
		public new int PlaybackHeadPosition
		{
			get
			{
				return getPlaybackHeadPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlaybackHeadPosition7203;
		public virtual int getPlaybackHeadPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlaybackHeadPosition7203);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackHeadPosition7203);
		}
		internal static global::MonoJavaBridge.MethodId _getNativeOutputSampleRate7204;
		public static int getNativeOutputSampleRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeOutputSampleRate7204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackPositionUpdateListener7205;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackPositionUpdateListener7206;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStereoVolume7207;
		public virtual int setStereoVolume(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setStereoVolume7207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setStereoVolume7207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackRate7208;
		public virtual int setPlaybackRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackRate7208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackRate7208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackHeadPosition7209;
		public virtual int setPlaybackHeadPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackHeadPosition7209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackHeadPosition7209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLoopPoints7210;
		public virtual int setLoopPoints(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setLoopPoints7210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setLoopPoints7210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _pause7211;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._pause7211);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._pause7211);
		}
		internal static global::MonoJavaBridge.MethodId _reloadStaticData7212;
		public virtual int reloadStaticData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._reloadStaticData7212);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._reloadStaticData7212);
		}
		internal static global::MonoJavaBridge.MethodId _AudioTrack7213;
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._AudioTrack7213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AudioTrack.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioTrack"));
			global::android.media.AudioTrack._finalize7179 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "finalize", "()V");
			global::android.media.AudioTrack._write7180 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "write", "([BII)I");
			global::android.media.AudioTrack._write7181 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "write", "([SII)I");
			global::android.media.AudioTrack._stop7182 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "stop", "()V");
			global::android.media.AudioTrack._getState7183 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getState", "()I");
			global::android.media.AudioTrack._flush7184 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "flush", "()V");
			global::android.media.AudioTrack._setState7185 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setState", "(I)V");
			global::android.media.AudioTrack._release7186 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "release", "()V");
			global::android.media.AudioTrack._play7187 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "play", "()V");
			global::android.media.AudioTrack._getSampleRate7188 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getSampleRate", "()I");
			global::android.media.AudioTrack._getAudioFormat7189 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I");
			global::android.media.AudioTrack._getChannelConfiguration7190 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I");
			global::android.media.AudioTrack._getChannelCount7191 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getChannelCount", "()I");
			global::android.media.AudioTrack._getNotificationMarkerPosition7192 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I");
			global::android.media.AudioTrack._getPositionNotificationPeriod7193 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I");
			global::android.media.AudioTrack._getMinBufferSize7194 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I");
			global::android.media.AudioTrack._setNotificationMarkerPosition7195 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I");
			global::android.media.AudioTrack._setPositionNotificationPeriod7196 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I");
			global::android.media.AudioTrack._getMinVolume7197 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F");
			global::android.media.AudioTrack._getMaxVolume7198 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F");
			global::android.media.AudioTrack._getPlaybackRate7199 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I");
			global::android.media.AudioTrack._getStreamType7200 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getStreamType", "()I");
			global::android.media.AudioTrack._getPlayState7201 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlayState", "()I");
			global::android.media.AudioTrack._getNativeFrameCount7202 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I");
			global::android.media.AudioTrack._getPlaybackHeadPosition7203 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I");
			global::android.media.AudioTrack._getNativeOutputSampleRate7204 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener7205 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener7206 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V");
			global::android.media.AudioTrack._setStereoVolume7207 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I");
			global::android.media.AudioTrack._setPlaybackRate7208 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackHeadPosition7209 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I");
			global::android.media.AudioTrack._setLoopPoints7210 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I");
			global::android.media.AudioTrack._pause7211 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "pause", "()V");
			global::android.media.AudioTrack._reloadStaticData7212 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I");
			global::android.media.AudioTrack._AudioTrack7213 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
