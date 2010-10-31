namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Surface : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Surface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class OutOfResourcesException : java.lang.Exception
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OutOfResourcesException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OutOfResourcesException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Surface.OutOfResourcesException._m0.native == global::System.IntPtr.Zero)
					global::android.view.Surface.OutOfResourcesException._m0 = @__env.GetMethodIDNoThrow(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._m0);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public OutOfResourcesException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Surface.OutOfResourcesException._m1.native == global::System.IntPtr.Zero)
					global::android.view.Surface.OutOfResourcesException._m1 = @__env.GetMethodIDNoThrow(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static OutOfResourcesException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Surface.OutOfResourcesException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Surface$OutOfResourcesException"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "finalize", "()V", ref global::android.view.Surface._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.view.Surface.staticClass, "toString", "()Ljava/lang/String;", ref global::android.view.Surface._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setSize", "(II)V", ref global::android.view.Surface._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool isValid()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Surface.staticClass, "isValid", "()Z", ref global::android.view.Surface._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.view.Surface._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Surface.staticClass, "describeContents", "()I", ref global::android.view.Surface._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void setFlags(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setFlags", "(II)V", ref global::android.view.Surface._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V", ref global::android.view.Surface._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setAlpha(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setAlpha", "(F)V", ref global::android.view.Surface._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setMatrix(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setMatrix", "(FFFF)V", ref global::android.view.Surface._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void show()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "show", "()V", ref global::android.view.Surface._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void hide()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "hide", "()V", ref global::android.view.Surface._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static void setOrientation(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Surface._m12.native == global::System.IntPtr.Zero)
				global::android.view.Surface._m12 = @__env.GetStaticMethodIDNoThrow(global::android.view.Surface.staticClass, "setOrientation", "(II)V");
			@__env.CallStaticVoidMethod(android.view.Surface.staticClass, global::android.view.Surface._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::android.graphics.Canvas lockCanvas(android.graphics.Rect arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Surface.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;", ref global::android.view.Surface._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Canvas;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void unlockCanvasAndPost(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V", ref global::android.view.Surface._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void unlockCanvas(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "unlockCanvas", "(Landroid/graphics/Canvas;)V", ref global::android.view.Surface._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Layer
		{
			set
			{
				setLayer(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual void setLayer(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setLayer", "(I)V", ref global::android.view.Surface._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual void setPosition(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setPosition", "(II)V", ref global::android.view.Surface._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.graphics.Region TransparentRegionHint
		{
			set
			{
				setTransparentRegionHint(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setTransparentRegionHint(android.graphics.Region arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setTransparentRegionHint", "(Landroid/graphics/Region;)V", ref global::android.view.Surface._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void freeze()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "freeze", "()V", ref global::android.view.Surface._m19);
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void unfreeze()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "unfreeze", "()V", ref global::android.view.Surface._m20);
		}
		public new int FreezeTint
		{
			set
			{
				setFreezeTint(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void setFreezeTint(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Surface.staticClass, "setFreezeTint", "(I)V", ref global::android.view.Surface._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR5677;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.Surface.staticClass, _CREATOR5677)) as android.os.Parcelable_Creator;
			}
		}
		static Surface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Surface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Surface"));
			global::android.view.Surface._CREATOR5677 = @__env.GetStaticFieldIDNoThrow(global::android.view.Surface.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
