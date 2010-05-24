namespace android.opengl 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class GLUtils : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GLUtils() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.opengl.GLUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.opengl.GLUtils(@__env); 
			} 
		} 
		internal GLUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType5303; 
		public static int getType(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, _getType5303, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInternalFormat5304; 
		public static int getInternalFormat(android.graphics.Bitmap arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.opengl.GLUtils.staticClass, _getInternalFormat5304, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _texImage2D5305; 
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4, int arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, _texImage2D5305, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _texImage2D5306; 
		public static void texImage2D(int arg0, int arg1, int arg2, android.graphics.Bitmap arg3, int arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, _texImage2D5306, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _texImage2D5307; 
		public static void texImage2D(int arg0, int arg1, android.graphics.Bitmap arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, _texImage2D5307, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _texSubImage2D5308; 
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, _texSubImage2D5308, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _texSubImage2D5309; 
		public static void texSubImage2D(int arg0, int arg1, int arg2, int arg3, android.graphics.Bitmap arg4, int arg5, int arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.opengl.GLUtils.staticClass, _texSubImage2D5309, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.opengl.GLUtils.staticClass = @__class; 
			global::android.opengl.GLUtils._getType5303 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "getType", "(Landroid/graphics/Bitmap;)I"); 
			global::android.opengl.GLUtils._getInternalFormat5304 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "getInternalFormat", "(Landroid/graphics/Bitmap;)I"); 
			global::android.opengl.GLUtils._texImage2D5305 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;II)V"); 
			global::android.opengl.GLUtils._texImage2D5306 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IIILandroid/graphics/Bitmap;I)V"); 
			global::android.opengl.GLUtils._texImage2D5307 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "texImage2D", "(IILandroid/graphics/Bitmap;I)V"); 
			global::android.opengl.GLUtils._texSubImage2D5308 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;)V"); 
			global::android.opengl.GLUtils._texSubImage2D5309 = @__env.GetStaticMethodID(global::android.opengl.GLUtils.staticClass, "texSubImage2D", "(IIIILandroid/graphics/Bitmap;II)V"); 
		} 
	} 
} 
