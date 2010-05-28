namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MediaRecorder : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static MediaRecorder() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.AudioEncoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.AudioSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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

		public partial class OnErrorListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnErrorListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnErrorListener : java.lang.Object, OnErrorListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnErrorListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.__OnErrorListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.__OnErrorListener(@__env); 
				} 
			} 
			internal __OnErrorListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onError4532; 
			 void android.media.MediaRecorder.OnErrorListener.onError(android.media.MediaRecorder arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.media.MediaRecorder.__OnErrorListener)) 
					@__env.CallVoidMethod(this, global::android.media.MediaRecorder.__OnErrorListener._onError4532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.__OnErrorListener.staticClass, global::android.media.MediaRecorder.__OnErrorListener._onError4532, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.__OnErrorListener.staticClass = @__class; 
				global::android.media.MediaRecorder.__OnErrorListener._onError4532 = @__env.GetMethodID(global::android.media.MediaRecorder.__OnErrorListener.staticClass, "android.media.MediaRecorder.OnErrorListener.onError", "(Landroid/media/MediaRecorder;II)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnInfoListener 
		{ 
			void onInfo(android.media.MediaRecorder arg0, int arg1, int arg2); 
		} 

		public partial class OnInfoListener_ 
		{ 
			public static global::java.lang.Class _class 
			{ 
				get { return __OnInfoListener.staticClass; } 
			} 
		} 

		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class __OnInfoListener : java.lang.Object, OnInfoListener
		{ 
			internal static global::java.lang.Class staticClass; 
			static __OnInfoListener() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.__OnInfoListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.media.MediaRecorder.__OnInfoListener(@__env); 
				} 
			} 
			internal __OnInfoListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onInfo4533; 
			 void android.media.MediaRecorder.OnInfoListener.onInfo(android.media.MediaRecorder arg0, int arg1, int arg2) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.media.MediaRecorder.__OnInfoListener)) 
					@__env.CallVoidMethod(this, global::android.media.MediaRecorder.__OnInfoListener._onInfo4533, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.__OnInfoListener.staticClass, global::android.media.MediaRecorder.__OnInfoListener._onInfo4533, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.media.MediaRecorder.__OnInfoListener.staticClass = @__class; 
				global::android.media.MediaRecorder.__OnInfoListener._onInfo4533 = @__env.GetMethodID(global::android.media.MediaRecorder.__OnInfoListener.staticClass, "android.media.MediaRecorder.OnInfoListener.onInfo", "(Landroid/media/MediaRecorder;II)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class OutputFormat : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static OutputFormat() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.OutputFormat), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.VideoEncoder), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.MediaRecorder.VideoSource), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _start4534; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._start4534); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._start4534); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4535; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._stop4535); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._stop4535); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset4536; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._reset4536); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._reset4536); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release4537; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._release4537); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._release4537); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFormat4538; 
		public virtual void setOutputFormat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOutputFormat4538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFormat4538, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _prepare4539; 
		public virtual void prepare() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._prepare4539); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._prepare4539); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewDisplay4540; 
		public virtual void setPreviewDisplay(android.view.Surface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setPreviewDisplay4540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setPreviewDisplay4540, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener4541; 
		public virtual void setOnErrorListener(android.media.MediaRecorder.OnErrorListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOnErrorListener4541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnErrorListener4541, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnInfoListener4542; 
		public virtual void setOnInfoListener(android.media.MediaRecorder.OnInfoListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOnInfoListener4542, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnInfoListener4542, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCamera4543; 
		public virtual void setCamera(android.hardware.Camera arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setCamera4543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setCamera4543, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAudioSource4544; 
		public virtual void setAudioSource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioSource4544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSource4544, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAudioSourceMax4545; 
		public static int getAudioSourceMax() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getAudioSourceMax4545); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoSource4546; 
		public virtual void setVideoSource(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoSource4546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSource4546, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoSize4547; 
		public virtual void setVideoSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoSize4547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSize4547, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoFrameRate4548; 
		public virtual void setVideoFrameRate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoFrameRate4548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoFrameRate4548, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxDuration4549; 
		public virtual void setMaxDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setMaxDuration4549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxDuration4549, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMaxFileSize4550; 
		public virtual void setMaxFileSize(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setMaxFileSize4550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxFileSize4550, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAudioEncoder4551; 
		public virtual void setAudioEncoder(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioEncoder4551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncoder4551, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVideoEncoder4552; 
		public virtual void setVideoEncoder(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoEncoder4552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncoder4552, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFile4553; 
		public virtual void setOutputFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOutputFile4553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile4553, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFile4554; 
		public virtual void setOutputFile(java.io.FileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOutputFile4554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile4554, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAmplitude4555; 
		public virtual int getMaxAmplitude() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.MediaRecorder)) 
				return @__env.CallIntMethod(this, global::android.media.MediaRecorder._getMaxAmplitude4555); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getMaxAmplitude4555); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MediaRecorder4556; 
		public MediaRecorder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._MediaRecorder4556, this); 
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
			global::android.media.MediaRecorder._start4534 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "start", "()V"); 
			global::android.media.MediaRecorder._stop4535 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "stop", "()V"); 
			global::android.media.MediaRecorder._reset4536 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "reset", "()V"); 
			global::android.media.MediaRecorder._release4537 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "release", "()V"); 
			global::android.media.MediaRecorder._setOutputFormat4538 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFormat", "(I)V"); 
			global::android.media.MediaRecorder._prepare4539 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "prepare", "()V"); 
			global::android.media.MediaRecorder._setPreviewDisplay4540 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setPreviewDisplay", "(Landroid/view/Surface;)V"); 
			global::android.media.MediaRecorder._setOnErrorListener4541 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V"); 
			global::android.media.MediaRecorder._setOnInfoListener4542 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V"); 
			global::android.media.MediaRecorder._setCamera4543 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setCamera", "(Landroid/hardware/Camera;)V"); 
			global::android.media.MediaRecorder._setAudioSource4544 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioSource", "(I)V"); 
			global::android.media.MediaRecorder._getAudioSourceMax4545 = @__env.GetStaticMethodID(global::android.media.MediaRecorder.staticClass, "getAudioSourceMax", "()I"); 
			global::android.media.MediaRecorder._setVideoSource4546 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoSource", "(I)V"); 
			global::android.media.MediaRecorder._setVideoSize4547 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoSize", "(II)V"); 
			global::android.media.MediaRecorder._setVideoFrameRate4548 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoFrameRate", "(I)V"); 
			global::android.media.MediaRecorder._setMaxDuration4549 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setMaxDuration", "(I)V"); 
			global::android.media.MediaRecorder._setMaxFileSize4550 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setMaxFileSize", "(J)V"); 
			global::android.media.MediaRecorder._setAudioEncoder4551 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioEncoder", "(I)V"); 
			global::android.media.MediaRecorder._setVideoEncoder4552 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoEncoder", "(I)V"); 
			global::android.media.MediaRecorder._setOutputFile4553 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/lang/String;)V"); 
			global::android.media.MediaRecorder._setOutputFile4554 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/io/FileDescriptor;)V"); 
			global::android.media.MediaRecorder._getMaxAmplitude4555 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "getMaxAmplitude", "()I"); 
			global::android.media.MediaRecorder._MediaRecorder4556 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "<init>", "()V"); 
		} 
	} 
} 
