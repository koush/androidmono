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
		public interface OnPlaybackPositionUpdateListener  : global::MonoJavaBridge.IJavaObject 
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
			internal static global::MonoJavaBridge.MethodId _onMarkerReached4890;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached(android.media.AudioTrack arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached4890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached4890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onPeriodicNotification4891;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification(android.media.AudioTrack arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification4891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification4891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioTrack$OnPlaybackPositionUpdateListener"));
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onMarkerReached4890 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onMarkerReached", "(Landroid/media/AudioTrack;)V");
				global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_._onPeriodicNotification4891 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.OnPlaybackPositionUpdateListener_.staticClass, "onPeriodicNotification", "(Landroid/media/AudioTrack;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4892;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._finalize4892);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._finalize4892);
		}
		internal static global::MonoJavaBridge.MethodId _write4893;
		public virtual int write(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._write4893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write4893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write4894;
		public virtual int write(short[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._write4894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write4894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _stop4895;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._stop4895);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._stop4895);
		}
		internal static global::MonoJavaBridge.MethodId _getState4896;
		public virtual int getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getState4896);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getState4896);
		}
		internal static global::MonoJavaBridge.MethodId _flush4897;
		public virtual void flush() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._flush4897);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._flush4897);
		}
		internal static global::MonoJavaBridge.MethodId _setState4898;
		protected virtual void setState(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setState4898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setState4898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release4899;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._release4899);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._release4899);
		}
		internal static global::MonoJavaBridge.MethodId _play4900;
		public virtual void play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._play4900);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._play4900);
		}
		internal static global::MonoJavaBridge.MethodId _getSampleRate4901;
		public virtual int getSampleRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getSampleRate4901);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getSampleRate4901);
		}
		internal static global::MonoJavaBridge.MethodId _getAudioFormat4902;
		public virtual int getAudioFormat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getAudioFormat4902);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getAudioFormat4902);
		}
		internal static global::MonoJavaBridge.MethodId _getChannelConfiguration4903;
		public virtual int getChannelConfiguration() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getChannelConfiguration4903);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelConfiguration4903);
		}
		internal static global::MonoJavaBridge.MethodId _getChannelCount4904;
		public virtual int getChannelCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getChannelCount4904);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelCount4904);
		}
		internal static global::MonoJavaBridge.MethodId _getNotificationMarkerPosition4905;
		public virtual int getNotificationMarkerPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getNotificationMarkerPosition4905);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNotificationMarkerPosition4905);
		}
		internal static global::MonoJavaBridge.MethodId _getPositionNotificationPeriod4906;
		public virtual int getPositionNotificationPeriod() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPositionNotificationPeriod4906);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPositionNotificationPeriod4906);
		}
		internal static global::MonoJavaBridge.MethodId _getMinBufferSize4907;
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinBufferSize4907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationMarkerPosition4908;
		public virtual int setNotificationMarkerPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setNotificationMarkerPosition4908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setNotificationMarkerPosition4908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPositionNotificationPeriod4909;
		public virtual int setPositionNotificationPeriod(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPositionNotificationPeriod4909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPositionNotificationPeriod4909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMinVolume4910;
		public static float getMinVolume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinVolume4910);
		}
		internal static global::MonoJavaBridge.MethodId _getMaxVolume4911;
		public static float getMaxVolume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMaxVolume4911);
		}
		internal static global::MonoJavaBridge.MethodId _getPlaybackRate4912;
		public virtual int getPlaybackRate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlaybackRate4912);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackRate4912);
		}
		internal static global::MonoJavaBridge.MethodId _getStreamType4913;
		public virtual int getStreamType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getStreamType4913);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getStreamType4913);
		}
		internal static global::MonoJavaBridge.MethodId _getPlayState4914;
		public virtual int getPlayState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlayState4914);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlayState4914);
		}
		internal static global::MonoJavaBridge.MethodId _getNativeFrameCount4915;
		protected virtual int getNativeFrameCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getNativeFrameCount4915);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeFrameCount4915);
		}
		internal static global::MonoJavaBridge.MethodId _getPlaybackHeadPosition4916;
		public virtual int getPlaybackHeadPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._getPlaybackHeadPosition4916);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackHeadPosition4916);
		}
		internal static global::MonoJavaBridge.MethodId _getNativeOutputSampleRate4917;
		public static int getNativeOutputSampleRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeOutputSampleRate4917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackPositionUpdateListener4918;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackPositionUpdateListener4919;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4919, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStereoVolume4920;
		public virtual int setStereoVolume(float arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setStereoVolume4920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setStereoVolume4920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackRate4921;
		public virtual int setPlaybackRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackRate4921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackRate4921, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPlaybackHeadPosition4922;
		public virtual int setPlaybackHeadPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setPlaybackHeadPosition4922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackHeadPosition4922, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLoopPoints4923;
		public virtual int setLoopPoints(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._setLoopPoints4923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setLoopPoints4923, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _pause4924;
		public virtual void pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioTrack._pause4924);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._pause4924);
		}
		internal static global::MonoJavaBridge.MethodId _reloadStaticData4925;
		public virtual int reloadStaticData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioTrack._reloadStaticData4925);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._reloadStaticData4925);
		}
		internal static global::MonoJavaBridge.MethodId _AudioTrack4926;
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._AudioTrack4926, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
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
			global::android.media.AudioTrack._finalize4892 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "finalize", "()V");
			global::android.media.AudioTrack._write4893 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "write", "([BII)I");
			global::android.media.AudioTrack._write4894 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "write", "([SII)I");
			global::android.media.AudioTrack._stop4895 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "stop", "()V");
			global::android.media.AudioTrack._getState4896 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getState", "()I");
			global::android.media.AudioTrack._flush4897 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "flush", "()V");
			global::android.media.AudioTrack._setState4898 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setState", "(I)V");
			global::android.media.AudioTrack._release4899 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "release", "()V");
			global::android.media.AudioTrack._play4900 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "play", "()V");
			global::android.media.AudioTrack._getSampleRate4901 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getSampleRate", "()I");
			global::android.media.AudioTrack._getAudioFormat4902 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I");
			global::android.media.AudioTrack._getChannelConfiguration4903 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I");
			global::android.media.AudioTrack._getChannelCount4904 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getChannelCount", "()I");
			global::android.media.AudioTrack._getNotificationMarkerPosition4905 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I");
			global::android.media.AudioTrack._getPositionNotificationPeriod4906 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I");
			global::android.media.AudioTrack._getMinBufferSize4907 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I");
			global::android.media.AudioTrack._setNotificationMarkerPosition4908 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I");
			global::android.media.AudioTrack._setPositionNotificationPeriod4909 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I");
			global::android.media.AudioTrack._getMinVolume4910 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F");
			global::android.media.AudioTrack._getMaxVolume4911 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F");
			global::android.media.AudioTrack._getPlaybackRate4912 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I");
			global::android.media.AudioTrack._getStreamType4913 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getStreamType", "()I");
			global::android.media.AudioTrack._getPlayState4914 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlayState", "()I");
			global::android.media.AudioTrack._getNativeFrameCount4915 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I");
			global::android.media.AudioTrack._getPlaybackHeadPosition4916 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I");
			global::android.media.AudioTrack._getNativeOutputSampleRate4917 = @__env.GetStaticMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4918 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4919 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V");
			global::android.media.AudioTrack._setStereoVolume4920 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I");
			global::android.media.AudioTrack._setPlaybackRate4921 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackHeadPosition4922 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I");
			global::android.media.AudioTrack._setLoopPoints4923 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I");
			global::android.media.AudioTrack._pause4924 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "pause", "()V");
			global::android.media.AudioTrack._reloadStaticData4925 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I");
			global::android.media.AudioTrack._AudioTrack4926 = @__env.GetMethodIDNoThrow(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
