namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class LocalSocketAddress : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static LocalSocketAddress() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.LocalSocketAddress), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.LocalSocketAddress(@__env); 
			} 
		} 
		protected LocalSocketAddress(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Namespace : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Namespace() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.LocalSocketAddress.Namespace), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.LocalSocketAddress.Namespace(@__env); 
				} 
			} 
			internal Namespace(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf4422; 
			public static android.net.LocalSocketAddress.Namespace valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress.Namespace>(@__env, @__env.CallStaticObjectMethodPtr(android.net.LocalSocketAddress.Namespace.staticClass, _valueOf4422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values4423; 
			public static android.net.LocalSocketAddress.Namespace[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.LocalSocketAddress.Namespace.staticClass, _values4423)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ABSTRACT4424; 
			public static android.net.LocalSocketAddress.Namespace ABSTRACT
			{ 
				get 
				{ 
					return default(android.net.LocalSocketAddress.Namespace); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FILESYSTEM4425; 
			public static android.net.LocalSocketAddress.Namespace FILESYSTEM
			{ 
				get 
				{ 
					return default(android.net.LocalSocketAddress.Namespace); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RESERVED4426; 
			public static android.net.LocalSocketAddress.Namespace RESERVED
			{ 
				get 
				{ 
					return default(android.net.LocalSocketAddress.Namespace); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.LocalSocketAddress.Namespace.staticClass = @__class; 
				global::android.net.LocalSocketAddress.Namespace._valueOf4422 = @__env.GetStaticMethodID(global::android.net.LocalSocketAddress.Namespace.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/LocalSocketAddress$Namespace;"); 
				global::android.net.LocalSocketAddress.Namespace._values4423 = @__env.GetStaticMethodID(global::android.net.LocalSocketAddress.Namespace.staticClass, "values", "()[Landroid/net/LocalSocketAddress/Namespace;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName4427; 
		public virtual java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocketAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName4427)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocketAddress.staticClass, _getName4427)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNamespace4428; 
		public virtual android.net.LocalSocketAddress.Namespace getNamespace() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.LocalSocketAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress.Namespace>(@__env, @__env.CallObjectMethodPtr(this, _getNamespace4428)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.LocalSocketAddress.Namespace>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.LocalSocketAddress.staticClass, _getNamespace4428)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalSocketAddress4429; 
		public LocalSocketAddress(java.lang.String arg0, android.net.LocalSocketAddress.Namespace arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalSocketAddress.staticClass, _LocalSocketAddress4429, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _LocalSocketAddress4430; 
		public LocalSocketAddress(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.LocalSocketAddress.staticClass, _LocalSocketAddress4430, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.LocalSocketAddress.staticClass = @__class; 
			global::android.net.LocalSocketAddress._getName4427 = @__env.GetMethodID(global::android.net.LocalSocketAddress.staticClass, "getName", "()Ljava/lang/String;"); 
			global::android.net.LocalSocketAddress._getNamespace4428 = @__env.GetMethodID(global::android.net.LocalSocketAddress.staticClass, "getNamespace", "()Landroid/net/LocalSocketAddress$Namespace;"); 
			global::android.net.LocalSocketAddress._LocalSocketAddress4429 = @__env.GetMethodID(global::android.net.LocalSocketAddress.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/LocalSocketAddress$Namespace;)V"); 
			global::android.net.LocalSocketAddress._LocalSocketAddress4430 = @__env.GetMethodID(global::android.net.LocalSocketAddress.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
