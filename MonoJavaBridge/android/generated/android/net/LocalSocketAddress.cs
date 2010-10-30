namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LocalSocketAddress : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LocalSocketAddress(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Namespace : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Namespace(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values7692;
			public static global::android.net.LocalSocketAddress.Namespace[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.LocalSocketAddress.Namespace._values7692.native == global::System.IntPtr.Zero)
					global::android.net.LocalSocketAddress.Namespace._values7692 = @__env.GetStaticMethodIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "values", "()[Landroid/net/LocalSocketAddress/Namespace;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.LocalSocketAddress.Namespace>(@__env.CallStaticObjectMethod(android.net.LocalSocketAddress.Namespace.staticClass, global::android.net.LocalSocketAddress.Namespace._values7692)) as android.net.LocalSocketAddress.Namespace[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7693;
			public static global::android.net.LocalSocketAddress.Namespace valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.LocalSocketAddress.Namespace._valueOf7693.native == global::System.IntPtr.Zero)
					global::android.net.LocalSocketAddress.Namespace._valueOf7693 = @__env.GetStaticMethodIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/LocalSocketAddress$Namespace;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.LocalSocketAddress.Namespace>(@__env.CallStaticObjectMethod(android.net.LocalSocketAddress.Namespace.staticClass, global::android.net.LocalSocketAddress.Namespace._valueOf7693, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.LocalSocketAddress.Namespace;
			}
			internal static global::MonoJavaBridge.FieldId _ABSTRACT7694;
			public static global::android.net.LocalSocketAddress.Namespace ABSTRACT
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.LocalSocketAddress.Namespace>(@__env.GetStaticObjectField(global::android.net.LocalSocketAddress.Namespace.staticClass, _ABSTRACT7694)) as android.net.LocalSocketAddress.Namespace;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FILESYSTEM7695;
			public static global::android.net.LocalSocketAddress.Namespace FILESYSTEM
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.LocalSocketAddress.Namespace>(@__env.GetStaticObjectField(global::android.net.LocalSocketAddress.Namespace.staticClass, _FILESYSTEM7695)) as android.net.LocalSocketAddress.Namespace;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RESERVED7696;
			public static global::android.net.LocalSocketAddress.Namespace RESERVED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.LocalSocketAddress.Namespace>(@__env.GetStaticObjectField(global::android.net.LocalSocketAddress.Namespace.staticClass, _RESERVED7696)) as android.net.LocalSocketAddress.Namespace;
				}
			}
			static Namespace()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.LocalSocketAddress.Namespace.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocketAddress$Namespace"));
				global::android.net.LocalSocketAddress.Namespace._ABSTRACT7694 = @__env.GetStaticFieldIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "ABSTRACT", "Landroid/net/LocalSocketAddress$Namespace;");
				global::android.net.LocalSocketAddress.Namespace._FILESYSTEM7695 = @__env.GetStaticFieldIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "FILESYSTEM", "Landroid/net/LocalSocketAddress$Namespace;");
				global::android.net.LocalSocketAddress.Namespace._RESERVED7696 = @__env.GetStaticFieldIDNoThrow(global::android.net.LocalSocketAddress.Namespace.staticClass, "RESERVED", "Landroid/net/LocalSocketAddress$Namespace;");
			}
			internal static void InitJNI()
			{
			}
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName7697;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.LocalSocketAddress.staticClass, "getName", "()Ljava/lang/String;", ref global::android.net.LocalSocketAddress._getName7697) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespace7698;
		public virtual global::android.net.LocalSocketAddress.Namespace getNamespace()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.LocalSocketAddress.Namespace>(this, global::android.net.LocalSocketAddress.staticClass, "getNamespace", "()Landroid/net/LocalSocketAddress$Namespace;", ref global::android.net.LocalSocketAddress._getNamespace7698) as android.net.LocalSocketAddress.Namespace;
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocketAddress7699;
		public LocalSocketAddress(java.lang.String arg0, android.net.LocalSocketAddress.Namespace arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.LocalSocketAddress._LocalSocketAddress7699.native == global::System.IntPtr.Zero)
				global::android.net.LocalSocketAddress._LocalSocketAddress7699 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocketAddress.staticClass, "<init>", "(Ljava/lang/String;Landroid/net/LocalSocketAddress$Namespace;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocketAddress.staticClass, global::android.net.LocalSocketAddress._LocalSocketAddress7699, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LocalSocketAddress7700;
		public LocalSocketAddress(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.net.LocalSocketAddress._LocalSocketAddress7700.native == global::System.IntPtr.Zero)
				global::android.net.LocalSocketAddress._LocalSocketAddress7700 = @__env.GetMethodIDNoThrow(global::android.net.LocalSocketAddress.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.net.LocalSocketAddress.staticClass, global::android.net.LocalSocketAddress._LocalSocketAddress7700, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LocalSocketAddress()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.LocalSocketAddress.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/LocalSocketAddress"));
		}
		internal static void InitJNI()
		{
		}
	}
}
