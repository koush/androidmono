namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyRep : java.lang.Object, java.io.Serializable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static KeyRep()
		{
			InitJNI();
		}
		protected KeyRep(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Type : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Type()
			{
				InitJNI();
			}
			internal Type(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values22939;
			public static global::java.security.KeyRep.Type[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.security.KeyRep.Type>(@__env.CallStaticObjectMethod(java.security.KeyRep.Type.staticClass, global::java.security.KeyRep.Type._values22939)) as java.security.KeyRep.Type[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf22940;
			public static global::java.security.KeyRep.Type valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.security.KeyRep.Type.staticClass, global::java.security.KeyRep.Type._valueOf22940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.security.KeyRep.Type;
			}
			internal static global::MonoJavaBridge.FieldId _SECRET22941;
			public static global::java.security.KeyRep.Type SECRET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.KeyRep.Type.staticClass, _SECRET22941)) as java.security.KeyRep.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PUBLIC22942;
			public static global::java.security.KeyRep.Type PUBLIC
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.KeyRep.Type.staticClass, _PUBLIC22942)) as java.security.KeyRep.Type;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PRIVATE22943;
			public static global::java.security.KeyRep.Type PRIVATE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::java.security.KeyRep.Type.staticClass, _PRIVATE22943)) as java.security.KeyRep.Type;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.KeyRep.Type.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyRep$Type"));
				global::java.security.KeyRep.Type._values22939 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyRep.Type.staticClass, "values", "()[Ljava/security/KeyRep/Type;");
				global::java.security.KeyRep.Type._valueOf22940 = @__env.GetStaticMethodIDNoThrow(global::java.security.KeyRep.Type.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/security/KeyRep$Type;");
				global::java.security.KeyRep.Type._SECRET22941 = @__env.GetStaticFieldIDNoThrow(global::java.security.KeyRep.Type.staticClass, "SECRET", "Ljava/security/KeyRep$Type;");
				global::java.security.KeyRep.Type._PUBLIC22942 = @__env.GetStaticFieldIDNoThrow(global::java.security.KeyRep.Type.staticClass, "PUBLIC", "Ljava/security/KeyRep$Type;");
				global::java.security.KeyRep.Type._PRIVATE22943 = @__env.GetStaticFieldIDNoThrow(global::java.security.KeyRep.Type.staticClass, "PRIVATE", "Ljava/security/KeyRep$Type;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _readResolve22944;
		protected virtual global::java.lang.Object readResolve() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.KeyRep._readResolve22944)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.KeyRep.staticClass, global::java.security.KeyRep._readResolve22944)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _KeyRep22945;
		public KeyRep(java.security.KeyRep.Type arg0, java.lang.String arg1, java.lang.String arg2, byte[] arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyRep.staticClass, global::java.security.KeyRep._KeyRep22945, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyRep.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyRep"));
			global::java.security.KeyRep._readResolve22944 = @__env.GetMethodIDNoThrow(global::java.security.KeyRep.staticClass, "readResolve", "()Ljava/lang/Object;");
			global::java.security.KeyRep._KeyRep22945 = @__env.GetMethodIDNoThrow(global::java.security.KeyRep.staticClass, "<init>", "(Ljava/security/KeyRep$Type;Ljava/lang/String;Ljava/lang/String;[B)V");
		}
	}
}
