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
			internal static global::net.sf.jni4net.jni.MethodId _onError4788;
			 void android.media.MediaRecorder.OnErrorListener.onError(android.media.MediaRecorder arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaRecorder.__OnErrorListener._onError4788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.__OnErrorListener.staticClass, global::android.media.MediaRecorder.__OnErrorListener._onError4788, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaRecorder.__OnErrorListener.staticClass = @__class;
				global::android.media.MediaRecorder.__OnErrorListener._onError4788 = @__env.GetMethodID(global::android.media.MediaRecorder.__OnErrorListener.staticClass, "android.media.MediaRecorder.OnErrorListener.onError", "(Landroid/media/MediaRecorder;II)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onInfo4789;
			 void android.media.MediaRecorder.OnInfoListener.onInfo(android.media.MediaRecorder arg0, int arg1, int arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.MediaRecorder.__OnInfoListener._onInfo4789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.__OnInfoListener.staticClass, global::android.media.MediaRecorder.__OnInfoListener._onInfo4789, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.MediaRecorder.__OnInfoListener.staticClass = @__class;
				global::android.media.MediaRecorder.__OnInfoListener._onInfo4789 = @__env.GetMethodID(global::android.media.MediaRecorder.__OnInfoListener.staticClass, "android.media.MediaRecorder.OnInfoListener.onInfo", "(Landroid/media/MediaRecorder;II)V");
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
		internal static global::net.sf.jni4net.jni.MethodId _start4790;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._start4790);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._start4790);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop4791;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._stop4791);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._stop4791);
		}
		internal static global::net.sf.jni4net.jni.MethodId _reset4792;
		public virtual void reset() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._reset4792);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._reset4792);
		}
		internal static global::net.sf.jni4net.jni.MethodId _release4793;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._release4793);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._release4793);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFormat4794;
		public virtual void setOutputFormat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOutputFormat4794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFormat4794, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _prepare4795;
		public virtual void prepare() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._prepare4795);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._prepare4795);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewDisplay4796;
		public virtual void setPreviewDisplay(android.view.Surface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setPreviewDisplay4796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setPreviewDisplay4796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnErrorListener4797;
		public virtual void setOnErrorListener(android.media.MediaRecorder.OnErrorListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOnErrorListener4797, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnErrorListener4797, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnInfoListener4798;
		public virtual void setOnInfoListener(android.media.MediaRecorder.OnInfoListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOnInfoListener4798, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnInfoListener4798, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCamera4799;
		public virtual void setCamera(android.hardware.Camera arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setCamera4799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setCamera4799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAudioSource4800;
		public virtual void setAudioSource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioSource4800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSource4800, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getAudioSourceMax4801;
		public static int getAudioSourceMax() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getAudioSourceMax4801);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoSource4802;
		public virtual void setVideoSource(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoSource4802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSource4802, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setProfile4803;
		public virtual void setProfile(android.media.CamcorderProfile arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setProfile4803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setProfile4803, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoSize4804;
		public virtual void setVideoSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoSize4804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSize4804, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoFrameRate4805;
		public virtual void setVideoFrameRate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoFrameRate4805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoFrameRate4805, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxDuration4806;
		public virtual void setMaxDuration(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setMaxDuration4806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxDuration4806, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaxFileSize4807;
		public virtual void setMaxFileSize(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setMaxFileSize4807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxFileSize4807, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAudioEncoder4808;
		public virtual void setAudioEncoder(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioEncoder4808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncoder4808, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoEncoder4809;
		public virtual void setVideoEncoder(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoEncoder4809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncoder4809, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAudioSamplingRate4810;
		public virtual void setAudioSamplingRate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioSamplingRate4810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSamplingRate4810, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAudioChannels4811;
		public virtual void setAudioChannels(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioChannels4811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioChannels4811, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAudioEncodingBitRate4812;
		public virtual void setAudioEncodingBitRate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setAudioEncodingBitRate4812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncodingBitRate4812, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVideoEncodingBitRate4813;
		public virtual void setVideoEncodingBitRate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setVideoEncodingBitRate4813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncodingBitRate4813, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFile4814;
		public virtual void setOutputFile(java.io.FileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOutputFile4814, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile4814, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOutputFile4815;
		public virtual void setOutputFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.MediaRecorder._setOutputFile4815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile4815, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaxAmplitude4816;
		public virtual int getMaxAmplitude() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.MediaRecorder._getMaxAmplitude4816);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getMaxAmplitude4816);
		}
		internal static global::net.sf.jni4net.jni.MethodId _MediaRecorder4817;
		public MediaRecorder()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._MediaRecorder4817, this);
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
			global::android.media.MediaRecorder._start4790 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "start", "()V");
			global::android.media.MediaRecorder._stop4791 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "stop", "()V");
			global::android.media.MediaRecorder._reset4792 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "reset", "()V");
			global::android.media.MediaRecorder._release4793 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "release", "()V");
			global::android.media.MediaRecorder._setOutputFormat4794 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFormat", "(I)V");
			global::android.media.MediaRecorder._prepare4795 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "prepare", "()V");
			global::android.media.MediaRecorder._setPreviewDisplay4796 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setPreviewDisplay", "(Landroid/view/Surface;)V");
			global::android.media.MediaRecorder._setOnErrorListener4797 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V");
			global::android.media.MediaRecorder._setOnInfoListener4798 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V");
			global::android.media.MediaRecorder._setCamera4799 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setCamera", "(Landroid/hardware/Camera;)V");
			global::android.media.MediaRecorder._setAudioSource4800 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioSource", "(I)V");
			global::android.media.MediaRecorder._getAudioSourceMax4801 = @__env.GetStaticMethodID(global::android.media.MediaRecorder.staticClass, "getAudioSourceMax", "()I");
			global::android.media.MediaRecorder._setVideoSource4802 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoSource", "(I)V");
			global::android.media.MediaRecorder._setProfile4803 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setProfile", "(Landroid/media/CamcorderProfile;)V");
			global::android.media.MediaRecorder._setVideoSize4804 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoSize", "(II)V");
			global::android.media.MediaRecorder._setVideoFrameRate4805 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoFrameRate", "(I)V");
			global::android.media.MediaRecorder._setMaxDuration4806 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setMaxDuration", "(I)V");
			global::android.media.MediaRecorder._setMaxFileSize4807 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setMaxFileSize", "(J)V");
			global::android.media.MediaRecorder._setAudioEncoder4808 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioEncoder", "(I)V");
			global::android.media.MediaRecorder._setVideoEncoder4809 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoEncoder", "(I)V");
			global::android.media.MediaRecorder._setAudioSamplingRate4810 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioSamplingRate", "(I)V");
			global::android.media.MediaRecorder._setAudioChannels4811 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioChannels", "(I)V");
			global::android.media.MediaRecorder._setAudioEncodingBitRate4812 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setAudioEncodingBitRate", "(I)V");
			global::android.media.MediaRecorder._setVideoEncodingBitRate4813 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setVideoEncodingBitRate", "(I)V");
			global::android.media.MediaRecorder._setOutputFile4814 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaRecorder._setOutputFile4815 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/lang/String;)V");
			global::android.media.MediaRecorder._getMaxAmplitude4816 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "getMaxAmplitude", "()I");
			global::android.media.MediaRecorder._MediaRecorder4817 = @__env.GetMethodID(global::android.media.MediaRecorder.staticClass, "<init>", "()V");
		}
	}
}
