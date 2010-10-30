namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Typeface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Typeface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.Typeface.staticClass, "finalize", "()V", ref global::android.graphics.Typeface._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.graphics.Typeface create(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Typeface._m1.native == global::System.IntPtr.Zero)
				global::android.graphics.Typeface._m1 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.graphics.Typeface create(android.graphics.Typeface arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Typeface._m2.native == global::System.IntPtr.Zero)
				global::android.graphics.Typeface._m2 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		public new int Style
		{
			get
			{
				return getStyle();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getStyle()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.graphics.Typeface.staticClass, "getStyle", "()I", ref global::android.graphics.Typeface._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isBold()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Typeface.staticClass, "isBold", "()Z", ref global::android.graphics.Typeface._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isItalic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.Typeface.staticClass, "isItalic", "()Z", ref global::android.graphics.Typeface._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.graphics.Typeface defaultFromStyle(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Typeface._m6.native == global::System.IntPtr.Zero)
				global::android.graphics.Typeface._m6 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "defaultFromStyle", "(I)Landroid/graphics/Typeface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::android.graphics.Typeface createFromAsset(android.content.res.AssetManager arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Typeface._m7.native == global::System.IntPtr.Zero)
				global::android.graphics.Typeface._m7 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::android.graphics.Typeface createFromFile(java.io.File arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Typeface._m8.native == global::System.IntPtr.Zero)
				global::android.graphics.Typeface._m8 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static global::android.graphics.Typeface createFromFile(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.Typeface._m9.native == global::System.IntPtr.Zero)
				global::android.graphics.Typeface._m9 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT2411;
		public static global::android.graphics.Typeface DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _DEFAULT2411)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT_BOLD2412;
		public static global::android.graphics.Typeface DEFAULT_BOLD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _DEFAULT_BOLD2412)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SANS_SERIF2413;
		public static global::android.graphics.Typeface SANS_SERIF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _SANS_SERIF2413)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SERIF2414;
		public static global::android.graphics.Typeface SERIF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _SERIF2414)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONOSPACE2415;
		public static global::android.graphics.Typeface MONOSPACE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _MONOSPACE2415)) as android.graphics.Typeface;
			}
		}
		public static int NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int BOLD
		{
			get
			{
				return 1;
			}
		}
		public static int ITALIC
		{
			get
			{
				return 2;
			}
		}
		public static int BOLD_ITALIC
		{
			get
			{
				return 3;
			}
		}
		static Typeface()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Typeface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Typeface"));
			global::android.graphics.Typeface._DEFAULT2411 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "DEFAULT", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._DEFAULT_BOLD2412 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "DEFAULT_BOLD", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._SANS_SERIF2413 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "SANS_SERIF", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._SERIF2414 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "SERIF", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._MONOSPACE2415 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "MONOSPACE", "Landroid/graphics/Typeface;");
		}
		internal static void InitJNI()
		{
		}
	}
}
