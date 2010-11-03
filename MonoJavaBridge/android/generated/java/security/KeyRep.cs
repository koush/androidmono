namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyRep : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyRep(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Type : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Type(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::java.security.KeyRep.Type[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyRep.Type._m0.native == global::System.IntPtr.Zero)
					global::java.security.KeyRep.Type._m0 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyRep.Type.staticClass, "values", "()[Ljava/security/KeyRep/Type;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.KeyRep.Type>(@__env.CallStaticObjectMethod(java.security.KeyRep.Type.staticClass, global::java.security.KeyRep.Type._m0)) as java.security.KeyRep.Type[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::java.security.KeyRep.Type valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.KeyRep.Type._m1.native == global::System.IntPtr.Zero)
					global::java.security.KeyRep.Type._m1 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyRep.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/security/KeyRep$Type;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyRep.Type>(@__env.CallStaticObjectMethod(java.security.KeyRep.Type.staticClass, global::java.security.KeyRep.Type._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyRep.Type;
			}
			internal static global::MonoJavaBridge.FieldId _SECRET6522;
			public static global::java.security.KeyRep.Type SECRET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyRep.Type>(@__env.GetStaticObjectField(global::java.security.KeyRep.Type.staticClass, _SECRET6522)) as java.security.KeyRep.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PUBLIC6523;
			public static global::java.security.KeyRep.Type PUBLIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyRep.Type>(@__env.GetStaticObjectField(global::java.security.KeyRep.Type.staticClass, _PUBLIC6523)) as java.security.KeyRep.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE6524;
			public static global::java.security.KeyRep.Type PRIVATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.security.KeyRep.Type>(@__env.GetStaticObjectField(global::java.security.KeyRep.Type.staticClass, _PRIVATE6524)) as java.security.KeyRep.Type;
				}
			}
			static Type()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyRep.Type.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyRep$Type"));
				global::java.security.KeyRep.Type._SECRET6522 = @__env.GetStaticFieldIDNoThrow(global::java.security.KeyRep.Type.staticClass, "SECRET", "Ljava/security/KeyRep$Type;");
				global::java.security.KeyRep.Type._PUBLIC6523 = @__env.GetStaticFieldIDNoThrow(global::java.security.KeyRep.Type.staticClass, "PUBLIC", "Ljava/security/KeyRep$Type;");
				global::java.security.KeyRep.Type._PRIVATE6524 = @__env.GetStaticFieldIDNoThrow(global::java.security.KeyRep.Type.staticClass, "PRIVATE", "Ljava/security/KeyRep$Type;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected virtual global::java.lang.Object readResolve()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.KeyRep.staticClass, "readResolve", "()Ljava/lang/Object;", ref global::java.security.KeyRep._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public KeyRep(java.security.KeyRep.Type arg0, java.lang.String arg1, java.lang.String arg2, byte[] arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyRep._m1.native == global::System.IntPtr.Zero)
				global::java.security.KeyRep._m1 = @__env.GetMethodIDNoThrow(global::java.security.KeyRep.staticClass, "<init>", "(Ljava/security/KeyRep$Type;Ljava/lang/String;Ljava/lang/String;[B)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyRep.staticClass, global::java.security.KeyRep._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static KeyRep()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyRep"));
		}
	}
}
