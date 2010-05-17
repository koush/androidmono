namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MediaPlayer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MediaPlayer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaPlayer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.MediaPlayer(@__env); 
			} 
		} 
		protected MediaPlayer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnBufferingUpdateListener 
		{ 
			void onBufferingUpdate(android.media.MediaPlayer arg0, int arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnCompletionListener 
		{ 
			void onCompletion(android.media.MediaPlayer arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnErrorListener 
		{ 
			bool onError(android.media.MediaPlayer arg0, int arg1, int arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnInfoListener 
		{ 
			bool onInfo(android.media.MediaPlayer arg0, int arg1, int arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnPreparedListener 
		{ 
			void onPrepared(android.media.MediaPlayer arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnSeekCompleteListener 
		{ 
			void onSeekComplete(android.media.MediaPlayer arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnVideoSizeChangedListener 
		{ 
			void onVideoSizeChanged(android.media.MediaPlayer arg0, int arg1, int arg2); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start4253; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _start4253); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _start4253); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4254; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _stop4254); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _stop4254); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset4255; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _reset4255); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _reset4255); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4256; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _release4256); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _release4256); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create4257; 
		public static android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1, android.view.SurfaceHolder arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.MediaPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.MediaPlayer.staticClass, _create4257, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create4258; 
		public static android.media.MediaPlayer create(android.content.Context arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.MediaPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.MediaPlayer.staticClass, _create4258, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create4259; 
		public static android.media.MediaPlayer create(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.media.MediaPlayer>(@__env, @__env.CallStaticObjectMethodPtr(android.media.MediaPlayer.staticClass, _create4259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepare4260; 
		public virtual void prepare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _prepare4260); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _prepare4260); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration4261; 
		public virtual int getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				return @__env.CallIntMethod(this, _getDuration4261); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.MediaPlayer.staticClass, _getDuration4261); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _pause4262; 
		public virtual void pause() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _pause4262); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _pause4262); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDisplay4263; 
		public virtual void setDisplay(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setDisplay4263, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setDisplay4263, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4264; 
		public virtual void setDataSource(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setDataSource4264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setDataSource4264, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4265; 
		public virtual void setDataSource(java.io.FileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setDataSource4265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setDataSource4265, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4266; 
		public virtual void setDataSource(java.io.FileDescriptor arg0, long arg1, long arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setDataSource4266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setDataSource4266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataSource4267; 
		public virtual void setDataSource(android.content.Context arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setDataSource4267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setDataSource4267, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepareAsync4268; 
		public virtual void prepareAsync() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _prepareAsync4268); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _prepareAsync4268); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWakeMode4269; 
		public virtual void setWakeMode(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setWakeMode4269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setWakeMode4269, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setScreenOnWhilePlaying4270; 
		public virtual void setScreenOnWhilePlaying(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setScreenOnWhilePlaying4270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setScreenOnWhilePlaying4270, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVideoWidth4271; 
		public virtual int getVideoWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				return @__env.CallIntMethod(this, _getVideoWidth4271); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.MediaPlayer.staticClass, _getVideoWidth4271); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVideoHeight4272; 
		public virtual int getVideoHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				return @__env.CallIntMethod(this, _getVideoHeight4272); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.MediaPlayer.staticClass, _getVideoHeight4272); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying4273; 
		public virtual bool isPlaying() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				return @__env.CallBooleanMethod(this, _isPlaying4273); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.MediaPlayer.staticClass, _isPlaying4273); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _seekTo4274; 
		public virtual void seekTo(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _seekTo4274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _seekTo4274, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrentPosition4275; 
		public virtual int getCurrentPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				return @__env.CallIntMethod(this, _getCurrentPosition4275); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.MediaPlayer.staticClass, _getCurrentPosition4275); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAudioStreamType4276; 
		public virtual void setAudioStreamType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setAudioStreamType4276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setAudioStreamType4276, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLooping4277; 
		public virtual void setLooping(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setLooping4277, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setLooping4277, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLooping4278; 
		public virtual bool isLooping() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				return @__env.CallBooleanMethod(this, _isLooping4278); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.MediaPlayer.staticClass, _isLooping4278); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVolume4279; 
		public virtual void setVolume(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setVolume4279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setVolume4279, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnPreparedListener4280; 
		public virtual void setOnPreparedListener(android.media.MediaPlayer.OnPreparedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnPreparedListener4280, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnPreparedListener4280, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnCompletionListener4281; 
		public virtual void setOnCompletionListener(android.media.MediaPlayer.OnCompletionListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnCompletionListener4281, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnCompletionListener4281, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnBufferingUpdateListener4282; 
		public virtual void setOnBufferingUpdateListener(android.media.MediaPlayer.OnBufferingUpdateListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnBufferingUpdateListener4282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnBufferingUpdateListener4282, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnSeekCompleteListener4283; 
		public virtual void setOnSeekCompleteListener(android.media.MediaPlayer.OnSeekCompleteListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnSeekCompleteListener4283, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnSeekCompleteListener4283, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnVideoSizeChangedListener4284; 
		public virtual void setOnVideoSizeChangedListener(android.media.MediaPlayer.OnVideoSizeChangedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnVideoSizeChangedListener4284, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnVideoSizeChangedListener4284, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener4285; 
		public virtual void setOnErrorListener(android.media.MediaPlayer.OnErrorListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnErrorListener4285, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnErrorListener4285, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnInfoListener4286; 
		public virtual void setOnInfoListener(android.media.MediaPlayer.OnInfoListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaPlayer)) 
				@__env.CallVoidMethod(this, _setOnInfoListener4286, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaPlayer.staticClass, _setOnInfoListener4286, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaPlayer4287; 
		public MediaPlayer()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.MediaPlayer.staticClass, _MediaPlayer4287, this); 
		} 
		public static int MEDIA_ERROR_UNKNOWN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int MEDIA_ERROR_SERVER_DIED
		{ 
			get 
			{ 
				return 100; 
			} 
		} 
		public static int MEDIA_ERROR_NOT_VALID_FOR_PROGRESSIVE_PLAYBACK
		{ 
			get 
			{ 
				return 200; 
			} 
		} 
		public static int MEDIA_INFO_UNKNOWN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int MEDIA_INFO_VIDEO_TRACK_LAGGING
		{ 
			get 
			{ 
				return 700; 
			} 
		} 
		public static int MEDIA_INFO_BAD_INTERLEAVING
		{ 
			get 
			{ 
				return 800; 
			} 
		} 
		public static int MEDIA_INFO_NOT_SEEKABLE
		{ 
			get 
			{ 
				return 801; 
			} 
		} 
		public static int MEDIA_INFO_METADATA_UPDATE
		{ 
			get 
			{ 
				return 802; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.MediaPlayer.staticClass = @__class; 
			global::android.media.MediaPlayer._start4253 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "start", "()V"); 
			global::android.media.MediaPlayer._stop4254 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "stop", "()V"); 
			global::android.media.MediaPlayer._reset4255 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "reset", "()V"); 
			global::android.media.MediaPlayer._release4256 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "release", "()V"); 
			global::android.media.MediaPlayer._create4257 = @__env.GetStaticMethodID(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;Landroid/view/SurfaceHolder;)Landroid/media/MediaPlayer;"); 
			global::android.media.MediaPlayer._create4258 = @__env.GetStaticMethodID(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;Landroid/net/Uri;)Landroid/media/MediaPlayer;"); 
			global::android.media.MediaPlayer._create4259 = @__env.GetStaticMethodID(global::android.media.MediaPlayer.staticClass, "create", "(Landroid/content/Context;I)Landroid/media/MediaPlayer;"); 
			global::android.media.MediaPlayer._prepare4260 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "prepare", "()V"); 
			global::android.media.MediaPlayer._getDuration4261 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getDuration", "()I"); 
			global::android.media.MediaPlayer._pause4262 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "pause", "()V"); 
			global::android.media.MediaPlayer._setDisplay4263 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDisplay", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.media.MediaPlayer._setDataSource4264 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/lang/String;)V"); 
			global::android.media.MediaPlayer._setDataSource4265 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;)V"); 
			global::android.media.MediaPlayer._setDataSource4266 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Ljava/io/FileDescriptor;JJ)V"); 
			global::android.media.MediaPlayer._setDataSource4267 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setDataSource", "(Landroid/content/Context;Landroid/net/Uri;)V"); 
			global::android.media.MediaPlayer._prepareAsync4268 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "prepareAsync", "()V"); 
			global::android.media.MediaPlayer._setWakeMode4269 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setWakeMode", "(Landroid/content/Context;I)V"); 
			global::android.media.MediaPlayer._setScreenOnWhilePlaying4270 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setScreenOnWhilePlaying", "(Z)V"); 
			global::android.media.MediaPlayer._getVideoWidth4271 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getVideoWidth", "()I"); 
			global::android.media.MediaPlayer._getVideoHeight4272 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getVideoHeight", "()I"); 
			global::android.media.MediaPlayer._isPlaying4273 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "isPlaying", "()Z"); 
			global::android.media.MediaPlayer._seekTo4274 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "seekTo", "(I)V"); 
			global::android.media.MediaPlayer._getCurrentPosition4275 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "getCurrentPosition", "()I"); 
			global::android.media.MediaPlayer._setAudioStreamType4276 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setAudioStreamType", "(I)V"); 
			global::android.media.MediaPlayer._setLooping4277 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setLooping", "(Z)V"); 
			global::android.media.MediaPlayer._isLooping4278 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "isLooping", "()Z"); 
			global::android.media.MediaPlayer._setVolume4279 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setVolume", "(FF)V"); 
			global::android.media.MediaPlayer._setOnPreparedListener4280 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnPreparedListener", "(Landroid/media/MediaPlayer$OnPreparedListener;)V"); 
			global::android.media.MediaPlayer._setOnCompletionListener4281 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnCompletionListener", "(Landroid/media/MediaPlayer$OnCompletionListener;)V"); 
			global::android.media.MediaPlayer._setOnBufferingUpdateListener4282 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnBufferingUpdateListener", "(Landroid/media/MediaPlayer$OnBufferingUpdateListener;)V"); 
			global::android.media.MediaPlayer._setOnSeekCompleteListener4283 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnSeekCompleteListener", "(Landroid/media/MediaPlayer$OnSeekCompleteListener;)V"); 
			global::android.media.MediaPlayer._setOnVideoSizeChangedListener4284 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnVideoSizeChangedListener", "(Landroid/media/MediaPlayer$OnVideoSizeChangedListener;)V"); 
			global::android.media.MediaPlayer._setOnErrorListener4285 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnErrorListener", "(Landroid/media/MediaPlayer$OnErrorListener;)V"); 
			global::android.media.MediaPlayer._setOnInfoListener4286 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "setOnInfoListener", "(Landroid/media/MediaPlayer$OnInfoListener;)V"); 
			global::android.media.MediaPlayer._MediaPlayer4287 = @__env.GetMethodID(global::android.media.MediaPlayer.staticClass, "<init>", "()V"); 
		} 
	} 
} 
