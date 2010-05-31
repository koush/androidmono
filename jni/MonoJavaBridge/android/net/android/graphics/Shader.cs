namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Shader : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Shader() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Shader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.Shader(@__env); 
			} 
		} 
		protected Shader(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class TileMode : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static TileMode() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.Shader.TileMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.Shader.TileMode(@__env); 
				} 
			} 
			internal TileMode(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3406; 
			public static global::android.graphics.Shader.TileMode valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Shader.TileMode.staticClass, global::android.graphics.Shader.TileMode._valueOf3406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3407; 
			public static global::android.graphics.Shader.TileMode[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Shader.TileMode.staticClass, global::android.graphics.Shader.TileMode._values3407)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLAMP3408; 
			public static global::android.graphics.Shader.TileMode CLAMP
			{ 
				get 
				{ 
					return default(global::android.graphics.Shader.TileMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MIRROR3409; 
			public static global::android.graphics.Shader.TileMode MIRROR
			{ 
				get 
				{ 
					return default(global::android.graphics.Shader.TileMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _REPEAT3410; 
			public static global::android.graphics.Shader.TileMode REPEAT
			{ 
				get 
				{ 
					return default(global::android.graphics.Shader.TileMode); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Shader.TileMode.staticClass = @__class; 
				global::android.graphics.Shader.TileMode._valueOf3406 = @__env.GetStaticMethodID(global::android.graphics.Shader.TileMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Shader$TileMode;"); 
				global::android.graphics.Shader.TileMode._values3407 = @__env.GetStaticMethodID(global::android.graphics.Shader.TileMode.staticClass, "values", "()[Landroid/graphics/Shader/TileMode;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalMatrix3411; 
		public virtual bool getLocalMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.graphics.Shader._getLocalMatrix3411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.Shader.staticClass, global::android.graphics.Shader._getLocalMatrix3411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocalMatrix3412; 
		public virtual void setLocalMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.graphics.Shader._setLocalMatrix3412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.Shader.staticClass, global::android.graphics.Shader._setLocalMatrix3412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Shader3413; 
		public Shader()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Shader.staticClass, global::android.graphics.Shader._Shader3413, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Shader.staticClass = @__class; 
			global::android.graphics.Shader._getLocalMatrix3411 = @__env.GetMethodID(global::android.graphics.Shader.staticClass, "getLocalMatrix", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Shader._setLocalMatrix3412 = @__env.GetMethodID(global::android.graphics.Shader.staticClass, "setLocalMatrix", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Shader._Shader3413 = @__env.GetMethodID(global::android.graphics.Shader.staticClass, "<init>", "()V"); 
		} 
	} 
} 
