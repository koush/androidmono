namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalSocketAddress : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LocalSocketAddress()
		{
			InitJNI();
		}
		protected LocalSocketAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Namespace : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Namespace()
			{
				InitJNI();
			}
			internal Namespace(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5181;
			public static global::android.net.LocalSocketAddress.Namespace[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.LocalSocketAddress.Namespace>(@__env.CallStaticObjectMethod(android.net.LocalSocketAddress.Namespace.staticClass, global::android.net.LocalSocketAddress.Namespace._values5181)) as android.net.LocalSocketAddress.Namespace[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5182;
			public static global::android.net.LocalSocketAddress.Namespace valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.LocalSocketAddress.Namespace.staticClass, global::android.net.LocalSocketAddress.Namespace._valueOf5182, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.LocalSocketAddress.Namespace;
			}
			internal static global::MonoJavaBridge.FieldId _ABSTRACT5183;
			public static global::android.net.LocalSocketAddress.Namespace ABSTRACT
			{
				get
				{
					return default(global::android.net.LocalSocketAddress.Namespace);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILESYSTEM5184;
			public static global::android.net.LocalSocketAddress.Namespace FILESYSTEM
			{
				get
				{
					return default(global::android.net.LocalSocketAddress.Namespace);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RESERVED5185;
			public static global::android.net.LocalSocketAddress.Namespace RESERVED
			{
				get
				{
					return default(global::android.net.LocalSocketAddress.Namespace);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.LocalSocketAddress.Namespace.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocketAddress$Namespace"));
				global::android.net.LocalSocketAddress.Namespace._values5181 = @__env.GetStaticMethodIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "values", "()[Landroid/net/LocalSocketAddress/Namespace;");
				global::android.net.LocalSocketAddress.Namespace._valueOf5182 = @__env.GetStaticMethodIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/LocalSocketAddress$Namespace;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName5186;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocketAddress._getName5186)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocketAddress.staticClass, global::android.net.LocalSocketAddress._getName5186)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace5187;
		public virtual global::android.net.LocalSocketAddress.Namespace getNamespace() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.LocalSocketAddress._getNamespace5187)) as android.net.LocalSocketAddress.Namespace;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.LocalSocketAddress.staticClass, global::android.net.LocalSocketAddress._getNamespace5187)) as android.net.LocalSocketAddress.Namespace;
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocketAddress5188;
		public LocalSocketAddress(java.lang.String arg0, android.net.LocalSocketAddress.Namespace arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocketAddress.staticClass, global::android.net.LocalSocketAddress._LocalSocketAddress5188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocketAddress5189;
		public LocalSocketAddress(java.lang.String arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocketAddress.staticClass, global::android.net.LocalSocketAddress._LocalSocketAddress5189, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalSocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocketAddress"));
			global::android.net.LocalSocketAddress._getName5186 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocketAddress.staticClass, "getName", "()Ljava/lang/String;");
			global::android.net.LocalSocketAddress._getNamespace5187 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocketAddress.staticClass, "getNamespace", "()Landroid/net/LocalSocketAddress$Namespace;");
			global::android.net.LocalSocketAddress._LocalSocketAddress5188 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocketAddress.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/LocalSocketAddress$Namespace;)V");
			global::android.net.LocalSocketAddress._LocalSocketAddress5189 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocketAddress.staticClass, "<init>", "(Ljava/lang/String;)V");
		}
	}
}
