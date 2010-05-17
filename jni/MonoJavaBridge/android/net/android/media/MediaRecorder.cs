namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MediaRecorder : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MediaRecorder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaRecorder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.MediaRecorder(@__env); 
			} 
		} 
		protected MediaRecorder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class AudioEncoder : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static AudioEncoder() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaRecorder.AudioEncoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.AudioEncoder(@__env); 
				} 
			} 
			internal AudioEncoder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			public static int DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int AMR_NB
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.AudioEncoder.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class AudioSource : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static AudioSource() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaRecorder.AudioSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.AudioSource(@__env); 
				} 
			} 
			internal AudioSource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			public static int DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int MIC
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int VOICE_UPLINK
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int VOICE_DOWNLINK
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			public static int VOICE_CALL
			{ 
				get 
				{ 
					return 4; 
				} 
			} 
			public static int CAMCORDER
			{ 
				get 
				{ 
					return 5; 
				} 
			} 
			public static int VOICE_RECOGNITION
			{ 
				get 
				{ 
					return 6; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.AudioSource.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnErrorListener 
		{ 
			void onError(android.media.MediaRecorder arg0, int arg1, int arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnInfoListener 
		{ 
			void onInfo(android.media.MediaRecorder arg0, int arg1, int arg2); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class OutputFormat : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static OutputFormat() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaRecorder.OutputFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.OutputFormat(@__env); 
				} 
			} 
			internal OutputFormat(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			public static int DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int THREE_GPP
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int MPEG_4
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int RAW_AMR
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.OutputFormat.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class VideoEncoder : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static VideoEncoder() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaRecorder.VideoEncoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.VideoEncoder(@__env); 
				} 
			} 
			internal VideoEncoder(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			public static int DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int H263
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			public static int H264
			{ 
				get 
				{ 
					return 2; 
				} 
			} 
			public static int MPEG_4_SP
			{ 
				get 
				{ 
					return 3; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.VideoEncoder.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class VideoSource : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static VideoSource() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.MediaRecorder.VideoSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.VideoSource(@__env); 
				} 
			} 
			internal VideoSource(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			public static int DEFAULT
			{ 
				get 
				{ 
					return 0; 
				} 
			} 
			public static int CAMERA
			{ 
				get 
				{ 
					return 1; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.VideoSource.staticClass = @__class; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start4288; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _start4288); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _start4288); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4289; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _stop4289); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _stop4289); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset4290; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _reset4290); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _reset4290); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4291; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _release4291); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _release4291); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFormat4292; 
		public virtual void setOutputFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setOutputFormat4292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setOutputFormat4292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepare4293; 
		public virtual void prepare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _prepare4293); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _prepare4293); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewDisplay4294; 
		public virtual void setPreviewDisplay(android.view.Surface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setPreviewDisplay4294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setPreviewDisplay4294, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener4295; 
		public virtual void setOnErrorListener(android.media.MediaRecorder.OnErrorListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setOnErrorListener4295, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setOnErrorListener4295, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnInfoListener4296; 
		public virtual void setOnInfoListener(android.media.MediaRecorder.OnInfoListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setOnInfoListener4296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setOnInfoListener4296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCamera4297; 
		public virtual void setCamera(android.hardware.Camera arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setCamera4297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setCamera4297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAudioSource4298; 
		public virtual void setAudioSource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setAudioSource4298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setAudioSource4298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioSourceMax4299; 
		public static int getAudioSourceMax() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.MediaRecorder.staticClass, _getAudioSourceMax4299); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoSource4300; 
		public virtual void setVideoSource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setVideoSource4300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setVideoSource4300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoSize4301; 
		public virtual void setVideoSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setVideoSize4301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setVideoSize4301, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoFrameRate4302; 
		public virtual void setVideoFrameRate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setVideoFrameRate4302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setVideoFrameRate4302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxDuration4303; 
		public virtual void setMaxDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setMaxDuration4303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setMaxDuration4303, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxFileSize4304; 
		public virtual void setMaxFileSize(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setMaxFileSize4304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setMaxFileSize4304, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAudioEncoder4305; 
		public virtual void setAudioEncoder(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setAudioEncoder4305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setAudioEncoder4305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoEncoder4306; 
		public virtual void setVideoEncoder(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setVideoEncoder4306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setVideoEncoder4306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFile4307; 
		public virtual void setOutputFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setOutputFile4307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setOutputFile4307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFile4308; 
		public virtual void setOutputFile(java.io.FileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, _setOutputFile4308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.MediaRecorder.staticClass, _setOutputFile4308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAmplitude4309; 
		public virtual int getMaxAmplitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				return @__env.CallIntMethod(this, _getMaxAmplitude4309); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.MediaRecorder.staticClass, _getMaxAmplitude4309); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaRecorder4310; 
		public MediaRecorder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.MediaRecorder.staticClass, _MediaRecorder4310, this); 
		} 
		public static int MEDIA_RECORDER_ERROR_UNKNOWN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int MEDIA_RECORDER_INFO_UNKNOWN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int MEDIA_RECORDER_INFO_MAX_DURATION_REACHED
		{ 
			get 
			{ 
				return 800; 
			} 
		} 
		public static int MEDIA_RECORDER_INFO_MAX_FILESIZE_REACHED
		{ 
			get 
			{ 
				return 801; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.MediaRecorder.staticClass = @__class; 
			global::android.media.MediaRecorder._start4288 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "start", "()V"); 
			global::android.media.MediaRecorder._stop4289 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "stop", "()V"); 
			global::android.media.MediaRecorder._reset4290 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "reset", "()V"); 
			global::android.media.MediaRecorder._release4291 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "release", "()V"); 
			global::android.media.MediaRecorder._setOutputFormat4292 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFormat", "(I)V"); 
			global::android.media.MediaRecorder._prepare4293 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "prepare", "()V"); 
			global::android.media.MediaRecorder._setPreviewDisplay4294 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setPreviewDisplay", "(Landroid/view/Surface;)V"); 
			global::android.media.MediaRecorder._setOnErrorListener4295 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V"); 
			global::android.media.MediaRecorder._setOnInfoListener4296 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V"); 
			global::android.media.MediaRecorder._setCamera4297 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setCamera", "(Landroid/hardware/Camera;)V"); 
			global::android.media.MediaRecorder._setAudioSource4298 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioSource", "(I)V"); 
			global::android.media.MediaRecorder._getAudioSourceMax4299 = @__env.GetStaticMethodID(global::android.media.MediaRecorder.staticClass, "getAudioSourceMax", "()I"); 
			global::android.media.MediaRecorder._setVideoSource4300 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoSource", "(I)V"); 
			global::android.media.MediaRecorder._setVideoSize4301 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoSize", "(II)V"); 
			global::android.media.MediaRecorder._setVideoFrameRate4302 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoFrameRate", "(I)V"); 
			global::android.media.MediaRecorder._setMaxDuration4303 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setMaxDuration", "(I)V"); 
			global::android.media.MediaRecorder._setMaxFileSize4304 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setMaxFileSize", "(J)V"); 
			global::android.media.MediaRecorder._setAudioEncoder4305 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioEncoder", "(I)V"); 
			global::android.media.MediaRecorder._setVideoEncoder4306 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoEncoder", "(I)V"); 
			global::android.media.MediaRecorder._setOutputFile4307 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/lang/String;)V"); 
			global::android.media.MediaRecorder._setOutputFile4308 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/io/FileDescriptor;)V"); 
			global::android.media.MediaRecorder._getMaxAmplitude4309 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "getMaxAmplitude", "()I"); 
			global::android.media.MediaRecorder._MediaRecorder4310 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "<init>", "()V"); 
		} 
	} 
} 
