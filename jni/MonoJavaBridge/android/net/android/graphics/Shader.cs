namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Shader : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Shader() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Shader), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.Shader.TileMode), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3206; 
			public static android.graphics.Shader.TileMode valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Shader.TileMode>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Shader.TileMode.staticClass, _valueOf3206, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3207; 
			public static android.graphics.Shader.TileMode[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.Shader.TileMode.staticClass, _values3207)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CLAMP3208; 
			public static android.graphics.Shader.TileMode CLAMP
			{ 
				get 
				{ 
					return default(android.graphics.Shader.TileMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MIRROR3209; 
			public static android.graphics.Shader.TileMode MIRROR
			{ 
				get 
				{ 
					return default(android.graphics.Shader.TileMode); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _REPEAT3210; 
			public static android.graphics.Shader.TileMode REPEAT
			{ 
				get 
				{ 
					return default(android.graphics.Shader.TileMode); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.Shader.TileMode.staticClass = @__class; 
				global::android.graphics.Shader.TileMode._valueOf3206 = @__env.GetStaticMethodID(global::android.graphics.Shader.TileMode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/Shader$TileMode;"); 
				global::android.graphics.Shader.TileMode._values3207 = @__env.GetStaticMethodID(global::android.graphics.Shader.TileMode.staticClass, "values", "()[Landroid/graphics/Shader/TileMode;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalMatrix3211; 
		public virtual bool getLocalMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Shader)) 
				return @__env.CallBooleanMethod(this, _getLocalMatrix3211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.Shader.staticClass, _getLocalMatrix3211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLocalMatrix3212; 
		public virtual void setLocalMatrix(android.graphics.Matrix arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.Shader)) 
				@__env.CallVoidMethod(this, _setLocalMatrix3212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.Shader.staticClass, _setLocalMatrix3212, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Shader3213; 
		public Shader()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.Shader.staticClass, _Shader3213, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.Shader.staticClass = @__class; 
			global::android.graphics.Shader._getLocalMatrix3211 = @__env.GetMethodID(global::android.graphics.Shader.staticClass, "getLocalMatrix", "(Landroid/graphics/Matrix;)Z"); 
			global::android.graphics.Shader._setLocalMatrix3212 = @__env.GetMethodID(global::android.graphics.Shader.staticClass, "setLocalMatrix", "(Landroid/graphics/Matrix;)V"); 
			global::android.graphics.Shader._Shader3213 = @__env.GetMethodID(global::android.graphics.Shader.staticClass, "<init>", "()V"); 
		} 
	} 
} 
