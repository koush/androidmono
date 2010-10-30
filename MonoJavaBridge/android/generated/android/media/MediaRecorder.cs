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
			internal static global::MonoJavaBridge.MethodId _onError7383;
			void android.media.MediaRecorder.OnErrorListener.onError(android.media.MediaRecorder arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.OnErrorListener_._onError7383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnErrorListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnErrorListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OnErrorListener"));
				global::android.media.MediaRecorder.OnErrorListener_._onError7383 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnErrorListener_.staticClass, "onError", "(Landroid/media/MediaRecorder;II)V");
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
			internal static global::MonoJavaBridge.MethodId _OnErrorListenerDelegateWrapper7384;
			public OnErrorListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.OnErrorListenerDelegateWrapper.staticClass, global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper._OnErrorListenerDelegateWrapper7384);
				Init(@__env, handle);
			}
			static OnErrorListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder_OnErrorListenerDelegateWrapper"));
				global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper._OnErrorListenerDelegateWrapper7384 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper.staticClass, "<init>", "()V");
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
			internal static global::MonoJavaBridge.MethodId _onInfo7385;
			void android.media.MediaRecorder.OnInfoListener.onInfo(android.media.MediaRecorder arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.MediaRecorder.OnInfoListener_._onInfo7385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnInfoListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnInfoListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder$OnInfoListener"));
				global::android.media.MediaRecorder.OnInfoListener_._onInfo7385 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnInfoListener_.staticClass, "onInfo", "(Landroid/media/MediaRecorder;II)V");
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
			internal static global::MonoJavaBridge.MethodId _OnInfoListenerDelegateWrapper7386;
			public OnInfoListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.OnInfoListenerDelegateWrapper.staticClass, global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper._OnInfoListenerDelegateWrapper7386);
				Init(@__env, handle);
			}
			static OnInfoListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/MediaRecorder_OnInfoListenerDelegateWrapper"));
				global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper._OnInfoListenerDelegateWrapper7386 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.OnInfoListenerDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _finalize7397;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._finalize7397);
		}
		internal static global::MonoJavaBridge.MethodId _start7398;
		public virtual void start()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._start7398);
		}
		internal static global::MonoJavaBridge.MethodId _stop7399;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._stop7399);
		}
		internal static global::MonoJavaBridge.MethodId _reset7400;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._reset7400);
		}
		internal static global::MonoJavaBridge.MethodId _release7401;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._release7401);
		}
		internal static global::MonoJavaBridge.MethodId _setOutputFormat7402;
		public virtual void setOutputFormat(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFormat7402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _prepare7403;
		public virtual void prepare()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._prepare7403);
		}
		public new global::android.view.Surface PreviewDisplay
		{
			set
			{
				setPreviewDisplay(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewDisplay7404;
		public virtual void setPreviewDisplay(android.view.Surface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setPreviewDisplay7404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOnErrorListener7405;
		public virtual void setOnErrorListener(android.media.MediaRecorder.OnErrorListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnErrorListener7405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnErrorListener(global::android.media.MediaRecorder.OnErrorListenerDelegate arg0)
		{
			setOnErrorListener((global::android.media.MediaRecorder.OnErrorListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setOnInfoListener7406;
		public virtual void setOnInfoListener(android.media.MediaRecorder.OnInfoListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOnInfoListener7406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _setCamera7407;
		public virtual void setCamera(android.hardware.Camera arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setCamera7407, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioSource7408;
		public virtual void setAudioSource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSource7408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int AudioSourceMax
		{
			get
			{
				return getAudioSourceMax();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAudioSourceMax7409;
		public static int getAudioSourceMax()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getAudioSourceMax7409);
		}
		internal static global::MonoJavaBridge.MethodId _setVideoSource7410;
		public virtual void setVideoSource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSource7410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.media.CamcorderProfile Profile
		{
			set
			{
				setProfile(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setProfile7411;
		public virtual void setProfile(android.media.CamcorderProfile arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setProfile7411, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoSize7412;
		public virtual void setVideoSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoSize7412, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new int VideoFrameRate
		{
			set
			{
				setVideoFrameRate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVideoFrameRate7413;
		public virtual void setVideoFrameRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoFrameRate7413, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxDuration
		{
			set
			{
				setMaxDuration(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxDuration7414;
		public virtual void setMaxDuration(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxDuration7414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long MaxFileSize
		{
			set
			{
				setMaxFileSize(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFileSize7415;
		public virtual void setMaxFileSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setMaxFileSize7415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAudioEncoder7416;
		public virtual void setAudioEncoder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncoder7416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVideoEncoder7417;
		public virtual void setVideoEncoder(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncoder7417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AudioSamplingRate
		{
			set
			{
				setAudioSamplingRate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAudioSamplingRate7418;
		public virtual void setAudioSamplingRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioSamplingRate7418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AudioChannels
		{
			set
			{
				setAudioChannels(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAudioChannels7419;
		public virtual void setAudioChannels(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioChannels7419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int AudioEncodingBitRate
		{
			set
			{
				setAudioEncodingBitRate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAudioEncodingBitRate7420;
		public virtual void setAudioEncodingBitRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setAudioEncodingBitRate7420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int VideoEncodingBitRate
		{
			set
			{
				setVideoEncodingBitRate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setVideoEncodingBitRate7421;
		public virtual void setVideoEncodingBitRate(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setVideoEncodingBitRate7421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputFile7422;
		public virtual void setOutputFile(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile7422, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOutputFile7423;
		public virtual void setOutputFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._setOutputFile7423, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MaxAmplitude
		{
			get
			{
				return getMaxAmplitude();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxAmplitude7424;
		public virtual int getMaxAmplitude()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._getMaxAmplitude7424);
		}
		internal static global::MonoJavaBridge.MethodId _MediaRecorder7425;
		public MediaRecorder() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.MediaRecorder.staticClass, global::android.media.MediaRecorder._MediaRecorder7425);
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
			global::android.media.MediaRecorder._finalize7397 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "finalize", "()V");
			global::android.media.MediaRecorder._start7398 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "start", "()V");
			global::android.media.MediaRecorder._stop7399 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "stop", "()V");
			global::android.media.MediaRecorder._reset7400 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "reset", "()V");
			global::android.media.MediaRecorder._release7401 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "release", "()V");
			global::android.media.MediaRecorder._setOutputFormat7402 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOutputFormat", "(I)V");
			global::android.media.MediaRecorder._prepare7403 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "prepare", "()V");
			global::android.media.MediaRecorder._setPreviewDisplay7404 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setPreviewDisplay", "(Landroid/view/Surface;)V");
			global::android.media.MediaRecorder._setOnErrorListener7405 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOnErrorListener", "(Landroid/media/MediaRecorder$OnErrorListener;)V");
			global::android.media.MediaRecorder._setOnInfoListener7406 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOnInfoListener", "(Landroid/media/MediaRecorder$OnInfoListener;)V");
			global::android.media.MediaRecorder._setCamera7407 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setCamera", "(Landroid/hardware/Camera;)V");
			global::android.media.MediaRecorder._setAudioSource7408 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioSource", "(I)V");
			global::android.media.MediaRecorder._getAudioSourceMax7409 = @__env.GetStaticMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "getAudioSourceMax", "()I");
			global::android.media.MediaRecorder._setVideoSource7410 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoSource", "(I)V");
			global::android.media.MediaRecorder._setProfile7411 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setProfile", "(Landroid/media/CamcorderProfile;)V");
			global::android.media.MediaRecorder._setVideoSize7412 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoSize", "(II)V");
			global::android.media.MediaRecorder._setVideoFrameRate7413 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoFrameRate", "(I)V");
			global::android.media.MediaRecorder._setMaxDuration7414 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setMaxDuration", "(I)V");
			global::android.media.MediaRecorder._setMaxFileSize7415 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setMaxFileSize", "(J)V");
			global::android.media.MediaRecorder._setAudioEncoder7416 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioEncoder", "(I)V");
			global::android.media.MediaRecorder._setVideoEncoder7417 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoEncoder", "(I)V");
			global::android.media.MediaRecorder._setAudioSamplingRate7418 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioSamplingRate", "(I)V");
			global::android.media.MediaRecorder._setAudioChannels7419 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioChannels", "(I)V");
			global::android.media.MediaRecorder._setAudioEncodingBitRate7420 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setAudioEncodingBitRate", "(I)V");
			global::android.media.MediaRecorder._setVideoEncodingBitRate7421 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setVideoEncodingBitRate", "(I)V");
			global::android.media.MediaRecorder._setOutputFile7422 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/io/FileDescriptor;)V");
			global::android.media.MediaRecorder._setOutputFile7423 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "setOutputFile", "(Ljava/lang/String;)V");
			global::android.media.MediaRecorder._getMaxAmplitude7424 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "getMaxAmplitude", "()I");
			global::android.media.MediaRecorder._MediaRecorder7425 = @__env.GetMethodIDNoThrow(global::android.media.MediaRecorder.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
