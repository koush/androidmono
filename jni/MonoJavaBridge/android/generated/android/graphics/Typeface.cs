namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Typeface : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Typeface()
		{
			InitJNI();
		}
		protected Typeface(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize5787;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Typeface._finalize5787);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._finalize5787);
		}
		internal static global::MonoJavaBridge.MethodId _create5788;
		public static global::android.graphics.Typeface create(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create5788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _create5789;
		public static global::android.graphics.Typeface create(android.graphics.Typeface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create5789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		public new int Style
		{
			get
			{
				return getStyle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStyle5790;
		public virtual int getStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Typeface._getStyle5790);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._getStyle5790);
		}
		internal static global::MonoJavaBridge.MethodId _isBold5791;
		public virtual bool isBold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Typeface._isBold5791);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isBold5791);
		}
		internal static global::MonoJavaBridge.MethodId _isItalic5792;
		public virtual bool isItalic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Typeface._isItalic5792);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isItalic5792);
		}
		internal static global::MonoJavaBridge.MethodId _defaultFromStyle5793;
		public static global::android.graphics.Typeface defaultFromStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._defaultFromStyle5793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _createFromAsset5794;
		public static global::android.graphics.Typeface createFromAsset(android.content.res.AssetManager arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromAsset5794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _createFromFile5795;
		public static global::android.graphics.Typeface createFromFile(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile5795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _createFromFile5796;
		public static global::android.graphics.Typeface createFromFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile5796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT5797;
		public static global::android.graphics.Typeface DEFAULT
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _DEFAULT5797)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT_BOLD5798;
		public static global::android.graphics.Typeface DEFAULT_BOLD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _DEFAULT_BOLD5798)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SANS_SERIF5799;
		public static global::android.graphics.Typeface SANS_SERIF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _SANS_SERIF5799)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SERIF5800;
		public static global::android.graphics.Typeface SERIF
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _SERIF5800)) as android.graphics.Typeface;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONOSPACE5801;
		public static global::android.graphics.Typeface MONOSPACE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.graphics.Typeface.staticClass, _MONOSPACE5801)) as android.graphics.Typeface;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.Typeface.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/Typeface"));
			global::android.graphics.Typeface._finalize5787 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "finalize", "()V");
			global::android.graphics.Typeface._create5788 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._create5789 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._getStyle5790 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "getStyle", "()I");
			global::android.graphics.Typeface._isBold5791 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "isBold", "()Z");
			global::android.graphics.Typeface._isItalic5792 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "isItalic", "()Z");
			global::android.graphics.Typeface._defaultFromStyle5793 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "defaultFromStyle", "(I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromAsset5794 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromFile5795 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromFile5796 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._DEFAULT5797 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "DEFAULT", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._DEFAULT_BOLD5798 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "DEFAULT_BOLD", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._SANS_SERIF5799 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "SANS_SERIF", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._SERIF5800 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "SERIF", "Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._MONOSPACE5801 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.Typeface.staticClass, "MONOSPACE", "Landroid/graphics/Typeface;");
		}
	}
}
