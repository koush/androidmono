namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Resources : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Resources(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class NotFoundException : java.lang.RuntimeException
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected NotFoundException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public NotFoundException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.NotFoundException._m0.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.NotFoundException._m0 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._m0);
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public NotFoundException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.res.Resources.NotFoundException._m1.native == global::System.IntPtr.Zero)
					global::android.content.res.Resources.NotFoundException._m1 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.NotFoundException.staticClass, "<init>", "(Ljava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Resources.NotFoundException.staticClass, global::android.content.res.Resources.NotFoundException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static NotFoundException()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.Resources.NotFoundException.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Resources$NotFoundException"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Theme : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Theme(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public void dump(int arg0, java.lang.String arg1, java.lang.String arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, "dump", "(ILjava/lang/String;Ljava/lang/String;)V", ref global::android.content.res.Resources.Theme._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public global::android.content.res.TypedArray obtainStyledAttributes(int[] arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", ref global::android.content.res.Resources.Theme._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.TypedArray;
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public global::android.content.res.TypedArray obtainStyledAttributes(int arg0, int[] arg1)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", ref global::android.content.res.Resources.Theme._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public global::android.content.res.TypedArray obtainStyledAttributes(android.util.AttributeSet arg0, int[] arg1, int arg2, int arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.Theme.staticClass, "obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", ref global::android.content.res.Resources.Theme._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.content.res.TypedArray;
			}
			public new global::android.content.res.Resources.Theme To
			{
				set
				{
					setTo(value);
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public void setTo(android.content.res.Resources.Theme arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, "setTo", "(Landroid/content/res/Resources$Theme;)V", ref global::android.content.res.Resources.Theme._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public void applyStyle(int arg0, bool arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.Theme.staticClass, "applyStyle", "(IZ)V", ref global::android.content.res.Resources.Theme._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public bool resolveAttribute(int arg0, android.util.TypedValue arg1, bool arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.Resources.Theme.staticClass, "resolveAttribute", "(ILandroid/util/TypedValue;Z)Z", ref global::android.content.res.Resources.Theme._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			static Theme()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.res.Resources.Theme.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Resources$Theme"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual bool getBoolean(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.content.res.Resources.staticClass, "getBoolean", "(I)Z", ref global::android.content.res.Resources._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void getValue(int arg0, android.util.TypedValue arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "getValue", "(ILandroid/util/TypedValue;Z)V", ref global::android.content.res.Resources._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void getValue(java.lang.String arg0, android.util.TypedValue arg1, bool arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "getValue", "(Ljava/lang/String;Landroid/util/TypedValue;Z)V", ref global::android.content.res.Resources._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getInteger(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, "getInteger", "(I)I", ref global::android.content.res.Resources._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.content.res.Resources._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::java.lang.String getString(int arg0, java.lang.Object[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", ref global::android.content.res.Resources._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getIdentifier(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, "getIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)I", ref global::android.content.res.Resources._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.content.res.AssetManager Assets
		{
			get
			{
				return getAssets();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.content.res.AssetManager getAssets()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.AssetManager>(this, global::android.content.res.Resources.staticClass, "getAssets", "()Landroid/content/res/AssetManager;", ref global::android.content.res.Resources._m7) as android.content.res.AssetManager;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::java.lang.CharSequence getText(int arg0, java.lang.CharSequence arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, "getText", "(ILjava/lang/CharSequence;)Ljava/lang/CharSequence;", ref global::android.content.res.Resources._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		public java.lang.CharSequence getText(int arg0, string arg1)
		{
			return getText(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::java.lang.CharSequence getText(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, "getText", "(I)Ljava/lang/CharSequence;", ref global::android.content.res.Resources._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence;
		}
		public static global::android.content.res.Resources System
		{
			get
			{
				return getSystem();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.content.res.Resources getSystem()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._m10.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._m10 = @__env.GetStaticMethodIDNoThrow(global::android.content.res.Resources.staticClass, "getSystem", "()Landroid/content/res/Resources;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.res.Resources.staticClass, global::android.content.res.Resources._m10)) as android.content.res.Resources;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.CharSequence getQuantityText(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, "getQuantityText", "(II)Ljava/lang/CharSequence;", ref global::android.content.res.Resources._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.CharSequence;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1, java.lang.Object[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getQuantityString", "(II[Ljava/lang/Object;)Ljava/lang/String;", ref global::android.content.res.Resources._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual global::java.lang.String getQuantityString(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getQuantityString", "(II)Ljava/lang/String;", ref global::android.content.res.Resources._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.CharSequence>(this, global::android.content.res.Resources.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;", ref global::android.content.res.Resources._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.CharSequence[];
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String[] getStringArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getStringArray", "(I)[Ljava/lang/String;", ref global::android.content.res.Resources._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual int[] getIntArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.content.res.Resources.staticClass, "getIntArray", "(I)[I", ref global::android.content.res.Resources._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::android.content.res.TypedArray obtainTypedArray(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "obtainTypedArray", "(I)Landroid/content/res/TypedArray;", ref global::android.content.res.Resources._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual float getDimension(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.Resources.staticClass, "getDimension", "(I)F", ref global::android.content.res.Resources._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual int getDimensionPixelOffset(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, "getDimensionPixelOffset", "(I)I", ref global::android.content.res.Resources._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual int getDimensionPixelSize(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, "getDimensionPixelSize", "(I)I", ref global::android.content.res.Resources._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual float getFraction(int arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.content.res.Resources.staticClass, "getFraction", "(III)F", ref global::android.content.res.Resources._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;", ref global::android.content.res.Resources._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual global::android.graphics.Movie getMovie(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "getMovie", "(I)Landroid/graphics/Movie;", ref global::android.content.res.Resources._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.graphics.Movie;
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual int getColor(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.res.Resources.staticClass, "getColor", "(I)I", ref global::android.content.res.Resources._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;", ref global::android.content.res.Resources._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.ColorStateList;
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual global::android.content.res.XmlResourceParser getLayout(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.Resources.staticClass, "getLayout", "(I)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.Resources._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual global::android.content.res.XmlResourceParser getAnimation(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.Resources.staticClass, "getAnimation", "(I)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.Resources._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual global::android.content.res.XmlResourceParser getXml(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.content.res.XmlResourceParser>(this, global::android.content.res.Resources.staticClass, "getXml", "(I)Landroid/content/res/XmlResourceParser;", ref global::android.content.res.Resources._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.XmlResourceParser;
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual global::java.io.InputStream openRawResource(int arg0, android.util.TypedValue arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "openRawResource", "(ILandroid/util/TypedValue;)Ljava/io/InputStream;", ref global::android.content.res.Resources._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual global::java.io.InputStream openRawResource(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "openRawResource", "(I)Ljava/io/InputStream;", ref global::android.content.res.Resources._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.io.InputStream;
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::android.content.res.AssetFileDescriptor openRawResourceFd(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "openRawResourceFd", "(I)Landroid/content/res/AssetFileDescriptor;", ref global::android.content.res.Resources._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.content.res.AssetFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual global::android.content.res.Resources.Theme newTheme()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Resources.Theme>(this, global::android.content.res.Resources.staticClass, "newTheme", "()Landroid/content/res/Resources$Theme;", ref global::android.content.res.Resources._m32) as android.content.res.Resources.Theme;
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual global::android.content.res.TypedArray obtainAttributes(android.util.AttributeSet arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "obtainAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", ref global::android.content.res.Resources._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.content.res.TypedArray;
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual void updateConfiguration(android.content.res.Configuration arg0, android.util.DisplayMetrics arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "updateConfiguration", "(Landroid/content/res/Configuration;Landroid/util/DisplayMetrics;)V", ref global::android.content.res.Resources._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.util.DisplayMetrics DisplayMetrics
		{
			get
			{
				return getDisplayMetrics();
			}
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual global::android.util.DisplayMetrics getDisplayMetrics()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.res.Resources.staticClass, "getDisplayMetrics", "()Landroid/util/DisplayMetrics;", ref global::android.content.res.Resources._m35) as android.util.DisplayMetrics;
		}
		public new global::android.content.res.Configuration Configuration
		{
			get
			{
				return getConfiguration();
			}
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual global::android.content.res.Configuration getConfiguration()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.content.res.Configuration>(this, global::android.content.res.Resources.staticClass, "getConfiguration", "()Landroid/content/res/Configuration;", ref global::android.content.res.Resources._m36) as android.content.res.Configuration;
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual global::java.lang.String getResourceName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getResourceName", "(I)Ljava/lang/String;", ref global::android.content.res.Resources._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual global::java.lang.String getResourcePackageName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getResourcePackageName", "(I)Ljava/lang/String;", ref global::android.content.res.Resources._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual global::java.lang.String getResourceTypeName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getResourceTypeName", "(I)Ljava/lang/String;", ref global::android.content.res.Resources._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::java.lang.String getResourceEntryName(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.content.res.Resources.staticClass, "getResourceEntryName", "(I)Ljava/lang/String;", ref global::android.content.res.Resources._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual void parseBundleExtras(android.content.res.XmlResourceParser arg0, android.os.Bundle arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "parseBundleExtras", "(Landroid/content/res/XmlResourceParser;Landroid/os/Bundle;)V", ref global::android.content.res.Resources._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual void parseBundleExtra(java.lang.String arg0, android.util.AttributeSet arg1, android.os.Bundle arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "parseBundleExtra", "(Ljava/lang/String;Landroid/util/AttributeSet;Landroid/os/Bundle;)V", ref global::android.content.res.Resources._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual void flushLayoutCache()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "flushLayoutCache", "()V", ref global::android.content.res.Resources._m43);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual void finishPreloading()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.res.Resources.staticClass, "finishPreloading", "()V", ref global::android.content.res.Resources._m44);
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public Resources(android.content.res.AssetManager arg0, android.util.DisplayMetrics arg1, android.content.res.Configuration arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.res.Resources._m45.native == global::System.IntPtr.Zero)
				global::android.content.res.Resources._m45 = @__env.GetMethodIDNoThrow(global::android.content.res.Resources.staticClass, "<init>", "(Landroid/content/res/AssetManager;Landroid/util/DisplayMetrics;Landroid/content/res/Configuration;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.res.Resources.staticClass, global::android.content.res.Resources._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Resources()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.Resources.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/Resources"));
		}
	}
}
