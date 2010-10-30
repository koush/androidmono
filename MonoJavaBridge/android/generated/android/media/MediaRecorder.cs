namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MediaRecorder : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MediaRecorder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AudioEncoder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			static AudioEncoder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.AudioEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$AudioEncoder"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class AudioSource : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			static AudioSource()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.AudioSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$AudioSource"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaRecorder.OnErrorListener_))]
		public partial interface OnErrorListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onError(android.media.MediaRecorder arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaRecorder.OnErrorListener))]
		internal sealed partial class OnErrorListener_ : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnErrorListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaRecorder.OnErrorListener.onError(android.media.MediaRecorder arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaRecorder;II)V", ref global::android.media.MediaRecorder.OnErrorListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnErrorListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OnErrorListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnErrorListenerDelegate(android.media.MediaRecorder arg0, int arg1, int arg2);

		internal partial class OnErrorListenerDelegateWrapper : java.lang.Object, OnErrorListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnErrorListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnErrorListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.OnErrorListenerDelegateWrapper.staticClass, global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnErrorListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder_OnErrorListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnErrorListenerDelegateWrapper
		{
			private OnErrorListenerDelegate myDelegate;
			public void onError(android.media.MediaRecorder arg0, int arg1, int arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnErrorListenerDelegateWrapper(OnErrorListenerDelegate d)
			{
				global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper ret = new global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.MediaRecorder.OnInfoListener_))]
		public partial interface OnInfoListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInfo(android.media.MediaRecorder arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.MediaRecorder.OnInfoListener))]
		internal sealed partial class OnInfoListener_ : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnInfoListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.MediaRecorder.OnInfoListener.onInfo(android.media.MediaRecorder arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaRecorder;II)V", ref global::android.media.MediaRecorder.OnInfoListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnInfoListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OnInfoListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnInfoListenerDelegate(android.media.MediaRecorder arg0, int arg1, int arg2);

		internal partial class OnInfoListenerDelegateWrapper : java.lang.Object, OnInfoListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnInfoListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnInfoListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.OnInfoListenerDelegateWrapper.staticClass, global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnInfoListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder_OnInfoListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnInfoListenerDelegateWrapper
		{
			private OnInfoListenerDelegate myDelegate;
			public void onInfo(android.media.MediaRecorder arg0, int arg1, int arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnInfoListenerDelegateWrapper(OnInfoListenerDelegate d)
			{
				global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper ret = new global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class OutputFormat : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			static OutputFormat()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OutputFormat.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OutputFormat"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class VideoEncoder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			static VideoEncoder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.VideoEncoder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$VideoEncoder"));
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class VideoSource : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			static VideoSource()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.VideoSource.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$VideoSource"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "finalize", "()V", ref global::android.media.MediaRecorder._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "start", "()V", ref global::android.media.MediaRecorder._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "stop", "()V", ref global::android.media.MediaRecorder._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "reset", "()V", ref global::android.media.MediaRecorder._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "release", "()V", ref global::android.media.MediaRecorder._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setOutputFormat(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setOutputFormat", "(I)V", ref global::android.media.MediaRecorder._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void prepare()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "prepare", "()V", ref global::android.media.MediaRecorder._m6);
		}
		public new global::android.view.Surface PreviewDisplay
		{
			set
			{
				setPreviewDisplay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setPreviewDisplay(android.view.Surface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setPreviewDisplay", "(Landroid/view/Surface;)V", ref global::android.media.MediaRecorder._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setOnErrorListener(android.media.MediaRecorder.OnErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V", ref global::android.media.MediaRecorder._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnErrorListener(global::android.media.MediaRecorder.OnErrorListenerDelegate arg0)
		{
			setOnErrorListener((global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setOnInfoListener(android.media.MediaRecorder.OnInfoListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V", ref global::android.media.MediaRecorder._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnInfoListener(global::android.media.MediaRecorder.OnInfoListenerDelegate arg0)
		{
			setOnInfoListener((global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper)arg0);
		}
		public new global::android.hardware.Camera Camera
		{
			set
			{
				setCamera(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setCamera(android.hardware.Camera arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setCamera", "(Landroid/hardware/Camera;)V", ref global::android.media.MediaRecorder._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setAudioSource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setAudioSource", "(I)V", ref global::android.media.MediaRecorder._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int AudioSourceMax
		{
			get
			{
				return getAudioSourceMax();
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static int getAudioSourceMax()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaRecorder._m12.native == global::System.IntPtr.Zero)
				global::android.media.MediaRecorder._m12 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "getAudioSourceMax", "()I");
			return @__env.CallStaticIntMethod(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setVideoSource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setVideoSource", "(I)V", ref global::android.media.MediaRecorder._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.media.CamcorderProfile Profile
		{
			set
			{
				setProfile(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setProfile(android.media.CamcorderProfile arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setProfile", "(Landroid/media/CamcorderProfile;)V", ref global::android.media.MediaRecorder._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setVideoSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setVideoSize", "(II)V", ref global::android.media.MediaRecorder._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int VideoFrameRate
		{
			set
			{
				setVideoFrameRate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setVideoFrameRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setVideoFrameRate", "(I)V", ref global::android.media.MediaRecorder._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxDuration
		{
			set
			{
				setMaxDuration(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setMaxDuration(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setMaxDuration", "(I)V", ref global::android.media.MediaRecorder._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long MaxFileSize
		{
			set
			{
				setMaxFileSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setMaxFileSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setMaxFileSize", "(J)V", ref global::android.media.MediaRecorder._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setAudioEncoder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setAudioEncoder", "(I)V", ref global::android.media.MediaRecorder._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setVideoEncoder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setVideoEncoder", "(I)V", ref global::android.media.MediaRecorder._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AudioSamplingRate
		{
			set
			{
				setAudioSamplingRate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setAudioSamplingRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setAudioSamplingRate", "(I)V", ref global::android.media.MediaRecorder._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AudioChannels
		{
			set
			{
				setAudioChannels(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setAudioChannels(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setAudioChannels", "(I)V", ref global::android.media.MediaRecorder._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AudioEncodingBitRate
		{
			set
			{
				setAudioEncodingBitRate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setAudioEncodingBitRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setAudioEncodingBitRate", "(I)V", ref global::android.media.MediaRecorder._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VideoEncodingBitRate
		{
			set
			{
				setVideoEncodingBitRate(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setVideoEncodingBitRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setVideoEncodingBitRate", "(I)V", ref global::android.media.MediaRecorder._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual void setOutputFile(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/io/FileDescriptor;)V", ref global::android.media.MediaRecorder._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setOutputFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/lang/String;)V", ref global::android.media.MediaRecorder._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxAmplitude
		{
			get
			{
				return getMaxAmplitude();
			}
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual int getMaxAmplitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaRecorder.staticClass, "getMaxAmplitude", "()I", ref global::android.media.MediaRecorder._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public MediaRecorder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.MediaRecorder._m28.native == global::System.IntPtr.Zero)
				global::android.media.MediaRecorder._m28 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._m28);
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
		static MediaRecorder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.MediaRecorder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder"));
		}
		internal static void InitJNI()
		{
		}
	}
}
