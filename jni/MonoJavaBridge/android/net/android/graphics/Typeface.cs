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
		internal static global::net.sf.jni4net.jni.MethodId _create3417; 
		public static global::android.graphics.Typeface create(java.lang.String arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create3417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _create3418; 
		public static global::android.graphics.Typeface create(android.graphics.Typeface arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._create3418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStyle3419; 
		public virtual int getStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Typeface)) 
				return @__env.CallIntMethod(this, global::android.graphics.Typeface._getStyle3419); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._getStyle3419); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBold3420; 
		public virtual bool isBold() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Typeface)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Typeface._isBold3420); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isBold3420); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isItalic3421; 
		public virtual bool isItalic() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Typeface)) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Typeface._isItalic3421); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Typeface.staticClass, global::android.graphics.Typeface._isItalic3421); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _defaultFromStyle3422; 
		public static global::android.graphics.Typeface defaultFromStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._defaultFromStyle3422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromAsset3423; 
		public static global::android.graphics.Typeface createFromAsset(android.content.res.AssetManager arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromAsset3423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromFile3424; 
		public static global::android.graphics.Typeface createFromFile(java.io.File arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile3424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromFile3425; 
		public static global::android.graphics.Typeface createFromFile(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Typeface>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Typeface.staticClass, global::android.graphics.Typeface._createFromFile3425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DEFAULT3426; 
		public static global::android.graphics.Typeface DEFAULT
		{ 
			get 
			{ 
				return default(global::android.graphics.Typeface); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _DEFAULT_BOLD3427; 
		public static global::android.graphics.Typeface DEFAULT_BOLD
		{ 
			get 
			{ 
				return default(global::android.graphics.Typeface); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SANS_SERIF3428; 
		public static global::android.graphics.Typeface SANS_SERIF
		{ 
			get 
			{ 
				return default(global::android.graphics.Typeface); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _SERIF3429; 
		public static global::android.graphics.Typeface SERIF
		{ 
			get 
			{ 
				return default(global::android.graphics.Typeface); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _MONOSPACE3430; 
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
			global::android.graphics.Typeface._create3417 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "create", "(Ljava/lang/String;I)Landroid/graphics/Typeface;"); 
			global::android.graphics.Typeface._create3418 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "create", "(Landroid/graphics/Typeface;I)Landroid/graphics/Typeface;"); 
			global::android.graphics.Typeface._getStyle3419 = @__env.GetMethodID(global::android.graphics.Typeface.staticClass, "getStyle", "()I"); 
			global::android.graphics.Typeface._isBold3420 = @__env.GetMethodID(global::android.graphics.Typeface.staticClass, "isBold", "()Z"); 
			global::android.graphics.Typeface._isItalic3421 = @__env.GetMethodID(global::android.graphics.Typeface.staticClass, "isItalic", "()Z"); 
			global::android.graphics.Typeface._defaultFromStyle3422 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "defaultFromStyle", "(I)Landroid/graphics/Typeface;"); 
			global::android.graphics.Typeface._createFromAsset3423 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "createFromAsset", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Landroid/graphics/Typeface;"); 
			global::android.graphics.Typeface._createFromFile3424 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/io/File;)Landroid/graphics/Typeface;"); 
			global::android.graphics.Typeface._createFromFile3425 = @__env.GetStaticMethodID(global::android.graphics.Typeface.staticClass, "createFromFile", "(Ljava/lang/String;)Landroid/graphics/Typeface;"); 
		} 
	} 
} 
