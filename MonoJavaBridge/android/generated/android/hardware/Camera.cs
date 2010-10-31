namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Camera : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Camera(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.AutoFocusCallback_))]
		public partial interface AutoFocusCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onAutoFocus(bool arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.AutoFocusCallback))]
		internal sealed partial class AutoFocusCallback_ : java.lang.Object, AutoFocusCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal AutoFocusCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.hardware.Camera.AutoFocusCallback.onAutoFocus(bool arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.AutoFocusCallback_.staticClass, "onAutoFocus", "(ZLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.AutoFocusCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static AutoFocusCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.AutoFocusCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$AutoFocusCallback"));
			}
		}

		public delegate void AutoFocusCallbackDelegate(bool arg0, android.hardware.Camera arg1);

		internal partial class AutoFocusCallbackDelegateWrapper : java.lang.Object, AutoFocusCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoFocusCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public AutoFocusCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.AutoFocusCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static AutoFocusCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_AutoFocusCallbackDelegateWrapper"));
			}
		}
		internal partial class AutoFocusCallbackDelegateWrapper
		{
			private AutoFocusCallbackDelegate myDelegate;
			public void onAutoFocus(bool arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator AutoFocusCallbackDelegateWrapper(AutoFocusCallbackDelegate d)
			{
				global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper ret = new global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.ErrorCallback_))]
		public partial interface ErrorCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onError(int arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.ErrorCallback))]
		internal sealed partial class ErrorCallback_ : java.lang.Object, ErrorCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ErrorCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.hardware.Camera.ErrorCallback.onError(int arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.ErrorCallback_.staticClass, "onError", "(ILandroid/hardware/Camera;)V", ref global::android.hardware.Camera.ErrorCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static ErrorCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ErrorCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ErrorCallback"));
			}
		}

		public delegate void ErrorCallbackDelegate(int arg0, android.hardware.Camera arg1);

		internal partial class ErrorCallbackDelegateWrapper : java.lang.Object, ErrorCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ErrorCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ErrorCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.ErrorCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.ErrorCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ErrorCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.ErrorCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.ErrorCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ErrorCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ErrorCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_ErrorCallbackDelegateWrapper"));
			}
		}
		internal partial class ErrorCallbackDelegateWrapper
		{
			private ErrorCallbackDelegate myDelegate;
			public void onError(int arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator ErrorCallbackDelegateWrapper(ErrorCallbackDelegate d)
			{
				global::android.hardware.Camera.ErrorCallbackDelegateWrapper ret = new global::android.hardware.Camera.ErrorCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.OnZoomChangeListener_))]
		public partial interface OnZoomChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.OnZoomChangeListener))]
		internal sealed partial class OnZoomChangeListener_ : java.lang.Object, OnZoomChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnZoomChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.hardware.Camera.OnZoomChangeListener.onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.OnZoomChangeListener_.staticClass, "onZoomChange", "(IZLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.OnZoomChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static OnZoomChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.OnZoomChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$OnZoomChangeListener"));
			}
		}

		public delegate void OnZoomChangeListenerDelegate(int arg0, bool arg1, android.hardware.Camera arg2);

		internal partial class OnZoomChangeListenerDelegateWrapper : java.lang.Object, OnZoomChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnZoomChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnZoomChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.OnZoomChangeListenerDelegateWrapper.staticClass, global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnZoomChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_OnZoomChangeListenerDelegateWrapper"));
			}
		}
		internal partial class OnZoomChangeListenerDelegateWrapper
		{
			private OnZoomChangeListenerDelegate myDelegate;
			public void onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2)
			{
				myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator OnZoomChangeListenerDelegateWrapper(OnZoomChangeListenerDelegate d)
			{
				global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper ret = new global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Parameters : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Parameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::java.lang.String get(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual int getInt(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I", ref global::android.hardware.Camera.Parameters._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void remove(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void set(java.lang.String arg0, java.lang.String arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void set(java.lang.String arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V", ref global::android.hardware.Camera.Parameters._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::java.lang.String flatten()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m5) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual void unflatten(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void setPreviewSize(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V", ref global::android.hardware.Camera.Parameters._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PreviewSize
			{
				get
				{
					return getPreviewSize();
				}
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public virtual global::android.hardware.Camera.Size getPreviewSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;", ref global::android.hardware.Camera.Parameters._m8) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPreviewSizes
			{
				get
				{
					return getSupportedPreviewSizes();
				}
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public virtual global::java.util.List getSupportedPreviewSizes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m9) as java.util.List;
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public virtual void setJpegThumbnailSize(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V", ref global::android.hardware.Camera.Parameters._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size JpegThumbnailSize
			{
				get
				{
					return getJpegThumbnailSize();
				}
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public virtual global::android.hardware.Camera.Size getJpegThumbnailSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;", ref global::android.hardware.Camera.Parameters._m11) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedJpegThumbnailSizes
			{
				get
				{
					return getSupportedJpegThumbnailSizes();
				}
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public virtual global::java.util.List getSupportedJpegThumbnailSizes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedJpegThumbnailSizes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m12) as java.util.List;
			}
			private static global::MonoJavaBridge.MethodId _m13;
			public virtual void setJpegThumbnailQuality(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V", ref global::android.hardware.Camera.Parameters._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int JpegThumbnailQuality
			{
				get
				{
					return getJpegThumbnailQuality();
				}
				set
				{
					setJpegThumbnailQuality(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m14;
			public virtual int getJpegThumbnailQuality()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I", ref global::android.hardware.Camera.Parameters._m14);
			}
			private static global::MonoJavaBridge.MethodId _m15;
			public virtual void setJpegQuality(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V", ref global::android.hardware.Camera.Parameters._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int JpegQuality
			{
				get
				{
					return getJpegQuality();
				}
				set
				{
					setJpegQuality(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m16;
			public virtual int getJpegQuality()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I", ref global::android.hardware.Camera.Parameters._m16);
			}
			private static global::MonoJavaBridge.MethodId _m17;
			public virtual void setPreviewFrameRate(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V", ref global::android.hardware.Camera.Parameters._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int PreviewFrameRate
			{
				get
				{
					return getPreviewFrameRate();
				}
				set
				{
					setPreviewFrameRate(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m18;
			public virtual int getPreviewFrameRate()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I", ref global::android.hardware.Camera.Parameters._m18);
			}
			public new global::java.util.List SupportedPreviewFrameRates
			{
				get
				{
					return getSupportedPreviewFrameRates();
				}
			}
			private static global::MonoJavaBridge.MethodId _m19;
			public virtual global::java.util.List getSupportedPreviewFrameRates()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m19) as java.util.List;
			}
			private static global::MonoJavaBridge.MethodId _m20;
			public virtual void setPreviewFormat(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V", ref global::android.hardware.Camera.Parameters._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int PreviewFormat
			{
				get
				{
					return getPreviewFormat();
				}
				set
				{
					setPreviewFormat(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m21;
			public virtual int getPreviewFormat()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I", ref global::android.hardware.Camera.Parameters._m21);
			}
			public new global::java.util.List SupportedPreviewFormats
			{
				get
				{
					return getSupportedPreviewFormats();
				}
			}
			private static global::MonoJavaBridge.MethodId _m22;
			public virtual global::java.util.List getSupportedPreviewFormats()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m22) as java.util.List;
			}
			private static global::MonoJavaBridge.MethodId _m23;
			public virtual void setPictureSize(int arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V", ref global::android.hardware.Camera.Parameters._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PictureSize
			{
				get
				{
					return getPictureSize();
				}
			}
			private static global::MonoJavaBridge.MethodId _m24;
			public virtual global::android.hardware.Camera.Size getPictureSize()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;", ref global::android.hardware.Camera.Parameters._m24) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPictureSizes
			{
				get
				{
					return getSupportedPictureSizes();
				}
			}
			private static global::MonoJavaBridge.MethodId _m25;
			public virtual global::java.util.List getSupportedPictureSizes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m25) as java.util.List;
			}
			private static global::MonoJavaBridge.MethodId _m26;
			public virtual void setPictureFormat(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V", ref global::android.hardware.Camera.Parameters._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int PictureFormat
			{
				get
				{
					return getPictureFormat();
				}
				set
				{
					setPictureFormat(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m27;
			public virtual int getPictureFormat()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I", ref global::android.hardware.Camera.Parameters._m27);
			}
			public new global::java.util.List SupportedPictureFormats
			{
				get
				{
					return getSupportedPictureFormats();
				}
			}
			private static global::MonoJavaBridge.MethodId _m28;
			public virtual global::java.util.List getSupportedPictureFormats()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m28) as java.util.List;
			}
			public new int Rotation
			{
				set
				{
					setRotation(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m29;
			public virtual void setRotation(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V", ref global::android.hardware.Camera.Parameters._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new double GpsLatitude
			{
				set
				{
					setGpsLatitude(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m30;
			public virtual void setGpsLatitude(double arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V", ref global::android.hardware.Camera.Parameters._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new double GpsLongitude
			{
				set
				{
					setGpsLongitude(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m31;
			public virtual void setGpsLongitude(double arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V", ref global::android.hardware.Camera.Parameters._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new double GpsAltitude
			{
				set
				{
					setGpsAltitude(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m32;
			public virtual void setGpsAltitude(double arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V", ref global::android.hardware.Camera.Parameters._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new long GpsTimestamp
			{
				set
				{
					setGpsTimestamp(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m33;
			public virtual void setGpsTimestamp(long arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V", ref global::android.hardware.Camera.Parameters._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.lang.String GpsProcessingMethod
			{
				set
				{
					setGpsProcessingMethod(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m34;
			public virtual void setGpsProcessingMethod(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setGpsProcessingMethod", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m35;
			public virtual void removeGpsData()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V", ref global::android.hardware.Camera.Parameters._m35);
			}
			public new global::java.lang.String WhiteBalance
			{
				get
				{
					return getWhiteBalance();
				}
				set
				{
					setWhiteBalance(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m36;
			public virtual global::java.lang.String getWhiteBalance()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m36) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m37;
			public virtual void setWhiteBalance(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedWhiteBalance
			{
				get
				{
					return getSupportedWhiteBalance();
				}
			}
			private static global::MonoJavaBridge.MethodId _m38;
			public virtual global::java.util.List getSupportedWhiteBalance()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m38) as java.util.List;
			}
			public new global::java.lang.String ColorEffect
			{
				get
				{
					return getColorEffect();
				}
				set
				{
					setColorEffect(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m39;
			public virtual global::java.lang.String getColorEffect()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m39) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m40;
			public virtual void setColorEffect(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedColorEffects
			{
				get
				{
					return getSupportedColorEffects();
				}
			}
			private static global::MonoJavaBridge.MethodId _m41;
			public virtual global::java.util.List getSupportedColorEffects()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m41) as java.util.List;
			}
			public new global::java.lang.String Antibanding
			{
				get
				{
					return getAntibanding();
				}
				set
				{
					setAntibanding(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m42;
			public virtual global::java.lang.String getAntibanding()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m42) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m43;
			public virtual void setAntibanding(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedAntibanding
			{
				get
				{
					return getSupportedAntibanding();
				}
			}
			private static global::MonoJavaBridge.MethodId _m44;
			public virtual global::java.util.List getSupportedAntibanding()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m44) as java.util.List;
			}
			public new global::java.lang.String SceneMode
			{
				get
				{
					return getSceneMode();
				}
				set
				{
					setSceneMode(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m45;
			public virtual global::java.lang.String getSceneMode()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m45) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m46;
			public virtual void setSceneMode(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedSceneModes
			{
				get
				{
					return getSupportedSceneModes();
				}
			}
			private static global::MonoJavaBridge.MethodId _m47;
			public virtual global::java.util.List getSupportedSceneModes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m47) as java.util.List;
			}
			public new global::java.lang.String FlashMode
			{
				get
				{
					return getFlashMode();
				}
				set
				{
					setFlashMode(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m48;
			public virtual global::java.lang.String getFlashMode()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m48) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m49;
			public virtual void setFlashMode(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFlashModes
			{
				get
				{
					return getSupportedFlashModes();
				}
			}
			private static global::MonoJavaBridge.MethodId _m50;
			public virtual global::java.util.List getSupportedFlashModes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m50) as java.util.List;
			}
			public new global::java.lang.String FocusMode
			{
				get
				{
					return getFocusMode();
				}
				set
				{
					setFocusMode(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m51;
			public virtual global::java.lang.String getFocusMode()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;", ref global::android.hardware.Camera.Parameters._m51) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m52;
			public virtual void setFocusMode(java.lang.String arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V", ref global::android.hardware.Camera.Parameters._m52, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFocusModes
			{
				get
				{
					return getSupportedFocusModes();
				}
			}
			private static global::MonoJavaBridge.MethodId _m53;
			public virtual global::java.util.List getSupportedFocusModes()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m53) as java.util.List;
			}
			public new float FocalLength
			{
				get
				{
					return getFocalLength();
				}
			}
			private static global::MonoJavaBridge.MethodId _m54;
			public virtual float getFocalLength()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getFocalLength", "()F", ref global::android.hardware.Camera.Parameters._m54);
			}
			public new float HorizontalViewAngle
			{
				get
				{
					return getHorizontalViewAngle();
				}
			}
			private static global::MonoJavaBridge.MethodId _m55;
			public virtual float getHorizontalViewAngle()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getHorizontalViewAngle", "()F", ref global::android.hardware.Camera.Parameters._m55);
			}
			public new float VerticalViewAngle
			{
				get
				{
					return getVerticalViewAngle();
				}
			}
			private static global::MonoJavaBridge.MethodId _m56;
			public virtual float getVerticalViewAngle()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getVerticalViewAngle", "()F", ref global::android.hardware.Camera.Parameters._m56);
			}
			public new int ExposureCompensation
			{
				get
				{
					return getExposureCompensation();
				}
				set
				{
					setExposureCompensation(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m57;
			public virtual int getExposureCompensation()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensation", "()I", ref global::android.hardware.Camera.Parameters._m57);
			}
			private static global::MonoJavaBridge.MethodId _m58;
			public virtual void setExposureCompensation(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setExposureCompensation", "(I)V", ref global::android.hardware.Camera.Parameters._m58, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int MaxExposureCompensation
			{
				get
				{
					return getMaxExposureCompensation();
				}
			}
			private static global::MonoJavaBridge.MethodId _m59;
			public virtual int getMaxExposureCompensation()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getMaxExposureCompensation", "()I", ref global::android.hardware.Camera.Parameters._m59);
			}
			public new int MinExposureCompensation
			{
				get
				{
					return getMinExposureCompensation();
				}
			}
			private static global::MonoJavaBridge.MethodId _m60;
			public virtual int getMinExposureCompensation()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getMinExposureCompensation", "()I", ref global::android.hardware.Camera.Parameters._m60);
			}
			public new float ExposureCompensationStep
			{
				get
				{
					return getExposureCompensationStep();
				}
			}
			private static global::MonoJavaBridge.MethodId _m61;
			public virtual float getExposureCompensationStep()
			{
				return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensationStep", "()F", ref global::android.hardware.Camera.Parameters._m61);
			}
			public new int Zoom
			{
				get
				{
					return getZoom();
				}
				set
				{
					setZoom(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m62;
			public virtual int getZoom()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getZoom", "()I", ref global::android.hardware.Camera.Parameters._m62);
			}
			private static global::MonoJavaBridge.MethodId _m63;
			public virtual void setZoom(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, "setZoom", "(I)V", ref global::android.hardware.Camera.Parameters._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m64;
			public virtual bool isZoomSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.Camera.Parameters.staticClass, "isZoomSupported", "()Z", ref global::android.hardware.Camera.Parameters._m64);
			}
			public new int MaxZoom
			{
				get
				{
					return getMaxZoom();
				}
			}
			private static global::MonoJavaBridge.MethodId _m65;
			public virtual int getMaxZoom()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, "getMaxZoom", "()I", ref global::android.hardware.Camera.Parameters._m65);
			}
			public new global::java.util.List ZoomRatios
			{
				get
				{
					return getZoomRatios();
				}
			}
			private static global::MonoJavaBridge.MethodId _m66;
			public virtual global::java.util.List getZoomRatios()
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.List>(this, global::android.hardware.Camera.Parameters.staticClass, "getZoomRatios", "()Ljava/util/List;", ref global::android.hardware.Camera.Parameters._m66) as java.util.List;
			}
			private static global::MonoJavaBridge.MethodId _m67;
			public virtual bool isSmoothZoomSupported()
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.Camera.Parameters.staticClass, "isSmoothZoomSupported", "()Z", ref global::android.hardware.Camera.Parameters._m67);
			}
			public static global::java.lang.String WHITE_BALANCE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_INCANDESCENT
			{
				get
				{
					return "incandescent";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_FLUORESCENT
			{
				get
				{
					return "fluorescent";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_WARM_FLUORESCENT
			{
				get
				{
					return "warm-fluorescent";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_DAYLIGHT
			{
				get
				{
					return "daylight";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_CLOUDY_DAYLIGHT
			{
				get
				{
					return "cloudy-daylight";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_TWILIGHT
			{
				get
				{
					return "twilight";
				}
			}
			public static global::java.lang.String WHITE_BALANCE_SHADE
			{
				get
				{
					return "shade";
				}
			}
			public static global::java.lang.String EFFECT_NONE
			{
				get
				{
					return "none";
				}
			}
			public static global::java.lang.String EFFECT_MONO
			{
				get
				{
					return "mono";
				}
			}
			public static global::java.lang.String EFFECT_NEGATIVE
			{
				get
				{
					return "negative";
				}
			}
			public static global::java.lang.String EFFECT_SOLARIZE
			{
				get
				{
					return "solarize";
				}
			}
			public static global::java.lang.String EFFECT_SEPIA
			{
				get
				{
					return "sepia";
				}
			}
			public static global::java.lang.String EFFECT_POSTERIZE
			{
				get
				{
					return "posterize";
				}
			}
			public static global::java.lang.String EFFECT_WHITEBOARD
			{
				get
				{
					return "whiteboard";
				}
			}
			public static global::java.lang.String EFFECT_BLACKBOARD
			{
				get
				{
					return "blackboard";
				}
			}
			public static global::java.lang.String EFFECT_AQUA
			{
				get
				{
					return "aqua";
				}
			}
			public static global::java.lang.String ANTIBANDING_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String ANTIBANDING_50HZ
			{
				get
				{
					return "50hz";
				}
			}
			public static global::java.lang.String ANTIBANDING_60HZ
			{
				get
				{
					return "60hz";
				}
			}
			public static global::java.lang.String ANTIBANDING_OFF
			{
				get
				{
					return "off";
				}
			}
			public static global::java.lang.String FLASH_MODE_OFF
			{
				get
				{
					return "off";
				}
			}
			public static global::java.lang.String FLASH_MODE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String FLASH_MODE_ON
			{
				get
				{
					return "on";
				}
			}
			public static global::java.lang.String FLASH_MODE_RED_EYE
			{
				get
				{
					return "red-eye";
				}
			}
			public static global::java.lang.String FLASH_MODE_TORCH
			{
				get
				{
					return "torch";
				}
			}
			public static global::java.lang.String SCENE_MODE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String SCENE_MODE_ACTION
			{
				get
				{
					return "action";
				}
			}
			public static global::java.lang.String SCENE_MODE_PORTRAIT
			{
				get
				{
					return "portrait";
				}
			}
			public static global::java.lang.String SCENE_MODE_LANDSCAPE
			{
				get
				{
					return "landscape";
				}
			}
			public static global::java.lang.String SCENE_MODE_NIGHT
			{
				get
				{
					return "night";
				}
			}
			public static global::java.lang.String SCENE_MODE_NIGHT_PORTRAIT
			{
				get
				{
					return "night-portrait";
				}
			}
			public static global::java.lang.String SCENE_MODE_THEATRE
			{
				get
				{
					return "theatre";
				}
			}
			public static global::java.lang.String SCENE_MODE_BEACH
			{
				get
				{
					return "beach";
				}
			}
			public static global::java.lang.String SCENE_MODE_SNOW
			{
				get
				{
					return "snow";
				}
			}
			public static global::java.lang.String SCENE_MODE_SUNSET
			{
				get
				{
					return "sunset";
				}
			}
			public static global::java.lang.String SCENE_MODE_STEADYPHOTO
			{
				get
				{
					return "steadyphoto";
				}
			}
			public static global::java.lang.String SCENE_MODE_FIREWORKS
			{
				get
				{
					return "fireworks";
				}
			}
			public static global::java.lang.String SCENE_MODE_SPORTS
			{
				get
				{
					return "sports";
				}
			}
			public static global::java.lang.String SCENE_MODE_PARTY
			{
				get
				{
					return "party";
				}
			}
			public static global::java.lang.String SCENE_MODE_CANDLELIGHT
			{
				get
				{
					return "candlelight";
				}
			}
			public static global::java.lang.String SCENE_MODE_BARCODE
			{
				get
				{
					return "barcode";
				}
			}
			public static global::java.lang.String FOCUS_MODE_AUTO
			{
				get
				{
					return "auto";
				}
			}
			public static global::java.lang.String FOCUS_MODE_INFINITY
			{
				get
				{
					return "infinity";
				}
			}
			public static global::java.lang.String FOCUS_MODE_MACRO
			{
				get
				{
					return "macro";
				}
			}
			public static global::java.lang.String FOCUS_MODE_FIXED
			{
				get
				{
					return "fixed";
				}
			}
			public static global::java.lang.String FOCUS_MODE_EDOF
			{
				get
				{
					return "edof";
				}
			}
			static Parameters()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Parameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Parameters"));
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.PictureCallback_))]
		public partial interface PictureCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onPictureTaken(byte[] arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.PictureCallback))]
		internal sealed partial class PictureCallback_ : java.lang.Object, PictureCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PictureCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.hardware.Camera.PictureCallback.onPictureTaken(byte[] arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.PictureCallback_.staticClass, "onPictureTaken", "([BLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.PictureCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static PictureCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PictureCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PictureCallback"));
			}
		}

		public delegate void PictureCallbackDelegate(byte[] arg0, android.hardware.Camera arg1);

		internal partial class PictureCallbackDelegateWrapper : java.lang.Object, PictureCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PictureCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public PictureCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.PictureCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.PictureCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PictureCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.PictureCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.PictureCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static PictureCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PictureCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_PictureCallbackDelegateWrapper"));
			}
		}
		internal partial class PictureCallbackDelegateWrapper
		{
			private PictureCallbackDelegate myDelegate;
			public void onPictureTaken(byte[] arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator PictureCallbackDelegateWrapper(PictureCallbackDelegate d)
			{
				global::android.hardware.Camera.PictureCallbackDelegateWrapper ret = new global::android.hardware.Camera.PictureCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.PreviewCallback_))]
		public partial interface PreviewCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.PreviewCallback))]
		internal sealed partial class PreviewCallback_ : java.lang.Object, PreviewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal PreviewCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.hardware.Camera.PreviewCallback.onPreviewFrame(byte[] arg0, android.hardware.Camera arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.PreviewCallback_.staticClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V", ref global::android.hardware.Camera.PreviewCallback_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static PreviewCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PreviewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PreviewCallback"));
			}
		}

		public delegate void PreviewCallbackDelegate(byte[] arg0, android.hardware.Camera arg1);

		internal partial class PreviewCallbackDelegateWrapper : java.lang.Object, PreviewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected PreviewCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public PreviewCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.PreviewCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.PreviewCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PreviewCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.PreviewCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.PreviewCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static PreviewCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PreviewCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_PreviewCallbackDelegateWrapper"));
			}
		}
		internal partial class PreviewCallbackDelegateWrapper
		{
			private PreviewCallbackDelegate myDelegate;
			public void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator PreviewCallbackDelegateWrapper(PreviewCallbackDelegate d)
			{
				global::android.hardware.Camera.PreviewCallbackDelegateWrapper ret = new global::android.hardware.Camera.PreviewCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.ShutterCallback_))]
		public partial interface ShutterCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onShutter();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.ShutterCallback))]
		internal sealed partial class ShutterCallback_ : java.lang.Object, ShutterCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ShutterCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.hardware.Camera.ShutterCallback.onShutter()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.ShutterCallback_.staticClass, "onShutter", "()V", ref global::android.hardware.Camera.ShutterCallback_._m0);
			}
			static ShutterCallback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ShutterCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ShutterCallback"));
			}
		}

		public delegate void ShutterCallbackDelegate();

		internal partial class ShutterCallbackDelegateWrapper : java.lang.Object, ShutterCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ShutterCallbackDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ShutterCallbackDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.ShutterCallbackDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.ShutterCallbackDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ShutterCallbackDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.ShutterCallbackDelegateWrapper.staticClass, global::android.hardware.Camera.ShutterCallbackDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ShutterCallbackDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ShutterCallbackDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera_ShutterCallbackDelegateWrapper"));
			}
		}
		internal partial class ShutterCallbackDelegateWrapper
		{
			private ShutterCallbackDelegate myDelegate;
			public void onShutter()
			{
				myDelegate();
			}
			public static implicit operator ShutterCallbackDelegateWrapper(ShutterCallbackDelegate d)
			{
				global::android.hardware.Camera.ShutterCallbackDelegateWrapper ret = new global::android.hardware.Camera.ShutterCallbackDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Size : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Size(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override bool equals(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.hardware.Camera.Size.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::android.hardware.Camera.Size._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public override int hashCode()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.hardware.Camera.Size.staticClass, "hashCode", "()I", ref global::android.hardware.Camera.Size._m1);
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public Size(android.hardware.Camera arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.hardware.Camera.Size._m2.native == global::System.IntPtr.Zero)
					global::android.hardware.Camera.Size._m2 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _width2484;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width2484);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height2485;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height2485);
				}
				set
				{
				}
			}
			static Size()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Size.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Size"));
				global::android.hardware.Camera.Size._width2484 = @__env.GetFieldIDNoThrow(global::android.hardware.Camera.Size.staticClass, "width", "I");
				global::android.hardware.Camera.Size._height2485 = @__env.GetFieldIDNoThrow(global::android.hardware.Camera.Size.staticClass, "height", "I");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "finalize", "()V", ref global::android.hardware.Camera._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void @lock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "@lock", "()V", ref global::android.hardware.Camera._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "release", "()V", ref global::android.hardware.Camera._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::android.hardware.Camera open()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.hardware.Camera._m3.native == global::System.IntPtr.Zero)
				global::android.hardware.Camera._m3 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.hardware.Camera.staticClass, global::android.hardware.Camera._m3)) as android.hardware.Camera;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void unlock()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "unlock", "()V", ref global::android.hardware.Camera._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.hardware.Camera.Parameters getParameters()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;", ref global::android.hardware.Camera._m5) as android.hardware.Camera.Parameters;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void reconnect()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "reconnect", "()V", ref global::android.hardware.Camera._m6);
		}
		public new global::android.view.SurfaceHolder PreviewDisplay
		{
			set
			{
				setPreviewDisplay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", ref global::android.hardware.Camera._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void startPreview()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "startPreview", "()V", ref global::android.hardware.Camera._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void stopPreview()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "stopPreview", "()V", ref global::android.hardware.Camera._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", ref global::android.hardware.Camera._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPreviewCallback(global::android.hardware.Camera.PreviewCallbackDelegate arg0)
		{
			setPreviewCallback((global::android.hardware.Camera.PreviewCallbackDelegateWrapper)arg0);
		}
		public new global::android.hardware.Camera.PreviewCallback OneShotPreviewCallback
		{
			set
			{
				setOneShotPreviewCallback(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V", ref global::android.hardware.Camera._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOneShotPreviewCallback(global::android.hardware.Camera.PreviewCallbackDelegate arg0)
		{
			setOneShotPreviewCallback((global::android.hardware.Camera.PreviewCallbackDelegateWrapper)arg0);
		}
		public new global::android.hardware.Camera.PreviewCallback PreviewCallbackWithBuffer
		{
			set
			{
				setPreviewCallbackWithBuffer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setPreviewCallbackWithBuffer(android.hardware.Camera.PreviewCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V", ref global::android.hardware.Camera._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setPreviewCallbackWithBuffer(global::android.hardware.Camera.PreviewCallbackDelegate arg0)
		{
			setPreviewCallbackWithBuffer((global::android.hardware.Camera.PreviewCallbackDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void addCallbackBuffer(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "addCallbackBuffer", "([B)V", ref global::android.hardware.Camera._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V", ref global::android.hardware.Camera._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void autoFocus(global::android.hardware.Camera.AutoFocusCallbackDelegate arg0)
		{
			autoFocus((global::android.hardware.Camera.AutoFocusCallbackDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void cancelAutoFocus()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V", ref global::android.hardware.Camera._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V", ref global::android.hardware.Camera._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public void takePicture(global::android.hardware.Camera.ShutterCallbackDelegate arg0, global::android.hardware.Camera.PictureCallbackDelegate arg1, global::android.hardware.Camera.PictureCallbackDelegate arg2, global::android.hardware.Camera.PictureCallbackDelegate arg3)
		{
			takePicture((global::android.hardware.Camera.ShutterCallbackDelegateWrapper)arg0, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg1, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg2, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg3);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V", ref global::android.hardware.Camera._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public void takePicture(global::android.hardware.Camera.ShutterCallbackDelegate arg0, global::android.hardware.Camera.PictureCallbackDelegate arg1, global::android.hardware.Camera.PictureCallbackDelegate arg2)
		{
			takePicture((global::android.hardware.Camera.ShutterCallbackDelegateWrapper)arg0, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg1, (global::android.hardware.Camera.PictureCallbackDelegateWrapper)arg2);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void startSmoothZoom(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "startSmoothZoom", "(I)V", ref global::android.hardware.Camera._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void stopSmoothZoom()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "stopSmoothZoom", "()V", ref global::android.hardware.Camera._m19);
		}
		public new int DisplayOrientation
		{
			set
			{
				setDisplayOrientation(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setDisplayOrientation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setDisplayOrientation", "(I)V", ref global::android.hardware.Camera._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.hardware.Camera.OnZoomChangeListener ZoomChangeListener
		{
			set
			{
				setZoomChangeListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setZoomChangeListener(android.hardware.Camera.OnZoomChangeListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V", ref global::android.hardware.Camera._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setZoomChangeListener(global::android.hardware.Camera.OnZoomChangeListenerDelegate arg0)
		{
			setZoomChangeListener((global::android.hardware.Camera.OnZoomChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V", ref global::android.hardware.Camera._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setErrorCallback(global::android.hardware.Camera.ErrorCallbackDelegate arg0)
		{
			setErrorCallback((global::android.hardware.Camera.ErrorCallbackDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void setParameters(android.hardware.Camera.Parameters arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V", ref global::android.hardware.Camera._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int CAMERA_ERROR_UNKNOWN
		{
			get
			{
				return 1;
			}
		}
		public static int CAMERA_ERROR_SERVER_DIED
		{
			get
			{
				return 100;
			}
		}
		static Camera()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera"));
		}
	}
}
