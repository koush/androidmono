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
			internal static global::net.sf.jni4net.jni.MethodId _onAutoFocus3846;
			 void android.hardware.Camera.AutoFocusCallback.onAutoFocus(bool arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__AutoFocusCallback._onAutoFocus3846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__AutoFocusCallback.staticClass, global::android.hardware.Camera.__AutoFocusCallback._onAutoFocus3846, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__AutoFocusCallback.staticClass = @__class;
				global::android.hardware.Camera.__AutoFocusCallback._onAutoFocus3846 = @__env.GetMethodID(global::android.hardware.Camera.__AutoFocusCallback.staticClass, "android.hardware.Camera.AutoFocusCallback.onAutoFocus", "(ZLandroid/hardware/Camera;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onError3847;
			 void android.hardware.Camera.ErrorCallback.onError(int arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__ErrorCallback._onError3847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__ErrorCallback.staticClass, global::android.hardware.Camera.__ErrorCallback._onError3847, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__ErrorCallback.staticClass = @__class;
				global::android.hardware.Camera.__ErrorCallback._onError3847 = @__env.GetMethodID(global::android.hardware.Camera.__ErrorCallback.staticClass, "android.hardware.Camera.ErrorCallback.onError", "(ILandroid/hardware/Camera;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _get3848;
			public virtual global::java.lang.String get(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._get3848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._get3848, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getInt3849;
			public virtual int getInt(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getInt3849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getInt3849, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _remove3850;
			public virtual void remove(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._remove3850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._remove3850, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _set3851;
			public virtual void set(java.lang.String arg0, java.lang.String arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._set3851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set3851, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _set3852;
			public virtual void set(java.lang.String arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._set3852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._set3852, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _flatten3853;
			public virtual global::java.lang.String flatten() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._flatten3853));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._flatten3853));
			}
			internal static global::net.sf.jni4net.jni.MethodId _unflatten3854;
			public virtual void unflatten(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._unflatten3854, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._unflatten3854, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewSize3855;
			public virtual void setPreviewSize(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPreviewSize3855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewSize3855, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewSize3856;
			public virtual global::android.hardware.Camera.Size getPreviewSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getPreviewSize3856));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewSize3856));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewSizes3857;
			public virtual global::java.util.List getSupportedPreviewSizes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes3857));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewSizes3857));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setJpegThumbnailSize3858;
			public virtual void setJpegThumbnailSize(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setJpegThumbnailSize3858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailSize3858, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getJpegThumbnailSize3859;
			public virtual global::android.hardware.Camera.Size getJpegThumbnailSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getJpegThumbnailSize3859));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailSize3859));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setJpegThumbnailQuality3860;
			public virtual void setJpegThumbnailQuality(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality3860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegThumbnailQuality3860, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getJpegThumbnailQuality3861;
			public virtual int getJpegThumbnailQuality() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality3861);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegThumbnailQuality3861);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setJpegQuality3862;
			public virtual void setJpegQuality(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setJpegQuality3862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setJpegQuality3862, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getJpegQuality3863;
			public virtual int getJpegQuality() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getJpegQuality3863);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getJpegQuality3863);
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewFrameRate3864;
			public virtual void setPreviewFrameRate(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPreviewFrameRate3864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFrameRate3864, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewFrameRate3865;
			public virtual int getPreviewFrameRate() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getPreviewFrameRate3865);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFrameRate3865);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewFrameRates3866;
			public virtual global::java.util.List getSupportedPreviewFrameRates() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates3866));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates3866));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewFormat3867;
			public virtual void setPreviewFormat(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPreviewFormat3867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPreviewFormat3867, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewFormat3868;
			public virtual int getPreviewFormat() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getPreviewFormat3868);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPreviewFormat3868);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewFormats3869;
			public virtual global::java.util.List getSupportedPreviewFormats() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats3869));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPreviewFormats3869));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPictureSize3870;
			public virtual void setPictureSize(int arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPictureSize3870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureSize3870, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPictureSize3871;
			public virtual global::android.hardware.Camera.Size getPictureSize() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getPictureSize3871));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureSize3871));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPictureSizes3872;
			public virtual global::java.util.List getSupportedPictureSizes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPictureSizes3872));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureSizes3872));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setPictureFormat3873;
			public virtual void setPictureFormat(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setPictureFormat3873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setPictureFormat3873, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getPictureFormat3874;
			public virtual int getPictureFormat() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.hardware.Camera.Parameters._getPictureFormat3874);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getPictureFormat3874);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPictureFormats3875;
			public virtual global::java.util.List getSupportedPictureFormats() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedPictureFormats3875));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedPictureFormats3875));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setRotation3876;
			public virtual void setRotation(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setRotation3876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setRotation3876, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsLatitude3877;
			public virtual void setGpsLatitude(double arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsLatitude3877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLatitude3877, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsLongitude3878;
			public virtual void setGpsLongitude(double arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsLongitude3878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsLongitude3878, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsAltitude3879;
			public virtual void setGpsAltitude(double arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsAltitude3879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsAltitude3879, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setGpsTimestamp3880;
			public virtual void setGpsTimestamp(long arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setGpsTimestamp3880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setGpsTimestamp3880, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _removeGpsData3881;
			public virtual void removeGpsData() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._removeGpsData3881);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._removeGpsData3881);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getWhiteBalance3882;
			public virtual global::java.lang.String getWhiteBalance() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getWhiteBalance3882));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getWhiteBalance3882));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setWhiteBalance3883;
			public virtual void setWhiteBalance(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setWhiteBalance3883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setWhiteBalance3883, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedWhiteBalance3884;
			public virtual global::java.util.List getSupportedWhiteBalance() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance3884));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedWhiteBalance3884));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getColorEffect3885;
			public virtual global::java.lang.String getColorEffect() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getColorEffect3885));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getColorEffect3885));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setColorEffect3886;
			public virtual void setColorEffect(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setColorEffect3886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setColorEffect3886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedColorEffects3887;
			public virtual global::java.util.List getSupportedColorEffects() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedColorEffects3887));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedColorEffects3887));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getAntibanding3888;
			public virtual global::java.lang.String getAntibanding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getAntibanding3888));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getAntibanding3888));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setAntibanding3889;
			public virtual void setAntibanding(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setAntibanding3889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setAntibanding3889, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedAntibanding3890;
			public virtual global::java.util.List getSupportedAntibanding() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedAntibanding3890));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedAntibanding3890));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSceneMode3891;
			public virtual global::java.lang.String getSceneMode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSceneMode3891));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSceneMode3891));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setSceneMode3892;
			public virtual void setSceneMode(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setSceneMode3892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setSceneMode3892, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedSceneModes3893;
			public virtual global::java.util.List getSupportedSceneModes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedSceneModes3893));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedSceneModes3893));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFlashMode3894;
			public virtual global::java.lang.String getFlashMode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getFlashMode3894));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFlashMode3894));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setFlashMode3895;
			public virtual void setFlashMode(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setFlashMode3895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFlashMode3895, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedFlashModes3896;
			public virtual global::java.util.List getSupportedFlashModes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedFlashModes3896));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFlashModes3896));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFocusMode3897;
			public virtual global::java.lang.String getFocusMode() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getFocusMode3897));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getFocusMode3897));
			}
			internal static global::net.sf.jni4net.jni.MethodId _setFocusMode3898;
			public virtual void setFocusMode(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.Parameters._setFocusMode3898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._setFocusMode3898, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedFocusModes3899;
			public virtual global::java.util.List getSupportedFocusModes() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera.Parameters._getSupportedFocusModes3899));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.Parameters.staticClass, global::android.hardware.Camera.Parameters._getSupportedFocusModes3899));
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.Parameters.staticClass = @__class;
				global::android.hardware.Camera.Parameters._get3848 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._getInt3849 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I");
				global::android.hardware.Camera.Parameters._remove3850 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set3851 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._set3852 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V");
				global::android.hardware.Camera.Parameters._flatten3853 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._unflatten3854 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._setPreviewSize3855 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPreviewSize3856 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPreviewSizes3857 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailSize3858 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailSize3859 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._setJpegThumbnailQuality3860 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegThumbnailQuality3861 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I");
				global::android.hardware.Camera.Parameters._setJpegQuality3862 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V");
				global::android.hardware.Camera.Parameters._getJpegQuality3863 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I");
				global::android.hardware.Camera.Parameters._setPreviewFrameRate3864 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFrameRate3865 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates3866 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPreviewFormat3867 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPreviewFormat3868 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPreviewFormats3869 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureSize3870 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V");
				global::android.hardware.Camera.Parameters._getPictureSize3871 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;");
				global::android.hardware.Camera.Parameters._getSupportedPictureSizes3872 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setPictureFormat3873 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V");
				global::android.hardware.Camera.Parameters._getPictureFormat3874 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I");
				global::android.hardware.Camera.Parameters._getSupportedPictureFormats3875 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._setRotation3876 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V");
				global::android.hardware.Camera.Parameters._setGpsLatitude3877 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsLongitude3878 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsAltitude3879 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V");
				global::android.hardware.Camera.Parameters._setGpsTimestamp3880 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V");
				global::android.hardware.Camera.Parameters._removeGpsData3881 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V");
				global::android.hardware.Camera.Parameters._getWhiteBalance3882 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setWhiteBalance3883 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedWhiteBalance3884 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getColorEffect3885 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setColorEffect3886 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedColorEffects3887 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getAntibanding3888 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setAntibanding3889 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedAntibanding3890 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getSceneMode3891 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setSceneMode3892 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedSceneModes3893 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFlashMode3894 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFlashMode3895 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFlashModes3896 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;");
				global::android.hardware.Camera.Parameters._getFocusMode3897 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;");
				global::android.hardware.Camera.Parameters._setFocusMode3898 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V");
				global::android.hardware.Camera.Parameters._getSupportedFocusModes3899 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;");
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
			internal static global::net.sf.jni4net.jni.MethodId _onPictureTaken3900;
			 void android.hardware.Camera.PictureCallback.onPictureTaken(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__PictureCallback._onPictureTaken3900, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__PictureCallback.staticClass, global::android.hardware.Camera.__PictureCallback._onPictureTaken3900, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__PictureCallback.staticClass = @__class;
				global::android.hardware.Camera.__PictureCallback._onPictureTaken3900 = @__env.GetMethodID(global::android.hardware.Camera.__PictureCallback.staticClass, "android.hardware.Camera.PictureCallback.onPictureTaken", "([BLandroid/hardware/Camera;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onPreviewFrame3901;
			 void android.hardware.Camera.PreviewCallback.onPreviewFrame(byte[] arg0, android.hardware.Camera arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__PreviewCallback._onPreviewFrame3901, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__PreviewCallback.staticClass, global::android.hardware.Camera.__PreviewCallback._onPreviewFrame3901, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__PreviewCallback.staticClass = @__class;
				global::android.hardware.Camera.__PreviewCallback._onPreviewFrame3901 = @__env.GetMethodID(global::android.hardware.Camera.__PreviewCallback.staticClass, "android.hardware.Camera.PreviewCallback.onPreviewFrame", "([BLandroid/hardware/Camera;)V");
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
			internal static global::net.sf.jni4net.jni.MethodId _onShutter3902;
			 void android.hardware.Camera.ShutterCallback.onShutter() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.hardware.Camera.__ShutterCallback._onShutter3902);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.__ShutterCallback.staticClass, global::android.hardware.Camera.__ShutterCallback._onShutter3902);
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.hardware.Camera.__ShutterCallback.staticClass = @__class;
				global::android.hardware.Camera.__ShutterCallback._onShutter3902 = @__env.GetMethodID(global::android.hardware.Camera.__ShutterCallback.staticClass, "android.hardware.Camera.ShutterCallback.onShutter", "()V");
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
			internal static global::net.sf.jni4net.jni.MethodId _Size3903;
			public Size(android.hardware.Camera arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.hardware.Camera.Size.staticClass, global::android.hardware.Camera.Size._Size3903, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.FieldId _width3904;
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
			internal static global::net.sf.jni4net.jni.FieldId _height3905;
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
				global::android.hardware.Camera.Size._Size3903 = @__env.GetMethodID(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _lock3906;
		public virtual void @lock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._lock3906);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._lock3906);
		}
		internal static global::net.sf.jni4net.jni.MethodId _release3907;
		public virtual void release() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._release3907);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._release3907);
		}
		internal static global::net.sf.jni4net.jni.MethodId _open3908;
		public static global::android.hardware.Camera open() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera>(@__env, @__env.CallStaticObjectMethodPtr(android.hardware.Camera.staticClass, global::android.hardware.Camera._open3908));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlock3909;
		public virtual void unlock() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._unlock3909);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._unlock3909);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameters3910;
		public virtual global::android.hardware.Camera.Parameters getParameters() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Parameters>(@__env, @__env.CallObjectMethodPtr(this, global::android.hardware.Camera._getParameters3910));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Parameters>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._getParameters3910));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewDisplay3911;
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setPreviewDisplay3911, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewDisplay3911, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startPreview3912;
		public virtual void startPreview() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._startPreview3912);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._startPreview3912);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopPreview3913;
		public virtual void stopPreview() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._stopPreview3913);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._stopPreview3913);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewCallback3914;
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setPreviewCallback3914, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setPreviewCallback3914, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOneShotPreviewCallback3915;
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setOneShotPreviewCallback3915, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setOneShotPreviewCallback3915, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _autoFocus3916;
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._autoFocus3916, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._autoFocus3916, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelAutoFocus3917;
		public virtual void cancelAutoFocus() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._cancelAutoFocus3917);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._cancelAutoFocus3917);
		}
		internal static global::net.sf.jni4net.jni.MethodId _takePicture3918;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._takePicture3918, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture3918, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _takePicture3919;
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._takePicture3919, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._takePicture3919, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setErrorCallback3920;
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setErrorCallback3920, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setErrorCallback3920, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParameters3921;
		public virtual void setParameters(android.hardware.Camera.Parameters arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.hardware.Camera._setParameters3921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.Camera.staticClass, global::android.hardware.Camera._setParameters3921, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			global::android.hardware.Camera._lock3906 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "@lock", "()V");
			global::android.hardware.Camera._release3907 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "release", "()V");
			global::android.hardware.Camera._open3908 = @__env.GetStaticMethodID(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;");
			global::android.hardware.Camera._unlock3909 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "unlock", "()V");
			global::android.hardware.Camera._getParameters3910 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;");
			global::android.hardware.Camera._setPreviewDisplay3911 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V");
			global::android.hardware.Camera._startPreview3912 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "startPreview", "()V");
			global::android.hardware.Camera._stopPreview3913 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "stopPreview", "()V");
			global::android.hardware.Camera._setPreviewCallback3914 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._setOneShotPreviewCallback3915 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V");
			global::android.hardware.Camera._autoFocus3916 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V");
			global::android.hardware.Camera._cancelAutoFocus3917 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V");
			global::android.hardware.Camera._takePicture3918 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._takePicture3919 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V");
			global::android.hardware.Camera._setErrorCallback3920 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V");
			global::android.hardware.Camera._setParameters3921 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V");
		}
	}
}
