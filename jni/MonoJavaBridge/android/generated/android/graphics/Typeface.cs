namespace android.graphics
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Typeface : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Typeface()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Typeface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.Typeface(@__env);
			}
		}
		protected Typeface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _create3616;
		public static global::android.graphics.Typeface create(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create3616, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _create3617;
		public static global::android.graphics.Typeface create(android.graphics.Typeface arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create3617, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStyle3618;
		public virtual int getStyle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.Typeface._getStyle3618);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._getStyle3618);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBold3619;
		public virtual bool isBold() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Typeface._isBold3619);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isBold3619);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isItalic3620;
		public virtual bool isItalic() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.Typeface._isItalic3620);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isItalic3620);
		}
		internal static global::net.sf.jni4net.jni.MethodId _defaultFromStyle3621;
		public static global::android.graphics.Typeface defaultFromStyle(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._defaultFromStyle3621, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromAsset3622;
		public static global::android.graphics.Typeface createFromAsset(android.content.res.AssetManager arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromAsset3622, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromFile3623;
		public static global::android.graphics.Typeface createFromFile(java.io.File arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile3623, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFromFile3624;
		public static global::android.graphics.Typeface createFromFile(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile3624, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.FieldId _DEFAULT3625;
		public static global::android.graphics.Typeface DEFAULT
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_BOLD3626;
		public static global::android.graphics.Typeface DEFAULT_BOLD
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SANS_SERIF3627;
		public static global::android.graphics.Typeface SANS_SERIF
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _SERIF3628;
		public static global::android.graphics.Typeface SERIF
		{
			get
			{
				return default(global::android.graphics.Typeface);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _MONOSPACE3629;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.Typeface.staticClass = @__class;
			global::android.graphics.Typeface._create3616 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._create3617 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._getStyle3618 = @__env.GetMethodID(global::android.graphics.Typeface.staticClass, "getStyle", "()I");
			global::android.graphics.Typeface._isBold3619 = @__env.GetMethodID(global::android.graphics.Typeface.staticClass, "isBold", "()Z");
			global::android.graphics.Typeface._isItalic3620 = @__env.GetMethodID(global::android.graphics.Typeface.staticClass, "isItalic", "()Z");
			global::android.graphics.Typeface._defaultFromStyle3621 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "defaultFromStyle", "(I)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromAsset3622 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromFile3623 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;");
			global::android.graphics.Typeface._createFromFile3624 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;");
		}
	}
}
