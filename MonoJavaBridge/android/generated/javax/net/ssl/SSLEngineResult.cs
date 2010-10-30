namespace javax.net.ssl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SSLEngineResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SSLEngineResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class HandshakeStatus : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal HandshakeStatus(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::javax.net.ssl.SSLEngineResult.HandshakeStatus._m0.native == global::System.IntPtr.Zero)
					global::javax.net.ssl.SSLEngineResult.HandshakeStatus._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/HandshakeStatus;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._m0)) as javax.net.ssl.SSLEngineResult.HandshakeStatus[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::javax.net.ssl.SSLEngineResult.HandshakeStatus._m1.native == global::System.IntPtr.Zero)
					global::javax.net.ssl.SSLEngineResult.HandshakeStatus._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, global::javax.net.ssl.SSLEngineResult.HandshakeStatus._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
			}
			internal static global::MonoJavaBridge.FieldId _NOT_HANDSHAKING7261;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NOT_HANDSHAKING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NOT_HANDSHAKING7261)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED7262;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus FINISHED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _FINISHED7262)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_TASK7263;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_TASK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_TASK7263)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_WRAP7264;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_WRAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_WRAP7264)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			internal static global::MonoJavaBridge.FieldId _NEED_UNWRAP7265;
			public static global::javax.net.ssl.SSLEngineResult.HandshakeStatus NEED_UNWRAP
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.HandshakeStatus>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, _NEED_UNWRAP7265)) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
				}
			}
			static HandshakeStatus()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$HandshakeStatus"));
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NOT_HANDSHAKING7261 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NOT_HANDSHAKING", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._FINISHED7262 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "FINISHED", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_TASK7263 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_TASK", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_WRAP7264 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_WRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
				global::javax.net.ssl.SSLEngineResult.HandshakeStatus._NEED_UNWRAP7265 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.HandshakeStatus.staticClass, "NEED_UNWRAP", "Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Status : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::javax.net.ssl.SSLEngineResult.Status[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::javax.net.ssl.SSLEngineResult.Status._m0.native == global::System.IntPtr.Zero)
					global::javax.net.ssl.SSLEngineResult.Status._m0 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "values", "()[Ljavax/net/ssl/SSLEngineResult/Status;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<javax.net.ssl.SSLEngineResult.Status>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._m0)) as javax.net.ssl.SSLEngineResult.Status[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::javax.net.ssl.SSLEngineResult.Status valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::javax.net.ssl.SSLEngineResult.Status._m1.native == global::System.IntPtr.Zero)
					global::javax.net.ssl.SSLEngineResult.Status._m1 = @__env.GetStaticMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "valueOf", "(Ljava/lang/String;)Ljavax/net/ssl/SSLEngineResult$Status;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.CallStaticObjectMethod(javax.net.ssl.SSLEngineResult.Status.staticClass, global::javax.net.ssl.SSLEngineResult.Status._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.net.ssl.SSLEngineResult.Status;
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_UNDERFLOW7266;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_UNDERFLOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _BUFFER_UNDERFLOW7266)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _BUFFER_OVERFLOW7267;
			public static global::javax.net.ssl.SSLEngineResult.Status BUFFER_OVERFLOW
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _BUFFER_OVERFLOW7267)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OK7268;
			public static global::javax.net.ssl.SSLEngineResult.Status OK
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _OK7268)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CLOSED7269;
			public static global::javax.net.ssl.SSLEngineResult.Status CLOSED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.net.ssl.SSLEngineResult.Status>(@__env.GetStaticObjectField(global::javax.net.ssl.SSLEngineResult.Status.staticClass, _CLOSED7269)) as javax.net.ssl.SSLEngineResult.Status;
				}
			}
			static Status()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.net.ssl.SSLEngineResult.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult$Status"));
				global::javax.net.ssl.SSLEngineResult.Status._BUFFER_UNDERFLOW7266 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "BUFFER_UNDERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._BUFFER_OVERFLOW7267 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "BUFFER_OVERFLOW", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._OK7268 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "OK", "Ljavax/net/ssl/SSLEngineResult$Status;");
				global::javax.net.ssl.SSLEngineResult.Status._CLOSED7269 = @__env.GetStaticFieldIDNoThrow(global::javax.net.ssl.SSLEngineResult.Status.staticClass, "CLOSED", "Ljavax/net/ssl/SSLEngineResult$Status;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.net.ssl.SSLEngineResult.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.net.ssl.SSLEngineResult._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::javax.net.ssl.SSLEngineResult.Status getStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.net.ssl.SSLEngineResult.Status>(this, global::javax.net.ssl.SSLEngineResult.staticClass, "getStatus", "()Ljavax/net/ssl/SSLEngineResult$Status;", ref global::javax.net.ssl.SSLEngineResult._m1) as javax.net.ssl.SSLEngineResult.Status;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::javax.net.ssl.SSLEngineResult.HandshakeStatus getHandshakeStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<javax.net.ssl.SSLEngineResult.HandshakeStatus>(this, global::javax.net.ssl.SSLEngineResult.staticClass, "getHandshakeStatus", "()Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;", ref global::javax.net.ssl.SSLEngineResult._m2) as javax.net.ssl.SSLEngineResult.HandshakeStatus;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int bytesConsumed()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLEngineResult.staticClass, "bytesConsumed", "()I", ref global::javax.net.ssl.SSLEngineResult._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int bytesProduced()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.net.ssl.SSLEngineResult.staticClass, "bytesProduced", "()I", ref global::javax.net.ssl.SSLEngineResult._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public SSLEngineResult(javax.net.ssl.SSLEngineResult.Status arg0, javax.net.ssl.SSLEngineResult.HandshakeStatus arg1, int arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.net.ssl.SSLEngineResult._m5.native == global::System.IntPtr.Zero)
				global::javax.net.ssl.SSLEngineResult._m5 = @__env.GetMethodIDNoThrow(global::javax.net.ssl.SSLEngineResult.staticClass, "<init>", "(Ljavax/net/ssl/SSLEngineResult$Status;Ljavax/net/ssl/SSLEngineResult$HandshakeStatus;II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.net.ssl.SSLEngineResult.staticClass, global::javax.net.ssl.SSLEngineResult._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SSLEngineResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.net.ssl.SSLEngineResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/net/ssl/SSLEngineResult"));
		}
		internal static void InitJNI()
		{
		}
	}
}
