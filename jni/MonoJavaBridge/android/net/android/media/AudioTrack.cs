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
			internal static global::net.sf.jni4net.jni.MethodId _onMarkerReached4418; 
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached(android.media.AudioTrack arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.media.AudioTrack.__OnPlaybackPositionUpdateListener)) 
					@__env.CallVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onMarkerReached4418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onMarkerReached4418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onPeriodicNotification4419; 
			 void android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification(android.media.AudioTrack arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.media.AudioTrack.__OnPlaybackPositionUpdateListener)) 
					@__env.CallVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onPeriodicNotification4419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onPeriodicNotification4419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass = @__class; 
				global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onMarkerReached4418 = @__env.GetMethodID(global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, "android.media.AudioTrack.OnPlaybackPositionUpdateListener.onMarkerReached", "(Landroid/media/AudioTrack;)V"); 
				global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener._onPeriodicNotification4419 = @__env.GetMethodID(global::android.media.AudioTrack.__OnPlaybackPositionUpdateListener.staticClass, "android.media.AudioTrack.OnPlaybackPositionUpdateListener.onPeriodicNotification", "(Landroid/media/AudioTrack;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write4420; 
		public virtual int write(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._write4420, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write4420, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _write4421; 
		public virtual int write(short[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._write4421, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._write4421, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4422; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._stop4422); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._stop4422); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState4423; 
		public virtual int getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getState4423); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getState4423); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _flush4424; 
		public virtual void flush() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._flush4424); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._flush4424); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setState4425; 
		protected virtual void setState(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._setState4425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setState4425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4426; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._release4426); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._release4426); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4427; 
		public virtual void play() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._play4427); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._play4427); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSampleRate4428; 
		public virtual int getSampleRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getSampleRate4428); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getSampleRate4428); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioFormat4429; 
		public virtual int getAudioFormat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getAudioFormat4429); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getAudioFormat4429); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelConfiguration4430; 
		public virtual int getChannelConfiguration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getChannelConfiguration4430); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelConfiguration4430); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChannelCount4431; 
		public virtual int getChannelCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getChannelCount4431); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getChannelCount4431); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNotificationMarkerPosition4432; 
		public virtual int getNotificationMarkerPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getNotificationMarkerPosition4432); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNotificationMarkerPosition4432); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPositionNotificationPeriod4433; 
		public virtual int getPositionNotificationPeriod() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPositionNotificationPeriod4433); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPositionNotificationPeriod4433); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinBufferSize4434; 
		public static int getMinBufferSize(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinBufferSize4434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationMarkerPosition4435; 
		public virtual int setNotificationMarkerPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setNotificationMarkerPosition4435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setNotificationMarkerPosition4435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPositionNotificationPeriod4436; 
		public virtual int setPositionNotificationPeriod(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setPositionNotificationPeriod4436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPositionNotificationPeriod4436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinVolume4437; 
		public static float getMinVolume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMinVolume4437); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxVolume4438; 
		public static float getMaxVolume() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticFloatMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getMaxVolume4438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPlaybackRate4439; 
		public virtual int getPlaybackRate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPlaybackRate4439); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackRate4439); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamType4440; 
		public virtual int getStreamType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getStreamType4440); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getStreamType4440); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPlayState4441; 
		public virtual int getPlayState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPlayState4441); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlayState4441); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeFrameCount4442; 
		protected virtual int getNativeFrameCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getNativeFrameCount4442); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeFrameCount4442); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPlaybackHeadPosition4443; 
		public virtual int getPlaybackHeadPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._getPlaybackHeadPosition4443); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getPlaybackHeadPosition4443); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNativeOutputSampleRate4444; 
		public static int getNativeOutputSampleRate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._getNativeOutputSampleRate4444, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackPositionUpdateListener4445; 
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0, android.os.Handler arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4445, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4445, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackPositionUpdateListener4446; 
		public virtual void setPlaybackPositionUpdateListener(android.media.AudioTrack.OnPlaybackPositionUpdateListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4446, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackPositionUpdateListener4446, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStereoVolume4447; 
		public virtual int setStereoVolume(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setStereoVolume4447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setStereoVolume4447, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackRate4448; 
		public virtual int setPlaybackRate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setPlaybackRate4448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackRate4448, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPlaybackHeadPosition4449; 
		public virtual int setPlaybackHeadPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setPlaybackHeadPosition4449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setPlaybackHeadPosition4449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLoopPoints4450; 
		public virtual int setLoopPoints(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._setLoopPoints4450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._setLoopPoints4450, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4451; 
		public virtual void pause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				@__env.CallVoidMethod(this, global::android.media.AudioTrack._pause4451); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._pause4451); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reloadStaticData4452; 
		public virtual int reloadStaticData() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioTrack)) 
				return @__env.CallIntMethod(this, global::android.media.AudioTrack._reloadStaticData4452); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioTrack.staticClass, global::android.media.AudioTrack._reloadStaticData4452); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AudioTrack4453; 
		public AudioTrack(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.AudioTrack.staticClass, global::android.media.AudioTrack._AudioTrack4453, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
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
			global::android.media.AudioTrack._write4420 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "write", "([BII)I"); 
			global::android.media.AudioTrack._write4421 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "write", "([SII)I"); 
			global::android.media.AudioTrack._stop4422 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "stop", "()V"); 
			global::android.media.AudioTrack._getState4423 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getState", "()I"); 
			global::android.media.AudioTrack._flush4424 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "flush", "()V"); 
			global::android.media.AudioTrack._setState4425 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setState", "(I)V"); 
			global::android.media.AudioTrack._release4426 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "release", "()V"); 
			global::android.media.AudioTrack._play4427 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "play", "()V"); 
			global::android.media.AudioTrack._getSampleRate4428 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getSampleRate", "()I"); 
			global::android.media.AudioTrack._getAudioFormat4429 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getAudioFormat", "()I"); 
			global::android.media.AudioTrack._getChannelConfiguration4430 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getChannelConfiguration", "()I"); 
			global::android.media.AudioTrack._getChannelCount4431 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getChannelCount", "()I"); 
			global::android.media.AudioTrack._getNotificationMarkerPosition4432 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getNotificationMarkerPosition", "()I"); 
			global::android.media.AudioTrack._getPositionNotificationPeriod4433 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPositionNotificationPeriod", "()I"); 
			global::android.media.AudioTrack._getMinBufferSize4434 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMinBufferSize", "(III)I"); 
			global::android.media.AudioTrack._setNotificationMarkerPosition4435 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setNotificationMarkerPosition", "(I)I"); 
			global::android.media.AudioTrack._setPositionNotificationPeriod4436 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPositionNotificationPeriod", "(I)I"); 
			global::android.media.AudioTrack._getMinVolume4437 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMinVolume", "()F"); 
			global::android.media.AudioTrack._getMaxVolume4438 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getMaxVolume", "()F"); 
			global::android.media.AudioTrack._getPlaybackRate4439 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlaybackRate", "()I"); 
			global::android.media.AudioTrack._getStreamType4440 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getStreamType", "()I"); 
			global::android.media.AudioTrack._getPlayState4441 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlayState", "()I"); 
			global::android.media.AudioTrack._getNativeFrameCount4442 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getNativeFrameCount", "()I"); 
			global::android.media.AudioTrack._getPlaybackHeadPosition4443 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "getPlaybackHeadPosition", "()I"); 
			global::android.media.AudioTrack._getNativeOutputSampleRate4444 = @__env.GetStaticMethodID(global::android.media.AudioTrack.staticClass, "getNativeOutputSampleRate", "(I)I"); 
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4445 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;Landroid/os/Handler;)V"); 
			global::android.media.AudioTrack._setPlaybackPositionUpdateListener4446 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackPositionUpdateListener", "(Landroid/media/AudioTrack$OnPlaybackPositionUpdateListener;)V"); 
			global::android.media.AudioTrack._setStereoVolume4447 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setStereoVolume", "(FF)I"); 
			global::android.media.AudioTrack._setPlaybackRate4448 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackRate", "(I)I"); 
			global::android.media.AudioTrack._setPlaybackHeadPosition4449 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setPlaybackHeadPosition", "(I)I"); 
			global::android.media.AudioTrack._setLoopPoints4450 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "setLoopPoints", "(III)I"); 
			global::android.media.AudioTrack._pause4451 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "pause", "()V"); 
			global::android.media.AudioTrack._reloadStaticData4452 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "reloadStaticData", "()I"); 
			global::android.media.AudioTrack._AudioTrack4453 = @__env.GetMethodID(global::android.media.AudioTrack.staticClass, "<init>", "(IIIIII)V"); 
		} 
	} 
} 
