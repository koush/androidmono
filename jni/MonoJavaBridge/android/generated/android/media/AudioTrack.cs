namespace android.media
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AudioTrack : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static AudioTrack()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.AudioTrack), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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

		public partial class OnPlaybackPositionUpdateListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnPlaybackPositionUpdateListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnPlaybackPositionUpdateListener : java.lang.Object, OnPlaybackPositionUpdateListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnPlaybackPositionUpdateListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener(@__env);
				}
			}
			internal __OnPlaybackPositionUpdateListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onMarkerReached4658;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached(android.media.AudioTrack arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onMarkerReached4658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onMarkerReached4658, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPeriodicNotification4659;
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification(android.media.AudioTrack arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onPeriodicNotification4659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onPeriodicNotification4659, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass = @__class;
				global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onMarkerReached4658 = @__env.GetMethodID(global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, "android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached", "(Landroid/media/AudioTrack;)V");
				global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onPeriodicNotification4659 = @__env.GetMethodID(global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, "android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification", "(Landroid/media/AudioTrack;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _write4660;
		public virtual int write(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._write4660, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write4660, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _write4661;
		public virtual int write(short[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._write4661, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write4661, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop4662;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._stop4662);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._stop4662);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getState4663;
		public virtual int getState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getState4663);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getState4663);
		}
		internal static global::net.sf.jni4net.jni.MethodId _flush4664;
		public virtual void flush() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._flush4664);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._flush4664);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setState4665;
		protected virtual void setState(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._setState4665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setState4665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _release4666;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._release4666);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._release4666);
		}
		internal static global::net.sf.jni4net.jni.MethodId _play4667;
		public virtual void play() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._play4667);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._play4667);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSampleRate4668;
		public virtual int getSampleRate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getSampleRate4668);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getSampleRate4668);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAudioFormat4669;
		public virtual int getAudioFormat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getAudioFormat4669);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getAudioFormat4669);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChannelConfiguration4670;
		public virtual int getChannelConfiguration() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getChannelConfiguration4670);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelConfiguration4670);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChannelCount4671;
		public virtual int getChannelCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getChannelCount4671);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelCount4671);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNotificationMarkerPosition4672;
		public virtual int getNotificationMarkerPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getNotificationMarkerPosition4672);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNotificationMarkerPosition4672);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPositionNotificationPeriod4673;
		public virtual int getPositionNotificationPeriod() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPositionNotificationPeriod4673);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPositionNotificationPeriod4673);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinBufferSize4674;
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinBufferSize4674, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationMarkerPosition4675;
		public virtual int setNotificationMarkerPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setNotificationMarkerPosition4675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setNotificationMarkerPosition4675, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPositionNotificationPeriod4676;
		public virtual int setPositionNotificationPeriod(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setPositionNotificationPeriod4676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPositionNotificationPeriod4676, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMinVolume4677;
		public static float getMinVolume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinVolume4677);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxVolume4678;
		public static float getMaxVolume() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMaxVolume4678);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPlaybackRate4679;
		public virtual int getPlaybackRate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPlaybackRate4679);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackRate4679);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStreamType4680;
		public virtual int getStreamType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getStreamType4680);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getStreamType4680);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPlayState4681;
		public virtual int getPlayState() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPlayState4681);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlayState4681);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNativeFrameCount4682;
		protected virtual int getNativeFrameCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getNativeFrameCount4682);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeFrameCount4682);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPlaybackHeadPosition4683;
		public virtual int getPlaybackHeadPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPlaybackHeadPosition4683);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackHeadPosition4683);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNativeOutputSampleRate4684;
		public static int getNativeOutputSampleRate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeOutputSampleRate4684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackPositionUpdateListener4685;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4685, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4685, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackPositionUpdateListener4686;
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4686, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4686, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStereoVolume4687;
		public virtual int setStereoVolume(float arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setStereoVolume4687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setStereoVolume4687, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackRate4688;
		public virtual int setPlaybackRate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setPlaybackRate4688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackRate4688, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackHeadPosition4689;
		public virtual int setPlaybackHeadPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setPlaybackHeadPosition4689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackHeadPosition4689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLoopPoints4690;
		public virtual int setLoopPoints(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setLoopPoints4690, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setLoopPoints4690, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _pause4691;
		public virtual void pause() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._pause4691);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._pause4691);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reloadStaticData4692;
		public virtual int reloadStaticData() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._reloadStaticData4692);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._reloadStaticData4692);
		}
		internal static global::net.sf.jni4net.jni.MethodId _AudioTrack4693;
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._AudioTrack4693, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5));
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
			global::android.media.AudioTrack._write4660 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "write", "([BII)I");
			global::android.media.AudioTrack._write4661 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "write", "([SII)I");
			global::android.media.AudioTrack._stop4662 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "stop", "()V");
			global::android.media.AudioTrack._getState4663 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getState", "()I");
			global::android.media.AudioTrack._flush4664 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "flush", "()V");
			global::android.media.AudioTrack._setState4665 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setState", "(I)V");
			global::android.media.AudioTrack._release4666 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "release", "()V");
			global::android.media.AudioTrack._play4667 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "play", "()V");
			global::android.media.AudioTrack._getSampleRate4668 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getSampleRate", "()I");
			global::android.media.AudioTrack._getAudioFormat4669 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I");
			global::android.media.AudioTrack._getChannelConfiguration4670 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I");
			global::android.media.AudioTrack._getChannelCount4671 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getChannelCount", "()I");
			global::android.media.AudioTrack._getNotificationMarkerPosition4672 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I");
			global::android.media.AudioTrack._getPositionNotificationPeriod4673 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I");
			global::android.media.AudioTrack._getMinBufferSize4674 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I");
			global::android.media.AudioTrack._setNotificationMarkerPosition4675 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I");
			global::android.media.AudioTrack._setPositionNotificationPeriod4676 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I");
			global::android.media.AudioTrack._getMinVolume4677 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F");
			global::android.media.AudioTrack._getMaxVolume4678 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F");
			global::android.media.AudioTrack._getPlaybackRate4679 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I");
			global::android.media.AudioTrack._getStreamType4680 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getStreamType", "()I");
			global::android.media.AudioTrack._getPlayState4681 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlayState", "()I");
			global::android.media.AudioTrack._getNativeFrameCount4682 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I");
			global::android.media.AudioTrack._getPlaybackHeadPosition4683 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I");
			global::android.media.AudioTrack._getNativeOutputSampleRate4684 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4685 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V");
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4686 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V");
			global::android.media.AudioTrack._setStereoVolume4687 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I");
			global::android.media.AudioTrack._setPlaybackRate4688 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I");
			global::android.media.AudioTrack._setPlaybackHeadPosition4689 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I");
			global::android.media.AudioTrack._setLoopPoints4690 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I");
			global::android.media.AudioTrack._pause4691 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "pause", "()V");
			global::android.media.AudioTrack._reloadStaticData4692 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I");
			global::android.media.AudioTrack._AudioTrack4693 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V");
		}
	}
}
