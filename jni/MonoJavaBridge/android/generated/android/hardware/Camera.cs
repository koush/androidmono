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
			internal static global::MonoJavaBridge.MethodId _onAutoFocus4253;
			 void android.hardware.Camera.AutoFocusCallback.onAutoFocus(bool arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus4253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.AutoFocusCallback_.staticClass, global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus4253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.AutoFocusCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$AutoFocusCallback"));
				global::android.hardware.Camera.AutoFocusCallback_._onAutoFocus4253 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.AutoFocusCallback_.staticClass, "onAutoFocus", "(ZLandroid/hardware/Camera;)V");
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
			internal static global::MonoJavaBridge.MethodId _onError4254;
			 void android.hardware.Camera.ErrorCallback.onError(int arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.ErrorCallback_._onError4254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.ErrorCallback_.staticClass, global::android.hardware.Camera.ErrorCallback_._onError4254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ErrorCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ErrorCallback"));
				global::android.hardware.Camera.ErrorCallback_._onError4254 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ErrorCallback_.staticClass, "onError", "(ILandroid/hardware/Camera;)V");
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
			internal static global::MonoJavaBridge.MethodId _onZoomChange4255;
			 void android.hardware.Camera.OnZoomChangeListener.onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange4255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.OnZoomChangeListener_.staticClass, global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange4255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.OnZoomChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$OnZoomChangeListener"));
				global::android.hardware.Camera.OnZoomChangeListener_._onZoomChange4255 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.OnZoomChangeListener_.staticClass, "onZoomChange", "(IZLandroid/hardware/Camera;)V");
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
			internal static global::MonoJavaBridge.MethodId _get4256;
			public virtual global::java.lang.String get(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._get4256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._get4256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getInt4257;
			public virtual int getInt(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getInt4257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getInt4257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _remove4258;
			public virtual void remove(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._remove4258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._remove4258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _set4259;
			public virtual void set(java.lang.String arg0, java.lang.String arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._set4259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set4259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _set4260;
			public virtual void set(java.lang.String arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._set4260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set4260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _flatten4261;
			public virtual global::java.lang.String flatten() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._flatten4261)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._flatten4261)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _unflatten4262;
			public virtual void unflatten(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._unflatten4262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._unflatten4262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewSize4263;
			public virtual void setPreviewSize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPreviewSize4263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewSize4263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PreviewSize
			{
				get
				{
					return getPreviewSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPreviewSize4264;
			public virtual global::android.hardware.Camera.Size getPreviewSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPreviewSize4264)) as android.hardware.Camera.Size;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewSize4264)) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPreviewSizes
			{
				get
				{
					return getSupportedPreviewSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewSizes4265;
			public virtual global::java.util.List getSupportedPreviewSizes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes4265)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes4265)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setJpegThumbnailSize4266;
			public virtual void setJpegThumbnailSize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setJpegThumbnailSize4266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailSize4266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size JpegThumbnailSize
			{
				get
				{
					return getJpegThumbnailSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getJpegThumbnailSize4267;
			public virtual global::android.hardware.Camera.Size getJpegThumbnailSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getJpegThumbnailSize4267)) as android.hardware.Camera.Size;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailSize4267)) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedJpegThumbnailSizes
			{
				get
				{
					return getSupportedJpegThumbnailSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedJpegThumbnailSizes4268;
			public virtual global::java.util.List getSupportedJpegThumbnailSizes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes4268)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes4268)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setJpegThumbnailQuality4269;
			public virtual void setJpegThumbnailQuality(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality4269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality4269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getJpegThumbnailQuality4270;
			public virtual int getJpegThumbnailQuality() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality4270);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality4270);
			}
			internal static global::MonoJavaBridge.MethodId _setJpegQuality4271;
			public virtual void setJpegQuality(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setJpegQuality4271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegQuality4271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getJpegQuality4272;
			public virtual int getJpegQuality() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getJpegQuality4272);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegQuality4272);
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewFrameRate4273;
			public virtual void setPreviewFrameRate(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPreviewFrameRate4273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFrameRate4273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getPreviewFrameRate4274;
			public virtual int getPreviewFrameRate() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPreviewFrameRate4274);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFrameRate4274);
			}
			public new global::java.util.List SupportedPreviewFrameRates
			{
				get
				{
					return getSupportedPreviewFrameRates();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewFrameRates4275;
			public virtual global::java.util.List getSupportedPreviewFrameRates() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates4275)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates4275)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPreviewFormat4276;
			public virtual void setPreviewFormat(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPreviewFormat4276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFormat4276, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getPreviewFormat4277;
			public virtual int getPreviewFormat() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPreviewFormat4277);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFormat4277);
			}
			public new global::java.util.List SupportedPreviewFormats
			{
				get
				{
					return getSupportedPreviewFormats();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPreviewFormats4278;
			public virtual global::java.util.List getSupportedPreviewFormats() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats4278)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats4278)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPictureSize4279;
			public virtual void setPictureSize(int arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPictureSize4279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureSize4279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			public new global::android.hardware.Camera.Size PictureSize
			{
				get
				{
					return getPictureSize();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getPictureSize4280;
			public virtual global::android.hardware.Camera.Size getPictureSize() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPictureSize4280)) as android.hardware.Camera.Size;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureSize4280)) as android.hardware.Camera.Size;
			}
			public new global::java.util.List SupportedPictureSizes
			{
				get
				{
					return getSupportedPictureSizes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPictureSizes4281;
			public virtual global::java.util.List getSupportedPictureSizes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPictureSizes4281)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureSizes4281)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setPictureFormat4282;
			public virtual void setPictureFormat(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setPictureFormat4282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureFormat4282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			internal static global::MonoJavaBridge.MethodId _getPictureFormat4283;
			public virtual int getPictureFormat() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getPictureFormat4283);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureFormat4283);
			}
			public new global::java.util.List SupportedPictureFormats
			{
				get
				{
					return getSupportedPictureFormats();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedPictureFormats4284;
			public virtual global::java.util.List getSupportedPictureFormats() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedPictureFormats4284)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureFormats4284)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _setRotation4285;
			public virtual void setRotation(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setRotation4285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setRotation4285, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsLatitude4286;
			public virtual void setGpsLatitude(double arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsLatitude4286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLatitude4286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsLongitude4287;
			public virtual void setGpsLongitude(double arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsLongitude4287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLongitude4287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsAltitude4288;
			public virtual void setGpsAltitude(double arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsAltitude4288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsAltitude4288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsTimestamp4289;
			public virtual void setGpsTimestamp(long arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsTimestamp4289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsTimestamp4289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _setGpsProcessingMethod4290;
			public virtual void setGpsProcessingMethod(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setGpsProcessingMethod4290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsProcessingMethod4290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _removeGpsData4291;
			public virtual void removeGpsData() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._removeGpsData4291);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._removeGpsData4291);
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
			internal static global::MonoJavaBridge.MethodId _getWhiteBalance4292;
			public virtual global::java.lang.String getWhiteBalance() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getWhiteBalance4292)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getWhiteBalance4292)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setWhiteBalance4293;
			public virtual void setWhiteBalance(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setWhiteBalance4293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setWhiteBalance4293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedWhiteBalance
			{
				get
				{
					return getSupportedWhiteBalance();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedWhiteBalance4294;
			public virtual global::java.util.List getSupportedWhiteBalance() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance4294)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance4294)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getColorEffect4295;
			public virtual global::java.lang.String getColorEffect() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getColorEffect4295)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getColorEffect4295)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setColorEffect4296;
			public virtual void setColorEffect(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setColorEffect4296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setColorEffect4296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedColorEffects
			{
				get
				{
					return getSupportedColorEffects();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedColorEffects4297;
			public virtual global::java.util.List getSupportedColorEffects() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedColorEffects4297)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedColorEffects4297)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getAntibanding4298;
			public virtual global::java.lang.String getAntibanding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getAntibanding4298)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getAntibanding4298)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setAntibanding4299;
			public virtual void setAntibanding(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setAntibanding4299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setAntibanding4299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedAntibanding
			{
				get
				{
					return getSupportedAntibanding();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedAntibanding4300;
			public virtual global::java.util.List getSupportedAntibanding() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedAntibanding4300)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedAntibanding4300)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getSceneMode4301;
			public virtual global::java.lang.String getSceneMode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSceneMode4301)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSceneMode4301)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setSceneMode4302;
			public virtual void setSceneMode(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setSceneMode4302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setSceneMode4302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedSceneModes
			{
				get
				{
					return getSupportedSceneModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedSceneModes4303;
			public virtual global::java.util.List getSupportedSceneModes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedSceneModes4303)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedSceneModes4303)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getFlashMode4304;
			public virtual global::java.lang.String getFlashMode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getFlashMode4304)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFlashMode4304)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setFlashMode4305;
			public virtual void setFlashMode(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setFlashMode4305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFlashMode4305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFlashModes
			{
				get
				{
					return getSupportedFlashModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedFlashModes4306;
			public virtual global::java.util.List getSupportedFlashModes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedFlashModes4306)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFlashModes4306)) as java.util.List;
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
			internal static global::MonoJavaBridge.MethodId _getFocusMode4307;
			public virtual global::java.lang.String getFocusMode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getFocusMode4307)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocusMode4307)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _setFocusMode4308;
			public virtual void setFocusMode(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setFocusMode4308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFocusMode4308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new global::java.util.List SupportedFocusModes
			{
				get
				{
					return getSupportedFocusModes();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getSupportedFocusModes4309;
			public virtual global::java.util.List getSupportedFocusModes() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getSupportedFocusModes4309)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFocusModes4309)) as java.util.List;
			}
			public new float FocalLength
			{
				get
				{
					return getFocalLength();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFocalLength4310;
			public virtual float getFocalLength() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getFocalLength4310);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocalLength4310);
			}
			public new float HorizontalViewAngle
			{
				get
				{
					return getHorizontalViewAngle();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getHorizontalViewAngle4311;
			public virtual float getHorizontalViewAngle() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getHorizontalViewAngle4311);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getHorizontalViewAngle4311);
			}
			public new float VerticalViewAngle
			{
				get
				{
					return getVerticalViewAngle();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getVerticalViewAngle4312;
			public virtual float getVerticalViewAngle() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getVerticalViewAngle4312);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getVerticalViewAngle4312);
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
			internal static global::MonoJavaBridge.MethodId _getExposureCompensation4313;
			public virtual int getExposureCompensation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getExposureCompensation4313);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getExposureCompensation4313);
			}
			internal static global::MonoJavaBridge.MethodId _setExposureCompensation4314;
			public virtual void setExposureCompensation(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setExposureCompensation4314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setExposureCompensation4314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			public new int MaxExposureCompensation
			{
				get
				{
					return getMaxExposureCompensation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMaxExposureCompensation4315;
			public virtual int getMaxExposureCompensation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getMaxExposureCompensation4315);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMaxExposureCompensation4315);
			}
			public new int MinExposureCompensation
			{
				get
				{
					return getMinExposureCompensation();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMinExposureCompensation4316;
			public virtual int getMinExposureCompensation() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getMinExposureCompensation4316);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMinExposureCompensation4316);
			}
			public new float ExposureCompensationStep
			{
				get
				{
					return getExposureCompensationStep();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getExposureCompensationStep4317;
			public virtual float getExposureCompensationStep() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getExposureCompensationStep4317);
				else
					return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getExposureCompensationStep4317);
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
			internal static global::MonoJavaBridge.MethodId _getZoom4318;
			public virtual int getZoom() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getZoom4318);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getZoom4318);
			}
			internal static global::MonoJavaBridge.MethodId _setZoom4319;
			public virtual void setZoom(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._setZoom4319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setZoom4319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _isZoomSupported4320;
			public virtual bool isZoomSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._isZoomSupported4320);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._isZoomSupported4320);
			}
			public new int MaxZoom
			{
				get
				{
					return getMaxZoom();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getMaxZoom4321;
			public virtual int getMaxZoom() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getMaxZoom4321);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMaxZoom4321);
			}
			public new global::java.util.List ZoomRatios
			{
				get
				{
					return getZoomRatios();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getZoomRatios4322;
			public virtual global::java.util.List getZoomRatios() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._getZoomRatios4322)) as java.util.List;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getZoomRatios4322)) as java.util.List;
			}
			internal static global::MonoJavaBridge.MethodId _isSmoothZoomSupported4323;
			public virtual bool isSmoothZoomSupported() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters._isSmoothZoomSupported4323);
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._isSmoothZoomSupported4323);
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
				global::android.hardware.Camera.Parameters._get4256 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._getInt4257 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I");
				global::android.hardware.Camera.Parameters._remove4258 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set4259 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set4260 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V");
				global::android.hardware.Camera.Parameters._flatten4261 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._unflatten4262 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._setPreviewSize4263 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPreviewSize4264 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPreviewSizes4265 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailSize4266 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailSize4267 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes4268 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedJpegThumbnailSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailQuality4269 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailQuality4270 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I");
				global::android.hardware.Camera.Parameters._setJpegQuality4271 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegQuality4272 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I");
				global::android.hardware.Camera.Parameters._setPreviewFrameRate4273 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFrameRate4274 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates4275 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPreviewFormat4276 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFormat4277 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFormats4278 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureSize4279 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPictureSize4280 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPictureSizes4281 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureFormat4282 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPictureFormat4283 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPictureFormats4284 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setRotation4285 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V");
				global::android.hardware.Camera.Parameters._setGpsLatitude4286 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsLongitude4287 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsAltitude4288 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsTimestamp4289 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V");
				global::android.hardware.Camera.Parameters._setGpsProcessingMethod4290 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setGpsProcessingMethod", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._removeGpsData4291 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V");
				global::android.hardware.Camera.Parameters._getWhiteBalance4292 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setWhiteBalance4293 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedWhiteBalance4294 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getColorEffect4295 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setColorEffect4296 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedColorEffects4297 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getAntibanding4298 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setAntibanding4299 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedAntibanding4300 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getSceneMode4301 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setSceneMode4302 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedSceneModes4303 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFlashMode4304 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFlashMode4305 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFlashModes4306 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocusMode4307 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFocusMode4308 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFocusModes4309 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocalLength4310 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getFocalLength", "()F");
				global::android.hardware.Camera.Parameters._getHorizontalViewAngle4311 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getHorizontalViewAngle", "()F");
				global::android.hardware.Camera.Parameters._getVerticalViewAngle4312 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getVerticalViewAngle", "()F");
				global::android.hardware.Camera.Parameters._getExposureCompensation4313 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._setExposureCompensation4314 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setExposureCompensation", "(I)V");
				global::android.hardware.Camera.Parameters._getMaxExposureCompensation4315 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getMaxExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._getMinExposureCompensation4316 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getMinExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._getExposureCompensationStep4317 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensationStep", "()F");
				global::android.hardware.Camera.Parameters._getZoom4318 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getZoom", "()I");
				global::android.hardware.Camera.Parameters._setZoom4319 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "setZoom", "(I)V");
				global::android.hardware.Camera.Parameters._isZoomSupported4320 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "isZoomSupported", "()Z");
				global::android.hardware.Camera.Parameters._getMaxZoom4321 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getMaxZoom", "()I");
				global::android.hardware.Camera.Parameters._getZoomRatios4322 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "getZoomRatios", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._isSmoothZoomSupported4323 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Parameters.staticClass, "isSmoothZoomSupported", "()Z");
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
			internal static global::MonoJavaBridge.MethodId _onPictureTaken4324;
			 void android.hardware.Camera.PictureCallback.onPictureTaken(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.PictureCallback_._onPictureTaken4324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.PictureCallback_.staticClass, global::android.hardware.Camera.PictureCallback_._onPictureTaken4324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PictureCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PictureCallback"));
				global::android.hardware.Camera.PictureCallback_._onPictureTaken4324 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PictureCallback_.staticClass, "onPictureTaken", "([BLandroid/hardware/Camera;)V");
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
			internal static global::MonoJavaBridge.MethodId _onPreviewFrame4325;
			 void android.hardware.Camera.PreviewCallback.onPreviewFrame(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.PreviewCallback_._onPreviewFrame4325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.PreviewCallback_.staticClass, global::android.hardware.Camera.PreviewCallback_._onPreviewFrame4325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.PreviewCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$PreviewCallback"));
				global::android.hardware.Camera.PreviewCallback_._onPreviewFrame4325 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.PreviewCallback_.staticClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
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
			internal static global::MonoJavaBridge.MethodId _onShutter4326;
			 void android.hardware.Camera.ShutterCallback.onShutter() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera.ShutterCallback_._onShutter4326);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.ShutterCallback_.staticClass, global::android.hardware.Camera.ShutterCallback_._onShutter4326);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.ShutterCallback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$ShutterCallback"));
				global::android.hardware.Camera.ShutterCallback_._onShutter4326 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.ShutterCallback_.staticClass, "onShutter", "()V");
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
			internal static global::MonoJavaBridge.MethodId _equals4327;
			public override bool equals(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Size._equals4327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._equals4327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _hashCode4328;
			public override int hashCode() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.hardware.Camera.Size._hashCode4328);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._hashCode4328);
			}
			internal static global::MonoJavaBridge.MethodId _Size4329;
			public Size(android.hardware.Camera arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._Size4329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _width4330;
			public int width
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _height4331;
			public int height
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.hardware.Camera.Size.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/hardware/Camera$Size"));
				global::android.hardware.Camera.Size._equals4327 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.hardware.Camera.Size._hashCode4328 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "hashCode", "()I");
				global::android.hardware.Camera.Size._Size4329 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4332;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._finalize4332);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._finalize4332);
		}
		internal static global::MonoJavaBridge.MethodId _lock4333;
		public virtual void @lock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._lock4333);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._lock4333);
		}
		internal static global::MonoJavaBridge.MethodId _release4334;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._release4334);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._release4334);
		}
		internal static global::MonoJavaBridge.MethodId _open4335;
		public static global::android.hardware.Camera open() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.hardware.Camera.staticClass, global::android.hardware.Camera._open4335)) as android.hardware.Camera;
		}
		internal static global::MonoJavaBridge.MethodId _unlock4336;
		public virtual void unlock() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._unlock4336);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._unlock4336);
		}
		internal static global::MonoJavaBridge.MethodId _getParameters4337;
		public virtual global::android.hardware.Camera.Parameters getParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.hardware.Camera._getParameters4337)) as android.hardware.Camera.Parameters;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._getParameters4337)) as android.hardware.Camera.Parameters;
		}
		internal static global::MonoJavaBridge.MethodId _reconnect4338;
		public virtual void reconnect() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._reconnect4338);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._reconnect4338);
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewDisplay4339;
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setPreviewDisplay4339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewDisplay4339, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startPreview4340;
		public virtual void startPreview() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._startPreview4340);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startPreview4340);
		}
		internal static global::MonoJavaBridge.MethodId _stopPreview4341;
		public virtual void stopPreview() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._stopPreview4341);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopPreview4341);
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewCallback4342;
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setPreviewCallback4342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallback4342, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setOneShotPreviewCallback4343;
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setOneShotPreviewCallback4343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setOneShotPreviewCallback4343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPreviewCallbackWithBuffer4344;
		public virtual void setPreviewCallbackWithBuffer(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setPreviewCallbackWithBuffer4344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallbackWithBuffer4344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addCallbackBuffer4345;
		public virtual void addCallbackBuffer(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._addCallbackBuffer4345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._addCallbackBuffer4345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _autoFocus4346;
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._autoFocus4346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._autoFocus4346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _cancelAutoFocus4347;
		public virtual void cancelAutoFocus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._cancelAutoFocus4347);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._cancelAutoFocus4347);
		}
		internal static global::MonoJavaBridge.MethodId _takePicture4348;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._takePicture4348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture4348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _takePicture4349;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._takePicture4349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture4349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startSmoothZoom4350;
		public virtual void startSmoothZoom(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._startSmoothZoom4350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startSmoothZoom4350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stopSmoothZoom4351;
		public virtual void stopSmoothZoom() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._stopSmoothZoom4351);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopSmoothZoom4351);
		}
		internal static global::MonoJavaBridge.MethodId _setDisplayOrientation4352;
		public virtual void setDisplayOrientation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setDisplayOrientation4352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setDisplayOrientation4352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setZoomChangeListener4353;
		public virtual void setZoomChangeListener(android.hardware.Camera.OnZoomChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setZoomChangeListener4353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setZoomChangeListener4353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setErrorCallback4354;
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setErrorCallback4354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setErrorCallback4354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setParameters4355;
		public virtual void setParameters(android.hardware.Camera.Parameters arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.hardware.Camera._setParameters4355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setParameters4355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.hardware.Camera._finalize4332 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "finalize", "()V");
			global::android.hardware.Camera._lock4333 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "@lock", "()V");
			global::android.hardware.Camera._release4334 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "release", "()V");
			global::android.hardware.Camera._open4335 = @__env.GetStaticMethodIDNoThrow(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;");
			global::android.hardware.Camera._unlock4336 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "unlock", "()V");
			global::android.hardware.Camera._getParameters4337 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;");
			global::android.hardware.Camera._reconnect4338 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "reconnect", "()V");
			global::android.hardware.Camera._setPreviewDisplay4339 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.hardware.Camera._startPreview4340 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "startPreview", "()V");
			global::android.hardware.Camera._stopPreview4341 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "stopPreview", "()V");
			global::android.hardware.Camera._setPreviewCallback4342 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setOneShotPreviewCallback4343 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setPreviewCallbackWithBuffer4344 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._addCallbackBuffer4345 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "addCallbackBuffer", "([B)V");
			global::android.hardware.Camera._autoFocus4346 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V");
			global::android.hardware.Camera._cancelAutoFocus4347 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V");
			global::android.hardware.Camera._takePicture4348 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._takePicture4349 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._startSmoothZoom4350 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "startSmoothZoom", "(I)V");
			global::android.hardware.Camera._stopSmoothZoom4351 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "stopSmoothZoom", "()V");
			global::android.hardware.Camera._setDisplayOrientation4352 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setDisplayOrientation", "(I)V");
			global::android.hardware.Camera._setZoomChangeListener4353 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V");
			global::android.hardware.Camera._setErrorCallback4354 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V");
			global::android.hardware.Camera._setParameters4355 = @__env.GetMethodIDNoThrow(global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V");
		}
	}
}
