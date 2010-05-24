namespace android.view 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Surface : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Surface() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.Surface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.view.Surface(@__env); 
			} 
		} 
		protected Surface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class OutOfResourcesException : java.lang.Exception
		{ 
			internal static global::java.lang.Class staticClass; 
			static OutOfResourcesException() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.Surface.OutOfResourcesException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.Surface.OutOfResourcesException(@__env); 
				} 
			} 
			protected OutOfResourcesException(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _OutOfResourcesException8028; 
			public OutOfResourcesException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, _OutOfResourcesException8028, this); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _OutOfResourcesException8029; 
			public OutOfResourcesException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, _OutOfResourcesException8029, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.Surface.OutOfResourcesException.staticClass = @__class; 
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException8028 = @__env.GetMethodID(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "()V"); 
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException8029 = @__env.GetMethodID(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "(Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString8030; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString8030)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Surface.staticClass, _toString8030)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSize8031; 
		public virtual void setSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setSize8031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setSize8031, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isValid8032; 
		public virtual bool isValid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				return @__env.CallBooleanMethod(this, _isValid8032); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.Surface.staticClass, _isValid8032); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8033; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _writeToParcel8033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _writeToParcel8033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8034; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				return @__env.CallIntMethod(this, _describeContents8034); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.Surface.staticClass, _describeContents8034); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFlags8035; 
		public virtual void setFlags(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setFlags8035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setFlags8035, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel8036; 
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _readFromParcel8036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _readFromParcel8036, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha8037; 
		public virtual void setAlpha(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setAlpha8037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setAlpha8037, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMatrix8038; 
		public virtual void setMatrix(float arg0, float arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setMatrix8038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setMatrix8038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show8039; 
		public virtual void show() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _show8039); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _show8039); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hide8040; 
		public virtual void hide() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _hide8040); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _hide8040); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation8041; 
		public static void setOrientation(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.view.Surface.staticClass, _setOrientation8041, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lockCanvas8042; 
		public virtual android.graphics.Canvas lockCanvas(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, _lockCanvas8042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.Surface.staticClass, _lockCanvas8042, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlockCanvasAndPost8043; 
		public virtual void unlockCanvasAndPost(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _unlockCanvasAndPost8043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _unlockCanvasAndPost8043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unlockCanvas8044; 
		public virtual void unlockCanvas(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _unlockCanvas8044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _unlockCanvas8044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLayer8045; 
		public virtual void setLayer(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setLayer8045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setLayer8045, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPosition8046; 
		public virtual void setPosition(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setPosition8046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setPosition8046, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setTransparentRegionHint8047; 
		public virtual void setTransparentRegionHint(android.graphics.Region arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setTransparentRegionHint8047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setTransparentRegionHint8047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _freeze8048; 
		public virtual void freeze() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _freeze8048); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _freeze8048); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unfreeze8049; 
		public virtual void unfreeze() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _unfreeze8049); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _unfreeze8049); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFreezeTint8050; 
		public virtual void setFreezeTint(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.Surface)) 
				@__env.CallVoidMethod(this, _setFreezeTint8050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.Surface.staticClass, _setFreezeTint8050, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		public static int HIDDEN
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int HARDWARE
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int GPU
		{ 
			get 
			{ 
				return 40; 
			} 
		} 
		public static int SECURE
		{ 
			get 
			{ 
				return 128; 
			} 
		} 
		public static int NON_PREMULTIPLIED
		{ 
			get 
			{ 
				return 256; 
			} 
		} 
		public static int PUSH_BUFFERS
		{ 
			get 
			{ 
				return 512; 
			} 
		} 
		public static int FX_SURFACE_NORMAL
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int FX_SURFACE_BLUR
		{ 
			get 
			{ 
				return 65536; 
			} 
		} 
		public static int FX_SURFACE_DIM
		{ 
			get 
			{ 
				return 131072; 
			} 
		} 
		public static int FX_SURFACE_MASK
		{ 
			get 
			{ 
				return 983040; 
			} 
		} 
		public static int SURFACE_HIDDEN
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SURFACE_FROZEN
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int SURACE_FROZEN
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int SURFACE_DITHER
		{ 
			get 
			{ 
				return 4; 
			} 
		} 
		public static int SURFACE_BLUR_FREEZE
		{ 
			get 
			{ 
				return 16; 
			} 
		} 
		public static int ROTATION_0
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int ROTATION_90
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ROTATION_180
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ROTATION_270
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8051; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.Surface.staticClass = @__class; 
			global::android.view.Surface._toString8030 = @__env.GetMethodID(global::android.view.Surface.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.view.Surface._setSize8031 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setSize", "(II)V"); 
			global::android.view.Surface._isValid8032 = @__env.GetMethodID(global::android.view.Surface.staticClass, "isValid", "()Z"); 
			global::android.view.Surface._writeToParcel8033 = @__env.GetMethodID(global::android.view.Surface.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.view.Surface._describeContents8034 = @__env.GetMethodID(global::android.view.Surface.staticClass, "describeContents", "()I"); 
			global::android.view.Surface._setFlags8035 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setFlags", "(II)V"); 
			global::android.view.Surface._readFromParcel8036 = @__env.GetMethodID(global::android.view.Surface.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V"); 
			global::android.view.Surface._setAlpha8037 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setAlpha", "(F)V"); 
			global::android.view.Surface._setMatrix8038 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setMatrix", "(FFFF)V"); 
			global::android.view.Surface._show8039 = @__env.GetMethodID(global::android.view.Surface.staticClass, "show", "()V"); 
			global::android.view.Surface._hide8040 = @__env.GetMethodID(global::android.view.Surface.staticClass, "hide", "()V"); 
			global::android.view.Surface._setOrientation8041 = @__env.GetStaticMethodID(global::android.view.Surface.staticClass, "setOrientation", "(II)V"); 
			global::android.view.Surface._lockCanvas8042 = @__env.GetMethodID(global::android.view.Surface.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;"); 
			global::android.view.Surface._unlockCanvasAndPost8043 = @__env.GetMethodID(global::android.view.Surface.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.Surface._unlockCanvas8044 = @__env.GetMethodID(global::android.view.Surface.staticClass, "unlockCanvas", "(Landroid/graphics/Canvas;)V"); 
			global::android.view.Surface._setLayer8045 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setLayer", "(I)V"); 
			global::android.view.Surface._setPosition8046 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setPosition", "(II)V"); 
			global::android.view.Surface._setTransparentRegionHint8047 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setTransparentRegionHint", "(Landroid/graphics/Region;)V"); 
			global::android.view.Surface._freeze8048 = @__env.GetMethodID(global::android.view.Surface.staticClass, "freeze", "()V"); 
			global::android.view.Surface._unfreeze8049 = @__env.GetMethodID(global::android.view.Surface.staticClass, "unfreeze", "()V"); 
			global::android.view.Surface._setFreezeTint8050 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setFreezeTint", "(I)V"); 
		} 
	} 
} 
