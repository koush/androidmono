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
			internal static global::MonoJavaBridge.MethodId _OutOfResourcesException14521;
			public OutOfResourcesException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._OutOfResourcesException14521);
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _OutOfResourcesException14522;
			public OutOfResourcesException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._OutOfResourcesException14522, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Surface.OutOfResourcesException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Surface$OutOfResourcesException"));
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException14521 = @__env.GetMethodIDNoThrow(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "()V");
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException14522 = @__env.GetMethodIDNoThrow(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize14523;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._finalize14523);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._finalize14523);
		}
		internal static global::MonoJavaBridge.MethodId _toString14524;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Surface._toString14524)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._toString14524)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setSize14525;
		public virtual void setSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setSize14525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setSize14525, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isValid14526;
		public virtual bool isValid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Surface._isValid14526);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._isValid14526);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel14527;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._writeToParcel14527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._writeToParcel14527, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents14528;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.view.Surface._describeContents14528);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._describeContents14528);
		}
		internal static global::MonoJavaBridge.MethodId _setFlags14529;
		public virtual void setFlags(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setFlags14529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setFlags14529, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel14530;
		public virtual void readFromParcel(android.os.Parcel arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._readFromParcel14530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._readFromParcel14530, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float Alpha
		{
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha14531;
		public virtual void setAlpha(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setAlpha14531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setAlpha14531, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMatrix14532;
		public virtual void setMatrix(float arg0, float arg1, float arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setMatrix14532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setMatrix14532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _show14533;
		public virtual void show()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._show14533);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._show14533);
		}
		internal static global::MonoJavaBridge.MethodId _hide14534;
		public virtual void hide()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._hide14534);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._hide14534);
		}
		internal static global::MonoJavaBridge.MethodId _setOrientation14535;
		public static void setOrientation(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Surface.staticClass, global::android.view.Surface._setOrientation14535, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _lockCanvas14536;
		public virtual global::android.graphics.Canvas lockCanvas(android.graphics.Rect arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Surface._lockCanvas14536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._lockCanvas14536, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Canvas;
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvasAndPost14537;
		public virtual void unlockCanvasAndPost(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._unlockCanvasAndPost14537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._unlockCanvasAndPost14537, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unlockCanvas14538;
		public virtual void unlockCanvas(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._unlockCanvas14538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._unlockCanvas14538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Layer
		{
			set
			{
				setLayer(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setLayer14539;
		public virtual void setLayer(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setLayer14539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setLayer14539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPosition14540;
		public virtual void setPosition(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setPosition14540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setPosition14540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.graphics.Region TransparentRegionHint
		{
			set
			{
				setTransparentRegionHint(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setTransparentRegionHint14541;
		public virtual void setTransparentRegionHint(android.graphics.Region arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setTransparentRegionHint14541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setTransparentRegionHint14541, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _freeze14542;
		public virtual void freeze()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._freeze14542);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._freeze14542);
		}
		internal static global::MonoJavaBridge.MethodId _unfreeze14543;
		public virtual void unfreeze()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._unfreeze14543);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._unfreeze14543);
		}
		public new int FreezeTint
		{
			set
			{
				setFreezeTint(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFreezeTint14544;
		public virtual void setFreezeTint(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Surface._setFreezeTint14544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.Surface.staticClass, global::android.view.Surface._setFreezeTint14544, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR14564;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.view.Surface.staticClass, _CREATOR14564)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Surface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Surface"));
			global::android.view.Surface._finalize14523 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "finalize", "()V");
			global::android.view.Surface._toString14524 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.Surface._setSize14525 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setSize", "(II)V");
			global::android.view.Surface._isValid14526 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "isValid", "()Z");
			global::android.view.Surface._writeToParcel14527 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.Surface._describeContents14528 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "describeContents", "()I");
			global::android.view.Surface._setFlags14529 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setFlags", "(II)V");
			global::android.view.Surface._readFromParcel14530 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.Surface._setAlpha14531 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setAlpha", "(F)V");
			global::android.view.Surface._setMatrix14532 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setMatrix", "(FFFF)V");
			global::android.view.Surface._show14533 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "show", "()V");
			global::android.view.Surface._hide14534 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "hide", "()V");
			global::android.view.Surface._setOrientation14535 = @__env.GetStaticMethodIDNoThrow(global::android.view.Surface.staticClass, "setOrientation", "(II)V");
			global::android.view.Surface._lockCanvas14536 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;");
			global::android.view.Surface._unlockCanvasAndPost14537 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V");
			global::android.view.Surface._unlockCanvas14538 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "unlockCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.view.Surface._setLayer14539 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setLayer", "(I)V");
			global::android.view.Surface._setPosition14540 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setPosition", "(II)V");
			global::android.view.Surface._setTransparentRegionHint14541 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setTransparentRegionHint", "(Landroid/graphics/Region;)V");
			global::android.view.Surface._freeze14542 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "freeze", "()V");
			global::android.view.Surface._unfreeze14543 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "unfreeze", "()V");
			global::android.view.Surface._setFreezeTint14544 = @__env.GetMethodIDNoThrow(global::android.view.Surface.staticClass, "setFreezeTint", "(I)V");
			global::android.view.Surface._CREATOR14564 = @__env.GetStaticFieldIDNoThrow(global::android.view.Surface.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
