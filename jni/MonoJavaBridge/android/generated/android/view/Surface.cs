namespace android.view
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Surface : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static Surface()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.Surface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.view.Surface.OutOfResourcesException), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _OutOfResourcesException8723;
			public OutOfResourcesException()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._OutOfResourcesException8723, this);
			}
			internal static global::net.sf.jni4net.jni.MethodId _OutOfResourcesException8724;
			public OutOfResourcesException(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.view.Surface.OutOfResourcesException.staticClass, global::android.view.Surface.OutOfResourcesException._OutOfResourcesException8724, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.view.Surface.OutOfResourcesException.staticClass = @__class;
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException8723 = @__env.GetMethodID(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "()V");
				global::android.view.Surface.OutOfResourcesException._OutOfResourcesException8724 = @__env.GetMethodID(global::android.view.Surface.OutOfResourcesException.staticClass, "<init>", "(Ljava/lang/String;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString8725;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Surface._toString8725));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Surface.staticClass, global::android.view.Surface._toString8725));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSize8726;
		public virtual void setSize(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setSize8726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setSize8726, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isValid8727;
		public virtual bool isValid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.view.Surface._isValid8727);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._isValid8727);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel8728;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._writeToParcel8728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._writeToParcel8728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents8729;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.view.Surface._describeContents8729);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._describeContents8729);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFlags8730;
		public virtual void setFlags(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setFlags8730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setFlags8730, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel8731;
		public virtual void readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._readFromParcel8731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._readFromParcel8731, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha8732;
		public virtual void setAlpha(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setAlpha8732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setAlpha8732, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMatrix8733;
		public virtual void setMatrix(float arg0, float arg1, float arg2, float arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setMatrix8733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setMatrix8733, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _show8734;
		public virtual void show() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._show8734);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._show8734);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hide8735;
		public virtual void hide() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._hide8735);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._hide8735);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOrientation8736;
		public static void setOrientation(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.view.Surface.staticClass, global::android.view.Surface._setOrientation8736, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _lockCanvas8737;
		public virtual global::android.graphics.Canvas lockCanvas(android.graphics.Rect arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallObjectMethodPtr(this, global::android.view.Surface._lockCanvas8737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Canvas>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.view.Surface.staticClass, global::android.view.Surface._lockCanvas8737, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlockCanvasAndPost8738;
		public virtual void unlockCanvasAndPost(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._unlockCanvasAndPost8738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._unlockCanvasAndPost8738, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unlockCanvas8739;
		public virtual void unlockCanvas(android.graphics.Canvas arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._unlockCanvas8739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._unlockCanvas8739, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLayer8740;
		public virtual void setLayer(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setLayer8740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setLayer8740, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPosition8741;
		public virtual void setPosition(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setPosition8741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setPosition8741, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTransparentRegionHint8742;
		public virtual void setTransparentRegionHint(android.graphics.Region arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setTransparentRegionHint8742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setTransparentRegionHint8742, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _freeze8743;
		public virtual void freeze() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._freeze8743);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._freeze8743);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unfreeze8744;
		public virtual void unfreeze() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._unfreeze8744);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._unfreeze8744);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setFreezeTint8745;
		public virtual void setFreezeTint(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.view.Surface._setFreezeTint8745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.view.Surface.staticClass, global::android.view.Surface._setFreezeTint8745, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR8746;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.view.Surface.staticClass = @__class;
			global::android.view.Surface._toString8725 = @__env.GetMethodID(global::android.view.Surface.staticClass, "toString", "()Ljava/lang/String;");
			global::android.view.Surface._setSize8726 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setSize", "(II)V");
			global::android.view.Surface._isValid8727 = @__env.GetMethodID(global::android.view.Surface.staticClass, "isValid", "()Z");
			global::android.view.Surface._writeToParcel8728 = @__env.GetMethodID(global::android.view.Surface.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.view.Surface._describeContents8729 = @__env.GetMethodID(global::android.view.Surface.staticClass, "describeContents", "()I");
			global::android.view.Surface._setFlags8730 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setFlags", "(II)V");
			global::android.view.Surface._readFromParcel8731 = @__env.GetMethodID(global::android.view.Surface.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.view.Surface._setAlpha8732 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setAlpha", "(F)V");
			global::android.view.Surface._setMatrix8733 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setMatrix", "(FFFF)V");
			global::android.view.Surface._show8734 = @__env.GetMethodID(global::android.view.Surface.staticClass, "show", "()V");
			global::android.view.Surface._hide8735 = @__env.GetMethodID(global::android.view.Surface.staticClass, "hide", "()V");
			global::android.view.Surface._setOrientation8736 = @__env.GetStaticMethodID(global::android.view.Surface.staticClass, "setOrientation", "(II)V");
			global::android.view.Surface._lockCanvas8737 = @__env.GetMethodID(global::android.view.Surface.staticClass, "lockCanvas", "(Landroid/graphics/Rect;)Landroid/graphics/Canvas;");
			global::android.view.Surface._unlockCanvasAndPost8738 = @__env.GetMethodID(global::android.view.Surface.staticClass, "unlockCanvasAndPost", "(Landroid/graphics/Canvas;)V");
			global::android.view.Surface._unlockCanvas8739 = @__env.GetMethodID(global::android.view.Surface.staticClass, "unlockCanvas", "(Landroid/graphics/Canvas;)V");
			global::android.view.Surface._setLayer8740 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setLayer", "(I)V");
			global::android.view.Surface._setPosition8741 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setPosition", "(II)V");
			global::android.view.Surface._setTransparentRegionHint8742 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setTransparentRegionHint", "(Landroid/graphics/Region;)V");
			global::android.view.Surface._freeze8743 = @__env.GetMethodID(global::android.view.Surface.staticClass, "freeze", "()V");
			global::android.view.Surface._unfreeze8744 = @__env.GetMethodID(global::android.view.Surface.staticClass, "unfreeze", "()V");
			global::android.view.Surface._setFreezeTint8745 = @__env.GetMethodID(global::android.view.Surface.staticClass, "setFreezeTint", "(I)V");
		}
	}
}
