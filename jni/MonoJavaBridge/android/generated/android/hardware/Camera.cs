namespace android.hardware
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Camera : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Camera()
		{
			InitJNI();
		}
		protected Camera(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.AutoFocusCallback_))]
		public interface AutoFocusCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onAutoFocus(bool arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.AutoFocusCallback))]
		public sealed partial class AutoFocusCallback_ : java.lang.Object, AutoFocusCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static AutoFocusCallback_()
			{
				InitJNI();
			}
			internal AutoFocusCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onAutoFocus6247;
			 void android.hardware.Camera.AutoFocusCallback.onAutoFocus(bool arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus6247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.AutoFocusCallback_.staticClass, global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus6247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.AutoFocusCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$AutoFocusCallback"));
				global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus6247 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.AutoFocusCallback_.staticClass, "onAutoFocus", "(ZLandroid/hardware/Camera;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.ErrorCallback_))]
		public interface ErrorCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onError(int arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.ErrorCallback))]
		public sealed partial class ErrorCallback_ : java.lang.Object, ErrorCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ErrorCallback_()
			{
				InitJNI();
			}
			internal ErrorCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onError6248;
			 void android.hardware.Camera.ErrorCallback.onError(int arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.ErrorCallback_._onError6248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.ErrorCallback_.staticClass, global::android.hardware.Camera.ErrorCallback_._onError6248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ErrorCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ErrorCallback"));
				global::android.hardware.Camera.ErrorCallback_._onError6248 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ErrorCallback_.staticClass, "onError", "(ILandroid/hardware/Camera;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.OnZoomChangeListener_))]
		public interface OnZoomChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.OnZoomChangeListener))]
		public sealed partial class OnZoomChangeListener_ : java.lang.Object, OnZoomChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnZoomChangeListener_()
			{
				InitJNI();
			}
			internal OnZoomChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onZoomChange6249;
			 void android.hardware.Camera.OnZoomChangeListener.onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange6249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.OnZoomChangeListener_.staticClass, global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange6249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.OnZoomChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$OnZoomChangeListener"));
				global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange6249 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.OnZoomChangeListener_.staticClass, "onZoomChange", "(IZLandroid/hardware/Camera;)V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Parameters : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Parameters()
			{
				InitJNI();
			}
			protected Parameters(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _get6250;
			public virtual global::java.lang.String get(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._get6250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._get6250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getInt6251;
			public virtual int getInt(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getInt6251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getInt6251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _remove6252;
			public virtual void remove(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._remove6252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._remove6252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _set6253;
			public virtual void set(java.lang.String arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._set6253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set6253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _set6254;
			public virtual void set(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._set6254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set6254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _flatten6255;
			public virtual global::java.lang.String flatten() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._flatten6255)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._flatten6255)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unflatten6256;
			public virtual void unflatten(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._unflatten6256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._unflatten6256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewSize6257;
			public virtual void setPreviewSize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPreviewSize6257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewSize6257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PreviewSize
			{
				get
				{
					return getPreviewSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPreviewSize6258;
			public virtual global::android.hardware.Camera.Size getPreviewSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPreviewSize6258)) as android.hardware.Camera.Size;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewSize6258)) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPreviewSizes
			{
				get
				{
					return getSupportedPreviewSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewSizes6259;
			public virtual global::java.util.List getSupportedPreviewSizes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes6259)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes6259)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setJpegThumbnailSize6260;
			public virtual void setJpegThumbnailSize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setJpegThumbnailSize6260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailSize6260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size JpegThumbnailSize
			{
				get
				{
					return getJpegThumbnailSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getJpegThumbnailSize6261;
			public virtual global::android.hardware.Camera.Size getJpegThumbnailSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getJpegThumbnailSize6261)) as android.hardware.Camera.Size;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailSize6261)) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedJpegThumbnailSizes
			{
				get
				{
					return getSupportedJpegThumbnailSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedJpegThumbnailSizes6262;
			public virtual global::java.util.List getSupportedJpegThumbnailSizes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes6262)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes6262)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setJpegThumbnailQuality6263;
			public virtual void setJpegThumbnailQuality(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality6263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality6263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getJpegThumbnailQuality6264;
			public virtual int getJpegThumbnailQuality() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality6264);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality6264);
			}
			internal static global::MonoJavaBridge.MethodId _setJpegQuality6265;
			public virtual void setJpegQuality(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setJpegQuality6265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegQuality6265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getJpegQuality6266;
			public virtual int getJpegQuality() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getJpegQuality6266);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegQuality6266);
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewFrameRate6267;
			public virtual void setPreviewFrameRate(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPreviewFrameRate6267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFrameRate6267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getPreviewFrameRate6268;
			public virtual int getPreviewFrameRate() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPreviewFrameRate6268);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFrameRate6268);
			}
			public new global::java.util.List SupportedPreviewFrameRates
			{
				get
				{
					return getSupportedPreviewFrameRates();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewFrameRates6269;
			public virtual global::java.util.List getSupportedPreviewFrameRates() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates6269)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates6269)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewFormat6270;
			public virtual void setPreviewFormat(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPreviewFormat6270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFormat6270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getPreviewFormat6271;
			public virtual int getPreviewFormat() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPreviewFormat6271);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFormat6271);
			}
			public new global::java.util.List SupportedPreviewFormats
			{
				get
				{
					return getSupportedPreviewFormats();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewFormats6272;
			public virtual global::java.util.List getSupportedPreviewFormats() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats6272)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats6272)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPictureSize6273;
			public virtual void setPictureSize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPictureSize6273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureSize6273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PictureSize
			{
				get
				{
					return getPictureSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPictureSize6274;
			public virtual global::android.hardware.Camera.Size getPictureSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPictureSize6274)) as android.hardware.Camera.Size;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureSize6274)) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPictureSizes
			{
				get
				{
					return getSupportedPictureSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPictureSizes6275;
			public virtual global::java.util.List getSupportedPictureSizes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPictureSizes6275)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureSizes6275)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPictureFormat6276;
			public virtual void setPictureFormat(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPictureFormat6276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureFormat6276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getPictureFormat6277;
			public virtual int getPictureFormat() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPictureFormat6277);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureFormat6277);
			}
			public new global::java.util.List SupportedPictureFormats
			{
				get
				{
					return getSupportedPictureFormats();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPictureFormats6278;
			public virtual global::java.util.List getSupportedPictureFormats() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPictureFormats6278)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureFormats6278)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setRotation6279;
			public virtual void setRotation(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setRotation6279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setRotation6279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsLatitude6280;
			public virtual void setGpsLatitude(double arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsLatitude6280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLatitude6280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsLongitude6281;
			public virtual void setGpsLongitude(double arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsLongitude6281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLongitude6281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsAltitude6282;
			public virtual void setGpsAltitude(double arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsAltitude6282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsAltitude6282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsTimestamp6283;
			public virtual void setGpsTimestamp(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsTimestamp6283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsTimestamp6283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsProcessingMethod6284;
			public virtual void setGpsProcessingMethod(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsProcessingMethod6284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsProcessingMethod6284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _removeGpsData6285;
			public virtual void removeGpsData() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._removeGpsData6285);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._removeGpsData6285);
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
			internal static global::MonoJavaBridge.MethodId _getWhiteBalance6286;
			public virtual global::java.lang.String getWhiteBalance() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getWhiteBalance6286)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getWhiteBalance6286)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setWhiteBalance6287;
			public virtual void setWhiteBalance(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setWhiteBalance6287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setWhiteBalance6287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedWhiteBalance
			{
				get
				{
					return getSupportedWhiteBalance();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedWhiteBalance6288;
			public virtual global::java.util.List getSupportedWhiteBalance() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance6288)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance6288)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getColorEffect6289;
			public virtual global::java.lang.String getColorEffect() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getColorEffect6289)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getColorEffect6289)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setColorEffect6290;
			public virtual void setColorEffect(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setColorEffect6290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setColorEffect6290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedColorEffects
			{
				get
				{
					return getSupportedColorEffects();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedColorEffects6291;
			public virtual global::java.util.List getSupportedColorEffects() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedColorEffects6291)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedColorEffects6291)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getAntibanding6292;
			public virtual global::java.lang.String getAntibanding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getAntibanding6292)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getAntibanding6292)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setAntibanding6293;
			public virtual void setAntibanding(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setAntibanding6293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setAntibanding6293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedAntibanding
			{
				get
				{
					return getSupportedAntibanding();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedAntibanding6294;
			public virtual global::java.util.List getSupportedAntibanding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedAntibanding6294)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedAntibanding6294)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getSceneMode6295;
			public virtual global::java.lang.String getSceneMode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSceneMode6295)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSceneMode6295)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setSceneMode6296;
			public virtual void setSceneMode(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setSceneMode6296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setSceneMode6296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedSceneModes
			{
				get
				{
					return getSupportedSceneModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedSceneModes6297;
			public virtual global::java.util.List getSupportedSceneModes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedSceneModes6297)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedSceneModes6297)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getFlashMode6298;
			public virtual global::java.lang.String getFlashMode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getFlashMode6298)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFlashMode6298)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setFlashMode6299;
			public virtual void setFlashMode(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setFlashMode6299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFlashMode6299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFlashModes
			{
				get
				{
					return getSupportedFlashModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedFlashModes6300;
			public virtual global::java.util.List getSupportedFlashModes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedFlashModes6300)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFlashModes6300)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getFocusMode6301;
			public virtual global::java.lang.String getFocusMode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getFocusMode6301)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocusMode6301)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setFocusMode6302;
			public virtual void setFocusMode(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setFocusMode6302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFocusMode6302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFocusModes
			{
				get
				{
					return getSupportedFocusModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedFocusModes6303;
			public virtual global::java.util.List getSupportedFocusModes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedFocusModes6303)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFocusModes6303)) as java.util.List;
			}
			public new float FocalLength
			{
				get
				{
					return getFocalLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFocalLength6304;
			public virtual float getFocalLength() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getFocalLength6304);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocalLength6304);
			}
			public new float HorizontalViewAngle
			{
				get
				{
					return getHorizontalViewAngle();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHorizontalViewAngle6305;
			public virtual float getHorizontalViewAngle() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getHorizontalViewAngle6305);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getHorizontalViewAngle6305);
			}
			public new float VerticalViewAngle
			{
				get
				{
					return getVerticalViewAngle();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getVerticalViewAngle6306;
			public virtual float getVerticalViewAngle() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getVerticalViewAngle6306);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getVerticalViewAngle6306);
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
			internal static global::MonoJavaBridge.MethodId _getExposureCompensation6307;
			public virtual int getExposureCompensation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getExposureCompensation6307);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getExposureCompensation6307);
			}
			internal static global::MonoJavaBridge.MethodId _setExposureCompensation6308;
			public virtual void setExposureCompensation(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setExposureCompensation6308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setExposureCompensation6308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int MaxExposureCompensation
			{
				get
				{
					return getMaxExposureCompensation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMaxExposureCompensation6309;
			public virtual int getMaxExposureCompensation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getMaxExposureCompensation6309);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMaxExposureCompensation6309);
			}
			public new int MinExposureCompensation
			{
				get
				{
					return getMinExposureCompensation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMinExposureCompensation6310;
			public virtual int getMinExposureCompensation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getMinExposureCompensation6310);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMinExposureCompensation6310);
			}
			public new float ExposureCompensationStep
			{
				get
				{
					return getExposureCompensationStep();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExposureCompensationStep6311;
			public virtual float getExposureCompensationStep() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getExposureCompensationStep6311);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getExposureCompensationStep6311);
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
			internal static global::MonoJavaBridge.MethodId _getZoom6312;
			public virtual int getZoom() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getZoom6312);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getZoom6312);
			}
			internal static global::MonoJavaBridge.MethodId _setZoom6313;
			public virtual void setZoom(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setZoom6313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setZoom6313, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isZoomSupported6314;
			public virtual bool isZoomSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._isZoomSupported6314);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._isZoomSupported6314);
			}
			public new int MaxZoom
			{
				get
				{
					return getMaxZoom();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMaxZoom6315;
			public virtual int getMaxZoom() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getMaxZoom6315);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMaxZoom6315);
			}
			public new global::java.util.List ZoomRatios
			{
				get
				{
					return getZoomRatios();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getZoomRatios6316;
			public virtual global::java.util.List getZoomRatios() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getZoomRatios6316)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getZoomRatios6316)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _isSmoothZoomSupported6317;
			public virtual bool isSmoothZoomSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._isSmoothZoomSupported6317);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._isSmoothZoomSupported6317);
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Parameters.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Parameters"));
				global::android.hardware.Camera.Parameters._get6250 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._getInt6251 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I");
				global::android.hardware.Camera.Parameters._remove6252 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set6253 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set6254 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V");
				global::android.hardware.Camera.Parameters._flatten6255 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._unflatten6256 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._setPreviewSize6257 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPreviewSize6258 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPreviewSizes6259 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailSize6260 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailSize6261 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes6262 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedJpegThumbnailSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailQuality6263 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailQuality6264 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I");
				global::android.hardware.Camera.Parameters._setJpegQuality6265 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegQuality6266 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I");
				global::android.hardware.Camera.Parameters._setPreviewFrameRate6267 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFrameRate6268 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates6269 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPreviewFormat6270 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFormat6271 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFormats6272 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureSize6273 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPictureSize6274 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPictureSizes6275 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureFormat6276 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPictureFormat6277 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPictureFormats6278 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setRotation6279 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V");
				global::android.hardware.Camera.Parameters._setGpsLatitude6280 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsLongitude6281 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsAltitude6282 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsTimestamp6283 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V");
				global::android.hardware.Camera.Parameters._setGpsProcessingMethod6284 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsProcessingMethod", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._removeGpsData6285 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V");
				global::android.hardware.Camera.Parameters._getWhiteBalance6286 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setWhiteBalance6287 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedWhiteBalance6288 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getColorEffect6289 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setColorEffect6290 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedColorEffects6291 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getAntibanding6292 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setAntibanding6293 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedAntibanding6294 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getSceneMode6295 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setSceneMode6296 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedSceneModes6297 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFlashMode6298 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFlashMode6299 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFlashModes6300 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocusMode6301 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFocusMode6302 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFocusModes6303 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocalLength6304 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getFocalLength", "()F");
				global::android.hardware.Camera.Parameters._getHorizontalViewAngle6305 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getHorizontalViewAngle", "()F");
				global::android.hardware.Camera.Parameters._getVerticalViewAngle6306 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getVerticalViewAngle", "()F");
				global::android.hardware.Camera.Parameters._getExposureCompensation6307 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._setExposureCompensation6308 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setExposureCompensation", "(I)V");
				global::android.hardware.Camera.Parameters._getMaxExposureCompensation6309 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getMaxExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._getMinExposureCompensation6310 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getMinExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._getExposureCompensationStep6311 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensationStep", "()F");
				global::android.hardware.Camera.Parameters._getZoom6312 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getZoom", "()I");
				global::android.hardware.Camera.Parameters._setZoom6313 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setZoom", "(I)V");
				global::android.hardware.Camera.Parameters._isZoomSupported6314 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "isZoomSupported", "()Z");
				global::android.hardware.Camera.Parameters._getMaxZoom6315 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getMaxZoom", "()I");
				global::android.hardware.Camera.Parameters._getZoomRatios6316 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getZoomRatios", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._isSmoothZoomSupported6317 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "isSmoothZoomSupported", "()Z");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.PictureCallback_))]
		public interface PictureCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onPictureTaken(byte[] arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.PictureCallback))]
		public sealed partial class PictureCallback_ : java.lang.Object, PictureCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PictureCallback_()
			{
				InitJNI();
			}
			internal PictureCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPictureTaken6365;
			 void android.hardware.Camera.PictureCallback.onPictureTaken(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.PictureCallback_._onPictureTaken6365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.PictureCallback_.staticClass, global::android.hardware.Camera.PictureCallback_._onPictureTaken6365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PictureCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PictureCallback"));
				global::android.hardware.Camera.PictureCallback_._onPictureTaken6365 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PictureCallback_.staticClass, "onPictureTaken", "([BLandroid/hardware/Camera;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.PreviewCallback_))]
		public interface PreviewCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.PreviewCallback))]
		public sealed partial class PreviewCallback_ : java.lang.Object, PreviewCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static PreviewCallback_()
			{
				InitJNI();
			}
			internal PreviewCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onPreviewFrame6366;
			 void android.hardware.Camera.PreviewCallback.onPreviewFrame(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.PreviewCallback_._onPreviewFrame6366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.PreviewCallback_.staticClass, global::android.hardware.Camera.PreviewCallback_._onPreviewFrame6366, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PreviewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PreviewCallback"));
				global::android.hardware.Camera.PreviewCallback_._onPreviewFrame6366 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PreviewCallback_.staticClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.hardware.Camera.ShutterCallback_))]
		public interface ShutterCallback  : global::MonoJavaBridge.IJavaObject 
		{
			void onShutter();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.hardware.Camera.ShutterCallback))]
		public sealed partial class ShutterCallback_ : java.lang.Object, ShutterCallback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ShutterCallback_()
			{
				InitJNI();
			}
			internal ShutterCallback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onShutter6367;
			 void android.hardware.Camera.ShutterCallback.onShutter() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.ShutterCallback_._onShutter6367);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.ShutterCallback_.staticClass, global::android.hardware.Camera.ShutterCallback_._onShutter6367);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ShutterCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ShutterCallback"));
				global::android.hardware.Camera.ShutterCallback_._onShutter6367 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ShutterCallback_.staticClass, "onShutter", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Size : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Size()
			{
				InitJNI();
			}
			protected Size(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _equals6368;
			public override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Size._equals6368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._equals6368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _hashCode6369;
			public override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Size._hashCode6369);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._hashCode6369);
			}
			internal static global::MonoJavaBridge.MethodId _Size6370;
			public Size(android.hardware.Camera arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._Size6370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _width6371;
			public int width
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _width6371);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height6372;
			public int height
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return @__env.GetIntField(this.JvmHandle, _height6372);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Size.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Size"));
				global::android.hardware.Camera.Size._equals6368 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.hardware.Camera.Size._hashCode6369 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "hashCode", "()I");
				global::android.hardware.Camera.Size._Size6370 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V");
				global::android.hardware.Camera.Size._width6371 = @__env.GetFieldIDNoThrow(global::android.hardware.Camera.Size.staticClass, "width", "I");
				global::android.hardware.Camera.Size._height6372 = @__env.GetFieldIDNoThrow(global::android.hardware.Camera.Size.staticClass, "height", "I");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize6373;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._finalize6373);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._finalize6373);
		}
		internal static global::MonoJavaBridge.MethodId _lock6374;
		public virtual void @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._lock6374);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._lock6374);
		}
		internal static global::MonoJavaBridge.MethodId _release6375;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._release6375);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._release6375);
		}
		internal static global::MonoJavaBridge.MethodId _open6376;
		public static global::android.hardware.Camera open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.hardware.Camera.staticClass, global::android.hardware.Camera._open6376)) as android.hardware.Camera;
		}
		internal static global::MonoJavaBridge.MethodId _unlock6377;
		public virtual void unlock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._unlock6377);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._unlock6377);
		}
		internal static global::MonoJavaBridge.MethodId _getParameters6378;
		public virtual global::android.hardware.Camera.Parameters getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera._getParameters6378)) as android.hardware.Camera.Parameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._getParameters6378)) as android.hardware.Camera.Parameters;
		}
		internal static global::MonoJavaBridge.MethodId _reconnect6379;
		public virtual void reconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._reconnect6379);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._reconnect6379);
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewDisplay6380;
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setPreviewDisplay6380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewDisplay6380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startPreview6381;
		public virtual void startPreview() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._startPreview6381);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startPreview6381);
		}
		internal static global::MonoJavaBridge.MethodId _stopPreview6382;
		public virtual void stopPreview() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._stopPreview6382);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopPreview6382);
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewCallback6383;
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setPreviewCallback6383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallback6383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOneShotPreviewCallback6384;
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setOneShotPreviewCallback6384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setOneShotPreviewCallback6384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewCallbackWithBuffer6385;
		public virtual void setPreviewCallbackWithBuffer(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setPreviewCallbackWithBuffer6385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallbackWithBuffer6385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCallbackBuffer6386;
		public virtual void addCallbackBuffer(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._addCallbackBuffer6386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._addCallbackBuffer6386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _autoFocus6387;
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._autoFocus6387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._autoFocus6387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancelAutoFocus6388;
		public virtual void cancelAutoFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._cancelAutoFocus6388);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._cancelAutoFocus6388);
		}
		internal static global::MonoJavaBridge.MethodId _takePicture6389;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._takePicture6389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture6389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _takePicture6390;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._takePicture6390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture6390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startSmoothZoom6391;
		public virtual void startSmoothZoom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._startSmoothZoom6391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startSmoothZoom6391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSmoothZoom6392;
		public virtual void stopSmoothZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._stopSmoothZoom6392);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopSmoothZoom6392);
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayOrientation6393;
		public virtual void setDisplayOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setDisplayOrientation6393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setDisplayOrientation6393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomChangeListener6394;
		public virtual void setZoomChangeListener(android.hardware.Camera.OnZoomChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setZoomChangeListener6394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setZoomChangeListener6394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorCallback6395;
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setErrorCallback6395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setErrorCallback6395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParameters6396;
		public virtual void setParameters(android.hardware.Camera.Parameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setParameters6396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setParameters6396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.hardware.Camera.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera"));
			global::android.hardware.Camera._finalize6373 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "finalize", "()V");
			global::android.hardware.Camera._lock6374 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "@lock", "()V");
			global::android.hardware.Camera._release6375 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "release", "()V");
			global::android.hardware.Camera._open6376 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;");
			global::android.hardware.Camera._unlock6377 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "unlock", "()V");
			global::android.hardware.Camera._getParameters6378 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;");
			global::android.hardware.Camera._reconnect6379 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "reconnect", "()V");
			global::android.hardware.Camera._setPreviewDisplay6380 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.hardware.Camera._startPreview6381 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "startPreview", "()V");
			global::android.hardware.Camera._stopPreview6382 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "stopPreview", "()V");
			global::android.hardware.Camera._setPreviewCallback6383 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setOneShotPreviewCallback6384 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setPreviewCallbackWithBuffer6385 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._addCallbackBuffer6386 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "addCallbackBuffer", "([B)V");
			global::android.hardware.Camera._autoFocus6387 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V");
			global::android.hardware.Camera._cancelAutoFocus6388 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V");
			global::android.hardware.Camera._takePicture6389 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._takePicture6390 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._startSmoothZoom6391 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "startSmoothZoom", "(I)V");
			global::android.hardware.Camera._stopSmoothZoom6392 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "stopSmoothZoom", "()V");
			global::android.hardware.Camera._setDisplayOrientation6393 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setDisplayOrientation", "(I)V");
			global::android.hardware.Camera._setZoomChangeListener6394 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V");
			global::android.hardware.Camera._setErrorCallback6395 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V");
			global::android.hardware.Camera._setParameters6396 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V");
		}
	}
}
