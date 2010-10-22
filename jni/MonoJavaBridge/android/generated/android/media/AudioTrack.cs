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
		public sealed partial class OnPlaybackPositionUpdateListener_ : java.lang.Object, OnPlaybackPositionUpdateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnPlaybackPositionUpdateListener_()
			{
				InitJNI();
			}
			internal OnPlaybackPositionUpdateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onMarkerReached7149;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached(android.media.AudioTrack arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached7149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached7149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onPeriodicNotification7150;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification(android.media.AudioTrack arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification7150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification7150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioTrack$OnPlaybackPositionUpdateListener"));
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached7149 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioTrack;)V");
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification7150 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioTrack;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7151;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._finalize7151);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._finalize7151);
		}
		internal static global::MonoJavaBridge.MethodId _write7152;
		public virtual int write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._write7152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write7152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write7153;
		public virtual int write(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._write7153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write7153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stop7154;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._stop7154);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._stop7154);
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
		internal static global::MonoJavaBridge.MethodId _getState7155;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getState7155);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getState7155);
		}
		internal static global::MonoJavaBridge.MethodId _flush7156;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._flush7156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._flush7156);
		}
		internal static global::MonoJavaBridge.MethodId _setState7157;
		protected virtual void setState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setState7157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setState7157, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release7158;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._release7158);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._release7158);
		}
		internal static global::MonoJavaBridge.MethodId _play7159;
		public virtual void play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._play7159);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._play7159);
		}
		public new int SampleRate
		{
			get
			{
				return getSampleRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSampleRate7160;
		public virtual int getSampleRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getSampleRate7160);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getSampleRate7160);
		}
		public new int AudioFormat
		{
			get
			{
				return getAudioFormat();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioFormat7161;
		public virtual int getAudioFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getAudioFormat7161);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getAudioFormat7161);
		}
		public new int ChannelConfiguration
		{
			get
			{
				return getChannelConfiguration();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelConfiguration7162;
		public virtual int getChannelConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getChannelConfiguration7162);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelConfiguration7162);
		}
		public new int ChannelCount
		{
			get
			{
				return getChannelCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChannelCount7163;
		public virtual int getChannelCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getChannelCount7163);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelCount7163);
		}
		public new int NotificationMarkerPosition
		{
			get
			{
				return getNotificationMarkerPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNotificationMarkerPosition7164;
		public virtual int getNotificationMarkerPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getNotificationMarkerPosition7164);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNotificationMarkerPosition7164);
		}
		public new int PositionNotificationPeriod
		{
			get
			{
				return getPositionNotificationPeriod();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositionNotificationPeriod7165;
		public virtual int getPositionNotificationPeriod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPositionNotificationPeriod7165);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPositionNotificationPeriod7165);
		}
		internal static global::MonoJavaBridge.MethodId _getMinBufferSize7166;
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinBufferSize7166, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationMarkerPosition7167;
		public virtual int setNotificationMarkerPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setNotificationMarkerPosition7167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setNotificationMarkerPosition7167, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositionNotificationPeriod7168;
		public virtual int setPositionNotificationPeriod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPositionNotificationPeriod7168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPositionNotificationPeriod7168, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static float MinVolume
		{
			get
			{
				return getMinVolume();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMinVolume7169;
		public static float getMinVolume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinVolume7169);
		}
		public static float MaxVolume
		{
			get
			{
				return getMaxVolume();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxVolume7170;
		public static float getMaxVolume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMaxVolume7170);
		}
		public new int PlaybackRate
		{
			get
			{
				return getPlaybackRate();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlaybackRate7171;
		public virtual int getPlaybackRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlaybackRate7171);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackRate7171);
		}
		public new int StreamType
		{
			get
			{
				return getStreamType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStreamType7172;
		public virtual int getStreamType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getStreamType7172);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getStreamType7172);
		}
		public new int PlayState
		{
			get
			{
				return getPlayState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlayState7173;
		public virtual int getPlayState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlayState7173);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlayState7173);
		}
		protected new int NativeFrameCount
		{
			get
			{
				return getNativeFrameCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNativeFrameCount7174;
		protected virtual int getNativeFrameCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getNativeFrameCount7174);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeFrameCount7174);
		}
		public new int PlaybackHeadPosition
		{
			get
			{
				return getPlaybackHeadPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPlaybackHeadPosition7175;
		public virtual int getPlaybackHeadPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlaybackHeadPosition7175);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackHeadPosition7175);
		}
		internal static global::MonoJavaBridge.MethodId _getNativeOutputSampleRate7176;
		public static int getNativeOutputSampleRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeOutputSampleRate7176, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackPositionUpdateListener7177;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7177, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackPositionUpdateListener7178;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener7178, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStereoVolume7179;
		public virtual int setStereoVolume(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setStereoVolume7179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setStereoVolume7179, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackRate7180;
		public virtual int setPlaybackRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackRate7180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackRate7180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackHeadPosition7181;
		public virtual int setPlaybackHeadPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackHeadPosition7181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackHeadPosition7181, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLoopPoints7182;
		public virtual int setLoopPoints(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setLoopPoints7182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setLoopPoints7182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _pause7183;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._pause7183);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._pause7183);
		}
		internal static global::MonoJavaBridge.MethodId _reloadStaticData7184;
		public virtual int reloadStaticData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._reloadStaticData7184);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._reloadStaticData7184);
		}
		internal static global::MonoJavaBridge.MethodId _AudioTrack7185;
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._AudioTrack7185, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::android.media.AudioTrack._finalize7151 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "finalize", "()V");
			global::android.media.AudioTrack._write7152 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "write", "([BII)I");
			global::android.media.AudioTrack._write7153 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "write", "([SII)I");
			global::android.media.AudioTrack._stop7154 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "stop", "()V");
			global::android.media.AudioTrack._getState7155 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getState", "()I");
			global::android.media.AudioTrack._flush7156 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "flush", "()V");
			global::android.media.AudioTrack._setState7157 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setState", "(I)V");
			global::android.media.AudioTrack._release7158 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "release", "()V");
			global::android.media.AudioTrack._play7159 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "play", "()V");
			global::android.media.AudioTrack._getSampleRate7160 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getSampleRate", "()I");
			global::android.media.AudioTrack._getAudioFormat7161 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I");
			global::android.media.AudioTrack._getChannelConfiguration7162 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I");
			global::android.media.AudioTrack._getChannelCount7163 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getChannelCount", "()I");
			global::android.media.AudioTrack._getNotificationMarkerPosition7164 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I");
			global::android.media.AudioTrack._getPositionNotificationPeriod7165 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I");
			global::android.media.AudioTrack._getMinBufferSize7166 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I");
			global::android.media.AudioTrack._setNotificationMarkerPosition7167 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I");
			global::android.media.AudioTrack._setPositionNotificationPeriod7168 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I");
			global::android.media.AudioTrack._getMinVolume7169 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F");
			global::android.media.AudioTrack._getMaxVolume7170 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F");
			global::android.media.AudioTrack._getPlaybackRate7171 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I");
			global::android.media.AudioTrack._getStreamType7172 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getStreamType", "()I");
			global::android.media.AudioTrack._getPlayState7173 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlayState", "()I");
			global::android.media.AudioTrack._getNativeFrameCount7174 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I");
			global::android.media.AudioTrack._getPlaybackHeadPosition7175 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I");
			global::android.media.AudioTrack._getNativeOutputSampleRate7176 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener7177 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener7178 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V");
			global::android.media.AudioTrack._setStereoVolume7179 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I");
			global::android.media.AudioTrack._setPlaybackRate7180 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackHeadPosition7181 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I");
			global::android.media.AudioTrack._setLoopPoints7182 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I");
			global::android.media.AudioTrack._pause7183 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "pause", "()V");
			global::android.media.AudioTrack._reloadStaticData7184 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I");
			global::android.media.AudioTrack._AudioTrack7185 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
