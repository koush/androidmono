namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Camera : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Camera() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.Camera), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ErrorCallback 
		{ 
			void onError(int arg0, android.hardware.Camera arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Parameters : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Parameters() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.Camera.Parameters), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _get3640; 
			public virtual java.lang.String get(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _get3640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _get3640, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getInt3641; 
			public virtual int getInt(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return @__env.CallIntMethod(this, _getInt3641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.hardware.Camera.Parameters.staticClass, _getInt3641, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _set3642; 
			public virtual void set(java.lang.String arg0, java.lang.String arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _set3642, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _set3642, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _set3643; 
			public virtual void set(java.lang.String arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _set3643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _set3643, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _remove3644; 
			public virtual void remove(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _remove3644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _remove3644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _flatten3645; 
			public virtual java.lang.String flatten() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _flatten3645)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _flatten3645)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _unflatten3646; 
			public virtual void unflatten(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _unflatten3646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _unflatten3646, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewSize3647; 
			public virtual void setPreviewSize(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setPreviewSize3647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setPreviewSize3647, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewSize3648; 
			public virtual android.hardware.Camera.Size getPreviewSize() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, _getPreviewSize3648)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getPreviewSize3648)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewSizes3649; 
			public virtual java.util.List getSupportedPreviewSizes() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedPreviewSizes3649)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedPreviewSizes3649)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setJpegThumbnailSize3650; 
			public virtual void setJpegThumbnailSize(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setJpegThumbnailSize3650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setJpegThumbnailSize3650, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getJpegThumbnailSize3651; 
			public virtual android.hardware.Camera.Size getJpegThumbnailSize() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, _getJpegThumbnailSize3651)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getJpegThumbnailSize3651)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setJpegThumbnailQuality3652; 
			public virtual void setJpegThumbnailQuality(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setJpegThumbnailQuality3652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setJpegThumbnailQuality3652, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getJpegThumbnailQuality3653; 
			public virtual int getJpegThumbnailQuality() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return @__env.CallIntMethod(this, _getJpegThumbnailQuality3653); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.hardware.Camera.Parameters.staticClass, _getJpegThumbnailQuality3653); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setJpegQuality3654; 
			public virtual void setJpegQuality(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setJpegQuality3654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setJpegQuality3654, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getJpegQuality3655; 
			public virtual int getJpegQuality() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return @__env.CallIntMethod(this, _getJpegQuality3655); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.hardware.Camera.Parameters.staticClass, _getJpegQuality3655); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewFrameRate3656; 
			public virtual void setPreviewFrameRate(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setPreviewFrameRate3656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setPreviewFrameRate3656, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewFrameRate3657; 
			public virtual int getPreviewFrameRate() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return @__env.CallIntMethod(this, _getPreviewFrameRate3657); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.hardware.Camera.Parameters.staticClass, _getPreviewFrameRate3657); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewFrameRates3658; 
			public virtual java.util.List getSupportedPreviewFrameRates() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedPreviewFrameRates3658)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedPreviewFrameRates3658)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPreviewFormat3659; 
			public virtual void setPreviewFormat(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setPreviewFormat3659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setPreviewFormat3659, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPreviewFormat3660; 
			public virtual int getPreviewFormat() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return @__env.CallIntMethod(this, _getPreviewFormat3660); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.hardware.Camera.Parameters.staticClass, _getPreviewFormat3660); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPreviewFormats3661; 
			public virtual java.util.List getSupportedPreviewFormats() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedPreviewFormats3661)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedPreviewFormats3661)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPictureSize3662; 
			public virtual void setPictureSize(int arg0, int arg1) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setPictureSize3662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setPictureSize3662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPictureSize3663; 
			public virtual android.hardware.Camera.Size getPictureSize() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallObjectMethodPtr(this, _getPictureSize3663)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Size>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getPictureSize3663)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPictureSizes3664; 
			public virtual java.util.List getSupportedPictureSizes() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedPictureSizes3664)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedPictureSizes3664)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setPictureFormat3665; 
			public virtual void setPictureFormat(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setPictureFormat3665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setPictureFormat3665, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getPictureFormat3666; 
			public virtual int getPictureFormat() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return @__env.CallIntMethod(this, _getPictureFormat3666); 
				else 
					return @__env.CallNonVirtualIntMethod(this, android.hardware.Camera.Parameters.staticClass, _getPictureFormat3666); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedPictureFormats3667; 
			public virtual java.util.List getSupportedPictureFormats() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedPictureFormats3667)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedPictureFormats3667)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setRotation3668; 
			public virtual void setRotation(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setRotation3668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setRotation3668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setGpsLatitude3669; 
			public virtual void setGpsLatitude(double arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setGpsLatitude3669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setGpsLatitude3669, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setGpsLongitude3670; 
			public virtual void setGpsLongitude(double arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setGpsLongitude3670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setGpsLongitude3670, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setGpsAltitude3671; 
			public virtual void setGpsAltitude(double arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setGpsAltitude3671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setGpsAltitude3671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setGpsTimestamp3672; 
			public virtual void setGpsTimestamp(long arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setGpsTimestamp3672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setGpsTimestamp3672, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _removeGpsData3673; 
			public virtual void removeGpsData() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _removeGpsData3673); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _removeGpsData3673); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getWhiteBalance3674; 
			public virtual java.lang.String getWhiteBalance() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getWhiteBalance3674)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getWhiteBalance3674)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setWhiteBalance3675; 
			public virtual void setWhiteBalance(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setWhiteBalance3675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setWhiteBalance3675, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedWhiteBalance3676; 
			public virtual java.util.List getSupportedWhiteBalance() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedWhiteBalance3676)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedWhiteBalance3676)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getColorEffect3677; 
			public virtual java.lang.String getColorEffect() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getColorEffect3677)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getColorEffect3677)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setColorEffect3678; 
			public virtual void setColorEffect(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setColorEffect3678, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setColorEffect3678, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedColorEffects3679; 
			public virtual java.util.List getSupportedColorEffects() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedColorEffects3679)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedColorEffects3679)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getAntibanding3680; 
			public virtual java.lang.String getAntibanding() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getAntibanding3680)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getAntibanding3680)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setAntibanding3681; 
			public virtual void setAntibanding(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setAntibanding3681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setAntibanding3681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedAntibanding3682; 
			public virtual java.util.List getSupportedAntibanding() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedAntibanding3682)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedAntibanding3682)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSceneMode3683; 
			public virtual java.lang.String getSceneMode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSceneMode3683)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSceneMode3683)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setSceneMode3684; 
			public virtual void setSceneMode(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setSceneMode3684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setSceneMode3684, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedSceneModes3685; 
			public virtual java.util.List getSupportedSceneModes() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedSceneModes3685)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedSceneModes3685)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFlashMode3686; 
			public virtual java.lang.String getFlashMode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFlashMode3686)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getFlashMode3686)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setFlashMode3687; 
			public virtual void setFlashMode(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setFlashMode3687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setFlashMode3687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedFlashModes3688; 
			public virtual java.util.List getSupportedFlashModes() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedFlashModes3688)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedFlashModes3688)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getFocusMode3689; 
			public virtual java.lang.String getFocusMode() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFocusMode3689)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getFocusMode3689)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _setFocusMode3690; 
			public virtual void setFocusMode(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					@__env.CallVoidMethod(this, _setFocusMode3690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.Parameters.staticClass, _setFocusMode3690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getSupportedFocusModes3691; 
			public virtual java.util.List getSupportedFocusModes() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.hardware.Camera.Parameters)) 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getSupportedFocusModes3691)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.Parameters.staticClass, _getSupportedFocusModes3691)); 
			} 
			public static java.lang.String WHITE_BALANCE_AUTO
			{ 
				get 
				{ 
					return "auto"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_INCANDESCENT
			{ 
				get 
				{ 
					return "incandescent"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_FLUORESCENT
			{ 
				get 
				{ 
					return "fluorescent"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_WARM_FLUORESCENT
			{ 
				get 
				{ 
					return "warm-fluorescent"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_DAYLIGHT
			{ 
				get 
				{ 
					return "daylight"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_CLOUDY_DAYLIGHT
			{ 
				get 
				{ 
					return "cloudy-daylight"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_TWILIGHT
			{ 
				get 
				{ 
					return "twilight"; 
				} 
			} 
			public static java.lang.String WHITE_BALANCE_SHADE
			{ 
				get 
				{ 
					return "shade"; 
				} 
			} 
			public static java.lang.String EFFECT_NONE
			{ 
				get 
				{ 
					return "none"; 
				} 
			} 
			public static java.lang.String EFFECT_MONO
			{ 
				get 
				{ 
					return "mono"; 
				} 
			} 
			public static java.lang.String EFFECT_NEGATIVE
			{ 
				get 
				{ 
					return "negative"; 
				} 
			} 
			public static java.lang.String EFFECT_SOLARIZE
			{ 
				get 
				{ 
					return "solarize"; 
				} 
			} 
			public static java.lang.String EFFECT_SEPIA
			{ 
				get 
				{ 
					return "sepia"; 
				} 
			} 
			public static java.lang.String EFFECT_POSTERIZE
			{ 
				get 
				{ 
					return "posterize"; 
				} 
			} 
			public static java.lang.String EFFECT_WHITEBOARD
			{ 
				get 
				{ 
					return "whiteboard"; 
				} 
			} 
			public static java.lang.String EFFECT_BLACKBOARD
			{ 
				get 
				{ 
					return "blackboard"; 
				} 
			} 
			public static java.lang.String EFFECT_AQUA
			{ 
				get 
				{ 
					return "aqua"; 
				} 
			} 
			public static java.lang.String ANTIBANDING_AUTO
			{ 
				get 
				{ 
					return "auto"; 
				} 
			} 
			public static java.lang.String ANTIBANDING_50HZ
			{ 
				get 
				{ 
					return "50hz"; 
				} 
			} 
			public static java.lang.String ANTIBANDING_60HZ
			{ 
				get 
				{ 
					return "60hz"; 
				} 
			} 
			public static java.lang.String ANTIBANDING_OFF
			{ 
				get 
				{ 
					return "off"; 
				} 
			} 
			public static java.lang.String FLASH_MODE_OFF
			{ 
				get 
				{ 
					return "off"; 
				} 
			} 
			public static java.lang.String FLASH_MODE_AUTO
			{ 
				get 
				{ 
					return "auto"; 
				} 
			} 
			public static java.lang.String FLASH_MODE_ON
			{ 
				get 
				{ 
					return "on"; 
				} 
			} 
			public static java.lang.String FLASH_MODE_RED_EYE
			{ 
				get 
				{ 
					return "red-eye"; 
				} 
			} 
			public static java.lang.String FLASH_MODE_TORCH
			{ 
				get 
				{ 
					return "torch"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_AUTO
			{ 
				get 
				{ 
					return "auto"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_ACTION
			{ 
				get 
				{ 
					return "action"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_PORTRAIT
			{ 
				get 
				{ 
					return "portrait"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_LANDSCAPE
			{ 
				get 
				{ 
					return "landscape"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_NIGHT
			{ 
				get 
				{ 
					return "night"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_NIGHT_PORTRAIT
			{ 
				get 
				{ 
					return "night-portrait"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_THEATRE
			{ 
				get 
				{ 
					return "theatre"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_BEACH
			{ 
				get 
				{ 
					return "beach"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_SNOW
			{ 
				get 
				{ 
					return "snow"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_SUNSET
			{ 
				get 
				{ 
					return "sunset"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_STEADYPHOTO
			{ 
				get 
				{ 
					return "steadyphoto"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_FIREWORKS
			{ 
				get 
				{ 
					return "fireworks"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_SPORTS
			{ 
				get 
				{ 
					return "sports"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_PARTY
			{ 
				get 
				{ 
					return "party"; 
				} 
			} 
			public static java.lang.String SCENE_MODE_CANDLELIGHT
			{ 
				get 
				{ 
					return "candlelight"; 
				} 
			} 
			public static java.lang.String FOCUS_MODE_AUTO
			{ 
				get 
				{ 
					return "auto"; 
				} 
			} 
			public static java.lang.String FOCUS_MODE_INFINITY
			{ 
				get 
				{ 
					return "infinity"; 
				} 
			} 
			public static java.lang.String FOCUS_MODE_MACRO
			{ 
				get 
				{ 
					return "macro"; 
				} 
			} 
			public static java.lang.String FOCUS_MODE_FIXED
			{ 
				get 
				{ 
					return "fixed"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.hardware.Camera.Parameters.staticClass = @__class; 
				global::android.hardware.Camera.Parameters._get3640 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._getInt3641 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getInt", "(Ljava/lang/String;)I"); 
				global::android.hardware.Camera.Parameters._set3642 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._set3643 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "set", "(Ljava/lang/String;I)V"); 
				global::android.hardware.Camera.Parameters._remove3644 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "remove", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._flatten3645 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "flatten", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._unflatten3646 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "unflatten", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._setPreviewSize3647 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewSize", "(II)V"); 
				global::android.hardware.Camera.Parameters._getPreviewSize3648 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewSize", "()Landroid/hardware/Camera$Size;"); 
				global::android.hardware.Camera.Parameters._getSupportedPreviewSizes3649 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewSizes", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._setJpegThumbnailSize3650 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailSize", "(II)V"); 
				global::android.hardware.Camera.Parameters._getJpegThumbnailSize3651 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailSize", "()Landroid/hardware/Camera$Size;"); 
				global::android.hardware.Camera.Parameters._setJpegThumbnailQuality3652 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegThumbnailQuality", "(I)V"); 
				global::android.hardware.Camera.Parameters._getJpegThumbnailQuality3653 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegThumbnailQuality", "()I"); 
				global::android.hardware.Camera.Parameters._setJpegQuality3654 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setJpegQuality", "(I)V"); 
				global::android.hardware.Camera.Parameters._getJpegQuality3655 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getJpegQuality", "()I"); 
				global::android.hardware.Camera.Parameters._setPreviewFrameRate3656 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFrameRate", "(I)V"); 
				global::android.hardware.Camera.Parameters._getPreviewFrameRate3657 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFrameRate", "()I"); 
				global::android.hardware.Camera.Parameters._getSupportedPreviewFrameRates3658 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFrameRates", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._setPreviewFormat3659 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPreviewFormat", "(I)V"); 
				global::android.hardware.Camera.Parameters._getPreviewFormat3660 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPreviewFormat", "()I"); 
				global::android.hardware.Camera.Parameters._getSupportedPreviewFormats3661 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPreviewFormats", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._setPictureSize3662 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPictureSize", "(II)V"); 
				global::android.hardware.Camera.Parameters._getPictureSize3663 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPictureSize", "()Landroid/hardware/Camera$Size;"); 
				global::android.hardware.Camera.Parameters._getSupportedPictureSizes3664 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureSizes", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._setPictureFormat3665 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setPictureFormat", "(I)V"); 
				global::android.hardware.Camera.Parameters._getPictureFormat3666 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getPictureFormat", "()I"); 
				global::android.hardware.Camera.Parameters._getSupportedPictureFormats3667 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedPictureFormats", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._setRotation3668 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setRotation", "(I)V"); 
				global::android.hardware.Camera.Parameters._setGpsLatitude3669 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsLatitude", "(D)V"); 
				global::android.hardware.Camera.Parameters._setGpsLongitude3670 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsLongitude", "(D)V"); 
				global::android.hardware.Camera.Parameters._setGpsAltitude3671 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsAltitude", "(D)V"); 
				global::android.hardware.Camera.Parameters._setGpsTimestamp3672 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setGpsTimestamp", "(J)V"); 
				global::android.hardware.Camera.Parameters._removeGpsData3673 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "removeGpsData", "()V"); 
				global::android.hardware.Camera.Parameters._getWhiteBalance3674 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getWhiteBalance", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._setWhiteBalance3675 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setWhiteBalance", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._getSupportedWhiteBalance3676 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedWhiteBalance", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._getColorEffect3677 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getColorEffect", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._setColorEffect3678 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setColorEffect", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._getSupportedColorEffects3679 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedColorEffects", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._getAntibanding3680 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getAntibanding", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._setAntibanding3681 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setAntibanding", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._getSupportedAntibanding3682 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedAntibanding", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._getSceneMode3683 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSceneMode", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._setSceneMode3684 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setSceneMode", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._getSupportedSceneModes3685 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedSceneModes", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._getFlashMode3686 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFlashMode", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._setFlashMode3687 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setFlashMode", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._getSupportedFlashModes3688 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFlashModes", "()Ljava/util/List;"); 
				global::android.hardware.Camera.Parameters._getFocusMode3689 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getFocusMode", "()Ljava/lang/String;"); 
				global::android.hardware.Camera.Parameters._setFocusMode3690 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "setFocusMode", "(Ljava/lang/String;)V"); 
				global::android.hardware.Camera.Parameters._getSupportedFocusModes3691 = @__env.GetMethodID(global::android.hardware.Camera.Parameters.staticClass, "getSupportedFocusModes", "()Ljava/util/List;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PictureCallback 
		{ 
			void onPictureTaken(byte[] arg0, android.hardware.Camera arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface PreviewCallback 
		{ 
			void onPreviewFrame(byte[] arg0, android.hardware.Camera arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface ShutterCallback 
		{ 
			void onShutter(); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Size : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Size() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.hardware.Camera.Size), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _Size3692; 
			public Size(android.hardware.Camera arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.hardware.Camera.Size.staticClass, _Size3692, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _width3693; 
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
			internal static global::net.sf.jni4net.jni.FieldId _height3694; 
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
				global::android.hardware.Camera.Size._Size3692 = @__env.GetMethodID(global::android.hardware.Camera.Size.staticClass, "<init>", "(Landroid/hardware/Camera;II)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lock3695; 
		public virtual void @lock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _lock3695); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _lock3695); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release3696; 
		public virtual void release() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _release3696); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _release3696); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _open3697; 
		public static android.hardware.Camera open() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera>(@__env, @__env.CallStaticObjectMethodPtr(android.hardware.Camera.staticClass, _open3697)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlock3698; 
		public virtual void unlock() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _unlock3698); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _unlock3698); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParameters3699; 
		public virtual android.hardware.Camera.Parameters getParameters() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Parameters>(@__env, @__env.CallObjectMethodPtr(this, _getParameters3699)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.hardware.Camera.Parameters>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.hardware.Camera.staticClass, _getParameters3699)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewDisplay3700; 
		public virtual void setPreviewDisplay(android.view.SurfaceHolder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _setPreviewDisplay3700, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _setPreviewDisplay3700, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startPreview3701; 
		public virtual void startPreview() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _startPreview3701); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _startPreview3701); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stopPreview3702; 
		public virtual void stopPreview() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _stopPreview3702); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _stopPreview3702); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPreviewCallback3703; 
		public virtual void setPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _setPreviewCallback3703, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _setPreviewCallback3703, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOneShotPreviewCallback3704; 
		public virtual void setOneShotPreviewCallback(android.hardware.Camera.PreviewCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _setOneShotPreviewCallback3704, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _setOneShotPreviewCallback3704, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _autoFocus3705; 
		public virtual void autoFocus(android.hardware.Camera.AutoFocusCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _autoFocus3705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _autoFocus3705, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelAutoFocus3706; 
		public virtual void cancelAutoFocus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _cancelAutoFocus3706); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _cancelAutoFocus3706); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _takePicture3707; 
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2, android.hardware.Camera.PictureCallback arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _takePicture3707, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _takePicture3707, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _takePicture3708; 
		public virtual void takePicture(android.hardware.Camera.ShutterCallback arg0, android.hardware.Camera.PictureCallback arg1, android.hardware.Camera.PictureCallback arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _takePicture3708, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _takePicture3708, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setErrorCallback3709; 
		public virtual void setErrorCallback(android.hardware.Camera.ErrorCallback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _setErrorCallback3709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _setErrorCallback3709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParameters3710; 
		public virtual void setParameters(android.hardware.Camera.Parameters arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.hardware.Camera)) 
				@__env.CallVoidMethod(this, _setParameters3710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.hardware.Camera.staticClass, _setParameters3710, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			global::android.hardware.Camera._lock3695 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "@lock", "()V"); 
			global::android.hardware.Camera._release3696 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "release", "()V"); 
			global::android.hardware.Camera._open3697 = @__env.GetStaticMethodID(global::android.hardware.Camera.staticClass, "open", "()Landroid/hardware/Camera;"); 
			global::android.hardware.Camera._unlock3698 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "unlock", "()V"); 
			global::android.hardware.Camera._getParameters3699 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "getParameters", "()Landroid/hardware/Camera$Parameters;"); 
			global::android.hardware.Camera._setPreviewDisplay3700 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V"); 
			global::android.hardware.Camera._startPreview3701 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "startPreview", "()V"); 
			global::android.hardware.Camera._stopPreview3702 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "stopPreview", "()V"); 
			global::android.hardware.Camera._setPreviewCallback3703 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V"); 
			global::android.hardware.Camera._setOneShotPreviewCallback3704 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setOneShotPreviewCallback", "(Landroid/hardware/Camera$PreviewCallback;)V"); 
			global::android.hardware.Camera._autoFocus3705 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "autoFocus", "(Landroid/hardware/Camera$AutoFocusCallback;)V"); 
			global::android.hardware.Camera._cancelAutoFocus3706 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "cancelAutoFocus", "()V"); 
			global::android.hardware.Camera._takePicture3707 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V"); 
			global::android.hardware.Camera._takePicture3708 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "takePicture", "(Landroid/hardware/Camera$ShutterCallback;Landroid/hardware/Camera$PictureCallback;Landroid/hardware/Camera$PictureCallback;)V"); 
			global::android.hardware.Camera._setErrorCallback3709 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setErrorCallback", "(Landroid/hardware/Camera$ErrorCallback;)V"); 
			global::android.hardware.Camera._setParameters3710 = @__env.GetMethodID(global::android.hardware.Camera.staticClass, "setParameters", "(Landroid/hardware/Camera$Parameters;)V"); 
		} 
	} 
} 
