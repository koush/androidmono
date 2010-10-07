namespace android.hardware
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Camera : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Camera()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.hardware.Camera(@__env);
			}
		}
		protected Camera(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface AutoFocusCallback 
		{
			void onAutoFocus(bool arg0, android.hardware.Camera arg1);
		}

		public partial class AutoFocusCallback_
		{
			public static global::java.lang.Class _class
			{
				get { return __AutoFocusCallback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __AutoFocusCallback : java.lang.Object, AutoFocusCallback
		{
			internal static global::java.lang.Class staticClass;
			static __AutoFocusCallback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.__AutoFocusCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.__AutoFocusCallback(@__env);
				}
			}
			internal __AutoFocusCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onAutoFocus4052;
			 void android.hardware.Camera.AutoFocusCallback.onAutoFocus(bool arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__AutoFocusCallback._onAutoFocus4052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__AutoFocusCallback.staticClass, global::android.hardware.Camera.__AutoFocusCallback._onAutoFocus4052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__AutoFocusCallback.staticClass = @__class;
				global::android.hardware.Camera.__AutoFocusCallback._onAutoFocus4052 = @__env.GetMethodID(global::android.hardware.Camera.__AutoFocusCallback.staticClass, "android.hardware.Camera.AutoFocusCallback.onAutoFocus", "(ZLandroid/hardware/Camera;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ErrorCallback 
		{
			void onError(int arg0, android.hardware.Camera arg1);
		}

		public partial class ErrorCallback_
		{
			public static global::java.lang.Class _class
			{
				get { return __ErrorCallback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ErrorCallback : java.lang.Object, ErrorCallback
		{
			internal static global::java.lang.Class staticClass;
			static __ErrorCallback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.__ErrorCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.__ErrorCallback(@__env);
				}
			}
			internal __ErrorCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onError4053;
			 void android.hardware.Camera.ErrorCallback.onError(int arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__ErrorCallback._onError4053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__ErrorCallback.staticClass, global::android.hardware.Camera.__ErrorCallback._onError4053, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__ErrorCallback.staticClass = @__class;
				global::android.hardware.Camera.__ErrorCallback._onError4053 = @__env.GetMethodID(global::android.hardware.Camera.__ErrorCallback.staticClass, "android.hardware.Camera.ErrorCallback.onError", "(ILandroid/hardware/Camera;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnZoomChangeListener 
		{
			void onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2);
		}

		public partial class OnZoomChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnZoomChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnZoomChangeListener : java.lang.Object, OnZoomChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnZoomChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.__OnZoomChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.__OnZoomChangeListener(@__env);
				}
			}
			internal __OnZoomChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onZoomChange4054;
			 void android.hardware.Camera.OnZoomChangeListener.onZoomChange(int arg0, bool arg1, android.hardware.Camera arg2) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__OnZoomChangeListener._onZoomChange4054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__OnZoomChangeListener.staticClass, global::android.hardware.Camera.__OnZoomChangeListener._onZoomChange4054, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__OnZoomChangeListener.staticClass = @__class;
				global::android.hardware.Camera.__OnZoomChangeListener._onZoomChange4054 = @__env.GetMethodID(global::android.hardware.Camera.__OnZoomChangeListener.staticClass, "android.hardware.Camera.OnZoomChangeListener.onZoomChange", "(IZLandroid/hardware/Camera;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Parameters : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Parameters()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.Parameters), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.Parameters(@__env);
				}
			}
			protected Parameters(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _get4055;
			public virtual global::java.lang.String get(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._get4055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._get4055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getInt4056;
			public virtual int getInt(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getInt4056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getInt4056, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _remove4057;
			public virtual void remove(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._remove4057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._remove4057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _set4058;
			public virtual void set(java.lang.String arg0, java.lang.String arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._set4058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set4058, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _set4059;
			public virtual void set(java.lang.String arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._set4059, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set4059, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _flatten4060;
			public virtual global::java.lang.String flatten() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._flatten4060));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._flatten4060));
			}
			internal static global::net.sf.jni4net.jni.MethodId _unflatten4061;
			public virtual void unflatten(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._unflatten4061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._unflatten4061, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewSize4062;
			public virtual void setPreviewSize(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPreviewSize4062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewSize4062, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewSize4063;
			public virtual global::android.hardware.Camera.Size getPreviewSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getPreviewSize4063));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewSize4063));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewSizes4064;
			public virtual global::java.util.List getSupportedPreviewSizes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes4064));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes4064));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setJpegThumbnailSize4065;
			public virtual void setJpegThumbnailSize(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setJpegThumbnailSize4065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailSize4065, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getJpegThumbnailSize4066;
			public virtual global::android.hardware.Camera.Size getJpegThumbnailSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getJpegThumbnailSize4066));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailSize4066));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedJpegThumbnailSizes4067;
			public virtual global::java.util.List getSupportedJpegThumbnailSizes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes4067));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes4067));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setJpegThumbnailQuality4068;
			public virtual void setJpegThumbnailQuality(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality4068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality4068, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getJpegThumbnailQuality4069;
			public virtual int getJpegThumbnailQuality() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality4069);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality4069);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setJpegQuality4070;
			public virtual void setJpegQuality(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setJpegQuality4070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegQuality4070, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getJpegQuality4071;
			public virtual int getJpegQuality() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getJpegQuality4071);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegQuality4071);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewFrameRate4072;
			public virtual void setPreviewFrameRate(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPreviewFrameRate4072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFrameRate4072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewFrameRate4073;
			public virtual int getPreviewFrameRate() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getPreviewFrameRate4073);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFrameRate4073);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewFrameRates4074;
			public virtual global::java.util.List getSupportedPreviewFrameRates() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates4074));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates4074));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewFormat4075;
			public virtual void setPreviewFormat(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPreviewFormat4075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFormat4075, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewFormat4076;
			public virtual int getPreviewFormat() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getPreviewFormat4076);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFormat4076);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewFormats4077;
			public virtual global::java.util.List getSupportedPreviewFormats() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats4077));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats4077));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPictureSize4078;
			public virtual void setPictureSize(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPictureSize4078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureSize4078, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPictureSize4079;
			public virtual global::android.hardware.Camera.Size getPictureSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getPictureSize4079));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureSize4079));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPictureSizes4080;
			public virtual global::java.util.List getSupportedPictureSizes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPictureSizes4080));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureSizes4080));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPictureFormat4081;
			public virtual void setPictureFormat(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPictureFormat4081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureFormat4081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPictureFormat4082;
			public virtual int getPictureFormat() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getPictureFormat4082);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureFormat4082);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPictureFormats4083;
			public virtual global::java.util.List getSupportedPictureFormats() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPictureFormats4083));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureFormats4083));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setRotation4084;
			public virtual void setRotation(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setRotation4084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setRotation4084, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsLatitude4085;
			public virtual void setGpsLatitude(double arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsLatitude4085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLatitude4085, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsLongitude4086;
			public virtual void setGpsLongitude(double arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsLongitude4086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLongitude4086, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsAltitude4087;
			public virtual void setGpsAltitude(double arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsAltitude4087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsAltitude4087, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsTimestamp4088;
			public virtual void setGpsTimestamp(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsTimestamp4088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsTimestamp4088, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsProcessingMethod4089;
			public virtual void setGpsProcessingMethod(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsProcessingMethod4089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsProcessingMethod4089, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _removeGpsData4090;
			public virtual void removeGpsData() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._removeGpsData4090);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._removeGpsData4090);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getWhiteBalance4091;
			public virtual global::java.lang.String getWhiteBalance() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getWhiteBalance4091));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getWhiteBalance4091));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setWhiteBalance4092;
			public virtual void setWhiteBalance(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setWhiteBalance4092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setWhiteBalance4092, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedWhiteBalance4093;
			public virtual global::java.util.List getSupportedWhiteBalance() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance4093));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance4093));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getColorEffect4094;
			public virtual global::java.lang.String getColorEffect() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getColorEffect4094));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getColorEffect4094));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setColorEffect4095;
			public virtual void setColorEffect(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setColorEffect4095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setColorEffect4095, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedColorEffects4096;
			public virtual global::java.util.List getSupportedColorEffects() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedColorEffects4096));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedColorEffects4096));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getAntibanding4097;
			public virtual global::java.lang.String getAntibanding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getAntibanding4097));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getAntibanding4097));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setAntibanding4098;
			public virtual void setAntibanding(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setAntibanding4098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setAntibanding4098, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedAntibanding4099;
			public virtual global::java.util.List getSupportedAntibanding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedAntibanding4099));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedAntibanding4099));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSceneMode4100;
			public virtual global::java.lang.String getSceneMode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSceneMode4100));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSceneMode4100));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSceneMode4101;
			public virtual void setSceneMode(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setSceneMode4101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setSceneMode4101, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedSceneModes4102;
			public virtual global::java.util.List getSupportedSceneModes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedSceneModes4102));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedSceneModes4102));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFlashMode4103;
			public virtual global::java.lang.String getFlashMode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getFlashMode4103));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFlashMode4103));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setFlashMode4104;
			public virtual void setFlashMode(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setFlashMode4104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFlashMode4104, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedFlashModes4105;
			public virtual global::java.util.List getSupportedFlashModes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedFlashModes4105));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFlashModes4105));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFocusMode4106;
			public virtual global::java.lang.String getFocusMode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getFocusMode4106));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocusMode4106));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setFocusMode4107;
			public virtual void setFocusMode(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setFocusMode4107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFocusMode4107, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedFocusModes4108;
			public virtual global::java.util.List getSupportedFocusModes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedFocusModes4108));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFocusModes4108));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFocalLength4109;
			public virtual float getFocalLength() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this, global::android.hardware.Camera.Parameters._getFocalLength4109);
				else
					return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocalLength4109);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getHorizontalViewAngle4110;
			public virtual float getHorizontalViewAngle() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this, global::android.hardware.Camera.Parameters._getHorizontalViewAngle4110);
				else
					return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getHorizontalViewAngle4110);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getVerticalViewAngle4111;
			public virtual float getVerticalViewAngle() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this, global::android.hardware.Camera.Parameters._getVerticalViewAngle4111);
				else
					return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getVerticalViewAngle4111);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getExposureCompensation4112;
			public virtual int getExposureCompensation() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getExposureCompensation4112);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getExposureCompensation4112);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setExposureCompensation4113;
			public virtual void setExposureCompensation(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setExposureCompensation4113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setExposureCompensation4113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getMaxExposureCompensation4114;
			public virtual int getMaxExposureCompensation() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getMaxExposureCompensation4114);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMaxExposureCompensation4114);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getMinExposureCompensation4115;
			public virtual int getMinExposureCompensation() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getMinExposureCompensation4115);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMinExposureCompensation4115);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getExposureCompensationStep4116;
			public virtual float getExposureCompensationStep() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallFloatMethod(this, global::android.hardware.Camera.Parameters._getExposureCompensationStep4116);
				else
					return @__env.CallNonVirtualFloatMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getExposureCompensationStep4116);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getZoom4117;
			public virtual int getZoom() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getZoom4117);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getZoom4117);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setZoom4118;
			public virtual void setZoom(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setZoom4118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setZoom4118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isZoomSupported4119;
			public virtual bool isZoomSupported() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.hardware.Camera.Parameters._isZoomSupported4119);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._isZoomSupported4119);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getMaxZoom4120;
			public virtual int getMaxZoom() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getMaxZoom4120);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getMaxZoom4120);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getZoomRatios4121;
			public virtual global::java.util.List getZoomRatios() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getZoomRatios4121));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getZoomRatios4121));
			}
			internal static global::net.sf.jni4net.jni.MethodId _isSmoothZoomSupported4122;
			public virtual bool isSmoothZoomSupported() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.hardware.Camera.Parameters._isSmoothZoomSupported4122);
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._isSmoothZoomSupported4122);
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.Parameters.staticClass = @__class;
				global::android.hardware.Camera.Parameters._get4055 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._getInt4056 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I");
				global::android.hardware.Camera.Parameters._remove4057 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set4058 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set4059 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V");
				global::android.hardware.Camera.Parameters._flatten4060 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._unflatten4061 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._setPreviewSize4062 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPreviewSize4063 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPreviewSizes4064 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailSize4065 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailSize4066 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedJpegThumbnailSizes4067 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedJpegThumbnailSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailQuality4068 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailQuality4069 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I");
				global::android.hardware.Camera.Parameters._setJpegQuality4070 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegQuality4071 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I");
				global::android.hardware.Camera.Parameters._setPreviewFrameRate4072 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFrameRate4073 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates4074 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPreviewFormat4075 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFormat4076 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFormats4077 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureSize4078 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPictureSize4079 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPictureSizes4080 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureFormat4081 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPictureFormat4082 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPictureFormats4083 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setRotation4084 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V");
				global::android.hardware.Camera.Parameters._setGpsLatitude4085 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsLongitude4086 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsAltitude4087 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsTimestamp4088 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V");
				global::android.hardware.Camera.Parameters._setGpsProcessingMethod4089 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsProcessingMethod", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._removeGpsData4090 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V");
				global::android.hardware.Camera.Parameters._getWhiteBalance4091 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setWhiteBalance4092 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedWhiteBalance4093 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getColorEffect4094 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setColorEffect4095 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedColorEffects4096 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getAntibanding4097 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setAntibanding4098 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedAntibanding4099 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getSceneMode4100 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setSceneMode4101 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedSceneModes4102 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFlashMode4103 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFlashMode4104 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFlashModes4105 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocusMode4106 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFocusMode4107 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFocusModes4108 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocalLength4109 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFocalLength", "()F");
				global::android.hardware.Camera.Parameters._getHorizontalViewAngle4110 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getHorizontalViewAngle", "()F");
				global::android.hardware.Camera.Parameters._getVerticalViewAngle4111 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getVerticalViewAngle", "()F");
				global::android.hardware.Camera.Parameters._getExposureCompensation4112 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._setExposureCompensation4113 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setExposureCompensation", "(I)V");
				global::android.hardware.Camera.Parameters._getMaxExposureCompensation4114 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getMaxExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._getMinExposureCompensation4115 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getMinExposureCompensation", "()I");
				global::android.hardware.Camera.Parameters._getExposureCompensationStep4116 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getExposureCompensationStep", "()F");
				global::android.hardware.Camera.Parameters._getZoom4117 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getZoom", "()I");
				global::android.hardware.Camera.Parameters._setZoom4118 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setZoom", "(I)V");
				global::android.hardware.Camera.Parameters._isZoomSupported4119 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "isZoomSupported", "()Z");
				global::android.hardware.Camera.Parameters._getMaxZoom4120 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getMaxZoom", "()I");
				global::android.hardware.Camera.Parameters._getZoomRatios4121 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getZoomRatios", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._isSmoothZoomSupported4122 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "isSmoothZoomSupported", "()Z");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface PictureCallback 
		{
			void onPictureTaken(byte[] arg0, android.hardware.Camera arg1);
		}

		public partial class PictureCallback_
		{
			public static global::java.lang.Class _class
			{
				get { return __PictureCallback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __PictureCallback : java.lang.Object, PictureCallback
		{
			internal static global::java.lang.Class staticClass;
			static __PictureCallback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.__PictureCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.__PictureCallback(@__env);
				}
			}
			internal __PictureCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPictureTaken4123;
			 void android.hardware.Camera.PictureCallback.onPictureTaken(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__PictureCallback._onPictureTaken4123, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__PictureCallback.staticClass, global::android.hardware.Camera.__PictureCallback._onPictureTaken4123, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__PictureCallback.staticClass = @__class;
				global::android.hardware.Camera.__PictureCallback._onPictureTaken4123 = @__env.GetMethodID(global::android.hardware.Camera.__PictureCallback.staticClass, "android.hardware.Camera.PictureCallback.onPictureTaken", "([BLandroid/hardware/Camera;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface PreviewCallback 
		{
			void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1);
		}

		public partial class PreviewCallback_
		{
			public static global::java.lang.Class _class
			{
				get { return __PreviewCallback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __PreviewCallback : java.lang.Object, PreviewCallback
		{
			internal static global::java.lang.Class staticClass;
			static __PreviewCallback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.__PreviewCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.__PreviewCallback(@__env);
				}
			}
			internal __PreviewCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onPreviewFrame4124;
			 void android.hardware.Camera.PreviewCallback.onPreviewFrame(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__PreviewCallback._onPreviewFrame4124, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__PreviewCallback.staticClass, global::android.hardware.Camera.__PreviewCallback._onPreviewFrame4124, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__PreviewCallback.staticClass = @__class;
				global::android.hardware.Camera.__PreviewCallback._onPreviewFrame4124 = @__env.GetMethodID(global::android.hardware.Camera.__PreviewCallback.staticClass, "android.hardware.Camera.PreviewCallback.onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface ShutterCallback 
		{
			void onShutter();
		}

		public partial class ShutterCallback_
		{
			public static global::java.lang.Class _class
			{
				get { return __ShutterCallback.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __ShutterCallback : java.lang.Object, ShutterCallback
		{
			internal static global::java.lang.Class staticClass;
			static __ShutterCallback()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.__ShutterCallback), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.__ShutterCallback(@__env);
				}
			}
			internal __ShutterCallback(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onShutter4125;
			 void android.hardware.Camera.ShutterCallback.onShutter() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__ShutterCallback._onShutter4125);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__ShutterCallback.staticClass, global::android.hardware.Camera.__ShutterCallback._onShutter4125);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__ShutterCallback.staticClass = @__class;
				global::android.hardware.Camera.__ShutterCallback._onShutter4125 = @__env.GetMethodID(global::android.hardware.Camera.__ShutterCallback.staticClass, "android.hardware.Camera.ShutterCallback.onShutter", "()V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Size : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Size()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.Camera.Size), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.hardware.Camera.Size(@__env);
				}
			}
			protected Size(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _equals4126;
			public override bool equals(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::android.hardware.Camera.Size._equals4126, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._equals4126, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _hashCode4127;
			public override int hashCode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Size._hashCode4127);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._hashCode4127);
			}
			internal static global::net.sf.jni4net.jni.MethodId _Size4128;
			public Size(android.hardware.Camera arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._Size4128, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _width4129;
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
			internal static global::net.sf.jni4net.jni.FieldId _height4130;
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.Size.staticClass = @__class;
				global::android.hardware.Camera.Size._equals4126 = @__env.GetMethodID(global::android.hardware.Camera.Size.staticClass, "equals", "(Ljava/lang/Object;)Z");
				global::android.hardware.Camera.Size._hashCode4127 = @__env.GetMethodID(global::android.hardware.Camera.Size.staticClass, "hashCode", "()I");
				global::android.hardware.Camera.Size._Size4128 = @__env.GetMethodID(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _lock4131;
		public virtual void @lock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._lock4131);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._lock4131);
		}
		internal static global::net.sf.jni4net.jni.MethodId _release4132;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._release4132);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._release4132);
		}
		internal static global::net.sf.jni4net.jni.MethodId _open4133;
		public static global::android.hardware.Camera open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera>(@__env, @__env.CallStaticObjectMethodPtr(android.hardware.Camera.staticClass, global::android.hardware.Camera._open4133));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlock4134;
		public virtual void unlock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._unlock4134);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._unlock4134);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameters4135;
		public virtual global::android.hardware.Camera.Parameters getParameters() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Parameters>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera._getParameters4135));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Parameters>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._getParameters4135));
		}
		internal static global::net.sf.jni4net.jni.MethodId _reconnect4136;
		public virtual void reconnect() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._reconnect4136);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._reconnect4136);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewDisplay4137;
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setPreviewDisplay4137, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewDisplay4137, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startPreview4138;
		public virtual void startPreview() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._startPreview4138);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startPreview4138);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopPreview4139;
		public virtual void stopPreview() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._stopPreview4139);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopPreview4139);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewCallback4140;
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setPreviewCallback4140, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallback4140, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOneShotPreviewCallback4141;
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setOneShotPreviewCallback4141, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setOneShotPreviewCallback4141, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewCallbackWithBuffer4142;
		public virtual void setPreviewCallbackWithBuffer(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setPreviewCallbackWithBuffer4142, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallbackWithBuffer4142, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addCallbackBuffer4143;
		public virtual void addCallbackBuffer(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._addCallbackBuffer4143, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._addCallbackBuffer4143, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _autoFocus4144;
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._autoFocus4144, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._autoFocus4144, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelAutoFocus4145;
		public virtual void cancelAutoFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._cancelAutoFocus4145);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._cancelAutoFocus4145);
		}
		internal static global::net.sf.jni4net.jni.MethodId _takePicture4146;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._takePicture4146, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture4146, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _takePicture4147;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._takePicture4147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture4147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startSmoothZoom4148;
		public virtual void startSmoothZoom(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._startSmoothZoom4148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startSmoothZoom4148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopSmoothZoom4149;
		public virtual void stopSmoothZoom() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._stopSmoothZoom4149);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopSmoothZoom4149);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDisplayOrientation4150;
		public virtual void setDisplayOrientation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setDisplayOrientation4150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setDisplayOrientation4150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setZoomChangeListener4151;
		public virtual void setZoomChangeListener(android.hardware.Camera.OnZoomChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setZoomChangeListener4151, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setZoomChangeListener4151, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setErrorCallback4152;
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setErrorCallback4152, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setErrorCallback4152, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParameters4153;
		public virtual void setParameters(android.hardware.Camera.Parameters arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setParameters4153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setParameters4153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.hardware.Camera.staticClass = @__class;
			global::android.hardware.Camera._lock4131 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "@lock", "()V");
			global::android.hardware.Camera._release4132 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "release", "()V");
			global::android.hardware.Camera._open4133 = @__env.GetStaticMethodID(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;");
			global::android.hardware.Camera._unlock4134 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "unlock", "()V");
			global::android.hardware.Camera._getParameters4135 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;");
			global::android.hardware.Camera._reconnect4136 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "reconnect", "()V");
			global::android.hardware.Camera._setPreviewDisplay4137 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.hardware.Camera._startPreview4138 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "startPreview", "()V");
			global::android.hardware.Camera._stopPreview4139 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "stopPreview", "()V");
			global::android.hardware.Camera._setPreviewCallback4140 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setOneShotPreviewCallback4141 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setPreviewCallbackWithBuffer4142 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewCallbackWithBuffer", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._addCallbackBuffer4143 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "addCallbackBuffer", "([B)V");
			global::android.hardware.Camera._autoFocus4144 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V");
			global::android.hardware.Camera._cancelAutoFocus4145 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V");
			global::android.hardware.Camera._takePicture4146 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._takePicture4147 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._startSmoothZoom4148 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "startSmoothZoom", "(I)V");
			global::android.hardware.Camera._stopSmoothZoom4149 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "stopSmoothZoom", "()V");
			global::android.hardware.Camera._setDisplayOrientation4150 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setDisplayOrientation", "(I)V");
			global::android.hardware.Camera._setZoomChangeListener4151 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setZoomChangeListener", "(Landroid/hardware/Camera$OnZoomChangeListener;)V");
			global::android.hardware.Camera._setErrorCallback4152 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V");
			global::android.hardware.Camera._setParameters4153 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V");
		}
	}
}
