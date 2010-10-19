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
		internal static global::MonoJavaBridge.MethodId _finalize3806;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.Typeface._finalize3806);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._finalize3806);
		}
		internal static global::MonoJavaBridge.MethodId _create3807;
		public static global::android.graphics.Typeface create(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create3807, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _create3808;
		public static global::android.graphics.Typeface create(android.graphics.Typeface arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create3808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		public new int Style
		{
			get
			{
				return getStyle();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStyle3809;
		public virtual int getStyle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.Typeface._getStyle3809);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._getStyle3809);
		}
		internal static global::MonoJavaBridge.MethodId _isBold3810;
		public virtual bool isBold() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Typeface._isBold3810);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isBold3810);
		}
		internal static global::MonoJavaBridge.MethodId _isItalic3811;
		public virtual bool isItalic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.Typeface._isItalic3811);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isItalic3811);
		}
		internal static global::MonoJavaBridge.MethodId _defaultFromStyle3812;
		public static global::android.graphics.Typeface defaultFromStyle(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._defaultFromStyle3812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _createFromAsset3813;
		public static global::android.graphics.Typeface createFromAsset(android.content.res.AssetManager arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromAsset3813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _createFromFile3814;
		public static global::android.graphics.Typeface createFromFile(java.io.File arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile3814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.MethodId _createFromFile3815;
		public static global::android.graphics.Typeface createFromFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile3815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.Typeface;
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT3816;
		public static global::android.graphics.Typeface DEFAULT
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DEFAULT_BOLD3817;
		public static global::android.graphics.Typeface DEFAULT_BOLD
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SANS_SERIF3818;
		public static global::android.graphics.Typeface SANS_SERIF
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SERIF3819;
		public static global::android.graphics.Typeface SERIF
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONOSPACE3820;
		public static global::android.graphics.Typeface MONOSPACE
		{
			get
			{
				return default(global::android.graphics.Typeface);
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
			global::android.graphics.Typeface._finalize3806 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "finalize", "()V");
			global::android.graphics.Typeface._create3807 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._create3808 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._getStyle3809 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "getStyle", "()I");
			global::android.graphics.Typeface._isBold3810 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "isBold", "()Z");
			global::android.graphics.Typeface._isItalic3811 = @__env.GetMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "isItalic", "()Z");
			global::android.graphics.Typeface._defaultFromStyle3812 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "defaultFromStyle", "(I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromAsset3813 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromFile3814 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromFile3815 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;");
		}
	}
}
