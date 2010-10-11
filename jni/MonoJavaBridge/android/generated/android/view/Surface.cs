namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Surface : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Surface()
		{
			InitJNI();
		}
		protected Surface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class OutOfResourcesException : java.lang.Exception
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OutOfResourcesException()
			{
				InitJNI();
			}
			protected OutOfResourcesException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OutOfResourcesException9031;
			public OutOfResourcesException()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._OutOfResourcesException9031);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _OutOfResourcesException9032;
			public OutOfResourcesException(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._OutOfResourcesException9032, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Surface.OutOfResourcesException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Surface$OutOfResourcesException"));
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException9031 = @__env.GetMethodIDNoThrow(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "()V");
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException9032 = @__env.GetMethodIDNoThrow(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize9033;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._finalize9033);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._finalize9033);
		}
		internal static global::MonoJavaBridge.MethodId _toString9034;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Surface._toString9034)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._toString9034)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSize9035;
		public virtual void setSize(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setSize9035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setSize9035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isValid9036;
		public virtual bool isValid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Surface._isValid9036);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._isValid9036);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9037;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._writeToParcel9037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._writeToParcel9037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9038;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Surface._describeContents9038);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._describeContents9038);
		}
		internal static global::MonoJavaBridge.MethodId _setFlags9039;
		public virtual void setFlags(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setFlags9039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setFlags9039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel9040;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._readFromParcel9040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._readFromParcel9040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha9041;
		public virtual void setAlpha(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setAlpha9041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setAlpha9041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMatrix9042;
		public virtual void setMatrix(float arg0, float arg1, float arg2, float arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setMatrix9042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setMatrix9042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _show9043;
		public virtual void show() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._show9043);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._show9043);
		}
		internal static global::MonoJavaBridge.MethodId _hide9044;
		public virtual void hide() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._hide9044);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._hide9044);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation9045;
		public static void setOrientation(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Surface.staticClass, global::android.view.Surface._setOrientation9045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas9046;
		public virtual global::android.graphics.Canvas lockCanvas(android.graphics.Rect arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Surface._lockCanvas9046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._lockCanvas9046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvasAndPost9047;
		public virtual void unlockCanvasAndPost(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._unlockCanvasAndPost9047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._unlockCanvasAndPost9047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvas9048;
		public virtual void unlockCanvas(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._unlockCanvas9048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._unlockCanvas9048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLayer9049;
		public virtual void setLayer(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setLayer9049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setLayer9049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPosition9050;
		public virtual void setPosition(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setPosition9050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setPosition9050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTransparentRegionHint9051;
		public virtual void setTransparentRegionHint(android.graphics.Region arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setTransparentRegionHint9051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setTransparentRegionHint9051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _freeze9052;
		public virtual void freeze() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._freeze9052);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._freeze9052);
		}
		internal static global::MonoJavaBridge.MethodId _unfreeze9053;
		public virtual void unfreeze() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._unfreeze9053);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._unfreeze9053);
		}
		internal static global::MonoJavaBridge.MethodId _setFreezeTint9054;
		public virtual void setFreezeTint(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setFreezeTint9054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setFreezeTint9054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR9055;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Surface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Surface"));
			global::android.view.Surface._finalize9033 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "finalize", "()V");
			global::android.view.Surface._toString9034 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.Surface._setSize9035 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setSize", "(II)V");
			global::android.view.Surface._isValid9036 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "isValid", "()Z");
			global::android.view.Surface._writeToParcel9037 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.Surface._describeContents9038 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "describeContents", "()I");
			global::android.view.Surface._setFlags9039 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setFlags", "(II)V");
			global::android.view.Surface._readFromParcel9040 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.Surface._setAlpha9041 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setAlpha", "(F)V");
			global::android.view.Surface._setMatrix9042 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setMatrix", "(FFFF)V");
			global::android.view.Surface._show9043 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "show", "()V");
			global::android.view.Surface._hide9044 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "hide", "()V");
			global::android.view.Surface._setOrientation9045 = @__env.GetStaticMethodIDNoThrow(global::android.view.Surface.staticClass, "setOrientation", "(II)V");
			global::android.view.Surface._lockCanvas9046 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;");
			global::android.view.Surface._unlockCanvasAndPost9047 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V");
			global::android.view.Surface._unlockCanvas9048 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "unlockCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.view.Surface._setLayer9049 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setLayer", "(I)V");
			global::android.view.Surface._setPosition9050 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setPosition", "(II)V");
			global::android.view.Surface._setTransparentRegionHint9051 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setTransparentRegionHint", "(Landroid/graphics/Region;)V");
			global::android.view.Surface._freeze9052 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "freeze", "()V");
			global::android.view.Surface._unfreeze9053 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "unfreeze", "()V");
			global::android.view.Surface._setFreezeTint9054 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setFreezeTint", "(I)V");
		}
	}
}
