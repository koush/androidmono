namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaRecorder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static MediaRecorder()
		{
			InitJNI();
		}
		protected MediaRecorder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AudioEncoder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AudioEncoder()
			{
				InitJNI();
			}
			internal AudioEncoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.AudioEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$AudioEncoder"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AudioSource : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AudioSource()
			{
				InitJNI();
			}
			internal AudioSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.AudioSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$AudioSource"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaRecorder.OnErrorListener_))]
		public interface OnErrorListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onError(android.media.MediaRecorder arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaRecorder.OnErrorListener))]
		public sealed partial class OnErrorListener_ : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnErrorListener_()
			{
				InitJNI();
			}
			internal OnErrorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onError5024;
			 void android.media.MediaRecorder.OnErrorListener.onError(android.media.MediaRecorder arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.OnErrorListener_._onError5024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.OnErrorListener_.staticClass, global::android.media.MediaRecorder.OnErrorListener_._onError5024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OnErrorListener"));
				global::android.media.MediaRecorder.OnErrorListener_._onError5024 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaRecorder;II)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaRecorder.OnInfoListener_))]
		public interface OnInfoListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInfo(android.media.MediaRecorder arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaRecorder.OnInfoListener))]
		public sealed partial class OnInfoListener_ : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnInfoListener_()
			{
				InitJNI();
			}
			internal OnInfoListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onInfo5025;
			 void android.media.MediaRecorder.OnInfoListener.onInfo(android.media.MediaRecorder arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.OnInfoListener_._onInfo5025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.OnInfoListener_.staticClass, global::android.media.MediaRecorder.OnInfoListener_._onInfo5025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OnInfoListener"));
				global::android.media.MediaRecorder.OnInfoListener_._onInfo5025 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaRecorder;II)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class OutputFormat : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OutputFormat()
			{
				InitJNI();
			}
			internal OutputFormat(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OutputFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OutputFormat"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class VideoEncoder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static VideoEncoder()
			{
				InitJNI();
			}
			internal VideoEncoder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.VideoEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$VideoEncoder"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class VideoSource : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static VideoSource()
			{
				InitJNI();
			}
			internal VideoSource(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.VideoSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$VideoSource"));
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize5026;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._finalize5026);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._finalize5026);
		}
		internal static global::MonoJavaBridge.MethodId _start5027;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._start5027);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._start5027);
		}
		internal static global::MonoJavaBridge.MethodId _stop5028;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._stop5028);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._stop5028);
		}
		internal static global::MonoJavaBridge.MethodId _reset5029;
		public virtual void reset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._reset5029);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._reset5029);
		}
		internal static global::MonoJavaBridge.MethodId _release5030;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._release5030);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._release5030);
		}
		internal static global::MonoJavaBridge.MethodId _setOutputFormat5031;
		public virtual void setOutputFormat(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setOutputFormat5031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFormat5031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _prepare5032;
		public virtual void prepare() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._prepare5032);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._prepare5032);
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewDisplay5033;
		public virtual void setPreviewDisplay(android.view.Surface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setPreviewDisplay5033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setPreviewDisplay5033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener5034;
		public virtual void setOnErrorListener(android.media.MediaRecorder.OnErrorListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setOnErrorListener5034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnErrorListener5034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnInfoListener5035;
		public virtual void setOnInfoListener(android.media.MediaRecorder.OnInfoListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setOnInfoListener5035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnInfoListener5035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCamera5036;
		public virtual void setCamera(android.hardware.Camera arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setCamera5036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setCamera5036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioSource5037;
		public virtual void setAudioSource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setAudioSource5037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSource5037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int AudioSourceMax
		{
			get
			{
				return getAudioSourceMax();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioSourceMax5038;
		public static int getAudioSourceMax() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getAudioSourceMax5038);
		}
		internal static global::MonoJavaBridge.MethodId _setVideoSource5039;
		public virtual void setVideoSource(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setVideoSource5039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSource5039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setProfile5040;
		public virtual void setProfile(android.media.CamcorderProfile arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setProfile5040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setProfile5040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoSize5041;
		public virtual void setVideoSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setVideoSize5041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSize5041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoFrameRate5042;
		public virtual void setVideoFrameRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setVideoFrameRate5042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoFrameRate5042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxDuration5043;
		public virtual void setMaxDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setMaxDuration5043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxDuration5043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFileSize5044;
		public virtual void setMaxFileSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setMaxFileSize5044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxFileSize5044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioEncoder5045;
		public virtual void setAudioEncoder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setAudioEncoder5045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncoder5045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoEncoder5046;
		public virtual void setVideoEncoder(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setVideoEncoder5046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncoder5046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioSamplingRate5047;
		public virtual void setAudioSamplingRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setAudioSamplingRate5047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSamplingRate5047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioChannels5048;
		public virtual void setAudioChannels(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setAudioChannels5048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioChannels5048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioEncodingBitRate5049;
		public virtual void setAudioEncodingBitRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setAudioEncodingBitRate5049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncodingBitRate5049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoEncodingBitRate5050;
		public virtual void setVideoEncodingBitRate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setVideoEncodingBitRate5050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncodingBitRate5050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputFile5051;
		public virtual void setOutputFile(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setOutputFile5051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile5051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputFile5052;
		public virtual void setOutputFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder._setOutputFile5052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile5052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxAmplitude
		{
			get
			{
				return getMaxAmplitude();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAmplitude5053;
		public virtual int getMaxAmplitude() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.MediaRecorder._getMaxAmplitude5053);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getMaxAmplitude5053);
		}
		internal static global::MonoJavaBridge.MethodId _MediaRecorder5054;
		public MediaRecorder()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._MediaRecorder5054);
			Init(@__env, handle);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaRecorder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder"));
			global::android.media.MediaRecorder._finalize5026 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "finalize", "()V");
			global::android.media.MediaRecorder._start5027 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "start", "()V");
			global::android.media.MediaRecorder._stop5028 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "stop", "()V");
			global::android.media.MediaRecorder._reset5029 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "reset", "()V");
			global::android.media.MediaRecorder._release5030 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "release", "()V");
			global::android.media.MediaRecorder._setOutputFormat5031 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOutputFormat", "(I)V");
			global::android.media.MediaRecorder._prepare5032 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "prepare", "()V");
			global::android.media.MediaRecorder._setPreviewDisplay5033 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setPreviewDisplay", "(Landroid/view/Surface;)V");
			global::android.media.MediaRecorder._setOnErrorListener5034 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V");
			global::android.media.MediaRecorder._setOnInfoListener5035 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V");
			global::android.media.MediaRecorder._setCamera5036 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setCamera", "(Landroid/hardware/Camera;)V");
			global::android.media.MediaRecorder._setAudioSource5037 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioSource", "(I)V");
			global::android.media.MediaRecorder._getAudioSourceMax5038 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "getAudioSourceMax", "()I");
			global::android.media.MediaRecorder._setVideoSource5039 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoSource", "(I)V");
			global::android.media.MediaRecorder._setProfile5040 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setProfile", "(Landroid/media/CamcorderProfile;)V");
			global::android.media.MediaRecorder._setVideoSize5041 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoSize", "(II)V");
			global::android.media.MediaRecorder._setVideoFrameRate5042 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoFrameRate", "(I)V");
			global::android.media.MediaRecorder._setMaxDuration5043 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setMaxDuration", "(I)V");
			global::android.media.MediaRecorder._setMaxFileSize5044 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setMaxFileSize", "(J)V");
			global::android.media.MediaRecorder._setAudioEncoder5045 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioEncoder", "(I)V");
			global::android.media.MediaRecorder._setVideoEncoder5046 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoEncoder", "(I)V");
			global::android.media.MediaRecorder._setAudioSamplingRate5047 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioSamplingRate", "(I)V");
			global::android.media.MediaRecorder._setAudioChannels5048 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioChannels", "(I)V");
			global::android.media.MediaRecorder._setAudioEncodingBitRate5049 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioEncodingBitRate", "(I)V");
			global::android.media.MediaRecorder._setVideoEncodingBitRate5050 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoEncodingBitRate", "(I)V");
			global::android.media.MediaRecorder._setOutputFile5051 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaRecorder._setOutputFile5052 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/lang/String;)V");
			global::android.media.MediaRecorder._getMaxAmplitude5053 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "getMaxAmplitude", "()I");
			global::android.media.MediaRecorder._MediaRecorder5054 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "<init>", "()V");
		}
	}
}
